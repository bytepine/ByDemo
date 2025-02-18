using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinProperty", "UnrealSharp.Flow.FlowDataPinProperty")]
public partial struct FFlowDataPinProperty : MarshalledStruct<FFlowDataPinProperty>
{
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinProperty()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinProperty");
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinProperty(IntPtr InNativeStruct)
    {
        unsafe
        {
        }
    }
    
    public static FFlowDataPinProperty FromNative(IntPtr buffer) => new FFlowDataPinProperty(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
        }
    }
}

public static class FFlowDataPinPropertyMarshaller
{
    public static FFlowDataPinProperty FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinProperty(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinProperty obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinProperty.NativeDataSize;
    }
}