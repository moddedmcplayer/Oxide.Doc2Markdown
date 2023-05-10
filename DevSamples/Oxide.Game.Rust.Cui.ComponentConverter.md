# Class ComponentConverter
Namespace: [Oxide.Game.Rust.Cui](Oxide.Game.Rust.Cui.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class ComponentConverter : JsonConverter
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Newtonsoft.Json.JsonConverter  
#### Inherited Members
CanRead, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
### CanWrite  
  
```csharp
public override bool CanWrite { get; }
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L516)
## Methods 
### WriteJson(JsonWriter, object, JsonSerializer)  
  
```csharp
public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L452)  
Overrides Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)  
#### Parameters  
JsonWriter writer   
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0) value   
JsonSerializer serializer 
### ReadJson(JsonReader, Type, object, JsonSerializer)  
  
```csharp
public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L457)  
Overrides Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)  
#### Parameters  
JsonReader reader   
[System.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type?view=net-7.0) objectType   
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0) existingValue   
JsonSerializer serializer 
### CanConvert(Type)  
  
```csharp
public override bool CanConvert(Type objectType)
```  
[Source](https://github.com/OxideMod/Oxide.Rust/tree/develop/src/RustCui.cs#L514)  
Overrides Newtonsoft.Json.JsonConverter.CanConvert(System.Type)  
#### Parameters  
[System.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type?view=net-7.0) objectType 