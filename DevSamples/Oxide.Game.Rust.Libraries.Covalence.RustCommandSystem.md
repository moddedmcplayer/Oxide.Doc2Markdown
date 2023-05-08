# Class RustCommandSystem
Namespace: [Oxide.Game.Rust.Libraries.Covalence](Oxide.Game.Rust.Libraries.Covalence.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCommandSystem : ICommandSystem
```  
#### Represents a binding to a generic command system


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0)  
#### Inherited Members
[ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
```csharp
public RustCommandSystem()
```
RustCommandSystem()
## Methods 
```csharp
public void RegisterCommand(string command, Plugin plugin, CommandCallback callback)
```
RegisterCommand(string, Plugin, CommandCallback)
```csharp
public void UnregisterCommand(string command, Plugin plugin)
```
UnregisterCommand(string, Plugin)
```csharp
public bool HandleChatMessage(IPlayer player, string message)
```
HandleChatMessage(IPlayer, string)
```csharp
public static string[] ExtractArgs(ConsoleSystem.Arg arg)
```
ExtractArgs(Arg)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "commentId": "T:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "id": "RustCommandSystem",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence",
      "children": [
        "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor",
        "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
        "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer,System.String)",
        "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
        "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCommandSystem",
      "nameWithType": "RustCommandSystem",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustCommandSystem",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Represents a binding to a generic command system",
      "example": [],
      "syntax": {
        "content": "public class RustCommandSystem : ICommandSystem",
        "content.vb": "Public Class RustCommandSystem Implements ICommandSystem"
      },
      "inheritance": [
        "System.Object"
      ],
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICommandSystem"
      ],
      "inheritedMembers": [
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor",
      "id": "#ctor",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCommandSystem()",
      "nameWithType": "RustCommandSystem.RustCommandSystem()",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RustCommandSystem()",
      "type": "constructor",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": ".ctor",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 80,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Initializes the command system",
      "example": [],
      "syntax": {
        "content": "public RustCommandSystem()",
        "content.vb": "Public Sub New()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor*",
      "nameWithType.vb": "RustCommandSystem.New()",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.New()",
      "name.vb": "New()"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "id": "RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RegisterCommand(string, Plugin, CommandCallback)",
      "nameWithType": "RustCommandSystem.RegisterCommand(string, Plugin, CommandCallback)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(string, Oxide.Core.Plugins.Plugin, Oxide.Core.Libraries.Covalence.CommandCallback)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RegisterCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 102,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Registers the specified command",
      "example": [],
      "syntax": {
        "content": "public void RegisterCommand(string command, Plugin plugin, CommandCallback callback)",
        "parameters": [
          {
            "id": "command",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "plugin",
            "type": "Oxide.Core.Plugins.Plugin",
            "description": ""
          },
          {
            "id": "callback",
            "type": "Oxide.Core.Libraries.Covalence.CommandCallback",
            "description": ""
          }
        ],
        "content.vb": "Public Sub RegisterCommand(command As String, plugin As Plugin, callback As CommandCallback)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)"
      ],
      "nameWithType.vb": "RustCommandSystem.RegisterCommand(String, Plugin, CommandCallback)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(String, Oxide.Core.Plugins.Plugin, Oxide.Core.Libraries.Covalence.CommandCallback)",
      "name.vb": "RegisterCommand(String, Plugin, CommandCallback)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "id": "UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "UnregisterCommand(string, Plugin)",
      "nameWithType": "RustCommandSystem.UnregisterCommand(string, Plugin)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(string, Oxide.Core.Plugins.Plugin)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "UnregisterCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 253,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Unregisters the specified command",
      "example": [],
      "syntax": {
        "content": "public void UnregisterCommand(string command, Plugin plugin)",
        "parameters": [
          {
            "id": "command",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "plugin",
            "type": "Oxide.Core.Plugins.Plugin",
            "description": ""
          }
        ],
        "content.vb": "Public Sub UnregisterCommand(command As String, plugin As Plugin)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand*",
      "implements": [
        "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)"
      ],
      "nameWithType.vb": "RustCommandSystem.UnregisterCommand(String, Plugin)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(String, Oxide.Core.Plugins.Plugin)",
      "name.vb": "UnregisterCommand(String, Plugin)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer,System.String)",
      "id": "HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "HandleChatMessage(IPlayer, string)",
      "nameWithType": "RustCommandSystem.HandleChatMessage(IPlayer, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "HandleChatMessage",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 322,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Handles a chat message",
      "example": [],
      "syntax": {
        "content": "public bool HandleChatMessage(IPlayer player, string message)",
        "parameters": [
          {
            "id": "player",
            "type": "Oxide.Core.Libraries.Covalence.IPlayer",
            "description": ""
          },
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Function HandleChatMessage(player As IPlayer, message As String) As Boolean"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage*",
      "nameWithType.vb": "RustCommandSystem.HandleChatMessage(IPlayer, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer, String)",
      "name.vb": "HandleChatMessage(IPlayer, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
      "id": "ExtractArgs(ConsoleSystem.Arg)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ExtractArgs(Arg)",
      "nameWithType": "RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Covalence/RustCommandSystem.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ExtractArgs",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Covalence/RustCommandSystem.cs",
        "startLine": 376,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries.Covalence",
      "summary": "Extract the arguments from a ConsoleSystem.Arg object",
      "example": [],
      "syntax": {
        "content": "public static string[] ExtractArgs(ConsoleSystem.Arg arg)",
        "parameters": [
          {
            "id": "arg",
            "type": "ConsoleSystem.Arg",
            "description": ""
          }
        ],
        "return": {
          "type": "System.String[]",
          "description": ""
        },
        "content.vb": "Public Shared Function ExtractArgs(arg As ConsoleSystem.Arg) As String()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs*"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence",
      "commentId": "N:Oxide.Game.Rust.Libraries.Covalence",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust.Libraries.Covalence",
      "nameWithType": "Oxide.Game.Rust.Libraries.Covalence",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence",
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
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.Covalence.html"
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
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Game.Rust.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": false,
          "href": "Oxide.Game.Rust.Libraries.Covalence.html"
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
      "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem",
      "commentId": "T:Oxide.Core.Libraries.Covalence.ICommandSystem",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "ICommandSystem",
      "nameWithType": "ICommandSystem",
      "fullName": "Oxide.Core.Libraries.Covalence.ICommandSystem"
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
      "uid": "Oxide.Core.Libraries.Covalence",
      "commentId": "N:Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "Oxide.Core.Libraries.Covalence",
      "nameWithType": "Oxide.Core.Libraries.Covalence",
      "fullName": "Oxide.Core.Libraries.Covalence",
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
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence",
          "name": "Covalence",
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
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Libraries.Covalence",
          "name": "Covalence",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html#Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.#ctor",
      "name": "RustCommandSystem",
      "nameWithType": "RustCommandSystem.RustCommandSystem",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RustCommandSystem",
      "nameWithType.vb": "RustCommandSystem.New",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.New",
      "name.vb": "New"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html#Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "name": "RegisterCommand",
      "nameWithType": "RustCommandSystem.RegisterCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.RegisterCommand"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
      "parent": "Oxide.Core.Libraries.Covalence.ICommandSystem",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "RegisterCommand(string, Plugin, CommandCallback)",
      "nameWithType": "ICommandSystem.RegisterCommand(string, Plugin, CommandCallback)",
      "fullName": "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(string, Oxide.Core.Plugins.Plugin, Oxide.Core.Libraries.Covalence.CommandCallback)",
      "nameWithType.vb": "ICommandSystem.RegisterCommand(String, Plugin, CommandCallback)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(String, Oxide.Core.Plugins.Plugin, Oxide.Core.Libraries.Covalence.CommandCallback)",
      "name.vb": "RegisterCommand(String, Plugin, CommandCallback)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "RegisterCommand",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.Plugin",
          "name": "Plugin",
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
          "uid": "Oxide.Core.Libraries.Covalence.CommandCallback",
          "name": "CommandCallback",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.RegisterCommand(System.String,Oxide.Core.Plugins.Plugin,Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "RegisterCommand",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.Plugin",
          "name": "Plugin",
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
          "uid": "Oxide.Core.Libraries.Covalence.CommandCallback",
          "name": "CommandCallback",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
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
      "uid": "Oxide.Core.Plugins.Plugin",
      "commentId": "T:Oxide.Core.Plugins.Plugin",
      "parent": "Oxide.Core.Plugins",
      "isExternal": true,
      "name": "Plugin",
      "nameWithType": "Plugin",
      "fullName": "Oxide.Core.Plugins.Plugin"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.CommandCallback",
      "commentId": "T:Oxide.Core.Libraries.Covalence.CommandCallback",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "CommandCallback",
      "nameWithType": "CommandCallback",
      "fullName": "Oxide.Core.Libraries.Covalence.CommandCallback"
    },
    {
      "uid": "Oxide.Core.Plugins",
      "commentId": "N:Oxide.Core.Plugins",
      "isExternal": true,
      "name": "Oxide.Core.Plugins",
      "nameWithType": "Oxide.Core.Plugins",
      "fullName": "Oxide.Core.Plugins",
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
          "uid": "Oxide.Core.Plugins",
          "name": "Plugins",
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
          "uid": "Oxide.Core.Plugins",
          "name": "Plugins",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html#Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "name": "UnregisterCommand",
      "nameWithType": "RustCommandSystem.UnregisterCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.UnregisterCommand"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "commentId": "M:Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "parent": "Oxide.Core.Libraries.Covalence.ICommandSystem",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "UnregisterCommand(string, Plugin)",
      "nameWithType": "ICommandSystem.UnregisterCommand(string, Plugin)",
      "fullName": "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(string, Oxide.Core.Plugins.Plugin)",
      "nameWithType.vb": "ICommandSystem.UnregisterCommand(String, Plugin)",
      "fullName.vb": "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(String, Oxide.Core.Plugins.Plugin)",
      "name.vb": "UnregisterCommand(String, Plugin)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
          "name": "UnregisterCommand",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.Plugin",
          "name": "Plugin",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Libraries.Covalence.ICommandSystem.UnregisterCommand(System.String,Oxide.Core.Plugins.Plugin)",
          "name": "UnregisterCommand",
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
          "name": ",",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.Plugin",
          "name": "Plugin",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html#Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage(Oxide.Core.Libraries.Covalence.IPlayer,System.String)",
      "name": "HandleChatMessage",
      "nameWithType": "RustCommandSystem.HandleChatMessage",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.HandleChatMessage"
    },
    {
      "uid": "Oxide.Core.Libraries.Covalence.IPlayer",
      "commentId": "T:Oxide.Core.Libraries.Covalence.IPlayer",
      "parent": "Oxide.Core.Libraries.Covalence",
      "isExternal": true,
      "name": "IPlayer",
      "nameWithType": "IPlayer",
      "fullName": "Oxide.Core.Libraries.Covalence.IPlayer"
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
      "uid": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs",
      "href": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.html#Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs(ConsoleSystem.Arg)",
      "name": "ExtractArgs",
      "nameWithType": "RustCommandSystem.ExtractArgs",
      "fullName": "Oxide.Game.Rust.Libraries.Covalence.RustCommandSystem.ExtractArgs"
    },
    {
      "uid": "ConsoleSystem.Arg",
      "commentId": "T:ConsoleSystem.Arg",
      "isExternal": true,
      "name": "ConsoleSystem.Arg",
      "nameWithType": "ConsoleSystem.Arg",
      "fullName": "ConsoleSystem.Arg",
      "spec.csharp": [
        {
          "uid": "ConsoleSystem",
          "name": "ConsoleSystem",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "ConsoleSystem.Arg",
          "name": "Arg",
          "isExternal": true
        }
      ],
      "spec.vb": [
        {
          "uid": "ConsoleSystem",
          "name": "ConsoleSystem",
          "isExternal": true
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "ConsoleSystem.Arg",
          "name": "Arg",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "System.String[]",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "string[]",
      "nameWithType": "string[]",
      "fullName": "string[]",
      "nameWithType.vb": "String()",
      "fullName.vb": "String()",
      "name.vb": "String()",
      "spec.csharp": [
        {
          "uid": "System.String",
          "name": "string",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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
          "uid": "System.String",
          "name": "String",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.string"
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