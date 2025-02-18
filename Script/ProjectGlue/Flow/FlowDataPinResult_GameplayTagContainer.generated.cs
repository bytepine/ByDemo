using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_GameplayTagContainer", "UnrealSharp.Flow.FlowDataPinResult_GameplayTagContainer")]
public partial struct FFlowDataPinResult_GameplayTagContainer : MarshalledStruct<FFlowDataPinResult_GameplayTagContainer>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    public UnrealSharp.GameplayTags.FGameplayTagContainer Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_GameplayTagContainer()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_GameplayTagContainer");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_GameplayTagContainer(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_GameplayTagContainer FromNative(IntPtr buffer) => new FFlowDataPinResult_GameplayTagContainer(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinResult_GameplayTagContainerMarshaller
{
    public static FFlowDataPinResult_GameplayTagContainer FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_GameplayTagContainer(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_GameplayTagContainer obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_GameplayTagContainer.NativeDataSize;
    }
}