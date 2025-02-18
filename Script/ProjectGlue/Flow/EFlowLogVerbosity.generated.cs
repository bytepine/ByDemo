using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Variant of ELogVerbosity
/// </summary>
[UEnum, GeneratedType("EFlowLogVerbosity", "UnrealSharp.Flow.EFlowLogVerbosity")]
public enum EFlowLogVerbosity : byte
{
    /// <summary>
    /// Prints a message to console (and log file)
    /// </summary>
    Error = 0,
    /// <summary>
    /// Prints a message to console (and log file)
    /// </summary>
    Warning = 1,
    /// <summary>
    /// Prints a message to console (and log file)
    /// </summary>
    Display = 2,
    /// <summary>
    /// Prints a message to a log file (does not print to console)
    /// </summary>
    Log = 3,
    /// <summary>
    /// Prints a verbose message to a log file (if Verbose logging is enabled for the given category, usually used for detailed logging)
    /// </summary>
    Verbose = 4,
    /// <summary>
    /// Prints a verbose message to a log file (if VeryVerbose logging is enabled, usually used for detailed logging that would otherwise spam output)
    /// </summary>
    VeryVerbose = 5,
}