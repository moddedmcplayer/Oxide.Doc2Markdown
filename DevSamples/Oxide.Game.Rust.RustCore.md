# Class RustCore
Namespace: [Oxide.Game.Rust](Oxide.Game.Rust.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCore : CSPlugin
```  
#### Game commands for the core Rust plugin


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Plugins.Plugin, Oxide.Core.Plugins.CSPlugin  
#### Inherited Members
Hooks, HooksCache, GetLibrary``1, HandleAddedToManager, AddHookMethod, OnCallHook, FindHooks, InvokeMethod, OnAddedToManager, OnRemovedFromManager, nestcount, Subscribe, Unsubscribe, HandleRemovedFromManager, Load, CallHook, Call, Call``1, RaiseError, TrackStart, TrackEnd, LoadConfig, LoadDefaultConfig, SaveConfig, LoadDefaultMessages, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, Filename, Name, Title, Description, Author, Version, ResourceId, Manager, HasConfig, HasMessages, IsCorePlugin, Loader, Object, Config, IsLoaded, TotalHookTime, OnError, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
### RustCore()  
Initializes a new instance of the RustCore class  
```csharp
public RustCore()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCore.cs#L25)
## Methods 
### FindPlayer(string)  
Returns the BasePlayer for the specified name, ID, or IP address string  
```csharp
public static BasePlayer FindPlayer(string nameOrIdOrIp)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCore.cs#L272)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) nameOrIdOrIp 
### FindPlayerByName(string)  
Returns the BasePlayer for the specified name string  
```csharp
public static BasePlayer FindPlayerByName(string name)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCore.cs#L347)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) name 
### FindPlayerById(ulong)  
Returns the BasePlayer for the specified ID ulong  
```csharp
public static BasePlayer FindPlayerById(ulong id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCore.cs#L392)  
  
#### Parameters  
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) id 
### FindPlayerByIdString(string)  
Returns the BasePlayer for the specified ID string  
```csharp
public static BasePlayer FindPlayerByIdString(string id)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCore.cs#L416)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) id 