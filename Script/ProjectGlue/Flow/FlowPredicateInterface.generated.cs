using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowPredicateInterface")]
public partial interface IFlowPredicateInterface
{
    [UFunction, GeneratedType("EvaluatePredicate")]
    public bool EvaluatePredicate();
}

public static class IFlowPredicateInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowPredicateInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowPredicateInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowPredicateInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowPredicateInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowPredicateInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}