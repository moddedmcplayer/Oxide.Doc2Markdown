# Class RustCore
Namespace: [Oxide.Game.Rust](Oxide.Game.Rust.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustCore : CSPlugin
```  
#### Game commands for the core Rust plugin


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Plugins.Plugin, Oxide.Core.Plugins.CSPlugin  
#### Inherited Members
Hooks, HooksCache, GetLibrary``1, HandleAddedToManager, AddHookMethod, OnCallHook, FindHooks, InvokeMethod, OnAddedToManager, OnRemovedFromManager, nestcount, Subscribe, Unsubscribe, HandleRemovedFromManager, Load, CallHook, Call, Call``1, RaiseError, TrackStart, TrackEnd, LoadConfig, LoadDefaultConfig, SaveConfig, LoadDefaultMessages, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, AddUniversalCommand, AddCovalenceCommand, Filename, Name, Title, Description, Author, Version, ResourceId, Manager, HasConfig, HasMessages, IsCorePlugin, Loader, Object, Config, IsLoaded, TotalHookTime, OnError, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Constructors 
```csharp
public RustCore()
```
RustCore()
## Methods 
```csharp
public static BasePlayer FindPlayer(string nameOrIdOrIp)
```
FindPlayer(string)
```csharp
public static BasePlayer FindPlayerByName(string name)
```
FindPlayerByName(string)
```csharp
public static BasePlayer FindPlayerById(ulong id)
```
FindPlayerById(ulong)
```csharp
public static BasePlayer FindPlayerByIdString(string id)
```
FindPlayerByIdString(string)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.RustCore",
      "commentId": "T:Oxide.Game.Rust.RustCore",
      "id": "RustCore",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust",
      "children": [
        "Oxide.Game.Rust.RustCore.#ctor",
        "Oxide.Game.Rust.RustCore.FindPlayer(System.String)",
        "Oxide.Game.Rust.RustCore.FindPlayerById(System.UInt64)",
        "Oxide.Game.Rust.RustCore.FindPlayerByIdString(System.String)",
        "Oxide.Game.Rust.RustCore.FindPlayerByName(System.String)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCore",
      "nameWithType": "RustCore",
      "fullName": "Oxide.Game.Rust.RustCore",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustHooks.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustCore",
        "path": "../../../../../../../Oxide.Rust/src/RustHooks.cs",
        "startLine": 24,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Game commands for the core Rust plugin",
      "example": [],
      "syntax": {
        "content": "public class RustCore : CSPlugin",
        "content.vb": "Public Class RustCore Inherits CSPlugin"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Plugins.Plugin",
        "Oxide.Core.Plugins.CSPlugin"
      ],
      "inheritedMembers": [
        "Oxide.Core.Plugins.CSPlugin.Hooks",
        "Oxide.Core.Plugins.CSPlugin.HooksCache",
        "Oxide.Core.Plugins.CSPlugin.GetLibrary``1(System.String)",
        "Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
        "Oxide.Core.Plugins.CSPlugin.AddHookMethod(System.String,System.Reflection.MethodInfo)",
        "Oxide.Core.Plugins.CSPlugin.OnCallHook(System.String,System.Object[])",
        "Oxide.Core.Plugins.CSPlugin.FindHooks(System.String,System.Object[])",
        "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
        "Oxide.Core.Plugins.Plugin.OnAddedToManager",
        "Oxide.Core.Plugins.Plugin.OnRemovedFromManager",
        "Oxide.Core.Plugins.Plugin.nestcount",
        "Oxide.Core.Plugins.Plugin.Subscribe(System.String)",
        "Oxide.Core.Plugins.Plugin.Unsubscribe(System.String)",
        "Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
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
      "uid": "Oxide.Game.Rust.RustCore.#ctor",
      "commentId": "M:Oxide.Game.Rust.RustCore.#ctor",
      "id": "#ctor",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustCore",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustCore()",
      "nameWithType": "RustCore.RustCore()",
      "fullName": "Oxide.Game.Rust.RustCore.RustCore()",
      "type": "constructor",
      "source": {
        "remote": {
          "path": "src/RustCore.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": ".ctor",
        "path": "../../../../../../../Oxide.Rust/src/RustCore.cs",
        "startLine": 25,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Initializes a new instance of the RustCore class",
      "example": [],
      "syntax": {
        "content": "public RustCore()",
        "content.vb": "Public Sub New()"
      },
      "overload": "Oxide.Game.Rust.RustCore.#ctor*",
      "nameWithType.vb": "RustCore.New()",
      "fullName.vb": "Oxide.Game.Rust.RustCore.New()",
      "name.vb": "New()"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayer(System.String)",
      "commentId": "M:Oxide.Game.Rust.RustCore.FindPlayer(System.String)",
      "id": "FindPlayer(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustCore",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayer(string)",
      "nameWithType": "RustCore.FindPlayer(string)",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayer(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCore.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayer",
        "path": "../../../../../../../Oxide.Rust/src/RustCore.cs",
        "startLine": 272,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Returns the BasePlayer for the specified name, ID, or IP address string",
      "example": [],
      "syntax": {
        "content": "public static BasePlayer FindPlayer(string nameOrIdOrIp)",
        "parameters": [
          {
            "id": "nameOrIdOrIp",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Shared Function FindPlayer(nameOrIdOrIp As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.RustCore.FindPlayer*",
      "nameWithType.vb": "RustCore.FindPlayer(String)",
      "fullName.vb": "Oxide.Game.Rust.RustCore.FindPlayer(String)",
      "name.vb": "FindPlayer(String)"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerByName(System.String)",
      "commentId": "M:Oxide.Game.Rust.RustCore.FindPlayerByName(System.String)",
      "id": "FindPlayerByName(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustCore",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerByName(string)",
      "nameWithType": "RustCore.FindPlayerByName(string)",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerByName(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCore.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerByName",
        "path": "../../../../../../../Oxide.Rust/src/RustCore.cs",
        "startLine": 347,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Returns the BasePlayer for the specified name string",
      "example": [],
      "syntax": {
        "content": "public static BasePlayer FindPlayerByName(string name)",
        "parameters": [
          {
            "id": "name",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Shared Function FindPlayerByName(name As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.RustCore.FindPlayerByName*",
      "nameWithType.vb": "RustCore.FindPlayerByName(String)",
      "fullName.vb": "Oxide.Game.Rust.RustCore.FindPlayerByName(String)",
      "name.vb": "FindPlayerByName(String)"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerById(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.RustCore.FindPlayerById(System.UInt64)",
      "id": "FindPlayerById(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustCore",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerById(ulong)",
      "nameWithType": "RustCore.FindPlayerById(ulong)",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerById(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCore.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerById",
        "path": "../../../../../../../Oxide.Rust/src/RustCore.cs",
        "startLine": 392,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Returns the BasePlayer for the specified ID ulong",
      "example": [],
      "syntax": {
        "content": "public static BasePlayer FindPlayerById(ulong id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.UInt64",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Shared Function FindPlayerById(id As ULong) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.RustCore.FindPlayerById*",
      "nameWithType.vb": "RustCore.FindPlayerById(ULong)",
      "fullName.vb": "Oxide.Game.Rust.RustCore.FindPlayerById(ULong)",
      "name.vb": "FindPlayerById(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerByIdString(System.String)",
      "commentId": "M:Oxide.Game.Rust.RustCore.FindPlayerByIdString(System.String)",
      "id": "FindPlayerByIdString(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustCore",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerByIdString(string)",
      "nameWithType": "RustCore.FindPlayerByIdString(string)",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerByIdString(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustCore.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerByIdString",
        "path": "../../../../../../../Oxide.Rust/src/RustCore.cs",
        "startLine": 416,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Returns the BasePlayer for the specified ID string",
      "example": [],
      "syntax": {
        "content": "public static BasePlayer FindPlayerByIdString(string id)",
        "parameters": [
          {
            "id": "id",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "BasePlayer",
          "description": ""
        },
        "content.vb": "Public Shared Function FindPlayerByIdString(id As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.RustCore.FindPlayerByIdString*",
      "nameWithType.vb": "RustCore.FindPlayerByIdString(String)",
      "fullName.vb": "Oxide.Game.Rust.RustCore.FindPlayerByIdString(String)",
      "name.vb": "FindPlayerByIdString(String)"
    }
  ],
  "references": [
    {
      "uid": "Oxide.Game.Rust",
      "commentId": "N:Oxide.Game.Rust",
      "href": "Oxide.html",
      "name": "Oxide.Game.Rust",
      "nameWithType": "Oxide.Game.Rust",
      "fullName": "Oxide.Game.Rust",
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
      "uid": "Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "name": "HandleAddedToManager(PluginManager)",
      "nameWithType": "CSPlugin.HandleAddedToManager(PluginManager)",
      "fullName": "Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
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
          "uid": "Oxide.Core.Plugins.CSPlugin.HandleAddedToManager(Oxide.Core.Plugins.PluginManager)",
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
      "uid": "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
      "commentId": "M:Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
      "parent": "Oxide.Core.Plugins.CSPlugin",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.object",
      "name": "InvokeMethod(HookMethod, object[])",
      "nameWithType": "CSPlugin.InvokeMethod(HookMethod, object[])",
      "fullName": "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod, object[])",
      "nameWithType.vb": "CSPlugin.InvokeMethod(HookMethod, Object())",
      "fullName.vb": "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod, Object())",
      "name.vb": "InvokeMethod(HookMethod, Object())",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
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
          "uid": "Oxide.Core.Plugins.CSPlugin.InvokeMethod(Oxide.Core.Plugins.HookMethod,System.Object[])",
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
      "uid": "Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "commentId": "M:Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "parent": "Oxide.Core.Plugins.Plugin",
      "isExternal": true,
      "name": "HandleRemovedFromManager(PluginManager)",
      "nameWithType": "Plugin.HandleRemovedFromManager(PluginManager)",
      "fullName": "Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
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
          "uid": "Oxide.Core.Plugins.Plugin.HandleRemovedFromManager(Oxide.Core.Plugins.PluginManager)",
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
      "uid": "Oxide.Game.Rust.RustCore.#ctor*",
      "commentId": "Overload:Oxide.Game.Rust.RustCore.#ctor",
      "href": "Oxide.Game.Rust.RustCore.html#Oxide.Game.Rust.RustCore.#ctor",
      "name": "RustCore",
      "nameWithType": "RustCore.RustCore",
      "fullName": "Oxide.Game.Rust.RustCore.RustCore",
      "nameWithType.vb": "RustCore.New",
      "fullName.vb": "Oxide.Game.Rust.RustCore.New",
      "name.vb": "New"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayer*",
      "commentId": "Overload:Oxide.Game.Rust.RustCore.FindPlayer",
      "href": "Oxide.Game.Rust.RustCore.html#Oxide.Game.Rust.RustCore.FindPlayer(System.String)",
      "name": "FindPlayer",
      "nameWithType": "RustCore.FindPlayer",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayer"
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
      "uid": "BasePlayer",
      "commentId": "T:BasePlayer",
      "isExternal": true,
      "name": "BasePlayer",
      "nameWithType": "BasePlayer",
      "fullName": "BasePlayer"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerByName*",
      "commentId": "Overload:Oxide.Game.Rust.RustCore.FindPlayerByName",
      "href": "Oxide.Game.Rust.RustCore.html#Oxide.Game.Rust.RustCore.FindPlayerByName(System.String)",
      "name": "FindPlayerByName",
      "nameWithType": "RustCore.FindPlayerByName",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerByName"
    },
    {
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerById*",
      "commentId": "Overload:Oxide.Game.Rust.RustCore.FindPlayerById",
      "href": "Oxide.Game.Rust.RustCore.html#Oxide.Game.Rust.RustCore.FindPlayerById(System.UInt64)",
      "name": "FindPlayerById",
      "nameWithType": "RustCore.FindPlayerById",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerById"
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
      "uid": "Oxide.Game.Rust.RustCore.FindPlayerByIdString*",
      "commentId": "Overload:Oxide.Game.Rust.RustCore.FindPlayerByIdString",
      "href": "Oxide.Game.Rust.RustCore.html#Oxide.Game.Rust.RustCore.FindPlayerByIdString(System.String)",
      "name": "FindPlayerByIdString",
      "nameWithType": "RustCore.FindPlayerByIdString",
      "fullName": "Oxide.Game.Rust.RustCore.FindPlayerByIdString"
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