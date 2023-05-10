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
### Object  
Gets the object that backs the player  
```csharp
public object Object { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L17)
### LastCommand  
Gets the player's last command type  
```csharp
public CommandType LastCommand { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L22)
### Name  
Gets/sets the name for the player  
```csharp
public string Name { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L31)
### Id  
Gets the ID for the player (unique within the current game)  
```csharp
public string Id { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L36)
### Language  
Gets the player's language  
```csharp
public CultureInfo Language { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L41)
### Address  
Gets the player's IP address  
```csharp
public string Address { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L46)
### Ping  
Gets the player's average network ping  
```csharp
public int Ping { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L51)
### IsAdmin  
Returns if the player is admin  
```csharp
public bool IsAdmin { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L56)
### IsBanned  
Gets if the player is banned  
```csharp
public bool IsBanned { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L61)
### IsConnected  
Returns if the player is connected  
```csharp
public bool IsConnected { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L66)
### IsSleeping  
Returns if the player is sleeping  
```csharp
public bool IsSleeping { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L71)
### IsServer  
Returns if the player is the server  
```csharp
public bool IsServer { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L76)
### BanTimeRemaining  
Gets the amount of time remaining on the player's ban  
```csharp
public TimeSpan BanTimeRemaining { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L94)
### Health  
Gets/sets the player's health  
```csharp
public float Health { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L107)
### MaxHealth  
Gets/sets the player's maximum health  
```csharp
public float MaxHealth { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L135)
## Methods 
### Ban(string, TimeSpan)  
Bans the player for the specified reason and duration  
```csharp
public void Ban(string reason, TimeSpan duration)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L87)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason   
[System.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-7.0) duration 
### Heal(float)  
Heals the player's character by specified amount  
```csharp
public void Heal(float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L100)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Hurt(float)  
Damages the player's character by specified amount  
```csharp
public void Hurt(float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L113)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Kick(string)  
Kicks the player from the game  
```csharp
public void Kick(string reason)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L121)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Kill()  
Causes the player's character to die  
```csharp
public void Kill()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L128)  
  
#### Parameters  
None
### Rename(string)  
Renames the player to specified name
<param name="name" />  
```csharp
public void Rename(string name)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L141)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name 
### Teleport(float, float, float)  
Teleports the player's character to the specified position  
```csharp
public void Teleport(float x, float y, float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L151)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 
### Teleport(GenericPosition)  
Teleports the player's character to the specified generic position  
```csharp
public void Teleport(GenericPosition pos)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L159)  
  
#### Parameters  
GenericPosition pos 
### Unban()  
Unbans the player  
```csharp
public void Unban()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L164)  
  
#### Parameters  
None
### Position(out float, out float, out float)  
Gets the position of the player  
```csharp
public void Position(out float x, out float y, out float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L178)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 
### Position()  
Gets the position of the player  
```csharp
public GenericPosition Position()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L189)  
  
#### Parameters  
None
### Message(string, string, params object[])  
Sends the specified message and prefix to the player  
```csharp
public void Message(string message, string prefix, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L201)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Message(string)  
Sends the specified message to the player  
```csharp
public void Message(string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L212)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### Reply(string, string, params object[])  
Replies to the player with the specified message and prefix  
```csharp
public void Reply(string message, string prefix, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L220)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Reply(string)  
Replies to the player with the specified message  
```csharp
public void Reply(string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L229)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### Command(string, params object[])  
Runs the specified console command on the player  
```csharp
public void Command(string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L236)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### HasPermission(string)  
Gets if the player has the specified permission  
```csharp
public bool HasPermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L250)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### GrantPermission(string)  
Grants the specified permission on this player  
```csharp
public void GrantPermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L256)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### RevokePermission(string)  
Strips the specified permission from this player  
```csharp
public void RevokePermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L264)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### BelongsToGroup(string)  
Gets if the player belongs to the specified group  
```csharp
public bool BelongsToGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L273)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 
### AddToGroup(string)  
Adds the player to the specified group  
```csharp
public void AddToGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L279)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 
### RemoveFromGroup(string)  
Removes the player from the specified group  
```csharp
public void RemoveFromGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustConsolePlayer.cs#L287)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 