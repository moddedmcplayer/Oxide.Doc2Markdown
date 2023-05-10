namespace Oxide.Doc2Markdown;

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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (lines[i] == null)
                continue;
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

                int count;
                count = first.Type == MemberType.Namespace ?
                    WhereTypeType(model, Enum.Parse<MemberType>(type, true)).Count()
                    : WhereTypeMethod(model, Enum.Parse<MemberType>(type, true)).Count();
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

                if (first.Type == MemberType.Namespace)
                {
                    var models = WhereTypeType(model, Enum.Parse<MemberType>(type, true)).ToArray();
                    result.AddRange(models.SelectMany(member =>
                        Interpolate(split[2], _documentViewModels[member.Uid]).Split(new []{"\n", "\\n"}, StringSplitOptions.RemoveEmptyEntries)));
                }
                else
                {
                    var models = WhereTypeMethod(model, Enum.Parse<MemberType>(type, true)).ToArray();
                    result.AddRange(models.SelectMany(member =>
                        Interpolate(split[2], member).Split(new []{"\n", "\\n"}, StringSplitOptions.RemoveEmptyEntries)));
                }
                continue;
            }
            result.Add(Interpolate(lines[i], first));
        }

        return string.Join("\n", result);
    }

    private IEnumerable<ReferenceViewModel> WhereTypeType(PageViewModel model, MemberType type) => 
        model.References.Skip(1)
        .Where(x => _memberTypes.ContainsKey(x.Uid) && _memberTypes[x.Uid] == type);
    private IEnumerable<ItemViewModel> WhereTypeMethod(PageViewModel model, MemberType type) => 
        model.Items.Skip(1)
            .Where(x => x.Type == type);

    private static readonly List<string> DefaultBaseClasses = new List<string> { "System.Object" };
    private static readonly List<string> DefaultInheritedMethods = typeof(object).GetMethods().Select(x => string.Join(string.Empty, x.Name.TakeWhile(y => y != '('))).ToList();
    public static string Interpolate(string text, ItemViewModel model)
    {
        List<string> inherited = model.Inheritance ?? DefaultBaseClasses;
        List<string> inheritedMembers = model.InheritedMembers ?? DefaultInheritedMethods;
        return text
                .Replace("{name}", model.Name)
                .Replace("{namelinked}", $"[{model.Name}]({model.FullName}.md)")
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
                    string.Join(", ", inherited.Select(x => GetTypeLink(x))))
                .Replace("{examples}", string.Join("\n", model.Examples ?? new List<string>()))
                .Replace("{inheritedmembers}", string.Join(", ", inheritedMembers))
                .Replace("{inheritedmemberslinked}",
                    string.Join(", ", inheritedMembers.Select(x => GetBaseMethodLink(x, model))))
                .Replace("{sourceurl}", model.Source == null ? string.Empty : $"[Source]({model.Source.Remote.RemoteRepositoryUrl}/tree/{model.Source.Remote.RemoteBranch}/{model.Source.Remote.RelativePath}#L{model.Source.StartLine})")
                .Replace("{isextensionsmethod}", model.IsExtensionMethod ? "Yes" : "No")
                .Replace("{isexplicitinterfaceimplementation}", model.IsExplicitInterfaceImplementation ? "Yes" : "No")
                .Replace("{overriden}",  string.IsNullOrWhiteSpace(model.Overridden) ? string.Empty : "Overrides "+model.Overridden)
                .Replace("{parameterslist}", GetParameterList(model))
            ;
    }

    private static string GetParameterList(ItemViewModel model)
    {
        if (model.Type != MemberType.Method)
            return "not method";
        var parameters = model.Syntax?.Parameters?.ToArray();
        if (parameters == null || parameters.Length == 0)
            return "None";
        List<string> paramParsed = new List<string>();
        foreach (var param in parameters)
        {
            #warning attributes not handled
            paramParsed.Add($"{GetTypeLink(param.Type, true)} {param.Name} {param.Description}");
        }
        return string.Join("  \n", paramParsed);
    }

    public static void SetTargetFramework(string targetFramework) => _targetFramework = targetFramework;
    private static string _targetFramework = "net7.0";
    private static string GetTypeLink(string type, bool trimName = false)
    {
        if (type.Contains('('))
            return string.Empty;
        string fullName = type;
        if (trimName)
            type = type.Split('.').Last();
        if (fullName.StartsWith("System") || fullName.StartsWith("Microsoft"))
            return $"[{fullName}](https://learn.microsoft.com/en-us/dotnet/api/{fullName.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        string file = fullName + ".md";
        return File.Exists(file) ? $"[{type}]({file})" : type;
    }

    private static string GetBaseMethodLink(string fullMethodName, ItemViewModel model)
    {
        if (model.Inheritance == null || model.InheritedMembers == null)
            return "namespace";
        fullMethodName = string.Join("", fullMethodName.TakeWhile(y => y != '('));
        if (model.Inheritance.Count == 1 && model.Inheritance[0] == "System.Object" && DefaultInheritedMethods.Contains(fullMethodName))
            return $"[{fullMethodName}](https://learn.microsoft.com/en-us/dotnet/api/system.object.{fullMethodName.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        var split = fullMethodName.Split('.');
        string type = string.Join('.', split.SkipLast(1));
        string method = split.Last();
        if (type.StartsWith("System") || type.StartsWith("Microsoft"))
            return method.Contains('.') 
                ? $"[{method}](https://learn.microsoft.com/en-us/dotnet/api/{method.ToLower()}?view=net-{_targetFramework.Replace("net", "")})"
                : $"[{method}](https://learn.microsoft.com/en-us/dotnet/api/{type.ToLower()}.{method.ToLower()}?view=net-{_targetFramework.Replace("net", "")})";
        string file = type + ".md";
        return File.Exists(file) ? $"[{method}]({file}#{split.Last()})" : method;
    }
}