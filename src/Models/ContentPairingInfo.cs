// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Oxide.Doc2Markdown.Models;

using Newtonsoft.Json;

[Serializable]
public class ContentPairingInfo
{
    [JsonProperty("contentFolder")]
    public string ContentFolder { get; set; }

    [JsonProperty("overwriteFragmentsFolder")]
    public string OverwriteFragmentsFolder { get; set; }
}