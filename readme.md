# Environment

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

## Format

```sh
> dotnet format --version
8.0.453106+2651752953c0d41c8c7b8d661cf2237151af33d0
```

`.\format.cmd` formats the code using `dotnet format` according the `.editorconfig` file.

## Build

`.\build.cmd` builds the solution.

