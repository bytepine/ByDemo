using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a FGameplayTagContainer that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_GameplayTagContainer", "UnrealSharp.Flow.FlowDataPinOutputProperty_GameplayTagContainer")]
public partial struct FFlowDataPinOutputProperty_GameplayTagContainer : MarshalledStruct<FFlowDataPinOutputProperty_GameplayTagContainer>
{
    // Value
    
    static int Value_Offset;
    public UnrealSharp.GameplayTags.FGameplayTagContainer Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_GameplayTagContainer()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_GameplayTagContainer");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_GameplayTagContainer(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_GameplayTagContainer FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_GameplayTagContainer(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_GameplayTagContainerMarshaller
{
    public static FFlowDataPinOutputProperty_GameplayTagContainer FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_GameplayTagContainer(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_GameplayTagContainer obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_GameplayTagContainer.NativeDataSize;
    }
}