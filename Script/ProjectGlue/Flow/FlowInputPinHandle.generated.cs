using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowInputPinHandle", "UnrealSharp.Flow.FlowInputPinHandle")]
public partial struct FFlowInputPinHandle : MarshalledStruct<FFlowInputPinHandle>
{
    // PinName
    
    static int PinName_Offset;
    /// <summary>
    /// Update SFlowPinHandleBase code if this property name would be ever changed
    /// </summary>
    public FName PinName;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowInputPinHandle()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowInputPinHandle");
        IntPtr PinName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinName");
        PinName_Offset = FPropertyExporter.CallGetPropertyOffset(PinName_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowInputPinHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            PinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, PinName_Offset), 0);
        }
    }
    
    public static FFlowInputPinHandle FromNative(IntPtr buffer) => new FFlowInputPinHandle(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, PinName_Offset), 0, PinName);
        }
    }
}

public static class FFlowInputPinHandleMarshaller
{
    public static FFlowInputPinHandle FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowInputPinHandle(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowInputPinHandle obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowInputPinHandle.NativeDataSize;
    }
}