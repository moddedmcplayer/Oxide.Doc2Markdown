# Class Rust
Namespace: [Oxide.Game.Rust.Libraries](Oxide.Game.Rust.Libraries.md)  
Assembly: Oxide.Rust.dll  
```csharp
public class Rust : Library
```  
#### A library containing utility shortcut functions for Rust


#### Inheritance
[System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0), Oxide.Core.Libraries.Library  
#### Inherited Members
Shutdown, GetFunctionNames, GetPropertyNames, GetFunction, GetProperty, LastException, [ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [Equals](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-7.0), [ReferenceEquals](https://learn.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=net-7.0), [GetHashCode](https://learn.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-7.0), [GetType](https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0), [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-7.0)  

## Properties 
```csharp
public override bool IsGlobal { get; }
```
IsGlobal
## Methods 
```csharp
[LibraryFunction("PrivateBindingFlag")]
public BindingFlags PrivateBindingFlag()
```
PrivateBindingFlag()
```csharp
[LibraryFunction("QuoteSafe")]
public string QuoteSafe(string str)
```
QuoteSafe(string)
```csharp
[LibraryFunction("BroadcastChat")]
public void BroadcastChat(string name, string message = null, string userId = "0")
```
BroadcastChat(string, string, string)
```csharp
[LibraryFunction("SendChatMessage")]
public void SendChatMessage(BasePlayer player, string name, string message = null, string userId = "0")
```
SendChatMessage(BasePlayer, string, string, string)
```csharp
[LibraryFunction("RunClientCommand")]
public void RunClientCommand(BasePlayer player, string command, params object[] args)
```
RunClientCommand(BasePlayer, string, params object[])
```csharp
[LibraryFunction("RunServerCommand")]
public void RunServerCommand(string command, params object[] args)
```
RunServerCommand(string, params object[])
```csharp
[LibraryFunction("UserIDFromConnection")]
public string UserIDFromConnection(Connection connection)
```
UserIDFromConnection(Connection)
```csharp
[LibraryFunction("UserIDsFromBuildingPrivilege")]
public Array UserIDsFromBuildingPrivlidge(BuildingPrivlidge priv)
```
UserIDsFromBuildingPrivlidge(BuildingPrivlidge)
```csharp
[LibraryFunction("UserIDFromPlayer")]
public string UserIDFromPlayer(BasePlayer player)
```
UserIDFromPlayer(BasePlayer)
```csharp
[LibraryFunction("OwnerIDFromEntity")]
public string OwnerIDFromEntity(BaseEntity entity)
```
OwnerIDFromEntity(BaseEntity)
```csharp
[LibraryFunction("FindPlayer")]
public BasePlayer FindPlayer(string nameOrIdOrIp)
```
FindPlayer(string)
```csharp
[LibraryFunction("FindPlayerByName")]
public BasePlayer FindPlayerByName(string name)
```
FindPlayerByName(string)
```csharp
[LibraryFunction("FindPlayerById")]
public BasePlayer FindPlayerById(ulong id)
```
FindPlayerById(ulong)
```csharp
[LibraryFunction("FindPlayerByIdString")]
public BasePlayer FindPlayerByIdString(string id)
```
FindPlayerByIdString(string)
```csharp
[LibraryFunction("ForcePlayerPosition")]
public void ForcePlayerPosition(BasePlayer player, float x, float y, float z)
```
ForcePlayerPosition(BasePlayer, float, float, float)






JSON:
{
  "items": [
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust",
      "commentId": "T:Oxide.Game.Rust.Libraries.Rust",
      "id": "Rust",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries",
      "children": [
        "Oxide.Game.Rust.Libraries.Rust.BroadcastChat(System.String,System.String,System.String)",
        "Oxide.Game.Rust.Libraries.Rust.FindPlayer(System.String)",
        "Oxide.Game.Rust.Libraries.Rust.FindPlayerById(System.UInt64)",
        "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(System.String)",
        "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(System.String)",
        "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer,System.Single,System.Single,System.Single)",
        "Oxide.Game.Rust.Libraries.Rust.IsGlobal",
        "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity(BaseEntity)",
        "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag",
        "Oxide.Game.Rust.Libraries.Rust.QuoteSafe(System.String)",
        "Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer,System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Rust.RunServerCommand(System.String,System.Object[])",
        "Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer,System.String,System.String,System.String)",
        "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection(Network.Connection)",
        "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer(BasePlayer)",
        "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)"
      ],
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "Rust",
      "nameWithType": "Rust",
      "fullName": "Oxide.Game.Rust.Libraries.Rust",
      "type": "class",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "Rust",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 12,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "A library containing utility shortcut functions for Rust",
      "example": [],
      "syntax": {
        "content": "public class Rust : Library",
        "content.vb": "Public Class Rust Inherits Library"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.IsGlobal",
      "commentId": "P:Oxide.Game.Rust.Libraries.Rust.IsGlobal",
      "id": "IsGlobal",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "IsGlobal",
      "nameWithType": "Rust.IsGlobal",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.IsGlobal",
      "type": "property",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "IsGlobal",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 21,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns if this library should be loaded into the global namespace",
      "example": [],
      "syntax": {
        "content": "public override bool IsGlobal { get; }",
        "parameters": [],
        "return": {
          "type": "System.Boolean",
          "description": ""
        },
        "content.vb": "Public Overrides ReadOnly Property IsGlobal As Boolean"
      },
      "overridden": "Oxide.Core.Libraries.Library.IsGlobal",
      "overload": "Oxide.Game.Rust.Libraries.Rust.IsGlobal*"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag",
      "id": "PrivateBindingFlag",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "PrivateBindingFlag()",
      "nameWithType": "Rust.PrivateBindingFlag()",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag()",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "PrivateBindingFlag",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 28,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Gets private bindingflag for accessing private methods, fields, and properties",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"PrivateBindingFlag\")]\npublic BindingFlags PrivateBindingFlag()",
        "return": {
          "type": "System.Reflection.BindingFlags"
        },
        "content.vb": "<LibraryFunction(\"PrivateBindingFlag\")>\nPublic Function PrivateBindingFlag() As BindingFlags"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "PrivateBindingFlag"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.QuoteSafe(System.String)",
      "id": "QuoteSafe(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "QuoteSafe(string)",
      "nameWithType": "Rust.QuoteSafe(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "QuoteSafe",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 35,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Converts a string into a quote safe string",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"QuoteSafe\")]\npublic string QuoteSafe(string str)",
        "parameters": [
          {
            "id": "str",
            "type": "System.String",
            "description": ""
          }
        ],
        "return": {
          "type": "System.String"
        },
        "content.vb": "<LibraryFunction(\"QuoteSafe\")>\nPublic Function QuoteSafe(str As String) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "QuoteSafe"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.QuoteSafe(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe(String)",
      "name.vb": "QuoteSafe(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat(System.String,System.String,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.BroadcastChat(System.String,System.String,System.String)",
      "id": "BroadcastChat(System.String,System.String,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "BroadcastChat(string, string, string)",
      "nameWithType": "Rust.BroadcastChat(string, string, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat(string, string, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "BroadcastChat",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 48,
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
        "content": "[LibraryFunction(\"BroadcastChat\")]\npublic void BroadcastChat(string name, string message = null, string userId = \"0\")",
        "parameters": [
          {
            "id": "name",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "<LibraryFunction(\"BroadcastChat\")>\nPublic Sub BroadcastChat(name As String, message As String = Nothing, userId As String = \"0\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "BroadcastChat"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.BroadcastChat(String, String, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat(String, String, String)",
      "name.vb": "BroadcastChat(String, String, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer,System.String,System.String,System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer,System.String,System.String,System.String)",
      "id": "SendChatMessage(BasePlayer,System.String,System.String,System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "SendChatMessage(BasePlayer, string, string, string)",
      "nameWithType": "Rust.SendChatMessage(BasePlayer, string, string, string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer, string, string, string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "SendChatMessage",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 61,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Sends a chat message to the player",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"SendChatMessage\")]\npublic void SendChatMessage(BasePlayer player, string name, string message = null, string userId = \"0\")",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "name",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "message",
            "type": "System.String",
            "description": ""
          },
          {
            "id": "userId",
            "type": "System.String",
            "description": ""
          }
        ],
        "content.vb": "<LibraryFunction(\"SendChatMessage\")>\nPublic Sub SendChatMessage(player As BasePlayer, name As String, message As String = Nothing, userId As String = \"0\")"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "SendChatMessage"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.SendChatMessage(BasePlayer, String, String, String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer, String, String, String)",
      "name.vb": "SendChatMessage(BasePlayer, String, String, String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer,System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer,System.String,System.Object[])",
      "id": "RunClientCommand(BasePlayer,System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RunClientCommand(BasePlayer, string, params object[])",
      "nameWithType": "Rust.RunClientCommand(BasePlayer, string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer, string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RunClientCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 77,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Runs a client command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"RunClientCommand\")]\npublic void RunClientCommand(BasePlayer player, string command, params object[] args)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
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
        "content.vb": "<LibraryFunction(\"RunClientCommand\")>\nPublic Sub RunClientCommand(player As BasePlayer, command As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "RunClientCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.RunClientCommand(BasePlayer, String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer, String, ParamArray Object())",
      "name.vb": "RunClientCommand(BasePlayer, String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand(System.String,System.Object[])",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.RunServerCommand(System.String,System.Object[])",
      "id": "RunServerCommand(System.String,System.Object[])",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "RunServerCommand(string, params object[])",
      "nameWithType": "Rust.RunServerCommand(string, params object[])",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand(string, params object[])",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "RunServerCommand",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 88,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Runs a server command",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"RunServerCommand\")]\npublic void RunServerCommand(string command, params object[] args)",
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
        "content.vb": "<LibraryFunction(\"RunServerCommand\")>\nPublic Sub RunServerCommand(command As String, ParamArray args As Object())"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "RunServerCommand"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.RunServerCommand(String, ParamArray Object())",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand(String, ParamArray Object())",
      "name.vb": "RunServerCommand(String, ParamArray Object())"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection(Network.Connection)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection(Network.Connection)",
      "id": "UserIDFromConnection(Network.Connection)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "UserIDFromConnection(Connection)",
      "nameWithType": "Rust.UserIDFromConnection(Connection)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection(Network.Connection)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "UserIDFromConnection",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 101,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the Steam ID for the specified connection as a string",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"UserIDFromConnection\")]\npublic string UserIDFromConnection(Connection connection)",
        "parameters": [
          {
            "id": "connection",
            "type": "Network.Connection",
            "description": ""
          }
        ],
        "return": {
          "type": "System.String",
          "description": ""
        },
        "content.vb": "<LibraryFunction(\"UserIDFromConnection\")>\nPublic Function UserIDFromConnection(connection As Connection) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "UserIDFromConnection"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "id": "UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "nameWithType": "Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "UserIDsFromBuildingPrivlidge",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 112,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the Steam ID for the specified building privilege as an array",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"UserIDsFromBuildingPrivilege\")]\npublic Array UserIDsFromBuildingPrivlidge(BuildingPrivlidge priv)",
        "parameters": [
          {
            "id": "priv",
            "type": "BuildingPrivlidge",
            "description": ""
          }
        ],
        "return": {
          "type": "System.Array",
          "description": ""
        },
        "content.vb": "<LibraryFunction(\"UserIDsFromBuildingPrivilege\")>\nPublic Function UserIDsFromBuildingPrivlidge(priv As BuildingPrivlidge) As Array"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "UserIDsFromBuildingPrivilege"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer(BasePlayer)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer(BasePlayer)",
      "id": "UserIDFromPlayer(BasePlayer)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "UserIDFromPlayer(BasePlayer)",
      "nameWithType": "Rust.UserIDFromPlayer(BasePlayer)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer(BasePlayer)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "UserIDFromPlayer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 123,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the Steam ID for the specified player as a string",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"UserIDFromPlayer\")]\npublic string UserIDFromPlayer(BasePlayer player)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          }
        ],
        "return": {
          "type": "System.String",
          "description": ""
        },
        "content.vb": "<LibraryFunction(\"UserIDFromPlayer\")>\nPublic Function UserIDFromPlayer(player As BasePlayer) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "UserIDFromPlayer"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity(BaseEntity)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity(BaseEntity)",
      "id": "OwnerIDFromEntity(BaseEntity)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "OwnerIDFromEntity(BaseEntity)",
      "nameWithType": "Rust.OwnerIDFromEntity(BaseEntity)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity(BaseEntity)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "OwnerIDFromEntity",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 131,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the Steam ID for the specified entity as a string",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"OwnerIDFromEntity\")]\npublic string OwnerIDFromEntity(BaseEntity entity)",
        "parameters": [
          {
            "id": "entity",
            "type": "BaseEntity",
            "description": ""
          }
        ],
        "return": {
          "type": "System.String",
          "description": ""
        },
        "content.vb": "<LibraryFunction(\"OwnerIDFromEntity\")>\nPublic Function OwnerIDFromEntity(entity As BaseEntity) As String"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "OwnerIDFromEntity"
            }
          ]
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayer(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.FindPlayer(System.String)",
      "id": "FindPlayer(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayer(string)",
      "nameWithType": "Rust.FindPlayer(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayer(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayer",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 139,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the player for the specified name, id or ip",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"FindPlayer\")]\npublic BasePlayer FindPlayer(string nameOrIdOrIp)",
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
        "content.vb": "<LibraryFunction(\"FindPlayer\")>\nPublic Function FindPlayer(nameOrIdOrIp As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.FindPlayer*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "FindPlayer"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.FindPlayer(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.FindPlayer(String)",
      "name.vb": "FindPlayer(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(System.String)",
      "id": "FindPlayerByName(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerByName(string)",
      "nameWithType": "Rust.FindPlayerByName(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerByName",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 147,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the player for the specified name",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"FindPlayerByName\")]\npublic BasePlayer FindPlayerByName(string name)",
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
        "content.vb": "<LibraryFunction(\"FindPlayerByName\")>\nPublic Function FindPlayerByName(name As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "FindPlayerByName"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.FindPlayerByName(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(String)",
      "name.vb": "FindPlayerByName(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById(System.UInt64)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.FindPlayerById(System.UInt64)",
      "id": "FindPlayerById(System.UInt64)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerById(ulong)",
      "nameWithType": "Rust.FindPlayerById(ulong)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById(ulong)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerById",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 155,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the player for the specified id",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"FindPlayerById\")]\npublic BasePlayer FindPlayerById(ulong id)",
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
        "content.vb": "<LibraryFunction(\"FindPlayerById\")>\nPublic Function FindPlayerById(id As ULong) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "FindPlayerById"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.FindPlayerById(ULong)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById(ULong)",
      "name.vb": "FindPlayerById(ULong)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(System.String)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(System.String)",
      "id": "FindPlayerByIdString(System.String)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "FindPlayerByIdString(string)",
      "nameWithType": "Rust.FindPlayerByIdString(string)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(string)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "FindPlayerByIdString",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 163,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Returns the player for the specified id",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"FindPlayerByIdString\")]\npublic BasePlayer FindPlayerByIdString(string id)",
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
        "content.vb": "<LibraryFunction(\"FindPlayerByIdString\")>\nPublic Function FindPlayerByIdString(id As String) As BasePlayer"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "FindPlayerByIdString"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.FindPlayerByIdString(String)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(String)",
      "name.vb": "FindPlayerByIdString(String)"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer,System.Single,System.Single,System.Single)",
      "commentId": "M:Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer,System.Single,System.Single,System.Single)",
      "id": "ForcePlayerPosition(BasePlayer,System.Single,System.Single,System.Single)",
      "isEii": false,
      "isExtensionMethod": false,
      "parent": "Oxide.Game.Rust.Libraries.Rust",
      "langs": [
        "csharp",
        "vb"
      ],
      "name": "ForcePlayerPosition(BasePlayer, float, float, float)",
      "nameWithType": "Rust.ForcePlayerPosition(BasePlayer, float, float, float)",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer, float, float, float)",
      "type": "method",
      "source": {
        "remote": {
          "path": "src/Libraries/Rust.cs",
          "branch": "develop",
          "repo": "https://github.com/OxideMod/Oxide.Rust"
        },
        "id": "ForcePlayerPosition",
        "path": "../../../../../../../Oxide.Rust/src/Libraries/Rust.cs",
        "startLine": 173,
        "endLine": 0,
        "isExternal": false
      },
      "assemblies": [
        "Oxide.Rust"
      ],
      "namespace": "Oxide.Game.Rust.Libraries",
      "summary": "Forces player position (teleportation)",
      "example": [],
      "syntax": {
        "content": "[LibraryFunction(\"ForcePlayerPosition\")]\npublic void ForcePlayerPosition(BasePlayer player, float x, float y, float z)",
        "parameters": [
          {
            "id": "player",
            "type": "BasePlayer",
            "description": ""
          },
          {
            "id": "x",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "y",
            "type": "System.Single",
            "description": ""
          },
          {
            "id": "z",
            "type": "System.Single",
            "description": ""
          }
        ],
        "content.vb": "<LibraryFunction(\"ForcePlayerPosition\")>\nPublic Sub ForcePlayerPosition(player As BasePlayer, x As Single, y As Single, z As Single)"
      },
      "overload": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition*",
      "attributes": [
        {
          "type": "Oxide.Core.Libraries.LibraryFunction",
          "ctor": "Oxide.Core.Libraries.LibraryFunction.#ctor(System.String)",
          "arguments": [
            {
              "type": "System.String",
              "value": "ForcePlayerPosition"
            }
          ]
        }
      ],
      "nameWithType.vb": "Rust.ForcePlayerPosition(BasePlayer, Single, Single, Single)",
      "fullName.vb": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer, Single, Single, Single)",
      "name.vb": "ForcePlayerPosition(BasePlayer, Single, Single, Single)"
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
      "uid": "Oxide.Core.Libraries.Library.IsGlobal",
      "commentId": "P:Oxide.Core.Libraries.Library.IsGlobal",
      "parent": "Oxide.Core.Libraries.Library",
      "isExternal": true,
      "name": "IsGlobal",
      "nameWithType": "Library.IsGlobal",
      "fullName": "Oxide.Core.Libraries.Library.IsGlobal"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.IsGlobal*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.IsGlobal",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.IsGlobal",
      "name": "IsGlobal",
      "nameWithType": "Rust.IsGlobal",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.IsGlobal"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag",
      "name": "PrivateBindingFlag",
      "nameWithType": "Rust.PrivateBindingFlag",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.PrivateBindingFlag"
    },
    {
      "uid": "System.Reflection.BindingFlags",
      "commentId": "T:System.Reflection.BindingFlags",
      "parent": "System.Reflection",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.reflection.bindingflags",
      "name": "BindingFlags",
      "nameWithType": "BindingFlags",
      "fullName": "System.Reflection.BindingFlags"
    },
    {
      "uid": "System.Reflection",
      "commentId": "N:System.Reflection",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system",
      "name": "System.Reflection",
      "nameWithType": "System.Reflection",
      "fullName": "System.Reflection",
      "spec.csharp": [
        {
          "uid": "System",
          "name": "System",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Reflection",
          "name": "Reflection",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.reflection"
        }
      ],
      "spec.vb": [
        {
          "uid": "System",
          "name": "System",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system"
        },
        {
          "name": ".",
          "isExternal": false
        },
        {
          "uid": "System.Reflection",
          "name": "Reflection",
          "isExternal": true,
          "href": "https://learn.microsoft.com/dotnet/api/system.reflection"
        }
      ]
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.QuoteSafe",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.QuoteSafe(System.String)",
      "name": "QuoteSafe",
      "nameWithType": "Rust.QuoteSafe",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.QuoteSafe"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.BroadcastChat",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.BroadcastChat(System.String,System.String,System.String)",
      "name": "BroadcastChat",
      "nameWithType": "Rust.BroadcastChat",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.BroadcastChat"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.SendChatMessage",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.SendChatMessage(BasePlayer,System.String,System.String,System.String)",
      "name": "SendChatMessage",
      "nameWithType": "Rust.SendChatMessage",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.SendChatMessage"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.RunClientCommand",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.RunClientCommand(BasePlayer,System.String,System.Object[])",
      "name": "RunClientCommand",
      "nameWithType": "Rust.RunClientCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.RunClientCommand"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.RunServerCommand",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.RunServerCommand(System.String,System.Object[])",
      "name": "RunServerCommand",
      "nameWithType": "Rust.RunServerCommand",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.RunServerCommand"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection(Network.Connection)",
      "name": "UserIDFromConnection",
      "nameWithType": "Rust.UserIDFromConnection",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDFromConnection"
    },
    {
      "uid": "Network.Connection",
      "commentId": "T:Network.Connection",
      "parent": "Network",
      "isExternal": true,
      "name": "Connection",
      "nameWithType": "Connection",
      "fullName": "Network.Connection"
    },
    {
      "uid": "Network",
      "commentId": "N:Network",
      "isExternal": true,
      "name": "Network",
      "nameWithType": "Network",
      "fullName": "Network"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge(BuildingPrivlidge)",
      "name": "UserIDsFromBuildingPrivlidge",
      "nameWithType": "Rust.UserIDsFromBuildingPrivlidge",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDsFromBuildingPrivlidge"
    },
    {
      "uid": "BuildingPrivlidge",
      "commentId": "T:BuildingPrivlidge",
      "isExternal": true,
      "name": "BuildingPrivlidge",
      "nameWithType": "BuildingPrivlidge",
      "fullName": "BuildingPrivlidge"
    },
    {
      "uid": "System.Array",
      "commentId": "T:System.Array",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.array",
      "name": "Array",
      "nameWithType": "Array",
      "fullName": "System.Array"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer(BasePlayer)",
      "name": "UserIDFromPlayer",
      "nameWithType": "Rust.UserIDFromPlayer",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.UserIDFromPlayer"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity(BaseEntity)",
      "name": "OwnerIDFromEntity",
      "nameWithType": "Rust.OwnerIDFromEntity",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.OwnerIDFromEntity"
    },
    {
      "uid": "BaseEntity",
      "commentId": "T:BaseEntity",
      "isExternal": true,
      "name": "BaseEntity",
      "nameWithType": "BaseEntity",
      "fullName": "BaseEntity"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayer*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.FindPlayer",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.FindPlayer(System.String)",
      "name": "FindPlayer",
      "nameWithType": "Rust.FindPlayer",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayer"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.FindPlayerByName",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.FindPlayerByName(System.String)",
      "name": "FindPlayerByName",
      "nameWithType": "Rust.FindPlayerByName",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByName"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.FindPlayerById",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.FindPlayerById(System.UInt64)",
      "name": "FindPlayerById",
      "nameWithType": "Rust.FindPlayerById",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerById"
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
      "uid": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString(System.String)",
      "name": "FindPlayerByIdString",
      "nameWithType": "Rust.FindPlayerByIdString",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.FindPlayerByIdString"
    },
    {
      "uid": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition*",
      "commentId": "Overload:Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition",
      "href": "Oxide.Game.Rust.Libraries.Rust.html#Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition(BasePlayer,System.Single,System.Single,System.Single)",
      "name": "ForcePlayerPosition",
      "nameWithType": "Rust.ForcePlayerPosition",
      "fullName": "Oxide.Game.Rust.Libraries.Rust.ForcePlayerPosition"
    },
    {
      "uid": "System.Single",
      "commentId": "T:System.Single",
      "parent": "System",
      "isExternal": true,
      "href": "https://learn.microsoft.com/dotnet/api/system.single",
      "name": "float",
      "nameWithType": "float",
      "fullName": "float",
      "nameWithType.vb": "Single",
      "fullName.vb": "Single",
      "name.vb": "Single"
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