using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Executes all outputs sequentially
/// </summary>
[UClass, GeneratedType("FlowNode_ExecutionSequence", "UnrealSharp.Flow.FlowNode_ExecutionSequence")]
public partial class UFlowNode_ExecutionSequence : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_ExecutionSequence()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_ExecutionSequence");
        IntPtr bSavePinExecutionState_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSavePinExecutionState");
        bSavePinExecutionState_Offset = FPropertyExporter.CallGetPropertyOffset(bSavePinExecutionState_NativeProperty);
        ExecutedConnections_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExecutedConnections");
        ExecutedConnections_Offset = FPropertyExporter.CallGetPropertyOffset(ExecutedConnections_NativeProperty);
    }
    
    static int bSavePinExecutionState_Offset;
    
    /// <summary>
    /// If enabled and the graph is saved during gameplay, this node
    /// tracks and saves which pins it has executed.
    /// 
    /// If you add new connections or replace old connections with with
    /// different nodes, this node will detect the changes. If during gameplay
    /// you load an old save game which had different connections, this node
    /// will automatically execute the updated connections you created.
    /// </summary>
    protected bool SavePinExecutionState
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bSavePinExecutionState_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bSavePinExecutionState_Offset), 0, value);
        }
    }
    
    
    static int ExecutedConnections_Offset;
    static IntPtr ExecutedConnections_NativeProperty;
    SetMarshaller<UnrealSharp.CoreUObject.FGuid> ExecutedConnections_Marshaller = null;
    
    protected System.Collections.Generic.ISet<UnrealSharp.CoreUObject.FGuid> ExecutedConnections
    {
        get
        {
            ExecutedConnections_Marshaller ??= new SetMarshaller<UnrealSharp.CoreUObject.FGuid>(ExecutedConnections_NativeProperty, StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative);
            return ExecutedConnections_Marshaller.FromNative(IntPtr.Add(NativeObject, ExecutedConnections_Offset), 0);
        }
    }
    
    
}