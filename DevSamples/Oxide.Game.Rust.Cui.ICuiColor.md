# Class ICuiColor
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public interface ICuiColor
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
namespace, namespace, namespace, namespace, namespace, namespace  

## Properties 
```csharp
[JsonProperty("color")]
string Color { get; set; }
```
Color






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor",
      "commentId": "T:Oxide.Game.Rust.Cui.ICuiColor",
      "id": "ICuiColor",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ICuiColor",
      "nameWithType": "ICuiColor",
      "fullName": "Oxide.Game.Rust.Cui.ICuiColor",
      "type": "interface",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ICuiColor",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 222,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public interface ICuiColor",
        "content.vb": "Public Interface ICuiColor"
      },
      "extensionMethods": [
        "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.GetColor",
        "Oxide.Game.Rust.Cui.ICuiColor.Oxide.Game.Rust.Cui.CuiHelper.SetColor(UnityEngine.Color)"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ICuiColor.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.ICuiColor.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.ICuiColor",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "ICuiColor.Color",
      "fullName": "Oxide.Game.Rust.Cui.ICuiColor.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 224,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"color\")]\nstring Color { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"color\")>\nProperty Color As String"
      },
      "overload": "Oxide.Game.Rust.Cui.ICuiColor.Color*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "color"
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
      "uid": "Oxide.Game.Rust.Cui.ICuiColor.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.ICuiColor.Color",
      "href": "Oxide.Game.Rust.Cui.ICuiColor.html#Oxide.Game.Rust.Cui.ICuiColor.Color",
      "name": "Color",
      "nameWithType": "ICuiColor.Color",
      "fullName": "Oxide.Game.Rust.Cui.ICuiColor.Color"
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
      "uid": "System",
      "commentId": "N:System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System",
      "nameWithType": "System",
      "fullName": "System"
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