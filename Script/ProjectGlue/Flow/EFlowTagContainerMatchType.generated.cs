using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UEnum, GeneratedType("EFlowTagContainerMatchType", "UnrealSharp.Flow.EFlowTagContainerMatchType")]
public enum EFlowTagContainerMatchType : byte
{
    /// <summary>
    /// Check if container A contains ANY of the tags in the specified container B.
    /// </summary>
    HasAny = 0,
    /// <summary>
    /// Check if container A contains ANY of the tags in the specified container B, only allowing exact matches.
    /// </summary>
    HasAnyExact = 1,
    /// <summary>
    /// Check if container A contains ALL of the tags in the specified container B.
    /// </summary>
    HasAll = 2,
    /// <summary>
    /// Check if container A contains ALL of the tags in the specified container B, only allowing exact matches
    /// </summary>
    HasAllExact = 3,
}