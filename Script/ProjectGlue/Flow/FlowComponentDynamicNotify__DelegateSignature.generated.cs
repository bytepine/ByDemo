using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("FlowComponentDynamicNotify__DelegateSignature"), UMultiDelegate]
public delegate void FlowComponentDynamicNotify(UnrealSharp.Flow.UFlowComponent flowComponent, UnrealSharp.GameplayTags.FGameplayTag notifyTag);

public partial class UFlowComponentDynamicNotify : MulticastDelegate<FlowComponentDynamicNotify>
{
    // FFlowComponentDynamicNotify
    static IntPtr FFlowComponentDynamicNotify_NativeFunction;
    static int FFlowComponentDynamicNotify_ParamsSize;
    static int FFlowComponentDynamicNotify_FlowComponent_Offset;
    static int FFlowComponentDynamicNotify_NotifyTag_Offset;
    
    protected void Invoker(UnrealSharp.Flow.UFlowComponent flowComponent, UnrealSharp.GameplayTags.FGameplayTag notifyTag)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FFlowComponentDynamicNotify_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FFlowComponentDynamicNotify_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, FFlowComponentDynamicNotify_FlowComponent_Offset), 0, flowComponent);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, FFlowComponentDynamicNotify_NotifyTag_Offset), 0, notifyTag);
            
            ProcessDelegate(ParamsBuffer);
            
            
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FFlowComponentDynamicNotify_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
        FFlowComponentDynamicNotify_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FFlowComponentDynamicNotify_NativeFunction);
        FFlowComponentDynamicNotify_FlowComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FFlowComponentDynamicNotify_NativeFunction, "FlowComponent");
        FFlowComponentDynamicNotify_NotifyTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FFlowComponentDynamicNotify_NativeFunction, "NotifyTag");
    }
}