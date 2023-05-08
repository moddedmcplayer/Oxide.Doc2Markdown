# Class CuiTextComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiTextComponent : ICuiComponent, ICuiColor
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
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("verticalOverflow")]
public VerticalWrapMode VerticalOverflow { get; set; }
```
VerticalOverflow
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```
FadeIn






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiTextComponent",
      "id": "CuiTextComponent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiTextComponent.Align",
        "Oxide.Game.Rust.Cui.CuiTextComponent.Color",
        "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
        "Oxide.Game.Rust.Cui.CuiTextComponent.Font",
        "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
        "Oxide.Game.Rust.Cui.CuiTextComponent.Text",
        "Oxide.Game.Rust.Cui.CuiTextComponent.Type",
        "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiTextComponent",
      "nameWithType": "CuiTextComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiTextComponent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 228,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiTextComponent : ICuiComponent, ICuiColor",
        "content.vb": "Public Class CuiTextComponent Implements ICuiComponent, ICuiColor"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.Type",
      "id": "Type",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Type",
      "nameWithType": "CuiTextComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Type",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Type",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 230,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.Type*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent.Type"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Text",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.Text",
      "id": "Text",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Text",
      "nameWithType": "CuiTextComponent.Text",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Text",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Text",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 233,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.Text*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
      "id": "FontSize",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FontSize",
      "nameWithType": "CuiTextComponent.FontSize",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FontSize",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 237,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Font",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.Font",
      "id": "Font",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Font",
      "nameWithType": "CuiTextComponent.Font",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Font",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Font",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 241,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.Font*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Align",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.Align",
      "id": "Align",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Align",
      "nameWithType": "CuiTextComponent.Align",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Align",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Align",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 245,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.Align*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "CuiTextComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 249,
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
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.Color*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow",
      "id": "VerticalOverflow",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "VerticalOverflow",
      "nameWithType": "CuiTextComponent.VerticalOverflow",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "VerticalOverflow",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 251,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonConverter(typeof(StringEnumConverter))]\n[JsonProperty(\"verticalOverflow\")]\npublic VerticalWrapMode VerticalOverflow { get; set; }",
        "parameters": [],
        "return": {
          "type": "UnityEngine.VerticalWrapMode"
        },
        "content.vb": "<JsonConverter(GetType(StringEnumConverter))>\n<JsonProperty(\"verticalOverflow\")>\nPublic Property VerticalOverflow As VerticalWrapMode"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow*",
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
              "value": "verticalOverflow"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
      "id": "FadeIn",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiTextComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FadeIn",
      "nameWithType": "CuiTextComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FadeIn",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 255,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"fadeIn\")]\npublic float FadeIn { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Single"
        },
        "content.vb": "<JsonProperty(\"fadeIn\")>\nPublic Property FadeIn As Single"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "fadeIn"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Type*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.Type",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.Type",
      "name": "Type",
      "nameWithType": "CuiTextComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Type"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Text*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.Text",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.Text",
      "name": "Text",
      "nameWithType": "CuiTextComponent.Text",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Text"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.FontSize",
      "name": "FontSize",
      "nameWithType": "CuiTextComponent.FontSize",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.FontSize"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Font*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.Font",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.Font",
      "name": "Font",
      "nameWithType": "CuiTextComponent.Font",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Font"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Align*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.Align",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.Align",
      "name": "Align",
      "nameWithType": "CuiTextComponent.Align",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Align"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.Color",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.Color",
      "name": "Color",
      "nameWithType": "CuiTextComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.Color"
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
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow",
      "name": "VerticalOverflow",
      "nameWithType": "CuiTextComponent.VerticalOverflow",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.VerticalOverflow"
    },
    {
      "uid": "UnityEngine.VerticalWrapMode",
      "commentId": "T:UnityEngine.VerticalWrapMode",
      "parent": "UnityEngine",
      "isExternal": true,
      "name": "VerticalWrapMode",
      "nameWithType": "VerticalWrapMode",
      "fullName": "UnityEngine.VerticalWrapMode"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
      "href": "Oxide.Game.Rust.Cui.CuiTextComponent.html#Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn",
      "name": "FadeIn",
      "nameWithType": "CuiTextComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiTextComponent.FadeIn"
    },
    {
      "uid": "System.Single",
      "commentId": "T:System.Single",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "float",
      "nameWithType": "float",
      "fullName": "float",
      "nameWithType.vb": "Single",
      "fullName.vb": "Single",
      "name.vb": "Single"
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