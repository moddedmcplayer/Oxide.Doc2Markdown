// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Oxide.Doc2Markdown.Models;

using System.Collections;
using Microsoft.DocAsCode;
using Microsoft.DocAsCode.Dotnet;
using Newtonsoft.Json;

public enum MemberLayout
{
    /// <summary>
    /// Place members in the same page as their containing type
    /// </summary>
    SamePage,

    /// <summary>
    /// Place members in separate pages
    /// </summary>
    SeparatePages,
}

public enum NamespaceLayout
{
    /// <summary>
    /// Renders the namespaces as a single flat list
    /// </summary>
    Flattened,

    /// <summary>
    /// Renders the namespaces in a nested tree form
    /// </summary>
    Nested,
}

public class MetadataJsonItemConfig
{
    [JsonProperty("src")]
    public FileMapping Source { get; set; }

    [JsonProperty("dest")]
    public string Destination { get; set; }

    [JsonProperty("shouldSkipMarkup")]
    public bool? ShouldSkipMarkup { get; set; }

    [JsonProperty("raw")]
    public bool? Raw { get; set; }

    [JsonProperty("references")]
    public FileMapping References { get; set; }

    [JsonProperty("filter")]
    public string FilterConfigFile { get; set; }

    [JsonProperty("includePrivateMembers")]
    public bool IncludePrivateMembers { get; set; }

    [JsonProperty("globalNamespaceId")]
    public string GlobalNamespaceId { get; set; }

    /// <summary>
    /// An optional set of MSBuild properties used when interpreting project files. These
    ///  are the same properties that are passed to msbuild via the /property:&lt;n&gt;=&lt;v&gt;
    ///  command line argument.
    /// </summary>
    [JsonProperty("properties")]
    public Dictionary<string, string> MSBuildProperties { get; set; }

    [JsonProperty("disableGitFeatures")]
    public bool DisableGitFeatures { get; set; }

    [JsonProperty("codeSourceBasePath")]
    public string CodeSourceBasePath { get; set; }

    [JsonProperty("disableDefaultFilter")]
    public bool DisableDefaultFilter { get; set; }

    [JsonProperty("noRestore")]
    public bool NoRestore { get; set; }

    [JsonProperty("namespaceLayout")]
    public NamespaceLayout NamespaceLayout { get; set; }

    [JsonProperty("memberLayout")]
    public MemberLayout MemberLayout { get; set; }

    [JsonProperty("allowCompilationErrors")]
    public bool AllowCompilationErrors { get; set; }
}

public class MetadataJsonConfig : List<MetadataJsonItemConfig>
{
    public MetadataJsonConfig(IEnumerable<MetadataJsonItemConfig> configs) : base(configs) { }

    public MetadataJsonConfig(params MetadataJsonItemConfig[] configs) : base(configs)
    {
    }
}

public static class MetadataJsonConfigExtensions
{
    public static object ToMicrosoftMetadataJsonConfig(this MetadataJsonConfig input)
    {
        var originalItemType = typeof(MetadataJsonItemConfig);
        var type = typeof(DotnetApiCatalog).Assembly.GetType("Microsoft.DocAsCode.MetadataJsonConfig")!;
        var itemType = typeof(DotnetApiCatalog).Assembly.GetType("Microsoft.DocAsCode.MetadataJsonItemConfig")!;
        var paramType = typeof(List<>).MakeGenericType(itemType);
        var obj = Activator.CreateInstance(type, Activator.CreateInstance(paramType));
        var list = (IList)obj!;

        foreach (var configItem in input)
        {
            var itemObj = Activator.CreateInstance(itemType);
            foreach (var property in itemType.GetProperties())
            {
                var source = originalItemType.GetProperty(property.Name)!;
                property.SetValue(itemObj, source.GetValue(configItem, null), null);
            }

            list.Add(itemObj);
        }
        return obj!;
    }
}