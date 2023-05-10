# Class Rust
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Rust : Library
```  
#### A library containing utility shortcut functions for Rust


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### IsGlobal  
Returns if this library should be loaded into the global namespace  
```csharp
public override bool IsGlobal { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L21)
## Methods 
### PrivateBindingFlag()  
Gets private bindingflag for accessing private methods, fields, and properties  
```csharp
[LibraryFunction("PrivateBindingFlag")]
public BindingFlags PrivateBindingFlag()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L28)  
  
#### Parameters  
None
### QuoteSafe(string)  
Converts a string into a quote safe string  
```csharp
[LibraryFunction("QuoteSafe")]
public string QuoteSafe(string str)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L35)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) str 
### BroadcastChat(string, string, string)  
Broadcasts the specified chat message to all players  
```csharp
[LibraryFunction("BroadcastChat")]
public void BroadcastChat(string name, string message = null, string userId = "0")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L48)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) userId 
### SendChatMessage(BasePlayer, string, string, string)  
Sends a chat message to the player  
```csharp
[LibraryFunction("SendChatMessage")]
public void SendChatMessage(BasePlayer player, string name, string message = null, string userId = "0")
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L61)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) userId 
### RunClientCommand(BasePlayer, string, params object[])  
Runs a client command  
```csharp
[LibraryFunction("RunClientCommand")]
public void RunClientCommand(BasePlayer player, string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L77)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### RunServerCommand(string, params object[])  
Runs a server command  
```csharp
[LibraryFunction("RunServerCommand")]
public void RunServerCommand(string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L88)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### UserIDFromConnection(Connection)  
Returns the Steam ID for the specified connection as a string  
```csharp
[LibraryFunction("UserIDFromConnection")]
public string UserIDFromConnection(Connection connection)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L101)  
  
#### Parameters  
Connection connection 
### UserIDsFromBuildingPrivlidge(BuildingPrivlidge)  
Returns the Steam ID for the specified building privilege as an array  
```csharp
[LibraryFunction("UserIDsFromBuildingPrivilege")]
public Array UserIDsFromBuildingPrivlidge(BuildingPrivlidge priv)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L112)  
  
#### Parameters  
BuildingPrivlidge priv 
### UserIDFromPlayer(BasePlayer)  
Returns the Steam ID for the specified player as a string  
```csharp
[LibraryFunction("UserIDFromPlayer")]
public string UserIDFromPlayer(BasePlayer player)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L123)  
  
#### Parameters  
BasePlayer player 
### OwnerIDFromEntity(BaseEntity)  
Returns the Steam ID for the specified entity as a string  
```csharp
[LibraryFunction("OwnerIDFromEntity")]
public string OwnerIDFromEntity(BaseEntity entity)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L131)  
  
#### Parameters  
BaseEntity entity 
### FindPlayer(string)  
Returns the player for the specified name, id or ip  
```csharp
[LibraryFunction("FindPlayer")]
public BasePlayer FindPlayer(string nameOrIdOrIp)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L139)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) nameOrIdOrIp 
### FindPlayerByName(string)  
Returns the player for the specified name  
```csharp
[LibraryFunction("FindPlayerByName")]
public BasePlayer FindPlayerByName(string name)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L147)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name 
### FindPlayerById(ulong)  
Returns the player for the specified id  
```csharp
[LibraryFunction("FindPlayerById")]
public BasePlayer FindPlayerById(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L155)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### FindPlayerByIdString(string)  
Returns the player for the specified id  
```csharp
[LibraryFunction("FindPlayerByIdString")]
public BasePlayer FindPlayerByIdString(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L163)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### ForcePlayerPosition(BasePlayer, float, float, float)  
Forces player position (teleportation)  
```csharp
[LibraryFunction("ForcePlayerPosition")]
public void ForcePlayerPosition(BasePlayer player, float x, float y, float z)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Rust.cs#L173)  
  
#### Parameters  
BasePlayer player   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) x   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) y   
[System.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single?view=net-7.0) z 