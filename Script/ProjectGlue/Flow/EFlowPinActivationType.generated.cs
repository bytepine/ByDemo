using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowPinActivationType", "UnrealSharp.Flow.EFlowPinActivationType")]
public enum EFlowPinActivationType : byte
{
    Default = 0,
    Forced = 1,
    PassThrough = 2,
}