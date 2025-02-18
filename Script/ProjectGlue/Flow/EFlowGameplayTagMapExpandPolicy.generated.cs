using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// NOTE (gtaylor) The choice of which EFlowGameplayTagMapExpandPolicy to use will be informed by the map's tolerance
///  for memory vs. lookup performance.  If speed is not a concern, then fully expanding with AllSubtags can
///  make for a single-tech lookup.  If memory is more of a concern, then NoExpand will store the minimal information
///  in the map keys (potentially requiring multiple parent searches in TryLookupGameplayTagKey).  If only the leaf tags
///  will be used for lookup, then LeafSubtags expansion policy is a good option.
/// </summary>
[UEnum, GeneratedType("EFlowGameplayTagMapExpandPolicy", "UnrealSharp.Flow.EFlowGameplayTagMapExpandPolicy")]
public enum EFlowGameplayTagMapExpandPolicy : sbyte
{
    AllSubtags = 0,
    /// <summary>
    /// Apply the payload to all of the tag's child tags
    /// </summary>
    LeafSubtags = 1,
    /// <summary>
    /// Apply the payload to the tag's leaf child tags
    /// </summary>
    RemoveSubtags = 2,
    /// <summary>
    /// Remove all of the keys in the result map of the tag's child tags
    /// </summary>
    NoExpand = 3,
    /// <summary>
    /// Only apply the payload patch to the tag, make no changes to it's child tags
    /// </summary>
    Max = 4,
    Invalid,
    Min = 0,
}