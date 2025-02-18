using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Flow Subsystem
/// - manages lifetime of Flow Graphs
/// - connects Flow Graphs with actors containing the Flow Component
/// - convenient base for project-specific systems
/// </summary>
[UClass, GeneratedType("FlowSubsystem", "UnrealSharp.Flow.FlowSubsystem")]
public partial class UFlowSubsystem : UnrealSharp.Engine.UGameInstanceSubsystem
{
    static readonly IntPtr NativeClassPtr;
    static UFlowSubsystem()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowSubsystem");
        InstancedTemplates_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InstancedTemplates");
        InstancedTemplates_Offset = FPropertyExporter.CallGetPropertyOffset(InstancedTemplates_NativeProperty);
        RootInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RootInstances");
        RootInstances_Offset = FPropertyExporter.CallGetPropertyOffset(RootInstances_NativeProperty);
        OnSaveGame_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnSaveGame");
        OnSaveGame_Offset = FPropertyExporter.CallGetPropertyOffset(OnSaveGame_NativeProperty);
        OnComponentRegistered_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnComponentRegistered");
        OnComponentRegistered_Offset = FPropertyExporter.CallGetPropertyOffset(OnComponentRegistered_NativeProperty);
        UnrealSharp.Flow.USimpleFlowComponentEvent.InitializeUnrealDelegate(OnComponentRegistered_NativeProperty);
        OnComponentTagAdded_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnComponentTagAdded");
        OnComponentTagAdded_Offset = FPropertyExporter.CallGetPropertyOffset(OnComponentTagAdded_NativeProperty);
        UnrealSharp.Flow.UTaggedFlowComponentEvent.InitializeUnrealDelegate(OnComponentTagAdded_NativeProperty);
        OnComponentUnregistered_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnComponentUnregistered");
        OnComponentUnregistered_Offset = FPropertyExporter.CallGetPropertyOffset(OnComponentUnregistered_NativeProperty);
        UnrealSharp.Flow.USimpleFlowComponentEvent.InitializeUnrealDelegate(OnComponentUnregistered_NativeProperty);
        OnComponentTagRemoved_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnComponentTagRemoved");
        OnComponentTagRemoved_Offset = FPropertyExporter.CallGetPropertyOffset(OnComponentTagRemoved_NativeProperty);
        UnrealSharp.Flow.UTaggedFlowComponentEvent.InitializeUnrealDelegate(OnComponentTagRemoved_NativeProperty);
        InstancedSubFlows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InstancedSubFlows");
        InstancedSubFlows_Offset = FPropertyExporter.CallGetPropertyOffset(InstancedSubFlows_NativeProperty);
        GetInstancedSubFlows_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInstancedSubFlows");
        GetInstancedSubFlows_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInstancedSubFlows_NativeFunction);
        GetInstancedSubFlows_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInstancedSubFlows_NativeFunction, "ReturnValue");
        GetInstancedSubFlows_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetInstancedSubFlows_NativeFunction, "ReturnValue");
        IntPtr LoadedSaveGame_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LoadedSaveGame");
        LoadedSaveGame_Offset = FPropertyExporter.CallGetPropertyOffset(LoadedSaveGame_NativeProperty);
        GetLoadedSaveGame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLoadedSaveGame");
        GetLoadedSaveGame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLoadedSaveGame_NativeFunction);
        GetLoadedSaveGame_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLoadedSaveGame_NativeFunction, "ReturnValue");
        AbortActiveFlows_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AbortActiveFlows");
        StartRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartRootFlow");
        StartRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StartRootFlow_NativeFunction);
        StartRootFlow_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartRootFlow_NativeFunction, "Owner");
        StartRootFlow_FlowAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartRootFlow_NativeFunction, "FlowAsset");
        StartRootFlow_bAllowMultipleInstances_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StartRootFlow_NativeFunction, "bAllowMultipleInstances");
        FinishRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinishRootFlow");
        FinishRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FinishRootFlow_NativeFunction);
        FinishRootFlow_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishRootFlow_NativeFunction, "Owner");
        FinishRootFlow_TemplateAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishRootFlow_NativeFunction, "TemplateAsset");
        FinishRootFlow_FinishPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishRootFlow_NativeFunction, "FinishPolicy");
        FinishAllRootFlows_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinishAllRootFlows");
        FinishAllRootFlows_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FinishAllRootFlows_NativeFunction);
        FinishAllRootFlows_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishAllRootFlows_NativeFunction, "Owner");
        FinishAllRootFlows_FinishPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishAllRootFlows_NativeFunction, "FinishPolicy");
        GetRootInstances_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootInstances");
        GetRootInstances_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootInstances_NativeFunction);
        GetRootInstances_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootInstances_NativeFunction, "ReturnValue");
        GetRootInstances_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetRootInstances_NativeFunction, "ReturnValue");
        GetRootInstancesByOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootInstancesByOwner");
        GetRootInstancesByOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootInstancesByOwner_NativeFunction);
        GetRootInstancesByOwner_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootInstancesByOwner_NativeFunction, "Owner");
        GetRootInstancesByOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootInstancesByOwner_NativeFunction, "ReturnValue");
        GetRootInstancesByOwner_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetRootInstancesByOwner_NativeFunction, "ReturnValue");
        GetRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootFlow");
        GetRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootFlow_NativeFunction);
        GetRootFlow_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootFlow_NativeFunction, "Owner");
        GetRootFlow_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootFlow_NativeFunction, "ReturnValue");
        OnGameSaved_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnGameSaved");
        OnGameSaved_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnGameSaved_NativeFunction);
        OnGameSaved_SaveGame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnGameSaved_NativeFunction, "SaveGame");
        OnGameLoaded_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnGameLoaded");
        OnGameLoaded_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnGameLoaded_NativeFunction);
        OnGameLoaded_SaveGame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnGameLoaded_NativeFunction, "SaveGame");
        LoadRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadRootFlow");
        LoadRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadRootFlow_NativeFunction);
        LoadRootFlow_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadRootFlow_NativeFunction, "Owner");
        LoadRootFlow_FlowAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadRootFlow_NativeFunction, "FlowAsset");
        LoadRootFlow_SavedAssetInstanceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadRootFlow_NativeFunction, "SavedAssetInstanceName");
        LoadSubFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadSubFlow");
        LoadSubFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadSubFlow_NativeFunction);
        LoadSubFlow_SubGraphNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadSubFlow_NativeFunction, "SubGraphNode");
        LoadSubFlow_SavedAssetInstanceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadSubFlow_NativeFunction, "SavedAssetInstanceName");
        GetFlowComponentsByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowComponentsByTag");
        GetFlowComponentsByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowComponentsByTag_NativeFunction);
        GetFlowComponentsByTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTag_NativeFunction, "Tag");
        GetFlowComponentsByTag_ComponentClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTag_NativeFunction, "ComponentClass");
        GetFlowComponentsByTag_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTag_NativeFunction, "bExactMatch");
        GetFlowComponentsByTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTag_NativeFunction, "ReturnValue");
        GetFlowComponentsByTag_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowComponentsByTag_NativeFunction, "ReturnValue");
        GetFlowComponentsByTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowComponentsByTags");
        GetFlowComponentsByTags_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowComponentsByTags_NativeFunction);
        GetFlowComponentsByTags_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTags_NativeFunction, "Tags");
        GetFlowComponentsByTags_MatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTags_NativeFunction, "MatchType");
        GetFlowComponentsByTags_ComponentClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTags_NativeFunction, "ComponentClass");
        GetFlowComponentsByTags_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTags_NativeFunction, "bExactMatch");
        GetFlowComponentsByTags_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowComponentsByTags_NativeFunction, "ReturnValue");
        GetFlowComponentsByTags_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowComponentsByTags_NativeFunction, "ReturnValue");
        GetFlowActorsByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowActorsByTag");
        GetFlowActorsByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowActorsByTag_NativeFunction);
        GetFlowActorsByTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTag_NativeFunction, "Tag");
        GetFlowActorsByTag_ActorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTag_NativeFunction, "ActorClass");
        GetFlowActorsByTag_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTag_NativeFunction, "bExactMatch");
        GetFlowActorsByTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTag_NativeFunction, "ReturnValue");
        GetFlowActorsByTag_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowActorsByTag_NativeFunction, "ReturnValue");
        GetFlowActorsByTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowActorsByTags");
        GetFlowActorsByTags_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowActorsByTags_NativeFunction);
        GetFlowActorsByTags_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTags_NativeFunction, "Tags");
        GetFlowActorsByTags_MatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTags_NativeFunction, "MatchType");
        GetFlowActorsByTags_ActorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTags_NativeFunction, "ActorClass");
        GetFlowActorsByTags_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTags_NativeFunction, "bExactMatch");
        GetFlowActorsByTags_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsByTags_NativeFunction, "ReturnValue");
        GetFlowActorsByTags_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowActorsByTags_NativeFunction, "ReturnValue");
        GetFlowActorsAndComponentsByTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowActorsAndComponentsByTag");
        GetFlowActorsAndComponentsByTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowActorsAndComponentsByTag_NativeFunction);
        GetFlowActorsAndComponentsByTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTag_NativeFunction, "Tag");
        GetFlowActorsAndComponentsByTag_ActorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTag_NativeFunction, "ActorClass");
        GetFlowActorsAndComponentsByTag_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTag_NativeFunction, "bExactMatch");
        GetFlowActorsAndComponentsByTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTag_NativeFunction, "ReturnValue");
        GetFlowActorsAndComponentsByTag_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowActorsAndComponentsByTag_NativeFunction, "ReturnValue");
        GetFlowActorsAndComponentsByTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowActorsAndComponentsByTags");
        GetFlowActorsAndComponentsByTags_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowActorsAndComponentsByTags_NativeFunction);
        GetFlowActorsAndComponentsByTags_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "Tags");
        GetFlowActorsAndComponentsByTags_MatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "MatchType");
        GetFlowActorsAndComponentsByTags_ActorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "ActorClass");
        GetFlowActorsAndComponentsByTags_bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "bExactMatch");
        GetFlowActorsAndComponentsByTags_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "ReturnValue");
        GetFlowActorsAndComponentsByTags_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetFlowActorsAndComponentsByTags_NativeFunction, "ReturnValue");
    }
    
    static int InstancedTemplates_Offset;
    static IntPtr InstancedTemplates_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.UFlowAsset> InstancedTemplates_Marshaller = null;
    
    /// <summary>
    /// All asset templates with active instances
    /// </summary>
    private System.Collections.Generic.IList<UnrealSharp.Flow.UFlowAsset> InstancedTemplates
    {
        get
        {
            InstancedTemplates_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.UFlowAsset>(InstancedTemplates_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return InstancedTemplates_Marshaller.FromNative(IntPtr.Add(NativeObject, InstancedTemplates_Offset), 0);
        }
    }
    
    
    static int RootInstances_Offset;
    static IntPtr RootInstances_NativeProperty;
    MapMarshaller<UnrealSharp.Flow.UFlowAsset, TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>> RootInstances_Marshaller = null;
    
    /// <summary>
    /// Assets instanced by object from another system, i.e. World Settings or Player Controller
    /// </summary>
    private System.Collections.Generic.IDictionary<UnrealSharp.Flow.UFlowAsset, TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>> RootInstances
    {
        get
        {
            RootInstances_Marshaller ??= new MapMarshaller<UnrealSharp.Flow.UFlowAsset, TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>>(RootInstances_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>>.ToNative, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>>.FromNative);
            return RootInstances_Marshaller.FromNative(IntPtr.Add(NativeObject, RootInstances_Offset), 0);
        }
    }
    
    
    static int OnSaveGame_Offset;
    static IntPtr OnSaveGame_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.SimpleFlowEvent> OnSaveGame_BackingField;
    
    /// <summary>
    /// SaveGame support
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.SimpleFlowEvent> OnSaveGame
    {
        get
        {
            if (OnSaveGame_BackingField == null)
            {
                OnSaveGame_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowEvent>.FromNative(IntPtr.Add(NativeObject, OnSaveGame_Offset), OnSaveGame_NativeProperty, 0);
            }
            return OnSaveGame_BackingField;
        }
        set
        {
            if (value == OnSaveGame_BackingField)
            {
                return;
            }
            OnSaveGame_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowEvent>.ToNative(IntPtr.Add(NativeObject, OnSaveGame_Offset), 0, value);
        }
    }
    
    
    static int OnComponentRegistered_Offset;
    static IntPtr OnComponentRegistered_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.SimpleFlowComponentEvent> OnComponentRegistered_BackingField;
    
    /// <summary>
    /// Called when actor with Flow Component appears in the world
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.SimpleFlowComponentEvent> OnComponentRegistered
    {
        get
        {
            if (OnComponentRegistered_BackingField == null)
            {
                OnComponentRegistered_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowComponentEvent>.FromNative(IntPtr.Add(NativeObject, OnComponentRegistered_Offset), OnComponentRegistered_NativeProperty, 0);
            }
            return OnComponentRegistered_BackingField;
        }
        set
        {
            if (value == OnComponentRegistered_BackingField)
            {
                return;
            }
            OnComponentRegistered_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowComponentEvent>.ToNative(IntPtr.Add(NativeObject, OnComponentRegistered_Offset), 0, value);
        }
    }
    
    
    static int OnComponentTagAdded_Offset;
    static IntPtr OnComponentTagAdded_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.TaggedFlowComponentEvent> OnComponentTagAdded_BackingField;
    
    /// <summary>
    /// Called after adding Identity Tags to already registered Flow Component
    ///        * This can happen only after Begin Play occured in the component
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.TaggedFlowComponentEvent> OnComponentTagAdded
    {
        get
        {
            if (OnComponentTagAdded_BackingField == null)
            {
                OnComponentTagAdded_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.TaggedFlowComponentEvent>.FromNative(IntPtr.Add(NativeObject, OnComponentTagAdded_Offset), OnComponentTagAdded_NativeProperty, 0);
            }
            return OnComponentTagAdded_BackingField;
        }
        set
        {
            if (value == OnComponentTagAdded_BackingField)
            {
                return;
            }
            OnComponentTagAdded_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.TaggedFlowComponentEvent>.ToNative(IntPtr.Add(NativeObject, OnComponentTagAdded_Offset), 0, value);
        }
    }
    
    
    static int OnComponentUnregistered_Offset;
    static IntPtr OnComponentUnregistered_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.SimpleFlowComponentEvent> OnComponentUnregistered_BackingField;
    
    /// <summary>
    /// Called when actor with Flow Component disappears from the world
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.SimpleFlowComponentEvent> OnComponentUnregistered
    {
        get
        {
            if (OnComponentUnregistered_BackingField == null)
            {
                OnComponentUnregistered_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowComponentEvent>.FromNative(IntPtr.Add(NativeObject, OnComponentUnregistered_Offset), OnComponentUnregistered_NativeProperty, 0);
            }
            return OnComponentUnregistered_BackingField;
        }
        set
        {
            if (value == OnComponentUnregistered_BackingField)
            {
                return;
            }
            OnComponentUnregistered_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.SimpleFlowComponentEvent>.ToNative(IntPtr.Add(NativeObject, OnComponentUnregistered_Offset), 0, value);
        }
    }
    
    
    static int OnComponentTagRemoved_Offset;
    static IntPtr OnComponentTagRemoved_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.TaggedFlowComponentEvent> OnComponentTagRemoved_BackingField;
    
    /// <summary>
    /// Called after removing Identity Tags from the Flow Component, if component still has some Identity Tags
    ///        * This can happen only after Begin Play occured in the component
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.TaggedFlowComponentEvent> OnComponentTagRemoved
    {
        get
        {
            if (OnComponentTagRemoved_BackingField == null)
            {
                OnComponentTagRemoved_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.TaggedFlowComponentEvent>.FromNative(IntPtr.Add(NativeObject, OnComponentTagRemoved_Offset), OnComponentTagRemoved_NativeProperty, 0);
            }
            return OnComponentTagRemoved_BackingField;
        }
        set
        {
            if (value == OnComponentTagRemoved_BackingField)
            {
                return;
            }
            OnComponentTagRemoved_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.TaggedFlowComponentEvent>.ToNative(IntPtr.Add(NativeObject, OnComponentTagRemoved_Offset), 0, value);
        }
    }
    
    
    // GetInstancedSubFlows
    static IntPtr GetInstancedSubFlows_NativeFunction;
    static int GetInstancedSubFlows_ParamsSize;
    static int GetInstancedSubFlows_ReturnValue_Offset;
    static IntPtr GetInstancedSubFlows_ReturnValue_NativeProperty;
    MapCopyMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph, UnrealSharp.Flow.UFlowAsset> GetInstancedSubFlows_ReturnValue_Marshaller = null;
    static int InstancedSubFlows_Offset;
    static IntPtr InstancedSubFlows_NativeProperty;
    static int InstancedSubFlows_Size;
    MapCopyMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph, UnrealSharp.Flow.UFlowAsset> InstancedSubFlows_Marshaller = null;
    
    /// <summary>
    /// Assets instanced by Sub Graph nodes
    /// </summary>
    public System.Collections.Generic.IDictionary<UnrealSharp.Flow.UFlowNode_SubGraph, UnrealSharp.Flow.UFlowAsset> InstancedSubFlows
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetInstancedSubFlows_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetInstancedSubFlows_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInstancedSubFlows_NativeFunction, ParamsBuffer);
                
                System.Collections.Generic.IDictionary<UnrealSharp.Flow.UFlowNode_SubGraph, UnrealSharp.Flow.UFlowAsset> returnValue;
                GetInstancedSubFlows_ReturnValue_Marshaller ??= new MapCopyMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph, UnrealSharp.Flow.UFlowAsset>(GetInstancedSubFlows_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph>.FromNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
                IntPtr GetInstancedSubFlows_ReturnValue_NativeProperty_ParamsBuffer = IntPtr.Add(ParamsBuffer, GetInstancedSubFlows_ReturnValue_Offset);
                returnValue = GetInstancedSubFlows_ReturnValue_Marshaller.FromNative(ParamsBuffer, 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetLoadedSaveGame
    static IntPtr GetLoadedSaveGame_NativeFunction;
    static int GetLoadedSaveGame_ParamsSize;
    static int GetLoadedSaveGame_ReturnValue_Offset;
    static int LoadedSaveGame_Offset;
    static IntPtr LoadedSaveGame_NativeProperty;
    static int LoadedSaveGame_Size;
    
    public UnrealSharp.Flow.UFlowSaveGame LoadedSaveGame
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetLoadedSaveGame_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetLoadedSaveGame_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLoadedSaveGame_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowSaveGame returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowSaveGame>.FromNative(IntPtr.Add(ParamsBuffer, GetLoadedSaveGame_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    // AbortActiveFlows
    static IntPtr AbortActiveFlows_NativeFunction;
    
    [UFunction, GeneratedType("AbortActiveFlows")]
    public void AbortActiveFlows()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AbortActiveFlows_NativeFunction, IntPtr.Zero);
        }
    }
    
    // StartRootFlow
    static IntPtr StartRootFlow_NativeFunction;
    static int StartRootFlow_ParamsSize;
    static int StartRootFlow_Owner_Offset;
    static int StartRootFlow_FlowAsset_Offset;
    static int StartRootFlow_bAllowMultipleInstances_Offset;
    
    /// <summary>
    /// Start the root Flow, graph that will eventually instantiate next Flow Graphs through the SubGraph node
    /// </summary>
    [UFunction, GeneratedType("StartRootFlow")]
    public void StartRootFlow(UnrealSharp.CoreUObject.UObject owner, UnrealSharp.Flow.UFlowAsset flowAsset, bool allowMultipleInstances = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StartRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(StartRootFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, StartRootFlow_Owner_Offset), 0, owner);
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, StartRootFlow_FlowAsset_Offset), 0, flowAsset);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, StartRootFlow_bAllowMultipleInstances_Offset), 0, allowMultipleInstances);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartRootFlow_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // FinishRootFlow
    static IntPtr FinishRootFlow_NativeFunction;
    static int FinishRootFlow_ParamsSize;
    static int FinishRootFlow_Owner_Offset;
    static int FinishRootFlow_TemplateAsset_Offset;
    static int FinishRootFlow_FinishPolicy_Offset;
    
    /// <summary>
    /// Finish Policy value is read by Flow Node
    ///        * Nodes have opportunity to terminate themselves differently if Flow Graph has been aborted
    ///        * Example: Spawn node might despawn all actors if Flow Graph is aborted, not completed
    /// </summary>
    [UFunction, GeneratedType("FinishRootFlow")]
    public void FinishRootFlow(UnrealSharp.CoreUObject.UObject owner, UnrealSharp.Flow.UFlowAsset templateAsset, UnrealSharp.Flow.EFlowFinishPolicy finishPolicy)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FinishRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FinishRootFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, FinishRootFlow_Owner_Offset), 0, owner);
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, FinishRootFlow_TemplateAsset_Offset), 0, templateAsset);
            EnumMarshaller<UnrealSharp.Flow.EFlowFinishPolicy>.ToNative(IntPtr.Add(ParamsBuffer, FinishRootFlow_FinishPolicy_Offset), 0, finishPolicy);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinishRootFlow_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // FinishAllRootFlows
    static IntPtr FinishAllRootFlows_NativeFunction;
    static int FinishAllRootFlows_ParamsSize;
    static int FinishAllRootFlows_Owner_Offset;
    static int FinishAllRootFlows_FinishPolicy_Offset;
    
    /// <summary>
    /// Finish Policy value is read by Flow Node
    ///        * Nodes have opportunity to terminate themselves differently if Flow Graph has been aborted
    ///        * Example: Spawn node might despawn all actors if Flow Graph is aborted, not completed
    /// </summary>
    [UFunction, GeneratedType("FinishAllRootFlows")]
    public void FinishAllRootFlows(UnrealSharp.CoreUObject.UObject owner, UnrealSharp.Flow.EFlowFinishPolicy finishPolicy)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FinishAllRootFlows_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FinishAllRootFlows_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, FinishAllRootFlows_Owner_Offset), 0, owner);
            EnumMarshaller<UnrealSharp.Flow.EFlowFinishPolicy>.ToNative(IntPtr.Add(ParamsBuffer, FinishAllRootFlows_FinishPolicy_Offset), 0, finishPolicy);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinishAllRootFlows_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // GetRootInstances
    static IntPtr GetRootInstances_NativeFunction;
    static int GetRootInstances_ParamsSize;
    static int GetRootInstances_ReturnValue_Offset;
    static IntPtr GetRootInstances_ReturnValue_NativeProperty;
    MapCopyMarshaller<UnrealSharp.CoreUObject.UObject, UnrealSharp.Flow.UFlowAsset> GetRootInstances_ReturnValue_Marshaller = null;
    
    /// <summary>
    /// Returns all assets instanced by object from another system like World Settings
    /// </summary>
    [UFunction, GeneratedType("GetRootInstances")]
    public System.Collections.Generic.IDictionary<UnrealSharp.CoreUObject.UObject, UnrealSharp.Flow.UFlowAsset> GetRootInstances()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRootInstances_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetRootInstances_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootInstances_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IDictionary<UnrealSharp.CoreUObject.UObject, UnrealSharp.Flow.UFlowAsset> returnValue;
            GetRootInstances_ReturnValue_Marshaller ??= new MapCopyMarshaller<UnrealSharp.CoreUObject.UObject, UnrealSharp.Flow.UFlowAsset>(GetRootInstances_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            IntPtr GetRootInstances_ReturnValue_NativeProperty_ParamsBuffer = IntPtr.Add(ParamsBuffer, GetRootInstances_ReturnValue_Offset);
            returnValue = GetRootInstances_ReturnValue_Marshaller.FromNative(ParamsBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetRootInstancesByOwner
    static IntPtr GetRootInstancesByOwner_NativeFunction;
    static int GetRootInstancesByOwner_ParamsSize;
    static int GetRootInstancesByOwner_Owner_Offset;
    static int GetRootInstancesByOwner_ReturnValue_Offset;
    static IntPtr GetRootInstancesByOwner_ReturnValue_NativeProperty;
    SetCopyMarshaller<UnrealSharp.Flow.UFlowAsset> GetRootInstancesByOwner_ReturnValue_Marshaller = null;
    
    /// <summary>
    /// Returns asset instanced by specific object
    /// </summary>
    [UFunction, GeneratedType("GetRootInstancesByOwner")]
    public System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowAsset> GetRootInstancesByOwner(UnrealSharp.CoreUObject.UObject owner)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRootInstancesByOwner_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetRootInstancesByOwner_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, GetRootInstancesByOwner_Owner_Offset), 0, owner);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootInstancesByOwner_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowAsset> returnValue;
            GetRootInstancesByOwner_ReturnValue_Marshaller ??= new SetCopyMarshaller<UnrealSharp.Flow.UFlowAsset>(GetRootInstancesByOwner_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetRootInstancesByOwner_ReturnValue_Offset);
            returnValue = GetRootInstancesByOwner_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetRootInstancesByOwner_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetRootFlow
    static IntPtr GetRootFlow_NativeFunction;
    static int GetRootFlow_ParamsSize;
    static int GetRootFlow_Owner_Offset;
    static int GetRootFlow_ReturnValue_Offset;
    
    [Obsolete("GetRootFlow is deprecated: Use GetRootInstancesByOwner() instead.")]
    [UFunction, GeneratedType("GetRootFlow")]
    public UnrealSharp.Flow.UFlowAsset GetRootFlow(UnrealSharp.CoreUObject.UObject owner)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetRootFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, GetRootFlow_Owner_Offset), 0, owner);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootFlow_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.UFlowAsset returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(ParamsBuffer, GetRootFlow_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // OnGameSaved
    static IntPtr OnGameSaved_NativeFunction;
    static int OnGameSaved_ParamsSize;
    static int OnGameSaved_SaveGame_Offset;
    
    [UFunction, GeneratedType("OnGameSaved")]
    public void OnGameSaved(UnrealSharp.Flow.UFlowSaveGame saveGame)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnGameSaved_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnGameSaved_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowSaveGame>.ToNative(IntPtr.Add(ParamsBuffer, OnGameSaved_SaveGame_Offset), 0, saveGame);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnGameSaved_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnGameLoaded
    static IntPtr OnGameLoaded_NativeFunction;
    static int OnGameLoaded_ParamsSize;
    static int OnGameLoaded_SaveGame_Offset;
    
    [UFunction, GeneratedType("OnGameLoaded")]
    public void OnGameLoaded(UnrealSharp.Flow.UFlowSaveGame saveGame)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnGameLoaded_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnGameLoaded_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowSaveGame>.ToNative(IntPtr.Add(ParamsBuffer, OnGameLoaded_SaveGame_Offset), 0, saveGame);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnGameLoaded_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // LoadRootFlow
    static IntPtr LoadRootFlow_NativeFunction;
    static int LoadRootFlow_ParamsSize;
    static int LoadRootFlow_Owner_Offset;
    static int LoadRootFlow_FlowAsset_Offset;
    static int LoadRootFlow_SavedAssetInstanceName_Offset;
    
    [UFunction, GeneratedType("LoadRootFlow")]
    public void LoadRootFlow(UnrealSharp.CoreUObject.UObject owner, UnrealSharp.Flow.UFlowAsset flowAsset, string savedAssetInstanceName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LoadRootFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, LoadRootFlow_Owner_Offset), 0, owner);
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, LoadRootFlow_FlowAsset_Offset), 0, flowAsset);
            IntPtr SavedAssetInstanceName_NativePtr = IntPtr.Add(ParamsBuffer, LoadRootFlow_SavedAssetInstanceName_Offset);
            StringMarshaller.ToNative(SavedAssetInstanceName_NativePtr,0,savedAssetInstanceName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadRootFlow_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(SavedAssetInstanceName_NativePtr, 0);
        }
    }
    
    // LoadSubFlow
    static IntPtr LoadSubFlow_NativeFunction;
    static int LoadSubFlow_ParamsSize;
    static int LoadSubFlow_SubGraphNode_Offset;
    static int LoadSubFlow_SavedAssetInstanceName_Offset;
    
    [UFunction, GeneratedType("LoadSubFlow")]
    public void LoadSubFlow(UnrealSharp.Flow.UFlowNode_SubGraph subGraphNode, string savedAssetInstanceName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadSubFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LoadSubFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowNode_SubGraph>.ToNative(IntPtr.Add(ParamsBuffer, LoadSubFlow_SubGraphNode_Offset), 0, subGraphNode);
            IntPtr SavedAssetInstanceName_NativePtr = IntPtr.Add(ParamsBuffer, LoadSubFlow_SavedAssetInstanceName_Offset);
            StringMarshaller.ToNative(SavedAssetInstanceName_NativePtr,0,savedAssetInstanceName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadSubFlow_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(SavedAssetInstanceName_NativePtr, 0);
        }
    }
    
    // GetFlowComponentsByTag
    static IntPtr GetFlowComponentsByTag_NativeFunction;
    static int GetFlowComponentsByTag_ParamsSize;
    static int GetFlowComponentsByTag_Tag_Offset;
    static int GetFlowComponentsByTag_ComponentClass_Offset;
    static int GetFlowComponentsByTag_bExactMatch_Offset;
    static int GetFlowComponentsByTag_ReturnValue_Offset;
    static IntPtr GetFlowComponentsByTag_ReturnValue_NativeProperty;
    
    public System.Collections.Generic.ISet<DOT> GetFlowComponentsByTag<DOT>(UnrealSharp.GameplayTags.FGameplayTag tag, bool exactMatch)
        where DOT : UnrealSharp.Flow.UFlowComponent
    {
        return GetFlowComponentsByTag<DOT>(tag, typeof(DOT), exactMatch);
    }
    
    /// <summary>
    /// Returns all registered Flow Components identified by given tag
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowComponentsByTag"), UMetaData("DeterminesOutputType", "ComponentClass")]
    public System.Collections.Generic.ISet<DOT> GetFlowComponentsByTag<DOT>(UnrealSharp.GameplayTags.FGameplayTag tag, TSubclassOf<DOT> componentClass, bool exactMatch = true)
        where DOT : UnrealSharp.Flow.UFlowComponent
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowComponentsByTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowComponentsByTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTag_Tag_Offset), 0, tag);
            SubclassOfMarshaller<DOT>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTag_ComponentClass_Offset), 0, componentClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTag_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowComponentsByTag_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<DOT> returnValue;
            var GetFlowComponentsByTag_ReturnValue_Marshaller = new SetCopyMarshaller<DOT>(GetFlowComponentsByTag_ReturnValue_NativeProperty, ObjectMarshaller<DOT>.ToNative, ObjectMarshaller<DOT>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetFlowComponentsByTag_ReturnValue_Offset);
            returnValue = GetFlowComponentsByTag_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetFlowComponentsByTag_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetFlowComponentsByTags
    static IntPtr GetFlowComponentsByTags_NativeFunction;
    static int GetFlowComponentsByTags_ParamsSize;
    static int GetFlowComponentsByTags_Tags_Offset;
    static int GetFlowComponentsByTags_MatchType_Offset;
    static int GetFlowComponentsByTags_ComponentClass_Offset;
    static int GetFlowComponentsByTags_bExactMatch_Offset;
    static int GetFlowComponentsByTags_ReturnValue_Offset;
    static IntPtr GetFlowComponentsByTags_ReturnValue_NativeProperty;
    
    public System.Collections.Generic.ISet<DOT> GetFlowComponentsByTags<DOT>(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.GameplayTags.EGameplayContainerMatchType matchType, bool exactMatch)
        where DOT : UnrealSharp.Flow.UFlowComponent
    {
        return GetFlowComponentsByTags<DOT>(tags, matchType, typeof(DOT), exactMatch);
    }
    
    /// <summary>
    /// Returns all registered Flow Components identified by Any or All provided tags
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowComponentsByTags"), UMetaData("DeterminesOutputType", "ComponentClass")]
    public System.Collections.Generic.ISet<DOT> GetFlowComponentsByTags<DOT>(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.GameplayTags.EGameplayContainerMatchType matchType, TSubclassOf<DOT> componentClass, bool exactMatch = true)
        where DOT : UnrealSharp.Flow.UFlowComponent
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowComponentsByTags_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowComponentsByTags_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTags_Tags_Offset), 0, tags);
            EnumMarshaller<UnrealSharp.GameplayTags.EGameplayContainerMatchType>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTags_MatchType_Offset), 0, matchType);
            SubclassOfMarshaller<DOT>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTags_ComponentClass_Offset), 0, componentClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowComponentsByTags_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowComponentsByTags_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<DOT> returnValue;
            var GetFlowComponentsByTags_ReturnValue_Marshaller = new SetCopyMarshaller<DOT>(GetFlowComponentsByTags_ReturnValue_NativeProperty, ObjectMarshaller<DOT>.ToNative, ObjectMarshaller<DOT>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetFlowComponentsByTags_ReturnValue_Offset);
            returnValue = GetFlowComponentsByTags_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetFlowComponentsByTags_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetFlowActorsByTag
    static IntPtr GetFlowActorsByTag_NativeFunction;
    static int GetFlowActorsByTag_ParamsSize;
    static int GetFlowActorsByTag_Tag_Offset;
    static int GetFlowActorsByTag_ActorClass_Offset;
    static int GetFlowActorsByTag_bExactMatch_Offset;
    static int GetFlowActorsByTag_ReturnValue_Offset;
    static IntPtr GetFlowActorsByTag_ReturnValue_NativeProperty;
    
    public System.Collections.Generic.ISet<DOT> GetFlowActorsByTag<DOT>(UnrealSharp.GameplayTags.FGameplayTag tag, bool exactMatch)
        where DOT : UnrealSharp.Engine.AActor
    {
        return GetFlowActorsByTag<DOT>(tag, typeof(DOT), exactMatch);
    }
    
    /// <summary>
    /// Returns all registered actors with Flow Component identified by given tag
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowActorsByTag"), UMetaData("DeterminesOutputType", "ActorClass")]
    public System.Collections.Generic.ISet<DOT> GetFlowActorsByTag<DOT>(UnrealSharp.GameplayTags.FGameplayTag tag, TSubclassOf<DOT> actorClass, bool exactMatch = true)
        where DOT : UnrealSharp.Engine.AActor
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowActorsByTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowActorsByTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTag_Tag_Offset), 0, tag);
            SubclassOfMarshaller<DOT>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTag_ActorClass_Offset), 0, actorClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTag_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowActorsByTag_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<DOT> returnValue;
            var GetFlowActorsByTag_ReturnValue_Marshaller = new SetCopyMarshaller<DOT>(GetFlowActorsByTag_ReturnValue_NativeProperty, ObjectMarshaller<DOT>.ToNative, ObjectMarshaller<DOT>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetFlowActorsByTag_ReturnValue_Offset);
            returnValue = GetFlowActorsByTag_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetFlowActorsByTag_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetFlowActorsByTags
    static IntPtr GetFlowActorsByTags_NativeFunction;
    static int GetFlowActorsByTags_ParamsSize;
    static int GetFlowActorsByTags_Tags_Offset;
    static int GetFlowActorsByTags_MatchType_Offset;
    static int GetFlowActorsByTags_ActorClass_Offset;
    static int GetFlowActorsByTags_bExactMatch_Offset;
    static int GetFlowActorsByTags_ReturnValue_Offset;
    static IntPtr GetFlowActorsByTags_ReturnValue_NativeProperty;
    
    public System.Collections.Generic.ISet<DOT> GetFlowActorsByTags<DOT>(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.GameplayTags.EGameplayContainerMatchType matchType, bool exactMatch)
        where DOT : UnrealSharp.Engine.AActor
    {
        return GetFlowActorsByTags<DOT>(tags, matchType, typeof(DOT), exactMatch);
    }
    
    /// <summary>
    /// Returns all registered actors with Flow Component identified by Any or All provided tags
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowActorsByTags"), UMetaData("DeterminesOutputType", "ActorClass")]
    public System.Collections.Generic.ISet<DOT> GetFlowActorsByTags<DOT>(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.GameplayTags.EGameplayContainerMatchType matchType, TSubclassOf<DOT> actorClass, bool exactMatch = true)
        where DOT : UnrealSharp.Engine.AActor
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowActorsByTags_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowActorsByTags_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTags_Tags_Offset), 0, tags);
            EnumMarshaller<UnrealSharp.GameplayTags.EGameplayContainerMatchType>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTags_MatchType_Offset), 0, matchType);
            SubclassOfMarshaller<DOT>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTags_ActorClass_Offset), 0, actorClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsByTags_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowActorsByTags_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<DOT> returnValue;
            var GetFlowActorsByTags_ReturnValue_Marshaller = new SetCopyMarshaller<DOT>(GetFlowActorsByTags_ReturnValue_NativeProperty, ObjectMarshaller<DOT>.ToNative, ObjectMarshaller<DOT>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetFlowActorsByTags_ReturnValue_Offset);
            returnValue = GetFlowActorsByTags_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetFlowActorsByTags_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetFlowActorsAndComponentsByTag
    static IntPtr GetFlowActorsAndComponentsByTag_NativeFunction;
    static int GetFlowActorsAndComponentsByTag_ParamsSize;
    static int GetFlowActorsAndComponentsByTag_Tag_Offset;
    static int GetFlowActorsAndComponentsByTag_ActorClass_Offset;
    static int GetFlowActorsAndComponentsByTag_bExactMatch_Offset;
    static int GetFlowActorsAndComponentsByTag_ReturnValue_Offset;
    static IntPtr GetFlowActorsAndComponentsByTag_ReturnValue_NativeProperty;
    MapCopyMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> GetFlowActorsAndComponentsByTag_ReturnValue_Marshaller = null;
    
    /// <summary>
    /// Returns all registered actors as pairs: Actor as key, its Flow Component as value
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowActorsAndComponentsByTag")]
    public System.Collections.Generic.IDictionary<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> GetFlowActorsAndComponentsByTag(UnrealSharp.GameplayTags.FGameplayTag tag, TSubclassOf<UnrealSharp.Engine.AActor> actorClass, bool exactMatch = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowActorsAndComponentsByTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowActorsAndComponentsByTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTag_Tag_Offset), 0, tag);
            SubclassOfMarshaller<UnrealSharp.Engine.AActor>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTag_ActorClass_Offset), 0, actorClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTag_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowActorsAndComponentsByTag_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IDictionary<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> returnValue;
            GetFlowActorsAndComponentsByTag_ReturnValue_Marshaller ??= new MapCopyMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent>(GetFlowActorsAndComponentsByTag_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative, ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.FromNative);
            IntPtr GetFlowActorsAndComponentsByTag_ReturnValue_NativeProperty_ParamsBuffer = IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTag_ReturnValue_Offset);
            returnValue = GetFlowActorsAndComponentsByTag_ReturnValue_Marshaller.FromNative(ParamsBuffer, 0);
            
            return returnValue;
        }
    }
    
    // GetFlowActorsAndComponentsByTags
    static IntPtr GetFlowActorsAndComponentsByTags_NativeFunction;
    static int GetFlowActorsAndComponentsByTags_ParamsSize;
    static int GetFlowActorsAndComponentsByTags_Tags_Offset;
    static int GetFlowActorsAndComponentsByTags_MatchType_Offset;
    static int GetFlowActorsAndComponentsByTags_ActorClass_Offset;
    static int GetFlowActorsAndComponentsByTags_bExactMatch_Offset;
    static int GetFlowActorsAndComponentsByTags_ReturnValue_Offset;
    static IntPtr GetFlowActorsAndComponentsByTags_ReturnValue_NativeProperty;
    MapCopyMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> GetFlowActorsAndComponentsByTags_ReturnValue_Marshaller = null;
    
    /// <summary>
    /// Returns all registered actors as pairs: Actor as key, its Flow Component as value
    /// 
    /// 
    /// </summary>
    [UFunction, GeneratedType("GetFlowActorsAndComponentsByTags")]
    public System.Collections.Generic.IDictionary<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> GetFlowActorsAndComponentsByTags(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.GameplayTags.EGameplayContainerMatchType matchType, TSubclassOf<UnrealSharp.Engine.AActor> actorClass, bool exactMatch = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlowActorsAndComponentsByTags_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetFlowActorsAndComponentsByTags_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTags_Tags_Offset), 0, tags);
            EnumMarshaller<UnrealSharp.GameplayTags.EGameplayContainerMatchType>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTags_MatchType_Offset), 0, matchType);
            SubclassOfMarshaller<UnrealSharp.Engine.AActor>.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTags_ActorClass_Offset), 0, actorClass);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTags_bExactMatch_Offset), 0, exactMatch);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowActorsAndComponentsByTags_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IDictionary<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent> returnValue;
            GetFlowActorsAndComponentsByTags_ReturnValue_Marshaller ??= new MapCopyMarshaller<UnrealSharp.Engine.AActor, UnrealSharp.Flow.UFlowComponent>(GetFlowActorsAndComponentsByTags_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative, ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative, ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.FromNative);
            IntPtr GetFlowActorsAndComponentsByTags_ReturnValue_NativeProperty_ParamsBuffer = IntPtr.Add(ParamsBuffer, GetFlowActorsAndComponentsByTags_ReturnValue_Offset);
            returnValue = GetFlowActorsAndComponentsByTags_ReturnValue_Marshaller.FromNative(ParamsBuffer, 0);
            
            return returnValue;
        }
    }
    
    
}