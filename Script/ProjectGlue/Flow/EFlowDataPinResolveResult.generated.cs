using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Result enum for TryResolveDataPinAs...() functions
/// </summary>
[UEnum, GeneratedType("EFlowDataPinResolveResult", "UnrealSharp.Flow.EFlowDataPinResolveResult")]
public enum EFlowDataPinResolveResult : byte
{
    /// <summary>
    /// Pin resolved successfully
    /// </summary>
    Success = 0,
    /// <summary>
    /// The pin is not connected to another pin
    /// </summary>
    FailedUnconnected = 1,
    /// <summary>
    /// The pin name is unknown
    /// </summary>
    FailedUnknownPin = 2,
    /// <summary>
    /// The pin was requested as an unsupported type
    /// </summary>
    FailedMismatchedType = 3,
    /// <summary>
    /// The Flow Node or AddOn did not implement the necessary function to provide this value
    /// </summary>
    FailedUnimplemented = 4,
    /// <summary>
    /// Failed due to missing pin (may just need re-save for the asset)
    /// </summary>
    FailedMissingPin = 5,
    /// <summary>
    /// Failed with an error message (see the error log)
    /// </summary>
    FailedWithError = 6,
    Max = 7,
    Invalid = 8,
    Min = 0,
}