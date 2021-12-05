// Made by Benjamin Abt - https://github.com/BenjaminAbt

using System;
using Microsoft.Extensions.Logging;

/// <summary>
/// Ignores all logging
/// </summary>
public class ThrowAwayLogger : ILogger, IDisposable
{
    /// <summary>
    ///  writes logging into the universe
    /// </summary>
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }

    /// <summary>
    /// true
    /// </summary>
    public bool IsEnabled(LogLevel logLevel) => true;

    /// <summary>
    /// this
    /// </summary>
    public IDisposable BeginScope<TState>(TState state) => this;

    /// <summary>
    /// well, dispose?
    /// </summary>
    public void Dispose() { }
}

/// <summary>
/// Ignores all logging
/// </summary>
public class ThrowAwayLogger<T> : ILogger<T>, IDisposable
{
    /// <summary>
    ///  writes logging into the universe
    /// </summary>
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }

    /// <summary>
    /// true
    /// </summary>
    public bool IsEnabled(LogLevel logLevel) => true;

    /// <summary>
    /// this
    /// </summary>
    public IDisposable BeginScope<TState>(TState state) => this;

    /// <summary>
    /// well, dispose?
    /// </summary>
    public void Dispose() { }
}
