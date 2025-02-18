using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Inject components onto actors and will remove them when they are destroyed (or this is shutdown)
/// </summary>
[UClass, GeneratedType("FlowInjectComponentsManager", "UnrealSharp.Flow.FlowInjectComponentsManager")]
public partial class UFlowInjectComponentsManager : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UFlowInjectComponentsManager()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowInjectComponentsManager");
        BeforeActorRemovedDelegate_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "BeforeActorRemovedDelegate");
        BeforeActorRemovedDelegate_Offset = FPropertyExporter.CallGetPropertyOffset(BeforeActorRemovedDelegate_NativeProperty);
        UnrealSharp.Flow.UFlowBeforeOnActorRemoved.InitializeUnrealDelegate(BeforeActorRemovedDelegate_NativeProperty);
        IntPtr bRemoveInjectedComponentsWhenDeinitializing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRemoveInjectedComponentsWhenDeinitializing");
        bRemoveInjectedComponentsWhenDeinitializing_Offset = FPropertyExporter.CallGetPropertyOffset(bRemoveInjectedComponentsWhenDeinitializing_NativeProperty);
        ActorToComponentsMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActorToComponentsMap");
        ActorToComponentsMap_Offset = FPropertyExporter.CallGetPropertyOffset(ActorToComponentsMap_NativeProperty);
        OnActorDestroyed_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnActorDestroyed");
        OnActorDestroyed_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnActorDestroyed_NativeFunction);
        OnActorDestroyed_DestroyedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnActorDestroyed_NativeFunction, "DestroyedActor");
    }
    
    static int BeforeActorRemovedDelegate_Offset;
    static IntPtr BeforeActorRemovedDelegate_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.FlowBeforeOnActorRemoved> BeforeActorRemovedDelegate_BackingField;
    
    public TMulticastDelegate<UnrealSharp.Flow.FlowBeforeOnActorRemoved> BeforeActorRemovedDelegate
    {
        get
        {
            if (BeforeActorRemovedDelegate_BackingField == null)
            {
                BeforeActorRemovedDelegate_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.FlowBeforeOnActorRemoved>.FromNative(IntPtr.Add(NativeObject, BeforeActorRemovedDelegate_Offset), BeforeActorRemovedDelegate_NativeProperty, 0);
            }
            return BeforeActorRemovedDelegate_BackingField;
        }
        set
        {
            if (value == BeforeActorRemovedDelegate_BackingField)
            {
                return;
            }
            BeforeActorRemovedDelegate_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.FlowBeforeOnActorRemoved>.ToNative(IntPtr.Add(NativeObject, BeforeActorRemovedDelegate_Offset), 0, value);
        }
    }
    
    
    static int bRemoveInjectedComponentsWhenDeinitializing_Offset;
    
    /// <summary>
    /// Remove the Injected Components from the Actors when Deinitialized
    /// </summary>
    public bool RemoveInjectedComponentsWhenDeinitializing
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRemoveInjectedComponentsWhenDeinitializing_Offset), 0);
        }
    }
    
    
    static int ActorToComponentsMap_Offset;
    static IntPtr ActorToComponentsMap_NativeProperty;
    MapMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.FFlowComponentInstances> ActorToComponentsMap_Marshaller = null;
    
    /// <summary>
    /// Map of spawned components (if we are cleaning up)
    /// </summary>
    public System.Collections.Generic.IDictionary<UnrealSharp.Engine.AActor, UnrealSharp.Flow.FFlowComponentInstances> ActorToComponentsMap
    {
        get
        {
            ActorToComponentsMap_Marshaller ??= new MapMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.FFlowComponentInstances>(ActorToComponentsMap_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative, StructMarshaller<UnrealSharp.Flow.FFlowComponentInstances>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowComponentInstances>.FromNative);
            return ActorToComponentsMap_Marshaller.FromNative(IntPtr.Add(NativeObject, ActorToComponentsMap_Offset), 0);
        }
    }
    
    // OnActorDestroyed
    static IntPtr OnActorDestroyed_NativeFunction;
    static int OnActorDestroyed_ParamsSize;
    static int OnActorDestroyed_DestroyedActor_Offset;
    
    [UFunction, GeneratedType("OnActorDestroyed")]
    protected void OnActorDestroyed(UnrealSharp.Engine.AActor destroyedActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnActorDestroyed_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnActorDestroyed_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative(IntPtr.Add(ParamsBuffer, OnActorDestroyed_DestroyedActor_Offset), 0, destroyedActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnActorDestroyed_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}