using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a Float (32bit) that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Float", "UnrealSharp.Flow.FlowDataPinOutputProperty_Float")]
public partial struct FFlowDataPinOutputProperty_Float : MarshalledStruct<FFlowDataPinOutputProperty_Float>
{
    // Value
    
    static int Value_Offset;
    public float Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Float()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Float");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Float(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_Float FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Float(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_FloatMarshaller
{
    public static FFlowDataPinOutputProperty_Float FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Float(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Float obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Float.NativeDataSize;
    }
}