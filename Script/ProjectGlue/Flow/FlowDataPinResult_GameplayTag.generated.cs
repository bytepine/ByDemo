using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_GameplayTag", "UnrealSharp.Flow.FlowDataPinResult_GameplayTag")]
public partial struct FFlowDataPinResult_GameplayTag : MarshalledStruct<FFlowDataPinResult_GameplayTag>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    public UnrealSharp.GameplayTags.FGameplayTag Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_GameplayTag()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_GameplayTag");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_GameplayTag(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_GameplayTag FromNative(IntPtr buffer) => new FFlowDataPinResult_GameplayTag(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinResult_GameplayTagMarshaller
{
    public static FFlowDataPinResult_GameplayTag FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_GameplayTag(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_GameplayTag obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_GameplayTag.NativeDataSize;
    }
}