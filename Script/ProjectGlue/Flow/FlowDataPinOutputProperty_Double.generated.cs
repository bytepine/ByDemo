using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a Double (64bit float) that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Double", "UnrealSharp.Flow.FlowDataPinOutputProperty_Double")]
public partial struct FFlowDataPinOutputProperty_Double : MarshalledStruct<FFlowDataPinOutputProperty_Double>
{
    // Value
    
    static int Value_Offset;
    public double Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Double()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Double");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Double(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_Double FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Double(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_DoubleMarshaller
{
    public static FFlowDataPinOutputProperty_Double FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Double(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Double obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Double.NativeDataSize;
    }
}