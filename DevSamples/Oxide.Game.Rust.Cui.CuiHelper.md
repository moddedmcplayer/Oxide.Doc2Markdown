# Class CuiHelper
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public static class CuiHelper
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Methods 
### ToJson(List<CuiElement>, bool)  
  
```csharp
public static string ToJson(List<CuiElement> elements, bool format = false)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L17)  
  
#### Parameters  
[System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list{oxide.game.rust.cui.cuielement}?view=net-7.0) elements   
[System.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-7.0) format 
### FromJson(string)  
  
```csharp
public static List<CuiElement> FromJson(string json)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L25)  
  
#### Parameters  
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) json 
### GetGuid()  
  
```csharp
public static string GetGuid()
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L27)  
  
#### Parameters  
None
### AddUi(BasePlayer, List<CuiElement>)  
  
```csharp
public static bool AddUi(BasePlayer player, List<CuiElement> elements)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L29)  
  
#### Parameters  
BasePlayer player   
[System.Collections.Generic.List{Oxide.Game.Rust.Cui.CuiElement}](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list{oxide.game.rust.cui.cuielement}?view=net-7.0) elements 
### AddUi(BasePlayer, string)  
  
```csharp
public static bool AddUi(BasePlayer player, string json)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L31)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) json 
### DestroyUi(BasePlayer, string)  
  
```csharp
public static bool DestroyUi(BasePlayer player, string elem)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L42)  
  
#### Parameters  
BasePlayer player   
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0) elem 
### SetColor(ICuiColor, Color)  
  
```csharp
public static void SetColor(this ICuiColor elem, Color color)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L54)  
  
#### Parameters  
ICuiColor elem   
Color color 
### GetColor(ICuiColor)  
  
```csharp
public static Color GetColor(this ICuiColor elem)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L59)  
  
#### Parameters  
ICuiColor elem 