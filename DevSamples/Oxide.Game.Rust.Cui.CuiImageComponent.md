# Class CuiImageComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiImageComponent : ICuiComponent, ICuiColor
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
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L256)
### Sprite  
  
```csharp
[JsonProperty("sprite")]
public string Sprite { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L258)
### Material  
  
```csharp
[JsonProperty("material")]
public string Material { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L261)
### Color  
  
```csharp
public string Color { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L264)
### ImageType  
  
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("imagetype")]
public Image.Type ImageType { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L266)
### Png  
  
```csharp
[JsonProperty("png")]
public string Png { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L270)
### FadeIn  
  
```csharp
[JsonProperty("fadeIn")]
public float FadeIn { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L273)
### ItemId  
  
```csharp
[JsonProperty("itemid")]
public int ItemId { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L276)
### SkinId  
  
```csharp
[JsonProperty("skinid")]
public ulong SkinId { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L279)