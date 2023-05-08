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
```csharp
public override bool CanWrite { get; }
```
CanWrite
## Methods 
```csharp
public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
```
WriteJson(JsonWriter, object, JsonSerializer)
```csharp
public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
```
ReadJson(JsonReader, Type, object, JsonSerializer)
```csharp
public override bool CanConvert(Type objectType)
```
CanConvert(Type)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter",
      "commentId": "T:Oxide.Game.Rust.Cui.ComponentConverter",
      "id": "ComponentConverter",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui",
      "children": [
        "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert(System.Type)",
        "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
        "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
        "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ComponentConverter",
      "nameWithType": "ComponentConverter",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ComponentConverter",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 455,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "syntax": {
        "content": "public class ComponentConverter : JsonConverter",
        "content.vb": "Public Class ComponentConverter Inherits JsonConverter"
      },
      "inheritance": [
        "System.Object",
        "Newtonsoft.Json.JsonConverter"
      ],
      "inheritedMembers": [
        "Newtonsoft.Json.JsonConverter.CanRead",
        "System.Object.ToString",
        "System.Object.Equals(System.Object)",
        "System.Object.Equals(System.Object,System.Object)",
        "System.Object.ReferenceEquals(System.Object,System.Object)",
        "System.Object.GetHashCode",
        "System.Object.GetType",
        "System.Object.MemberwiseClone"
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "commentId": "M:Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "id": "WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.ComponentConverter",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "WriteJson(JsonWriter, object, JsonSerializer)",
      "nameWithType": "ComponentConverter.WriteJson(JsonWriter, object, JsonSerializer)",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter, object, Newtonsoft.Json.JsonSerializer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "WriteJson",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 457,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)",
        "parameters": [
          {
            "id": "writer",
            "type": "Newtonsoft.Json.JsonWriter"
          },
          {
            "id": "value",
            "type": "System.Object"
          },
          {
            "id": "serializer",
            "type": "Newtonsoft.Json.JsonSerializer"
          }
        ],
        "content.vb": "Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)"
      },
      "overridden": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "overload": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson*",
      "nameWithType.vb": "ComponentConverter.WriteJson(JsonWriter, Object, JsonSerializer)",
      "fullName.vb": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter, Object, Newtonsoft.Json.JsonSerializer)",
      "name.vb": "WriteJson(JsonWriter, Object, JsonSerializer)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "commentId": "M:Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "id": "ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.ComponentConverter",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ReadJson(JsonReader, Type, object, JsonSerializer)",
      "nameWithType": "ComponentConverter.ReadJson(JsonReader, Type, object, JsonSerializer)",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader, System.Type, object, Newtonsoft.Json.JsonSerializer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ReadJson",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 462,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)",
        "parameters": [
          {
            "id": "reader",
            "type": "Newtonsoft.Json.JsonReader"
          },
          {
            "id": "objectType",
            "type": "System.Type"
          },
          {
            "id": "existingValue",
            "type": "System.Object"
          },
          {
            "id": "serializer",
            "type": "Newtonsoft.Json.JsonSerializer"
          }
        ],
        "return": {
          "type": "System.Object"
        },
        "content.vb": "Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object"
      },
      "overridden": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "overload": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson*",
      "nameWithType.vb": "ComponentConverter.ReadJson(JsonReader, Type, Object, JsonSerializer)",
      "fullName.vb": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader, System.Type, Object, Newtonsoft.Json.JsonSerializer)",
      "name.vb": "ReadJson(JsonReader, Type, Object, JsonSerializer)"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert(System.Type)",
      "commentId": "M:Oxide.Game.Rust.Cui.ComponentConverter.CanConvert(System.Type)",
      "id": "CanConvert(System.Type)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.ComponentConverter",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CanConvert(Type)",
      "nameWithType": "ComponentConverter.CanConvert(Type)",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert(System.Type)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CanConvert",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 519,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public override bool CanConvert(Type objectType)",
        "parameters": [
          {
            "id": "objectType",
            "type": "System.Type"
          }
        ],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Overrides Function CanConvert(objectType As Type) As Boolean"
      },
      "overridden": "Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
      "overload": "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert*"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
      "commentId": "P:Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
      "id": "CanWrite",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Cui.ComponentConverter",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CanWrite",
      "nameWithType": "ComponentConverter.CanWrite",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustCui.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CanWrite",
        "path": "../../../../../../../Oxide.Rust/src/RustCui.cs",
        "startLine": 521,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Cui",
      "example": [],
      "syntax": {
        "content": "public override bool CanWrite { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Overrides ReadOnly Property CanWrite As Boolean"
      },
      "overridden": "Newtonsoft.Json.JsonConverter.CanWrite",
      "overload": "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite*"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Cui",
      "commentId": "N:Oxide.Game.Rust.Cui",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Cui",
      "nameWithType": "Oxide.Game.Rust.Cui",
      "fullName": "Oxide.Game.Rust.Cui",
      "spec.csharp": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": false,
          "href": "Oxide.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game",
          "name": "Game",
          "isExternal": false,
          "href": "Oxide.Game.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust",
          "name": "Rust",
          "isExternal": false,
          "href": "Oxide.Game.Rust.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui",
          "name": "Cui",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.html"
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": false,
          "href": "Oxide.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game",
          "name": "Game",
          "isExternal": false,
          "href": "Oxide.Game.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust",
          "name": "Rust",
          "isExternal": false,
          "href": "Oxide.Game.Rust.html"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Cui",
          "name": "Cui",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Cui.html"
        }
      ]
    },
    {
      "uid": "System.Object",
      "commentId": "T:System.Object",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "object",
      "nameWithType": "object",
      "fullName": "object",
      "nameWithType.vb": "Object",
      "fullName.vb": "Object",
      "name.vb": "Object"
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter",
      "commentId": "T:Newtonsoft.Json.JsonConverter",
      "parent": "Newtonsoft.Json",
      "isExternal": true,
      "name": "JsonConverter",
      "nameWithType": "JsonConverter",
      "fullName": "Newtonsoft.Json.JsonConverter"
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter.CanRead",
      "commentId": "P:Newtonsoft.Json.JsonConverter.CanRead",
      "parent": "Newtonsoft.Json.JsonConverter",
      "isExternal": true,
      "name": "CanRead",
      "nameWithType": "JsonConverter.CanRead",
      "fullName": "Newtonsoft.Json.JsonConverter.CanRead"
    },
    {
      "uid": "System.Object.ToString",
      "commentId": "M:System.Object.ToString",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring",
      "name": "ToString()",
      "nameWithType": "object.ToString()",
      "fullName": "object.ToString()",
      "nameWithType.vb": "Object.ToString()",
      "fullName.vb": "Object.ToString()",
      "spec.csharp": [
        {
          "uid": "System.Object.ToString",
          "name": "ToString",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.ToString",
          "name": "ToString",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.tostring"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.Equals(System.Object)",
      "commentId": "M:System.Object.Equals(System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)",
      "name": "Equals(object)",
      "nameWithType": "object.Equals(object)",
      "fullName": "object.Equals(object)",
      "nameWithType.vb": "Object.Equals(Object)",
      "fullName.vb": "Object.Equals(Object)",
      "name.vb": "Equals(Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.Equals(System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.Equals(System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.Equals(System.Object,System.Object)",
      "commentId": "M:System.Object.Equals(System.Object,System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)",
      "name": "Equals(object, object)",
      "nameWithType": "object.Equals(object, object)",
      "fullName": "object.Equals(object, object)",
      "nameWithType.vb": "Object.Equals(Object, Object)",
      "fullName.vb": "Object.Equals(Object, Object)",
      "name.vb": "Equals(Object, Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.Equals(System.Object,System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.Equals(System.Object,System.Object)",
          "name": "Equals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
      "commentId": "M:System.Object.ReferenceEquals(System.Object,System.Object)",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals",
      "name": "ReferenceEquals(object, object)",
      "nameWithType": "object.ReferenceEquals(object, object)",
      "fullName": "object.ReferenceEquals(object, object)",
      "nameWithType.vb": "Object.ReferenceEquals(Object, Object)",
      "fullName.vb": "Object.ReferenceEquals(Object, Object)",
      "name.vb": "ReferenceEquals(Object, Object)",
      "spec.csharp": [
        {
          "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
          "name": "ReferenceEquals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.ReferenceEquals(System.Object,System.Object)",
          "name": "ReferenceEquals",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.referenceequals"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.GetHashCode",
      "commentId": "M:System.Object.GetHashCode",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode",
      "name": "GetHashCode()",
      "nameWithType": "object.GetHashCode()",
      "fullName": "object.GetHashCode()",
      "nameWithType.vb": "Object.GetHashCode()",
      "fullName.vb": "Object.GetHashCode()",
      "spec.csharp": [
        {
          "uid": "System.Object.GetHashCode",
          "name": "GetHashCode",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.GetHashCode",
          "name": "GetHashCode",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gethashcode"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.GetType",
      "commentId": "M:System.Object.GetType",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype",
      "name": "GetType()",
      "nameWithType": "object.GetType()",
      "fullName": "object.GetType()",
      "nameWithType.vb": "Object.GetType()",
      "fullName.vb": "Object.GetType()",
      "spec.csharp": [
        {
          "uid": "System.Object.GetType",
          "name": "GetType",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.GetType",
          "name": "GetType",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.gettype"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Object.MemberwiseClone",
      "commentId": "M:System.Object.MemberwiseClone",
      "parent": "System.Object",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone",
      "name": "MemberwiseClone()",
      "nameWithType": "object.MemberwiseClone()",
      "fullName": "object.MemberwiseClone()",
      "nameWithType.vb": "Object.MemberwiseClone()",
      "fullName.vb": "Object.MemberwiseClone()",
      "spec.csharp": [
        {
          "uid": "System.Object.MemberwiseClone",
          "name": "MemberwiseClone",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object.MemberwiseClone",
          "name": "MemberwiseClone",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System",
      "commentId": "N:System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System",
      "nameWithType": "System",
      "fullName": "System"
    },
    {
      "uid": "Newtonsoft.Json",
      "commentId": "N:Newtonsoft.Json",
      "isExternal": true,
      "name": "Newtonsoft.Json",
      "nameWithType": "Newtonsoft.Json",
      "fullName": "Newtonsoft.Json",
      "spec.csharp": [
        {
          "uid": "Newtonsoft",
          "name": "Newtonsoft",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json",
          "name": "Json",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "Newtonsoft",
          "name": "Newtonsoft",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json",
          "name": "Json",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "commentId": "M:Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "parent": "Newtonsoft.Json.JsonConverter",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "WriteJson(JsonWriter, object, JsonSerializer)",
      "nameWithType": "JsonConverter.WriteJson(JsonWriter, object, JsonSerializer)",
      "fullName": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter, object, Newtonsoft.Json.JsonSerializer)",
      "nameWithType.vb": "JsonConverter.WriteJson(JsonWriter, Object, JsonSerializer)",
      "fullName.vb": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter, Object, Newtonsoft.Json.JsonSerializer)",
      "name.vb": "WriteJson(JsonWriter, Object, JsonSerializer)",
      "spec.csharp": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
          "name": "WriteJson",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonWriter",
          "name": "JsonWriter",
          "isExternal": true
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonSerializer",
          "name": "JsonSerializer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
          "name": "WriteJson",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonWriter",
          "name": "JsonWriter",
          "isExternal": true
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonSerializer",
          "name": "JsonSerializer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.ComponentConverter.WriteJson",
      "href": "Oxide.Game.Rust.Cui.ComponentConverter.html#Oxide.Game.Rust.Cui.ComponentConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)",
      "name": "WriteJson",
      "nameWithType": "ComponentConverter.WriteJson",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.WriteJson"
    },
    {
      "uid": "Newtonsoft.Json.JsonWriter",
      "commentId": "T:Newtonsoft.Json.JsonWriter",
      "parent": "Newtonsoft.Json",
      "isExternal": true,
      "name": "JsonWriter",
      "nameWithType": "JsonWriter",
      "fullName": "Newtonsoft.Json.JsonWriter"
    },
    {
      "uid": "Newtonsoft.Json.JsonSerializer",
      "commentId": "T:Newtonsoft.Json.JsonSerializer",
      "parent": "Newtonsoft.Json",
      "isExternal": true,
      "name": "JsonSerializer",
      "nameWithType": "JsonSerializer",
      "fullName": "Newtonsoft.Json.JsonSerializer"
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "commentId": "M:Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "parent": "Newtonsoft.Json.JsonConverter",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.type",
      "name": "ReadJson(JsonReader, Type, object, JsonSerializer)",
      "nameWithType": "JsonConverter.ReadJson(JsonReader, Type, object, JsonSerializer)",
      "fullName": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader, System.Type, object, Newtonsoft.Json.JsonSerializer)",
      "nameWithType.vb": "JsonConverter.ReadJson(JsonReader, Type, Object, JsonSerializer)",
      "fullName.vb": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader, System.Type, Object, Newtonsoft.Json.JsonSerializer)",
      "name.vb": "ReadJson(JsonReader, Type, Object, JsonSerializer)",
      "spec.csharp": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
          "name": "ReadJson",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonReader",
          "name": "JsonReader",
          "isExternal": true
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonSerializer",
          "name": "JsonSerializer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
          "name": "ReadJson",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonReader",
          "name": "JsonReader",
          "isExternal": true
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Newtonsoft.Json.JsonSerializer",
          "name": "JsonSerializer",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.ComponentConverter.ReadJson",
      "href": "Oxide.Game.Rust.Cui.ComponentConverter.html#Oxide.Game.Rust.Cui.ComponentConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)",
      "name": "ReadJson",
      "nameWithType": "ComponentConverter.ReadJson",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.ReadJson"
    },
    {
      "uid": "Newtonsoft.Json.JsonReader",
      "commentId": "T:Newtonsoft.Json.JsonReader",
      "parent": "Newtonsoft.Json",
      "isExternal": true,
      "name": "JsonReader",
      "nameWithType": "JsonReader",
      "fullName": "Newtonsoft.Json.JsonReader"
    },
    {
      "uid": "System.Type",
      "commentId": "T:System.Type",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.type",
      "name": "Type",
      "nameWithType": "Type",
      "fullName": "System.Type"
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
      "commentId": "M:Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
      "parent": "Newtonsoft.Json.JsonConverter",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.type",
      "name": "CanConvert(Type)",
      "nameWithType": "JsonConverter.CanConvert(Type)",
      "fullName": "Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
      "spec.csharp": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
          "name": "CanConvert",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Newtonsoft.Json.JsonConverter.CanConvert(System.Type)",
          "name": "CanConvert",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.ComponentConverter.CanConvert",
      "href": "Oxide.Game.Rust.Cui.ComponentConverter.html#Oxide.Game.Rust.Cui.ComponentConverter.CanConvert(System.Type)",
      "name": "CanConvert",
      "nameWithType": "ComponentConverter.CanConvert",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.CanConvert"
    },
    {
      "uid": "System.Boolean",
      "commentId": "T:System.Boolean",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.boolean",
      "name": "bool",
      "nameWithType": "bool",
      "fullName": "bool",
      "nameWithType.vb": "Boolean",
      "fullName.vb": "Boolean",
      "name.vb": "Boolean"
    },
    {
      "uid": "Newtonsoft.Json.JsonConverter.CanWrite",
      "commentId": "P:Newtonsoft.Json.JsonConverter.CanWrite",
      "parent": "Newtonsoft.Json.JsonConverter",
      "isExternal": true,
      "name": "CanWrite",
      "nameWithType": "JsonConverter.CanWrite",
      "fullName": "Newtonsoft.Json.JsonConverter.CanWrite"
    },
    {
      "uid": "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite*",
      "commentId": "Overload:Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
      "href": "Oxide.Game.Rust.Cui.ComponentConverter.html#Oxide.Game.Rust.Cui.ComponentConverter.CanWrite",
      "name": "CanWrite",
      "nameWithType": "ComponentConverter.CanWrite",
      "fullName": "Oxide.Game.Rust.Cui.ComponentConverter.CanWrite"
    }
  ],
  "shouldSkipMarkup": false,
  "memberLayout": "samePage",
  "_systemKeys": [
    "uid",
    "isEii",
    "isExtensionMethod",
    "parent",
    "children",
    "href",
    "langs",
    "name",
    "nameWithType",
    "fullName",
    "type",
    "source",
    "documentation",
    "assemblies",
    "namespace",
    "summary",
    "remarks",
    "example",
    "syntax",
    "overridden",
    "overload",
    "exceptions",
    "seealso",
    "see",
    "inheritance",
    "derivedClasses",
    "level",
    "implements",
    "inheritedMembers",
    "extensionMethods",
    "conceptual",
    "platform",
    "attributes",
    "additionalNotes"
  ]
}