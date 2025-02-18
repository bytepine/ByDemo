using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinResult_Class", "UnrealSharp.Flow.FlowDataPinResult_Class")]
public partial struct FFlowDataPinResult_Class : MarshalledStruct<FFlowDataPinResult_Class>
{
    // Result
    
    static int Result_Offset;
    /// <summary>
    /// Result for the DataPin resolve attempt
    /// </summary>
    public UnrealSharp.Flow.EFlowDataPinResolveResult Result;
    
    // ValuePath
    
    static int ValuePath_Offset;
    /// <summary>
    /// SoftClassPath version of the result
    /// (both the SoftClassPath and the UClass (if available) will be set for the result)
    /// </summary>
    public UnrealSharp.CoreUObject.FSoftClassPath ValuePath;
    
    // ValueClass
    
    static int ValueClass_Offset;
    /// <summary>
    /// UClass version of the result
    /// (both the SoftClassPath and the UClass (if available) will be set for the result)
    /// </summary>
    public TSubclassOf<UnrealSharp.CoreUObject.UObject> ValueClass;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinResult_Class()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinResult_Class");
        IntPtr Result_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Result");
        Result_Offset = FPropertyExporter.CallGetPropertyOffset(Result_NativeProperty);
        IntPtr ValuePath_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ValuePath");
        ValuePath_Offset = FPropertyExporter.CallGetPropertyOffset(ValuePath_NativeProperty);
        IntPtr ValueClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ValueClass");
        ValueClass_Offset = FPropertyExporter.CallGetPropertyOffset(ValueClass_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinResult_Class(IntPtr InNativeStruct)
    {
        unsafe
        {
            Result = EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0);
            ValuePath = StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.FromNative(IntPtr.Add(InNativeStruct, ValuePath_Offset), 0);
            ValueClass = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, ValueClass_Offset), 0);
        }
    }
    
    public static FFlowDataPinResult_Class FromNative(IntPtr buffer) => new FFlowDataPinResult_Class(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowDataPinResolveResult>.ToNative(IntPtr.Add(buffer, Result_Offset), 0, Result);
            StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.ToNative(IntPtr.Add(buffer, ValuePath_Offset), 0, ValuePath);
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, ValueClass_Offset), 0, ValueClass);
        }
    }
}

public static class FFlowDataPinResult_ClassMarshaller
{
    public static FFlowDataPinResult_Class FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinResult_Class(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinResult_Class obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinResult_Class.NativeDataSize;
    }
}