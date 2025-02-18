using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Base class for nodes used to receive/send events between graphs
/// </summary>
[UClass(ClassFlags.Abstract), GeneratedType("FlowNode_CustomEventBase", "UnrealSharp.Flow.FlowNode_CustomEventBase")]
public partial class UFlowNode_CustomEventBase : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_CustomEventBase()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_CustomEventBase");
        IntPtr EventName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventName");
        EventName_Offset = FPropertyExporter.CallGetPropertyOffset(EventName_NativeProperty);
    }
    
    static int EventName_Offset;
    
    protected FName EventName
    {
        get
        {
            return BlittableMarshaller<FName>.FromNative(IntPtr.Add(NativeObject, EventName_Offset), 0);
        }
    }
    
    
}