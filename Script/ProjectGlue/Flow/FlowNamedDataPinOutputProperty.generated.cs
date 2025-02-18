using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper for FFlowDataPinProperty that is used for flow nodes that add
/// dynamic properties, with associated data pins, on the flow node instance
/// (as opposed to C++ or blueprint compile-time).
/// </summary>
[UStruct, GeneratedType("FlowNamedDataPinOutputProperty", "UnrealSharp.Flow.FlowNamedDataPinOutputProperty")]
public partial struct FFlowNamedDataPinOutputProperty : MarshalledStruct<FFlowNamedDataPinOutputProperty>
{
    // Name
    
    static int Name_Offset;
    /// <summary>
    /// Name of this instanced property
    /// </summary>
    public FName Name;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowNamedDataPinOutputProperty()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowNamedDataPinOutputProperty");
        IntPtr Name_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Name");
        Name_Offset = FPropertyExporter.CallGetPropertyOffset(Name_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowNamedDataPinOutputProperty(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0);
        }
    }
    
    public static FFlowNamedDataPinOutputProperty FromNative(IntPtr buffer) => new FFlowNamedDataPinOutputProperty(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, Name_Offset), 0, Name);
        }
    }
}

public static class FFlowNamedDataPinOutputPropertyMarshaller
{
    public static FFlowNamedDataPinOutputProperty FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowNamedDataPinOutputProperty(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowNamedDataPinOutputProperty obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowNamedDataPinOutputProperty.NativeDataSize;
    }
}