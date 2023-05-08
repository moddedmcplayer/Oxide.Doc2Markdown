# Class CuiOutlineComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiOutlineComponent : ICuiComponent, ICuiColor
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
public string Color { get; set; }
```
Color
```csharp
[JsonProperty("distance")]
public string Distance { get; set; }
```
Distance
```csharp
[JsonProperty("useGraphicAlpha")]
public bool UseGraphicAlpha { get; set; }
```
UseGraphicAlpha






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "id": "CuiOutlineComponent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
        "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
        "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
        "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiOutlineComponent",
      "nameWithType": "CuiOutlineComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiOutlineComponent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 339,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiOutlineComponent : ICuiComponent, ICuiColor",
        "content.vb": "Public Class CuiOutlineComponent Implements ICuiComponent, ICuiColor"
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
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
      "id": "Type",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Type",
      "nameWithType": "CuiOutlineComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Type",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 341,
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
      "overload": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiComponent.Type"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
      "id": "Color",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Color",
      "nameWithType": "CuiOutlineComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Color",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 344,
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
      "overload": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color*",
      "implements": [
        "Oxide.Game.Rust.Cui.ICuiColor.Color"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
      "id": "Distance",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Distance",
      "nameWithType": "CuiOutlineComponent.Distance",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Distance",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 347,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"distance\")]\npublic string Distance { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"distance\")>\nPublic Property Distance As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "distance"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha",
      "id": "UseGraphicAlpha",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiOutlineComponent",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "UseGraphicAlpha",
      "nameWithType": "CuiOutlineComponent.UseGraphicAlpha",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "UseGraphicAlpha",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 351,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"useGraphicAlpha\")]\npublic bool UseGraphicAlpha { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "<JsonProperty(\"useGraphicAlpha\")>\nPublic Property UseGraphicAlpha As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "useGraphicAlpha"
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
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
      "href": "Oxide.Game.Rust.Cui.CuiOutlineComponent.html#Oxide.Game.Rust.Cui.CuiOutlineComponent.Type",
      "name": "Type",
      "nameWithType": "CuiOutlineComponent.Type",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Type"
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
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
      "href": "Oxide.Game.Rust.Cui.CuiOutlineComponent.html#Oxide.Game.Rust.Cui.CuiOutlineComponent.Color",
      "name": "Color",
      "nameWithType": "CuiOutlineComponent.Color",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Color"
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
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
      "href": "Oxide.Game.Rust.Cui.CuiOutlineComponent.html#Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance",
      "name": "Distance",
      "nameWithType": "CuiOutlineComponent.Distance",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.Distance"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha",
      "href": "Oxide.Game.Rust.Cui.CuiOutlineComponent.html#Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha",
      "name": "UseGraphicAlpha",
      "nameWithType": "CuiOutlineComponent.UseGraphicAlpha",
      "fullName": "Oxide.Game.Rust.Cui.CuiOutlineComponent.UseGraphicAlpha"
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