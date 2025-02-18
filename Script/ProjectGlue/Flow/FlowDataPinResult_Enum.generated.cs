using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_Enum", "UnrealSharp.Flow.FlowDataPinResult_Enum")]
public partial struct FFlowDataPinResult_Enum : MarshalledStruct<FFlowDataPinResult_Enum>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // Value
    
    static int Value_Offset;
    /// <summary>
    /// The selected enum Value
    /// </summary>
    public FName Value;
    
    // EnumClass
    
    static int EnumClass_Offset;
    /// <summary>
    /// Class for this enum
    /// </summary>
    public UnrealSharp.CoreUObject.UEnum EnumClass;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_Enum()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_Enum");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        IntPtr EnumClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EnumClass");
        EnumClass_Offset = FPropertyExporter.CallGetPropertyOffset(EnumClass_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_Enum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            Value = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
            EnumClass = ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.FromNative(IntPtr.Add(InNativeStruct, EnumClass_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_Enum FromNative(IntPtr buffer) => new FFlowDataPinResult_Enum(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
            ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.ToNative(IntPtr.Add(buffer, EnumClass_Offset), 0, EnumClass);
        }
    }
}

public static class FFlowDataPinResult_EnumMarshaller
{
    public static FFlowDataPinResult_Enum FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_Enum(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_Enum obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_Enum.NativeDataSize;
    }
}