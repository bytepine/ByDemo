using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowCoreExecutableInterface")]
public partial interface IFlowCoreExecutableInterface
{
    /// <summary>
    /// Method called just after creating the node instance, while initializing the Flow Asset instance
    /// This happens before executing graph, only called during gameplay
    /// </summary>
    [UFunction, GeneratedType("K2_InitializeInstance")]
    public void InitializeInstance();
    /// <summary>
    /// Event called from UMKTFlowNode::DeinitializeInstance()
    /// </summary>
    [UFunction, GeneratedType("K2_DeinitializeInstance")]
    public void DeinitializeInstance();
    /// <summary>
    /// If preloading is enabled, will be called to preload content
    /// </summary>
    [UFunction, GeneratedType("K2_PreloadContent")]
    public void PreloadContent();
    /// <summary>
    /// If preloading is enabled, will be called to flush content
    /// </summary>
    [UFunction, GeneratedType("K2_FlushContent")]
    public void FlushContent();
    /// <summary>
    /// Called immediately before the first input is triggered
    /// </summary>
    [UFunction, GeneratedType("K2_OnActivate")]
    public void OnActivate();
    /// <summary>
    /// Event called after node finished the work
    /// </summary>
    [UFunction, GeneratedType("K2_Cleanup")]
    public void Cleanup();
    /// <summary>
    /// Define what happens when node is terminated from the outside
    /// </summary>
    [UFunction, GeneratedType("K2_ForceFinishNode")]
    public void ForceFinishNode();
    /// <summary>
    /// Event reacting on triggering Input pin
    /// </summary>
    [UFunction, GeneratedType("K2_ExecuteInput")]
    public void ExecuteInput(FName pinName);
}

public static class IFlowCoreExecutableInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowCoreExecutableInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowCoreExecutableInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowCoreExecutableInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowCoreExecutableInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowCoreExecutableInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}