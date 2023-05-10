# Class CuiCountdownComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiCountdownComponent : ICuiComponent
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### Type  
  
```csharp
public string Type { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L401)
### EndTime  
  
```csharp
[JsonProperty("endTime")]
public int EndTime { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L403)
### StartTime  
  
```csharp
[JsonProperty("startTime")]
public int StartTime { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L406)
### Step  
  
```csharp
[JsonProperty("step")]
public int Step { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L409)
### Command  
  
```csharp
[JsonProperty("command")]
public string Command { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L412)
### FadeIn  
  
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L415)