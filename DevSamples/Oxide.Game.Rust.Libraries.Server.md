# Class Server
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Server : Library
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, IsGlobal, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Methods 
### Broadcast(string, string, ulong, params object[])  
Broadcasts the specified chat message and prefix to all players  
```csharp
public void Broadcast(string message, string prefix, ulong userId = 0, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Server.cs#L16)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) prefix   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 
### Broadcast(string, ulong)  
Broadcasts the specified chat message to all players  
```csharp
public void Broadcast(string message, ulong userId = 0)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Server.cs#L31)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) message   
[System.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64?view=net-7.0) userId 
### Command(string, params object[])  
Runs the specified server command  
```csharp
public void Command(string command, params object[] args)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/Libraries/Server.cs#L38)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) command   
[System.Object[]](https://learn.microsoft.com/en-us/dotnet/api/system.object[]?view=net-7.0) args 