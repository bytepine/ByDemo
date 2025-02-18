using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("TaggedFlowComponentEvent__DelegateSignature"), UMultiDelegate]
public delegate void TaggedFlowComponentEvent(UnrealSharp.Flow.UFlowComponent component, UnrealSharp.GameplayTags.FGameplayTagContainer tags);

public partial class UTaggedFlowComponentEvent : MulticastDelegate<TaggedFlowComponentEvent>
{
    // FTaggedFlowComponentEvent
    static IntPtr FTaggedFlowComponentEvent_NativeFunction;
    static int FTaggedFlowComponentEvent_ParamsSize;
    static int FTaggedFlowComponentEvent_Component_Offset;
    static int FTaggedFlowComponentEvent_Tags_Offset;
    
    protected void Invoker(UnrealSharp.Flow.UFlowComponent component, UnrealSharp.GameplayTags.FGameplayTagContainer tags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FTaggedFlowComponentEvent_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FTaggedFlowComponentEvent_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, FTaggedFlowComponentEvent_Component_Offset), 0, component);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, FTaggedFlowComponentEvent_Tags_Offset), 0, tags);
            
            ProcessDelegate(ParamsBuffer);
            
            
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FTaggedFlowComponentEvent_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
        FTaggedFlowComponentEvent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FTaggedFlowComponentEvent_NativeFunction);
        FTaggedFlowComponentEvent_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FTaggedFlowComponentEvent_NativeFunction, "Component");
        FTaggedFlowComponentEvent_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FTaggedFlowComponentEvent_NativeFunction, "Tags");
    }
}