using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Finish Policy value is read by Flow Node
/// Nodes have opportunity to terminate themselves differently if Flow Graph has been aborted
/// Example: Spawn node might despawn all actors if Flow Graph is aborted, not completed
/// </summary>
[UEnum, GeneratedType("EFlowFinishPolicy", "UnrealSharp.Flow.EFlowFinishPolicy")]
public enum EFlowFinishPolicy : byte
{
    Keep = 0,
    Abort = 1,
}