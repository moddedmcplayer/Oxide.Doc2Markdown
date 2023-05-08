# Class RustCovalenceProvider
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCovalenceProvider : ICovalenceProvider
```  
#### Provides Covalence functionality for the game "Rust"


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public string GameName { get; }
```
GameName
```csharp
public uint ClientAppId { get; }
```
ClientAppId
```csharp
public uint ServerAppId { get; }
```
ServerAppId
```csharp
public RustPlayerManager PlayerManager { get; }
```
PlayerManager
```csharp
public RustCommandSystem CommandSystem { get; }
```
CommandSystem
## Constructors 
```csharp
public RustCovalenceProvider()
```
RustCovalenceProvider()
## Methods 
```csharp
public IServer CreateServer()
```
CreateServer()
```csharp
public IPlayerManager CreatePlayerManager()
```
CreatePlayerManager()
```csharp
public ICommandSystem CreateCommandSystemProvider()
```
CreateCommandSystemProvider()
```csharp
public string FormatText(string text)
```
FormatText(string)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "id": "RustCovalenceProvider",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
        "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCovalenceProvider",
      "nameWithType": "RustCovalenceProvider",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustCovalenceProvider",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 7,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Provides Covalence functionality for the game \"Rust\"",
      "example": [],
      "syntax": {
        "content": "public class RustCovalenceProvider : ICovalenceProvider",
        "content.vb": "Public Class RustCovalenceProvider Implements ICovalenceProvider"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
      "id": "GameName",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GameName",
      "nameWithType": "RustCovalenceProvider.GameName",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GameName",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 12,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the name of the game for which this provider provides",
      "example": [],
      "syntax": {
        "content": "public string GameName { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property GameName As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.GameName"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
      "id": "ClientAppId",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ClientAppId",
      "nameWithType": "RustCovalenceProvider.ClientAppId",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ClientAppId",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 17,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the Steam app ID of the game's client, if available",
      "example": [],
      "syntax": {
        "content": "public uint ClientAppId { get; }",
        "parameters": [],
        "return": {
          "type": "System.UInt32"
        },
        "content.vb": "Public ReadOnly Property ClientAppId As UInteger"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ClientAppId"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId",
      "id": "ServerAppId",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ServerAppId",
      "nameWithType": "RustCovalenceProvider.ServerAppId",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ServerAppId",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 22,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the Steam app ID of the game's server, if available",
      "example": [],
      "syntax": {
        "content": "public uint ServerAppId { get; }",
        "parameters": [],
        "return": {
          "type": "System.UInt32"
        },
        "content.vb": "Public ReadOnly Property ServerAppId As UInteger"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ServerAppId"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor",
      "id": "#ctor",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCovalenceProvider()",
      "nameWithType": "RustCovalenceProvider.RustCovalenceProvider()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.RustCovalenceProvider()",
      "type": "constructor",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": ".ctor",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 29,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "syntax": {
        "content": "public RustCovalenceProvider()",
        "content.vb": "Public Sub New()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor*",
      "nameWithType.vb": "RustCovalenceProvider.New()",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.New()",
      "name.vb": "New()"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
      "id": "PlayerManager",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PlayerManager",
      "nameWithType": "RustCovalenceProvider.PlayerManager",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PlayerManager",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 37,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the player manager",
      "example": [],
      "syntax": {
        "content": "public RustPlayerManager PlayerManager { get; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager"
        },
        "content.vb": "Public Property PlayerManager As RustPlayerManager"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
      "id": "CommandSystem",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CommandSystem",
      "nameWithType": "RustCovalenceProvider.CommandSystem",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CommandSystem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 42,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the command system provider",
      "example": [],
      "syntax": {
        "content": "public RustCommandSystem CommandSystem { get; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem"
        },
        "content.vb": "Public Property CommandSystem As RustCommandSystem"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer",
      "id": "CreateServer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CreateServer()",
      "nameWithType": "RustCovalenceProvider.CreateServer()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CreateServer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 48,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Creates the game-specific server object",
      "example": [],
      "syntax": {
        "content": "public IServer CreateServer()",
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.IServer",
          "description": ""
        },
        "content.vb": "Public Function CreateServer() As IServer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager",
      "id": "CreatePlayerManager",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CreatePlayerManager()",
      "nameWithType": "RustCovalenceProvider.CreatePlayerManager()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CreatePlayerManager",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 54,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Creates the game-specific player manager object",
      "example": [],
      "syntax": {
        "content": "public IPlayerManager CreatePlayerManager()",
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.IPlayerManager",
          "description": ""
        },
        "content.vb": "Public Function CreatePlayerManager() As IPlayerManager"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider",
      "id": "CreateCommandSystemProvider",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CreateCommandSystemProvider()",
      "nameWithType": "RustCovalenceProvider.CreateCommandSystemProvider()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CreateCommandSystemProvider",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 65,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Creates the game-specific command system provider object",
      "example": [],
      "syntax": {
        "content": "public ICommandSystem CreateCommandSystemProvider()",
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.ICommandSystem",
          "description": ""
        },
        "content.vb": "Public Function CreateCommandSystemProvider() As ICommandSystem"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(System.String)",
      "id": "FormatText(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FormatText(string)",
      "nameWithType": "RustCovalenceProvider.FormatText(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCovalenceProvider.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FormatText",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCovalenceProvider.cs",
        "startLine": 73,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Formats the text with markup as specified in Oxide.Core.Libraries.Covalence.Formatter\ninto the game-specific markup language",
      "example": [],
      "syntax": {
        "content": "public string FormatText(string text)",
        "parameters": [
          {
            "id": "text",
            "type": "System.String",
            "description": "text to format"
          }
        ],
        "return": {
          "type": "System.String",
          "description": "formatted text"
        },
        "content.vb": "Public Function FormatText(text As String) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(System.String)"
      ],
      "nameWithType.vb": "RustCovalenceProvider.FormatText(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(String)",
      "name.vb": "FormatText(String)"
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
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "commentId": "T:Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "ICovalenceProvider",
      "nameWithType": "ICovalenceProvider",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName",
      "name": "GameName",
      "nameWithType": "RustCovalenceProvider.GameName",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.GameName"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.GameName",
      "commentId": "P:Oxide.Core.Libraries.Covalence.ICovalenceProvider.GameName",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "GameName",
      "nameWithType": "ICovalenceProvider.GameName",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.GameName"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId",
      "name": "ClientAppId",
      "nameWithType": "RustCovalenceProvider.ClientAppId",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ClientAppId"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ClientAppId",
      "commentId": "P:Oxide.Core.Libraries.Covalence.ICovalenceProvider.ClientAppId",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "ClientAppId",
      "nameWithType": "ICovalenceProvider.ClientAppId",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ClientAppId"
    },
    {
      "uid": "System.UInt32",
      "commentId": "T:System.UInt32",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.uint32",
      "name": "uint",
      "nameWithType": "uint",
      "fullName": "uint",
      "nameWithType.vb": "UInteger",
      "fullName.vb": "UInteger",
      "name.vb": "UInteger"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId",
      "name": "ServerAppId",
      "nameWithType": "RustCovalenceProvider.ServerAppId",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.ServerAppId"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ServerAppId",
      "commentId": "P:Oxide.Core.Libraries.Covalence.ICovalenceProvider.ServerAppId",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "ServerAppId",
      "nameWithType": "ICovalenceProvider.ServerAppId",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.ServerAppId"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.#ctor",
      "name": "RustCovalenceProvider",
      "nameWithType": "RustCovalenceProvider.RustCovalenceProvider",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.RustCovalenceProvider",
      "nameWithType.vb": "RustCovalenceProvider.New",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.New",
      "name.vb": "New"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager",
      "name": "PlayerManager",
      "nameWithType": "RustCovalenceProvider.PlayerManager",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.PlayerManager"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager",
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager.html",
      "name": "RustPlayerManager",
      "nameWithType": "RustPlayerManager",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayerManager"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem",
      "name": "CommandSystem",
      "nameWithType": "RustCovalenceProvider.CommandSystem",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CommandSystem"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html",
      "name": "RustCommandSystem",
      "nameWithType": "RustCommandSystem",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer",
      "name": "CreateServer",
      "nameWithType": "RustCovalenceProvider.CreateServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateServer"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "CreateServer()",
      "nameWithType": "ICovalenceProvider.CreateServer()",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer",
          "name": "CreateServer",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateServer",
          "name": "CreateServer",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Covalence.IServer",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IServer",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IServer",
      "nameWithType": "IServer",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager",
      "name": "CreatePlayerManager",
      "nameWithType": "RustCovalenceProvider.CreatePlayerManager",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreatePlayerManager"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "CreatePlayerManager()",
      "nameWithType": "ICovalenceProvider.CreatePlayerManager()",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager",
          "name": "CreatePlayerManager",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreatePlayerManager",
          "name": "CreatePlayerManager",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayerManager",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IPlayerManager",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IPlayerManager",
      "nameWithType": "IPlayerManager",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayerManager"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider",
      "name": "CreateCommandSystemProvider",
      "nameWithType": "RustCovalenceProvider.CreateCommandSystemProvider",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.CreateCommandSystemProvider"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "name": "CreateCommandSystemProvider()",
      "nameWithType": "ICovalenceProvider.CreateCommandSystemProvider()",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider",
          "name": "CreateCommandSystemProvider",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.CreateCommandSystemProvider",
          "name": "CreateCommandSystemProvider",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem",
      "commentId": "T:Oxide.Core.Libraries.Covalence.ICommandSystem",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "ICommandSystem",
      "nameWithType": "ICommandSystem",
      "fullName": "Oxide.Core.Libraries.Covalence.ICommandSystem"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.html#Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText(System.String)",
      "name": "FormatText",
      "nameWithType": "RustCovalenceProvider.FormatText",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCovalenceProvider.FormatText"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.ICovalenceProvider",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "FormatText(string)",
      "nameWithType": "ICovalenceProvider.FormatText(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(string)",
      "nameWithType.vb": "ICovalenceProvider.FormatText(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(String)",
      "name.vb": "FormatText(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(System.String)",
          "name": "FormatText",
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
          "uid": "Oxide.Core.Libraries.Covalence.ICovalenceProvider.FormatText(System.String)",
          "name": "FormatText",
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