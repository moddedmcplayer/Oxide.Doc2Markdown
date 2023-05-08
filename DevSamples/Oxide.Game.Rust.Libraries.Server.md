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
```csharp
public void Broadcast(string message, string prefix, ulong userId = 0, params object[] args)
```
Broadcast(string, string, ulong, params object[])
```csharp
public void Broadcast(string message, ulong userId = 0)
```
Broadcast(string, ulong)
```csharp
public void Command(string command, params object[] args)
```
Command(string, params object[])






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Server",
      "commentId": "T:Oxide.Game.Rust.Libraries.Server",
      "id": "Server",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries",
      "children": [
        "Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.String,System.UInt64,System.Object[])",
        "Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.UInt64)",
        "Oxide.Game.Rust.Libraries.Server.Command(System.String,System.Object[])"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Server",
      "nameWithType": "Server",
      "fullName": "Oxide.Game.Rust.Libraries.Server",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Server.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Server",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Server.cs",
        "startLine": 5,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "syntax": {
        "content": "public class Server : Library",
        "content.vb": "Public Class Server Inherits Library"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Libraries.Library"
      ],
      "inheritedMembers": [
        "Oxide.Core.Libraries.Library.Shutdown",
        "Oxide.Core.Libraries.Library.GetFunctionNames",
        "Oxide.Core.Libraries.Library.GetPropertyNames",
        "Oxide.Core.Libraries.Library.GetFunction(System.String)",
        "Oxide.Core.Libraries.Library.GetProperty(System.String)",
        "Oxide.Core.Libraries.Library.IsGlobal",
        "Oxide.Core.Libraries.Library.LastException",
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
      "uid": "Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.String,System.UInt64,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.String,System.UInt64,System.Object[])",
      "id": "Broadcast(System.String,System.String,System.UInt64,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Server",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Broadcast(string, string, ulong, params object[])",
      "nameWithType": "Server.Broadcast(string, string, ulong, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Server.Broadcast(string, string, ulong, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Server.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Broadcast",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Server.cs",
        "startLine": 16,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Broadcasts the specified chat message and prefix to all players",
      "example": [],
      "syntax": {
        "content": "public void Broadcast(string message, string prefix, ulong userId = 0, params object[] args)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "prefix",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.UInt64",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Broadcast(message As String, prefix As String, userId As ULong = 0, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Server.Broadcast*",
      "nameWithType.vb": "Server.Broadcast(String, String, ULong, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Server.Broadcast(String, String, ULong, ParamArray Object())",
      "name.vb": "Broadcast(String, String, ULong, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.UInt64)",
      "id": "Broadcast(System.String,System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Server",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Broadcast(string, ulong)",
      "nameWithType": "Server.Broadcast(string, ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Server.Broadcast(string, ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Server.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Broadcast",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Server.cs",
        "startLine": 31,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Broadcasts the specified chat message to all players",
      "example": [],
      "syntax": {
        "content": "public void Broadcast(string message, ulong userId = 0)",
        "parameters": [
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.UInt64",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Broadcast(message As String, userId As ULong = 0)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Server.Broadcast*",
      "nameWithType.vb": "Server.Broadcast(String, ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Server.Broadcast(String, ULong)",
      "name.vb": "Broadcast(String, ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Server.Command(System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Server.Command(System.String,System.Object[])",
      "id": "Command(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Server",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command(string, params object[])",
      "nameWithType": "Server.Command(string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Server.Command(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Server.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Server.cs",
        "startLine": 38,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Runs the specified server command",
      "example": [],
      "syntax": {
        "content": "public void Command(string command, params object[] args)",
        "parameters": [
          {
            "id": "command",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Public Sub Command(command As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Server.Command*",
      "nameWithType.vb": "Server.Command(String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Server.Command(String, ParamArray Object())",
      "name.vb": "Command(String, ParamArray Object())"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Libraries",
      "commentId": "N:Oxide.Game.Rust.Libraries",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Libraries",
      "nameWithType": "Oxide.Game.Rust.Libraries",
      "fullName": "Oxide.Game.Rust.Libraries",
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
          "uid": "Oxide.Game.Rust.Libraries",
          "name": "Libraries",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.html"
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
          "uid": "Oxide.Game.Rust.Libraries",
          "name": "Libraries",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.html"
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
      "uid": "Oxide.Core.Libraries.Library",
      "commentId": "T:Oxide.Core.Libraries.Library",
      "parent": "Oxide.Core.Libraries",
      "isExternal": true,
      "name": "Library",
      "nameWithType": "Library",
      "fullName": "Oxide.Core.Libraries.Library"
    },
    {
      "uid": "Oxide.Core.Libraries.Library.Shutdown",
      "commentId": "M:Oxide.Core.Libraries.Library.Shutdown",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "Shutdown()",
      "nameWithType": "Library.Shutdown()",
      "fullName": "Oxide.Core.Libraries.Library.Shutdown()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.Shutdown",
          "name": "Shutdown",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Library.Shutdown",
          "name": "Shutdown",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
      "commentId": "M:Oxide.Core.Libraries.Library.GetFunctionNames",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "GetFunctionNames()",
      "nameWithType": "Library.GetFunctionNames()",
      "fullName": "Oxide.Core.Libraries.Library.GetFunctionNames()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
          "name": "GetFunctionNames",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Library.GetFunctionNames",
          "name": "GetFunctionNames",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
      "commentId": "M:Oxide.Core.Libraries.Library.GetPropertyNames",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "GetPropertyNames()",
      "nameWithType": "Library.GetPropertyNames()",
      "fullName": "Oxide.Core.Libraries.Library.GetPropertyNames()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
          "name": "GetPropertyNames",
          "isExternal": true
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
          "uid": "Oxide.Core.Libraries.Library.GetPropertyNames",
          "name": "GetPropertyNames",
          "isExternal": true
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
      "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Library.GetFunction(System.String)",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetFunction(string)",
      "nameWithType": "Library.GetFunction(string)",
      "fullName": "Oxide.Core.Libraries.Library.GetFunction(string)",
      "nameWithType.vb": "Library.GetFunction(String)",
      "fullName.vb": "Oxide.Core.Libraries.Library.GetFunction(String)",
      "name.vb": "GetFunction(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
          "name": "GetFunction",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetFunction(System.String)",
          "name": "GetFunction",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
      "commentId": "M:Oxide.Core.Libraries.Library.GetProperty(System.String)",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetProperty(string)",
      "nameWithType": "Library.GetProperty(string)",
      "fullName": "Oxide.Core.Libraries.Library.GetProperty(string)",
      "nameWithType.vb": "Library.GetProperty(String)",
      "fullName.vb": "Oxide.Core.Libraries.Library.GetProperty(String)",
      "name.vb": "GetProperty(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
          "name": "GetProperty",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Library.GetProperty(System.String)",
          "name": "GetProperty",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Libraries.Library.IsGlobal",
      "commentId": "P:Oxide.Core.Libraries.Library.IsGlobal",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "IsGlobal",
      "nameWithType": "Library.IsGlobal",
      "fullName": "Oxide.Core.Libraries.Library.IsGlobal"
    },
    {
      "uid": "Oxide.Core.Libraries.Library.LastException",
      "commentId": "P:Oxide.Core.Libraries.Library.LastException",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "LastException",
      "nameWithType": "Library.LastException",
      "fullName": "Oxide.Core.Libraries.Library.LastException"
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
      "uid": "Oxide.Core.Libraries",
      "commentId": "N:Oxide.Core.Libraries",
      "isExternal": true,
      "name": "Oxide.Core.Libraries",
      "nameWithType": "Oxide.Core.Libraries",
      "fullName": "Oxide.Core.Libraries",
      "spec.csharp": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core",
          "name": "Core",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries",
          "name": "Libraries",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide",
          "name": "Oxide",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core",
          "name": "Core",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries",
          "name": "Libraries",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Server.Broadcast*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Server.Broadcast",
      "href": "Oxide.Game.Rust.Libraries.Server.html#Oxide.Game.Rust.Libraries.Server.Broadcast(System.String,System.String,System.UInt64,System.Object[])",
      "name": "Broadcast",
      "nameWithType": "Server.Broadcast",
      "fullName": "Oxide.Game.Rust.Libraries.Server.Broadcast"
    },
    {
      "uid": "System.String",
      "commentId": "T:System.String",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "string",
      "nameWithType": "string",
      "fullName": "string",
      "nameWithType.vb": "String",
      "fullName.vb": "String",
      "name.vb": "String"
    },
    {
      "uid": "System.UInt64",
      "commentId": "T:System.UInt64",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.uint64",
      "name": "ulong",
      "nameWithType": "ulong",
      "fullName": "ulong",
      "nameWithType.vb": "ULong",
      "fullName.vb": "ULong",
      "name.vb": "ULong"
    },
    {
      "uid": "System.Object[]",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "object[]",
      "nameWithType": "object[]",
      "fullName": "object[]",
      "nameWithType.vb": "Object()",
      "fullName.vb": "Object()",
      "name.vb": "Object()",
      "spec.csharp": [
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
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
      "uid": "Oxide.Game.Rust.Libraries.Server.Command*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Server.Command",
      "href": "Oxide.Game.Rust.Libraries.Server.html#Oxide.Game.Rust.Libraries.Server.Command(System.String,System.Object[])",
      "name": "Command",
      "nameWithType": "Server.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Server.Command"
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