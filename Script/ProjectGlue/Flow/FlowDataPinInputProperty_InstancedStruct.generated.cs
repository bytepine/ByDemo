using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinInputProperty_InstancedStruct", "UnrealSharp.Flow.FlowDataPinInputProperty_InstancedStruct")]
public partial struct FFlowDataPinInputProperty_InstancedStruct : MarshalledStruct<FFlowDataPinInputProperty_InstancedStruct>
{
    // Value
    
    static int Value_Offset;
    public UnrealSharp.CoreUObject.FInstancedStruct Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinInputProperty_InstancedStruct()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinInputProperty_InstancedStruct");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinInputProperty_InstancedStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinInputProperty_InstancedStruct FromNative(IntPtr buffer) => new FFlowDataPinInputProperty_InstancedStruct(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinInputProperty_InstancedStructMarshaller
{
    public static FFlowDataPinInputProperty_InstancedStruct FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinInputProperty_InstancedStruct(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinInputProperty_InstancedStruct obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinInputProperty_InstancedStruct.NativeDataSize;
    }
}