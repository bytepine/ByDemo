using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowNetMode", "UnrealSharp.Flow.EFlowNetMode")]
public enum EFlowNetMode : byte
{
    /// <summary>
    /// Any networking mode.
    /// </summary>
    Any = 0,
    /// <summary>
    /// Executed on the server or in the single-player (standalone).
    /// </summary>
    Authority = 1,
    /// <summary>
    /// Executed locally, on the single client.
    /// </summary>
    ClientOnly = 2,
    /// <summary>
    /// Executed on the server.
    /// </summary>
    ServerOnly = 3,
    /// <summary>
    /// Executed only in the single player, not available in multiplayer.
    /// </summary>
    SinglePlayerOnly = 4,
}