# Class CuiInputFieldComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiInputFieldComponent : ICuiComponent, ICuiColor
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public string Type { get; }
```
Type
```csharp
[JsonProperty("text")]
public string Text { get; set; }
```
Text
```csharp
[JsonProperty("fontSize")]
public int FontSize { get; set; }
```
FontSize
```csharp
[JsonProperty("font")]
public string Font { get; set; }
```
Font
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("align")]
public TextAnchor Align { get; set; }
```
Align
```csharp
public string Color { get; set; }
```
Color
```csharp
[JsonProperty("characterLimit")]
public int CharsLimit { get; set; }
```
CharsLimit
```csharp
[JsonProperty("command")]
public string Command { get; set; }
```
Command
```csharp
[JsonProperty("password")]
public bool IsPassword { get; set; }
```
IsPassword
```csharp
[JsonProperty("readOnly")]
public bool ReadOnly { get; set; }
```
ReadOnly
```csharp
[JsonProperty("needsKeyboard")]
public bool NeedsKeyboard { get; set; }
```
NeedsKeyboard
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("lineType")]
public InputField.LineType LineType { get; set; }
```
LineType
```csharp
[JsonProperty("autofocus")]
public bool Autofocus { get; set; }
```
Autofocus
```csharp
[JsonProperty("hudMenuInput")]
public bool HudMenuInput { get; set; }
```
HudMenuInput






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "id": "CuiInputFieldComponent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
        "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiInputFieldComponent",
      "nameWithType": "CuiInputFieldComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiInputFieldComponent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 355,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiInputFieldComponent : ICuiComponent, ICuiColor",
        "content.vb": "Public Class CuiInputFieldComponent Implements ICuiComponent, ICuiColor"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent",
        "Oxide.Game.Rust.Cui.ICuiColor"
      ],
      "inheritedMembers": [
        "System.Object.ToString",
        "System.Object.Equals(System.Object)",
        "System.Object.Equals(System.Object,System.Object)",
        "System.Object.ReferenceEquals(System.Object,System.Object)",
        "System.Object.GetHashCode",
        "System.Object.GetType",
        "System.Object.MemberwiseClone"
      ],
      "extensionMethods": [
        "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.GetColor",
        "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.SetColor(UnityEngine.Color)"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type",
      "id": "Type",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Type",
      "nameWithType": "CuiInputFieldComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Type",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 357,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public string Type { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property Type As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent.Type"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
      "id": "Text",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Text",
      "nameWithType": "CuiInputFieldComponent.Text",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Text",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 360,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"text\")]\npublic string Text { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"text\")>\nPublic Property Text As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "text"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
      "id": "FontSize",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FontSize",
      "nameWithType": "CuiInputFieldComponent.FontSize",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FontSize",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 364,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"fontSize\")]\npublic int FontSize { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "<JsonProperty(\"fontSize\")>\nPublic Property FontSize As Integer"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "fontSize"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
      "id": "Font",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Font",
      "nameWithType": "CuiInputFieldComponent.Font",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Font",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 368,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"font\")]\npublic string Font { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"font\")>\nPublic Property Font As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "font"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
      "id": "Align",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Align",
      "nameWithType": "CuiInputFieldComponent.Align",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Align",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 372,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonConverter(typeof(StringEnumConverter))]\n[JsonProperty(\"align\")]\npublic TextAnchor Align { get; set; }",
        "parameters": [],
        "return": {
          "type": "UnityEngine.TextAnchor"
        },
        "content.vb": "<JsonConverter(GetType(StringEnumConverter))>\n<JsonProperty(\"align\")>\nPublic Property Align As TextAnchor"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonConverterAttribute",
          "ctor": "Newtonsoft.Json.JsonConverterAttribute.#ctor(System.Type)",
          "arguments": [
            {
              "type": "System.Type",
              "value": "Newtonsoft.Json.Converters.StringEnumConverter"
            }
          ]
        },
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "align"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "CuiInputFieldComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 376,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public string Color { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Property Color As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
      "id": "CharsLimit",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CharsLimit",
      "nameWithType": "CuiInputFieldComponent.CharsLimit",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CharsLimit",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 378,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"characterLimit\")]\npublic int CharsLimit { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "<JsonProperty(\"characterLimit\")>\nPublic Property CharsLimit As Integer"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "characterLimit"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
      "id": "Command",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command",
      "nameWithType": "CuiInputFieldComponent.Command",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 381,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"command\")]\npublic string Command { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"command\")>\nPublic Property Command As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "command"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
      "id": "IsPassword",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsPassword",
      "nameWithType": "CuiInputFieldComponent.IsPassword",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsPassword",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 384,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"password\")]\npublic bool IsPassword { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"password\")>\nPublic Property IsPassword As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "password"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
      "id": "ReadOnly",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ReadOnly",
      "nameWithType": "CuiInputFieldComponent.ReadOnly",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ReadOnly",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 387,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"readOnly\")]\npublic bool ReadOnly { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"readOnly\")>\nPublic Property [ReadOnly] As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "readOnly"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
      "id": "NeedsKeyboard",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "NeedsKeyboard",
      "nameWithType": "CuiInputFieldComponent.NeedsKeyboard",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "NeedsKeyboard",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 390,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"needsKeyboard\")]\npublic bool NeedsKeyboard { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"needsKeyboard\")>\nPublic Property NeedsKeyboard As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "needsKeyboard"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
      "id": "LineType",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "LineType",
      "nameWithType": "CuiInputFieldComponent.LineType",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "LineType",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 393,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonConverter(typeof(StringEnumConverter))]\n[JsonProperty(\"lineType\")]\npublic InputField.LineType LineType { get; set; }",
        "parameters": [],
        "return": {
          "type": "UnityEngine.UI.InputField.LineType"
        },
        "content.vb": "<JsonConverter(GetType(StringEnumConverter))>\n<JsonProperty(\"lineType\")>\nPublic Property LineType As InputField.LineType"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonConverterAttribute",
          "ctor": "Newtonsoft.Json.JsonConverterAttribute.#ctor(System.Type)",
          "arguments": [
            {
              "type": "System.Type",
              "value": "Newtonsoft.Json.Converters.StringEnumConverter"
            }
          ]
        },
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "lineType"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
      "id": "Autofocus",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Autofocus",
      "nameWithType": "CuiInputFieldComponent.Autofocus",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Autofocus",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 397,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"autofocus\")]\npublic bool Autofocus { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"autofocus\")>\nPublic Property Autofocus As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "autofocus"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
      "id": "HudMenuInput",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiInputFieldComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "HudMenuInput",
      "nameWithType": "CuiInputFieldComponent.HudMenuInput",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "HudMenuInput",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 400,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"hudMenuInput\")]\npublic bool HudMenuInput { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"hudMenuInput\")>\nPublic Property HudMenuInput As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "hudMenuInput"
            }
          ]
        }
      ]
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Cui",
      "commentId": "N:Oxide.Game.Rust.Cui",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Cui",
      "nameWithType": "Oxide.Game.Rust.Cui",
      "fullName": "Oxide.Game.Rust.Cui",
      "spec.csharp": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": false,
          "href": "Oxide.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game",
          "name": "Game",
          "isExternal": false,
          "href": "Oxide.Game.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust",
          "name": "Rust",
          "isExternal": false,
          "href": "Oxide.Game.Rust.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui",
          "name": "Cui",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.html"
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": false,
          "href": "Oxide.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game",
          "name": "Game",
          "isExternal": false,
          "href": "Oxide.Game.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust",
          "name": "Rust",
          "isExternal": false,
          "href": "Oxide.Game.Rust.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui",
          "name": "Cui",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.html"
        }
      ]
    },
    {
      "uid": "System.Object",
      "commentId": "T:System.Object",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "object",
      "nameWithType": "object",
      "fullName": "object",
      "nameWithType.vb": "Object",
      "fullName.vb": "Object",
      "name.vb": "Object"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.ICuiComponent",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.ICuiComponent.html",
      "name": "ICuiComponent",
      "nameWithType": "ICuiComponent",
      "fullName": "Oxide.Game.Rust.Cui.ICuiComponent"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor",
      "commentId": "T:Oxide.Game.Rust.Cui.ICuiColor",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.ICuiColor.html",
      "name": "ICuiColor",
      "nameWithType": "ICuiColor",
      "fullName": "Oxide.Game.Rust.Cui.ICuiColor"
    },
    {
      "uid": "System.Object.ToString",
      "commentId": "M:System.Object.ToString",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring",
      "name": "ToString()",
      "nameWithType": "object.ToString()",
      "fullName": "object.ToString()",
      "nameWithType.vb": "Object.ToString()",
      "fullName.vb": "Object.ToString()",
      "spec.csharp": [
        {
          "uid": "System.Object.ToString",
          "name": "ToString",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.ToString",
          "name": "ToString",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.Equals(System.Object)",
      "commentId": "M:System.Object.Equals(System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)",
      "name": "Equals(object)",
      "nameWithType": "object.Equals(object)",
      "fullName": "object.Equals(object)",
      "nameWithType.vb": "Object.Equals(Object)",
      "fullName.vb": "Object.Equals(Object)",
      "name.vb": "Equals(Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.Equals(System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.Equals(System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.Equals(System.Object,System.Object)",
      "commentId": "M:System.Object.Equals(System.Object,System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)",
      "name": "Equals(object, object)",
      "nameWithType": "object.Equals(object, object)",
      "fullName": "object.Equals(object, object)",
      "nameWithType.vb": "Object.Equals(Object, Object)",
      "fullName.vb": "Object.Equals(Object, Object)",
      "name.vb": "Equals(Object, Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.Equals(System.Object,System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.Equals(System.Object,System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
      "commentId": "M:System.Object.ReferenceEquals(System.Object,System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals",
      "name": "ReferenceEquals(object, object)",
      "nameWithType": "object.ReferenceEquals(object, object)",
      "fullName": "object.ReferenceEquals(object, object)",
      "nameWithType.vb": "Object.ReferenceEquals(Object, Object)",
      "fullName.vb": "Object.ReferenceEquals(Object, Object)",
      "name.vb": "ReferenceEquals(Object, Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
          "name": "ReferenceEquals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
          "name": "ReferenceEquals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.GetHashCode",
      "commentId": "M:System.Object.GetHashCode",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode",
      "name": "GetHashCode()",
      "nameWithType": "object.GetHashCode()",
      "fullName": "object.GetHashCode()",
      "nameWithType.vb": "Object.GetHashCode()",
      "fullName.vb": "Object.GetHashCode()",
      "spec.csharp": [
        {
          "uid": "System.Object.GetHashCode",
          "name": "GetHashCode",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.GetHashCode",
          "name": "GetHashCode",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.GetType",
      "commentId": "M:System.Object.GetType",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype",
      "name": "GetType()",
      "nameWithType": "object.GetType()",
      "fullName": "object.GetType()",
      "nameWithType.vb": "Object.GetType()",
      "fullName.vb": "Object.GetType()",
      "spec.csharp": [
        {
          "uid": "System.Object.GetType",
          "name": "GetType",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.GetType",
          "name": "GetType",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.MemberwiseClone",
      "commentId": "M:System.Object.MemberwiseClone",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone",
      "name": "MemberwiseClone()",
      "nameWithType": "object.MemberwiseClone()",
      "fullName": "object.MemberwiseClone()",
      "nameWithType.vb": "Object.MemberwiseClone()",
      "fullName.vb": "Object.MemberwiseClone()",
      "spec.csharp": [
        {
          "uid": "System.Object.MemberwiseClone",
          "name": "MemberwiseClone",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.MemberwiseClone",
          "name": "MemberwiseClone",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.GetColor",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "definition": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "name": "GetColor(ICuiColor)",
      "nameWithType": "CuiHelper.GetColor(ICuiColor)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "spec.csharp": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
          "name": "GetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
          "name": "GetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.SetColor(UnityEngine.Color)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "definition": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "name": "SetColor(ICuiColor, Color)",
      "nameWithType": "CuiHelper.SetColor(ICuiColor, Color)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor, UnityEngine.Color)",
      "spec.csharp": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
          "name": "SetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.Color",
          "name": "Color",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
          "name": "SetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.Color",
          "name": "Color",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System",
      "commentId": "N:System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System",
      "nameWithType": "System",
      "fullName": "System"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "name": "GetColor(ICuiColor)",
      "nameWithType": "CuiHelper.GetColor(ICuiColor)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "spec.csharp": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
          "name": "GetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
          "name": "GetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiHelper",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html",
      "name": "CuiHelper",
      "nameWithType": "CuiHelper",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "isExternal": true,
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "name": "SetColor(ICuiColor, Color)",
      "nameWithType": "CuiHelper.SetColor(ICuiColor, Color)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor, UnityEngine.Color)",
      "spec.csharp": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
          "name": "SetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.Color",
          "name": "Color",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
          "name": "SetColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiColor",
          "name": "ICuiColor",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiColor.html"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.Color",
          "name": "Color",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type",
      "name": "Type",
      "nameWithType": "CuiInputFieldComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Type"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.ICuiComponent.Type",
      "parent": "Oxide.Game.Rust.Cui.ICuiComponent",
      "href": "Oxide.Game.Rust.Cui.ICuiComponent.html#Oxide.Game.Rust.Cui.ICuiComponent.Type",
      "name": "Type",
      "nameWithType": "ICuiComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.ICuiComponent.Type"
    },
    {
      "uid": "System.String",
      "commentId": "T:System.String",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "string",
      "nameWithType": "string",
      "fullName": "string",
      "nameWithType.vb": "String",
      "fullName.vb": "String",
      "name.vb": "String"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text",
      "name": "Text",
      "nameWithType": "CuiInputFieldComponent.Text",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Text"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize",
      "name": "FontSize",
      "nameWithType": "CuiInputFieldComponent.FontSize",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.FontSize"
    },
    {
      "uid": "System.Int32",
      "commentId": "T:System.Int32",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.int32",
      "name": "int",
      "nameWithType": "int",
      "fullName": "int",
      "nameWithType.vb": "Integer",
      "fullName.vb": "Integer",
      "name.vb": "Integer"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font",
      "name": "Font",
      "nameWithType": "CuiInputFieldComponent.Font",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Font"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align",
      "name": "Align",
      "nameWithType": "CuiInputFieldComponent.Align",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Align"
    },
    {
      "uid": "UnityEngine.TextAnchor",
      "commentId": "T:UnityEngine.TextAnchor",
      "parent": "UnityEngine",
      "isExternal": true,
      "name": "TextAnchor",
      "nameWithType": "TextAnchor",
      "fullName": "UnityEngine.TextAnchor"
    },
    {
      "uid": "UnityEngine",
      "commentId": "N:UnityEngine",
      "isExternal": true,
      "name": "UnityEngine",
      "nameWithType": "UnityEngine",
      "fullName": "UnityEngine"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color",
      "name": "Color",
      "nameWithType": "CuiInputFieldComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Color"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.ICuiColor.Color",
      "parent": "Oxide.Game.Rust.Cui.ICuiColor",
      "href": "Oxide.Game.Rust.Cui.ICuiColor.html#Oxide.Game.Rust.Cui.ICuiColor.Color",
      "name": "Color",
      "nameWithType": "ICuiColor.Color",
      "fullName": "Oxide.Game.Rust.Cui.ICuiColor.Color"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit",
      "name": "CharsLimit",
      "nameWithType": "CuiInputFieldComponent.CharsLimit",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.CharsLimit"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command",
      "name": "Command",
      "nameWithType": "CuiInputFieldComponent.Command",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Command"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword",
      "name": "IsPassword",
      "nameWithType": "CuiInputFieldComponent.IsPassword",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.IsPassword"
    },
    {
      "uid": "System.Boolean",
      "commentId": "T:System.Boolean",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.boolean",
      "name": "bool",
      "nameWithType": "bool",
      "fullName": "bool",
      "nameWithType.vb": "Boolean",
      "fullName.vb": "Boolean",
      "name.vb": "Boolean"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly",
      "name": "ReadOnly",
      "nameWithType": "CuiInputFieldComponent.ReadOnly",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.ReadOnly"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard",
      "name": "NeedsKeyboard",
      "nameWithType": "CuiInputFieldComponent.NeedsKeyboard",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.NeedsKeyboard"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType",
      "name": "LineType",
      "nameWithType": "CuiInputFieldComponent.LineType",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.LineType"
    },
    {
      "uid": "UnityEngine.UI.InputField.LineType",
      "commentId": "T:UnityEngine.UI.InputField.LineType",
      "parent": "UnityEngine.UI",
      "isExternal": true,
      "name": "InputField.LineType",
      "nameWithType": "InputField.LineType",
      "fullName": "UnityEngine.UI.InputField.LineType",
      "spec.csharp": [
        {
          "uid": "UnityEngine.UI.InputField",
          "name": "InputField",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI.InputField.LineType",
          "name": "LineType",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "UnityEngine.UI.InputField",
          "name": "InputField",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI.InputField.LineType",
          "name": "LineType",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "UnityEngine.UI",
      "commentId": "N:UnityEngine.UI",
      "isExternal": true,
      "name": "UnityEngine.UI",
      "nameWithType": "UnityEngine.UI",
      "fullName": "UnityEngine.UI",
      "spec.csharp": [
        {
          "uid": "UnityEngine",
          "name": "UnityEngine",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI",
          "name": "UI",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "UnityEngine",
          "name": "UnityEngine",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI",
          "name": "UI",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus",
      "name": "Autofocus",
      "nameWithType": "CuiInputFieldComponent.Autofocus",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.Autofocus"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
      "href": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.html#Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput",
      "name": "HudMenuInput",
      "nameWithType": "CuiInputFieldComponent.HudMenuInput",
      "fullName": "Oxide.Game.Rust.Cui.CuiInputFieldComponent.HudMenuInput"
    }
  ],
  "shouldSkipMarkup": false,
  "memberLayout": "samePage",
  "_systemKeys": [
    "uid",
    "isEii",
    "isExtensionMethod",
    "parent",
    "children",
    "href",
    "langs",
    "name",
    "nameWithType",
    "fullName",
    "type",
    "source",
    "documentation",
    "assemblies",
    "namespace",
    "summary",
    "remarks",
    "example",
    "syntax",
    "overridden",
    "overload",
    "exceptions",
    "seealso",
    "see",
    "inheritance",
    "derivedClasses",
    "level",
    "implements",
    "inheritedMembers",
    "extensionMethods",
    "conceptual",
    "platform",
    "attributes",
    "additionalNotes"
  ]
}