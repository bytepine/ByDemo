using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowExternalExecutableInterface")]
public partial interface IFlowExternalExecutableInterface
{
    /// <summary>
    /// Called immediately prior to OnActivate() to set the native proxy that is executing the
    /// external executable object in the flow graph.  This is primarily done so that the external element has a
    /// handle to call TriggerOutput() and Finish() when it has completed its work.
    /// </summary>
    [UFunction, GeneratedType("K2_PreActivateExternalFlowExecutable")]
    public void PreActivateExternalFlowExecutable(UnrealSharp.Flow.UFlowNodeBase flowNodeBase);
}

public static class IFlowExternalExecutableInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowExternalExecutableInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowExternalExecutableInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowExternalExecutableInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowExternalExecutableInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowExternalExecutableInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}