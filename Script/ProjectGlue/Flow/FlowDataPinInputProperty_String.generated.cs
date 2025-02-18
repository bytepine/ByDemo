using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowDataPinInputProperty_String", "UnrealSharp.Flow.FlowDataPinInputProperty_String")]
public partial struct FFlowDataPinInputProperty_String : MarshalledStruct<FFlowDataPinInputProperty_String>
{
    // Value
    
    static int Value_Offset;
    static IntPtr Value_NativeProperty;
    public string Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinInputProperty_String()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinInputProperty_String");
        Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinInputProperty_String(IntPtr InNativeStruct)
    {
        unsafe
        {
            IntPtr Value_NativePtr = IntPtr.Add(InNativeStruct,Value_Offset);
            Value = StringMarshaller.FromNative(Value_NativePtr,0);
        }
    }
    
    public static FFlowDataPinInputProperty_String FromNative(IntPtr buffer) => new FFlowDataPinInputProperty_String(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            IntPtr Value_NativePtr = IntPtr.Add(buffer, Value_Offset);
            StringMarshaller.ToNative(Value_NativePtr,0,Value);
        }
    }
}

public static class FFlowDataPinInputProperty_StringMarshaller
{
    public static FFlowDataPinInputProperty_String FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinInputProperty_String(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinInputProperty_String obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinInputProperty_String.NativeDataSize;
    }
}