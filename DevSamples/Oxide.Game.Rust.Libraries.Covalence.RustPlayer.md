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
### Object  
Gets the object that backs the player  
```csharp
public object Object { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L51)
### LastCommand  
Gets the player's last command type  
```csharp
public CommandType LastCommand { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L56)
### Name  
Gets/sets the name for the player  
```csharp
public string Name { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L65)
### Id  
Gets the ID for the player (unique within the current game)  
```csharp
public string Id { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L70)
### Language  
Gets the player's language  
```csharp
public CultureInfo Language { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L75)
### Address  
Gets the player's IP address  
```csharp
public string Address { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L80)
### Ping  
Gets the player's average network ping  
```csharp
public int Ping { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L85)
### IsAdmin  
Returns if the player is admin  
```csharp
public bool IsAdmin { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L90)
### IsBanned  
Gets if the player is banned  
```csharp
public bool IsBanned { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L95)
### IsConnected  
Returns if the player is connected  
```csharp
public bool IsConnected { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L100)
### IsSleeping  
Returns if the player is sleeping  
```csharp
public bool IsSleeping { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L105)
### IsServer  
Returns if the player is the server  
```csharp
public bool IsServer { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L110)
### BanTimeRemaining  
Gets the amount of time remaining on the player's ban  
```csharp
public TimeSpan BanTimeRemaining { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L126)
### Health  
Gets/sets the player's health  
```csharp
public float Health { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L137)
### MaxHealth  
Gets/sets the player's maximum health  
```csharp
public float MaxHealth { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L163)
## Methods 
### Ban(string, TimeSpan)  
Bans the player for the specified reason and duration  
```csharp
public void Ban(string reason, TimeSpan duration = default)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L121)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason   
[System.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-7.0) duration 
### Heal(float)  
Heals the player's character by specified amount  
```csharp
public void Heal(float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L132)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Hurt(float)  
Damages the player's character by specified amount  
```csharp
public void Hurt(float amount)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L147)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) amount 
### Kick(string)  
Kicks the player from the game  
```csharp
public void Kick(string reason)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L153)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason 
### Kill()  
Causes the player's character to die  
```csharp
public void Kill()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L158)  
  
#### Parameters  
None
### Rename(string)  
Renames the player to specified name
<param name="name" />  
```csharp
public void Rename(string name)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L173)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name 
### Teleport(float, float, float)  
Teleports the player's character to the specified position  
```csharp
public void Teleport(float x, float y, float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L181)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 
### Teleport(GenericPosition)  
Teleports the player's character to the specified generic position  
```csharp
public void Teleport(GenericPosition pos)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L187)  
  
#### Parameters  
GenericPosition pos 
### Unban()  
Unbans the player  
```csharp
public void Unban()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L192)  
  
#### Parameters  
None
### Position(out float, out float, out float)  
Gets the position of the player  
```csharp
public void Position(out float x, out float y, out float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L204)  
  
#### Parameters  
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 
### Position()  
Gets the position of the player  
```csharp
public GenericPosition Position()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L216)  
  
#### Parameters  
None
### Message(string, string, params object[])  
Sends the specified message and prefix to the player  
```csharp
public void Message(string message, string prefix, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L232)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Message(string)  
Sends the specified message to the player  
```csharp
public void Message(string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L241)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### Reply(string, string, params object[])  
Replies to the player with the specified message and prefix  
```csharp
public void Reply(string message, string prefix, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L249)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Reply(string)  
Replies to the player with the specified message  
```csharp
public void Reply(string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L267)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### Command(string, params object[])  
Runs the specified console command on the player  
```csharp
public void Command(string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L274)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### HasPermission(string)  
Gets if the player has the specified permission  
```csharp
public bool HasPermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L285)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### GrantPermission(string)  
Grants the specified permission on this player  
```csharp
public void GrantPermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L291)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### RevokePermission(string)  
Strips the specified permission from this player  
```csharp
public void RevokePermission(string perm)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L297)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) perm 
### BelongsToGroup(string)  
Gets if the player belongs to the specified group  
```csharp
public bool BelongsToGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L304)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 
### AddToGroup(string)  
Adds the player to the specified group  
```csharp
public void AddToGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L310)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 
### RemoveFromGroup(string)  
Removes the player from the specified group  
```csharp
public void RemoveFromGroup(string group)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L316)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) group 
### Equals(IPlayer)  
Returns if player's unique ID is equal to another player's unique ID  
```csharp
public bool Equals(IPlayer other)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L327)  
  
#### Parameters  
IPlayer other 
### Equals(object)  
Returns if player's object is equal to another player's object  
```csharp
public override bool Equals(object obj)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L334)  
Overrides System.Object.Equals(System.Object)  
#### Parameters  
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0) obj 
### GetHashCode()  
Gets the hash code of the player's unique ID  
```csharp
public override int GetHashCode()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L340)  
Overrides System.Object.GetHashCode  
#### Parameters  
None
### ToString()  
Returns a human readable string representation of this IPlayer  
```csharp
public override string ToString()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayer.cs#L346)  
Overrides System.Object.ToString  
#### Parameters  
None