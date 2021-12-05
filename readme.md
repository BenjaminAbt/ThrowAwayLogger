# ThrowAwayLogger

`ThrowAwayLogger` is an implementation of [ILogger](https://docs.microsoft.com/dotnet/core/extensions/custom-logging-provider?WT.mc_id=DT-MVP-5001507) as well as [ILogger<T>](https://docs.microsoft.com/dotnet/core/extensions/custom-logging-provider?WT.mc_id=DT-MVP-5001507) which does nothing. Really: nothing.

Very handy for benchmarks or simple testing.

## NuGet

[BenjaminAbt.Extensions.Logger.ThrowAwayLogger](https://www.nuget.org/packages/BenjaminAbt.Extensions.Logger.ThrowAwayLogger/)

## Sample

```csharp
private ILogger _log = new NobodyCaresLogger();
_log.Log(LogLevel.Information, _ex, "Test " + _message);
```

Nothing happens ¯\_(ツ)_/¯
