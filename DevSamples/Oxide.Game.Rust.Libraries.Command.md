# Class Command
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Command : Library
```  
#### A library containing functions for adding console and chat commands


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, IsGlobal, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
### Command()  
Initializes a new instance of the Command class  
```csharp
public Command()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L108)
## Methods 
### AddChatCommand(string, Plugin, string)  
Adds a chat command  
```csharp
[LibraryFunction("AddChatCommand")]
public void AddChatCommand(string name, Plugin plugin, string callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L121)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name   
Plugin plugin   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) callback 
### AddChatCommand(string, Plugin, Action<BasePlayer, string, string[]>)  
Adds a chat command  
```csharp
public void AddChatCommand(string command, Plugin plugin, Action<BasePlayer, string, string[]> callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L133)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin   
[System.Action{BasePlayer,System.String,System.String[]}](https://learn.microsoft.com/en-us/dotnet/api/system.action{baseplayer,system.string,system.string[]}?view=net-7.0) callback 
### AddConsoleCommand(string, Plugin, string)  
Adds a console command  
```csharp
[LibraryFunction("AddConsoleCommand")]
public void AddConsoleCommand(string command, Plugin plugin, string callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L179)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) callback 
### AddConsoleCommand(string, Plugin, Func<Arg, bool>)  
Adds a console command with a delegate callback  
```csharp
public void AddConsoleCommand(string command, Plugin plugin, Func<ConsoleSystem.Arg, bool> callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L191)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin   
[System.Func{ConsoleSystem.Arg,System.Boolean}](https://learn.microsoft.com/en-us/dotnet/api/system.func{consolesystem.arg,system.boolean}?view=net-7.0) callback 
### RemoveChatCommand(string, Plugin)  
Removes a previously registered chat command  
```csharp
[LibraryFunction("RemoveChatCommand")]
public void RemoveChatCommand(string command, Plugin plugin)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L284)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin 
### RemoveConsoleCommand(string, Plugin)  
Removes a previously registered console command  
```csharp
[LibraryFunction("RemoveConsoleCommand")]
public void RemoveConsoleCommand(string command, Plugin plugin)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Command.cs#L299)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
Plugin plugin 