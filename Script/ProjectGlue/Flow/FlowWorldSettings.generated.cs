using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// World Settings used to start a Flow for this world
/// </summary>
[UClass, GeneratedType("FlowWorldSettings", "UnrealSharp.Flow.FlowWorldSettings")]
public partial class AFlowWorldSettings : UnrealSharp.Engine.AWorldSettings
{
    static readonly IntPtr NativeClassPtr;
    static AFlowWorldSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowWorldSettings");
        IntPtr FlowComponent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowComponent");
        FlowComponent_Offset = FPropertyExporter.CallGetPropertyOffset(FlowComponent_NativeProperty);
    }
    
    static int FlowComponent_Offset;
    
    public UnrealSharp.Flow.UFlowComponent FlowComponent
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.FromNative(IntPtr.Add(NativeObject, FlowComponent_Offset), 0);
        }
        init
        {
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(NativeObject, FlowComponent_Offset), 0, value);
        }
    }
    
    
}