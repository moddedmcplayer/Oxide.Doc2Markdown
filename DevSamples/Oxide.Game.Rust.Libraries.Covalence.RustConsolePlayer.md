# Class RustConsolePlayer
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustConsolePlayer : IPlayer
```  
#### The player object that represents the server console


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public object Object { get; }
```
Object
```csharp
public CommandType LastCommand { get; set; }
```
LastCommand
```csharp
public string Name { get; set; }
```
Name
```csharp
public string Id { get; }
```
Id
```csharp
public CultureInfo Language { get; }
```
Language
```csharp
public string Address { get; }
```
Address
```csharp
public int Ping { get; }
```
Ping
```csharp
public bool IsAdmin { get; }
```
IsAdmin
```csharp
public bool IsBanned { get; }
```
IsBanned
```csharp
public bool IsConnected { get; }
```
IsConnected
```csharp
public bool IsSleeping { get; }
```
IsSleeping
```csharp
public bool IsServer { get; }
```
IsServer
```csharp
public TimeSpan BanTimeRemaining { get; }
```
BanTimeRemaining
```csharp
public float Health { get; set; }
```
Health
```csharp
public float MaxHealth { get; set; }
```
MaxHealth
## Methods 
```csharp
public void Ban(string reason, TimeSpan duration)
```
Ban(string, TimeSpan)
```csharp
public void Heal(float amount)
```
Heal(float)
```csharp
public void Hurt(float amount)
```
Hurt(float)
```csharp
public void Kick(string reason)
```
Kick(string)
```csharp
public void Kill()
```
Kill()
```csharp
public void Rename(string name)
```
Rename(string)
```csharp
public void Teleport(float x, float y, float z)
```
Teleport(float, float, float)
```csharp
public void Teleport(GenericPosition pos)
```
Teleport(GenericPosition)
```csharp
public void Unban()
```
Unban()
```csharp
public void Position(out float x, out float y, out float z)
```
Position(out float, out float, out float)
```csharp
public GenericPosition Position()
```
Position()
```csharp
public void Message(string message, string prefix, params object[] args)
```
Message(string, string, params object[])
```csharp
public void Message(string message)
```
Message(string)
```csharp
public void Reply(string message, string prefix, params object[] args)
```
Reply(string, string, params object[])
```csharp
public void Reply(string message)
```
Reply(string)
```csharp
public void Command(string command, params object[] args)
```
Command(string, params object[])
```csharp
public bool HasPermission(string perm)
```
HasPermission(string)
```csharp
public void GrantPermission(string perm)
```
GrantPermission(string)
```csharp
public void RevokePermission(string perm)
```
RevokePermission(string)
```csharp
public bool BelongsToGroup(string group)
```
BelongsToGroup(string)
```csharp
public void AddToGroup(string group)
```
AddToGroup(string)
```csharp
public void RemoveFromGroup(string group)
```
RemoveFromGroup(string)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "id": "RustConsolePlayer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(System.String,System.TimeSpan)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(System.Single@,System.Single@,System.Single@)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(System.Single,System.Single,System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustConsolePlayer",
      "nameWithType": "RustConsolePlayer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustConsolePlayer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 10,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "The player object that represents the server console",
      "example": [],
      "syntax": {
        "content": "public class RustConsolePlayer : IPlayer",
        "content.vb": "Public Class RustConsolePlayer Implements IPlayer"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
      "id": "Object",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Object",
      "nameWithType": "RustConsolePlayer.Object",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Object",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 17,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the object that backs the player",
      "example": [],
      "syntax": {
        "content": "public object Object { get; }",
        "parameters": [],
        "return": {
          "type": "System.Object"
        },
        "content.vb": "Public ReadOnly Property [Object] As Object"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Object"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
      "id": "LastCommand",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "LastCommand",
      "nameWithType": "RustConsolePlayer.LastCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "LastCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 22,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the player's last command type",
      "example": [],
      "syntax": {
        "content": "public CommandType LastCommand { get; set; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.CommandType"
        },
        "content.vb": "Public Property LastCommand As CommandType"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.LastCommand"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
      "id": "Name",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Name",
      "nameWithType": "RustConsolePlayer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Name",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 31,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the name for the player",
      "example": [],
      "syntax": {
        "content": "public string Name { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Property Name As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Name"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
      "id": "Id",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Id",
      "nameWithType": "RustConsolePlayer.Id",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Id",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 36,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the ID for the player (unique within the current game)",
      "example": [],
      "syntax": {
        "content": "public string Id { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property Id As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Id"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
      "id": "Language",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Language",
      "nameWithType": "RustConsolePlayer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Language",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 41,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the player's language",
      "example": [],
      "syntax": {
        "content": "public CultureInfo Language { get; }",
        "parameters": [],
        "return": {
          "type": "System.Globalization.CultureInfo"
        },
        "content.vb": "Public ReadOnly Property Language As CultureInfo"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Language"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
      "id": "Address",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Address",
      "nameWithType": "RustConsolePlayer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Address",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 46,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the player's IP address",
      "example": [],
      "syntax": {
        "content": "public string Address { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public ReadOnly Property Address As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Address"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
      "id": "Ping",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ping",
      "nameWithType": "RustConsolePlayer.Ping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 51,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the player's average network ping",
      "example": [],
      "syntax": {
        "content": "public int Ping { get; }",
        "parameters": [],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "Public ReadOnly Property Ping As Integer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Ping"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
      "id": "IsAdmin",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsAdmin",
      "nameWithType": "RustConsolePlayer.IsAdmin",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsAdmin",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 56,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if the player is admin",
      "example": [],
      "syntax": {
        "content": "public bool IsAdmin { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public ReadOnly Property IsAdmin As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsAdmin"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
      "id": "IsBanned",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned",
      "nameWithType": "RustConsolePlayer.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 61,
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
        "content": "public bool IsBanned { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public ReadOnly Property IsBanned As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsBanned"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
      "id": "IsConnected",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsConnected",
      "nameWithType": "RustConsolePlayer.IsConnected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsConnected",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 66,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if the player is connected",
      "example": [],
      "syntax": {
        "content": "public bool IsConnected { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public ReadOnly Property IsConnected As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsConnected"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
      "id": "IsSleeping",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsSleeping",
      "nameWithType": "RustConsolePlayer.IsSleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsSleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 71,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if the player is sleeping",
      "example": [],
      "syntax": {
        "content": "public bool IsSleeping { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public ReadOnly Property IsSleeping As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsSleeping"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
      "id": "IsServer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsServer",
      "nameWithType": "RustConsolePlayer.IsServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsServer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 76,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if the player is the server",
      "example": [],
      "syntax": {
        "content": "public bool IsServer { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public ReadOnly Property IsServer As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsServer"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(System.String,System.TimeSpan)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(System.String,System.TimeSpan)",
      "id": "Ban(System.String,System.TimeSpan)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(string, TimeSpan)",
      "nameWithType": "RustConsolePlayer.Ban(string, TimeSpan)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(string, System.TimeSpan)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 87,
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
        "content": "public void Ban(string reason, TimeSpan duration)",
        "parameters": [
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
        "content.vb": "Public Sub Ban(reason As String, duration As TimeSpan)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Ban(String, TimeSpan)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(String, System.TimeSpan)",
      "name.vb": "Ban(String, TimeSpan)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
      "id": "BanTimeRemaining",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BanTimeRemaining",
      "nameWithType": "RustConsolePlayer.BanTimeRemaining",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BanTimeRemaining",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 94,
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
        "content": "public TimeSpan BanTimeRemaining { get; }",
        "parameters": [],
        "return": {
          "type": "System.TimeSpan"
        },
        "content.vb": "Public ReadOnly Property BanTimeRemaining As TimeSpan"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.BanTimeRemaining"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(System.Single)",
      "id": "Heal(System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Heal(float)",
      "nameWithType": "RustConsolePlayer.Heal(float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Heal",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 100,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Heals the player's character by specified amount",
      "example": [],
      "syntax": {
        "content": "public void Heal(float amount)",
        "parameters": [
          {
            "id": "amount",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Heal(amount As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Heal(Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(Single)",
      "name.vb": "Heal(Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
      "id": "Health",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Health",
      "nameWithType": "RustConsolePlayer.Health",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Health",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 107,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the player's health",
      "example": [],
      "syntax": {
        "content": "public float Health { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Single"
        },
        "content.vb": "Public Property Health As Single"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Health"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(System.Single)",
      "id": "Hurt(System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Hurt(float)",
      "nameWithType": "RustConsolePlayer.Hurt(float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Hurt",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 113,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Damages the player's character by specified amount",
      "example": [],
      "syntax": {
        "content": "public void Hurt(float amount)",
        "parameters": [
          {
            "id": "amount",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Hurt(amount As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Hurt(Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(Single)",
      "name.vb": "Hurt(Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(System.String)",
      "id": "Kick(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kick(string)",
      "nameWithType": "RustConsolePlayer.Kick(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kick",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 121,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Kicks the player from the game",
      "example": [],
      "syntax": {
        "content": "public void Kick(string reason)",
        "parameters": [
          {
            "id": "reason",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Kick(reason As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Kick(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(String)",
      "name.vb": "Kick(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill",
      "id": "Kill",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kill()",
      "nameWithType": "RustConsolePlayer.Kill()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kill",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 128,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Causes the player's character to die",
      "example": [],
      "syntax": {
        "content": "public void Kill()",
        "content.vb": "Public Sub Kill()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Kill"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
      "id": "MaxHealth",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "MaxHealth",
      "nameWithType": "RustConsolePlayer.MaxHealth",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "MaxHealth",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 135,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets/sets the player's maximum health",
      "example": [],
      "syntax": {
        "content": "public float MaxHealth { get; set; }",
        "parameters": [],
        "return": {
          "type": "System.Single"
        },
        "content.vb": "Public Property MaxHealth As Single"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.MaxHealth"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(System.String)",
      "id": "Rename(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Rename(string)",
      "nameWithType": "RustConsolePlayer.Rename(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Rename",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 141,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Renames the player to specified name\n<param name=\"name\" />",
      "example": [],
      "syntax": {
        "content": "public void Rename(string name)",
        "parameters": [
          {
            "id": "name",
            "type": "System.String"
          }
        ],
        "content.vb": "Public Sub Rename(name As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Rename(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(String)",
      "name.vb": "Rename(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(System.Single,System.Single,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(System.Single,System.Single,System.Single)",
      "id": "Teleport(System.Single,System.Single,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(float, float, float)",
      "nameWithType": "RustConsolePlayer.Teleport(float, float, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(float, float, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 151,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Teleports the player's character to the specified position",
      "example": [],
      "syntax": {
        "content": "public void Teleport(float x, float y, float z)",
        "parameters": [
          {
            "id": "x",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "y",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "z",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Teleport(x As Single, y As Single, z As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Teleport(Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(Single, Single, Single)",
      "name.vb": "Teleport(Single, Single, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "id": "Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(GenericPosition)",
      "nameWithType": "RustConsolePlayer.Teleport(GenericPosition)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 159,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Teleports the player's character to the specified generic position",
      "example": [],
      "syntax": {
        "content": "public void Teleport(GenericPosition pos)",
        "parameters": [
          {
            "id": "pos",
            "type": "Oxide.Core.Libraries.Covalence.GenericPosition",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Teleport(pos As GenericPosition)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban",
      "id": "Unban",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban()",
      "nameWithType": "RustConsolePlayer.Unban()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 164,
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
        "content": "public void Unban()",
        "content.vb": "Public Sub Unban()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Unban"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(System.Single@,System.Single@,System.Single@)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(System.Single@,System.Single@,System.Single@)",
      "id": "Position(System.Single@,System.Single@,System.Single@)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Position(out float, out float, out float)",
      "nameWithType": "RustConsolePlayer.Position(out float, out float, out float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(out float, out float, out float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Position",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 178,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the position of the player",
      "example": [],
      "syntax": {
        "content": "public void Position(out float x, out float y, out float z)",
        "parameters": [
          {
            "id": "x",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "y",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "z",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Position(x As Single, y As Single, z As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Position(Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(Single, Single, Single)",
      "name.vb": "Position(Single, Single, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position",
      "id": "Position",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Position()",
      "nameWithType": "RustConsolePlayer.Position()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Position",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 189,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the position of the player",
      "example": [],
      "syntax": {
        "content": "public GenericPosition Position()",
        "return": {
          "type": "Oxide.Core.Libraries.Covalence.GenericPosition",
          "description": ""
        },
        "content.vb": "Public Function Position() As GenericPosition"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Position"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String,System.String,System.Object[])",
      "id": "Message(System.String,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(string, string, params object[])",
      "nameWithType": "RustConsolePlayer.Message(string, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(string, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 201,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Sends the specified message and prefix to the player",
      "example": [],
      "syntax": {
        "content": "public void Message(string message, string prefix, params object[] args)",
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
        "content.vb": "Public Sub Message(message As String, prefix As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustConsolePlayer.Message(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(String, String, ParamArray Object())",
      "name.vb": "Message(String, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String)",
      "id": "Message(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(string)",
      "nameWithType": "RustConsolePlayer.Message(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 212,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Sends the specified message to the player",
      "example": [],
      "syntax": {
        "content": "public void Message(string message)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Message(message As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Message(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(String)",
      "name.vb": "Message(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String,System.String,System.Object[])",
      "id": "Reply(System.String,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(string, string, params object[])",
      "nameWithType": "RustConsolePlayer.Reply(string, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(string, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 220,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Replies to the player with the specified message and prefix",
      "example": [],
      "syntax": {
        "content": "public void Reply(string message, string prefix, params object[] args)",
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
        "content.vb": "Public Sub Reply(message As String, prefix As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustConsolePlayer.Reply(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(String, String, ParamArray Object())",
      "name.vb": "Reply(String, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String)",
      "id": "Reply(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(string)",
      "nameWithType": "RustConsolePlayer.Reply(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 229,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Replies to the player with the specified message",
      "example": [],
      "syntax": {
        "content": "public void Reply(string message)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Reply(message As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.Reply(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(String)",
      "name.vb": "Reply(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(System.String,System.Object[])",
      "id": "Command(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command(string, params object[])",
      "nameWithType": "RustConsolePlayer.Command(string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 236,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Runs the specified console command on the player",
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustConsolePlayer.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(System.String)",
      "id": "HasPermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "HasPermission(string)",
      "nameWithType": "RustConsolePlayer.HasPermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "HasPermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 250,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets if the player has the specified permission",
      "example": [],
      "syntax": {
        "content": "public bool HasPermission(string perm)",
        "parameters": [
          {
            "id": "perm",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Function HasPermission(perm As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.HasPermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(String)",
      "name.vb": "HasPermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(System.String)",
      "id": "GrantPermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GrantPermission(string)",
      "nameWithType": "RustConsolePlayer.GrantPermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GrantPermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 256,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Grants the specified permission on this player",
      "example": [],
      "syntax": {
        "content": "public void GrantPermission(string perm)",
        "parameters": [
          {
            "id": "perm",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub GrantPermission(perm As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.GrantPermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(String)",
      "name.vb": "GrantPermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(System.String)",
      "id": "RevokePermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RevokePermission(string)",
      "nameWithType": "RustConsolePlayer.RevokePermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RevokePermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 264,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Strips the specified permission from this player",
      "example": [],
      "syntax": {
        "content": "public void RevokePermission(string perm)",
        "parameters": [
          {
            "id": "perm",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub RevokePermission(perm As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.RevokePermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(String)",
      "name.vb": "RevokePermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(System.String)",
      "id": "BelongsToGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BelongsToGroup(string)",
      "nameWithType": "RustConsolePlayer.BelongsToGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BelongsToGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 273,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets if the player belongs to the specified group",
      "example": [],
      "syntax": {
        "content": "public bool BelongsToGroup(string group)",
        "parameters": [
          {
            "id": "group",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Function BelongsToGroup(group As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.BelongsToGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(String)",
      "name.vb": "BelongsToGroup(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(System.String)",
      "id": "AddToGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddToGroup(string)",
      "nameWithType": "RustConsolePlayer.AddToGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddToGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 279,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Adds the player to the specified group",
      "example": [],
      "syntax": {
        "content": "public void AddToGroup(string group)",
        "parameters": [
          {
            "id": "group",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub AddToGroup(group As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.AddToGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(String)",
      "name.vb": "AddToGroup(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(System.String)",
      "id": "RemoveFromGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RemoveFromGroup(string)",
      "nameWithType": "RustConsolePlayer.RemoveFromGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustConsolePlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RemoveFromGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustConsolePlayer.cs",
        "startLine": 287,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Removes the player from the specified group",
      "example": [],
      "syntax": {
        "content": "public void RemoveFromGroup(string group)",
        "parameters": [
          {
            "id": "group",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub RemoveFromGroup(group As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)"
      ],
      "nameWithType.vb": "RustConsolePlayer.RemoveFromGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(String)",
      "name.vb": "RemoveFromGroup(String)"
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IPlayer",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IPlayer",
      "nameWithType": "IPlayer",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object",
      "name": "Object",
      "nameWithType": "RustConsolePlayer.Object",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Object"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Object",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Object",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Object",
      "nameWithType": "IPlayer.Object",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Object"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand",
      "name": "LastCommand",
      "nameWithType": "RustConsolePlayer.LastCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.LastCommand"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.LastCommand",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.LastCommand",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "LastCommand",
      "nameWithType": "IPlayer.LastCommand",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.LastCommand"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.CommandType",
      "commentId": "T:Oxide.Core.Libraries.Covalence.CommandType",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "CommandType",
      "nameWithType": "CommandType",
      "fullName": "Oxide.Core.Libraries.Covalence.CommandType"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name",
      "name": "Name",
      "nameWithType": "RustConsolePlayer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Name"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Name",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Name",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Name",
      "nameWithType": "IPlayer.Name",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Name"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id",
      "name": "Id",
      "nameWithType": "RustConsolePlayer.Id",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Id"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Id",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Id",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Id",
      "nameWithType": "IPlayer.Id",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Id"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language",
      "name": "Language",
      "nameWithType": "RustConsolePlayer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Language"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Language",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Language",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Language",
      "nameWithType": "IPlayer.Language",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Language"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address",
      "name": "Address",
      "nameWithType": "RustConsolePlayer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Address"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Address",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Address",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Address",
      "nameWithType": "IPlayer.Address",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Address"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping",
      "name": "Ping",
      "nameWithType": "RustConsolePlayer.Ping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ping"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Ping",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Ping",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Ping",
      "nameWithType": "IPlayer.Ping",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Ping"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin",
      "name": "IsAdmin",
      "nameWithType": "RustConsolePlayer.IsAdmin",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsAdmin"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.IsAdmin",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.IsAdmin",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "IsAdmin",
      "nameWithType": "IPlayer.IsAdmin",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.IsAdmin"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned",
      "name": "IsBanned",
      "nameWithType": "RustConsolePlayer.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsBanned"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.IsBanned",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.IsBanned",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "IsBanned",
      "nameWithType": "IPlayer.IsBanned",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.IsBanned"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected",
      "name": "IsConnected",
      "nameWithType": "RustConsolePlayer.IsConnected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsConnected"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.IsConnected",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.IsConnected",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "IsConnected",
      "nameWithType": "IPlayer.IsConnected",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.IsConnected"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping",
      "name": "IsSleeping",
      "nameWithType": "RustConsolePlayer.IsSleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsSleeping"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.IsSleeping",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.IsSleeping",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "IsSleeping",
      "nameWithType": "IPlayer.IsSleeping",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.IsSleeping"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer",
      "name": "IsServer",
      "nameWithType": "RustConsolePlayer.IsServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.IsServer"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.IsServer",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.IsServer",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "IsServer",
      "nameWithType": "IPlayer.IsServer",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.IsServer"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban(System.String,System.TimeSpan)",
      "name": "Ban",
      "nameWithType": "RustConsolePlayer.Ban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Ban"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Ban(string, TimeSpan)",
      "nameWithType": "IPlayer.Ban(string, TimeSpan)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Ban(string, System.TimeSpan)",
      "nameWithType.vb": "IPlayer.Ban(String, TimeSpan)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Ban(String, System.TimeSpan)",
      "name.vb": "Ban(String, TimeSpan)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining",
      "name": "BanTimeRemaining",
      "nameWithType": "RustConsolePlayer.BanTimeRemaining",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BanTimeRemaining"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.BanTimeRemaining",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.BanTimeRemaining",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "BanTimeRemaining",
      "nameWithType": "IPlayer.BanTimeRemaining",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.BanTimeRemaining"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal(System.Single)",
      "name": "Heal",
      "nameWithType": "RustConsolePlayer.Heal",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Heal"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "Heal(float)",
      "nameWithType": "IPlayer.Heal(float)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Heal(float)",
      "nameWithType.vb": "IPlayer.Heal(Single)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Heal(Single)",
      "name.vb": "Heal(Single)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)",
          "name": "Heal",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)",
          "name": "Heal",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health",
      "name": "Health",
      "nameWithType": "RustConsolePlayer.Health",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Health"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Health",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.Health",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Health",
      "nameWithType": "IPlayer.Health",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Health"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt(System.Single)",
      "name": "Hurt",
      "nameWithType": "RustConsolePlayer.Hurt",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Hurt"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "Hurt(float)",
      "nameWithType": "IPlayer.Hurt(float)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(float)",
      "nameWithType.vb": "IPlayer.Hurt(Single)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(Single)",
      "name.vb": "Hurt(Single)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)",
          "name": "Hurt",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)",
          "name": "Hurt",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick(System.String)",
      "name": "Kick",
      "nameWithType": "RustConsolePlayer.Kick",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kick"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Kick(string)",
      "nameWithType": "IPlayer.Kick(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Kick(string)",
      "nameWithType.vb": "IPlayer.Kick(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Kick(String)",
      "name.vb": "Kick(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)",
          "name": "Kick",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)",
          "name": "Kick",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill",
      "name": "Kill",
      "nameWithType": "RustConsolePlayer.Kill",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Kill"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kill",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Kill",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Kill()",
      "nameWithType": "IPlayer.Kill()",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Kill()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kill",
          "name": "Kill",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Kill",
          "name": "Kill",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth",
      "name": "MaxHealth",
      "nameWithType": "RustConsolePlayer.MaxHealth",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.MaxHealth"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.MaxHealth",
      "commentId": "P:Oxide.Core.Libraries.Covalence.IPlayer.MaxHealth",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "MaxHealth",
      "nameWithType": "IPlayer.MaxHealth",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.MaxHealth"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename(System.String)",
      "name": "Rename",
      "nameWithType": "RustConsolePlayer.Rename",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Rename"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Rename(string)",
      "nameWithType": "IPlayer.Rename(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Rename(string)",
      "nameWithType.vb": "IPlayer.Rename(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Rename(String)",
      "name.vb": "Rename(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)",
          "name": "Rename",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)",
          "name": "Rename",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport(System.Single,System.Single,System.Single)",
      "name": "Teleport",
      "nameWithType": "RustConsolePlayer.Teleport",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Teleport"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "Teleport(float, float, float)",
      "nameWithType": "IPlayer.Teleport(float, float, float)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(float, float, float)",
      "nameWithType.vb": "IPlayer.Teleport(Single, Single, Single)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Single, Single, Single)",
      "name.vb": "Teleport(Single, Single, Single)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)",
          "name": "Teleport",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)",
          "name": "Teleport",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Teleport(GenericPosition)",
      "nameWithType": "IPlayer.Teleport(GenericPosition)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
          "name": "Teleport",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence.GenericPosition",
          "name": "GenericPosition",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
          "name": "Teleport",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence.GenericPosition",
          "name": "GenericPosition",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.GenericPosition",
      "commentId": "T:Oxide.Core.Libraries.Covalence.GenericPosition",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "GenericPosition",
      "nameWithType": "GenericPosition",
      "fullName": "Oxide.Core.Libraries.Covalence.GenericPosition"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban",
      "name": "Unban",
      "nameWithType": "RustConsolePlayer.Unban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Unban"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Unban",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Unban",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Unban()",
      "nameWithType": "IPlayer.Unban()",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Unban()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Unban",
          "name": "Unban",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Unban",
          "name": "Unban",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position(System.Single@,System.Single@,System.Single@)",
      "name": "Position",
      "nameWithType": "RustConsolePlayer.Position",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Position"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "Position(out float, out float, out float)",
      "nameWithType": "IPlayer.Position(out float, out float, out float)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Position(out float, out float, out float)",
      "nameWithType.vb": "IPlayer.Position(Single, Single, Single)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Position(Single, Single, Single)",
      "name.vb": "Position(Single, Single, Single)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)",
          "name": "Position",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "out",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "name": "out",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "name": "out",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "float",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)",
          "name": "Position",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
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
          "uid": "System.Single",
          "name": "Single",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.single"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Position",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "name": "Position()",
      "nameWithType": "IPlayer.Position()",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Position()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position",
          "name": "Position",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Position",
          "name": "Position",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message(System.String,System.String,System.Object[])",
      "name": "Message",
      "nameWithType": "RustConsolePlayer.Message",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Message"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Message(string, string, params object[])",
      "nameWithType": "IPlayer.Message(string, string, params object[])",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Message(string, string, params object[])",
      "nameWithType.vb": "IPlayer.Message(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Message(String, String, ParamArray Object())",
      "name.vb": "Message(String, String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])",
          "name": "Message",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])",
          "name": "Message",
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Message(string)",
      "nameWithType": "IPlayer.Message(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Message(string)",
      "nameWithType.vb": "IPlayer.Message(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Message(String)",
      "name.vb": "Message(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)",
          "name": "Message",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)",
          "name": "Message",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply(System.String,System.String,System.Object[])",
      "name": "Reply",
      "nameWithType": "RustConsolePlayer.Reply",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Reply"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Reply(string, string, params object[])",
      "nameWithType": "IPlayer.Reply(string, string, params object[])",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(string, string, params object[])",
      "nameWithType.vb": "IPlayer.Reply(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(String, String, ParamArray Object())",
      "name.vb": "Reply(String, String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])",
          "name": "Reply",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])",
          "name": "Reply",
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
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Reply(string)",
      "nameWithType": "IPlayer.Reply(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(string)",
      "nameWithType.vb": "IPlayer.Reply(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(String)",
      "name.vb": "Reply(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)",
          "name": "Reply",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)",
          "name": "Reply",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command(System.String,System.Object[])",
      "name": "Command",
      "nameWithType": "RustConsolePlayer.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.Command"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Command(string, params object[])",
      "nameWithType": "IPlayer.Command(string, params object[])",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.Command(string, params object[])",
      "nameWithType.vb": "IPlayer.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])",
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
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission(System.String)",
      "name": "HasPermission",
      "nameWithType": "RustConsolePlayer.HasPermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.HasPermission"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "HasPermission(string)",
      "nameWithType": "IPlayer.HasPermission(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(string)",
      "nameWithType.vb": "IPlayer.HasPermission(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(String)",
      "name.vb": "HasPermission(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)",
          "name": "HasPermission",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)",
          "name": "HasPermission",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission(System.String)",
      "name": "GrantPermission",
      "nameWithType": "RustConsolePlayer.GrantPermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.GrantPermission"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GrantPermission(string)",
      "nameWithType": "IPlayer.GrantPermission(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(string)",
      "nameWithType.vb": "IPlayer.GrantPermission(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(String)",
      "name.vb": "GrantPermission(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)",
          "name": "GrantPermission",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)",
          "name": "GrantPermission",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission(System.String)",
      "name": "RevokePermission",
      "nameWithType": "RustConsolePlayer.RevokePermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RevokePermission"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "RevokePermission(string)",
      "nameWithType": "IPlayer.RevokePermission(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(string)",
      "nameWithType.vb": "IPlayer.RevokePermission(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(String)",
      "name.vb": "RevokePermission(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)",
          "name": "RevokePermission",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)",
          "name": "RevokePermission",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup(System.String)",
      "name": "BelongsToGroup",
      "nameWithType": "RustConsolePlayer.BelongsToGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.BelongsToGroup"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "BelongsToGroup(string)",
      "nameWithType": "IPlayer.BelongsToGroup(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(string)",
      "nameWithType.vb": "IPlayer.BelongsToGroup(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(String)",
      "name.vb": "BelongsToGroup(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)",
          "name": "BelongsToGroup",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)",
          "name": "BelongsToGroup",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup(System.String)",
      "name": "AddToGroup",
      "nameWithType": "RustConsolePlayer.AddToGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.AddToGroup"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddToGroup(string)",
      "nameWithType": "IPlayer.AddToGroup(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(string)",
      "nameWithType.vb": "IPlayer.AddToGroup(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(String)",
      "name.vb": "AddToGroup(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)",
          "name": "AddToGroup",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)",
          "name": "AddToGroup",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup(System.String)",
      "name": "RemoveFromGroup",
      "nameWithType": "RustConsolePlayer.RemoveFromGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustConsolePlayer.RemoveFromGroup"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)",
      "parent": "Oxide.Core.Libraries.Covalence.IPlayer",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "RemoveFromGroup(string)",
      "nameWithType": "IPlayer.RemoveFromGroup(string)",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(string)",
      "nameWithType.vb": "IPlayer.RemoveFromGroup(String)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(String)",
      "name.vb": "RemoveFromGroup(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)",
          "name": "RemoveFromGroup",
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
          "uid": "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)",
          "name": "RemoveFromGroup",
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