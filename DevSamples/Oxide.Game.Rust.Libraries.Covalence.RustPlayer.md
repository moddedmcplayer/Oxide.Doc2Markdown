# Class RustPlayer
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustPlayer : IPlayer, IEquatable<IPlayer>
```  
#### Represents a player, either connected or not


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

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
public void Ban(string reason, TimeSpan duration = default)
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
```csharp
public bool Equals(IPlayer other)
```
Equals(IPlayer)
```csharp
public override bool Equals(object obj)
```
Equals(object)
```csharp
public override int GetHashCode()
```
GetHashCode()
```csharp
public override string ToString()
```
ToString()






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "id": "RustPlayer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(System.String,System.TimeSpan)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(System.Object)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(System.Single@,System.Single@,System.Single@)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(System.Single,System.Single,System.Single)",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString",
        "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustPlayer",
      "nameWithType": "RustPlayer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustPlayer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 12,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Represents a player, either connected or not",
      "example": [],
      "syntax": {
        "content": "public class RustPlayer : IPlayer, IEquatable<IPlayer>",
        "content.vb": "Public Class RustPlayer Implements IPlayer, IEquatable(Of IPlayer)"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer",
        "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}"
      ],
      "inheritedMembers": [
        "System.Object.Equals(System.Object,System.Object)",
        "System.Object.ReferenceEquals(System.Object,System.Object)",
        "System.Object.GetType",
        "System.Object.MemberwiseClone"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
      "id": "Object",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Object",
      "nameWithType": "RustPlayer.Object",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Object",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 51,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Object"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
      "id": "LastCommand",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "LastCommand",
      "nameWithType": "RustPlayer.LastCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "LastCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 56,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.LastCommand"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
      "id": "Name",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Name",
      "nameWithType": "RustPlayer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Name",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 65,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Name"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
      "id": "Id",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Id",
      "nameWithType": "RustPlayer.Id",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Id",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 70,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Id"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
      "id": "Language",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Language",
      "nameWithType": "RustPlayer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Language",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 75,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Language"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
      "id": "Address",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Address",
      "nameWithType": "RustPlayer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Address",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 80,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Address"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
      "id": "Ping",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ping",
      "nameWithType": "RustPlayer.Ping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 85,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Ping"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
      "id": "IsAdmin",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsAdmin",
      "nameWithType": "RustPlayer.IsAdmin",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsAdmin",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 90,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsAdmin"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
      "id": "IsBanned",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned",
      "nameWithType": "RustPlayer.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 95,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsBanned"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
      "id": "IsConnected",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsConnected",
      "nameWithType": "RustPlayer.IsConnected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsConnected",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 100,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsConnected"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
      "id": "IsSleeping",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsSleeping",
      "nameWithType": "RustPlayer.IsSleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsSleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 105,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsSleeping"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
      "id": "IsServer",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsServer",
      "nameWithType": "RustPlayer.IsServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsServer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 110,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.IsServer"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(System.String,System.TimeSpan)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(System.String,System.TimeSpan)",
      "id": "Ban(System.String,System.TimeSpan)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(string, TimeSpan)",
      "nameWithType": "RustPlayer.Ban(string, TimeSpan)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(string, System.TimeSpan)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 121,
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
        "content": "public void Ban(string reason, TimeSpan duration = default)",
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
        "content.vb": "Public Sub Ban(reason As String, duration As TimeSpan = Nothing)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Ban(System.String,System.TimeSpan)"
      ],
      "nameWithType.vb": "RustPlayer.Ban(String, TimeSpan)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(String, System.TimeSpan)",
      "name.vb": "Ban(String, TimeSpan)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
      "id": "BanTimeRemaining",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BanTimeRemaining",
      "nameWithType": "RustPlayer.BanTimeRemaining",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BanTimeRemaining",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 126,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.BanTimeRemaining"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(System.Single)",
      "id": "Heal(System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Heal(float)",
      "nameWithType": "RustPlayer.Heal(float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Heal",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 132,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Heal(System.Single)"
      ],
      "nameWithType.vb": "RustPlayer.Heal(Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(Single)",
      "name.vb": "Heal(Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
      "id": "Health",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Health",
      "nameWithType": "RustPlayer.Health",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Health",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 137,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Health"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(System.Single)",
      "id": "Hurt(System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Hurt(float)",
      "nameWithType": "RustPlayer.Hurt(float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Hurt",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 147,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Hurt(System.Single)"
      ],
      "nameWithType.vb": "RustPlayer.Hurt(Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(Single)",
      "name.vb": "Hurt(Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(System.String)",
      "id": "Kick(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kick(string)",
      "nameWithType": "RustPlayer.Kick(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kick",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 153,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Kick(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.Kick(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(String)",
      "name.vb": "Kick(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill",
      "id": "Kill",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kill()",
      "nameWithType": "RustPlayer.Kill()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kill",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 158,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Kill"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
      "commentId": "P:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
      "id": "MaxHealth",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "MaxHealth",
      "nameWithType": "RustPlayer.MaxHealth",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "MaxHealth",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 163,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.MaxHealth"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(System.String)",
      "id": "Rename(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Rename(string)",
      "nameWithType": "RustPlayer.Rename(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Rename",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 173,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Rename(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.Rename(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(String)",
      "name.vb": "Rename(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(System.Single,System.Single,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(System.Single,System.Single,System.Single)",
      "id": "Teleport(System.Single,System.Single,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(float, float, float)",
      "nameWithType": "RustPlayer.Teleport(float, float, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(float, float, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 181,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(System.Single,System.Single,System.Single)"
      ],
      "nameWithType.vb": "RustPlayer.Teleport(Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(Single, Single, Single)",
      "name.vb": "Teleport(Single, Single, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "id": "Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(GenericPosition)",
      "nameWithType": "RustPlayer.Teleport(GenericPosition)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 187,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Teleport(Oxide.Core.Libraries.Covalence.GenericPosition)"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban",
      "id": "Unban",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban()",
      "nameWithType": "RustPlayer.Unban()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 192,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Unban"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(System.Single@,System.Single@,System.Single@)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(System.Single@,System.Single@,System.Single@)",
      "id": "Position(System.Single@,System.Single@,System.Single@)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Position(out float, out float, out float)",
      "nameWithType": "RustPlayer.Position(out float, out float, out float)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(out float, out float, out float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Position",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 204,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Position(System.Single@,System.Single@,System.Single@)"
      ],
      "nameWithType.vb": "RustPlayer.Position(Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(Single, Single, Single)",
      "name.vb": "Position(Single, Single, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position",
      "id": "Position",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Position()",
      "nameWithType": "RustPlayer.Position()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Position",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 216,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Position"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String,System.String,System.Object[])",
      "id": "Message(System.String,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(string, string, params object[])",
      "nameWithType": "RustPlayer.Message(string, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(string, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 232,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String,System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustPlayer.Message(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(String, String, ParamArray Object())",
      "name.vb": "Message(String, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String)",
      "id": "Message(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(string)",
      "nameWithType": "RustPlayer.Message(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 241,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Message(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.Message(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(String)",
      "name.vb": "Message(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String,System.String,System.Object[])",
      "id": "Reply(System.String,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(string, string, params object[])",
      "nameWithType": "RustPlayer.Reply(string, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(string, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 249,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String,System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustPlayer.Reply(String, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(String, String, ParamArray Object())",
      "name.vb": "Reply(String, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String)",
      "id": "Reply(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(string)",
      "nameWithType": "RustPlayer.Reply(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 267,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Reply(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.Reply(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(String)",
      "name.vb": "Reply(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(System.String,System.Object[])",
      "id": "Command(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command(string, params object[])",
      "nameWithType": "RustPlayer.Command(string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 274,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.Command(System.String,System.Object[])"
      ],
      "nameWithType.vb": "RustPlayer.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(System.String)",
      "id": "HasPermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "HasPermission(string)",
      "nameWithType": "RustPlayer.HasPermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "HasPermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 285,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.HasPermission(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.HasPermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(String)",
      "name.vb": "HasPermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(System.String)",
      "id": "GrantPermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GrantPermission(string)",
      "nameWithType": "RustPlayer.GrantPermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GrantPermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 291,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.GrantPermission(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.GrantPermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(String)",
      "name.vb": "GrantPermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(System.String)",
      "id": "RevokePermission(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RevokePermission(string)",
      "nameWithType": "RustPlayer.RevokePermission(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RevokePermission",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 297,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.RevokePermission(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.RevokePermission(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(String)",
      "name.vb": "RevokePermission(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(System.String)",
      "id": "BelongsToGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BelongsToGroup(string)",
      "nameWithType": "RustPlayer.BelongsToGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BelongsToGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 304,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.BelongsToGroup(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.BelongsToGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(String)",
      "name.vb": "BelongsToGroup(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(System.String)",
      "id": "AddToGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddToGroup(string)",
      "nameWithType": "RustPlayer.AddToGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddToGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 310,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.AddToGroup(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.AddToGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(String)",
      "name.vb": "AddToGroup(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(System.String)",
      "id": "RemoveFromGroup(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RemoveFromGroup(string)",
      "nameWithType": "RustPlayer.RemoveFromGroup(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RemoveFromGroup",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 316,
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
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.IPlayer.RemoveFromGroup(System.String)"
      ],
      "nameWithType.vb": "RustPlayer.RemoveFromGroup(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(String)",
      "name.vb": "RemoveFromGroup(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "id": "Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Equals(IPlayer)",
      "nameWithType": "RustPlayer.Equals(IPlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Equals",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 327,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if player's unique ID is equal to another player's unique ID",
      "example": [],
      "syntax": {
        "content": "public bool Equals(IPlayer other)",
        "parameters": [
          {
            "id": "other",
            "type": "Oxide.Core.Libraries.Covalence.IPlayer",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Function Equals(other As IPlayer) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals*",
      "implements": [
        "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}.Equals(Oxide.Core.Libraries.Covalence.IPlayer)"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(System.Object)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(System.Object)",
      "id": "Equals(System.Object)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Equals(object)",
      "nameWithType": "RustPlayer.Equals(object)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(object)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Equals",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 334,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns if player's object is equal to another player's object",
      "example": [],
      "syntax": {
        "content": "public override bool Equals(object obj)",
        "parameters": [
          {
            "id": "obj",
            "type": "System.Object",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Overrides Function Equals(obj As Object) As Boolean"
      },
      "overridden": "System.Object.Equals(System.Object)",
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals*",
      "nameWithType.vb": "RustPlayer.Equals(Object)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Object)",
      "name.vb": "Equals(Object)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode",
      "id": "GetHashCode",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GetHashCode()",
      "nameWithType": "RustPlayer.GetHashCode()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GetHashCode",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 340,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Gets the hash code of the player's unique ID",
      "example": [],
      "syntax": {
        "content": "public override int GetHashCode()",
        "return": {
          "type": "System.Int32",
          "description": ""
        },
        "content.vb": "Public Overrides Function GetHashCode() As Integer"
      },
      "overridden": "System.Object.GetHashCode",
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString",
      "id": "ToString",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ToString()",
      "nameWithType": "RustPlayer.ToString()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustPlayer.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ToString",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustPlayer.cs",
        "startLine": 346,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Returns a human readable string representation of this IPlayer",
      "example": [],
      "syntax": {
        "content": "public override string ToString()",
        "return": {
          "type": "System.String",
          "description": ""
        },
        "content.vb": "Public Overrides Function ToString() As String"
      },
      "overridden": "System.Object.ToString",
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString*"
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
      "uid": "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}",
      "commentId": "T:System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}",
      "parent": "System",
      "definition": "System.IEquatable`1",
      "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1",
      "name": "IEquatable<IPlayer>",
      "nameWithType": "IEquatable<IPlayer>",
      "fullName": "System.IEquatable<Oxide.Core.Libraries.Covalence.IPlayer>",
      "nameWithType.vb": "IEquatable(Of IPlayer)",
      "fullName.vb": "System.IEquatable(Of Oxide.Core.Libraries.Covalence.IPlayer)",
      "name.vb": "IEquatable(Of IPlayer)",
      "spec.csharp": [
        {
          "uid": "System.IEquatable`1",
          "name": "IEquatable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1"
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
          "uid": "System.IEquatable`1",
          "name": "IEquatable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1"
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
      "uid": "System.IEquatable`1",
      "commentId": "T:System.IEquatable`1",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1",
      "name": "IEquatable<T>",
      "nameWithType": "IEquatable<T>",
      "fullName": "System.IEquatable<T>",
      "nameWithType.vb": "IEquatable(Of T)",
      "fullName.vb": "System.IEquatable(Of T)",
      "name.vb": "IEquatable(Of T)",
      "spec.csharp": [
        {
          "uid": "System.IEquatable`1",
          "name": "IEquatable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1"
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
          "uid": "System.IEquatable`1",
          "name": "IEquatable",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object",
      "name": "Object",
      "nameWithType": "RustPlayer.Object",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Object"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand",
      "name": "LastCommand",
      "nameWithType": "RustPlayer.LastCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.LastCommand"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name",
      "name": "Name",
      "nameWithType": "RustPlayer.Name",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Name"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id",
      "name": "Id",
      "nameWithType": "RustPlayer.Id",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Id"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language",
      "name": "Language",
      "nameWithType": "RustPlayer.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Language"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address",
      "name": "Address",
      "nameWithType": "RustPlayer.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Address"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping",
      "name": "Ping",
      "nameWithType": "RustPlayer.Ping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ping"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin",
      "name": "IsAdmin",
      "nameWithType": "RustPlayer.IsAdmin",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsAdmin"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned",
      "name": "IsBanned",
      "nameWithType": "RustPlayer.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsBanned"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected",
      "name": "IsConnected",
      "nameWithType": "RustPlayer.IsConnected",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsConnected"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping",
      "name": "IsSleeping",
      "nameWithType": "RustPlayer.IsSleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsSleeping"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer",
      "name": "IsServer",
      "nameWithType": "RustPlayer.IsServer",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.IsServer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban(System.String,System.TimeSpan)",
      "name": "Ban",
      "nameWithType": "RustPlayer.Ban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Ban"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining",
      "name": "BanTimeRemaining",
      "nameWithType": "RustPlayer.BanTimeRemaining",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BanTimeRemaining"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal(System.Single)",
      "name": "Heal",
      "nameWithType": "RustPlayer.Heal",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Heal"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health",
      "name": "Health",
      "nameWithType": "RustPlayer.Health",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Health"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt(System.Single)",
      "name": "Hurt",
      "nameWithType": "RustPlayer.Hurt",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Hurt"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick(System.String)",
      "name": "Kick",
      "nameWithType": "RustPlayer.Kick",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kick"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill",
      "name": "Kill",
      "nameWithType": "RustPlayer.Kill",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Kill"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth",
      "name": "MaxHealth",
      "nameWithType": "RustPlayer.MaxHealth",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.MaxHealth"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename(System.String)",
      "name": "Rename",
      "nameWithType": "RustPlayer.Rename",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Rename"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport(System.Single,System.Single,System.Single)",
      "name": "Teleport",
      "nameWithType": "RustPlayer.Teleport",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Teleport"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban",
      "name": "Unban",
      "nameWithType": "RustPlayer.Unban",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Unban"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position(System.Single@,System.Single@,System.Single@)",
      "name": "Position",
      "nameWithType": "RustPlayer.Position",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Position"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message(System.String,System.String,System.Object[])",
      "name": "Message",
      "nameWithType": "RustPlayer.Message",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Message"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply(System.String,System.String,System.Object[])",
      "name": "Reply",
      "nameWithType": "RustPlayer.Reply",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Reply"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command(System.String,System.Object[])",
      "name": "Command",
      "nameWithType": "RustPlayer.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Command"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission(System.String)",
      "name": "HasPermission",
      "nameWithType": "RustPlayer.HasPermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.HasPermission"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission(System.String)",
      "name": "GrantPermission",
      "nameWithType": "RustPlayer.GrantPermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GrantPermission"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission(System.String)",
      "name": "RevokePermission",
      "nameWithType": "RustPlayer.RevokePermission",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RevokePermission"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup(System.String)",
      "name": "BelongsToGroup",
      "nameWithType": "RustPlayer.BelongsToGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.BelongsToGroup"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup(System.String)",
      "name": "AddToGroup",
      "nameWithType": "RustPlayer.AddToGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.AddToGroup"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup(System.String)",
      "name": "RemoveFromGroup",
      "nameWithType": "RustPlayer.RemoveFromGroup",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.RemoveFromGroup"
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
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "name": "Equals",
      "nameWithType": "RustPlayer.Equals",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.Equals"
    },
    {
      "uid": "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "commentId": "M:System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "parent": "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}",
      "definition": "System.IEquatable`1.Equals(`0)",
      "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-oxide.core.libraries.covalence.iplayer-.equals#system-iequatable((oxide-core-libraries-covalence-iplayer))-equals(oxide-core-libraries-covalence-iplayer)",
      "name": "Equals(IPlayer)",
      "nameWithType": "IEquatable<IPlayer>.Equals(IPlayer)",
      "fullName": "System.IEquatable<Oxide.Core.Libraries.Covalence.IPlayer>.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "nameWithType.vb": "IEquatable(Of IPlayer).Equals(IPlayer)",
      "fullName.vb": "System.IEquatable(Of Oxide.Core.Libraries.Covalence.IPlayer).Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
      "spec.csharp": [
        {
          "uid": "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-oxide.core.libraries.covalence.iplayer-.equals#system-iequatable((oxide-core-libraries-covalence-iplayer))-equals(oxide-core-libraries-covalence-iplayer)"
        },
        {
          "name": "(",
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
      ],
      "spec.vb": [
        {
          "uid": "System.IEquatable{Oxide.Core.Libraries.Covalence.IPlayer}.Equals(Oxide.Core.Libraries.Covalence.IPlayer)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-oxide.core.libraries.covalence.iplayer-.equals#system-iequatable((oxide-core-libraries-covalence-iplayer))-equals(oxide-core-libraries-covalence-iplayer)"
        },
        {
          "name": "(",
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
      "uid": "System.IEquatable`1.Equals(`0)",
      "commentId": "M:System.IEquatable`1.Equals(`0)",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1.equals",
      "name": "Equals(T)",
      "nameWithType": "IEquatable<T>.Equals(T)",
      "fullName": "System.IEquatable<T>.Equals(T)",
      "nameWithType.vb": "IEquatable(Of T).Equals(T)",
      "fullName.vb": "System.IEquatable(Of T).Equals(T)",
      "spec.csharp": [
        {
          "uid": "System.IEquatable`1.Equals(`0)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1.equals"
        },
        {
          "name": "(",
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
      ],
      "spec.vb": [
        {
          "uid": "System.IEquatable`1.Equals(`0)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.iequatable-1.equals"
        },
        {
          "name": "(",
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode",
      "name": "GetHashCode",
      "nameWithType": "RustPlayer.GetHashCode",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.GetHashCode"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.html#Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString",
      "name": "ToString",
      "nameWithType": "RustPlayer.ToString",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustPlayer.ToString"
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