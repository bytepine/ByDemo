using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_Bool", "UnrealSharp.Flow.FlowDataPinResult_Bool")]
public partial struct FFlowDataPinResult_Bool : MarshalledStruct<FFlowDataPinResult_Bool>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    public bool Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_Bool()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_Bool");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_Bool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_Bool FromNative(IntPtr buffer) => new FFlowDataPinResult_Bool(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            BoolMarshaller.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinResult_BoolMarshaller
{
    public static FFlowDataPinResult_Bool FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_Bool(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_Bool obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_Bool.NativeDataSize;
    }
}