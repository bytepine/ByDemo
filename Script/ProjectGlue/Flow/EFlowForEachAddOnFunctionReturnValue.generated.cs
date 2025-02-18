using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowForEachAddOnFunctionReturnValue", "UnrealSharp.Flow.EFlowForEachAddOnFunctionReturnValue")]
public enum EFlowForEachAddOnFunctionReturnValue : sbyte
{
    /// <summary>
    /// Continue iterating the ForEach loop
    /// </summary>
    Continue = 0,
    /// <summary>
    /// Break out of the ForEach loop, with a "Success" result (whatever that means to the TFunction)
    /// </summary>
    BreakWithSuccess = 1,
    /// <summary>
    /// Break out of the ForEach loop, with a "Failure" return (whatever that means to the TFunction)
    /// </summary>
    BreakWithFailure = 2,
    Max = 3,
    Invalid,
    Min = 0,
    ContinueForEachFirst,
    ContinueForEachLast,
}