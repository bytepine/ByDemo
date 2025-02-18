using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowContextPinSupplierInterface")]
public partial interface IFlowContextPinSupplierInterface
{
    [UFunction, GeneratedType("K2_SupportsContextPins")]
    public bool SupportsContextPins();
    [UFunction, GeneratedType("K2_GetContextInputs")]
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextInputs();
    [UFunction, GeneratedType("K2_GetContextOutputs")]
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextOutputs();
}

public static class IFlowContextPinSupplierInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowContextPinSupplierInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowContextPinSupplierInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowContextPinSupplierInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowContextPinSupplierInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowContextPinSupplierInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}