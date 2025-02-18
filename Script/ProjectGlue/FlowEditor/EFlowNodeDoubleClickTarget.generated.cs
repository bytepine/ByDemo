using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UEnum, GeneratedType("EFlowNodeDoubleClickTarget", "UnrealSharp.FlowEditor.EFlowNodeDoubleClickTarget")]
public enum EFlowNodeDoubleClickTarget : byte
{
    /// <summary>
    /// Open node class: either blueprint or C++ class
    /// </summary>
    NodeDefinition = 0,
    /// <summary>
    /// Open asset defined as primary asset, i.e. Dialogue asset for PlayDialogue node
    /// </summary>
    PrimaryAsset = 1,
    /// <summary>
    /// First try opening the asset then if there is none, open the node class
    /// </summary>
    PrimaryAssetOrNodeDefinition = 2,
}