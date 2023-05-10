# Class RustPlugin
Namespace: [Oxide.Plugins](Oxide.Plugins.md)  
Assembly: Oxide.Rust.dll  
```csharp
public abstract class RustPlugin : CSharpPlugin
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Plugins.Plugin, Oxide.Core.Plugins.CSPlugin, Oxide.Plugins.CSharpPlugin  
#### Inherited Members
Watcher, covalence, lang, plugins, permission, webrequest, timer, onlinePlayerFields, SetPluginInfo, HandleRemovedFromManager, DirectCallHook, InvokeMethod, SetFailState, Puts, PrintWarning, PrintError, LogToFile, NextFrame, NextTick, QueueWorkerThread, HookedOnFrame, Hooks, HooksCache, GetLibrary``1, AddHookMethod, OnCallHook, FindHooks, OnAddedToManager, OnRemovedFromManager, nestcount, Subscribe, Unsubscribe, Load, CallHook, Call, Call``1, RaiseError, TrackStart, TrackEnd, LoadConfig, LoadDefaultConfig, SaveConfig, LoadDefaultMessages, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, Filename, Name, Title, Description, Author, Version, ResourceId, Manager, HasConfig, HasMessages, IsCorePlugin, Loader, Object, Config, IsLoaded, TotalHookTime, OnError, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Methods 
### HandleAddedToManager(PluginManager)  
  
```csharp
public override void HandleAddedToManager(PluginManager manager)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L17)  
Overrides Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)  
#### Parameters  
PluginManager manager 
### PrintToConsole(BasePlayer, string, params object[])  
Print a message to the players console log  
```csharp
protected void PrintToConsole(BasePlayer player, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L121)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### PrintToConsole(string, params object[])  
Print a message to every players console log  
```csharp
protected void PrintToConsole(string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L134)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### PrintToChat(BasePlayer, string, params object[])  
Print a message to the players chat log  
```csharp
protected void PrintToChat(BasePlayer player, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L148)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### PrintToChat(string, params object[])  
Print a message to every players chat log  
```csharp
protected void PrintToChat(string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L161)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### SendReply(Arg, string, params object[])  
Send a reply message in response to a console command  
```csharp
protected void SendReply(ConsoleSystem.Arg arg, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L175)  
  
#### Parameters  
Arg arg   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### SendReply(BasePlayer, string, params object[])  
Send a reply message in response to a chat command  
```csharp
protected void SendReply(BasePlayer player, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L195)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### SendWarning(Arg, string, params object[])  
Send a warning message in response to a console command  
```csharp
protected void SendWarning(ConsoleSystem.Arg arg, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L203)  
  
#### Parameters  
Arg arg   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### SendError(Arg, string, params object[])  
Send an error message in response to a console command  
```csharp
protected void SendError(ConsoleSystem.Arg arg, string format, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L223)  
  
#### Parameters  
Arg arg   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) format   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### ForcePlayerPosition(BasePlayer, Vector3)  
Forces the player to a specific position  
```csharp
protected void ForcePlayerPosition(BasePlayer player, Vector3 destination)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L242)  
  
#### Parameters  
BasePlayer player   
Vector3 destination 
## Fields 
### cmd  
  
```csharp
protected Command cmd
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L11)
### rust  
  
```csharp
protected Rust rust
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L12)
### Item  
  
```csharp
protected Item Item
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L13)
### Player  
  
```csharp
protected Player Player
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L14)
### Server  
  
```csharp
protected Server Server
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustPlugin.cs#L15)