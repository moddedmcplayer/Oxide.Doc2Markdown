# Class RustPlugin
Namespace: [Oxide.Plugins](Oxide.Plugins.md)  
Assembly: Oxide.Rust.dll  
```csharp
public abstract class RustPlugin : CSharpPlugin
```  
#### 


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Plugins.Plugin, Oxide.Core.Plugins.CSPlugin, Oxide.Plugins.CSharpPlugin  
#### Inherited Members
Watcher, covalence, lang, plugins, permission, webrequest, timer, onlinePlayerFields, SetPluginInfo, HandleRemovedFromManager, DirectCallHook, InvokeMethod, SetFailState, Puts, PrintWarning, PrintError, LogToFile, NextFrame, NextTick, QueueWorkerThread, HookedOnFrame, Hooks, HooksCache, GetLibrary``1, AddHookMethod, OnCallHook, FindHooks, OnAddedToManager, OnRemovedFromManager, nestcount, Subscribe, Unsubscribe, Load, CallHook, Call, Call``1, RaiseError, TrackStart, TrackEnd, LoadConfig, LoadDefaultConfig, SaveConfig, LoadDefaultMessages, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, Filename, Name, Title, Description, Author, Version, ResourceId, Manager, HasConfig, HasMessages, IsCorePlugin, Loader, Object, Config, IsLoaded, TotalHookTime, OnError, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Methods 
```csharp
public override void HandleAddedToManager(PluginManager manager)
```
HandleAddedToManager(PluginManager)
```csharp
protected void PrintToConsole(BasePlayer player, string format, params object[] args)
```
PrintToConsole(BasePlayer, string, params object[])
```csharp
protected void PrintToConsole(string format, params object[] args)
```
PrintToConsole(string, params object[])
```csharp
protected void PrintToChat(BasePlayer player, string format, params object[] args)
```
PrintToChat(BasePlayer, string, params object[])
```csharp
protected void PrintToChat(string format, params object[] args)
```
PrintToChat(string, params object[])
```csharp
protected void SendReply(ConsoleSystem.Arg arg, string format, params object[] args)
```
SendReply(Arg, string, params object[])
```csharp
protected void SendReply(BasePlayer player, string format, params object[] args)
```
SendReply(BasePlayer, string, params object[])
```csharp
protected void SendWarning(ConsoleSystem.Arg arg, string format, params object[] args)
```
SendWarning(Arg, string, params object[])
```csharp
protected void SendError(ConsoleSystem.Arg arg, string format, params object[] args)
```
SendError(Arg, string, params object[])
```csharp
protected void ForcePlayerPosition(BasePlayer player, Vector3 destination)
```
ForcePlayerPosition(BasePlayer, Vector3)
## Fields 
```csharp
protected Command cmd
```
cmd
```csharp
protected Rust rust
```
rust
```csharp
protected Item Item
```
Item
```csharp
protected Player Player
```
Player
```csharp
protected Server Server
```
Server






JSON:
{
  "items": [
    {
      "uid": "Oxide.Plugins.RustPlugin",
      "commentId": "T:Oxide.Plugins.RustPlugin",
      "id": "RustPlugin",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins",
      "children": [
        "Oxide.Plugins.RustPlugin.ForcePlayerPosition(BasePlayer,UnityEngine.Vector3)",
        "Oxide.Plugins.RustPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
        "Oxide.Plugins.RustPlugin.Item",
        "Oxide.Plugins.RustPlugin.Player",
        "Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.PrintToChat(System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.PrintToConsole(System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.SendReply(BasePlayer,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg,System.String,System.Object[])",
        "Oxide.Plugins.RustPlugin.Server",
        "Oxide.Plugins.RustPlugin.cmd",
        "Oxide.Plugins.RustPlugin.rust"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustPlugin",
      "nameWithType": "RustPlugin",
      "fullName": "Oxide.Plugins.RustPlugin",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustPlugin",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 9,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "public abstract class RustPlugin : CSharpPlugin",
        "content.vb": "Public MustInherit Class RustPlugin Inherits CSharpPlugin"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Plugins.Plugin",
        "Oxide.Core.Plugins.CSPlugin",
        "Oxide.Plugins.CSharpPlugin"
      ],
      "inheritedMembers": [
        "Oxide.Plugins.CSharpPlugin.Watcher",
        "Oxide.Plugins.CSharpPlugin.covalence",
        "Oxide.Plugins.CSharpPlugin.lang",
        "Oxide.Plugins.CSharpPlugin.plugins",
        "Oxide.Plugins.CSharpPlugin.permission",
        "Oxide.Plugins.CSharpPlugin.webrequest",
        "Oxide.Plugins.CSharpPlugin.timer",
        "Oxide.Plugins.CSharpPlugin.onlinePlayerFields",
        "Oxide.Plugins.CSharpPlugin.SetPluginInfo(System.String,System.String)",
        "Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
        "Oxide.Plugins.CSharpPlugin.DirectCallHook(System.String,System.Object@,System.Object[])",
        "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
        "Oxide.Plugins.CSharpPlugin.SetFailState(System.String)",
        "Oxide.Plugins.CSharpPlugin.Puts(System.String,System.Object[])",
        "Oxide.Plugins.CSharpPlugin.PrintWarning(System.String,System.Object[])",
        "Oxide.Plugins.CSharpPlugin.PrintError(System.String,System.Object[])",
        "Oxide.Plugins.CSharpPlugin.LogToFile(System.String,System.String,Oxide.Core.Plugins.Plugin,System.Boolean,System.Boolean)",
        "Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
        "Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
        "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action{System.Object})",
        "Oxide.Plugins.CSharpPlugin.HookedOnFrame",
        "Oxide.Core.Plugins.CSPlugin.Hooks",
        "Oxide.Core.Plugins.CSPlugin.HooksCache",
        "Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
        "Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
        "Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
        "Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
        "Oxide.Core.Plugins.Plugin.OnAddedToManager",
        "Oxide.Core.Plugins.Plugin.OnRemovedFromManager",
        "Oxide.Core.Plugins.Plugin.nestcount",
        "Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
        "Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
        "Oxide.Core.Plugins.Plugin.Load",
        "Oxide.Core.Plugins.Plugin.CallHook(System.String,System.Object[])",
        "Oxide.Core.Plugins.Plugin.Call(System.String,System.Object[])",
        "Oxide.Core.Plugins.Plugin.Call``1(System.String,System.Object[])",
        "Oxide.Core.Plugins.Plugin.RaiseError(System.String)",
        "Oxide.Core.Plugins.Plugin.TrackStart",
        "Oxide.Core.Plugins.Plugin.TrackEnd",
        "Oxide.Core.Plugins.Plugin.LoadConfig",
        "Oxide.Core.Plugins.Plugin.LoadDefaultConfig",
        "Oxide.Core.Plugins.Plugin.SaveConfig",
        "Oxide.Core.Plugins.Plugin.LoadDefaultMessages",
        "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String,System.String,System.String)",
        "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String,System.String,System.String)",
        "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String)",
        "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String)",
        "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String[])",
        "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String[])",
        "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
        "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
        "Oxide.Core.Plugins.Plugin.Filename",
        "Oxide.Core.Plugins.Plugin.Name",
        "Oxide.Core.Plugins.Plugin.Title",
        "Oxide.Core.Plugins.Plugin.Description",
        "Oxide.Core.Plugins.Plugin.Author",
        "Oxide.Core.Plugins.Plugin.Version",
        "Oxide.Core.Plugins.Plugin.ResourceId",
        "Oxide.Core.Plugins.Plugin.Manager",
        "Oxide.Core.Plugins.Plugin.HasConfig",
        "Oxide.Core.Plugins.Plugin.HasMessages",
        "Oxide.Core.Plugins.Plugin.IsCorePlugin",
        "Oxide.Core.Plugins.Plugin.Loader",
        "Oxide.Core.Plugins.Plugin.Object",
        "Oxide.Core.Plugins.Plugin.Config",
        "Oxide.Core.Plugins.Plugin.IsLoaded",
        "Oxide.Core.Plugins.Plugin.TotalHookTime",
        "Oxide.Core.Plugins.Plugin.OnError",
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
      "uid": "Oxide.Plugins.RustPlugin.cmd",
      "commentId": "F:Oxide.Plugins.RustPlugin.cmd",
      "id": "cmd",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "cmd",
      "nameWithType": "RustPlugin.cmd",
      "fullName": "Oxide.Plugins.RustPlugin.cmd",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "cmd",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 11,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "protected Command cmd",
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Command"
        },
        "content.vb": "Protected cmd As Command"
      }
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.rust",
      "commentId": "F:Oxide.Plugins.RustPlugin.rust",
      "id": "rust",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "rust",
      "nameWithType": "RustPlugin.rust",
      "fullName": "Oxide.Plugins.RustPlugin.rust",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "rust",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 12,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "protected Rust rust",
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Rust"
        },
        "content.vb": "Protected rust As Rust"
      }
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.Item",
      "commentId": "F:Oxide.Plugins.RustPlugin.Item",
      "id": "Item",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Item",
      "nameWithType": "RustPlugin.Item",
      "fullName": "Oxide.Plugins.RustPlugin.Item",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Item",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 13,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "protected Item Item",
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Item"
        },
        "content.vb": "Protected Item As Item"
      }
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.Player",
      "commentId": "F:Oxide.Plugins.RustPlugin.Player",
      "id": "Player",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Player",
      "nameWithType": "RustPlugin.Player",
      "fullName": "Oxide.Plugins.RustPlugin.Player",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Player",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "protected Player Player",
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Player"
        },
        "content.vb": "Protected Player As Player"
      }
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.Server",
      "commentId": "F:Oxide.Plugins.RustPlugin.Server",
      "id": "Server",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Server",
      "nameWithType": "RustPlugin.Server",
      "fullName": "Oxide.Plugins.RustPlugin.Server",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Server",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 15,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "syntax": {
        "content": "protected Server Server",
        "return": {
          "type": "Oxide.Game.Rust.Libraries.Server"
        },
        "content.vb": "Protected Server As Server"
      }
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "commentId": "M:Oxide.Plugins.RustPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "id": "HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "HandleAddedToManager(PluginManager)",
      "nameWithType": "RustPlugin.HandleAddedToManager(PluginManager)",
      "fullName": "Oxide.Plugins.RustPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "HandleAddedToManager",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 17,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "example": [],
      "syntax": {
        "content": "public override void HandleAddedToManager(PluginManager manager)",
        "parameters": [
          {
            "id": "manager",
            "type": "Oxide.Core.Plugins.PluginManager"
          }
        ],
        "content.vb": "Public Overrides Sub HandleAddedToManager(manager As PluginManager)"
      },
      "overridden": "Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "overload": "Oxide.Plugins.RustPlugin.HandleAddedToManager*"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer,System.String,System.Object[])",
      "id": "PrintToConsole(BasePlayer,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PrintToConsole(BasePlayer, string, params object[])",
      "nameWithType": "RustPlugin.PrintToConsole(BasePlayer, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PrintToConsole",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 121,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Print a message to the players console log",
      "example": [],
      "syntax": {
        "content": "protected void PrintToConsole(BasePlayer player, string format, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub PrintToConsole(player As BasePlayer, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.PrintToConsole*",
      "nameWithType.vb": "RustPlugin.PrintToConsole(BasePlayer, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer, String, ParamArray Object())",
      "name.vb": "PrintToConsole(BasePlayer, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.PrintToConsole(System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.PrintToConsole(System.String,System.Object[])",
      "id": "PrintToConsole(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PrintToConsole(string, params object[])",
      "nameWithType": "RustPlugin.PrintToConsole(string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToConsole(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PrintToConsole",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 134,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Print a message to every players console log",
      "example": [],
      "syntax": {
        "content": "protected void PrintToConsole(string format, params object[] args)",
        "parameters": [
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub PrintToConsole(format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.PrintToConsole*",
      "nameWithType.vb": "RustPlugin.PrintToConsole(String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.PrintToConsole(String, ParamArray Object())",
      "name.vb": "PrintToConsole(String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer,System.String,System.Object[])",
      "id": "PrintToChat(BasePlayer,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PrintToChat(BasePlayer, string, params object[])",
      "nameWithType": "RustPlugin.PrintToChat(BasePlayer, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PrintToChat",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 148,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Print a message to the players chat log",
      "example": [],
      "syntax": {
        "content": "protected void PrintToChat(BasePlayer player, string format, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub PrintToChat(player As BasePlayer, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.PrintToChat*",
      "nameWithType.vb": "RustPlugin.PrintToChat(BasePlayer, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer, String, ParamArray Object())",
      "name.vb": "PrintToChat(BasePlayer, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.PrintToChat(System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.PrintToChat(System.String,System.Object[])",
      "id": "PrintToChat(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PrintToChat(string, params object[])",
      "nameWithType": "RustPlugin.PrintToChat(string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToChat(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PrintToChat",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 161,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Print a message to every players chat log",
      "example": [],
      "syntax": {
        "content": "protected void PrintToChat(string format, params object[] args)",
        "parameters": [
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub PrintToChat(format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.PrintToChat*",
      "nameWithType.vb": "RustPlugin.PrintToChat(String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.PrintToChat(String, ParamArray Object())",
      "name.vb": "PrintToChat(String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg,System.String,System.Object[])",
      "id": "SendReply(ConsoleSystem.Arg,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SendReply(Arg, string, params object[])",
      "nameWithType": "RustPlugin.SendReply(ConsoleSystem.Arg, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SendReply",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 175,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Send a reply message in response to a console command",
      "example": [],
      "syntax": {
        "content": "protected void SendReply(ConsoleSystem.Arg arg, string format, params object[] args)",
        "parameters": [
          {
            "id": "arg",
            "type": "ConsoleSystem.Arg",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub SendReply(arg As ConsoleSystem.Arg, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.SendReply*",
      "nameWithType.vb": "RustPlugin.SendReply(ConsoleSystem.Arg, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg, String, ParamArray Object())",
      "name.vb": "SendReply(Arg, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendReply(BasePlayer,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.SendReply(BasePlayer,System.String,System.Object[])",
      "id": "SendReply(BasePlayer,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SendReply(BasePlayer, string, params object[])",
      "nameWithType": "RustPlugin.SendReply(BasePlayer, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.SendReply(BasePlayer, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SendReply",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 195,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Send a reply message in response to a chat command",
      "example": [],
      "syntax": {
        "content": "protected void SendReply(BasePlayer player, string format, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub SendReply(player As BasePlayer, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.SendReply*",
      "nameWithType.vb": "RustPlugin.SendReply(BasePlayer, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.SendReply(BasePlayer, String, ParamArray Object())",
      "name.vb": "SendReply(BasePlayer, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg,System.String,System.Object[])",
      "id": "SendWarning(ConsoleSystem.Arg,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SendWarning(Arg, string, params object[])",
      "nameWithType": "RustPlugin.SendWarning(ConsoleSystem.Arg, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SendWarning",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 203,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Send a warning message in response to a console command",
      "example": [],
      "syntax": {
        "content": "protected void SendWarning(ConsoleSystem.Arg arg, string format, params object[] args)",
        "parameters": [
          {
            "id": "arg",
            "type": "ConsoleSystem.Arg",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub SendWarning(arg As ConsoleSystem.Arg, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.SendWarning*",
      "nameWithType.vb": "RustPlugin.SendWarning(ConsoleSystem.Arg, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg, String, ParamArray Object())",
      "name.vb": "SendWarning(Arg, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg,System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg,System.String,System.Object[])",
      "id": "SendError(ConsoleSystem.Arg,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SendError(Arg, string, params object[])",
      "nameWithType": "RustPlugin.SendError(ConsoleSystem.Arg, string, params object[])",
      "fullName": "Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SendError",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 223,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Send an error message in response to a console command",
      "example": [],
      "syntax": {
        "content": "protected void SendError(ConsoleSystem.Arg arg, string format, params object[] args)",
        "parameters": [
          {
            "id": "arg",
            "type": "ConsoleSystem.Arg",
            "description": ""
          },
          {
            "id": "format",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "args",
            "type": "System.Object[]",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub SendError(arg As ConsoleSystem.Arg, format As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Plugins.RustPlugin.SendError*",
      "nameWithType.vb": "RustPlugin.SendError(ConsoleSystem.Arg, String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg, String, ParamArray Object())",
      "name.vb": "SendError(Arg, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.ForcePlayerPosition(BasePlayer,UnityEngine.Vector3)",
      "commentId": "M:Oxide.Plugins.RustPlugin.ForcePlayerPosition(BasePlayer,UnityEngine.Vector3)",
      "id": "ForcePlayerPosition(BasePlayer,UnityEngine.Vector3)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Plugins.RustPlugin",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ForcePlayerPosition(BasePlayer, Vector3)",
      "nameWithType": "RustPlugin.ForcePlayerPosition(BasePlayer, Vector3)",
      "fullName": "Oxide.Plugins.RustPlugin.ForcePlayerPosition(BasePlayer, UnityEngine.Vector3)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustPlugin.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ForcePlayerPosition",
        "path": "../../../../../../../Oxide.Rust/src/RustPlugin.cs",
        "startLine": 242,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Plugins",
      "summary": "Forces the player to a specific position",
      "example": [],
      "syntax": {
        "content": "protected void ForcePlayerPosition(BasePlayer player, Vector3 destination)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "destination",
            "type": "UnityEngine.Vector3",
            "description": ""
          }
        ],
        "content.vb": "Protected Sub ForcePlayerPosition(player As BasePlayer, destination As Vector3)"
      },
      "overload": "Oxide.Plugins.RustPlugin.ForcePlayerPosition*"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Plugins",
      "commentId": "N:Oxide.Plugins",
      "href": "Oxide.html",
      "name": "Oxide.Plugins",
      "nameWithType": "Oxide.Plugins",
      "fullName": "Oxide.Plugins",
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
          "uid": "Oxide.Plugins",
          "name": "Plugins",
          "isExternal": false,
          "href": "Oxide.Plugins.html"
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
          "uid": "Oxide.Plugins",
          "name": "Plugins",
          "isExternal": false,
          "href": "Oxide.Plugins.html"
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
      "uid": "Oxide.Core.Plugins.Plugin",
      "commentId": "T:Oxide.Core.Plugins.Plugin",
      "parent": "Oxide.Core.Plugins",
      "isExternal": true,
      "name": "Plugin",
      "nameWithType": "Plugin",
      "fullName": "Oxide.Core.Plugins.Plugin"
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin",
      "commentId": "T:Oxide.Core.Plugins.CSPlugin",
      "parent": "Oxide.Core.Plugins",
      "isExternal": true,
      "name": "CSPlugin",
      "nameWithType": "CSPlugin",
      "fullName": "Oxide.Core.Plugins.CSPlugin"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin",
      "commentId": "T:Oxide.Plugins.CSharpPlugin",
      "parent": "Oxide.Plugins",
      "isExternal": true,
      "name": "CSharpPlugin",
      "nameWithType": "CSharpPlugin",
      "fullName": "Oxide.Plugins.CSharpPlugin"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.Watcher",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.Watcher",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "Watcher",
      "nameWithType": "CSharpPlugin.Watcher",
      "fullName": "Oxide.Plugins.CSharpPlugin.Watcher"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.covalence",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.covalence",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "covalence",
      "nameWithType": "CSharpPlugin.covalence",
      "fullName": "Oxide.Plugins.CSharpPlugin.covalence"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.lang",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.lang",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "lang",
      "nameWithType": "CSharpPlugin.lang",
      "fullName": "Oxide.Plugins.CSharpPlugin.lang"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.plugins",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.plugins",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "plugins",
      "nameWithType": "CSharpPlugin.plugins",
      "fullName": "Oxide.Plugins.CSharpPlugin.plugins"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.permission",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.permission",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "permission",
      "nameWithType": "CSharpPlugin.permission",
      "fullName": "Oxide.Plugins.CSharpPlugin.permission"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.webrequest",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.webrequest",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "webrequest",
      "nameWithType": "CSharpPlugin.webrequest",
      "fullName": "Oxide.Plugins.CSharpPlugin.webrequest"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.timer",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.timer",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "timer",
      "nameWithType": "CSharpPlugin.timer",
      "fullName": "Oxide.Plugins.CSharpPlugin.timer"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.onlinePlayerFields",
      "commentId": "F:Oxide.Plugins.CSharpPlugin.onlinePlayerFields",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "onlinePlayerFields",
      "nameWithType": "CSharpPlugin.onlinePlayerFields",
      "fullName": "Oxide.Plugins.CSharpPlugin.onlinePlayerFields"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.SetPluginInfo(System.String,System.String)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.SetPluginInfo(System.String,System.String)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "SetPluginInfo(string, string)",
      "nameWithType": "CSharpPlugin.SetPluginInfo(string, string)",
      "fullName": "Oxide.Plugins.CSharpPlugin.SetPluginInfo(string, string)",
      "nameWithType.vb": "CSharpPlugin.SetPluginInfo(String, String)",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.SetPluginInfo(String, String)",
      "name.vb": "SetPluginInfo(String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.SetPluginInfo(System.String,System.String)",
          "name": "SetPluginInfo",
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
          "uid": "Oxide.Plugins.CSharpPlugin.SetPluginInfo(System.String,System.String)",
          "name": "SetPluginInfo",
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
      "uid": "Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "HandleRemovedFromManager(PluginManager)",
      "nameWithType": "CSharpPlugin.HandleRemovedFromManager(PluginManager)",
      "fullName": "Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
          "name": "HandleRemovedFromManager",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.PluginManager",
          "name": "PluginManager",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
          "name": "HandleRemovedFromManager",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.PluginManager",
          "name": "PluginManager",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.DirectCallHook(System.String,System.Object@,System.Object[])",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.DirectCallHook(System.String,System.Object@,System.Object[])",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "DirectCallHook(string, out object, object[])",
      "nameWithType": "CSharpPlugin.DirectCallHook(string, out object, object[])",
      "fullName": "Oxide.Plugins.CSharpPlugin.DirectCallHook(string, out object, object[])",
      "nameWithType.vb": "CSharpPlugin.DirectCallHook(String, Object, Object())",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.DirectCallHook(String, Object, Object())",
      "name.vb": "DirectCallHook(String, Object, Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.DirectCallHook(System.String,System.Object@,System.Object[])",
          "name": "DirectCallHook",
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
          "name": "out",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.DirectCallHook(System.String,System.Object@,System.Object[])",
          "name": "DirectCallHook",
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
      "uid": "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "InvokeMethod(HookMethod, object[])",
      "nameWithType": "CSharpPlugin.InvokeMethod(HookMethod, object[])",
      "fullName": "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod, object[])",
      "nameWithType.vb": "CSharpPlugin.InvokeMethod(HookMethod, Object())",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod, Object())",
      "name.vb": "InvokeMethod(HookMethod, Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
          "name": "InvokeMethod",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.HookMethod",
          "name": "HookMethod",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
          "name": "InvokeMethod",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.HookMethod",
          "name": "HookMethod",
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
      "uid": "Oxide.Plugins.CSharpPlugin.SetFailState(System.String)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.SetFailState(System.String)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "SetFailState(string)",
      "nameWithType": "CSharpPlugin.SetFailState(string)",
      "fullName": "Oxide.Plugins.CSharpPlugin.SetFailState(string)",
      "nameWithType.vb": "CSharpPlugin.SetFailState(String)",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.SetFailState(String)",
      "name.vb": "SetFailState(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.SetFailState(System.String)",
          "name": "SetFailState",
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
          "uid": "Oxide.Plugins.CSharpPlugin.SetFailState(System.String)",
          "name": "SetFailState",
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
      "uid": "Oxide.Plugins.CSharpPlugin.Puts(System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.Puts(System.String,System.Object[])",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Puts(string, params object[])",
      "nameWithType": "CSharpPlugin.Puts(string, params object[])",
      "fullName": "Oxide.Plugins.CSharpPlugin.Puts(string, params object[])",
      "nameWithType.vb": "CSharpPlugin.Puts(String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.Puts(String, ParamArray Object())",
      "name.vb": "Puts(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.Puts(System.String,System.Object[])",
          "name": "Puts",
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.Puts(System.String,System.Object[])",
          "name": "Puts",
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
          "name": "ParamArray",
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
      "uid": "Oxide.Plugins.CSharpPlugin.PrintWarning(System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.PrintWarning(System.String,System.Object[])",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "PrintWarning(string, params object[])",
      "nameWithType": "CSharpPlugin.PrintWarning(string, params object[])",
      "fullName": "Oxide.Plugins.CSharpPlugin.PrintWarning(string, params object[])",
      "nameWithType.vb": "CSharpPlugin.PrintWarning(String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.PrintWarning(String, ParamArray Object())",
      "name.vb": "PrintWarning(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.PrintWarning(System.String,System.Object[])",
          "name": "PrintWarning",
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.PrintWarning(System.String,System.Object[])",
          "name": "PrintWarning",
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
          "name": "ParamArray",
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
      "uid": "Oxide.Plugins.CSharpPlugin.PrintError(System.String,System.Object[])",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.PrintError(System.String,System.Object[])",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "PrintError(string, params object[])",
      "nameWithType": "CSharpPlugin.PrintError(string, params object[])",
      "fullName": "Oxide.Plugins.CSharpPlugin.PrintError(string, params object[])",
      "nameWithType.vb": "CSharpPlugin.PrintError(String, ParamArray Object())",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.PrintError(String, ParamArray Object())",
      "name.vb": "PrintError(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.PrintError(System.String,System.Object[])",
          "name": "PrintError",
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.PrintError(System.String,System.Object[])",
          "name": "PrintError",
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
          "name": "ParamArray",
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
      "uid": "Oxide.Plugins.CSharpPlugin.LogToFile(System.String,System.String,Oxide.Core.Plugins.Plugin,System.Boolean,System.Boolean)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.LogToFile(System.String,System.String,Oxide.Core.Plugins.Plugin,System.Boolean,System.Boolean)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "LogToFile(string, string, Plugin, bool, bool)",
      "nameWithType": "CSharpPlugin.LogToFile(string, string, Plugin, bool, bool)",
      "fullName": "Oxide.Plugins.CSharpPlugin.LogToFile(string, string, Oxide.Core.Plugins.Plugin, bool, bool)",
      "nameWithType.vb": "CSharpPlugin.LogToFile(String, String, Plugin, Boolean, Boolean)",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.LogToFile(String, String, Oxide.Core.Plugins.Plugin, Boolean, Boolean)",
      "name.vb": "LogToFile(String, String, Plugin, Boolean, Boolean)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.LogToFile(System.String,System.String,Oxide.Core.Plugins.Plugin,System.Boolean,System.Boolean)",
          "name": "LogToFile",
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
          "uid": "System.Boolean",
          "name": "bool",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.boolean"
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.LogToFile(System.String,System.String,Oxide.Core.Plugins.Plugin,System.Boolean,System.Boolean)",
          "name": "LogToFile",
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
          "uid": "System.Boolean",
          "name": "Boolean",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.boolean"
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
      "uid": "Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.action",
      "name": "NextFrame(Action)",
      "nameWithType": "CSharpPlugin.NextFrame(Action)",
      "fullName": "Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
          "name": "NextFrame",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.NextFrame(System.Action)",
          "name": "NextFrame",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.action",
      "name": "NextTick(Action)",
      "nameWithType": "CSharpPlugin.NextTick(Action)",
      "fullName": "Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
          "name": "NextTick",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.NextTick(System.Action)",
          "name": "NextTick",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action{System.Object})",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action{System.Object})",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.action-1",
      "name": "QueueWorkerThread(Action<object>)",
      "nameWithType": "CSharpPlugin.QueueWorkerThread(Action<object>)",
      "fullName": "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action<object>)",
      "nameWithType.vb": "CSharpPlugin.QueueWorkerThread(Action(Of Object))",
      "fullName.vb": "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action(Of Object))",
      "name.vb": "QueueWorkerThread(Action(Of Object))",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action{System.Object})",
          "name": "QueueWorkerThread",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action`1",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-1"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "System.Object",
          "name": "object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
        },
        {
          "name": ">",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.QueueWorkerThread(System.Action{System.Object})",
          "name": "QueueWorkerThread",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "System.Action`1",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-1"
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
          "uid": "System.Object",
          "name": "Object",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.object"
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
      "uid": "Oxide.Plugins.CSharpPlugin.HookedOnFrame",
      "commentId": "P:Oxide.Plugins.CSharpPlugin.HookedOnFrame",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "HookedOnFrame",
      "nameWithType": "CSharpPlugin.HookedOnFrame",
      "fullName": "Oxide.Plugins.CSharpPlugin.HookedOnFrame"
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin.Hooks",
      "commentId": "F:Oxide.Core.Plugins.CSPlugin.Hooks",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "name": "Hooks",
      "nameWithType": "CSPlugin.Hooks",
      "fullName": "Oxide.Core.Plugins.CSPlugin.Hooks"
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin.HooksCache",
      "commentId": "F:Oxide.Core.Plugins.CSPlugin.HooksCache",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "name": "HooksCache",
      "nameWithType": "CSPlugin.HooksCache",
      "fullName": "Oxide.Core.Plugins.CSPlugin.HooksCache"
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetLibrary<T>(string)",
      "nameWithType": "CSPlugin.GetLibrary<T>(string)",
      "fullName": "Oxide.Core.Plugins.CSPlugin.GetLibrary<T>(string)",
      "nameWithType.vb": "CSPlugin.GetLibrary(Of T)(String)",
      "fullName.vb": "Oxide.Core.Plugins.CSPlugin.GetLibrary(Of T)(String)",
      "name.vb": "GetLibrary(Of T)(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
          "name": "GetLibrary",
          "isExternal": true
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
          "name": ">",
          "isExternal": false
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
          "uid": "Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
          "name": "GetLibrary",
          "isExternal": true
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
          "name": ")",
          "isExternal": false
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
      "uid": "Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddHookMethod(string, MethodInfo)",
      "nameWithType": "CSPlugin.AddHookMethod(string, MethodInfo)",
      "fullName": "Oxide.Core.Plugins.CSPlugin.AddHookMethod(string, System.Reflection.MethodInfo)",
      "nameWithType.vb": "CSPlugin.AddHookMethod(String, MethodInfo)",
      "fullName.vb": "Oxide.Core.Plugins.CSPlugin.AddHookMethod(String, System.Reflection.MethodInfo)",
      "name.vb": "AddHookMethod(String, MethodInfo)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
          "name": "AddHookMethod",
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
          "uid": "System.Reflection.MethodInfo",
          "name": "MethodInfo",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.reflection.methodinfo"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
          "name": "AddHookMethod",
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
          "uid": "System.Reflection.MethodInfo",
          "name": "MethodInfo",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.reflection.methodinfo"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "OnCallHook(string, object[])",
      "nameWithType": "CSPlugin.OnCallHook(string, object[])",
      "fullName": "Oxide.Core.Plugins.CSPlugin.OnCallHook(string, object[])",
      "nameWithType.vb": "CSPlugin.OnCallHook(String, Object())",
      "fullName.vb": "Oxide.Core.Plugins.CSPlugin.OnCallHook(String, Object())",
      "name.vb": "OnCallHook(String, Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
          "name": "OnCallHook",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
          "name": "OnCallHook",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "FindHooks(string, object[])",
      "nameWithType": "CSPlugin.FindHooks(string, object[])",
      "fullName": "Oxide.Core.Plugins.CSPlugin.FindHooks(string, object[])",
      "nameWithType.vb": "CSPlugin.FindHooks(String, Object())",
      "fullName.vb": "Oxide.Core.Plugins.CSPlugin.FindHooks(String, Object())",
      "name.vb": "FindHooks(String, Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
          "name": "FindHooks",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
          "name": "FindHooks",
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
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.OnAddedToManager",
      "commentId": "F:Oxide.Core.Plugins.Plugin.OnAddedToManager",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "OnAddedToManager",
      "nameWithType": "Plugin.OnAddedToManager",
      "fullName": "Oxide.Core.Plugins.Plugin.OnAddedToManager"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.OnRemovedFromManager",
      "commentId": "F:Oxide.Core.Plugins.Plugin.OnRemovedFromManager",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "OnRemovedFromManager",
      "nameWithType": "Plugin.OnRemovedFromManager",
      "fullName": "Oxide.Core.Plugins.Plugin.OnRemovedFromManager"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.nestcount",
      "commentId": "F:Oxide.Core.Plugins.Plugin.nestcount",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "nestcount",
      "nameWithType": "Plugin.nestcount",
      "fullName": "Oxide.Core.Plugins.Plugin.nestcount"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Subscribe(string)",
      "nameWithType": "Plugin.Subscribe(string)",
      "fullName": "Oxide.Core.Plugins.Plugin.Subscribe(string)",
      "nameWithType.vb": "Plugin.Subscribe(String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.Subscribe(String)",
      "name.vb": "Subscribe(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
          "name": "Subscribe",
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
          "uid": "Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
          "name": "Subscribe",
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
      "uid": "Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Unsubscribe(string)",
      "nameWithType": "Plugin.Unsubscribe(string)",
      "fullName": "Oxide.Core.Plugins.Plugin.Unsubscribe(string)",
      "nameWithType.vb": "Plugin.Unsubscribe(String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.Unsubscribe(String)",
      "name.vb": "Unsubscribe(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
          "name": "Unsubscribe",
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
          "uid": "Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
          "name": "Unsubscribe",
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
      "uid": "Oxide.Core.Plugins.Plugin.Load",
      "commentId": "M:Oxide.Core.Plugins.Plugin.Load",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Load()",
      "nameWithType": "Plugin.Load()",
      "fullName": "Oxide.Core.Plugins.Plugin.Load()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Load",
          "name": "Load",
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
          "uid": "Oxide.Core.Plugins.Plugin.Load",
          "name": "Load",
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
      "uid": "Oxide.Core.Plugins.Plugin.CallHook(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.Plugin.CallHook(System.String,System.Object[])",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "CallHook(string, params object[])",
      "nameWithType": "Plugin.CallHook(string, params object[])",
      "fullName": "Oxide.Core.Plugins.Plugin.CallHook(string, params object[])",
      "nameWithType.vb": "Plugin.CallHook(String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.CallHook(String, ParamArray Object())",
      "name.vb": "CallHook(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.CallHook(System.String,System.Object[])",
          "name": "CallHook",
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.CallHook(System.String,System.Object[])",
          "name": "CallHook",
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
          "name": "ParamArray",
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
      "uid": "Oxide.Core.Plugins.Plugin.Call(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.Plugin.Call(System.String,System.Object[])",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Call(string, params object[])",
      "nameWithType": "Plugin.Call(string, params object[])",
      "fullName": "Oxide.Core.Plugins.Plugin.Call(string, params object[])",
      "nameWithType.vb": "Plugin.Call(String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.Call(String, ParamArray Object())",
      "name.vb": "Call(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Call(System.String,System.Object[])",
          "name": "Call",
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Call(System.String,System.Object[])",
          "name": "Call",
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
          "name": "ParamArray",
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
      "uid": "Oxide.Core.Plugins.Plugin.Call``1(System.String,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.Plugin.Call``1(System.String,System.Object[])",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Call<T>(string, params object[])",
      "nameWithType": "Plugin.Call<T>(string, params object[])",
      "fullName": "Oxide.Core.Plugins.Plugin.Call<T>(string, params object[])",
      "nameWithType.vb": "Plugin.Call(Of T)(String, ParamArray Object())",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.Call(Of T)(String, ParamArray Object())",
      "name.vb": "Call(Of T)(String, ParamArray Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Call``1(System.String,System.Object[])",
          "name": "Call",
          "isExternal": true
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
          "name": ">",
          "isExternal": false
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
          "name": "params",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
          "isExternal": false
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.Call``1(System.String,System.Object[])",
          "name": "Call",
          "isExternal": true
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
          "name": ")",
          "isExternal": false
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
          "name": "ParamArray",
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
      "uid": "Oxide.Core.Plugins.Plugin.RaiseError(System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.RaiseError(System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "RaiseError(string)",
      "nameWithType": "Plugin.RaiseError(string)",
      "fullName": "Oxide.Core.Plugins.Plugin.RaiseError(string)",
      "nameWithType.vb": "Plugin.RaiseError(String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.RaiseError(String)",
      "name.vb": "RaiseError(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.RaiseError(System.String)",
          "name": "RaiseError",
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
          "uid": "Oxide.Core.Plugins.Plugin.RaiseError(System.String)",
          "name": "RaiseError",
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
      "uid": "Oxide.Core.Plugins.Plugin.TrackStart",
      "commentId": "M:Oxide.Core.Plugins.Plugin.TrackStart",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "TrackStart()",
      "nameWithType": "Plugin.TrackStart()",
      "fullName": "Oxide.Core.Plugins.Plugin.TrackStart()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.TrackStart",
          "name": "TrackStart",
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
          "uid": "Oxide.Core.Plugins.Plugin.TrackStart",
          "name": "TrackStart",
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
      "uid": "Oxide.Core.Plugins.Plugin.TrackEnd",
      "commentId": "M:Oxide.Core.Plugins.Plugin.TrackEnd",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "TrackEnd()",
      "nameWithType": "Plugin.TrackEnd()",
      "fullName": "Oxide.Core.Plugins.Plugin.TrackEnd()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.TrackEnd",
          "name": "TrackEnd",
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
          "uid": "Oxide.Core.Plugins.Plugin.TrackEnd",
          "name": "TrackEnd",
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
      "uid": "Oxide.Core.Plugins.Plugin.LoadConfig",
      "commentId": "M:Oxide.Core.Plugins.Plugin.LoadConfig",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "LoadConfig()",
      "nameWithType": "Plugin.LoadConfig()",
      "fullName": "Oxide.Core.Plugins.Plugin.LoadConfig()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.LoadConfig",
          "name": "LoadConfig",
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
          "uid": "Oxide.Core.Plugins.Plugin.LoadConfig",
          "name": "LoadConfig",
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
      "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultConfig",
      "commentId": "M:Oxide.Core.Plugins.Plugin.LoadDefaultConfig",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "LoadDefaultConfig()",
      "nameWithType": "Plugin.LoadDefaultConfig()",
      "fullName": "Oxide.Core.Plugins.Plugin.LoadDefaultConfig()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultConfig",
          "name": "LoadDefaultConfig",
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
          "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultConfig",
          "name": "LoadDefaultConfig",
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
      "uid": "Oxide.Core.Plugins.Plugin.SaveConfig",
      "commentId": "M:Oxide.Core.Plugins.Plugin.SaveConfig",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "SaveConfig()",
      "nameWithType": "Plugin.SaveConfig()",
      "fullName": "Oxide.Core.Plugins.Plugin.SaveConfig()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.SaveConfig",
          "name": "SaveConfig",
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
          "uid": "Oxide.Core.Plugins.Plugin.SaveConfig",
          "name": "SaveConfig",
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
      "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultMessages",
      "commentId": "M:Oxide.Core.Plugins.Plugin.LoadDefaultMessages",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "LoadDefaultMessages()",
      "nameWithType": "Plugin.LoadDefaultMessages()",
      "fullName": "Oxide.Core.Plugins.Plugin.LoadDefaultMessages()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultMessages",
          "name": "LoadDefaultMessages",
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
          "uid": "Oxide.Core.Plugins.Plugin.LoadDefaultMessages",
          "name": "LoadDefaultMessages",
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
      "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String,System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String,System.String,System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddUniversalCommand(string, string, string)",
      "nameWithType": "Plugin.AddUniversalCommand(string, string, string)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(string, string, string)",
      "nameWithType.vb": "Plugin.AddUniversalCommand(String, String, String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(String, String, String)",
      "name.vb": "AddUniversalCommand(String, String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String,System.String,System.String)",
          "name": "AddUniversalCommand",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String,System.String,System.String)",
          "name": "AddUniversalCommand",
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
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String,System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String,System.String,System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddCovalenceCommand(string, string, string)",
      "nameWithType": "Plugin.AddCovalenceCommand(string, string, string)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(string, string, string)",
      "nameWithType.vb": "Plugin.AddCovalenceCommand(String, String, String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(String, String, String)",
      "name.vb": "AddCovalenceCommand(String, String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String,System.String,System.String)",
          "name": "AddCovalenceCommand",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String,System.String,System.String)",
          "name": "AddCovalenceCommand",
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
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddUniversalCommand(string[], string, string)",
      "nameWithType": "Plugin.AddUniversalCommand(string[], string, string)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(string[], string, string)",
      "nameWithType.vb": "Plugin.AddUniversalCommand(String(), String, String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(String(), String, String)",
      "name.vb": "AddUniversalCommand(String(), String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String)",
          "name": "AddUniversalCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String)",
          "name": "AddUniversalCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddCovalenceCommand(string[], string, string)",
      "nameWithType": "Plugin.AddCovalenceCommand(string[], string, string)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(string[], string, string)",
      "nameWithType.vb": "Plugin.AddCovalenceCommand(String(), String, String)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(String(), String, String)",
      "name.vb": "AddCovalenceCommand(String(), String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String)",
          "name": "AddCovalenceCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String)",
          "name": "AddCovalenceCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String[])",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String[])",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddUniversalCommand(string[], string, string[])",
      "nameWithType": "Plugin.AddUniversalCommand(string[], string, string[])",
      "fullName": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(string[], string, string[])",
      "nameWithType.vb": "Plugin.AddUniversalCommand(String(), String, String())",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(String(), String, String())",
      "name.vb": "AddUniversalCommand(String(), String, String())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String[])",
          "name": "AddUniversalCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String,System.String[])",
          "name": "AddUniversalCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
      "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String[])",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String[])",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddCovalenceCommand(string[], string, string[])",
      "nameWithType": "Plugin.AddCovalenceCommand(string[], string, string[])",
      "fullName": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(string[], string, string[])",
      "nameWithType.vb": "Plugin.AddCovalenceCommand(String(), String, String())",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(String(), String, String())",
      "name.vb": "AddCovalenceCommand(String(), String, String())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String[])",
          "name": "AddCovalenceCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String,System.String[])",
          "name": "AddCovalenceCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
      "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddUniversalCommand(string[], string[], CommandCallback)",
      "nameWithType": "Plugin.AddUniversalCommand(string[], string[], CommandCallback)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(string[], string[], Oxide.Core.Libraries.Covalence.CommandCallback)",
      "nameWithType.vb": "Plugin.AddUniversalCommand(String(), String(), CommandCallback)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(String(), String(), Oxide.Core.Libraries.Covalence.CommandCallback)",
      "name.vb": "AddUniversalCommand(String(), String(), CommandCallback)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "AddUniversalCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "uid": "Oxide.Core.Plugins.Plugin.AddUniversalCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "AddUniversalCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
      "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "AddCovalenceCommand(string[], string[], CommandCallback)",
      "nameWithType": "Plugin.AddCovalenceCommand(string[], string[], CommandCallback)",
      "fullName": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(string[], string[], Oxide.Core.Libraries.Covalence.CommandCallback)",
      "nameWithType.vb": "Plugin.AddCovalenceCommand(String(), String(), CommandCallback)",
      "fullName.vb": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(String(), String(), Oxide.Core.Libraries.Covalence.CommandCallback)",
      "name.vb": "AddCovalenceCommand(String(), String(), CommandCallback)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "AddCovalenceCommand",
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
          "name": "[",
          "isExternal": false
        },
        {
          "name": "]",
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
          "uid": "Oxide.Core.Plugins.Plugin.AddCovalenceCommand(System.String[],System.String[],Oxide.Core.Libraries.Covalence.CommandCallback)",
          "name": "AddCovalenceCommand",
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
          "name": "(",
          "isExternal": false
        },
        {
          "name": ")",
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
      "uid": "Oxide.Core.Plugins.Plugin.Filename",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Filename",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Filename",
      "nameWithType": "Plugin.Filename",
      "fullName": "Oxide.Core.Plugins.Plugin.Filename"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Name",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Name",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Name",
      "nameWithType": "Plugin.Name",
      "fullName": "Oxide.Core.Plugins.Plugin.Name"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Title",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Title",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Title",
      "nameWithType": "Plugin.Title",
      "fullName": "Oxide.Core.Plugins.Plugin.Title"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Description",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Description",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Description",
      "nameWithType": "Plugin.Description",
      "fullName": "Oxide.Core.Plugins.Plugin.Description"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Author",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Author",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Author",
      "nameWithType": "Plugin.Author",
      "fullName": "Oxide.Core.Plugins.Plugin.Author"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Version",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Version",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Version",
      "nameWithType": "Plugin.Version",
      "fullName": "Oxide.Core.Plugins.Plugin.Version"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.ResourceId",
      "commentId": "P:Oxide.Core.Plugins.Plugin.ResourceId",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "ResourceId",
      "nameWithType": "Plugin.ResourceId",
      "fullName": "Oxide.Core.Plugins.Plugin.ResourceId"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Manager",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Manager",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Manager",
      "nameWithType": "Plugin.Manager",
      "fullName": "Oxide.Core.Plugins.Plugin.Manager"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.HasConfig",
      "commentId": "P:Oxide.Core.Plugins.Plugin.HasConfig",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "HasConfig",
      "nameWithType": "Plugin.HasConfig",
      "fullName": "Oxide.Core.Plugins.Plugin.HasConfig"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.HasMessages",
      "commentId": "P:Oxide.Core.Plugins.Plugin.HasMessages",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "HasMessages",
      "nameWithType": "Plugin.HasMessages",
      "fullName": "Oxide.Core.Plugins.Plugin.HasMessages"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.IsCorePlugin",
      "commentId": "P:Oxide.Core.Plugins.Plugin.IsCorePlugin",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "IsCorePlugin",
      "nameWithType": "Plugin.IsCorePlugin",
      "fullName": "Oxide.Core.Plugins.Plugin.IsCorePlugin"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Loader",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Loader",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Loader",
      "nameWithType": "Plugin.Loader",
      "fullName": "Oxide.Core.Plugins.Plugin.Loader"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Object",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Object",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Object",
      "nameWithType": "Plugin.Object",
      "fullName": "Oxide.Core.Plugins.Plugin.Object"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.Config",
      "commentId": "P:Oxide.Core.Plugins.Plugin.Config",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "Config",
      "nameWithType": "Plugin.Config",
      "fullName": "Oxide.Core.Plugins.Plugin.Config"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.IsLoaded",
      "commentId": "P:Oxide.Core.Plugins.Plugin.IsLoaded",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "IsLoaded",
      "nameWithType": "Plugin.IsLoaded",
      "fullName": "Oxide.Core.Plugins.Plugin.IsLoaded"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.TotalHookTime",
      "commentId": "P:Oxide.Core.Plugins.Plugin.TotalHookTime",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "TotalHookTime",
      "nameWithType": "Plugin.TotalHookTime",
      "fullName": "Oxide.Core.Plugins.Plugin.TotalHookTime"
    },
    {
      "uid": "Oxide.Core.Plugins.Plugin.OnError",
      "commentId": "E:Oxide.Core.Plugins.Plugin.OnError",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "OnError",
      "nameWithType": "Plugin.OnError",
      "fullName": "Oxide.Core.Plugins.Plugin.OnError"
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
      "uid": "Oxide.Game.Rust.Libraries.Command",
      "commentId": "T:Oxide.Game.Rust.Libraries.Command",
      "parent": "Oxide.Game.Rust.Libraries",
      "href": "Oxide.Game.Rust.Libraries.Command.html",
      "name": "Command",
      "nameWithType": "Command",
      "fullName": "Oxide.Game.Rust.Libraries.Command"
    },
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
      "uid": "Oxide.Game.Rust.Libraries.Rust",
      "commentId": "T:Oxide.Game.Rust.Libraries.Rust",
      "parent": "Oxide.Game.Rust.Libraries",
      "href": "Oxide.Game.Rust.Libraries.Rust.html",
      "name": "Rust",
      "nameWithType": "Rust",
      "fullName": "Oxide.Game.Rust.Libraries.Rust"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Item",
      "commentId": "T:Oxide.Game.Rust.Libraries.Item",
      "parent": "Oxide.Game.Rust.Libraries",
      "href": "Oxide.Game.Rust.Libraries.Item.html",
      "name": "Item",
      "nameWithType": "Item",
      "fullName": "Oxide.Game.Rust.Libraries.Item"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Player",
      "commentId": "T:Oxide.Game.Rust.Libraries.Player",
      "parent": "Oxide.Game.Rust.Libraries",
      "href": "Oxide.Game.Rust.Libraries.Player.html",
      "name": "Player",
      "nameWithType": "Player",
      "fullName": "Oxide.Game.Rust.Libraries.Player"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Server",
      "commentId": "T:Oxide.Game.Rust.Libraries.Server",
      "parent": "Oxide.Game.Rust.Libraries",
      "href": "Oxide.Game.Rust.Libraries.Server.html",
      "name": "Server",
      "nameWithType": "Server",
      "fullName": "Oxide.Game.Rust.Libraries.Server"
    },
    {
      "uid": "Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "commentId": "M:Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "parent": "Oxide.Plugins.CSharpPlugin",
      "isExternal": true,
      "name": "HandleAddedToManager(PluginManager)",
      "nameWithType": "CSharpPlugin.HandleAddedToManager(PluginManager)",
      "fullName": "Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "spec.csharp": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
          "name": "HandleAddedToManager",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.PluginManager",
          "name": "PluginManager",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Plugins.CSharpPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
          "name": "HandleAddedToManager",
          "isExternal": true
        },
        {
          "name": "(",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.Plugins.PluginManager",
          "name": "PluginManager",
          "isExternal": true
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.HandleAddedToManager*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.HandleAddedToManager",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "name": "HandleAddedToManager",
      "nameWithType": "RustPlugin.HandleAddedToManager",
      "fullName": "Oxide.Plugins.RustPlugin.HandleAddedToManager"
    },
    {
      "uid": "Oxide.Core.Plugins.PluginManager",
      "commentId": "T:Oxide.Core.Plugins.PluginManager",
      "parent": "Oxide.Core.Plugins",
      "isExternal": true,
      "name": "PluginManager",
      "nameWithType": "PluginManager",
      "fullName": "Oxide.Core.Plugins.PluginManager"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.PrintToConsole*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.PrintToConsole",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.PrintToConsole(BasePlayer,System.String,System.Object[])",
      "name": "PrintToConsole",
      "nameWithType": "RustPlugin.PrintToConsole",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToConsole"
    },
    {
      "uid": "BasePlayer",
      "commentId": "T:BasePlayer",
      "isExternal": true,
      "name": "BasePlayer",
      "nameWithType": "BasePlayer",
      "fullName": "BasePlayer"
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
      "uid": "Oxide.Plugins.RustPlugin.PrintToChat*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.PrintToChat",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.PrintToChat(BasePlayer,System.String,System.Object[])",
      "name": "PrintToChat",
      "nameWithType": "RustPlugin.PrintToChat",
      "fullName": "Oxide.Plugins.RustPlugin.PrintToChat"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendReply*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.SendReply",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.SendReply(ConsoleSystem.Arg,System.String,System.Object[])",
      "name": "SendReply",
      "nameWithType": "RustPlugin.SendReply",
      "fullName": "Oxide.Plugins.RustPlugin.SendReply"
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
      "uid": "Oxide.Plugins.RustPlugin.SendWarning*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.SendWarning",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.SendWarning(ConsoleSystem.Arg,System.String,System.Object[])",
      "name": "SendWarning",
      "nameWithType": "RustPlugin.SendWarning",
      "fullName": "Oxide.Plugins.RustPlugin.SendWarning"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.SendError*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.SendError",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.SendError(ConsoleSystem.Arg,System.String,System.Object[])",
      "name": "SendError",
      "nameWithType": "RustPlugin.SendError",
      "fullName": "Oxide.Plugins.RustPlugin.SendError"
    },
    {
      "uid": "Oxide.Plugins.RustPlugin.ForcePlayerPosition*",
      "commentId": "Overload:Oxide.Plugins.RustPlugin.ForcePlayerPosition",
      "href": "Oxide.Plugins.RustPlugin.html#Oxide.Plugins.RustPlugin.ForcePlayerPosition(BasePlayer,UnityEngine.Vector3)",
      "name": "ForcePlayerPosition",
      "nameWithType": "RustPlugin.ForcePlayerPosition",
      "fullName": "Oxide.Plugins.RustPlugin.ForcePlayerPosition"
    },
    {
      "uid": "UnityEngine.Vector3",
      "commentId": "T:UnityEngine.Vector3",
      "parent": "UnityEngine",
      "isExternal": true,
      "name": "Vector3",
      "nameWithType": "Vector3",
      "fullName": "UnityEngine.Vector3"
    },
    {
      "uid": "UnityEngine",
      "commentId": "N:UnityEngine",
      "isExternal": true,
      "name": "UnityEngine",
      "nameWithType": "UnityEngine",
      "fullName": "UnityEngine"
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