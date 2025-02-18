using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// FlowNode to define data pin property literals for use connecting to data pin inputs in a flow graph
/// </summary>
[UClass, GeneratedType("FlowNode_DefineProperties", "UnrealSharp.Flow.FlowNode_DefineProperties")]
public partial class UFlowNode_DefineProperties : UnrealSharp.Flow.UFlowNode, UnrealSharp.Flow.IFlowDataPinGeneratorNodeInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_DefineProperties()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_DefineProperties");
        OutputProperties_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OutputProperties");
        OutputProperties_Offset = FPropertyExporter.CallGetPropertyOffset(OutputProperties_NativeProperty);
    }
    
    static int OutputProperties_Offset;
    static IntPtr OutputProperties_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowNamedDataPinOutputProperty> OutputProperties_Marshaller = null;
    
    /// <summary>
    /// Instance-defined properties.
    /// These will auto-generate a matching pin that is bound to its property as its data source.
    /// </summary>
    protected System.Collections.Generic.IList<UnrealSharp.Flow.FFlowNamedDataPinOutputProperty> Properties
    {
        get
        {
            OutputProperties_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowNamedDataPinOutputProperty>(OutputProperties_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowNamedDataPinOutputProperty>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowNamedDataPinOutputProperty>.FromNative);
            return OutputProperties_Marshaller.FromNative(IntPtr.Add(NativeObject, OutputProperties_Offset), 0);
        }
    }
    
    
}