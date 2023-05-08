# Class CuiButtonComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiButtonComponent : ICuiComponent, ICuiColor
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
[JsonProperty("command")]
public string Command { get; set; }
```
Command
```csharp
[JsonProperty("close")]
public string Close { get; set; }
```
Close
```csharp
[JsonProperty("sprite")]
public string Sprite { get; set; }
```
Sprite
```csharp
[JsonProperty("material")]
public string Material { get; set; }
```
Material
```csharp
public string Color { get; set; }
```
Color
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("imagetype")]
public Image.Type ImageType { get; set; }
```
ImageType
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```
FadeIn






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiButtonComponent",
      "id": "CuiButtonComponent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
        "Oxide.Game.Rust.Cui.CuiButtonComponent.Type"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiButtonComponent",
      "nameWithType": "CuiButtonComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiButtonComponent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 310,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiButtonComponent : ICuiComponent, ICuiColor",
        "content.vb": "Public Class CuiButtonComponent Implements ICuiComponent, ICuiColor"
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Type",
      "id": "Type",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Type",
      "nameWithType": "CuiButtonComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Type",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Type",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 312,
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
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Type*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent.Type"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
      "id": "Command",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command",
      "nameWithType": "CuiButtonComponent.Command",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 314,
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
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Command*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
      "id": "Close",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Close",
      "nameWithType": "CuiButtonComponent.Close",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Close",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 317,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"close\")]\npublic string Close { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"close\")>\nPublic Property Close As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Close*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "close"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
      "id": "Sprite",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Sprite",
      "nameWithType": "CuiButtonComponent.Sprite",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Sprite",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 321,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"sprite\")]\npublic string Sprite { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"sprite\")>\nPublic Property Sprite As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "sprite"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
      "id": "Material",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Material",
      "nameWithType": "CuiButtonComponent.Material",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Material",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 325,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"material\")]\npublic string Material { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"material\")>\nPublic Property Material As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Material*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "material"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "CuiButtonComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 328,
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
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.Color*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
      "id": "ImageType",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ImageType",
      "nameWithType": "CuiButtonComponent.ImageType",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ImageType",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 331,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonConverter(typeof(StringEnumConverter))]\n[JsonProperty(\"imagetype\")]\npublic Image.Type ImageType { get; set; }",
        "parameters": [],
        "return": {
          "type": "UnityEngine.UI.Image.Type"
        },
        "content.vb": "<JsonConverter(GetType(StringEnumConverter))>\n<JsonProperty(\"imagetype\")>\nPublic Property ImageType As Image.Type"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType*",
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
              "value": "imagetype"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
      "id": "FadeIn",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiButtonComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FadeIn",
      "nameWithType": "CuiButtonComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FadeIn",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 335,
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
      "overload": "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Type*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Type",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Type",
      "name": "Type",
      "nameWithType": "CuiButtonComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Type"
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Command",
      "name": "Command",
      "nameWithType": "CuiButtonComponent.Command",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Command"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Close*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Close",
      "name": "Close",
      "nameWithType": "CuiButtonComponent.Close",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Close"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite",
      "name": "Sprite",
      "nameWithType": "CuiButtonComponent.Sprite",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Sprite"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Material*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Material",
      "name": "Material",
      "nameWithType": "CuiButtonComponent.Material",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Material"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.Color",
      "name": "Color",
      "nameWithType": "CuiButtonComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.Color"
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType",
      "name": "ImageType",
      "nameWithType": "CuiButtonComponent.ImageType",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.ImageType"
    },
    {
      "uid": "UnityEngine.UI.Image.Type",
      "commentId": "T:UnityEngine.UI.Image.Type",
      "parent": "UnityEngine.UI",
      "isExternal": true,
      "name": "Image.Type",
      "nameWithType": "Image.Type",
      "fullName": "UnityEngine.UI.Image.Type",
      "spec.csharp": [
        {
          "uid": "UnityEngine.UI.Image",
          "name": "Image",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI.Image.Type",
          "name": "Type",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "UnityEngine.UI.Image",
          "name": "Image",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "UnityEngine.UI.Image.Type",
          "name": "Type",
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
      "uid": "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
      "href": "Oxide.Game.Rust.Cui.CuiButtonComponent.html#Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn",
      "name": "FadeIn",
      "nameWithType": "CuiButtonComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiButtonComponent.FadeIn"
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