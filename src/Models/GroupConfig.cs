﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Oxide.Doc2Markdown.Models;

using Newtonsoft.Json;

[Serializable]
public class GroupConfig
{
    [JsonProperty("dest")]
    public string Destination { get; set; }

    [JsonProperty("xrefTags")]
    public ListWithStringFallback XrefTags { get; set; }

    [JsonExtensionData]
    public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
}