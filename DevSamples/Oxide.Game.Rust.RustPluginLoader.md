# Class RustPluginLoader
Namespace: [Oxide.Game.Rust](Oxide.Game.Rust.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustPluginLoader : PluginLoader
```  
#### Responsible for loading Rust core plugins


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Plugins.PluginLoader  
#### Inherited Members
LoadedPlugins, ScanDirectory, Load, GetPlugin, LoadPlugin, Reload, Unloading, LoadingPlugins, PluginErrors, FileExtension, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public override Type[] CorePlugins { get; }
```
CorePlugins






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.RustPluginLoader",
      "commentId": "T:Oxide.Game.Rust.RustPluginLoader",
      "id": "RustPluginLoader",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust",
      "children": [
        "Oxide.Game.Rust.RustPluginLoader.CorePlugins"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustPluginLoader",
      "nameWithType": "RustPluginLoader",
      "fullName": "Oxide.Game.Rust.RustPluginLoader",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustPluginLoader.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustPluginLoader",
        "path": "../../../../../../../Oxide.Rust/src/RustPluginLoader.cs",
        "startLine": 8,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Responsible for loading Rust core plugins",
      "example": [],
      "syntax": {
        "content": "public class RustPluginLoader : PluginLoader",
        "content.vb": "Public Class RustPluginLoader Inherits PluginLoader"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Plugins.PluginLoader"
      ],
      "inheritedMembers": [
        "Oxide.Core.Plugins.PluginLoader.LoadedPlugins",
        "Oxide.Core.Plugins.PluginLoader.ScanDirectory(System.String)",
        "Oxide.Core.Plugins.PluginLoader.Load(System.String,System.String)",
        "Oxide.Core.Plugins.PluginLoader.GetPlugin(System.String)",
        "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin,System.Boolean)",
        "Oxide.Core.Plugins.PluginLoader.Reload(System.String,System.String)",
        "Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
        "Oxide.Core.Plugins.PluginLoader.LoadingPlugins",
        "Oxide.Core.Plugins.PluginLoader.PluginErrors",
        "Oxide.Core.Plugins.PluginLoader.FileExtension",
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
      "uid": "Oxide.Game.Rust.RustPluginLoader.CorePlugins",
      "commentId": "P:Oxide.Game.Rust.RustPluginLoader.CorePlugins",
      "id": "CorePlugins",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustPluginLoader",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "CorePlugins",
      "nameWithType": "RustPluginLoader.CorePlugins",
      "fullName": "Oxide.Game.Rust.RustPluginLoader.CorePlugins",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustPluginLoader.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "CorePlugins",
        "path": "../../../../../../../Oxide.Rust/src/RustPluginLoader.cs",
        "startLine": 10,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "example": [],
      "syntax": {
        "content": "public override Type[] CorePlugins { get; }",
        "parameters": [],
        "return": {
          "type": "System.Type[]"
        },
        "content.vb": "Public Overrides ReadOnly Property CorePlugins As Type()"
      },
      "overridden": "Oxide.Core.Plugins.PluginLoader.CorePlugins",
      "overload": "Oxide.Game.Rust.RustPluginLoader.CorePlugins*"
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
      "uid": "Oxide.Core.Plugins.PluginLoader",
      "commentId": "T:Oxide.Core.Plugins.PluginLoader",
      "parent": "Oxide.Core.Plugins",
      "isExternal": true,
      "name": "PluginLoader",
      "nameWithType": "PluginLoader",
      "fullName": "Oxide.Core.Plugins.PluginLoader"
    },
    {
      "uid": "Oxide.Core.Plugins.PluginLoader.LoadedPlugins",
      "commentId": "F:Oxide.Core.Plugins.PluginLoader.LoadedPlugins",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "LoadedPlugins",
      "nameWithType": "PluginLoader.LoadedPlugins",
      "fullName": "Oxide.Core.Plugins.PluginLoader.LoadedPlugins"
    },
    {
      "uid": "Oxide.Core.Plugins.PluginLoader.ScanDirectory(System.String)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.ScanDirectory(System.String)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "ScanDirectory(string)",
      "nameWithType": "PluginLoader.ScanDirectory(string)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.ScanDirectory(string)",
      "nameWithType.vb": "PluginLoader.ScanDirectory(String)",
      "fullName.vb": "Oxide.Core.Plugins.PluginLoader.ScanDirectory(String)",
      "name.vb": "ScanDirectory(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.ScanDirectory(System.String)",
          "name": "ScanDirectory",
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
          "uid": "Oxide.Core.Plugins.PluginLoader.ScanDirectory(System.String)",
          "name": "ScanDirectory",
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
      "uid": "Oxide.Core.Plugins.PluginLoader.Load(System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.Load(System.String,System.String)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Load(string, string)",
      "nameWithType": "PluginLoader.Load(string, string)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.Load(string, string)",
      "nameWithType.vb": "PluginLoader.Load(String, String)",
      "fullName.vb": "Oxide.Core.Plugins.PluginLoader.Load(String, String)",
      "name.vb": "Load(String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.Load(System.String,System.String)",
          "name": "Load",
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
          "uid": "Oxide.Core.Plugins.PluginLoader.Load(System.String,System.String)",
          "name": "Load",
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
      "uid": "Oxide.Core.Plugins.PluginLoader.GetPlugin(System.String)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.GetPlugin(System.String)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "GetPlugin(string)",
      "nameWithType": "PluginLoader.GetPlugin(string)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.GetPlugin(string)",
      "nameWithType.vb": "PluginLoader.GetPlugin(String)",
      "fullName.vb": "Oxide.Core.Plugins.PluginLoader.GetPlugin(String)",
      "name.vb": "GetPlugin(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.GetPlugin(System.String)",
          "name": "GetPlugin",
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
          "uid": "Oxide.Core.Plugins.PluginLoader.GetPlugin(System.String)",
          "name": "GetPlugin",
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
      "uid": "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin,System.Boolean)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin,System.Boolean)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.boolean",
      "name": "LoadPlugin(Plugin, bool)",
      "nameWithType": "PluginLoader.LoadPlugin(Plugin, bool)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin, bool)",
      "nameWithType.vb": "PluginLoader.LoadPlugin(Plugin, Boolean)",
      "fullName.vb": "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin, Boolean)",
      "name.vb": "LoadPlugin(Plugin, Boolean)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin,System.Boolean)",
          "name": "LoadPlugin",
          "isExternal": true
        },
        {
          "name": "(",
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
          "name": ")",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.LoadPlugin(Oxide.Core.Plugins.Plugin,System.Boolean)",
          "name": "LoadPlugin",
          "isExternal": true
        },
        {
          "name": "(",
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
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "Oxide.Core.Plugins.PluginLoader.Reload(System.String,System.String)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.Reload(System.String,System.String)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "Reload(string, string)",
      "nameWithType": "PluginLoader.Reload(string, string)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.Reload(string, string)",
      "nameWithType.vb": "PluginLoader.Reload(String, String)",
      "fullName.vb": "Oxide.Core.Plugins.PluginLoader.Reload(String, String)",
      "name.vb": "Reload(String, String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.Reload(System.String,System.String)",
          "name": "Reload",
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
          "uid": "Oxide.Core.Plugins.PluginLoader.Reload(System.String,System.String)",
          "name": "Reload",
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
      "uid": "Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
      "commentId": "M:Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "Unloading(Plugin)",
      "nameWithType": "PluginLoader.Unloading(Plugin)",
      "fullName": "Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
          "name": "Unloading",
          "isExternal": true
        },
        {
          "name": "(",
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
          "uid": "Oxide.Core.Plugins.PluginLoader.Unloading(Oxide.Core.Plugins.Plugin)",
          "name": "Unloading",
          "isExternal": true
        },
        {
          "name": "(",
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
      "uid": "Oxide.Core.Plugins.PluginLoader.LoadingPlugins",
      "commentId": "P:Oxide.Core.Plugins.PluginLoader.LoadingPlugins",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "LoadingPlugins",
      "nameWithType": "PluginLoader.LoadingPlugins",
      "fullName": "Oxide.Core.Plugins.PluginLoader.LoadingPlugins"
    },
    {
      "uid": "Oxide.Core.Plugins.PluginLoader.PluginErrors",
      "commentId": "P:Oxide.Core.Plugins.PluginLoader.PluginErrors",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "PluginErrors",
      "nameWithType": "PluginLoader.PluginErrors",
      "fullName": "Oxide.Core.Plugins.PluginLoader.PluginErrors"
    },
    {
      "uid": "Oxide.Core.Plugins.PluginLoader.FileExtension",
      "commentId": "P:Oxide.Core.Plugins.PluginLoader.FileExtension",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "FileExtension",
      "nameWithType": "PluginLoader.FileExtension",
      "fullName": "Oxide.Core.Plugins.PluginLoader.FileExtension"
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
      "uid": "Oxide.Core.Plugins.PluginLoader.CorePlugins",
      "commentId": "P:Oxide.Core.Plugins.PluginLoader.CorePlugins",
      "parent": "Oxide.Core.Plugins.PluginLoader",
      "isExternal": true,
      "name": "CorePlugins",
      "nameWithType": "PluginLoader.CorePlugins",
      "fullName": "Oxide.Core.Plugins.PluginLoader.CorePlugins"
    },
    {
      "uid": "Oxide.Game.Rust.RustPluginLoader.CorePlugins*",
      "commentId": "Overload:Oxide.Game.Rust.RustPluginLoader.CorePlugins",
      "href": "Oxide.Game.Rust.RustPluginLoader.html#Oxide.Game.Rust.RustPluginLoader.CorePlugins",
      "name": "CorePlugins",
      "nameWithType": "RustPluginLoader.CorePlugins",
      "fullName": "Oxide.Game.Rust.RustPluginLoader.CorePlugins"
    },
    {
      "uid": "System.Type[]",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.type",
      "name": "Type[]",
      "nameWithType": "Type[]",
      "fullName": "System.Type[]",
      "nameWithType.vb": "Type()",
      "fullName.vb": "System.Type()",
      "name.vb": "Type()",
      "spec.csharp": [
        {
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
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
          "uid": "System.Type",
          "name": "Type",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.type"
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