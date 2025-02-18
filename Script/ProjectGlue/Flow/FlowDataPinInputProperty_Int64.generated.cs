using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinInputProperty_Int64", "UnrealSharp.Flow.FlowDataPinInputProperty_Int64")]
public partial struct FFlowDataPinInputProperty_Int64 : MarshalledStruct<FFlowDataPinInputProperty_Int64>
{
    // Value
    
    static int Value_Offset;
    public long Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinInputProperty_Int64()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinInputProperty_Int64");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinInputProperty_Int64(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<long>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinInputProperty_Int64 FromNative(IntPtr buffer) => new FFlowDataPinInputProperty_Int64(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<long>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinInputProperty_Int64Marshaller
{
    public static FFlowDataPinInputProperty_Int64 FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinInputProperty_Int64(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinInputProperty_Int64 obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinInputProperty_Int64.NativeDataSize;
    }
}