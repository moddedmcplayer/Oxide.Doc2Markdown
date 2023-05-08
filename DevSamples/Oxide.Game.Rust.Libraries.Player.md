# Class Player
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Player : Library
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, IsGlobal, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public ListHashSet<BasePlayer> Players { get; }
```
Players
```csharp
public ListHashSet<BasePlayer> Sleepers { get; }
```
Sleepers
## Methods 
```csharp
public CultureInfo Language(BasePlayer player)
```
Language(BasePlayer)
```csharp
public string Address(Connection connection)
```
Address(Connection)
```csharp
public string Address(BasePlayer player)
```
Address(BasePlayer)
```csharp
public int Ping(Connection connection)
```
Ping(Connection)
```csharp
public int Ping(BasePlayer player)
```
Ping(BasePlayer)
```csharp
public bool IsAdmin(ulong id)
```
IsAdmin(ulong)
```csharp
public bool IsAdmin(string id)
```
IsAdmin(string)
```csharp
public bool IsAdmin(BasePlayer player)
```
IsAdmin(BasePlayer)
```csharp
public bool IsBanned(ulong id)
```
IsBanned(ulong)
```csharp
public bool IsBanned(string id)
```
IsBanned(string)
```csharp
public bool IsBanned(BasePlayer player)
```
IsBanned(BasePlayer)
```csharp
public bool IsConnected(BasePlayer player)
```
IsConnected(BasePlayer)
```csharp
public bool IsSleeping(ulong id)
```
IsSleeping(ulong)
```csharp
public bool IsSleeping(string id)
```
IsSleeping(string)
```csharp
public bool IsSleeping(BasePlayer player)
```
IsSleeping(BasePlayer)
```csharp
public void Ban(ulong id, string reason = "")
```
Ban(ulong, string)
```csharp
public void Ban(string id, string reason = "")
```
Ban(string, string)
```csharp
public void Ban(BasePlayer player, string reason = "")
```
Ban(BasePlayer, string)
```csharp
public void Heal(BasePlayer player, float amount)
```
Heal(BasePlayer, float)
```csharp
public void Hurt(BasePlayer player, float amount)
```
Hurt(BasePlayer, float)
```csharp
public void Kick(BasePlayer player, string reason = "")
```
Kick(BasePlayer, string)
```csharp
public void Kill(BasePlayer player)
```
Kill(BasePlayer)
```csharp
public void Rename(BasePlayer player, string name)
```
Rename(BasePlayer, string)
```csharp
public void Teleport(BasePlayer player, Vector3 destination)
```
Teleport(BasePlayer, Vector3)
```csharp
public void Teleport(BasePlayer player, BasePlayer target)
```
Teleport(BasePlayer, BasePlayer)
```csharp
public void Teleport(BasePlayer player, float x, float y, float z)
```
Teleport(BasePlayer, float, float, float)
```csharp
public void Unban(ulong id)
```
Unban(ulong)
```csharp
public void Unban(string id)
```
Unban(string)
```csharp
public void Unban(BasePlayer player)
```
Unban(BasePlayer)
```csharp
public Vector3 Position(BasePlayer player)
```
Position(BasePlayer)
```csharp
public BasePlayer Find(string nameOrIdOrIp)
```
Find(string)
```csharp
public BasePlayer FindById(string id)
```
FindById(string)
```csharp
public BasePlayer FindById(ulong id)
```
FindById(ulong)
```csharp
public void Message(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)
```
Message(BasePlayer, string, string, ulong, params object[])
```csharp
public void Message(BasePlayer player, string message, ulong userId = 0)
```
Message(BasePlayer, string, ulong)
```csharp
public void Reply(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)
```
Reply(BasePlayer, string, string, ulong, params object[])
```csharp
public void Reply(BasePlayer player, string message, ulong userId = 0)
```
Reply(BasePlayer, string, ulong)
```csharp
public void Command(BasePlayer player, string command, params object[] args)
```
Command(BasePlayer, string, params object[])
```csharp
public void DropItem(BasePlayer player, int itemId)
```
DropItem(BasePlayer, int)
```csharp
public void DropItem(BasePlayer player, Item item)
```
DropItem(BasePlayer, Item)
```csharp
public void GiveItem(BasePlayer player, int itemId, int quantity = 1)
```
GiveItem(BasePlayer, int, int)
```csharp
public void GiveItem(BasePlayer player, Item item, int quantity = 1)
```
GiveItem(BasePlayer, Item, int)
```csharp
public PlayerInventory Inventory(BasePlayer player)
```
Inventory(BasePlayer)
```csharp
public void ClearInventory(BasePlayer player)
```
ClearInventory(BasePlayer)
```csharp
public void ResetInventory(BasePlayer player)
```
ResetInventory(BasePlayer)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Player",
      "commentId": "T:Oxide.Game.Rust.Libraries.Player",
      "id": "Player",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries",
      "children": [
        "Oxide.Game.Rust.Libraries.Player.Address(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Address(Network.Connection)",
        "Oxide.Game.Rust.Libraries.Player.Ban(BasePlayer,System.String)",
        "Oxide.Game.Rust.Libraries.Player.Ban(System.String,System.String)",
        "Oxide.Game.Rust.Libraries.Player.Ban(System.UInt64,System.String)",
        "Oxide.Game.Rust.Libraries.Player.ClearInventory(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Command(BasePlayer,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,Item)",
        "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,System.Int32)",
        "Oxide.Game.Rust.Libraries.Player.Find(System.String)",
        "Oxide.Game.Rust.Libraries.Player.FindById(System.String)",
        "Oxide.Game.Rust.Libraries.Player.FindById(System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,Item,System.Int32)",
        "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,System.Int32,System.Int32)",
        "Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer,System.Single)",
        "Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer,System.Single)",
        "Oxide.Game.Rust.Libraries.Player.Inventory(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.IsAdmin(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.IsAdmin(System.String)",
        "Oxide.Game.Rust.Libraries.Player.IsAdmin(System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.IsBanned(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.IsBanned(System.String)",
        "Oxide.Game.Rust.Libraries.Player.IsBanned(System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.IsConnected(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.IsSleeping(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.IsSleeping(System.String)",
        "Oxide.Game.Rust.Libraries.Player.IsSleeping(System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer,System.String)",
        "Oxide.Game.Rust.Libraries.Player.Kill(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Language(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
        "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.Ping(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Ping(Network.Connection)",
        "Oxide.Game.Rust.Libraries.Player.Players",
        "Oxide.Game.Rust.Libraries.Player.Position(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer,System.String)",
        "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
        "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.UInt64)",
        "Oxide.Game.Rust.Libraries.Player.ResetInventory(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Sleepers",
        "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,System.Single,System.Single,System.Single)",
        "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,UnityEngine.Vector3)",
        "Oxide.Game.Rust.Libraries.Player.Unban(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Player.Unban(System.String)",
        "Oxide.Game.Rust.Libraries.Player.Unban(System.UInt64)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Player",
      "nameWithType": "Player",
      "fullName": "Oxide.Game.Rust.Libraries.Player",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Player",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "syntax": {
        "content": "public class Player : Library",
        "content.vb": "Public Class Player Inherits Library"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Libraries.Library"
      ],
      "inheritedMembers": [
        "Oxide.Core.Libraries.Library.Shutdown",
        "Oxide.Core.Libraries.Library.GetFunctionNames",
        "Oxide.Core.Libraries.Library.GetPropertyNames",
        "Oxide.Core.Libraries.Library.GetFunction(System.String)",
        "Oxide.Core.Libraries.Library.GetProperty(System.String)",
        "Oxide.Core.Libraries.Library.IsGlobal",
        "Oxide.Core.Libraries.Library.LastException",
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Language(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Language(BasePlayer)",
      "id": "Language(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Language(BasePlayer)",
      "nameWithType": "Player.Language(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Language(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Language",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 29,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player's language",
      "example": [],
      "syntax": {
        "content": "public CultureInfo Language(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Globalization.CultureInfo"
        },
        "content.vb": "Public Function Language(player As BasePlayer) As CultureInfo"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Language*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Address(Network.Connection)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Address(Network.Connection)",
      "id": "Address(Network.Connection)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Address(Connection)",
      "nameWithType": "Player.Address(Connection)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Address(Network.Connection)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Address",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 46,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player's IP address",
      "example": [],
      "syntax": {
        "content": "public string Address(Connection connection)",
        "parameters": [
          {
            "id": "connection",
            "type": "Network.Connection"
          }
        ],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Function Address(connection As Connection) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Address*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Address(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Address(BasePlayer)",
      "id": "Address(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Address(BasePlayer)",
      "nameWithType": "Player.Address(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Address(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Address",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 51,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player's IP address",
      "example": [],
      "syntax": {
        "content": "public string Address(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Function Address(player As BasePlayer) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Address*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ping(Network.Connection)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Ping(Network.Connection)",
      "id": "Ping(Network.Connection)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ping(Connection)",
      "nameWithType": "Player.Ping(Connection)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ping(Network.Connection)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 56,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player's average network ping",
      "example": [],
      "syntax": {
        "content": "public int Ping(Connection connection)",
        "parameters": [
          {
            "id": "connection",
            "type": "Network.Connection"
          }
        ],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "Public Function Ping(connection As Connection) As Integer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Ping*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ping(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Ping(BasePlayer)",
      "id": "Ping(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ping(BasePlayer)",
      "nameWithType": "Player.Ping(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ping(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 61,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player's average network ping",
      "example": [],
      "syntax": {
        "content": "public int Ping(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Int32"
        },
        "content.vb": "Public Function Ping(player As BasePlayer) As Integer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Ping*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsAdmin(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsAdmin(System.UInt64)",
      "id": "IsAdmin(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsAdmin(ulong)",
      "nameWithType": "Player.IsAdmin(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsAdmin(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsAdmin",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 66,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is admin",
      "example": [],
      "syntax": {
        "content": "public bool IsAdmin(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsAdmin(id As ULong) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsAdmin*",
      "nameWithType.vb": "Player.IsAdmin(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsAdmin(ULong)",
      "name.vb": "IsAdmin(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsAdmin(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsAdmin(System.String)",
      "id": "IsAdmin(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsAdmin(string)",
      "nameWithType": "Player.IsAdmin(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsAdmin(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsAdmin",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 71,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is admin",
      "example": [],
      "syntax": {
        "content": "public bool IsAdmin(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsAdmin(id As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsAdmin*",
      "nameWithType.vb": "Player.IsAdmin(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsAdmin(String)",
      "name.vb": "IsAdmin(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsAdmin(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsAdmin(BasePlayer)",
      "id": "IsAdmin(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsAdmin(BasePlayer)",
      "nameWithType": "Player.IsAdmin(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsAdmin(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsAdmin",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 76,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is admin",
      "example": [],
      "syntax": {
        "content": "public bool IsAdmin(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsAdmin(player As BasePlayer) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsAdmin*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsBanned(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsBanned(System.UInt64)",
      "id": "IsBanned(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned(ulong)",
      "nameWithType": "Player.IsBanned(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsBanned(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 81,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets if the player is banned",
      "example": [],
      "syntax": {
        "content": "public bool IsBanned(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsBanned(id As ULong) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsBanned*",
      "nameWithType.vb": "Player.IsBanned(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsBanned(ULong)",
      "name.vb": "IsBanned(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsBanned(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsBanned(System.String)",
      "id": "IsBanned(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned(string)",
      "nameWithType": "Player.IsBanned(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsBanned(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 86,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets if the player is banned",
      "example": [],
      "syntax": {
        "content": "public bool IsBanned(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsBanned(id As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsBanned*",
      "nameWithType.vb": "Player.IsBanned(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsBanned(String)",
      "name.vb": "IsBanned(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsBanned(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsBanned(BasePlayer)",
      "id": "IsBanned(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsBanned(BasePlayer)",
      "nameWithType": "Player.IsBanned(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsBanned(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsBanned",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 91,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets if the player is banned",
      "example": [],
      "syntax": {
        "content": "public bool IsBanned(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsBanned(player As BasePlayer) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsBanned*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsConnected(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsConnected(BasePlayer)",
      "id": "IsConnected(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsConnected(BasePlayer)",
      "nameWithType": "Player.IsConnected(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsConnected(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsConnected",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 96,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets if the player is connected",
      "example": [],
      "syntax": {
        "content": "public bool IsConnected(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsConnected(player As BasePlayer) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsConnected*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsSleeping(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsSleeping(System.UInt64)",
      "id": "IsSleeping(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsSleeping(ulong)",
      "nameWithType": "Player.IsSleeping(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsSleeping(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsSleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 101,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is sleeping",
      "example": [],
      "syntax": {
        "content": "public bool IsSleeping(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsSleeping(id As ULong) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsSleeping*",
      "nameWithType.vb": "Player.IsSleeping(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsSleeping(ULong)",
      "name.vb": "IsSleeping(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsSleeping(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsSleeping(System.String)",
      "id": "IsSleeping(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsSleeping(string)",
      "nameWithType": "Player.IsSleeping(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsSleeping(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsSleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 106,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is sleeping",
      "example": [],
      "syntax": {
        "content": "public bool IsSleeping(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsSleeping(id As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsSleeping*",
      "nameWithType.vb": "Player.IsSleeping(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.IsSleeping(String)",
      "name.vb": "IsSleeping(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsSleeping(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.IsSleeping(BasePlayer)",
      "id": "IsSleeping(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsSleeping(BasePlayer)",
      "nameWithType": "Player.IsSleeping(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsSleeping(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsSleeping",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 111,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if the player is sleeping",
      "example": [],
      "syntax": {
        "content": "public bool IsSleeping(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Function IsSleeping(player As BasePlayer) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.IsSleeping*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ban(System.UInt64,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Ban(System.UInt64,System.String)",
      "id": "Ban(System.UInt64,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(ulong, string)",
      "nameWithType": "Player.Ban(ulong, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ban(ulong, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 122,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Bans the player from the server based on user ID",
      "example": [],
      "syntax": {
        "content": "public void Ban(ulong id, string reason = \"\")",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64",
            "description": ""
          },
          {
            "id": "reason",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Ban(id As ULong, reason As String = \"\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Ban*",
      "nameWithType.vb": "Player.Ban(ULong, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Ban(ULong, String)",
      "name.vb": "Ban(ULong, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ban(System.String,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Ban(System.String,System.String)",
      "id": "Ban(System.String,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(string, string)",
      "nameWithType": "Player.Ban(string, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ban(string, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 143,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Bans the player from the server based on user ID",
      "example": [],
      "syntax": {
        "content": "public void Ban(string id, string reason = \"\")",
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
          }
        ],
        "content.vb": "Public Sub Ban(id As String, reason As String = \"\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Ban*",
      "nameWithType.vb": "Player.Ban(String, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Ban(String, String)",
      "name.vb": "Ban(String, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ban(BasePlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Ban(BasePlayer,System.String)",
      "id": "Ban(BasePlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Ban(BasePlayer, string)",
      "nameWithType": "Player.Ban(BasePlayer, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ban(BasePlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Ban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 150,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Bans the player from the server",
      "example": [],
      "syntax": {
        "content": "public void Ban(BasePlayer player, string reason = \"\")",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "reason",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Ban(player As BasePlayer, reason As String = \"\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Ban*",
      "nameWithType.vb": "Player.Ban(BasePlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Ban(BasePlayer, String)",
      "name.vb": "Ban(BasePlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer,System.Single)",
      "id": "Heal(BasePlayer,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Heal(BasePlayer, float)",
      "nameWithType": "Player.Heal(BasePlayer, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Heal",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 157,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Heals the player by specified amount",
      "example": [],
      "syntax": {
        "content": "public void Heal(BasePlayer player, float amount)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "amount",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Heal(player As BasePlayer, amount As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Heal*",
      "nameWithType.vb": "Player.Heal(BasePlayer, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer, Single)",
      "name.vb": "Heal(BasePlayer, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer,System.Single)",
      "id": "Hurt(BasePlayer,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Hurt(BasePlayer, float)",
      "nameWithType": "Player.Hurt(BasePlayer, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Hurt",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 164,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Damages the player by specified amount",
      "example": [],
      "syntax": {
        "content": "public void Hurt(BasePlayer player, float amount)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "amount",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Hurt(player As BasePlayer, amount As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Hurt*",
      "nameWithType.vb": "Player.Hurt(BasePlayer, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer, Single)",
      "name.vb": "Hurt(BasePlayer, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer,System.String)",
      "id": "Kick(BasePlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kick(BasePlayer, string)",
      "nameWithType": "Player.Kick(BasePlayer, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kick",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 171,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Kicks the player from the server",
      "example": [],
      "syntax": {
        "content": "public void Kick(BasePlayer player, string reason = \"\")",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "reason",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Kick(player As BasePlayer, reason As String = \"\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Kick*",
      "nameWithType.vb": "Player.Kick(BasePlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer, String)",
      "name.vb": "Kick(BasePlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Kill(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Kill(BasePlayer)",
      "id": "Kill(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Kill(BasePlayer)",
      "nameWithType": "Player.Kill(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Kill(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Kill",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 177,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Causes the player to die",
      "example": [],
      "syntax": {
        "content": "public void Kill(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Kill(player As BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Kill*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer,System.String)",
      "id": "Rename(BasePlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Rename(BasePlayer, string)",
      "nameWithType": "Player.Rename(BasePlayer, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Rename",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 184,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Renames the player to specified name\n<param name=\"session\" />\n<param name=\"name\" />",
      "example": [],
      "syntax": {
        "content": "public void Rename(BasePlayer player, string name)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          },
          {
            "id": "name",
            "type": "System.String"
          }
        ],
        "content.vb": "Public Sub Rename(player As BasePlayer, name As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Rename*",
      "nameWithType.vb": "Player.Rename(BasePlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer, String)",
      "name.vb": "Rename(BasePlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,UnityEngine.Vector3)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,UnityEngine.Vector3)",
      "id": "Teleport(BasePlayer,UnityEngine.Vector3)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(BasePlayer, Vector3)",
      "nameWithType": "Player.Teleport(BasePlayer, Vector3)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer, UnityEngine.Vector3)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 227,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Teleports the player to the specified position",
      "example": [],
      "syntax": {
        "content": "public void Teleport(BasePlayer player, Vector3 destination)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "destination",
            "type": "UnityEngine.Vector3",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Teleport(player As BasePlayer, destination As Vector3)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Teleport*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,BasePlayer)",
      "id": "Teleport(BasePlayer,BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(BasePlayer, BasePlayer)",
      "nameWithType": "Player.Teleport(BasePlayer, BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer, BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 271,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Teleports the player to the target player",
      "example": [],
      "syntax": {
        "content": "public void Teleport(BasePlayer player, BasePlayer target)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "target",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Teleport(player As BasePlayer, target As BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Teleport*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,System.Single,System.Single,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,System.Single,System.Single,System.Single)",
      "id": "Teleport(BasePlayer,System.Single,System.Single,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Teleport(BasePlayer, float, float, float)",
      "nameWithType": "Player.Teleport(BasePlayer, float, float, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer, float, float, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Teleport",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 280,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Teleports the player to the specified position",
      "example": [],
      "syntax": {
        "content": "public void Teleport(BasePlayer player, float x, float y, float z)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
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
        "content.vb": "Public Sub Teleport(player As BasePlayer, x As Single, y As Single, z As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Teleport*",
      "nameWithType.vb": "Player.Teleport(BasePlayer, Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer, Single, Single, Single)",
      "name.vb": "Teleport(BasePlayer, Single, Single, Single)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Unban(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Unban(System.UInt64)",
      "id": "Unban(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban(ulong)",
      "nameWithType": "Player.Unban(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Unban(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 285,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Unbans the player by user ID",
      "example": [],
      "syntax": {
        "content": "public void Unban(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64"
          }
        ],
        "content.vb": "Public Sub Unban(id As ULong)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Unban*",
      "nameWithType.vb": "Player.Unban(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Unban(ULong)",
      "name.vb": "Unban(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Unban(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Unban(System.String)",
      "id": "Unban(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban(string)",
      "nameWithType": "Player.Unban(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Unban(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 299,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Unbans the player by user ID",
      "example": [],
      "syntax": {
        "content": "public void Unban(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String"
          }
        ],
        "content.vb": "Public Sub Unban(id As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Unban*",
      "nameWithType.vb": "Player.Unban(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Unban(String)",
      "name.vb": "Unban(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Unban(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Unban(BasePlayer)",
      "id": "Unban(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Unban(BasePlayer)",
      "nameWithType": "Player.Unban(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Unban(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Unban",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 304,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Unbans the player",
      "example": [],
      "syntax": {
        "content": "public void Unban(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer"
          }
        ],
        "content.vb": "Public Sub Unban(player As BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Unban*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Position(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Position(BasePlayer)",
      "id": "Position(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Position(BasePlayer)",
      "nameWithType": "Player.Position(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Position(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Position",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 315,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the position of player as Vector3",
      "example": [],
      "syntax": {
        "content": "public Vector3 Position(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "return": {
          "type": "UnityEngine.Vector3",
          "description": ""
        },
        "content.vb": "Public Function Position(player As BasePlayer) As Vector3"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Position*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Find(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Find(System.String)",
      "id": "Find(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Find(string)",
      "nameWithType": "Player.Find(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Find(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Find",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 326,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player object using a name, Steam ID, or IP address",
      "example": [],
      "syntax": {
        "content": "public BasePlayer Find(string nameOrIdOrIp)",
        "parameters": [
          {
            "id": "nameOrIdOrIp",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Function Find(nameOrIdOrIp As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Find*",
      "nameWithType.vb": "Player.Find(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Find(String)",
      "name.vb": "Find(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.FindById(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.FindById(System.String)",
      "id": "FindById(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindById(string)",
      "nameWithType": "Player.FindById(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.FindById(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindById",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 346,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player object using a Steam ID",
      "example": [],
      "syntax": {
        "content": "public BasePlayer FindById(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Function FindById(id As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.FindById*",
      "nameWithType.vb": "Player.FindById(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.FindById(String)",
      "name.vb": "FindById(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.FindById(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.FindById(System.UInt64)",
      "id": "FindById(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindById(ulong)",
      "nameWithType": "Player.FindById(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.FindById(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindById",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 365,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the player object using a Steam ID",
      "example": [],
      "syntax": {
        "content": "public BasePlayer FindById(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Function FindById(id As ULong) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.FindById*",
      "nameWithType.vb": "Player.FindById(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.FindById(ULong)",
      "name.vb": "FindById(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Players",
      "commentId": "P:Oxide.Game.Rust.Libraries.Player.Players",
      "id": "Players",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Players",
      "nameWithType": "Player.Players",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Players",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Players",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 382,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns all connected players",
      "example": [],
      "syntax": {
        "content": "public ListHashSet<BasePlayer> Players { get; }",
        "parameters": [],
        "return": {
          "type": "ListHashSet{BasePlayer}"
        },
        "content.vb": "Public ReadOnly Property Players As ListHashSet(Of BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Players*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Sleepers",
      "commentId": "P:Oxide.Game.Rust.Libraries.Player.Sleepers",
      "id": "Sleepers",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Sleepers",
      "nameWithType": "Player.Sleepers",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Sleepers",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Sleepers",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 387,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns all sleeping players",
      "example": [],
      "syntax": {
        "content": "public ListHashSet<BasePlayer> Sleepers { get; }",
        "parameters": [],
        "return": {
          "type": "ListHashSet{BasePlayer}"
        },
        "content.vb": "Public ReadOnly Property Sleepers As ListHashSet(Of BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Sleepers*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "id": "Message(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(BasePlayer, string, string, ulong, params object[])",
      "nameWithType": "Player.Message(BasePlayer, string, string, ulong, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer, string, string, ulong, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 400,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Sends the specified message and prefix to the player",
      "example": [],
      "syntax": {
        "content": "public void Message(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
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
            "id": "userId",
            "type": "System.UInt64"
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Message(player As BasePlayer, message As String, prefix As String, userId As ULong = 0, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Message*",
      "nameWithType.vb": "Player.Message(BasePlayer, String, String, ULong, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer, String, String, ULong, ParamArray Object())",
      "name.vb": "Message(BasePlayer, String, String, ULong, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.UInt64)",
      "id": "Message(BasePlayer,System.String,System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Message(BasePlayer, string, ulong)",
      "nameWithType": "Player.Message(BasePlayer, string, ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer, string, ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Message",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 422,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Sends the specified message to the player",
      "example": [],
      "syntax": {
        "content": "public void Message(BasePlayer player, string message, ulong userId = 0)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.UInt64",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Message(player As BasePlayer, message As String, userId As ULong = 0)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Message*",
      "nameWithType.vb": "Player.Message(BasePlayer, String, ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Message(BasePlayer, String, ULong)",
      "name.vb": "Message(BasePlayer, String, ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "id": "Reply(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(BasePlayer, string, string, ulong, params object[])",
      "nameWithType": "Player.Reply(BasePlayer, string, string, ulong, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer, string, string, ulong, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 431,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Replies to the player with the specified message and prefix",
      "example": [],
      "syntax": {
        "content": "public void Reply(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
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
            "id": "userId",
            "type": "System.UInt64"
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Reply(player As BasePlayer, message As String, prefix As String, userId As ULong = 0, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Reply*",
      "nameWithType.vb": "Player.Reply(BasePlayer, String, String, ULong, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer, String, String, ULong, ParamArray Object())",
      "name.vb": "Reply(BasePlayer, String, String, ULong, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.UInt64)",
      "id": "Reply(BasePlayer,System.String,System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Reply(BasePlayer, string, ulong)",
      "nameWithType": "Player.Reply(BasePlayer, string, ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer, string, ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Reply",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 442,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Replies to the player with the specified message",
      "example": [],
      "syntax": {
        "content": "public void Reply(BasePlayer player, string message, ulong userId = 0)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.UInt64",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Reply(player As BasePlayer, message As String, userId As ULong = 0)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Reply*",
      "nameWithType.vb": "Player.Reply(BasePlayer, String, ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer, String, ULong)",
      "name.vb": "Reply(BasePlayer, String, ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Command(BasePlayer,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Command(BasePlayer,System.String,System.Object[])",
      "id": "Command(BasePlayer,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command(BasePlayer, string, params object[])",
      "nameWithType": "Player.Command(BasePlayer, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Command(BasePlayer, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 450,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Runs the specified player command",
      "example": [],
      "syntax": {
        "content": "public void Command(BasePlayer player, string command, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
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
        "content.vb": "Public Sub Command(player As BasePlayer, command As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Command*",
      "nameWithType.vb": "Player.Command(BasePlayer, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.Command(BasePlayer, String, ParamArray Object())",
      "name.vb": "Command(BasePlayer, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,System.Int32)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,System.Int32)",
      "id": "DropItem(BasePlayer,System.Int32)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "DropItem(BasePlayer, int)",
      "nameWithType": "Player.DropItem(BasePlayer, int)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer, int)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "DropItem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 461,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Drops item by item ID from player's inventory",
      "example": [],
      "syntax": {
        "content": "public void DropItem(BasePlayer player, int itemId)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "itemId",
            "type": "System.Int32",
            "description": ""
          }
        ],
        "content.vb": "Public Sub DropItem(player As BasePlayer, itemId As Integer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.DropItem*",
      "nameWithType.vb": "Player.DropItem(BasePlayer, Integer)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer, Integer)",
      "name.vb": "DropItem(BasePlayer, Integer)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,Item)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,Item)",
      "id": "DropItem(BasePlayer,Item)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "DropItem(BasePlayer, Item)",
      "nameWithType": "Player.DropItem(BasePlayer, Item)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer, Item)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "DropItem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 496,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Drops item from the player's inventory",
      "example": [],
      "syntax": {
        "content": "public void DropItem(BasePlayer player, Item item)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "item",
            "type": "Item",
            "description": ""
          }
        ],
        "content.vb": "Public Sub DropItem(player As BasePlayer, item As Item)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.DropItem*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,System.Int32,System.Int32)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,System.Int32,System.Int32)",
      "id": "GiveItem(BasePlayer,System.Int32,System.Int32)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GiveItem(BasePlayer, int, int)",
      "nameWithType": "Player.GiveItem(BasePlayer, int, int)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer, int, int)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GiveItem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 532,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gives quantity of an item to the player",
      "example": [],
      "syntax": {
        "content": "public void GiveItem(BasePlayer player, int itemId, int quantity = 1)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "itemId",
            "type": "System.Int32",
            "description": ""
          },
          {
            "id": "quantity",
            "type": "System.Int32",
            "description": ""
          }
        ],
        "content.vb": "Public Sub GiveItem(player As BasePlayer, itemId As Integer, quantity As Integer = 1)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.GiveItem*",
      "nameWithType.vb": "Player.GiveItem(BasePlayer, Integer, Integer)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer, Integer, Integer)",
      "name.vb": "GiveItem(BasePlayer, Integer, Integer)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,Item,System.Int32)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,Item,System.Int32)",
      "id": "GiveItem(BasePlayer,Item,System.Int32)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GiveItem(BasePlayer, Item, int)",
      "nameWithType": "Player.GiveItem(BasePlayer, Item, int)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer, Item, int)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GiveItem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 540,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gives quantity of an item to the player",
      "example": [],
      "syntax": {
        "content": "public void GiveItem(BasePlayer player, Item item, int quantity = 1)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "item",
            "type": "Item",
            "description": ""
          },
          {
            "id": "quantity",
            "type": "System.Int32",
            "description": ""
          }
        ],
        "content.vb": "Public Sub GiveItem(player As BasePlayer, item As Item, quantity As Integer = 1)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.GiveItem*",
      "nameWithType.vb": "Player.GiveItem(BasePlayer, Item, Integer)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer, Item, Integer)",
      "name.vb": "GiveItem(BasePlayer, Item, Integer)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Inventory(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.Inventory(BasePlayer)",
      "id": "Inventory(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Inventory(BasePlayer)",
      "nameWithType": "Player.Inventory(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Inventory(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Inventory",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 551,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets the inventory of the player",
      "example": [],
      "syntax": {
        "content": "public PlayerInventory Inventory(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "return": {
          "type": "PlayerInventory",
          "description": ""
        },
        "content.vb": "Public Function Inventory(player As BasePlayer) As PlayerInventory"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.Inventory*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.ClearInventory(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.ClearInventory(BasePlayer)",
      "id": "ClearInventory(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ClearInventory(BasePlayer)",
      "nameWithType": "Player.ClearInventory(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.ClearInventory(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ClearInventory",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 557,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Clears the inventory of the player",
      "example": [],
      "syntax": {
        "content": "public void ClearInventory(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "content.vb": "Public Sub ClearInventory(player As BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.ClearInventory*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.ResetInventory(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Player.ResetInventory(BasePlayer)",
      "id": "ResetInventory(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Player",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ResetInventory(BasePlayer)",
      "nameWithType": "Player.ResetInventory(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Player.ResetInventory(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Player.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ResetInventory",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Player.cs",
        "startLine": 563,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Resets the inventory of the player",
      "example": [],
      "syntax": {
        "content": "public void ResetInventory(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "content.vb": "Public Sub ResetInventory(player As BasePlayer)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Player.ResetInventory*"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Libraries",
      "commentId": "N:Oxide.Game.Rust.Libraries",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Libraries",
      "nameWithType": "Oxide.Game.Rust.Libraries",
      "fullName": "Oxide.Game.Rust.Libraries",
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
      "uid": "Oxide.Core.Libraries.Library",
      "commentId": "T:Oxide.Core.Libraries.Library",
      "parent": "Oxide.Core.Libraries",
      "isExternal": true,
      "name": "Library",
      "nameWithType": "Library",
      "fullName": "Oxide.Core.Libraries.Library"
    },
    {
      "uid": "Oxide.Core.Libraries.Library.Shutdown",
      "commentId": "M:Oxide.Core.Libraries.Library.Shutdown",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "Shutdown()",
      "nameWithType": "Library.Shutdown()",
      "fullName": "Oxide.Core.Libraries.Library.Shutdown()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.Shutdown",
          "name": "Shutdown",
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
          "uid": "Oxide.Core.Libraries.Library.Shutdown",
          "name": "Shutdown",
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
      "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
      "commentId": "M:Oxide.Core.Libraries.Library.GetFunctionNames",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "GetFunctionNames()",
      "nameWithType": "Library.GetFunctionNames()",
      "fullName": "Oxide.Core.Libraries.Library.GetFunctionNames()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
          "name": "GetFunctionNames",
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
          "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
          "name": "GetFunctionNames",
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
      "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
      "commentId": "M:Oxide.Core.Libraries.Library.GetPropertyNames",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "GetPropertyNames()",
      "nameWithType": "Library.GetPropertyNames()",
      "fullName": "Oxide.Core.Libraries.Library.GetPropertyNames()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
          "name": "GetPropertyNames",
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
          "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
          "name": "GetPropertyNames",
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
      "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Library.GetFunction(System.String)",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetFunction(string)",
      "nameWithType": "Library.GetFunction(string)",
      "fullName": "Oxide.Core.Libraries.Library.GetFunction(string)",
      "nameWithType.vb": "Library.GetFunction(String)",
      "fullName.vb": "Oxide.Core.Libraries.Library.GetFunction(String)",
      "name.vb": "GetFunction(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
          "name": "GetFunction",
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
          "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
          "name": "GetFunction",
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
      "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Library.GetProperty(System.String)",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetProperty(string)",
      "nameWithType": "Library.GetProperty(string)",
      "fullName": "Oxide.Core.Libraries.Library.GetProperty(string)",
      "nameWithType.vb": "Library.GetProperty(String)",
      "fullName.vb": "Oxide.Core.Libraries.Library.GetProperty(String)",
      "name.vb": "GetProperty(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
          "name": "GetProperty",
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
          "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
          "name": "GetProperty",
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
      "uid": "Oxide.Core.Libraries.Library.IsGlobal",
      "commentId": "P:Oxide.Core.Libraries.Library.IsGlobal",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "IsGlobal",
      "nameWithType": "Library.IsGlobal",
      "fullName": "Oxide.Core.Libraries.Library.IsGlobal"
    },
    {
      "uid": "Oxide.Core.Libraries.Library.LastException",
      "commentId": "P:Oxide.Core.Libraries.Library.LastException",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "LastException",
      "nameWithType": "Library.LastException",
      "fullName": "Oxide.Core.Libraries.Library.LastException"
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
      "uid": "Oxide.Core.Libraries",
      "commentId": "N:Oxide.Core.Libraries",
      "isExternal": true,
      "name": "Oxide.Core.Libraries",
      "nameWithType": "Oxide.Core.Libraries",
      "fullName": "Oxide.Core.Libraries",
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
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Language*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Language",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Language(BasePlayer)",
      "name": "Language",
      "nameWithType": "Player.Language",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Language"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Address*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Address",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Address(Network.Connection)",
      "name": "Address",
      "nameWithType": "Player.Address",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Address"
    },
    {
      "uid": "Network.Connection",
      "commentId": "T:Network.Connection",
      "parent": "Network",
      "isExternal": true,
      "name": "Connection",
      "nameWithType": "Connection",
      "fullName": "Network.Connection"
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
      "uid": "Network",
      "commentId": "N:Network",
      "isExternal": true,
      "name": "Network",
      "nameWithType": "Network",
      "fullName": "Network"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Ping",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Ping(Network.Connection)",
      "name": "Ping",
      "nameWithType": "Player.Ping",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ping"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.IsAdmin*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.IsAdmin",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.IsAdmin(System.UInt64)",
      "name": "IsAdmin",
      "nameWithType": "Player.IsAdmin",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsAdmin"
    },
    {
      "uid": "System.UInt64",
      "commentId": "T:System.UInt64",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.uint64",
      "name": "ulong",
      "nameWithType": "ulong",
      "fullName": "ulong",
      "nameWithType.vb": "ULong",
      "fullName.vb": "ULong",
      "name.vb": "ULong"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.IsBanned*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.IsBanned",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.IsBanned(System.UInt64)",
      "name": "IsBanned",
      "nameWithType": "Player.IsBanned",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsBanned"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsConnected*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.IsConnected",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.IsConnected(BasePlayer)",
      "name": "IsConnected",
      "nameWithType": "Player.IsConnected",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsConnected"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.IsSleeping*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.IsSleeping",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.IsSleeping(System.UInt64)",
      "name": "IsSleeping",
      "nameWithType": "Player.IsSleeping",
      "fullName": "Oxide.Game.Rust.Libraries.Player.IsSleeping"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Ban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Ban",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Ban(System.UInt64,System.String)",
      "name": "Ban",
      "nameWithType": "Player.Ban",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Ban"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Heal*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Heal",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Heal(BasePlayer,System.Single)",
      "name": "Heal",
      "nameWithType": "Player.Heal",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Heal"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Hurt*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Hurt",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Hurt(BasePlayer,System.Single)",
      "name": "Hurt",
      "nameWithType": "Player.Hurt",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Hurt"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Kick*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Kick",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Kick(BasePlayer,System.String)",
      "name": "Kick",
      "nameWithType": "Player.Kick",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Kick"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Kill*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Kill",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Kill(BasePlayer)",
      "name": "Kill",
      "nameWithType": "Player.Kill",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Kill"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Rename*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Rename",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Rename(BasePlayer,System.String)",
      "name": "Rename",
      "nameWithType": "Player.Rename",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Rename"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Teleport*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Teleport",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Teleport(BasePlayer,UnityEngine.Vector3)",
      "name": "Teleport",
      "nameWithType": "Player.Teleport",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Teleport"
    },
    {
      "uid": "UnityEngine.Vector3",
      "commentId": "T:UnityEngine.Vector3",
      "parent": "UnityEngine",
      "isExternal": true,
      "name": "Vector3",
      "nameWithType": "Vector3",
      "fullName": "UnityEngine.Vector3"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Unban*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Unban",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Unban(System.UInt64)",
      "name": "Unban",
      "nameWithType": "Player.Unban",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Unban"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Position*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Position",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Position(BasePlayer)",
      "name": "Position",
      "nameWithType": "Player.Position",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Position"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Find*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Find",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Find(System.String)",
      "name": "Find",
      "nameWithType": "Player.Find",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Find"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.FindById*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.FindById",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.FindById(System.String)",
      "name": "FindById",
      "nameWithType": "Player.FindById",
      "fullName": "Oxide.Game.Rust.Libraries.Player.FindById"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Players*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Players",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Players",
      "name": "Players",
      "nameWithType": "Player.Players",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Players"
    },
    {
      "uid": "ListHashSet{BasePlayer}",
      "commentId": "T:ListHashSet{BasePlayer}",
      "definition": "ListHashSet`1",
      "name": "ListHashSet<BasePlayer>",
      "nameWithType": "ListHashSet<BasePlayer>",
      "fullName": "ListHashSet<BasePlayer>",
      "nameWithType.vb": "ListHashSet(Of BasePlayer)",
      "fullName.vb": "ListHashSet(Of BasePlayer)",
      "name.vb": "ListHashSet(Of BasePlayer)",
      "spec.csharp": [
        {
          "uid": "ListHashSet`1",
          "name": "ListHashSet",
          "isExternal": true
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "BasePlayer",
          "name": "BasePlayer",
          "isExternal": true
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "ListHashSet`1",
          "name": "ListHashSet",
          "isExternal": true
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
          "uid": "BasePlayer",
          "name": "BasePlayer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "ListHashSet`1",
      "commentId": "T:ListHashSet`1",
      "isExternal": true,
      "name": "ListHashSet<T>",
      "nameWithType": "ListHashSet<T>",
      "fullName": "ListHashSet<T>",
      "nameWithType.vb": "ListHashSet(Of T)",
      "fullName.vb": "ListHashSet(Of T)",
      "name.vb": "ListHashSet(Of T)",
      "spec.csharp": [
        {
          "uid": "ListHashSet`1",
          "name": "ListHashSet",
          "isExternal": true
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
          "uid": "ListHashSet`1",
          "name": "ListHashSet",
          "isExternal": true
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Sleepers*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Sleepers",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Sleepers",
      "name": "Sleepers",
      "nameWithType": "Player.Sleepers",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Sleepers"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Message*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Message",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Message(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "name": "Message",
      "nameWithType": "Player.Message",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Message"
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
      "uid": "Oxide.Game.Rust.Libraries.Player.Reply*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Reply",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Reply(BasePlayer,System.String,System.String,System.UInt64,System.Object[])",
      "name": "Reply",
      "nameWithType": "Player.Reply",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Reply"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Command",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Command(BasePlayer,System.String,System.Object[])",
      "name": "Command",
      "nameWithType": "Player.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Command"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.DropItem*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.DropItem",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.DropItem(BasePlayer,System.Int32)",
      "name": "DropItem",
      "nameWithType": "Player.DropItem",
      "fullName": "Oxide.Game.Rust.Libraries.Player.DropItem"
    },
    {
      "uid": "Item",
      "commentId": "T:Item",
      "isExternal": true,
      "name": "Item",
      "nameWithType": "Item",
      "fullName": "Item"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.GiveItem*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.GiveItem",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.GiveItem(BasePlayer,System.Int32,System.Int32)",
      "name": "GiveItem",
      "nameWithType": "Player.GiveItem",
      "fullName": "Oxide.Game.Rust.Libraries.Player.GiveItem"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.Inventory*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.Inventory",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.Inventory(BasePlayer)",
      "name": "Inventory",
      "nameWithType": "Player.Inventory",
      "fullName": "Oxide.Game.Rust.Libraries.Player.Inventory"
    },
    {
      "uid": "PlayerInventory",
      "commentId": "T:PlayerInventory",
      "isExternal": true,
      "name": "PlayerInventory",
      "nameWithType": "PlayerInventory",
      "fullName": "PlayerInventory"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.ClearInventory*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.ClearInventory",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.ClearInventory(BasePlayer)",
      "name": "ClearInventory",
      "nameWithType": "Player.ClearInventory",
      "fullName": "Oxide.Game.Rust.Libraries.Player.ClearInventory"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player.ResetInventory*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Player.ResetInventory",
      "href": "Oxide.Game.Rust.Libraries.Player.html#Oxide.Game.Rust.Libraries.Player.ResetInventory(BasePlayer)",
      "name": "ResetInventory",
      "nameWithType": "Player.ResetInventory",
      "fullName": "Oxide.Game.Rust.Libraries.Player.ResetInventory"
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