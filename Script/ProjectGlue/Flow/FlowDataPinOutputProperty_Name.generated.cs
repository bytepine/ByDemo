using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a FName that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Name", "UnrealSharp.Flow.FlowDataPinOutputProperty_Name")]
public partial struct FFlowDataPinOutputProperty_Name : MarshalledStruct<FFlowDataPinOutputProperty_Name>
{
    // Value
    
    static int Value_Offset;
    public FName Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Name()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Name");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Name(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinOutputProperty_Name FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Name(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_NameMarshaller
{
    public static FFlowDataPinOutputProperty_Name FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Name(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Name obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Name.NativeDataSize;
    }
}