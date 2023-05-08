namespace Oxide.Doc2Markdown.Models;

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.DocAsCode.DataContracts.ManagedReference;

public class MarkdownTemplateBase
{
    [NotNull]
    public static MarkdownTemplateBase? Default { get; private set; }
    public static List<MarkdownTemplateBase> EmbeddedTemplates { get; private set; } = new List<MarkdownTemplateBase>();
    public static void LoadEmbeddedTemplates()
    {
        EmbeddedTemplates.Clear();
        Dictionary<string, MarkdownTemplateBase> loaded = new Dictionary<string, MarkdownTemplateBase>();
        var assembly = Assembly.GetExecutingAssembly();
        var resources = assembly.GetManifestResourceNames().Select(x => x.Replace("Oxide.Doc2Markdown.", ""));
        foreach (var resource in resources)
        {
            if (!resource.EndsWith(".md"))
                continue;

            var split = resource.Split(".");
            string name = split[0];
            if (!loaded.TryGetValue(name, out var templateBase))
            {
                loaded.Add(name, new MarkdownTemplateBase(name));
                templateBase = loaded[name];
            }
            var type = split[1];
            if (!Enum.TryParse<MemberType>(type, true, out var templateType))
                continue;
            var stream = assembly.GetManifestResourceStream("Oxide.Doc2Markdown."+resource)!;
            using var reader = new StreamReader(stream);
            var content = reader.ReadToEnd();
            // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            templateBase._content ??= new Dictionary<MemberType, string>();
            templateBase._content.Add(templateType, content);
        }
        EmbeddedTemplates = loaded.Values.Where(x => x.Name != "Default").ToList();
        Default = loaded["Default"];
    }

    public string Name { get; }
    private Dictionary<MemberType, string> _content = null!;
    private MarkdownTemplateBase(string name)
    {
        Name = name;
    }
    public MarkdownTemplateBase(string name, Dictionary<MemberType, string> content)
    {
        Name = name;
        _content = content;
    }

    public virtual string GetText(MemberType type)
    {
        if (type == MemberType.Default)
            throw new InvalidEnumArgumentException(nameof(type), (int)type, typeof(MemberType));
        if (type == MemberType.Namespace)
            return _content[MemberType.Namespace];
        return !_content.ContainsKey(type) ? _content[MemberType.Class] : _content[type];
    }
}