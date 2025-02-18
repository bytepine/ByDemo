using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("SimpleFlowComponentEvent__DelegateSignature"), UMultiDelegate]
public delegate void SimpleFlowComponentEvent(UnrealSharp.Flow.UFlowComponent component);

public partial class USimpleFlowComponentEvent : MulticastDelegate<SimpleFlowComponentEvent>
{
    // FSimpleFlowComponentEvent
    static IntPtr FSimpleFlowComponentEvent_NativeFunction;
    static int FSimpleFlowComponentEvent_ParamsSize;
    static int FSimpleFlowComponentEvent_Component_Offset;
    
    protected void Invoker(UnrealSharp.Flow.UFlowComponent component)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FSimpleFlowComponentEvent_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FSimpleFlowComponentEvent_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, FSimpleFlowComponentEvent_Component_Offset), 0, component);
            
            ProcessDelegate(ParamsBuffer);
            
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FSimpleFlowComponentEvent_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
        FSimpleFlowComponentEvent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FSimpleFlowComponentEvent_NativeFunction);
        FSimpleFlowComponentEvent_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FSimpleFlowComponentEvent_NativeFunction, "Component");
    }
}