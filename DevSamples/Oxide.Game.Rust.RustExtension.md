# Class RustExtension
Namespace: [Oxide.Game.Rust](Oxide.Game.Rust.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustExtension : Extension
```  
#### The extension class that represents this extension


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Extensions.Extension  
#### Inherited Members
Unload, OnShutdown, Filename, IsCoreExtension, SupportsReloading, Manager, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### IsGameExtension  
Gets whether this extension is for a specific game  
```csharp
public override bool IsGameExtension { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L32)
### Name  
Gets the name of this extension  
```csharp
public override string Name { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L37)
### Author  
Gets the author of this extension  
```csharp
public override string Author { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L42)
### Version  
Gets the version of this extension  
```csharp
public override VersionNumber Version { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L47)
### Branch  
Gets the branch of this extension  
```csharp
public override string Branch { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L52)
### DefaultReferences  
Default game-specific references for use in plugins  
```csharp
public override string[] DefaultReferences { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L57)
### WhitelistAssemblies  
List of assemblies allowed for use in plugins  
```csharp
public override string[] WhitelistAssemblies { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L70)
### WhitelistNamespaces  
List of namespaces allowed for use in plugins  
```csharp
public override string[] WhitelistNamespaces { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L79)
## Constructors 
### RustExtension(ExtensionManager)  
Initializes a new instance of the RustExtension class  
```csharp
public RustExtension(ExtensionManager manager)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L114)
## Methods 
### Load()  
Loads this extension  
```csharp
public override void Load()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L121)  
Overrides Oxide.Core.Extensions.Extension.Load  
#### Parameters  
None
### LoadPluginWatchers(string)  
Loads plugin watchers used by this extension  
```csharp
public override void LoadPluginWatchers(string directory)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L142)  
Overrides Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) directory 
### OnModLoad()  
Called when all other extensions have been loaded  
```csharp
public override void OnModLoad()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L149)  
Overrides Oxide.Core.Extensions.Extension.OnModLoad  
#### Parameters  
None
### GetLatestVersion(Action<VersionNumber, Exception>)  
Gets latest official Oxide.Rust build version  
```csharp
public void GetLatestVersion(Action<VersionNumber, Exception> callback)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L161)  
  
#### Parameters  
[System.Action{Oxide.Core.VersionNumber,System.Exception}](https://learn.microsoft.com/en-us/dotnet/api/system.action{oxide.core.versionnumber,system.exception}?view=net-7.0) callback Callback to execute.<br />
    First argument is the version (latest, if request was successful, current otherwise)<br />
    Second argument is the exception indicating fail reason. Null if request was successful.
## Fields 
### Filter  
List of filter matches to apply to console output  
```csharp
public static string[] Filter
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustExtension.cs#L88)