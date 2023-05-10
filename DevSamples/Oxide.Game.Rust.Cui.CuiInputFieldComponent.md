# Class CuiInputFieldComponent
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class CuiInputFieldComponent : ICuiComponent, ICuiColor
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
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L352)
### Text  
  
```csharp
[JsonProperty("text")]
public string Text { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L355)
### FontSize  
  
```csharp
[JsonProperty("fontSize")]
public int FontSize { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L359)
### Font  
  
```csharp
[JsonProperty("font")]
public string Font { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L363)
### Align  
  
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("align")]
public TextAnchor Align { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L367)
### Color  
  
```csharp
public string Color { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L371)
### CharsLimit  
  
```csharp
[JsonProperty("characterLimit")]
public int CharsLimit { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L373)
### Command  
  
```csharp
[JsonProperty("command")]
public string Command { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L376)
### IsPassword  
  
```csharp
[JsonProperty("password")]
public bool IsPassword { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L379)
### ReadOnly  
  
```csharp
[JsonProperty("readOnly")]
public bool ReadOnly { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L382)
### NeedsKeyboard  
  
```csharp
[JsonProperty("needsKeyboard")]
public bool NeedsKeyboard { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L385)
### LineType  
  
```csharp
[JsonConverter(typeof(StringEnumConverter))]
[JsonProperty("lineType")]
public InputField.LineType LineType { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L388)
### Autofocus  
  
```csharp
[JsonProperty("autofocus")]
public bool Autofocus { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L392)
### HudMenuInput  
  
```csharp
[JsonProperty("hudMenuInput")]
public bool HudMenuInput { get; set; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L395)