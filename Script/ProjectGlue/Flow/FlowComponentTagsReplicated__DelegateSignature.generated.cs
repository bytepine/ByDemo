using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("FlowComponentTagsReplicated__DelegateSignature"), UMultiDelegate]
public delegate void FlowComponentTagsReplicated(UnrealSharp.Flow.UFlowComponent flowComponent, UnrealSharp.GameplayTags.FGameplayTagContainer currentTags);

public partial class UFlowComponentTagsReplicated : MulticastDelegate<FlowComponentTagsReplicated>
{
    // FFlowComponentTagsReplicated
    static IntPtr FFlowComponentTagsReplicated_NativeFunction;
    static int FFlowComponentTagsReplicated_ParamsSize;
    static int FFlowComponentTagsReplicated_FlowComponent_Offset;
    static int FFlowComponentTagsReplicated_CurrentTags_Offset;
    
    protected void Invoker(UnrealSharp.Flow.UFlowComponent flowComponent, UnrealSharp.GameplayTags.FGameplayTagContainer currentTags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FFlowComponentTagsReplicated_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FFlowComponentTagsReplicated_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, FFlowComponentTagsReplicated_FlowComponent_Offset), 0, flowComponent);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, FFlowComponentTagsReplicated_CurrentTags_Offset), 0, currentTags);
            
            ProcessDelegate(ParamsBuffer);
            
            
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FFlowComponentTagsReplicated_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
        FFlowComponentTagsReplicated_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FFlowComponentTagsReplicated_NativeFunction);
        FFlowComponentTagsReplicated_FlowComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FFlowComponentTagsReplicated_NativeFunction, "FlowComponent");
        FFlowComponentTagsReplicated_CurrentTags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FFlowComponentTagsReplicated_NativeFunction, "CurrentTags");
    }
}