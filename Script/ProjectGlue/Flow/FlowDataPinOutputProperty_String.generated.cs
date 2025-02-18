using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a FString that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_String", "UnrealSharp.Flow.FlowDataPinOutputProperty_String")]
public partial struct FFlowDataPinOutputProperty_String : MarshalledStruct<FFlowDataPinOutputProperty_String>
{
    // Value
    
    static int Value_Offset;
    static IntPtr Value_NativeProperty;
    public string Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_String()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_String");
        Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_String(IntPtr InNativeStruct)
    {
        unsafe
        {
            IntPtr Value_NativePtr = IntPtr.Add(InNativeStruct,Value_Offset);
            Value = StringMarshaller.FromNative(Value_NativePtr,0);
        }
    }
    
    public static FFlowDataPinOutputProperty_String FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_String(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            IntPtr Value_NativePtr = IntPtr.Add(buffer, Value_Offset);
            StringMarshaller.ToNative(Value_NativePtr,0,Value);
        }
    }
}

public static class FFlowDataPinOutputProperty_StringMarshaller
{
    public static FFlowDataPinOutputProperty_String FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_String(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_String obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_String.NativeDataSize;
    }
}