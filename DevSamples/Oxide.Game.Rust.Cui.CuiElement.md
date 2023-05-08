# Class CuiElement
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiElement
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
[JsonProperty("name")]
public string Name { get; set; }
```
Name
```csharp
[JsonProperty("parent")]
public string Parent { get; set; }
```
Parent
```csharp
[JsonProperty("destroyUi", NullValueHandling = NullValueHandling.Ignore)]
public string DestroyUi { get; set; }
```
DestroyUi
```csharp
[JsonProperty("components")]
public List<ICuiComponent> Components { get; }
```
Components
```csharp
[JsonProperty("fadeOut")]
public float FadeOut { get; set; }
```
FadeOut






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiElement",
      "id": "CuiElement",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiElement.Components",
        "Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
        "Oxide.Game.Rust.Cui.CuiElement.FadeOut",
        "Oxide.Game.Rust.Cui.CuiElement.Name",
        "Oxide.Game.Rust.Cui.CuiElement.Parent"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiElement",
      "nameWithType": "CuiElement",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiElement",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 197,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiElement",
        "content.vb": "Public Class CuiElement"
      },
      "inheritance": [
        "System.Object"
      ],
      "inheritedMembers": [
        "System.Object.ToString",
        "System.Object.Equals(System.Object)",
        "System.Object.Equals(System.Object,System.Object)",
        "System.Object.ReferenceEquals(System.Object,System.Object)",
        "System.Object.GetHashCode",
        "System.Object.GetType",
        "System.Object.MemberwiseClone"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Name",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiElement.Name",
      "id": "Name",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiElement",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Name",
      "nameWithType": "CuiElement.Name",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Name",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Name",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 199,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"name\")]\npublic string Name { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"name\")>\nPublic Property Name As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiElement.Name*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "name"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Parent",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiElement.Parent",
      "id": "Parent",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiElement",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Parent",
      "nameWithType": "CuiElement.Parent",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Parent",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Parent",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 202,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"parent\")]\npublic string Parent { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"parent\")>\nPublic Property Parent As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiElement.Parent*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "parent"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
      "id": "DestroyUi",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiElement",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "DestroyUi",
      "nameWithType": "CuiElement.DestroyUi",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "DestroyUi",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 205,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"destroyUi\", NullValueHandling = NullValueHandling.Ignore)]\npublic string DestroyUi { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<JsonProperty(\"destroyUi\", NullValueHandling:=NullValueHandling.Ignore)>\nPublic Property DestroyUi As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiElement.DestroyUi*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "destroyUi"
            }
          ],
          "namedArguments": [
            {
              "name": "NullValueHandling",
              "type": "Newtonsoft.Json.NullValueHandling",
              "value": 1
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Components",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiElement.Components",
      "id": "Components",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiElement",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Components",
      "nameWithType": "CuiElement.Components",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Components",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Components",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 208,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"components\")]\npublic List<ICuiComponent> Components { get; }",
        "parameters": [],
        "return": {
          "type": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.ICuiComponent}"
        },
        "content.vb": "<JsonProperty(\"components\")>\nPublic ReadOnly Property Components As List(Of ICuiComponent)"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiElement.Components*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "components"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.FadeOut",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiElement.FadeOut",
      "id": "FadeOut",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiElement",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FadeOut",
      "nameWithType": "CuiElement.FadeOut",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.FadeOut",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FadeOut",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 211,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "[JsonProperty(\"fadeOut\")]\npublic float FadeOut { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Single"
        },
        "content.vb": "<JsonProperty(\"fadeOut\")>\nPublic Property FadeOut As Single"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiElement.FadeOut*",
      "attributes": [
        {
          "type": "Newtonsoft.Json.JsonPropertyAttribute",
          "ctor": "Newtonsoft.Json.JsonPropertyAttribute.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "fadeOut"
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
      "uid": "System",
      "commentId": "N:System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System",
      "nameWithType": "System",
      "fullName": "System"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Name*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiElement.Name",
      "href": "Oxide.Game.Rust.Cui.CuiElement.html#Oxide.Game.Rust.Cui.CuiElement.Name",
      "name": "Name",
      "nameWithType": "CuiElement.Name",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Name"
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
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Parent*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiElement.Parent",
      "href": "Oxide.Game.Rust.Cui.CuiElement.html#Oxide.Game.Rust.Cui.CuiElement.Parent",
      "name": "Parent",
      "nameWithType": "CuiElement.Parent",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Parent"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.DestroyUi*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
      "href": "Oxide.Game.Rust.Cui.CuiElement.html#Oxide.Game.Rust.Cui.CuiElement.DestroyUi",
      "name": "DestroyUi",
      "nameWithType": "CuiElement.DestroyUi",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.DestroyUi"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.Components*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiElement.Components",
      "href": "Oxide.Game.Rust.Cui.CuiElement.html#Oxide.Game.Rust.Cui.CuiElement.Components",
      "name": "Components",
      "nameWithType": "CuiElement.Components",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.Components"
    },
    {
      "uid": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.ICuiComponent}",
      "commentId": "T:System.Collections.Generic.List{Oxide.Game.Rust.Cui.ICuiComponent}",
      "parent": "System.Collections.Generic",
      "definition": "System.Collections.Generic.List`1",
      "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1",
      "name": "List<ICuiComponent>",
      "nameWithType": "List<ICuiComponent>",
      "fullName": "System.Collections.Generic.List<Oxide.Game.Rust.Cui.ICuiComponent>",
      "nameWithType.vb": "List(Of ICuiComponent)",
      "fullName.vb": "System.Collections.Generic.List(Of Oxide.Game.Rust.Cui.ICuiComponent)",
      "name.vb": "List(Of ICuiComponent)",
      "spec.csharp": [
        {
          "uid": "System.Collections.Generic.List`1",
          "name": "List",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiComponent",
          "name": "ICuiComponent",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiComponent.html"
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Collections.Generic.List`1",
          "name": "List",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui.ICuiComponent",
          "name": "ICuiComponent",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.ICuiComponent.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Collections.Generic.List`1",
      "commentId": "T:System.Collections.Generic.List`1",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1",
      "name": "List<T>",
      "nameWithType": "List<T>",
      "fullName": "System.Collections.Generic.List<T>",
      "nameWithType.vb": "List(Of T)",
      "fullName.vb": "System.Collections.Generic.List(Of T)",
      "name.vb": "List(Of T)",
      "spec.csharp": [
        {
          "uid": "System.Collections.Generic.List`1",
          "name": "List",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "name": "T",
          "isExternal": false
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Collections.Generic.List`1",
          "name": "List",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "name": "T",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Collections.Generic",
      "commentId": "N:System.Collections.Generic",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System.Collections.Generic",
      "nameWithType": "System.Collections.Generic",
      "fullName": "System.Collections.Generic",
      "spec.csharp": [
        {
          "uid": "System",
          "name": "System",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Collections",
          "name": "Collections",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Collections.Generic",
          "name": "Generic",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic"
        }
      ],
      "spec.vb": [
        {
          "uid": "System",
          "name": "System",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Collections",
          "name": "Collections",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Collections.Generic",
          "name": "Generic",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic"
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiElement.FadeOut*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiElement.FadeOut",
      "href": "Oxide.Game.Rust.Cui.CuiElement.html#Oxide.Game.Rust.Cui.CuiElement.FadeOut",
      "name": "FadeOut",
      "nameWithType": "CuiElement.FadeOut",
      "fullName": "Oxide.Game.Rust.Cui.CuiElement.FadeOut"
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