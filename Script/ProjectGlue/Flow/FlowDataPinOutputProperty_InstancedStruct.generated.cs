using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a FInstancedStruct that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_InstancedStruct", "UnrealSharp.Flow.FlowDataPinOutputProperty_InstancedStruct")]
public partial struct FFlowDataPinOutputProperty_InstancedStruct : MarshalledStruct<FFlowDataPinOutputProperty_InstancedStruct>
{
    // Value
    
    static int Value_Offset;
    public UnrealSharp.CoreUObject.FInstancedStruct Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_InstancedStruct()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_InstancedStruct");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_InstancedStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_InstancedStruct FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_InstancedStruct(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_InstancedStructMarshaller
{
    public static FFlowDataPinOutputProperty_InstancedStruct FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_InstancedStruct(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_InstancedStruct obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_InstancedStruct.NativeDataSize;
    }
}