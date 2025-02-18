using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowNodeStyle", "UnrealSharp.Flow.EFlowNodeStyle")]
public enum EFlowNodeStyle : byte
{
    /// <summary>
    /// Deprecated EFlowNodeStyle enum (use NodeDisplayStyle tag instead)
    /// </summary>
    Condition = 0,
    Default = 1,
    InOut = 2,
    Latent = 3,
    Logic = 4,
    SubGraph = 5,
    Custom = 6,
    Max = 7,
    Invalid = 8,
    Min = 0,
}