using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowNodeWithExternalDataPinSupplierInterface")]
public partial interface IFlowNodeWithExternalDataPinSupplierInterface
{
}

public static class IFlowNodeWithExternalDataPinSupplierInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNodeWithExternalDataPinSupplierInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowNodeWithExternalDataPinSupplierInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowNodeWithExternalDataPinSupplierInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowNodeWithExternalDataPinSupplierInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowNodeWithExternalDataPinSupplierInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}