# Class RustExtension
Namespace: [Oxide.Game.Rust](Oxide.Game.Rust.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class RustExtension : Extension
```  
#### The extension class that represents this extension


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Extensions.Extension  
#### Inherited Members
Unload, OnShutdown, Filename, IsCoreExtension, SupportsReloading, Manager, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public override bool IsGameExtension { get; }
```
IsGameExtension
```csharp
public override string Name { get; }
```
Name
```csharp
public override string Author { get; }
```
Author
```csharp
public override VersionNumber Version { get; }
```
Version
```csharp
public override string Branch { get; }
```
Branch
```csharp
public override string[] DefaultReferences { get; }
```
DefaultReferences
```csharp
public override string[] WhitelistAssemblies { get; }
```
WhitelistAssemblies
```csharp
public override string[] WhitelistNamespaces { get; }
```
WhitelistNamespaces
## Constructors 
```csharp
public RustExtension(ExtensionManager manager)
```
RustExtension(ExtensionManager)
## Methods 
```csharp
public override void Load()
```
Load()
```csharp
public override void LoadPluginWatchers(string directory)
```
LoadPluginWatchers(string)
```csharp
public override void OnModLoad()
```
OnModLoad()
```csharp
public void GetLatestVersion(Action<VersionNumber, Exception> callback)
```
GetLatestVersion(Action<VersionNumber, Exception>)
## Fields 
```csharp
public static string[] Filter
```
Filter






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.RustExtension",
      "commentId": "T:Oxide.Game.Rust.RustExtension",
      "id": "RustExtension",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust",
      "children": [
        "Oxide.Game.Rust.RustExtension.#ctor(Oxide.Core.Extensions.ExtensionManager)",
        "Oxide.Game.Rust.RustExtension.Author",
        "Oxide.Game.Rust.RustExtension.Branch",
        "Oxide.Game.Rust.RustExtension.DefaultReferences",
        "Oxide.Game.Rust.RustExtension.Filter",
        "Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action{Oxide.Core.VersionNumber,System.Exception})",
        "Oxide.Game.Rust.RustExtension.IsGameExtension",
        "Oxide.Game.Rust.RustExtension.Load",
        "Oxide.Game.Rust.RustExtension.LoadPluginWatchers(System.String)",
        "Oxide.Game.Rust.RustExtension.Name",
        "Oxide.Game.Rust.RustExtension.OnModLoad",
        "Oxide.Game.Rust.RustExtension.Version",
        "Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
        "Oxide.Game.Rust.RustExtension.WhitelistNamespaces"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustExtension",
      "nameWithType": "RustExtension",
      "fullName": "Oxide.Game.Rust.RustExtension",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RustExtension",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 14,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "The extension class that represents this extension",
      "example": [],
      "syntax": {
        "content": "public class RustExtension : Extension",
        "content.vb": "Public Class RustExtension Inherits Extension"
      },
      "inheritance": [
        "System.Object",
        "Oxide.Core.Extensions.Extension"
      ],
      "inheritedMembers": [
        "Oxide.Core.Extensions.Extension.Unload",
        "Oxide.Core.Extensions.Extension.OnShutdown",
        "Oxide.Core.Extensions.Extension.Filename",
        "Oxide.Core.Extensions.Extension.IsCoreExtension",
        "Oxide.Core.Extensions.Extension.SupportsReloading",
        "Oxide.Core.Extensions.Extension.Manager",
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
      "uid": "Oxide.Game.Rust.RustExtension.IsGameExtension",
      "commentId": "P:Oxide.Game.Rust.RustExtension.IsGameExtension",
      "id": "IsGameExtension",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsGameExtension",
      "nameWithType": "RustExtension.IsGameExtension",
      "fullName": "Oxide.Game.Rust.RustExtension.IsGameExtension",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsGameExtension",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 32,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets whether this extension is for a specific game",
      "example": [],
      "syntax": {
        "content": "public override bool IsGameExtension { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean"
        },
        "content.vb": "Public Overrides ReadOnly Property IsGameExtension As Boolean"
      },
      "overridden": "Oxide.Core.Extensions.Extension.IsGameExtension",
      "overload": "Oxide.Game.Rust.RustExtension.IsGameExtension*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Name",
      "commentId": "P:Oxide.Game.Rust.RustExtension.Name",
      "id": "Name",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Name",
      "nameWithType": "RustExtension.Name",
      "fullName": "Oxide.Game.Rust.RustExtension.Name",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Name",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 37,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets the name of this extension",
      "example": [],
      "syntax": {
        "content": "public override string Name { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Overrides ReadOnly Property Name As String"
      },
      "overridden": "Oxide.Core.Extensions.Extension.Name",
      "overload": "Oxide.Game.Rust.RustExtension.Name*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Author",
      "commentId": "P:Oxide.Game.Rust.RustExtension.Author",
      "id": "Author",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Author",
      "nameWithType": "RustExtension.Author",
      "fullName": "Oxide.Game.Rust.RustExtension.Author",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Author",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 42,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets the author of this extension",
      "example": [],
      "syntax": {
        "content": "public override string Author { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Overrides ReadOnly Property Author As String"
      },
      "overridden": "Oxide.Core.Extensions.Extension.Author",
      "overload": "Oxide.Game.Rust.RustExtension.Author*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Version",
      "commentId": "P:Oxide.Game.Rust.RustExtension.Version",
      "id": "Version",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Version",
      "nameWithType": "RustExtension.Version",
      "fullName": "Oxide.Game.Rust.RustExtension.Version",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Version",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 47,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets the version of this extension",
      "example": [],
      "syntax": {
        "content": "public override VersionNumber Version { get; }",
        "parameters": [],
        "return": {
          "type": "Oxide.Core.VersionNumber"
        },
        "content.vb": "Public Overrides ReadOnly Property Version As VersionNumber"
      },
      "overridden": "Oxide.Core.Extensions.Extension.Version",
      "overload": "Oxide.Game.Rust.RustExtension.Version*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Branch",
      "commentId": "P:Oxide.Game.Rust.RustExtension.Branch",
      "id": "Branch",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Branch",
      "nameWithType": "RustExtension.Branch",
      "fullName": "Oxide.Game.Rust.RustExtension.Branch",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Branch",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 52,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets the branch of this extension",
      "example": [],
      "syntax": {
        "content": "public override string Branch { get; }",
        "parameters": [],
        "return": {
          "type": "System.String"
        },
        "content.vb": "Public Overrides ReadOnly Property Branch As String"
      },
      "overridden": "Oxide.Core.Extensions.Extension.Branch",
      "overload": "Oxide.Game.Rust.RustExtension.Branch*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.DefaultReferences",
      "commentId": "P:Oxide.Game.Rust.RustExtension.DefaultReferences",
      "id": "DefaultReferences",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "DefaultReferences",
      "nameWithType": "RustExtension.DefaultReferences",
      "fullName": "Oxide.Game.Rust.RustExtension.DefaultReferences",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "DefaultReferences",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 57,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Default game-specific references for use in plugins",
      "example": [],
      "syntax": {
        "content": "public override string[] DefaultReferences { get; }",
        "parameters": [],
        "return": {
          "type": "System.String[]"
        },
        "content.vb": "Public Overrides Property DefaultReferences As String()"
      },
      "overridden": "Oxide.Core.Extensions.Extension.DefaultReferences",
      "overload": "Oxide.Game.Rust.RustExtension.DefaultReferences*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
      "commentId": "P:Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
      "id": "WhitelistAssemblies",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "WhitelistAssemblies",
      "nameWithType": "RustExtension.WhitelistAssemblies",
      "fullName": "Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "WhitelistAssemblies",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 70,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "List of assemblies allowed for use in plugins",
      "example": [],
      "syntax": {
        "content": "public override string[] WhitelistAssemblies { get; }",
        "parameters": [],
        "return": {
          "type": "System.String[]"
        },
        "content.vb": "Public Overrides Property WhitelistAssemblies As String()"
      },
      "overridden": "Oxide.Core.Extensions.Extension.WhitelistAssemblies",
      "overload": "Oxide.Game.Rust.RustExtension.WhitelistAssemblies*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.WhitelistNamespaces",
      "commentId": "P:Oxide.Game.Rust.RustExtension.WhitelistNamespaces",
      "id": "WhitelistNamespaces",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "WhitelistNamespaces",
      "nameWithType": "RustExtension.WhitelistNamespaces",
      "fullName": "Oxide.Game.Rust.RustExtension.WhitelistNamespaces",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "WhitelistNamespaces",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 79,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "List of namespaces allowed for use in plugins",
      "example": [],
      "syntax": {
        "content": "public override string[] WhitelistNamespaces { get; }",
        "parameters": [],
        "return": {
          "type": "System.String[]"
        },
        "content.vb": "Public Overrides Property WhitelistNamespaces As String()"
      },
      "overridden": "Oxide.Core.Extensions.Extension.WhitelistNamespaces",
      "overload": "Oxide.Game.Rust.RustExtension.WhitelistNamespaces*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Filter",
      "commentId": "F:Oxide.Game.Rust.RustExtension.Filter",
      "id": "Filter",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Filter",
      "nameWithType": "RustExtension.Filter",
      "fullName": "Oxide.Game.Rust.RustExtension.Filter",
      "type": "field",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Filter",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 88,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "List of filter matches to apply to console output",
      "example": [],
      "syntax": {
        "content": "public static string[] Filter",
        "return": {
          "type": "System.String[]"
        },
        "content.vb": "Public Shared Filter As String()"
      }
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.#ctor(Oxide.Core.Extensions.ExtensionManager)",
      "commentId": "M:Oxide.Game.Rust.RustExtension.#ctor(Oxide.Core.Extensions.ExtensionManager)",
      "id": "#ctor(Oxide.Core.Extensions.ExtensionManager)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RustExtension(ExtensionManager)",
      "nameWithType": "RustExtension.RustExtension(ExtensionManager)",
      "fullName": "Oxide.Game.Rust.RustExtension.RustExtension(Oxide.Core.Extensions.ExtensionManager)",
      "type": "constructor",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": ".ctor",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 114,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Initializes a new instance of the RustExtension class",
      "example": [],
      "syntax": {
        "content": "public RustExtension(ExtensionManager manager)",
        "parameters": [
          {
            "id": "manager",
            "type": "Oxide.Core.Extensions.ExtensionManager",
            "description": ""
          }
        ],
        "content.vb": "Public Sub New(manager As ExtensionManager)"
      },
      "overload": "Oxide.Game.Rust.RustExtension.#ctor*",
      "nameWithType.vb": "RustExtension.New(ExtensionManager)",
      "fullName.vb": "Oxide.Game.Rust.RustExtension.New(Oxide.Core.Extensions.ExtensionManager)",
      "name.vb": "New(ExtensionManager)"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Load",
      "commentId": "M:Oxide.Game.Rust.RustExtension.Load",
      "id": "Load",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Load()",
      "nameWithType": "RustExtension.Load()",
      "fullName": "Oxide.Game.Rust.RustExtension.Load()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Load",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 121,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Loads this extension",
      "example": [],
      "syntax": {
        "content": "public override void Load()",
        "content.vb": "Public Overrides Sub Load()"
      },
      "overridden": "Oxide.Core.Extensions.Extension.Load",
      "overload": "Oxide.Game.Rust.RustExtension.Load*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers(System.String)",
      "commentId": "M:Oxide.Game.Rust.RustExtension.LoadPluginWatchers(System.String)",
      "id": "LoadPluginWatchers(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "LoadPluginWatchers(string)",
      "nameWithType": "RustExtension.LoadPluginWatchers(string)",
      "fullName": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "LoadPluginWatchers",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 142,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Loads plugin watchers used by this extension",
      "example": [],
      "syntax": {
        "content": "public override void LoadPluginWatchers(string directory)",
        "parameters": [
          {
            "id": "directory",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "Public Overrides Sub LoadPluginWatchers(directory As String)"
      },
      "overridden": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)",
      "overload": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers*",
      "nameWithType.vb": "RustExtension.LoadPluginWatchers(String)",
      "fullName.vb": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers(String)",
      "name.vb": "LoadPluginWatchers(String)"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.OnModLoad",
      "commentId": "M:Oxide.Game.Rust.RustExtension.OnModLoad",
      "id": "OnModLoad",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "OnModLoad()",
      "nameWithType": "RustExtension.OnModLoad()",
      "fullName": "Oxide.Game.Rust.RustExtension.OnModLoad()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "OnModLoad",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 149,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Called when all other extensions have been loaded",
      "example": [],
      "syntax": {
        "content": "public override void OnModLoad()",
        "content.vb": "Public Overrides Sub OnModLoad()"
      },
      "overridden": "Oxide.Core.Extensions.Extension.OnModLoad",
      "overload": "Oxide.Game.Rust.RustExtension.OnModLoad*"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action{Oxide.Core.VersionNumber,System.Exception})",
      "commentId": "M:Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action{Oxide.Core.VersionNumber,System.Exception})",
      "id": "GetLatestVersion(System.Action{Oxide.Core.VersionNumber,System.Exception})",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.RustExtension",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "GetLatestVersion(Action<VersionNumber, Exception>)",
      "nameWithType": "RustExtension.GetLatestVersion(Action<VersionNumber, Exception>)",
      "fullName": "Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action<Oxide.Core.VersionNumber, System.Exception>)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/RustExtension.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "GetLatestVersion",
        "path": "../../../../../../../Oxide.Rust/src/RustExtension.cs",
        "startLine": 161,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust",
      "summary": "Gets latest official Oxide.Rust build version",
      "example": [],
      "syntax": {
        "content": "public void GetLatestVersion(Action<VersionNumber, Exception> callback)",
        "parameters": [
          {
            "id": "callback",
            "type": "System.Action{Oxide.Core.VersionNumber,System.Exception}",
            "description": "Callback to execute.<br />\n    First argument is the version (latest, if request was successful, current otherwise)<br />\n    Second argument is the exception indicating fail reason. Null if request was successful."
          }
        ],
        "content.vb": "Public Sub GetLatestVersion(callback As Action(Of VersionNumber, Exception))"
      },
      "overload": "Oxide.Game.Rust.RustExtension.GetLatestVersion*",
      "nameWithType.vb": "RustExtension.GetLatestVersion(Action(Of VersionNumber, Exception))",
      "fullName.vb": "Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action(Of Oxide.Core.VersionNumber, System.Exception))",
      "name.vb": "GetLatestVersion(Action(Of VersionNumber, Exception))"
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
      "uid": "Oxide.Core.Extensions.Extension",
      "commentId": "T:Oxide.Core.Extensions.Extension",
      "parent": "Oxide.Core.Extensions",
      "isExternal": true,
      "name": "Extension",
      "nameWithType": "Extension",
      "fullName": "Oxide.Core.Extensions.Extension"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.Unload",
      "commentId": "M:Oxide.Core.Extensions.Extension.Unload",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Unload()",
      "nameWithType": "Extension.Unload()",
      "fullName": "Oxide.Core.Extensions.Extension.Unload()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Extensions.Extension.Unload",
          "name": "Unload",
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
          "uid": "Oxide.Core.Extensions.Extension.Unload",
          "name": "Unload",
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
      "uid": "Oxide.Core.Extensions.Extension.OnShutdown",
      "commentId": "M:Oxide.Core.Extensions.Extension.OnShutdown",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "OnShutdown()",
      "nameWithType": "Extension.OnShutdown()",
      "fullName": "Oxide.Core.Extensions.Extension.OnShutdown()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Extensions.Extension.OnShutdown",
          "name": "OnShutdown",
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
          "uid": "Oxide.Core.Extensions.Extension.OnShutdown",
          "name": "OnShutdown",
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
      "uid": "Oxide.Core.Extensions.Extension.Filename",
      "commentId": "P:Oxide.Core.Extensions.Extension.Filename",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Filename",
      "nameWithType": "Extension.Filename",
      "fullName": "Oxide.Core.Extensions.Extension.Filename"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.IsCoreExtension",
      "commentId": "P:Oxide.Core.Extensions.Extension.IsCoreExtension",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "IsCoreExtension",
      "nameWithType": "Extension.IsCoreExtension",
      "fullName": "Oxide.Core.Extensions.Extension.IsCoreExtension"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.SupportsReloading",
      "commentId": "P:Oxide.Core.Extensions.Extension.SupportsReloading",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "SupportsReloading",
      "nameWithType": "Extension.SupportsReloading",
      "fullName": "Oxide.Core.Extensions.Extension.SupportsReloading"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.Manager",
      "commentId": "P:Oxide.Core.Extensions.Extension.Manager",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Manager",
      "nameWithType": "Extension.Manager",
      "fullName": "Oxide.Core.Extensions.Extension.Manager"
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
      "uid": "Oxide.Core.Extensions",
      "commentId": "N:Oxide.Core.Extensions",
      "isExternal": true,
      "name": "Oxide.Core.Extensions",
      "nameWithType": "Oxide.Core.Extensions",
      "fullName": "Oxide.Core.Extensions",
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
          "uid": "Oxide.Core.Extensions",
          "name": "Extensions",
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
          "uid": "Oxide.Core.Extensions",
          "name": "Extensions",
          "isExternal": true
        }
      ]
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.IsGameExtension",
      "commentId": "P:Oxide.Core.Extensions.Extension.IsGameExtension",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "IsGameExtension",
      "nameWithType": "Extension.IsGameExtension",
      "fullName": "Oxide.Core.Extensions.Extension.IsGameExtension"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.IsGameExtension*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.IsGameExtension",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.IsGameExtension",
      "name": "IsGameExtension",
      "nameWithType": "RustExtension.IsGameExtension",
      "fullName": "Oxide.Game.Rust.RustExtension.IsGameExtension"
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
      "uid": "Oxide.Core.Extensions.Extension.Name",
      "commentId": "P:Oxide.Core.Extensions.Extension.Name",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Name",
      "nameWithType": "Extension.Name",
      "fullName": "Oxide.Core.Extensions.Extension.Name"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Name*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.Name",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.Name",
      "name": "Name",
      "nameWithType": "RustExtension.Name",
      "fullName": "Oxide.Game.Rust.RustExtension.Name"
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
      "uid": "Oxide.Core.Extensions.Extension.Author",
      "commentId": "P:Oxide.Core.Extensions.Extension.Author",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Author",
      "nameWithType": "Extension.Author",
      "fullName": "Oxide.Core.Extensions.Extension.Author"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Author*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.Author",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.Author",
      "name": "Author",
      "nameWithType": "RustExtension.Author",
      "fullName": "Oxide.Game.Rust.RustExtension.Author"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.Version",
      "commentId": "P:Oxide.Core.Extensions.Extension.Version",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Version",
      "nameWithType": "Extension.Version",
      "fullName": "Oxide.Core.Extensions.Extension.Version"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Version*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.Version",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.Version",
      "name": "Version",
      "nameWithType": "RustExtension.Version",
      "fullName": "Oxide.Game.Rust.RustExtension.Version"
    },
    {
      "uid": "Oxide.Core.VersionNumber",
      "commentId": "T:Oxide.Core.VersionNumber",
      "parent": "Oxide.Core",
      "isExternal": true,
      "name": "VersionNumber",
      "nameWithType": "VersionNumber",
      "fullName": "Oxide.Core.VersionNumber"
    },
    {
      "uid": "Oxide.Core",
      "commentId": "N:Oxide.Core",
      "isExternal": true,
      "name": "Oxide.Core",
      "nameWithType": "Oxide.Core",
      "fullName": "Oxide.Core",
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
        }
      ]
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.Branch",
      "commentId": "P:Oxide.Core.Extensions.Extension.Branch",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Branch",
      "nameWithType": "Extension.Branch",
      "fullName": "Oxide.Core.Extensions.Extension.Branch"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.Branch*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.Branch",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.Branch",
      "name": "Branch",
      "nameWithType": "RustExtension.Branch",
      "fullName": "Oxide.Game.Rust.RustExtension.Branch"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.DefaultReferences",
      "commentId": "P:Oxide.Core.Extensions.Extension.DefaultReferences",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "DefaultReferences",
      "nameWithType": "Extension.DefaultReferences",
      "fullName": "Oxide.Core.Extensions.Extension.DefaultReferences"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.DefaultReferences*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.DefaultReferences",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.DefaultReferences",
      "name": "DefaultReferences",
      "nameWithType": "RustExtension.DefaultReferences",
      "fullName": "Oxide.Game.Rust.RustExtension.DefaultReferences"
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
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.WhitelistAssemblies",
      "commentId": "P:Oxide.Core.Extensions.Extension.WhitelistAssemblies",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "WhitelistAssemblies",
      "nameWithType": "Extension.WhitelistAssemblies",
      "fullName": "Oxide.Core.Extensions.Extension.WhitelistAssemblies"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.WhitelistAssemblies*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.WhitelistAssemblies",
      "name": "WhitelistAssemblies",
      "nameWithType": "RustExtension.WhitelistAssemblies",
      "fullName": "Oxide.Game.Rust.RustExtension.WhitelistAssemblies"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.WhitelistNamespaces",
      "commentId": "P:Oxide.Core.Extensions.Extension.WhitelistNamespaces",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "WhitelistNamespaces",
      "nameWithType": "Extension.WhitelistNamespaces",
      "fullName": "Oxide.Core.Extensions.Extension.WhitelistNamespaces"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.WhitelistNamespaces*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.WhitelistNamespaces",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.WhitelistNamespaces",
      "name": "WhitelistNamespaces",
      "nameWithType": "RustExtension.WhitelistNamespaces",
      "fullName": "Oxide.Game.Rust.RustExtension.WhitelistNamespaces"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.#ctor*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.#ctor",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.#ctor(Oxide.Core.Extensions.ExtensionManager)",
      "name": "RustExtension",
      "nameWithType": "RustExtension.RustExtension",
      "fullName": "Oxide.Game.Rust.RustExtension.RustExtension",
      "nameWithType.vb": "RustExtension.New",
      "fullName.vb": "Oxide.Game.Rust.RustExtension.New",
      "name.vb": "New"
    },
    {
      "uid": "Oxide.Core.Extensions.ExtensionManager",
      "commentId": "T:Oxide.Core.Extensions.ExtensionManager",
      "parent": "Oxide.Core.Extensions",
      "isExternal": true,
      "name": "ExtensionManager",
      "nameWithType": "ExtensionManager",
      "fullName": "Oxide.Core.Extensions.ExtensionManager"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.Load",
      "commentId": "M:Oxide.Core.Extensions.Extension.Load",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "Load()",
      "nameWithType": "Extension.Load()",
      "fullName": "Oxide.Core.Extensions.Extension.Load()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Extensions.Extension.Load",
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
          "uid": "Oxide.Core.Extensions.Extension.Load",
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
      "uid": "Oxide.Game.Rust.RustExtension.Load*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.Load",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.Load",
      "name": "Load",
      "nameWithType": "RustExtension.Load",
      "fullName": "Oxide.Game.Rust.RustExtension.Load"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)",
      "commentId": "M:Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.string",
      "name": "LoadPluginWatchers(string)",
      "nameWithType": "Extension.LoadPluginWatchers(string)",
      "fullName": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(string)",
      "nameWithType.vb": "Extension.LoadPluginWatchers(String)",
      "fullName.vb": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(String)",
      "name.vb": "LoadPluginWatchers(String)",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)",
          "name": "LoadPluginWatchers",
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
          "uid": "Oxide.Core.Extensions.Extension.LoadPluginWatchers(System.String)",
          "name": "LoadPluginWatchers",
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
      "uid": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.LoadPluginWatchers",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.LoadPluginWatchers(System.String)",
      "name": "LoadPluginWatchers",
      "nameWithType": "RustExtension.LoadPluginWatchers",
      "fullName": "Oxide.Game.Rust.RustExtension.LoadPluginWatchers"
    },
    {
      "uid": "Oxide.Core.Extensions.Extension.OnModLoad",
      "commentId": "M:Oxide.Core.Extensions.Extension.OnModLoad",
      "parent": "Oxide.Core.Extensions.Extension",
      "isExternal": true,
      "name": "OnModLoad()",
      "nameWithType": "Extension.OnModLoad()",
      "fullName": "Oxide.Core.Extensions.Extension.OnModLoad()",
      "spec.csharp": [
        {
          "uid": "Oxide.Core.Extensions.Extension.OnModLoad",
          "name": "OnModLoad",
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
          "uid": "Oxide.Core.Extensions.Extension.OnModLoad",
          "name": "OnModLoad",
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
      "uid": "Oxide.Game.Rust.RustExtension.OnModLoad*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.OnModLoad",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.OnModLoad",
      "name": "OnModLoad",
      "nameWithType": "RustExtension.OnModLoad",
      "fullName": "Oxide.Game.Rust.RustExtension.OnModLoad"
    },
    {
      "uid": "Oxide.Game.Rust.RustExtension.GetLatestVersion*",
      "commentId": "Overload:Oxide.Game.Rust.RustExtension.GetLatestVersion",
      "href": "Oxide.Game.Rust.RustExtension.html#Oxide.Game.Rust.RustExtension.GetLatestVersion(System.Action{Oxide.Core.VersionNumber,System.Exception})",
      "name": "GetLatestVersion",
      "nameWithType": "RustExtension.GetLatestVersion",
      "fullName": "Oxide.Game.Rust.RustExtension.GetLatestVersion"
    },
    {
      "uid": "System.Action{Oxide.Core.VersionNumber,System.Exception}",
      "commentId": "T:System.Action{Oxide.Core.VersionNumber,System.Exception}",
      "parent": "System",
      "definition": "System.Action`2",
      "href": "https://learn.microsoft.com/dotnet/api/system.action-2",
      "name": "Action<VersionNumber, Exception>",
      "nameWithType": "Action<VersionNumber, Exception>",
      "fullName": "System.Action<Oxide.Core.VersionNumber, System.Exception>",
      "nameWithType.vb": "Action(Of VersionNumber, Exception)",
      "fullName.vb": "System.Action(Of Oxide.Core.VersionNumber, System.Exception)",
      "name.vb": "Action(Of VersionNumber, Exception)",
      "spec.csharp": [
        {
          "uid": "System.Action`2",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-2"
        },
        {
          "name": "<",
          "isExternal": false
        },
        {
          "uid": "Oxide.Core.VersionNumber",
          "name": "VersionNumber",
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
          "uid": "System.Exception",
          "name": "Exception",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.exception"
        },
        {
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Action`2",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-2"
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
          "uid": "Oxide.Core.VersionNumber",
          "name": "VersionNumber",
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
          "uid": "System.Exception",
          "name": "Exception",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.exception"
        },
        {
          "name": ")",
          "isExternal": false
        }
      ]
    },
    {
      "uid": "System.Action`2",
      "commentId": "T:System.Action`2",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.action-2",
      "name": "Action<T1, T2>",
      "nameWithType": "Action<T1, T2>",
      "fullName": "System.Action<T1, T2>",
      "nameWithType.vb": "Action(Of T1, T2)",
      "fullName.vb": "System.Action(Of T1, T2)",
      "name.vb": "Action(Of T1, T2)",
      "spec.csharp": [
        {
          "uid": "System.Action`2",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-2"
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
          "name": ">",
          "isExternal": false
        }
      ],
      "spec.vb": [
        {
          "uid": "System.Action`2",
          "name": "Action",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.action-2"
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