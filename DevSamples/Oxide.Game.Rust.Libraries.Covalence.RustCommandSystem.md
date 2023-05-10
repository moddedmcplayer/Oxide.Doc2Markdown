# Class RustCommandSystem
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCommandSystem : ICommandSystem
```  
#### Represents a binding to a generic command system


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
### RustCommandSystem()  
Initializes the command system  
```csharp
public RustCommandSystem()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCommandSystem.cs#L80)
## Methods 
### RegisterCommand(string, Plugin, CommandCallback)  
Registers the specified command  
```csharp
public void RegisterCommand(string command, Plugin plugin, CommandCallback callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCommandSystem.cs#L102)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin   
CommandCallback callback 
### UnregisterCommand(string, Plugin)  
Unregisters the specified command  
```csharp
public void UnregisterCommand(string command, Plugin plugin)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCommandSystem.cs#L253)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin 
### HandleChatMessage(IPlayer, string)  
Handles a chat message  
```csharp
public bool HandleChatMessage(IPlayer player, string message)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCommandSystem.cs#L322)  
  
#### Parameters  
IPlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message 
### ExtractArgs(Arg)  
Extract the arguments from a ConsoleSystem.Arg object  
```csharp
public static string[] ExtractArgs(ConsoleSystem.Arg arg)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Covalence/RustCommandSystem.cs#L376)  
  
#### Parameters  
Arg arg 