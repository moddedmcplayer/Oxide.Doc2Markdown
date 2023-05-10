# Class RustCovalenceProvider
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCovalenceProvider : ICovalenceProvider
```  
#### Provides Covalence functionality for the game "Rust"


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### GameName  
Gets the name of the game for which this provider provides  
```csharp
public string GameName { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L12)
### ClientAppId  
Gets the Steam app ID of the game's client, if available  
```csharp
public uint ClientAppId { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L17)
### ServerAppId  
Gets the Steam app ID of the game's server, if available  
```csharp
public uint ServerAppId { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L22)
### PlayerManager  
Gets the player manager  
```csharp
public RustPlayerManager PlayerManager { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L37)
### CommandSystem  
Gets the command system provider  
```csharp
public RustCommandSystem CommandSystem { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L42)
## Constructors 
### RustCovalenceProvider()  
  
```csharp
public RustCovalenceProvider()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L29)
## Methods 
### CreateServer()  
Creates the game-specific server object  
```csharp
public IServer CreateServer()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L48)  
  
#### Parameters  
None
### CreatePlayerManager()  
Creates the game-specific player manager object  
```csharp
public IPlayerManager CreatePlayerManager()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L54)  
  
#### Parameters  
None
### CreateCommandSystemProvider()  
Creates the game-specific command system provider object  
```csharp
public ICommandSystem CreateCommandSystemProvider()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L65)  
  
#### Parameters  
None
### FormatText(string)  
Formats the text with markup as specified in Oxide.Core.Libraries.Covalence.Formatter
into the game-specific markup language  
```csharp
public string FormatText(string text)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCovalenceProvider.cs#L73)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) text text to format