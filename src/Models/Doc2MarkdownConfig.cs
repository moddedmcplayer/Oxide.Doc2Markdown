namespace Oxide.Doc2Markdown.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
public enum FileType
{
    None,
    CSProject,
    Solution,
    Dll
}

public static class FileTypeExtensions
{
    public static string GetExtension(this FileType fileType) => fileType switch
    {
        FileType.CSProject => "*.csproj",
        FileType.Solution => "*.sln",
        FileType.Dll => "*.dll",
        _ => "*.*"
    };
}

public class Doc2MarkdownConfig
{
    public string Path { get; set; } = "";
    public FileType FileType { get; set; } = FileType.None;
    public string TargetFramework { get; set; } = "net48";
    public List<string> Exclude { get; set; } = new List<string>();
}