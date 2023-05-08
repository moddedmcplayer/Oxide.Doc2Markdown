# Class RustServer
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustServer : IServer
```  
#### Represents the server hosting the game instance


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public string Name { get; set; }
```
Name
```csharp
public IPAddress Address { get; }
```
Address
```csharp
public IPAddress LocalAddress { get; }
```
LocalAddress
```csharp
public ushort Port { get; }
```
Port
```csharp
public string Version { get; }
```
Version
```csharp
public string Protocol { get; }
```
Protocol
```csharp
public CultureInfo Language { get; }
```
Language
```csharp
public int Players { get; }
```
Players
```csharp
public int MaxPlayers { get; set; }
```
MaxPlayers
```csharp
public DateTime Time { get; set; }
```
Time
```csharp
public SaveInfo SaveInfo { get; }
```
SaveInfo
## Methods 
```csharp
public void Ban(string id, string reason, TimeSpan duration = default)
```
Ban(string, string, TimeSpan)
```csharp
public TimeSpan BanTimeRemaining(string id)
```
BanTimeRemaining(string)
```csharp
public bool IsBanned(string id)
```
IsBanned(string)
```csharp
public void Save()
```
Save()
```csharp
public void Unban(string id)
```
Unban(string)
```csharp
public void Broadcast(string message, string prefix, params object[] args)
```
Broadcast(string, string, params object[])
```csharp
public void Broadcast(string message)
```
Broadcast(string)
```csharp
public void Command(string command, params object[] args)
```
Command(string, params object[])






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "id": "RustServer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(System.String,System.String,System.TimeSpan)",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustServer",
      "nameWithType": "RustServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustServer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Represents the server hosting the game instance",
      "example": [],
      "syntax": {
        "content": "public class RustServer : IServer",
        "content.vb": "Public Class RustServer Implements IServer"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
      "id": "Name",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Name",
      "nameWithType": "RustServer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Name",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 27,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the public-facing name of the server",
      "example": [],
      "syntax": {
        "content": "public string Name { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Property Name As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Name"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
      "id": "Address",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Address",
      "nameWithType": "RustServer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Address",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 39,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the public-facing IP address of the server, if known",
      "example": [],
      "syntax": {
        "content": "public IPAddress Address { get; }",
        "parameters": [],
        "return": {
          "type": "System.Net.IPAddress"
        },
        "content.vb": "Public ReadOnly Property Address As IPAddress"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Address"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
      "id": "LocalAddress",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "LocalAddress",
      "nameWithType": "RustServer.LocalAddress",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "LocalAddress",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 73,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the local IP address of the server, if known",
      "example": [],
      "syntax": {
        "content": "public IPAddress LocalAddress { get; }",
        "parameters": [],
        "return": {
          "type": "System.Net.IPAddress"
        },
        "content.vb": "Public ReadOnly Property LocalAddress As IPAddress"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.LocalAddress"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
      "id": "Port",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Port",
      "nameWithType": "RustServer.Port",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Port",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 92,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the public-facing network port of the server, if known",
      "example": [],
      "syntax": {
        "content": "public ushort Port { get; }",
        "parameters": [],
        "return": {
          "type": "System.UInt16"
        },
        "content.vb": "Public ReadOnly Property Port As UShort"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Port"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Version",
      "id": "Version",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Version",
      "nameWithType": "RustServer.Version",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Version",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 97,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the version or build number of the server",
      "example": [],
      "syntax": {
        "content": "public string Version { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property Version As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Version"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
      "id": "Protocol",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Protocol",
      "nameWithType": "RustServer.Protocol",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Protocol",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 102,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the network protocol version of the server",
      "example": [],
      "syntax": {
        "content": "public string Protocol { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property Protocol As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Protocol"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
      "id": "Language",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Language",
      "nameWithType": "RustServer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Language",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 107,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the language set by the server",
      "example": [],
      "syntax": {
        "content": "public CultureInfo Language { get; }",
        "parameters": [],
        "return": {
          "type": "System.Globalization.CultureInfo"
        },
        "content.vb": "Public ReadOnly Property Language As CultureInfo"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Language"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
      "id": "Players",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Players",
      "nameWithType": "RustServer.Players",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Players",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 112,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the total of players currently on the server",
      "example": [],
      "syntax": {
        "content": "public int Players { get; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "Public ReadOnly Property Players As Integer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Players"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
      "id": "MaxPlayers",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "MaxPlayers",
      "nameWithType": "RustServer.MaxPlayers",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "MaxPlayers",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 117,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the maximum players allowed on the server",
      "example": [],
      "syntax": {
        "content": "public int MaxPlayers { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "Public Property MaxPlayers As Integer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.MaxPlayers"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
      "id": "Time",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Time",
      "nameWithType": "RustServer.Time",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Time",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 126,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the current in-game time on the server",
      "example": [],
      "syntax": {
        "content": "public DateTime Time { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.DateTime"
        },
        "content.vb": "Public Property Time As Date"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Time"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
      "id": "SaveInfo",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SaveInfo",
      "nameWithType": "RustServer.SaveInfo",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SaveInfo",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 135,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets information on the currently loaded save file",
      "example": [],
      "syntax": {
        "content": "public SaveInfo SaveInfo { get; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.SaveInfo"
        },
        "content.vb": "Public ReadOnly Property SaveInfo As SaveInfo"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.SaveInfo"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(System.String,System.String,System.TimeSpan)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(System.String,System.String,System.TimeSpan)",
      "id": "Ban(System.String,System.String,System.TimeSpan)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(string, string, TimeSpan)",
      "nameWithType": "RustServer.Ban(string, string, TimeSpan)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(string, string, System.TimeSpan)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 147,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Bans the player for the specified reason and duration",
      "example": [],
      "syntax": {
        "content": "public void Ban(string id, string reason, TimeSpan duration = default)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "reason",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "duration",
            "type": "System.TimeSpan",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Ban(id As String, reason As String, duration As TimeSpan = Nothing)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Ban(System.String,System.String,System.TimeSpan)"
      ],
      "nameWithType.vb": "RustServer.Ban(String, String, TimeSpan)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(String, String, System.TimeSpan)",
      "name.vb": "Ban(String, String, TimeSpan)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(System.String)",
      "id": "BanTimeRemaining(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BanTimeRemaining(string)",
      "nameWithType": "RustServer.BanTimeRemaining(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BanTimeRemaining",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 160,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the amount of time remaining on the player's ban",
      "example": [],
      "syntax": {
        "content": "public TimeSpan BanTimeRemaining(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.TimeSpan"
        },
        "content.vb": "Public Function BanTimeRemaining(id As String) As TimeSpan"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(System.String)"
      ],
      "nameWithType.vb": "RustServer.BanTimeRemaining(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(String)",
      "name.vb": "BanTimeRemaining(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(System.String)",
      "id": "IsBanned(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned(string)",
      "nameWithType": "RustServer.IsBanned(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 166,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets if the player is banned",
      "example": [],
      "syntax": {
        "content": "public bool IsBanned(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsBanned(id As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.IsBanned(System.String)"
      ],
      "nameWithType.vb": "RustServer.IsBanned(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(String)",
      "name.vb": "IsBanned(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Save",
      "id": "Save",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Save()",
      "nameWithType": "RustServer.Save()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Save",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 171,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Saves the server and any related information",
      "example": [],
      "syntax": {
        "content": "public void Save()",
        "content.vb": "Public Sub Save()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Save"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(System.String)",
      "id": "Unban(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban(string)",
      "nameWithType": "RustServer.Unban(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 182,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Unbans the player",
      "example": [],
      "syntax": {
        "content": "public void Unban(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Unban(id As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Unban(System.String)"
      ],
      "nameWithType.vb": "RustServer.Unban(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(String)",
      "name.vb": "Unban(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String,System.String,System.Object[])",
      "id": "Broadcast(System.String,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Broadcast(string, string, params object[])",
      "nameWithType": "RustServer.Broadcast(string, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(string, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Broadcast",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 201,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Broadcasts the specified chat message and prefix to all players",
      "example": [],
      "syntax": {
        "content": "public void Broadcast(string message, string prefix, params object[] args)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "prefix",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Broadcast(message As String, prefix As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String,System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustServer.Broadcast(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(String, String, ParamArray Object())",
      "name.vb": "Broadcast(String, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String)",
      "id": "Broadcast(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Broadcast(string)",
      "nameWithType": "RustServer.Broadcast(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Broadcast",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 210,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Broadcasts the specified chat message to all players",
      "example": [],
      "syntax": {
        "content": "public void Broadcast(string message)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Broadcast(message As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String)"
      ],
      "nameWithType.vb": "RustServer.Broadcast(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(String)",
      "name.vb": "Broadcast(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(System.String,System.Object[])",
      "id": "Command(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustServer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command(string, params object[])",
      "nameWithType": "RustServer.Command(string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustServer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustServer.cs",
        "startLine": 217,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Runs the specified server command",
      "example": [],
      "syntax": {
        "content": "public void Command(string command, params object[] args)",
        "parameters": [
          {
            "id": "command",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Command(command As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IServer.Command(System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustServer.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())"
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
      "uid": "Oxide.Core.Libraries.Covalence.IServer",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IServer",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IServer",
      "nameWithType": "IServer",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Name",
      "name": "Name",
      "nameWithType": "RustServer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Name"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Name",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Name",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Name",
      "nameWithType": "IServer.Name",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Name"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Address",
      "name": "Address",
      "nameWithType": "RustServer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Address"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Address",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Address",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Address",
      "nameWithType": "IServer.Address",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Address"
    },
    {
      "uid": "System.Net.IPAddress",
      "commentId": "T:System.Net.IPAddress",
      "parent": "System.Net",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.net.ipaddress",
      "name": "IPAddress",
      "nameWithType": "IPAddress",
      "fullName": "System.Net.IPAddress"
    },
    {
      "uid": "System.Net",
      "commentId": "N:System.Net",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System.Net",
      "nameWithType": "System.Net",
      "fullName": "System.Net",
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
          "uid": "System.Net",
          "name": "Net",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.net"
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
          "uid": "System.Net",
          "name": "Net",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.net"
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress",
      "name": "LocalAddress",
      "nameWithType": "RustServer.LocalAddress",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.LocalAddress"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.LocalAddress",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.LocalAddress",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "LocalAddress",
      "nameWithType": "IServer.LocalAddress",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.LocalAddress"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Port",
      "name": "Port",
      "nameWithType": "RustServer.Port",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Port"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Port",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Port",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Port",
      "nameWithType": "IServer.Port",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Port"
    },
    {
      "uid": "System.UInt16",
      "commentId": "T:System.UInt16",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.uint16",
      "name": "ushort",
      "nameWithType": "ushort",
      "fullName": "ushort",
      "nameWithType.vb": "UShort",
      "fullName.vb": "UShort",
      "name.vb": "UShort"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Version",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Version",
      "name": "Version",
      "nameWithType": "RustServer.Version",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Version"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Version",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Version",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Version",
      "nameWithType": "IServer.Version",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Version"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol",
      "name": "Protocol",
      "nameWithType": "RustServer.Protocol",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Protocol"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Protocol",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Protocol",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Protocol",
      "nameWithType": "IServer.Protocol",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Protocol"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Language",
      "name": "Language",
      "nameWithType": "RustServer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Language"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Language",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Language",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Language",
      "nameWithType": "IServer.Language",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Language"
    },
    {
      "uid": "System.Globalization.CultureInfo",
      "commentId": "T:System.Globalization.CultureInfo",
      "parent": "System.Globalization",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo",
      "name": "CultureInfo",
      "nameWithType": "CultureInfo",
      "fullName": "System.Globalization.CultureInfo"
    },
    {
      "uid": "System.Globalization",
      "commentId": "N:System.Globalization",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System.Globalization",
      "nameWithType": "System.Globalization",
      "fullName": "System.Globalization",
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
          "uid": "System.Globalization",
          "name": "Globalization",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.globalization"
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
          "uid": "System.Globalization",
          "name": "Globalization",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.globalization"
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Players",
      "name": "Players",
      "nameWithType": "RustServer.Players",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Players"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Players",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Players",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Players",
      "nameWithType": "IServer.Players",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Players"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers",
      "name": "MaxPlayers",
      "nameWithType": "RustServer.MaxPlayers",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.MaxPlayers"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.MaxPlayers",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.MaxPlayers",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "MaxPlayers",
      "nameWithType": "IServer.MaxPlayers",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.MaxPlayers"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Time",
      "name": "Time",
      "nameWithType": "RustServer.Time",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Time"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Time",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.Time",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Time",
      "nameWithType": "IServer.Time",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Time"
    },
    {
      "uid": "System.DateTime",
      "commentId": "T:System.DateTime",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.datetime",
      "name": "DateTime",
      "nameWithType": "DateTime",
      "fullName": "System.DateTime",
      "nameWithType.vb": "Date",
      "fullName.vb": "Date",
      "name.vb": "Date"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo",
      "name": "SaveInfo",
      "nameWithType": "RustServer.SaveInfo",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.SaveInfo"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.SaveInfo",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IServer.SaveInfo",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "SaveInfo",
      "nameWithType": "IServer.SaveInfo",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.SaveInfo"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.SaveInfo",
      "commentId": "T:Oxide.Core.Libraries.Covalence.SaveInfo",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "SaveInfo",
      "nameWithType": "SaveInfo",
      "fullName": "Oxide.Core.Libraries.Covalence.SaveInfo"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban(System.String,System.String,System.TimeSpan)",
      "name": "Ban",
      "nameWithType": "RustServer.Ban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Ban"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Ban(System.String,System.String,System.TimeSpan)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Ban(System.String,System.String,System.TimeSpan)",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Ban(string, string, TimeSpan)",
      "nameWithType": "IServer.Ban(string, string, TimeSpan)",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Ban(string, string, System.TimeSpan)",
      "nameWithType.vb": "IServer.Ban(String, String, TimeSpan)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.Ban(String, String, System.TimeSpan)",
      "name.vb": "Ban(String, String, TimeSpan)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Ban(System.String,System.String,System.TimeSpan)",
          "name": "Ban",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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
          "uid": "System.TimeSpan",
          "name": "TimeSpan",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.timespan"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Ban(System.String,System.String,System.TimeSpan)",
          "name": "Ban",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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
          "uid": "System.TimeSpan",
          "name": "TimeSpan",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.timespan"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.TimeSpan",
      "commentId": "T:System.TimeSpan",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.timespan",
      "name": "TimeSpan",
      "nameWithType": "TimeSpan",
      "fullName": "System.TimeSpan"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining(System.String)",
      "name": "BanTimeRemaining",
      "nameWithType": "RustServer.BanTimeRemaining",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.BanTimeRemaining"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "BanTimeRemaining(string)",
      "nameWithType": "IServer.BanTimeRemaining(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(string)",
      "nameWithType.vb": "IServer.BanTimeRemaining(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(String)",
      "name.vb": "BanTimeRemaining(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(System.String)",
          "name": "BanTimeRemaining",
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
          "uid": "Oxide.Core.Libraries.Covalence.IServer.BanTimeRemaining(System.String)",
          "name": "BanTimeRemaining",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned(System.String)",
      "name": "IsBanned",
      "nameWithType": "RustServer.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.IsBanned"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.IsBanned(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.IsBanned(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "IsBanned(string)",
      "nameWithType": "IServer.IsBanned(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.IsBanned(string)",
      "nameWithType.vb": "IServer.IsBanned(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.IsBanned(String)",
      "name.vb": "IsBanned(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.IsBanned(System.String)",
          "name": "IsBanned",
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
          "uid": "Oxide.Core.Libraries.Covalence.IServer.IsBanned(System.String)",
          "name": "IsBanned",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Save",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Save",
      "name": "Save",
      "nameWithType": "RustServer.Save",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Save"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Save",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Save",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "name": "Save()",
      "nameWithType": "IServer.Save()",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Save()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Save",
          "name": "Save",
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
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Save",
          "name": "Save",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban(System.String)",
      "name": "Unban",
      "nameWithType": "RustServer.Unban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Unban"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Unban(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Unban(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Unban(string)",
      "nameWithType": "IServer.Unban(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Unban(string)",
      "nameWithType.vb": "IServer.Unban(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.Unban(String)",
      "name.vb": "Unban(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Unban(System.String)",
          "name": "Unban",
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
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Unban(System.String)",
          "name": "Unban",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast(System.String,System.String,System.Object[])",
      "name": "Broadcast",
      "nameWithType": "RustServer.Broadcast",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Broadcast"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String,System.String,System.Object[])",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Broadcast(string, string, params object[])",
      "nameWithType": "IServer.Broadcast(string, string, params object[])",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(string, string, params object[])",
      "nameWithType.vb": "IServer.Broadcast(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(String, String, ParamArray Object())",
      "name.vb": "Broadcast(String, String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String,System.String,System.Object[])",
          "name": "Broadcast",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String,System.String,System.Object[])",
          "name": "Broadcast",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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
          "name": "ParamArray",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object[]",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "object[]",
      "nameWithType": "object[]",
      "fullName": "object[]",
      "nameWithType.vb": "Object()",
      "fullName.vb": "Object()",
      "name.vb": "Object()",
      "spec.csharp": [
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
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
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Broadcast(string)",
      "nameWithType": "IServer.Broadcast(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(string)",
      "nameWithType.vb": "IServer.Broadcast(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(String)",
      "name.vb": "Broadcast(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String)",
          "name": "Broadcast",
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
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Broadcast(System.String)",
          "name": "Broadcast",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustServer.Command",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustServer.html#Oxide.Game.Rust.Libraries.Covalence.RustServer.Command(System.String,System.Object[])",
      "name": "Command",
      "nameWithType": "RustServer.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustServer.Command"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IServer.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IServer.Command(System.String,System.Object[])",
      "parent": "Oxide.Core.Libraries.Covalence.IServer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Command(string, params object[])",
      "nameWithType": "IServer.Command(string, params object[])",
      "fullName": "Oxide.Core.Libraries.Covalence.IServer.Command(string, params object[])",
      "nameWithType.vb": "IServer.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IServer.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Command(System.String,System.Object[])",
          "name": "Command",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IServer.Command(System.String,System.Object[])",
          "name": "Command",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "name": "ParamArray",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
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