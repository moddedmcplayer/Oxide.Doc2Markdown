# Class CuiOutlineComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiOutlineComponent : ICuiComponent, ICuiColor
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
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L336)
### Color  
  
```csharp
public string Color { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L339)
### Distance  
  
```csharp
[JsonProperty("distance")]
public string Distance { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L342)
### UseGraphicAlpha  
  
```csharp
[JsonProperty("useGraphicAlpha")]
public bool UseGraphicAlpha { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L346)