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
### Players  
Returns all connected players  
```csharp
public ListHashSet<BasePlayer> Players { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L382)
### Sleepers  
Returns all sleeping players  
```csharp
public ListHashSet<BasePlayer> Sleepers { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L387)
## Methods 
### Language(BasePlayer)  
Gets the player's language  
```csharp
public CultureInfo Language(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L29)  
  
#### Parameters  
BasePlayer player 
### Address(Connection)  
Gets the player's IP address  
```csharp
public string Address(Connection connection)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L46)  
  
#### Parameters  
Connection connection 
### Address(BasePlayer)  
Gets the player's IP address  
```csharp
public string Address(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L51)  
  
#### Parameters  
BasePlayer player 
### Ping(Connection)  
Gets the player's average network ping  
```csharp
public int Ping(Connection connection)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L56)  
  
#### Parameters  
Connection connection 
### Ping(BasePlayer)  
Gets the player's average network ping  
```csharp
public int Ping(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L61)  
  
#### Parameters  
BasePlayer player 
### IsAdmin(ulong)  
Returns if the player is admin  
```csharp
public bool IsAdmin(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L66)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### IsAdmin(string)  
Returns if the player is admin  
```csharp
public bool IsAdmin(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L71)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### IsAdmin(BasePlayer)  
Returns if the player is admin  
```csharp
public bool IsAdmin(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L76)  
  
#### Parameters  
BasePlayer player 
### IsBanned(ulong)  
Gets if the player is banned  
```csharp
public bool IsBanned(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L81)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### IsBanned(string)  
Gets if the player is banned  
```csharp
public bool IsBanned(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L86)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### IsBanned(BasePlayer)  
Gets if the player is banned  
```csharp
public bool IsBanned(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L91)  
  
#### Parameters  
BasePlayer player 
### IsConnected(BasePlayer)  
Gets if the player is connected  
```csharp
public bool IsConnected(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L96)  
  
#### Parameters  
BasePlayer player 
### IsSleeping(ulong)  
Returns if the player is sleeping  
```csharp
public bool IsSleeping(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L101)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### IsSleeping(string)  
Returns if the player is sleeping  
```csharp
public bool IsSleeping(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L106)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### IsSleeping(BasePlayer)  
Returns if the player is sleeping  
```csharp
public bool IsSleeping(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L111)  
  
#### Parameters  
BasePlayer player 
### Ban(ulong, string)  
Bans the player from the server based on user ID  
```csharp
public void Ban(ulong id, string reason = "")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L122)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Ban(string, string)  
Bans the player from the server based on user ID  
```csharp
public void Ban(string id, string reason = "")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L143)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Ban(BasePlayer, string)  
Bans the player from the server  
```csharp
public void Ban(BasePlayer player, string reason = "")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L150)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Heal(BasePlayer, float)  
Heals the player by specified amount  
```csharp
public void Heal(BasePlayer player, float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L157)  
  
#### Parameters  
BasePlayer player   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Hurt(BasePlayer, float)  
Damages the player by specified amount  
```csharp
public void Hurt(BasePlayer player, float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L164)  
  
#### Parameters  
BasePlayer player   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Kick(BasePlayer, string)  
Kicks the player from the server  
```csharp
public void Kick(BasePlayer player, string reason = "")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L171)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Kill(BasePlayer)  
Causes the player to die  
```csharp
public void Kill(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L177)  
  
#### Parameters  
BasePlayer player 
### Rename(BasePlayer, string)  
Renames the player to specified name
<param name="session" />
<param name="name" />  
```csharp
public void Rename(BasePlayer player, string name)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L184)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name 
### Teleport(BasePlayer, Vector3)  
Teleports the player to the specified position  
```csharp
public void Teleport(BasePlayer player, Vector3 destination)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L227)  
  
#### Parameters  
BasePlayer player   
Vector3 destination 
### Teleport(BasePlayer, BasePlayer)  
Teleports the player to the target player  
```csharp
public void Teleport(BasePlayer player, BasePlayer target)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L271)  
  
#### Parameters  
BasePlayer player   
BasePlayer target 
### Teleport(BasePlayer, float, float, float)  
Teleports the player to the specified position  
```csharp
public void Teleport(BasePlayer player, float x, float y, float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L280)  
  
#### Parameters  
BasePlayer player   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 
### Unban(ulong)  
Unbans the player by user ID  
```csharp
public void Unban(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L285)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### Unban(string)  
Unbans the player by user ID  
```csharp
public void Unban(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L299)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### Unban(BasePlayer)  
Unbans the player  
```csharp
public void Unban(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L304)  
  
#### Parameters  
BasePlayer player 
### Position(BasePlayer)  
Returns the position of player as Vector3  
```csharp
public Vector3 Position(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L315)  
  
#### Parameters  
BasePlayer player 
### Find(string)  
Gets the player object using a name, Steam ID, or IP address  
```csharp
public BasePlayer Find(string nameOrIdOrIp)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L326)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) nameOrIdOrIp 
### FindById(string)  
Gets the player object using a Steam ID  
```csharp
public BasePlayer FindById(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L346)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### FindById(ulong)  
Gets the player object using a Steam ID  
```csharp
public BasePlayer FindById(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L365)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### Message(BasePlayer, string, string, ulong, params object[])  
Sends the specified message and prefix to the player  
```csharp
public void Message(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L400)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Message(BasePlayer, string, ulong)  
Sends the specified message to the player  
```csharp
public void Message(BasePlayer player, string message, ulong userId = 0)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L422)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId 
### Reply(BasePlayer, string, string, ulong, params object[])  
Replies to the player with the specified message and prefix  
```csharp
public void Reply(BasePlayer player, string message, string prefix, ulong userId = 0, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L431)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Reply(BasePlayer, string, ulong)  
Replies to the player with the specified message  
```csharp
public void Reply(BasePlayer player, string message, ulong userId = 0)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L442)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId 
### Command(BasePlayer, string, params object[])  
Runs the specified player command  
```csharp
public void Command(BasePlayer player, string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L450)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### DropItem(BasePlayer, int)  
Drops item by item ID from player's inventory  
```csharp
public void DropItem(BasePlayer player, int itemId)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L461)  
  
#### Parameters  
BasePlayer player   
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-7.0) itemId 
### DropItem(BasePlayer, Item)  
Drops item from the player's inventory  
```csharp
public void DropItem(BasePlayer player, Item item)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L496)  
  
#### Parameters  
BasePlayer player   
Item item 
### GiveItem(BasePlayer, int, int)  
Gives quantity of an item to the player  
```csharp
public void GiveItem(BasePlayer player, int itemId, int quantity = 1)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L532)  
  
#### Parameters  
BasePlayer player   
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-7.0) itemId   
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-7.0) quantity 
### GiveItem(BasePlayer, Item, int)  
Gives quantity of an item to the player  
```csharp
public void GiveItem(BasePlayer player, Item item, int quantity = 1)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L540)  
  
#### Parameters  
BasePlayer player   
Item item   
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-7.0) quantity 
### Inventory(BasePlayer)  
Gets the inventory of the player  
```csharp
public PlayerInventory Inventory(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L551)  
  
#### Parameters  
BasePlayer player 
### ClearInventory(BasePlayer)  
Clears the inventory of the player  
```csharp
public void ClearInventory(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L557)  
  
#### Parameters  
BasePlayer player 
### ResetInventory(BasePlayer)  
Resets the inventory of the player  
```csharp
public void ResetInventory(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Player.cs#L563)  
  
#### Parameters  
BasePlayer player 