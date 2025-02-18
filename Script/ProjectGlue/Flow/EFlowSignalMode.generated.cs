using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowSignalMode", "UnrealSharp.Flow.EFlowSignalMode")]
public enum EFlowSignalMode : byte
{
    /// <summary>
    /// Default state, node is fully executed.
    /// </summary>
    Enabled = 0,
    /// <summary>
    /// No logic executed, any Input Pin activation is ignored. Node instantly enters a deactivated state.
    /// </summary>
    Disabled = 1,
    /// <summary>
    /// Internal node logic not executed. All connected outputs are triggered, node finishes its work.
    /// </summary>
    PassThrough = 2,
}