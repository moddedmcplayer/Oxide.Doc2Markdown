# Class CuiHelper
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public static class CuiHelper
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Methods 
```csharp
public static string ToJson(List<CuiElement> elements, bool format = false)
```
ToJson(List<CuiElement>, bool)
```csharp
public static List<CuiElement> FromJson(string json)
```
FromJson(string)
```csharp
public static string GetGuid()
```
GetGuid()
```csharp
public static bool AddUi(BasePlayer player, List<CuiElement> elements)
```
AddUi(BasePlayer, List<CuiElement>)
```csharp
public static bool AddUi(BasePlayer player, string json)
```
AddUi(BasePlayer, string)
```csharp
public static bool DestroyUi(BasePlayer player, string elem)
```
DestroyUi(BasePlayer, string)
```csharp
public static void SetColor(this ICuiColor elem, Color color)
```
SetColor(ICuiColor, Color)
```csharp
public static Color GetColor(this ICuiColor elem)
```
GetColor(ICuiColor)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper",
      "commentId": "T:Oxide.Game.Rust.Cui.CuiHelper",
      "id": "CuiHelper",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement})",
        "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.String)",
        "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer,System.String)",
        "Oxide.Game.Rust.Cui.CuiHelper.FromJson(System.String)",
        "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
        "Oxide.Game.Rust.Cui.CuiHelper.GetGuid",
        "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
        "Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement},System.Boolean)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CuiHelper",
      "nameWithType": "CuiHelper",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CuiHelper",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 13,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static class CuiHelper",
        "content.vb": "Public Module CuiHelper"
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
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement},System.Boolean)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement},System.Boolean)",
      "id": "ToJson(System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement},System.Boolean)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ToJson(List<CuiElement>, bool)",
      "nameWithType": "CuiHelper.ToJson(List<CuiElement>, bool)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List<Oxide.Game.Rust.Cui.CuiElement>, bool)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ToJson",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 15,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static string ToJson(List<CuiElement> elements, bool format = false)",
        "parameters": [
          {
            "id": "elements",
            "type": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}"
          },
          {
            "id": "format",
            "type": "System.Boolean"
          }
        ],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Shared Function ToJson(elements As List(Of CuiElement), format As Boolean = False) As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.ToJson*",
      "nameWithType.vb": "CuiHelper.ToJson(List(Of CuiElement), Boolean)",
      "fullName.vb": "Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List(Of Oxide.Game.Rust.Cui.CuiElement), Boolean)",
      "name.vb": "ToJson(List(Of CuiElement), Boolean)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.FromJson(System.String)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.FromJson(System.String)",
      "id": "FromJson(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FromJson(string)",
      "nameWithType": "CuiHelper.FromJson(string)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.FromJson(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FromJson",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 23,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static List<CuiElement> FromJson(string json)",
        "parameters": [
          {
            "id": "json",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}"
        },
        "content.vb": "Public Shared Function FromJson(json As String) As List(Of CuiElement)"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.FromJson*",
      "nameWithType.vb": "CuiHelper.FromJson(String)",
      "fullName.vb": "Oxide.Game.Rust.Cui.CuiHelper.FromJson(String)",
      "name.vb": "FromJson(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetGuid",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.GetGuid",
      "id": "GetGuid",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GetGuid()",
      "nameWithType": "CuiHelper.GetGuid()",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetGuid()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GetGuid",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 25,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static string GetGuid()",
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Shared Function GetGuid() As String"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.GetGuid*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement})",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement})",
      "id": "AddUi(BasePlayer,System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement})",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddUi(BasePlayer, List<CuiElement>)",
      "nameWithType": "CuiHelper.AddUi(BasePlayer, List<CuiElement>)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer, System.Collections.Generic.List<Oxide.Game.Rust.Cui.CuiElement>)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddUi",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 27,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static bool AddUi(BasePlayer player, List<CuiElement> elements)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          },
          {
            "id": "elements",
            "type": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Shared Function AddUi(player As BasePlayer, elements As List(Of CuiElement)) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.AddUi*",
      "nameWithType.vb": "CuiHelper.AddUi(BasePlayer, List(Of CuiElement))",
      "fullName.vb": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer, System.Collections.Generic.List(Of Oxide.Game.Rust.Cui.CuiElement))",
      "name.vb": "AddUi(BasePlayer, List(Of CuiElement))"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.String)",
      "id": "AddUi(BasePlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddUi(BasePlayer, string)",
      "nameWithType": "CuiHelper.AddUi(BasePlayer, string)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddUi",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 29,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static bool AddUi(BasePlayer player, string json)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          },
          {
            "id": "json",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Shared Function AddUi(player As BasePlayer, json As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.AddUi*",
      "nameWithType.vb": "CuiHelper.AddUi(BasePlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer, String)",
      "name.vb": "AddUi(BasePlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer,System.String)",
      "id": "DestroyUi(BasePlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "DestroyUi(BasePlayer, string)",
      "nameWithType": "CuiHelper.DestroyUi(BasePlayer, string)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "DestroyUi",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 40,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static bool DestroyUi(BasePlayer player, string elem)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          },
          {
            "id": "elem",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Shared Function DestroyUi(player As BasePlayer, elem As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi*",
      "nameWithType.vb": "CuiHelper.DestroyUi(BasePlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer, String)",
      "name.vb": "DestroyUi(BasePlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "id": "SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "isEii": false,
      "isExtensionMethod": true,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SetColor(ICuiColor, Color)",
      "nameWithType": "CuiHelper.SetColor(ICuiColor, Color)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor, UnityEngine.Color)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SetColor",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 52,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static void SetColor(this ICuiColor elem, Color color)",
        "parameters": [
          {
            "id": "elem",
            "type": "Oxide.Game.Rust.Cui.ICuiColor"
          },
          {
            "id": "color",
            "type": "UnityEngine.Color"
          }
        ],
        "content.vb": "Public Shared Sub SetColor(elem As ICuiColor, color As Color)"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.SetColor*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "commentId": "M:Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "id": "GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "isEii": false,
      "isExtensionMethod": true,
      "parent": "Oxide.Game.Rust.Cui.CuiHelper",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GetColor(ICuiColor)",
      "nameWithType": "CuiHelper.GetColor(ICuiColor)",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GetColor",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 57,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public static Color GetColor(this ICuiColor elem)",
        "parameters": [
          {
            "id": "elem",
            "type": "Oxide.Game.Rust.Cui.ICuiColor"
          }
        ],
        "return": {
          "type": "UnityEngine.Color"
        },
        "content.vb": "Public Shared Function GetColor(elem As ICuiColor) As Color"
      },
      "overload": "Oxide.Game.Rust.Cui.CuiHelper.GetColor*"
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
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.ToJson*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.ToJson",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.ToJson(System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement},System.Boolean)",
      "name": "ToJson",
      "nameWithType": "CuiHelper.ToJson",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.ToJson"
    },
    {
      "uid": "System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}",
      "commentId": "T:System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}",
      "parent": "System.Collections.Generic",
      "definition": "System.Collections.Generic.List`1",
      "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1",
      "name": "List<CuiElement>",
      "nameWithType": "List<CuiElement>",
      "fullName": "System.Collections.Generic.List<Oxide.Game.Rust.Cui.CuiElement>",
      "nameWithType.vb": "List(Of CuiElement)",
      "fullName.vb": "System.Collections.Generic.List(Of Oxide.Game.Rust.Cui.CuiElement)",
      "name.vb": "List(Of CuiElement)",
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
          "uid": "Oxide.Game.Rust.Cui.CuiElement",
          "name": "CuiElement",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiElement.html"
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
          "uid": "Oxide.Game.Rust.Cui.CuiElement",
          "name": "CuiElement",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.CuiElement.html"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
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
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.FromJson*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.FromJson",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.FromJson(System.String)",
      "name": "FromJson",
      "nameWithType": "CuiHelper.FromJson",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.FromJson"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetGuid*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.GetGuid",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetGuid",
      "name": "GetGuid",
      "nameWithType": "CuiHelper.GetGuid",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetGuid"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.AddUi*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.AddUi",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.AddUi(BasePlayer,System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement})",
      "name": "AddUi",
      "nameWithType": "CuiHelper.AddUi",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.AddUi"
    },
    {
      "uid": "BasePlayer",
      "commentId": "T:BasePlayer",
      "isExternal": true,
      "name": "BasePlayer",
      "nameWithType": "BasePlayer",
      "fullName": "BasePlayer"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.DestroyUi",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.DestroyUi(BasePlayer,System.String)",
      "name": "DestroyUi",
      "nameWithType": "CuiHelper.DestroyUi",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.DestroyUi"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.SetColor*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.SetColor",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.SetColor(Oxide.Game.Rust.Cui.ICuiColor,UnityEngine.Color)",
      "name": "SetColor",
      "nameWithType": "CuiHelper.SetColor",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.SetColor"
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
      "uid": "UnityEngine.Color",
      "commentId": "T:UnityEngine.Color",
      "parent": "UnityEngine",
      "isExternal": true,
      "name": "Color",
      "nameWithType": "Color",
      "fullName": "UnityEngine.Color"
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
      "uid": "Oxide.Game.Rust.Cui.CuiHelper.GetColor*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.CuiHelper.GetColor",
      "href": "Oxide.Game.Rust.Cui.CuiHelper.html#Oxide.Game.Rust.Cui.CuiHelper.GetColor(Oxide.Game.Rust.Cui.ICuiColor)",
      "name": "GetColor",
      "nameWithType": "CuiHelper.GetColor",
      "fullName": "Oxide.Game.Rust.Cui.CuiHelper.GetColor"
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