# Class RustPlayerManager
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustPlayerManager : IPlayerManager
```  
#### Represents a generic player manager


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### All  
Gets all players  
```csharp
public IEnumerable<IPlayer> All { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L75)
### Connected  
Gets all connected players  
```csharp
public IEnumerable<IPlayer> Connected { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L81)
### Sleeping  
Gets all sleeping players  
```csharp
public IEnumerable<IPlayer> Sleeping { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L87)
## Methods 
### FindPlayerById(string)  
Finds a single player given unique ID  
```csharp
public IPlayer FindPlayerById(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L94)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 
### FindPlayerByObj(object)  
Finds a single connected player given game object  
```csharp
public IPlayer FindPlayerByObj(object obj)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L104)  
  
#### Parameters  
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0) obj 
### FindPlayer(string)  
Finds a single player given a partial name or unique ID (case-insensitive, wildcards accepted, multiple matches returns null)  
```csharp
public IPlayer FindPlayer(string partialNameOrId)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L111)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) partialNameOrId 
### FindPlayers(string)  
Finds any number of players given a partial name or unique ID (case-insensitive, wildcards accepted)  
```csharp
public IEnumerable<IPlayer> FindPlayers(string partialNameOrId)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustPlayerManager.cs#L122)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) partialNameOrId 