# Developer Tips

## Installing C#

Download C# Version [10.0.401](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-10.0.401-windows-x64-installer).

Verify installation with `dotnet --version`.

## Running the project

``` PowerShell
cd trump-as-a-service
dotnet run
```

## Building .exe

``` PowerShell
dotnet publish -c Release -r win-x64 -p:PublishAot=true
```
