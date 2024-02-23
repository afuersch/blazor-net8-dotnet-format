# Project

This is the Blazor WASM sample application created from the template.

The only code differences to the template are that the `Counter` and `Weather` pages use a partial code behind file.

```
- Pages
    - Counter.razor
        - Counter.razor.cs
    - Weather.razor
        - Weather.razor.cs
```

## Build

The `.\build.cmd` builds the solution.

## Format

`.\format.cmd` formats the code using `dotnet format` according the `.editorconfig` file.

## Verify code styles

`.\format-verify.cmd` verifies the code using `dotnet format style --verify-no-changes` according the `.editorconfig` file.

# Problem

Since the .NET SDK update to version `8.0.200` the format tool doesn't link the Razor pages with their code behind files anymore.
E.g. the verify no style changes command brings up `IDE0051` error and says that the Click event handler defined in the code behind file is unused.
```
D:\source\github\blazor-net8-dotnet-format> .\format-verify.cmd
D:\source\github\blazor-net8-dotnet-format>dotnet format BlazorApp.sln style --verify-no-changes

D:\source\github\blazor-net8-dotnet-format\BlazorApp\Pages\Counter.razor.cs(9,18): warning IDE0051: Private member 'Counter.IncrementCount' is unused [D:\source\github\blazor-net8-dotnet-format\BlazorApp\BlazorApp.csproj]
```

Running `dotnet format` formats the `Counter.razor.cs` file and removes the `IncrementCount()` method.

```
D:\source\github\blazor-net8-dotnet-format>dotnet format BlazorApp.sln -v normal
  Formatting code files in workspace 'D:\source\github\blazor-net8-dotnet-format\BlazorApp.sln'.
  Formatted code file 'D:\source\github\blazor-net8-dotnet-format\BlazorApp\Pages\Counter.razor.cs'.
  Format complete in 5646ms.
```

The automatically removed method leads to a failed build.

```
D:\source\github\blazor-net8-dotnet-format>dotnet build BlazorApp.sln
MSBuild version 17.9.4+90725d08d for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
D:\source\github\blazor-net8-dotnet-format\BlazorApp\Pages\Counter.razor(9,44): error CS0103: The name 'IncrementCount' does not exist in the current context [D:\
source\github\blazor-net8-dotnet-format\BlazorApp\BlazorApp.csproj]

Build FAILED.

D:\source\github\blazor-net8-dotnet-format\BlazorApp\Pages\Counter.razor(9,44): error CS0103: The name 'IncrementCount' does not exist in the current context [D:\
source\github\blazor-net8-dotnet-format\BlazorApp\BlazorApp.csproj]
    0 Warning(s)
    1 Error(s)

Time Elapsed 00:00:04.26
```

## Environment

### .NET

```
> dotnet --info
.NET SDK:
 Version:           8.0.200
 Commit:            438cab6a9d
 Workload version:  8.0.200-manifests.e575128c

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.22631
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\8.0.200\

.NET workloads installed:
There are no installed workloads to display.

Host:
  Version:      8.0.2
  Architecture: x64
  Commit:       1381d5ebd2

.NET SDKs installed:
  7.0.313 [C:\Program Files\dotnet\sdk]
  7.0.406 [C:\Program Files\dotnet\sdk]
  8.0.102 [C:\Program Files\dotnet\sdk]
  8.0.200 [C:\Program Files\dotnet\sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 6.0.27 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 7.0.16 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 8.0.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 6.0.27 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 7.0.16 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 8.0.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 6.0.27 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 7.0.16 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 8.0.2 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]

Other architectures found:
  x86   [C:\Program Files (x86)\dotnet]
    registered at [HKLM\SOFTWARE\dotnet\Setup\InstalledVersions\x86\InstallLocation]

Environment variables:
  Not set

global.json file:
  Not found

```

### dotnet format

```sh
> dotnet format --version
8.0.453106+2651752953c0d41c8c7b8d661cf2237151af33d0
```
