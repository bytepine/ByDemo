using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Logical AND
/// Output will be triggered only once
/// </summary>
[UClass, GeneratedType("FlowNode_LogicalAND", "UnrealSharp.Flow.FlowNode_LogicalAND")]
public partial class UFlowNode_LogicalAND : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_LogicalAND()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_LogicalAND");
        ExecutedInputNames_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExecutedInputNames");
        ExecutedInputNames_Offset = FPropertyExporter.CallGetPropertyOffset(ExecutedInputNames_NativeProperty);
    }
    
    static int ExecutedInputNames_Offset;
    static IntPtr ExecutedInputNames_NativeProperty;
    SetMarshaller<FName> ExecutedInputNames_Marshaller = null;
    
    private System.Collections.Generic.ISet<FName> ExecutedInputNames
    {
        get
        {
            ExecutedInputNames_Marshaller ??= new SetMarshaller<FName>(ExecutedInputNames_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            return ExecutedInputNames_Marshaller.FromNative(IntPtr.Add(NativeObject, ExecutedInputNames_Offset), 0);
        }
    }
    
    
}