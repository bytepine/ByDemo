using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Logical OR
/// Output will be triggered only once
/// </summary>
[UClass, GeneratedType("FlowNode_LogicalOR", "UnrealSharp.Flow.FlowNode_LogicalOR")]
public partial class UFlowNode_LogicalOR : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_LogicalOR()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_LogicalOR");
        IntPtr bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffset(bEnabled_NativeProperty);
        IntPtr ExecutionLimit_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExecutionLimit");
        ExecutionLimit_Offset = FPropertyExporter.CallGetPropertyOffset(ExecutionLimit_NativeProperty);
        IntPtr ExecutionCount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExecutionCount");
        ExecutionCount_Offset = FPropertyExporter.CallGetPropertyOffset(ExecutionCount_NativeProperty);
    }
    
    static int bEnabled_Offset;
    
    protected bool Enabled
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnabled_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnabled_Offset), 0, value);
        }
    }
    
    
    static int ExecutionLimit_Offset;
    
    /// <summary>
    /// This node will become Blocked (not executed any more), if Execution Limit > 0 and Execution Count reaches this limit
    /// Set this to zero, if you'd like fire output indefinitely
    /// </summary>
    protected int ExecutionLimit
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, ExecutionLimit_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, ExecutionLimit_Offset), 0, value);
        }
    }
    
    
    static int ExecutionCount_Offset;
    
    /// <summary>
    /// This node will become Blocked (not executed any more), if Execution Limit > 0 and Execution Count reaches this limit
    /// </summary>
    protected int ExecutionCount
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, ExecutionCount_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, ExecutionCount_Offset), 0, value);
        }
    }
    
    
}