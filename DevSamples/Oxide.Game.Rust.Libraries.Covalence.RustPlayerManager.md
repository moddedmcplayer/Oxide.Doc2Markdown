# Class RustPlayerManager
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustPlayerManager : IPlayerManager
```  
#### Represents a generic player manager


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public IEnumerable<IPlayer> All { get; }
```
All
```csharp
public IEnumerable<IPlayer> Connected { get; }
```
Connected
```csharp
public IEnumerable<IPlayer> Sleeping { get; }
```
Sleeping
## Methods 
```csharp
public IPlayer FindPlayerById(string id)
```
FindPlayerById(string)
```csharp
public IPlayer FindPlayerByObj(object obj)
```
FindPlayerByObj(object)
```csharp
public IPlayer FindPlayer(string partialNameOrId)
```
FindPlayer(string)
```csharp
public IEnumerable<IPlayer> FindPlayers(string partialNameOrId)
```
FindPlayers(string)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "id": "RustPlayerManager",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(System.Object)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustPlayerManager",
      "nameWithType": "RustPlayerManager",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustPlayerManager",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Represents a generic player manager",
      "example": [],
      "syntax": {
        "content": "public class RustPlayerManager : IPlayerManager",
        "content.vb": "Public Class RustPlayerManager Implements IPlayerManager"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
      "id": "All",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "All",
      "nameWithType": "RustPlayerManager.All",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "All",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 75,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets all players",
      "example": [],
      "syntax": {
        "content": "public IEnumerable<IPlayer> All { get; }",
        "parameters": [],
        "return": {
          "type": "System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
          "description": ""
        },
        "content.vb": "Public ReadOnly Property All As IEnumerable(Of IPlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.All"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
      "id": "Connected",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Connected",
      "nameWithType": "RustPlayerManager.Connected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Connected",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 81,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets all connected players",
      "example": [],
      "syntax": {
        "content": "public IEnumerable<IPlayer> Connected { get; }",
        "parameters": [],
        "return": {
          "type": "System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
          "description": ""
        },
        "content.vb": "Public ReadOnly Property Connected As IEnumerable(Of IPlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.Connected"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping",
      "id": "Sleeping",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Sleeping",
      "nameWithType": "RustPlayerManager.Sleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Sleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 87,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets all sleeping players",
      "example": [],
      "syntax": {
        "content": "public IEnumerable<IPlayer> Sleeping { get; }",
        "parameters": [],
        "return": {
          "type": "System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
          "description": ""
        },
        "content.vb": "Public ReadOnly Property Sleeping As IEnumerable(Of IPlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(System.String)",
      "id": "FindPlayerById(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerById(string)",
      "nameWithType": "RustPlayerManager.FindPlayerById(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerById",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 94,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Finds a single player given unique ID",
      "example": [],
      "syntax": {
        "content": "public IPlayer FindPlayerById(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.IPlayer",
          "description": ""
        },
        "content.vb": "Public Function FindPlayerById(id As String) As IPlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(System.String)"
      ],
      "nameWithType.vb": "RustPlayerManager.FindPlayerById(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(String)",
      "name.vb": "FindPlayerById(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(System.Object)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(System.Object)",
      "id": "FindPlayerByObj(System.Object)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerByObj(object)",
      "nameWithType": "RustPlayerManager.FindPlayerByObj(object)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(object)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerByObj",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 104,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Finds a single connected player given game object",
      "example": [],
      "syntax": {
        "content": "public IPlayer FindPlayerByObj(object obj)",
        "parameters": [
          {
            "id": "obj",
            "type": "System.Object",
            "description": ""
          }
        ],
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.IPlayer",
          "description": ""
        },
        "content.vb": "Public Function FindPlayerByObj(obj As Object) As IPlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(System.Object)"
      ],
      "nameWithType.vb": "RustPlayerManager.FindPlayerByObj(Object)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(Object)",
      "name.vb": "FindPlayerByObj(Object)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(System.String)",
      "id": "FindPlayer(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayer(string)",
      "nameWithType": "RustPlayerManager.FindPlayer(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 111,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Finds a single player given a partial name or unique ID (case-insensitive, wildcards accepted, multiple matches returns null)",
      "example": [],
      "syntax": {
        "content": "public IPlayer FindPlayer(string partialNameOrId)",
        "parameters": [
          {
            "id": "partialNameOrId",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.IPlayer",
          "description": ""
        },
        "content.vb": "Public Function FindPlayer(partialNameOrId As String) As IPlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(System.String)"
      ],
      "nameWithType.vb": "RustPlayerManager.FindPlayer(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(String)",
      "name.vb": "FindPlayer(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(System.String)",
      "id": "FindPlayers(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayers(string)",
      "nameWithType": "RustPlayerManager.FindPlayers(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayerManager.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayers",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayerManager.cs",
        "startLine": 122,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Finds any number of players given a partial name or unique ID (case-insensitive, wildcards accepted)",
      "example": [],
      "syntax": {
        "content": "public IEnumerable<IPlayer> FindPlayers(string partialNameOrId)",
        "parameters": [
          {
            "id": "partialNameOrId",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
          "description": ""
        },
        "content.vb": "Public Function FindPlayers(partialNameOrId As String) As IEnumerable(Of IPlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(System.String)"
      ],
      "nameWithType.vb": "RustPlayerManager.FindPlayers(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(String)",
      "name.vb": "FindPlayers(String)"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence",
      "commentId": "N:Oxide.Game.Rust.Libraries.Covalence",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Libraries.Covalence",
      "nameWithType": "Oxide.Game.Rust.Libraries.Covalence",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence",
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
          "uid": "Oxide.Game.Rust.Libraries",
          "name": "Libraries",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.Covalence.html"
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
          "uid": "Oxide.Game.Rust.Libraries",
          "name": "Libraries",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.Covalence.html"
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IPlayerManager",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IPlayerManager",
      "nameWithType": "IPlayerManager",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager"
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
      "uid": "Oxide.Core.Libraries.Covalence",
      "commentId": "N:Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "Oxide.Core.Libraries.Covalence",
      "nameWithType": "Oxide.Core.Libraries.Covalence",
      "fullName": "Oxide.Core.Libraries.Covalence",
      "spec.csharp": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core",
          "name": "Core",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries",
          "name": "Libraries",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core",
          "name": "Core",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries",
          "name": "Libraries",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All",
      "name": "All",
      "nameWithType": "RustPlayerManager.All",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.All"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.All",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayerManager.All",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "name": "All",
      "nameWithType": "IPlayerManager.All",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.All"
    },
    {
      "uid": "System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
      "commentId": "T:System.Collections.Generic.IEnumerable{Oxide.Core.Libraries.Covalence.IPlayer}",
      "parent": "System.Collections.Generic",
      "definition": "System.Collections.Generic.IEnumerable`1",
      "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1",
      "name": "IEnumerable<IPlayer>",
      "nameWithType": "IEnumerable<IPlayer>",
      "fullName": "System.Collections.Generic.IEnumerable<Oxide.Core.Libraries.Covalence.IPlayer>",
      "nameWithType.vb": "IEnumerable(Of IPlayer)",
      "fullName.vb": "System.Collections.Generic.IEnumerable(Of Oxide.Core.Libraries.Covalence.IPlayer)",
      "name.vb": "IEnumerable(Of IPlayer)",
      "spec.csharp": [
        {
          "uid": "System.Collections.Generic.IEnumerable`1",
          "name": "IEnumerable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer",
          "name": "IPlayer",
          "isExternal": true
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Collections.Generic.IEnumerable`1",
          "name": "IEnumerable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1"
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer",
          "name": "IPlayer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Collections.Generic.IEnumerable`1",
      "commentId": "T:System.Collections.Generic.IEnumerable`1",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1",
      "name": "IEnumerable<T>",
      "nameWithType": "IEnumerable<T>",
      "fullName": "System.Collections.Generic.IEnumerable<T>",
      "nameWithType.vb": "IEnumerable(Of T)",
      "fullName.vb": "System.Collections.Generic.IEnumerable(Of T)",
      "name.vb": "IEnumerable(Of T)",
      "spec.csharp": [
        {
          "uid": "System.Collections.Generic.IEnumerable`1",
          "name": "IEnumerable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1"
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
          "uid": "System.Collections.Generic.IEnumerable`1",
          "name": "IEnumerable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected",
      "name": "Connected",
      "nameWithType": "RustPlayerManager.Connected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Connected"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.Connected",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayerManager.Connected",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "name": "Connected",
      "nameWithType": "IPlayerManager.Connected",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.Connected"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping",
      "name": "Sleeping",
      "nameWithType": "RustPlayerManager.Sleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.Sleeping"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById(System.String)",
      "name": "FindPlayerById",
      "nameWithType": "RustPlayerManager.FindPlayerById",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerById"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "FindPlayerById(string)",
      "nameWithType": "IPlayerManager.FindPlayerById(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(string)",
      "nameWithType.vb": "IPlayerManager.FindPlayerById(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(String)",
      "name.vb": "FindPlayerById(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(System.String)",
          "name": "FindPlayerById",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerById(System.String)",
          "name": "FindPlayerById",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IPlayer",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IPlayer",
      "nameWithType": "IPlayer",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj(System.Object)",
      "name": "FindPlayerByObj",
      "nameWithType": "RustPlayerManager.FindPlayerByObj",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayerByObj"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(System.Object)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(System.Object)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "FindPlayerByObj(object)",
      "nameWithType": "IPlayerManager.FindPlayerByObj(object)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(object)",
      "nameWithType.vb": "IPlayerManager.FindPlayerByObj(Object)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(Object)",
      "name.vb": "FindPlayerByObj(Object)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(System.Object)",
          "name": "FindPlayerByObj",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayerByObj(System.Object)",
          "name": "FindPlayerByObj",
          "isExternal": true
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer(System.String)",
      "name": "FindPlayer",
      "nameWithType": "RustPlayerManager.FindPlayer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayer"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "FindPlayer(string)",
      "nameWithType": "IPlayerManager.FindPlayer(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(string)",
      "nameWithType.vb": "IPlayerManager.FindPlayer(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(String)",
      "name.vb": "FindPlayer(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(System.String)",
          "name": "FindPlayer",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayer(System.String)",
          "name": "FindPlayer",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers(System.String)",
      "name": "FindPlayers",
      "nameWithType": "RustPlayerManager.FindPlayers",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.FindPlayers"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "FindPlayers(string)",
      "nameWithType": "IPlayerManager.FindPlayers(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(string)",
      "nameWithType.vb": "IPlayerManager.FindPlayers(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(String)",
      "name.vb": "FindPlayers(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(System.String)",
          "name": "FindPlayers",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager.FindPlayers(System.String)",
          "name": "FindPlayers",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
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