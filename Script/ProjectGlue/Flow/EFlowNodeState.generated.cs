using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowNodeState", "UnrealSharp.Flow.EFlowNodeState")]
public enum EFlowNodeState : byte
{
    NeverActivated = 0,
    Active = 1,
    Completed = 2,
    Aborted = 3,
    Max = 4,
    Invalid = 5,
    Min = 0,
}