using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowAddOnAcceptResult", "UnrealSharp.Flow.EFlowAddOnAcceptResult")]
public enum EFlowAddOnAcceptResult : byte
{
    /// <summary>
    /// No result from the current operation
    /// </summary>
    Undetermined = 0,
    /// <summary>
    /// Accept, if all other conditions are met
    /// </summary>
    TentativeAccept = 1,
    /// <summary>
    /// Reject the AddOn outright, regardless if previously TentativelyAccept-ed
    /// </summary>
    Reject = 2,
    Max = 3,
    Invalid = 4,
    Min,
}