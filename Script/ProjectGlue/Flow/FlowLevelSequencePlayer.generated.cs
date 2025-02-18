using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Custom ULevelSequencePlayer allows for binding Flow Nodes to Level Sequence events
/// </summary>
[UClass, GeneratedType("FlowLevelSequencePlayer", "UnrealSharp.Flow.FlowLevelSequencePlayer")]
public partial class UFlowLevelSequencePlayer : UnrealSharp.LevelSequence.ULevelSequencePlayer
{
    static readonly IntPtr NativeClassPtr;
    static UFlowLevelSequencePlayer()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowLevelSequencePlayer");
        IntPtr FlowEventReceiver_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowEventReceiver");
        FlowEventReceiver_Offset = FPropertyExporter.CallGetPropertyOffset(FlowEventReceiver_NativeProperty);
    }
    
    static int FlowEventReceiver_Offset;
    
    /// <summary>
    /// most likely this is a UFlowNode_PlayLevelSequence or its child
    /// </summary>
    private UnrealSharp.Flow.UFlowNode FlowEventReceiver
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative(IntPtr.Add(NativeObject, FlowEventReceiver_Offset), 0);
        }
    }
    
    
}