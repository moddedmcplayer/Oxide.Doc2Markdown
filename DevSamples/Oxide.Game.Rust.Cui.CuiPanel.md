# Class CuiPanel
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiPanel
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public CuiImageComponent Image { get; set; }
```
Image
```csharp
public CuiRawImageComponent RawImage { get; set; }
```
RawImage
```csharp
public CuiRectTransformComponent RectTransform { get; }
```
RectTransform
```csharp
public bool CursorEnabled { get; set; }
```
CursorEnabled
```csharp
public bool KeyboardEnabled { get; set; }
```
KeyboardEnabled
```csharp
public float FadeOut { get; set; }
```
FadeOut






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiPanel",
      "id": "CuiPanel",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
        "Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
        "Oxide.Game.Rust.Cui.CuiPanel.Image",
        "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
        "Oxide.Game.Rust.Cui.CuiPanel.RawImage",
        "Oxide.Game.Rust.Cui.CuiPanel.RectTransform"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiPanel",
      "nameWithType": "CuiPanel",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiPanel",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 180,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class CuiPanel",
        "content.vb": "Public Class CuiPanel"
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
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.Image",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.Image",
      "id": "Image",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Image",
      "nameWithType": "CuiPanel.Image",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.Image",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Image",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 182,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public CuiImageComponent Image { get; set; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Game.Rust.Cui.CuiImageComponent"
        },
        "content.vb": "Public Property Image As CuiImageComponent"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.Image*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.RawImage",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.RawImage",
      "id": "RawImage",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RawImage",
      "nameWithType": "CuiPanel.RawImage",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.RawImage",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RawImage",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 183,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public CuiRawImageComponent RawImage { get; set; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Game.Rust.Cui.CuiRawImageComponent"
        },
        "content.vb": "Public Property RawImage As CuiRawImageComponent"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.RawImage*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.RectTransform",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.RectTransform",
      "id": "RectTransform",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RectTransform",
      "nameWithType": "CuiPanel.RectTransform",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.RectTransform",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RectTransform",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 184,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public CuiRectTransformComponent RectTransform { get; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Game.Rust.Cui.CuiRectTransformComponent"
        },
        "content.vb": "Public ReadOnly Property RectTransform As CuiRectTransformComponent"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.RectTransform*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
      "id": "CursorEnabled",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CursorEnabled",
      "nameWithType": "CuiPanel.CursorEnabled",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CursorEnabled",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 185,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public bool CursorEnabled { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Property CursorEnabled As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
      "id": "KeyboardEnabled",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "KeyboardEnabled",
      "nameWithType": "CuiPanel.KeyboardEnabled",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "KeyboardEnabled",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 186,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public bool KeyboardEnabled { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Property KeyboardEnabled As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
      "commentId": "P:Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
      "id": "FadeOut",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiPanel",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FadeOut",
      "nameWithType": "CuiPanel.FadeOut",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FadeOut",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 187,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public float FadeOut { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Single"
        },
        "content.vb": "Public Property FadeOut As Single"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiPanel.FadeOut*"
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
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.Image*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.Image",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.Image",
      "name": "Image",
      "nameWithType": "CuiPanel.Image",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.Image"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiImageComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiImageComponent",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.CuiImageComponent.html",
      "name": "CuiImageComponent",
      "nameWithType": "CuiImageComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiImageComponent"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.RawImage*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.RawImage",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.RawImage",
      "name": "RawImage",
      "nameWithType": "CuiPanel.RawImage",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.RawImage"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiRawImageComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiRawImageComponent",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.CuiRawImageComponent.html",
      "name": "CuiRawImageComponent",
      "nameWithType": "CuiRawImageComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiRawImageComponent"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.RectTransform*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.RectTransform",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.RectTransform",
      "name": "RectTransform",
      "nameWithType": "CuiPanel.RectTransform",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.RectTransform"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiRectTransformComponent",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiRectTransformComponent",
      "parent": "Oxide.Game.Rust.Cui",
      "href": "Oxide.Game.Rust.Cui.CuiRectTransformComponent.html",
      "name": "CuiRectTransformComponent",
      "nameWithType": "CuiRectTransformComponent",
      "fullName": "Oxide.Game.Rust.Cui.CuiRectTransformComponent"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled",
      "name": "CursorEnabled",
      "nameWithType": "CuiPanel.CursorEnabled",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.CursorEnabled"
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
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled",
      "name": "KeyboardEnabled",
      "nameWithType": "CuiPanel.KeyboardEnabled",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.KeyboardEnabled"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiPanel.FadeOut*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
      "href": "Oxide.Game.Rust.Cui.CuiPanel.html#Oxide.Game.Rust.Cui.CuiPanel.FadeOut",
      "name": "FadeOut",
      "nameWithType": "CuiPanel.FadeOut",
      "fullName": "Oxide.Game.Rust.Cui.CuiPanel.FadeOut"
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