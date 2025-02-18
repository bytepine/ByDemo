using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Execution of the graph always starts from this node
/// </summary>
[UClass, GeneratedType("FlowNode_Start", "UnrealSharp.Flow.FlowNode_Start")]
public partial class UFlowNode_Start : UnrealSharp.Flow.UFlowNode_DefineProperties, UnrealSharp.Flow.IFlowNodeWithExternalDataPinSupplierInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_Start()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_Start");
        IntPtr FlowDataPinValueSupplierInterface_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowDataPinValueSupplierInterface");
        FlowDataPinValueSupplierInterface_Offset = FPropertyExporter.CallGetPropertyOffset(FlowDataPinValueSupplierInterface_NativeProperty);
    }
    
    static int FlowDataPinValueSupplierInterface_Offset;
    
    /// <summary>
    /// External DataPin Value Supplier
    /// (eg, the UFlowNode_SubGraph that instanced this Start node's flow asset)
    /// </summary>
    protected UnrealSharp.Flow.IFlowDataPinValueSupplierInterface FlowDataPinValueSupplierInterface
    {
        get
        {
            return UnrealSharp.Flow.IFlowDataPinValueSupplierInterfaceMarshaller.FromNative(IntPtr.Add(NativeObject, FlowDataPinValueSupplierInterface_Offset), 0);
        }
    }
    
    
}