using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Execute a UActorComponent on the owning actor as if it was a flow subgraph
/// </summary>
[UClass, GeneratedType("FlowNode_ExecuteComponent", "UnrealSharp.Flow.FlowNode_ExecuteComponent")]
public partial class UFlowNode_ExecuteComponent : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_ExecuteComponent()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_ExecuteComponent");
        IntPtr ComponentRef_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentRef");
        ComponentRef_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentRef_NativeProperty);
        IntPtr ComponentTemplate_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentTemplate");
        ComponentTemplate_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentTemplate_NativeProperty);
        IntPtr ComponentClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentClass");
        ComponentClass_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentClass_NativeProperty);
        IntPtr InjectComponentsManager_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InjectComponentsManager");
        InjectComponentsManager_Offset = FPropertyExporter.CallGetPropertyOffset(InjectComponentsManager_NativeProperty);
        IntPtr bReuseExistingComponent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReuseExistingComponent");
        bReuseExistingComponent_Offset = FPropertyExporter.CallGetPropertyOffset(bReuseExistingComponent_NativeProperty);
        IntPtr bAllowInjectComponent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowInjectComponent");
        bAllowInjectComponent_Offset = FPropertyExporter.CallGetPropertyOffset(bAllowInjectComponent_NativeProperty);
        IntPtr ComponentSource_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentSource");
        ComponentSource_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentSource_NativeProperty);
    }
    
    static int ComponentRef_Offset;
    
    /// <summary>
    /// Executable Component (by name) on the expected Flow owning Actor
    ///  (the component must implement the IFlowExecutableComponentInterface)
    /// </summary>
    protected UnrealSharp.Flow.FFlowActorOwnerComponentRef ComponenttoExecute
    {
        get
        {
            return StructMarshaller<UnrealSharp.Flow.FFlowActorOwnerComponentRef>.FromNative(IntPtr.Add(NativeObject, ComponentRef_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.Flow.FFlowActorOwnerComponentRef>.ToNative(IntPtr.Add(NativeObject, ComponentRef_Offset), 0, value);
        }
    }
    
    
    static int ComponentTemplate_Offset;
    
    /// <summary>
    /// Component (template) to inject on the spawned actor, may be configured inline
    /// </summary>
    protected UnrealSharp.Engine.UActorComponent ComponentTemplate
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative(IntPtr.Add(NativeObject, ComponentTemplate_Offset), 0);
        }
        set
        {
            ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative(IntPtr.Add(NativeObject, ComponentTemplate_Offset), 0, value);
        }
    }
    
    
    static int ComponentClass_Offset;
    
    /// <summary>
    /// Component (class) to inject on the spawned actor
    /// </summary>
    protected TSubclassOf<UnrealSharp.Engine.UActorComponent> ComponentClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative(IntPtr.Add(NativeObject, ComponentClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative(IntPtr.Add(NativeObject, ComponentClass_Offset), 0, value);
        }
    }
    
    
    static int InjectComponentsManager_Offset;
    
    /// <summary>
    /// Manager object to inject and remove components from the Flow owning Actor
    /// </summary>
    protected UnrealSharp.Flow.UFlowInjectComponentsManager InjectComponentsManager
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowInjectComponentsManager>.FromNative(IntPtr.Add(NativeObject, InjectComponentsManager_Offset), 0);
        }
    }
    
    
    static int bReuseExistingComponent_Offset;
    
    /// <summary>
    /// Look for the component (by class) on the Actor and re-use it (rather than injecting)
    /// if the component already exists.
    /// </summary>
    protected bool ReuseExistingComponent
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bReuseExistingComponent_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bReuseExistingComponent_Offset), 0, value);
        }
    }
    
    
    static int bAllowInjectComponent_Offset;
    
    /// <summary>
    /// Allow injecting the component, if it cannot be found on the Actor
    /// </summary>
    protected bool Allowinjectingcomponent
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAllowInjectComponent_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAllowInjectComponent_Offset), 0, value);
        }
    }
    
    
    static int ComponentSource_Offset;
    
    /// <summary>
    /// Inject component(s) onto the owning Actor
    /// </summary>
    protected UnrealSharp.Flow.EExecuteComponentSource ComponentSource
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EExecuteComponentSource>.FromNative(IntPtr.Add(NativeObject, ComponentSource_Offset), 0);
        }
    }
    
    
}