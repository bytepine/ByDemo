using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinInputProperty_Vector", "UnrealSharp.Flow.FlowDataPinInputProperty_Vector")]
public partial struct FFlowDataPinInputProperty_Vector : MarshalledStruct<FFlowDataPinInputProperty_Vector>
{
    // Value
    
    static int Value_Offset;
    public UnrealSharp.CoreUObject.FVector Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinInputProperty_Vector()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinInputProperty_Vector");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinInputProperty_Vector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = StructMarshaller<UnrealSharp.CoreUObject.FVector>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinInputProperty_Vector FromNative(IntPtr buffer) => new FFlowDataPinInputProperty_Vector(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FVector>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinInputProperty_VectorMarshaller
{
    public static FFlowDataPinInputProperty_Vector FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinInputProperty_Vector(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinInputProperty_Vector obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinInputProperty_Vector.NativeDataSize;
    }
}