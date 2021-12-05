// Made by Benjamin Abt - https://github.com/BenjaminAbt

using System;
using Microsoft.Extensions.Logging;

public class ThrowAwayLogger : ILogger, IDisposable
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }

    public bool IsEnabled(LogLevel logLevel) => true;
    public IDisposable BeginScope<TState>(TState state) => this;
    public void Dispose() { }
}

public class ThrowAwayLogger<T> : ILogger<T>, IDisposable
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }

    public bool IsEnabled(LogLevel logLevel) => true;
    public IDisposable BeginScope<TState>(TState state) => this;
    public void Dispose() { }
}
