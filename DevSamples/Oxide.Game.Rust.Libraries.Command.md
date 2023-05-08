# Class Command
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Command : Library
```  
#### A library containing functions for adding console and chat commands


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, IsGlobal, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
```csharp
public Command()
```
Command()
## Methods 
```csharp
[LibraryFunction("AddChatCommand")]
public void AddChatCommand(string name, Plugin plugin, string callback)
```
AddChatCommand(string, Plugin, string)
```csharp
public void AddChatCommand(string command, Plugin plugin, Action<BasePlayer, string, string[]> callback)
```
AddChatCommand(string, Plugin, Action<BasePlayer, string, string[]>)
```csharp
[LibraryFunction("AddConsoleCommand")]
public void AddConsoleCommand(string command, Plugin plugin, string callback)
```
AddConsoleCommand(string, Plugin, string)
```csharp
public void AddConsoleCommand(string command, Plugin plugin, Func<ConsoleSystem.Arg, bool> callback)
```
AddConsoleCommand(string, Plugin, Func<Arg, bool>)
```csharp
[LibraryFunction("RemoveChatCommand")]
public void RemoveChatCommand(string command, Plugin plugin)
```
RemoveChatCommand(string, Plugin)
```csharp
[LibraryFunction("RemoveConsoleCommand")]
public void RemoveConsoleCommand(string command, Plugin plugin)
```
RemoveConsoleCommand(string, Plugin)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Command",
      "commentId": "T:Oxide.Game.Rust.Libraries.Command",
      "id": "Command",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries",
      "children": [
        "Oxide.Game.Rust.Libraries.Command.#ctor",
        "Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.Action{BasePlayer,System.String,System.String[]})",
        "Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
        "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.Func{ConsoleSystem.Arg,System.Boolean})",
        "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
        "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(System.String,Oxide.Core.Plugins.Plugin)",
        "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(System.String,Oxide.Core.Plugins.Plugin)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command",
      "nameWithType": "Command",
      "fullName": "Oxide.Game.Rust.Libraries.Command",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Command",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "A library containing functions for adding console and chat commands",
      "example": [],
      "syntax": {
        "content": "public class Command : Library",
        "content.vb": "Public Class Command Inherits Library"
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
      "uid": "Oxide.Game.Rust.Libraries.Command.#ctor",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.#ctor",
      "id": "#ctor",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Command()",
      "nameWithType": "Command.Command()",
      "fullName": "Oxide.Game.Rust.Libraries.Command.Command()",
      "type": "constructor",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": ".ctor",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 108,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Initializes a new instance of the Command class",
      "example": [],
      "syntax": {
        "content": "public Command()",
        "content.vb": "Public Sub New()"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.#ctor*",
      "nameWithType.vb": "Command.New()",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.New()",
      "name.vb": "New()"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "id": "AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddChatCommand(string, Plugin, string)",
      "nameWithType": "Command.AddChatCommand(string, Plugin, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(string, Oxide.Core.Plugins.Plugin, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddChatCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 121,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Adds a chat command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"AddChatCommand\")]\npublic void AddChatCommand(string name, Plugin plugin, string callback)",
        "parameters": [
          {
            "id": "name",
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
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "<LibraryFunction(\"AddChatCommand\")>\nPublic Sub AddChatCommand(name As String, plugin As Plugin, callback As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.AddChatCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "AddChatCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Command.AddChatCommand(String, Plugin, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(String, Oxide.Core.Plugins.Plugin, String)",
      "name.vb": "AddChatCommand(String, Plugin, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.Action{BasePlayer,System.String,System.String[]})",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.Action{BasePlayer,System.String,System.String[]})",
      "id": "AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.Action{BasePlayer,System.String,System.String[]})",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddChatCommand(string, Plugin, Action<BasePlayer, string, string[]>)",
      "nameWithType": "Command.AddChatCommand(string, Plugin, Action<BasePlayer, string, string[]>)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(string, Oxide.Core.Plugins.Plugin, System.Action<BasePlayer, string, string[]>)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddChatCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 133,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Adds a chat command",
      "example": [],
      "syntax": {
        "content": "public void AddChatCommand(string command, Plugin plugin, Action<BasePlayer, string, string[]> callback)",
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
            "type": "System.Action{BasePlayer,System.String,System.String[]}",
            "description": ""
          }
        ],
        "content.vb": "Public Sub AddChatCommand(command As String, plugin As Plugin, callback As Action(Of BasePlayer, String, String()))"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.AddChatCommand*",
      "nameWithType.vb": "Command.AddChatCommand(String, Plugin, Action(Of BasePlayer, String, String()))",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.AddChatCommand(String, Oxide.Core.Plugins.Plugin, System.Action(Of BasePlayer, String, String()))",
      "name.vb": "AddChatCommand(String, Plugin, Action(Of BasePlayer, String, String()))"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "id": "AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddConsoleCommand(string, Plugin, string)",
      "nameWithType": "Command.AddConsoleCommand(string, Plugin, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(string, Oxide.Core.Plugins.Plugin, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddConsoleCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 179,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Adds a console command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"AddConsoleCommand\")]\npublic void AddConsoleCommand(string command, Plugin plugin, string callback)",
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
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "<LibraryFunction(\"AddConsoleCommand\")>\nPublic Sub AddConsoleCommand(command As String, plugin As Plugin, callback As String)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "AddConsoleCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Command.AddConsoleCommand(String, Plugin, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(String, Oxide.Core.Plugins.Plugin, String)",
      "name.vb": "AddConsoleCommand(String, Plugin, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.Func{ConsoleSystem.Arg,System.Boolean})",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.Func{ConsoleSystem.Arg,System.Boolean})",
      "id": "AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.Func{ConsoleSystem.Arg,System.Boolean})",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "AddConsoleCommand(string, Plugin, Func<Arg, bool>)",
      "nameWithType": "Command.AddConsoleCommand(string, Plugin, Func<ConsoleSystem.Arg, bool>)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(string, Oxide.Core.Plugins.Plugin, System.Func<ConsoleSystem.Arg, bool>)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "AddConsoleCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 191,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Adds a console command with a delegate callback",
      "example": [],
      "syntax": {
        "content": "public void AddConsoleCommand(string command, Plugin plugin, Func<ConsoleSystem.Arg, bool> callback)",
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
            "type": "System.Func{ConsoleSystem.Arg,System.Boolean}",
            "description": ""
          }
        ],
        "content.vb": "Public Sub AddConsoleCommand(command As String, plugin As Plugin, callback As Func(Of ConsoleSystem.Arg, Boolean))"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand*",
      "nameWithType.vb": "Command.AddConsoleCommand(String, Plugin, Func(Of ConsoleSystem.Arg, Boolean))",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(String, Oxide.Core.Plugins.Plugin, System.Func(Of ConsoleSystem.Arg, Boolean))",
      "name.vb": "AddConsoleCommand(String, Plugin, Func(Of Arg, Boolean))"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "id": "RemoveChatCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RemoveChatCommand(string, Plugin)",
      "nameWithType": "Command.RemoveChatCommand(string, Plugin)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(string, Oxide.Core.Plugins.Plugin)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RemoveChatCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 284,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Removes a previously registered chat command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"RemoveChatCommand\")]\npublic void RemoveChatCommand(string command, Plugin plugin)",
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
        "content.vb": "<LibraryFunction(\"RemoveChatCommand\")>\nPublic Sub RemoveChatCommand(command As String, plugin As Plugin)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "RemoveChatCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Command.RemoveChatCommand(String, Plugin)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(String, Oxide.Core.Plugins.Plugin)",
      "name.vb": "RemoveChatCommand(String, Plugin)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "id": "RemoveConsoleCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Command",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RemoveConsoleCommand(string, Plugin)",
      "nameWithType": "Command.RemoveConsoleCommand(string, Plugin)",
      "fullName": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(string, Oxide.Core.Plugins.Plugin)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Command.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RemoveConsoleCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Command.cs",
        "startLine": 299,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Removes a previously registered console command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"RemoveConsoleCommand\")]\npublic void RemoveConsoleCommand(string command, Plugin plugin)",
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
        "content.vb": "<LibraryFunction(\"RemoveConsoleCommand\")>\nPublic Sub RemoveConsoleCommand(command As String, plugin As Plugin)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "RemoveConsoleCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Command.RemoveConsoleCommand(String, Plugin)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(String, Oxide.Core.Plugins.Plugin)",
      "name.vb": "RemoveConsoleCommand(String, Plugin)"
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
      "uid": "Oxide.Game.Rust.Libraries.Command.#ctor*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Command.#ctor",
      "href": "Oxide.Game.Rust.Libraries.Command.html#Oxide.Game.Rust.Libraries.Command.#ctor",
      "name": "Command",
      "nameWithType": "Command.Command",
      "fullName": "Oxide.Game.Rust.Libraries.Command.Command",
      "nameWithType.vb": "Command.New",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Command.New",
      "name.vb": "New"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddChatCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Command.AddChatCommand",
      "href": "Oxide.Game.Rust.Libraries.Command.html#Oxide.Game.Rust.Libraries.Command.AddChatCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "name": "AddChatCommand",
      "nameWithType": "Command.AddChatCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddChatCommand"
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
      "uid": "System.Action{BasePlayer,System.String,System.String[]}",
      "commentId": "T:System.Action{BasePlayer,System.String,System.String[]}",
      "parent": "System",
      "definition": "System.Action`3",
      "href": "https://learn.microsoft.com/dotnet/api/system.action-3",
      "name": "Action<BasePlayer, string, string[]>",
      "nameWithType": "Action<BasePlayer, string, string[]>",
      "fullName": "System.Action<BasePlayer, string, string[]>",
      "nameWithType.vb": "Action(Of BasePlayer, String, String())",
      "fullName.vb": "System.Action(Of BasePlayer, String, String())",
      "name.vb": "Action(Of BasePlayer, String, String())",
      "spec.csharp": [
        {
          "uid": "System.Action`3",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-3"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "BasePlayer",
          "name": "BasePlayer",
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
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Action`3",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-3"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "uid": "BasePlayer",
          "name": "BasePlayer",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Action`3",
      "commentId": "T:System.Action`3",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.action-3",
      "name": "Action<T1, T2, T3>",
      "nameWithType": "Action<T1, T2, T3>",
      "fullName": "System.Action<T1, T2, T3>",
      "nameWithType.vb": "Action(Of T1, T2, T3)",
      "fullName.vb": "System.Action(Of T1, T2, T3)",
      "name.vb": "Action(Of T1, T2, T3)",
      "spec.csharp": [
        {
          "uid": "System.Action`3",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-3"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "name": "T1",
          "isExternal": false
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
          "name": "T2",
          "isExternal": false
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
          "name": "T3",
          "isExternal": false
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Action`3",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-3"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "name": "T1",
          "isExternal": false
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
          "name": "T2",
          "isExternal": false
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
          "name": "T3",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Command.AddConsoleCommand",
      "href": "Oxide.Game.Rust.Libraries.Command.html#Oxide.Game.Rust.Libraries.Command.AddConsoleCommand(System.String,Oxide.Core.Plugins.Plugin,System.String)",
      "name": "AddConsoleCommand",
      "nameWithType": "Command.AddConsoleCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Command.AddConsoleCommand"
    },
    {
      "uid": "System.Func{ConsoleSystem.Arg,System.Boolean}",
      "commentId": "T:System.Func{ConsoleSystem.Arg,System.Boolean}",
      "parent": "System",
      "definition": "System.Func`2",
      "href": "https://learn.microsoft.com/dotnet/api/system.func-2",
      "name": "Func<ConsoleSystem.Arg, bool>",
      "nameWithType": "Func<ConsoleSystem.Arg, bool>",
      "fullName": "System.Func<ConsoleSystem.Arg, bool>",
      "nameWithType.vb": "Func(Of ConsoleSystem.Arg, Boolean)",
      "fullName.vb": "System.Func(Of ConsoleSystem.Arg, Boolean)",
      "name.vb": "Func(Of ConsoleSystem.Arg, Boolean)",
      "spec.csharp": [
        {
          "uid": "System.Func`2",
          "name": "Func",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.func-2"
        },
        {
          "name": "<",
          "isExternal": false
        },
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
          "uid": "System.Boolean",
          "name": "bool",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.boolean"
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Func`2",
          "name": "Func",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.func-2"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
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
          "uid": "System.Boolean",
          "name": "Boolean",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.boolean"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Func`2",
      "commentId": "T:System.Func`2",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.func-2",
      "name": "Func<T, TResult>",
      "nameWithType": "Func<T, TResult>",
      "fullName": "System.Func<T, TResult>",
      "nameWithType.vb": "Func(Of T, TResult)",
      "fullName.vb": "System.Func(Of T, TResult)",
      "name.vb": "Func(Of T, TResult)",
      "spec.csharp": [
        {
          "uid": "System.Func`2",
          "name": "Func",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.func-2"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "name": "T",
          "isExternal": false
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
          "name": "TResult",
          "isExternal": false
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Func`2",
          "name": "Func",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.func-2"
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "name": "Of",
          "isExternal": false
        },
        {
          "name": " ",
          "isExternal": false
        },
        {
          "name": "T",
          "isExternal": false
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
          "name": "TResult",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Command.RemoveChatCommand",
      "href": "Oxide.Game.Rust.Libraries.Command.html#Oxide.Game.Rust.Libraries.Command.RemoveChatCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "name": "RemoveChatCommand",
      "nameWithType": "Command.RemoveChatCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Command.RemoveChatCommand"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand",
      "href": "Oxide.Game.Rust.Libraries.Command.html#Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand(System.String,Oxide.Core.Plugins.Plugin)",
      "name": "RemoveConsoleCommand",
      "nameWithType": "Command.RemoveConsoleCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Command.RemoveConsoleCommand"
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