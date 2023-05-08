using System.Collections.Immutable;
using System.Reflection;
using Microsoft.DocAsCode;
using Microsoft.DocAsCode.Build.ManagedReference;
using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.Dotnet;
using Microsoft.DocAsCode.Plugins;
using Newtonsoft.Json;
using Oxide.Doc2Markdown;
using Oxide.Doc2Markdown.Models;

args = args.Select(x => x.ToLower()).ToArray();

if (args.Contains("init"))
{
    File.WriteAllText("doc2markdown.json", JsonConvert.SerializeObject(new Doc2MarkdownConfig(), Formatting.Indented));
    return;
}

Doc2MarkdownConfig config = null!;
try
{
    if (File.Exists("doc2markdown.json"))
    {
        config = JsonConvert.DeserializeObject<Doc2MarkdownConfig>(File.ReadAllText("doc2markdown.json")) ??
                 throw new NullReferenceException("doc2markdown.json null");
    }
    else
    {
        if (args.Length < 2 || !args.Where((_, i) => i != 0 && args[i - 1] == "--path").Any())
        {
            throw new ArgumentException("No doc2markdown.json found and no path specified.");
        }

        var path = args.Where((_, i) => i != 0 && args[i - 1] == "--path").FirstOrDefault();
        config.Path = path!;
        var fileType = args.Where((_, i) => i != 0 && args[i - 1] == "--type").FirstOrDefault();
        if (fileType != null)
        {
            if(Enum.TryParse<FileType>(fileType, true, out var ft))
            {
                config.FileType = ft;
            }
            else
            {
                throw new Exception($"Invalid file type: {fileType}");
            }
        }
        var targetFramework = args.Where((_, i) => i != 0 && args[i - 1] == "--target").FirstOrDefault();
        if (targetFramework != null)
        {
            config.TargetFramework = targetFramework;
        }
        var exclude = args.Where((_, i) => i != 0 && args[i - 1] == "--exclude").FirstOrDefault();
        if (exclude != null)
        {
            config.Exclude = exclude.Split(",").ToList();
        }
    }

    if (string.IsNullOrEmpty(config.Path))
    {
        throw new ArgumentException("Config path is null or empty. Use . for current directory.");
    }

    if (!Directory.Exists(config.Path))
    {
        throw new ArgumentException("Config path does not exist.");
    }
}
catch (Exception e)
{
    Console.WriteLine($"An error occured: {e}");
    Console.Read();
    return;
}

if (!args.Contains("--skip-docfx"))
{
    var sourceDir = new FileMapping();
    sourceDir.Add(new FileMappingItem()
    {
        Files = new FileItems(config.FileType.GetExtension()),
        SourceFolder = Path.GetFullPath(config.Path.Replace("/", "\\")),
        Exclude = new FileItems(config.Exclude)
    });
    Directory.CreateDirectory("doc2markdown");
    File.Create("doc2markdown/docfx.json").Close();
    FileModelsProcessor.SetTargetFramework(config.TargetFramework);
    var docfxConfig = new DocfxConfig()
    {
        Metadata = new MetadataJsonConfig()
        {
            new MetadataJsonItemConfig()
            {
                Source = sourceDir,
                Destination = "docfxout",
                ShouldSkipMarkup = false,
                MSBuildProperties = new Dictionary<string, string>()
                {
                    { "TargetFramework", config.TargetFramework }
                },
            }
        }
    };

    await using (var sr = new StreamWriter("doc2markdown/docfx.json"))
    {
        JsonUtility.Serialize(sr, config, Formatting.Indented);
    }

    Logger.RegisterListener(new ConsoleLogListener());
    ((Task)typeof(DotnetApiCatalog).GetMethod("Exec", BindingFlags.Static | BindingFlags.NonPublic)!.Invoke(null,
        new[]
        {
            docfxConfig.Metadata.ToMicrosoftMetadataJsonConfig(), new DotnetApiOptions(), "doc2markdown/docfx.json",
            "doc2markdown"
        })!).GetAwaiter().GetResult();
}

if (!args.Contains("--skip-markdown"))
{
    MarkdownTemplateBase.LoadEmbeddedTemplates();
    string[] articleFiles = Directory.GetFiles("doc2markdown/docfxout", "*.yml").Where(x => !x.EndsWith("toc.yml"))
        .ToArray();
    FileModel[] models = new FileModel[articleFiles.Length];
    var processor = new ManagedReferenceDocumentProcessor();
    string baseDir = Path.GetFullPath("doc2markdown/docfxout");
    EnvironmentContext.SetBaseDirectory("."); // another wtf microsoft moment
    for (int i = 0; i < articleFiles.Length; i++)
    {
        string articleFile = articleFiles[i];
        models[i] = processor.Load(new FileAndType(baseDir, articleFile, DocumentType.Article),
            new Dictionary<string, object>().ToImmutableDictionary());
    }

    Directory.CreateDirectory("doc2markdown/mdout");
    var modelProcessor = new FileModelsProcessor(models, MarkdownTemplateBase.Default);
    modelProcessor.Process("doc2markdown/mdout");
}

Console.WriteLine("Done!");