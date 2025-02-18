using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_Int", "UnrealSharp.Flow.FlowDataPinResult_Int")]
public partial struct FFlowDataPinResult_Int : MarshalledStruct<FFlowDataPinResult_Int>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    public long Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_Int()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_Int");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_Int(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = BlittableMarshaller<long>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_Int FromNative(IntPtr buffer) => new FFlowDataPinResult_Int(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            BlittableMarshaller<long>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinResult_IntMarshaller
{
    public static FFlowDataPinResult_Int FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_Int(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_Int obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_Int.NativeDataSize;
    }
}