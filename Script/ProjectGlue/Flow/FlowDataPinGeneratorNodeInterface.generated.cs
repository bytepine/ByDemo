using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowDataPinGeneratorNodeInterface")]
public partial interface IFlowDataPinGeneratorNodeInterface
{
}

public static class IFlowDataPinGeneratorNodeInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowDataPinGeneratorNodeInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowDataPinGeneratorNodeInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinGeneratorNodeInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowDataPinGeneratorNodeInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinGeneratorNodeInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}