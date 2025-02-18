using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Counts how many times signal entered this node
/// </summary>
[UClass, GeneratedType("FlowNode_Counter", "UnrealSharp.Flow.FlowNode_Counter")]
public partial class UFlowNode_Counter : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_Counter()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_Counter");
        IntPtr Goal_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Goal");
        Goal_Offset = FPropertyExporter.CallGetPropertyOffset(Goal_NativeProperty);
        IntPtr CurrentSum_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CurrentSum");
        CurrentSum_Offset = FPropertyExporter.CallGetPropertyOffset(CurrentSum_NativeProperty);
    }
    
    static int Goal_Offset;
    
    protected int Goal
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, Goal_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, Goal_Offset), 0, value);
        }
    }
    
    
    static int CurrentSum_Offset;
    
    private int CurrentSum
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, CurrentSum_Offset), 0);
        }
    }
    
    
}