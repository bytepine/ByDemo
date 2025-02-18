using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowOutputPinHandle", "UnrealSharp.Flow.FlowOutputPinHandle")]
public partial struct FFlowOutputPinHandle : MarshalledStruct<FFlowOutputPinHandle>
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
    static FFlowOutputPinHandle()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowOutputPinHandle");
        IntPtr PinName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinName");
        PinName_Offset = FPropertyExporter.CallGetPropertyOffset(PinName_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowOutputPinHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            PinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, PinName_Offset), 0);
        }
    }
    
    public static FFlowOutputPinHandle FromNative(IntPtr buffer) => new FFlowOutputPinHandle(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, PinName_Offset), 0, PinName);
        }
    }
}

public static class FFlowOutputPinHandleMarshaller
{
    public static FFlowOutputPinHandle FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowOutputPinHandle(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowOutputPinHandle obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowOutputPinHandle.NativeDataSize;
    }
}