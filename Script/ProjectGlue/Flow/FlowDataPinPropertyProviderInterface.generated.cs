using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowDataPinPropertyProviderInterface")]
public partial interface IFlowDataPinPropertyProviderInterface
{
}

public static class IFlowDataPinPropertyProviderInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowDataPinPropertyProviderInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowDataPinPropertyProviderInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinPropertyProviderInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowDataPinPropertyProviderInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinPropertyProviderInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}