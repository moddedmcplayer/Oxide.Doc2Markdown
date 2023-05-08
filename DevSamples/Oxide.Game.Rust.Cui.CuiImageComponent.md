# Class CuiImageComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiImageComponent : ICuiComponent, ICuiColor
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
[JsonProperty("png")]
public string Png { get; set; }
```
Png
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```
FadeIn
```csharp
[JsonProperty("itemid")]
public int ItemId { get; set; }
```
ItemId
```csharp
[JsonProperty("skinid")]
public ulong SkinId { get; set; }
```
SkinId






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiImageComponent",
      "id": "CuiImageComponent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiImageComponent.Color",
        "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
        "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
        "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
        "Oxide.Game.Rust.Cui.CuiImageComponent.Material",
        "Oxide.Game.Rust.Cui.CuiImageComponent.Png",
        "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
        "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
        "Oxide.Game.Rust.Cui.CuiImageComponent.Type"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiImageComponent",
      "nameWithType": "CuiImageComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiImageComponent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 259,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiImageComponent : ICuiComponent, ICuiColor",
        "content.vb": "Public Class CuiImageComponent Implements ICuiComponent, ICuiColor"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.Type",
      "id": "Type",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Type",
      "nameWithType": "CuiImageComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Type",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Type",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 261,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.Type*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent.Type"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
      "id": "Sprite",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Sprite",
      "nameWithType": "CuiImageComponent.Sprite",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Sprite",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 263,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Material",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.Material",
      "id": "Material",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Material",
      "nameWithType": "CuiImageComponent.Material",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Material",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Material",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 266,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.Material*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "CuiImageComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 269,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.Color*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
      "id": "ImageType",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ImageType",
      "nameWithType": "CuiImageComponent.ImageType",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ImageType",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 271,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType*",
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Png",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.Png",
      "id": "Png",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Png",
      "nameWithType": "CuiImageComponent.Png",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Png",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Png",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 275,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"png\")]\npublic string Png { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"png\")>\nPublic Property Png As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.Png*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "png"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
      "id": "FadeIn",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FadeIn",
      "nameWithType": "CuiImageComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FadeIn",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 278,
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
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn*",
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
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
      "id": "ItemId",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ItemId",
      "nameWithType": "CuiImageComponent.ItemId",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ItemId",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 281,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"itemid\")]\npublic int ItemId { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "<JsonProperty(\"itemid\")>\nPublic Property ItemId As Integer"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "itemid"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
      "id": "SkinId",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SkinId",
      "nameWithType": "CuiImageComponent.SkinId",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SkinId",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 284,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"skinid\")]\npublic ulong SkinId { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.UInt64"
        },
        "content.vb": "<JsonProperty(\"skinid\")>\nPublic Property SkinId As ULong"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "skinid"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Type*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.Type",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.Type",
      "name": "Type",
      "nameWithType": "CuiImageComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Type"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.Sprite",
      "name": "Sprite",
      "nameWithType": "CuiImageComponent.Sprite",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Sprite"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Material*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.Material",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.Material",
      "name": "Material",
      "nameWithType": "CuiImageComponent.Material",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Material"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.Color",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.Color",
      "name": "Color",
      "nameWithType": "CuiImageComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Color"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.ImageType",
      "name": "ImageType",
      "nameWithType": "CuiImageComponent.ImageType",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.ImageType"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.Png*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.Png",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.Png",
      "name": "Png",
      "nameWithType": "CuiImageComponent.Png",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.Png"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn",
      "name": "FadeIn",
      "nameWithType": "CuiImageComponent.FadeIn",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.FadeIn"
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
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.ItemId",
      "name": "ItemId",
      "nameWithType": "CuiImageComponent.ItemId",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.ItemId"
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
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html#Oxide.Game.Rust.Cui.CuiImageComponent.SkinId",
      "name": "SkinId",
      "nameWithType": "CuiImageComponent.SkinId",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent.SkinId"
    },
    {
      "uid": "System.UInt64",
      "commentId": "T:System.UInt64",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.uint64",
      "name": "ulong",
      "nameWithType": "ulong",
      "fullName": "ulong",
      "nameWithType.vb": "ULong",
      "fullName.vb": "ULong",
      "name.vb": "ULong"
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