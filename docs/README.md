# Multiple Entry Points in .NET Applications.

This repository aims to show how it is possible to have multiple entry-points within an application, 
even to the extent that multiple applications can share an entry-point, via Shared Projects.

## Build Configurations

I have included four different Build configurations:

 - **IMPLICIT:** - This flag is also included within ***Debug*** and ***Release*** configurations, and shows the OOBE behaviour.
 - **EXPLICIT:** - This sets the Startup Object to be `$(AssemblyName).ExplicitEntryPoint`. This entry point is within the same assembly.
 - **SHARED:** - This sets the Startup Object to be `SharedEntryPoints.SharedProgram`. This entry point is ***NOT*** within the same assembly.
 - **TLS:** - This sets the project to use the implicitly generated link to the TLS file within the assembly.

 In each case, you can see that there is no `Program.cs` file in either assembly, or the Shared Project.
 
 Top Level Statements are purely a language feature. We can see that all three projects, `net7.0`, `net5.0`, and `netstandard2.0`
 all have TLS enabled, and active, when in `TLS` configuration. So long as the project is running C# version 9.0 or higher, then
 TLS will be the first default implicit entry point to be run. If no TLS files are found, then the first `static void Main(...)`
 class will be used.

 By running each project, in each configuration, you can see how the entry-point shifts down the line.