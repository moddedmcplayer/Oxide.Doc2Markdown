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
### Name  
Gets/sets the public-facing name of the server  
```csharp
public string Name { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L27)
### Address  
Gets the public-facing IP address of the server, if known  
```csharp
public IPAddress Address { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L39)
### LocalAddress  
Gets the local IP address of the server, if known  
```csharp
public IPAddress LocalAddress { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L73)
### Port  
Gets the public-facing network port of the server, if known  
```csharp
public ushort Port { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L92)
### Version  
Gets the version or build number of the server  
```csharp
public string Version { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L97)
### Protocol  
Gets the network protocol version of the server  
```csharp
public string Protocol { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L102)
### Language  
Gets the language set by the server  
```csharp
public CultureInfo Language { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L107)
### Players  
Gets the total of players currently on the server  
```csharp
public int Players { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L112)
### MaxPlayers  
Gets/sets the maximum players allowed on the server  
```csharp
public int MaxPlayers { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L117)
### Time  
Gets/sets the current in-game time on the server  
```csharp
public DateTime Time { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L126)
### SaveInfo  
Gets information on the currently loaded save file  
```csharp
public SaveInfo SaveInfo { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L135)
## Methods 
### Ban(string, string, TimeSpan)  
Bans the player for the specified reason and duration  
```csharp
public void Ban(string id, string reason, TimeSpan duration = default)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L147)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) reason   
[System.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-7.0) duration 
### BanTimeRemaining(string)  
Gets the amount of time remaining on the player's ban  
```csharp
public TimeSpan BanTimeRemaining(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L160)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### IsBanned(string)  
Gets if the player is banned  
```csharp
public bool IsBanned(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L166)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### Save()  
Saves the server and any related information  
```csharp
public void Save()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L171)  
  
#### Parameters  
None
### Unban(string)  
Unbans the player  
```csharp
public void Unban(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L182)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### Broadcast(string, string, params object[])  
Broadcasts the specified chat message and prefix to all players  
```csharp
public void Broadcast(string message, string prefix, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L201)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Broadcast(string)  
Broadcasts the specified chat message to all players  
```csharp
public void Broadcast(string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L210)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### Command(string, params object[])  
Runs the specified server command  
```csharp
public void Command(string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustServer.cs#L217)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 