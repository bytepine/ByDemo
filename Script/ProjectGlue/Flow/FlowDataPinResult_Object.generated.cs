using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_Object", "UnrealSharp.Flow.FlowDataPinResult_Object")]
public partial struct FFlowDataPinResult_Object : MarshalledStruct<FFlowDataPinResult_Object>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    public UnrealSharp.CoreUObject.UObject Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_Object()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_Object");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_Object(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_Object FromNative(IntPtr buffer) => new FFlowDataPinResult_Object(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinResult_ObjectMarshaller
{
    public static FFlowDataPinResult_Object FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_Object(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_Object obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_Object.NativeDataSize;
    }
}