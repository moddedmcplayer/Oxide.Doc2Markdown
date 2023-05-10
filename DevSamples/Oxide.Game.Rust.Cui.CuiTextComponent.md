# Class CuiTextComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiTextComponent : ICuiComponent, ICuiColor
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
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L225)
### Text  
  
```csharp
[JsonProperty("text")]
public string Text { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L228)
### FontSize  
  
```csharp
[JsonProperty("fontSize")]
public int FontSize { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L232)
### Font  
  
```csharp
[JsonProperty("font")]
public string Font { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L236)
### Align  
  
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("align")]
public TextAnchor Align { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L240)
### Color  
  
```csharp
public string Color { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L244)
### VerticalOverflow  
  
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("verticalOverflow")]
public VerticalWrapMode VerticalOverflow { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L246)
### FadeIn  
  
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L250)