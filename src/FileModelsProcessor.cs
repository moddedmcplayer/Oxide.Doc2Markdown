﻿namespace Oxide.Doc2Markdown;

using System.Collections.Immutable;
using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.DataContracts.Common;
using Microsoft.DocAsCode.DataContracts.ManagedReference;
using Microsoft.DocAsCode.Plugins;
using Newtonsoft.Json;
using Oxide.Doc2Markdown.Models;

public class FileModelsProcessor
{
    private FileModel[] _models;
    private MarkdownTemplateBase _template;
    private ImmutableDictionary<string, MemberType> _memberTypes;
    private ImmutableDictionary<string, ItemViewModel> _documentViewModels;

    public FileModelsProcessor(IEnumerable<FileModel> models, MarkdownTemplateBase template)
    {
        _models = models.ToArray();
        var modelsFirstItem = _models
            .Select(model => ((PageViewModel)model.Content).Items.First()).ToArray();
        _memberTypes = 
            modelsFirstItem.ToDictionary(key => key.Uid, value => value.Type!.Value).ToImmutableDictionary();
        _documentViewModels = 
            modelsFirstItem.ToDictionary(key => key.FullName).ToImmutableDictionary();
        _template = template;
    }

    public void Process(string outdir)
    {
        foreach (var model in _models)
        {
            string filePath = Path.Join(outdir, Path.GetFileNameWithoutExtension(model.Key) + ".md");
            File.Create(filePath).Close();
            using var sw = new StreamWriter(filePath);
            var content = (PageViewModel)model.Content;
            var type = content.Items.First().Type!.Value;
            try
            {
                sw.Write(ProcessText(_template.GetText(type), content));
            }
            catch (Exception e)
            {
                Logger.LogError($"Failed to process {model.Key}: {e}");
                throw;
            }
        }
    }

    private string ProcessText(string text, PageViewModel model)
    {
        var lines = text.Split("\n");
        var first = model.Items.First();
        List<string> result = new List<string>();
        for (var i = 0; i < lines.Length; i++)
        {
            if (lines[i].TrimEnd().EndsWith("hideifnone"))
            {
                var split = lines[i].Split(":");
                string type = split.Reverse().ElementAt(1);
                switch (type)
                {
                    case "seealso" when first.SeeAlsosUidReference == null || first.SeeAlsos.Count == 0:
                        continue;
                    case "seealso":
                        result.Add(Interpolate(split[0], first));
                        continue;
                    case "example" when first.Examples == null || first.Examples.Count == 0:
                        continue;
                    case "example":
                        result.Add(Interpolate(split[0], first));
                        continue;
                }

                int count = WhereType(model, Enum.Parse<MemberType>(type, true)).Count();
                if (count == 0)
                    continue;
                lines[i] = split[0];
            }
            else if (lines[i].StartsWith("foreach"))
            {
                var split = lines[i].Split(":");
                string type = split[1].Trim();
                switch (type)
                {
                    case "seealso" when first.SeeAlsosUidReference == null:
                        continue;
                    case "seealso":
                        result.AddRange(first.SeeAlsosUidReference.Select(x => Interpolate(split[2], _documentViewModels[x])));
                        continue;
                }

                var models = WhereType(model, Enum.Parse<MemberType>(type, true)).ToArray();

                result.AddRange(models.Select(member => Interpolate(split[2], _documentViewModels[member.Uid])));
                continue;
            }
            result.Add(Interpolate(lines[i], first));
        }

        return string.Join("\n", result) + '\n' + model.ToJsonString(Formatting.Indented);
    }

    private IEnumerable<ReferenceViewModel> WhereType(PageViewModel model, MemberType type) => 
        model.References.Skip(1)
        .Where(x => _memberTypes[x.Uid] == type);

    private static readonly List<string> DefaultBaseClasses = new List<string> { "System.Object" };
    private static readonly List<string> DefaultInheritedMethods = typeof(object).GetMethods().Select(x => string.Join(string.Empty, x.Name.TakeWhile(y => y != '('))).ToList();
    public static string Interpolate(string text, ItemViewModel model)
    {
        List<string> inherited = model.Inheritance ?? DefaultBaseClasses;
        List<string> inheritedMembers = model.InheritedMembers ?? DefaultInheritedMethods;
        return text
                .Replace("{name}", model.Name)
                .Replace("{namelinked}", $"[{model.Name}]({model.Id}.md)")
                .Replace("{namespace}", $"[{model.NamespaceName}]({model.NamespaceName}.md)")
                .Replace("{namespacelinked}", model.NamespaceName)
                .Replace("{assemblies}", string.Join(", ", model.AssemblyNameList.Select(x => x + ".dll")))
                .Replace("{codeblock}",
                    "```csharp\n" + (model.Syntax?.Content ?? $"namespace {model.NamespaceName}") + "\n```")
                .Replace("{summary}", model.Summary)
                .Replace("_{remarks}_",  string.IsNullOrWhiteSpace(model.Remarks) ? "" : "_Remarks: "+model.Remarks+"_")
                .Replace("{remarks}", string.IsNullOrWhiteSpace(model.Remarks) ? "" : "Remarks: "+model.Remarks)
                .Replace("{baseclasses}", string.Join(", ", inherited))
                .Replace("{baseclasseslinked}",
                    string.Join(", ", inherited.Select(GetTypeLink)))
                .Replace("{examples}", string.Join("\n", model.Examples ?? new List<string>()))
                .Replace("{inheritedmembers}", string.Join(", ", inheritedMembers))
                .Replace("{inheritedmemberslinked}",
                    string.Join(", ", inheritedMembers.Select(x => GetBaseMethodLink(x, model))))
            ;
    }

    public static void SetTargetFramework(string targetFramework) => _targetFramework = targetFramework;
    private static string _targetFramework = "net7.0";
    private static string GetTypeLink(string type)
    {
        if (type.StartsWith("System") || type.StartsWith("Microsoft"))
            return $"[{type}](https://learn.microsoft.com/en-us/dotnet/api/{type.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        string file = type + ".md";
        return File.Exists(file) ? $"[{type}]({file})" : type;
    }

    private static string GetBaseMethodLink(string fullMethodName, ItemViewModel model)
    {
        if (model.Inheritance == null || model.InheritedMembers == null)
            return "namespace";
        fullMethodName = string.Join("", fullMethodName.TakeWhile(y => y != '('));
        var split = fullMethodName.Split('.');
        string type = string.Join('.', split.SkipLast(1));
        if (model.Inheritance.Count == 1 && model.Inheritance[0] == "System.Object" && DefaultInheritedMethods.Contains(fullMethodName))
            return $"[{fullMethodName}](https://learn.microsoft.com/en-us/dotnet/api/system.object.{fullMethodName.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        string method = split.Last();
        if (type.StartsWith("System") || type.StartsWith("Microsoft"))
            return $"[{method}](https://learn.microsoft.com/en-us/dotnet/api/{method.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        string file = type + ".md";
        return File.Exists(file) ? $"[{method}]({file}#{split.Last()})" : method;
    }
}