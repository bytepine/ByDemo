using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper-structs for a blueprint defaulted input pin types
///   "Hidden" to keep them out of the TInstancedStruct<FFlowDataPinProperty> selection list (but they can still be authored as properties in blueprint)
///   "DefaultForInputFlowPin" to change them to an Defaulted-Input property (rather than an output property)
/// </summary>
[UStruct, GeneratedType("FlowDataPinInputProperty_Bool", "UnrealSharp.Flow.FlowDataPinInputProperty_Bool")]
public partial struct FFlowDataPinInputProperty_Bool : MarshalledStruct<FFlowDataPinInputProperty_Bool>
{
    // Value
    
    static int Value_Offset;
    public bool Value;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinInputProperty_Bool()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinInputProperty_Bool");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinInputProperty_Bool(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
        }
    }
    
    public static FFlowDataPinInputProperty_Bool FromNative(IntPtr buffer) => new FFlowDataPinInputProperty_Bool(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
        }
    }
}

public static class FFlowDataPinInputProperty_BoolMarshaller
{
    public static FFlowDataPinInputProperty_Bool FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinInputProperty_Bool(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinInputProperty_Bool obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinInputProperty_Bool.NativeDataSize;
    }
}