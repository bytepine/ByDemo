using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowPinHandle", "UnrealSharp.Flow.FlowPinHandle")]
public partial struct FFlowPinHandle : MarshalledStruct<FFlowPinHandle>
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
    static FFlowPinHandle()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowPinHandle");
        IntPtr PinName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinName");
        PinName_Offset = FPropertyExporter.CallGetPropertyOffset(PinName_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowPinHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            PinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, PinName_Offset), 0);
        }
    }
    
    public static FFlowPinHandle FromNative(IntPtr buffer) => new FFlowPinHandle(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, PinName_Offset), 0, PinName);
        }
    }
}

public static class FFlowPinHandleMarshaller
{
    public static FFlowPinHandle FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowPinHandle(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowPinHandle obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowPinHandle.NativeDataSize;
    }
}