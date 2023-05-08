namespace Oxide.Doc2Markdown.Models;

using Newtonsoft.Json;

public class DocfxConfig
{
    [JsonProperty("build")]
    public BuildJsonConfig Build { get; set; } = new BuildJsonConfig();

    [JsonProperty("metadata")]
    public MetadataJsonConfig Metadata { get; set; } = new MetadataJsonConfig();
}