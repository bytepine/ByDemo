using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a bool that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Bool", "UnrealSharp.Flow.FlowDataPinOutputProperty_Bool")]
public partial struct FFlowDataPinOutputProperty_Bool : MarshalledStruct<FFlowDataPinOutputProperty_Bool>
{
    // Value
    
    static int Value_Offset;
    public bool Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Bool()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Bool");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Bool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_Bool FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Bool(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_BoolMarshaller
{
    public static FFlowDataPinOutputProperty_Bool FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Bool(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Bool obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Bool.NativeDataSize;
    }
}