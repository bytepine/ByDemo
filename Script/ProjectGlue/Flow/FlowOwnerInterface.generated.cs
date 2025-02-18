using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowOwnerInterface")]
public partial interface IFlowOwnerInterface
{
}

public static class IFlowOwnerInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowOwnerInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowOwnerInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowOwnerInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowOwnerInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowOwnerInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}