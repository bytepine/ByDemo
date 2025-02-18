using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Base component of Flow System - makes possible to communicate between Actor, Flow Subsystem and Flow Graphs
/// </summary>
[UClass, GeneratedType("FlowComponent", "UnrealSharp.Flow.FlowComponent")]
public partial class UFlowComponent : UnrealSharp.Engine.UActorComponent, UnrealSharp.Flow.IFlowOwnerInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowComponent()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowComponent");
        IntPtr IdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "IdentityTags");
        IdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(IdentityTags_NativeProperty);
        IntPtr AddedIdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AddedIdentityTags");
        AddedIdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(AddedIdentityTags_NativeProperty);
        IntPtr RemovedIdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RemovedIdentityTags");
        RemovedIdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(RemovedIdentityTags_NativeProperty);
        OnIdentityTagsAdded_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnIdentityTagsAdded");
        OnIdentityTagsAdded_Offset = FPropertyExporter.CallGetPropertyOffset(OnIdentityTagsAdded_NativeProperty);
        UnrealSharp.Flow.UFlowComponentTagsReplicated.InitializeUnrealDelegate(OnIdentityTagsAdded_NativeProperty);
        OnIdentityTagsRemoved_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OnIdentityTagsRemoved");
        OnIdentityTagsRemoved_Offset = FPropertyExporter.CallGetPropertyOffset(OnIdentityTagsRemoved_NativeProperty);
        UnrealSharp.Flow.UFlowComponentTagsReplicated.InitializeUnrealDelegate(OnIdentityTagsRemoved_NativeProperty);
        IntPtr RecentlySentNotifyTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecentlySentNotifyTags");
        RecentlySentNotifyTags_Offset = FPropertyExporter.CallGetPropertyOffset(RecentlySentNotifyTags_NativeProperty);
        IntPtr NotifyTagsFromGraph_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NotifyTagsFromGraph");
        NotifyTagsFromGraph_Offset = FPropertyExporter.CallGetPropertyOffset(NotifyTagsFromGraph_NativeProperty);
        ReceiveNotify_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ReceiveNotify");
        ReceiveNotify_Offset = FPropertyExporter.CallGetPropertyOffset(ReceiveNotify_NativeProperty);
        UnrealSharp.Flow.UFlowComponentDynamicNotify.InitializeUnrealDelegate(ReceiveNotify_NativeProperty);
        NotifyTagsFromAnotherComponent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NotifyTagsFromAnotherComponent");
        NotifyTagsFromAnotherComponent_Offset = FPropertyExporter.CallGetPropertyOffset(NotifyTagsFromAnotherComponent_NativeProperty);
        IntPtr RootFlow_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RootFlow");
        RootFlow_Offset = FPropertyExporter.CallGetPropertyOffset(RootFlow_NativeProperty);
        IntPtr bAutoStartRootFlow_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAutoStartRootFlow");
        bAutoStartRootFlow_Offset = FPropertyExporter.CallGetPropertyOffset(bAutoStartRootFlow_NativeProperty);
        IntPtr RootFlowMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RootFlowMode");
        RootFlowMode_Offset = FPropertyExporter.CallGetPropertyOffset(RootFlowMode_NativeProperty);
        IntPtr bAllowMultipleInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowMultipleInstances");
        bAllowMultipleInstances_Offset = FPropertyExporter.CallGetPropertyOffset(bAllowMultipleInstances_NativeProperty);
        SavedAssetInstanceName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SavedAssetInstanceName");
        SavedAssetInstanceName_Offset = FPropertyExporter.CallGetPropertyOffset(SavedAssetInstanceName_NativeProperty);
        GetRootFlowInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootFlowInstance");
        GetRootFlowInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootFlowInstance_NativeFunction);
        GetRootFlowInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootFlowInstance_NativeFunction, "ReturnValue");
        AddIdentityTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddIdentityTag");
        AddIdentityTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddIdentityTag_NativeFunction);
        AddIdentityTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddIdentityTag_NativeFunction, "Tag");
        AddIdentityTag_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddIdentityTag_NativeFunction, "NetMode");
        AddIdentityTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddIdentityTags");
        AddIdentityTags_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddIdentityTags_NativeFunction);
        AddIdentityTags_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddIdentityTags_NativeFunction, "Tags");
        AddIdentityTags_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddIdentityTags_NativeFunction, "NetMode");
        RemoveIdentityTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveIdentityTag");
        RemoveIdentityTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveIdentityTag_NativeFunction);
        RemoveIdentityTag_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveIdentityTag_NativeFunction, "Tag");
        RemoveIdentityTag_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveIdentityTag_NativeFunction, "NetMode");
        RemoveIdentityTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveIdentityTags");
        RemoveIdentityTags_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveIdentityTags_NativeFunction);
        RemoveIdentityTags_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveIdentityTags_NativeFunction, "Tags");
        RemoveIdentityTags_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveIdentityTags_NativeFunction, "NetMode");
        OnRep_AddedIdentityTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_AddedIdentityTags");
        OnRep_RemovedIdentityTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_RemovedIdentityTags");
        LogError_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LogError");
        LogError_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LogError_NativeFunction);
        LogError_Message_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogError_NativeFunction, "Message");
        LogError_OnScreenMessageType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogError_NativeFunction, "OnScreenMessageType");
        NotifyGraph_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "NotifyGraph");
        NotifyGraph_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(NotifyGraph_NativeFunction);
        NotifyGraph_NotifyTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyGraph_NativeFunction, "NotifyTag");
        NotifyGraph_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyGraph_NativeFunction, "NetMode");
        BulkNotifyGraph_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "BulkNotifyGraph");
        BulkNotifyGraph_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(BulkNotifyGraph_NativeFunction);
        BulkNotifyGraph_NotifyTags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BulkNotifyGraph_NativeFunction, "NotifyTags");
        BulkNotifyGraph_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BulkNotifyGraph_NativeFunction, "NetMode");
        OnRep_SentNotifyTags_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_SentNotifyTags");
        OnRep_NotifyTagsFromGraph_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_NotifyTagsFromGraph");
        NotifyActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "NotifyActor");
        NotifyActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(NotifyActor_NativeFunction);
        NotifyActor_ActorTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyActor_NativeFunction, "ActorTag");
        NotifyActor_NotifyTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyActor_NativeFunction, "NotifyTag");
        NotifyActor_NetMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyActor_NativeFunction, "NetMode");
        OnRep_NotifyTagsFromAnotherComponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_NotifyTagsFromAnotherComponent");
        StartRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StartRootFlow");
        FinishRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinishRootFlow");
        FinishRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FinishRootFlow_NativeFunction);
        FinishRootFlow_TemplateAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishRootFlow_NativeFunction, "TemplateAsset");
        FinishRootFlow_FinishPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishRootFlow_NativeFunction, "FinishPolicy");
        GetRootInstances_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootInstances");
        GetRootInstances_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootInstances_NativeFunction);
        GetRootInstances_Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootInstances_NativeFunction, "Owner");
        GetRootInstances_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootInstances_NativeFunction, "ReturnValue");
        GetRootInstances_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetRootInstances_NativeFunction, "ReturnValue");
        TriggerRootFlowCustomInput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TriggerRootFlowCustomInput");
        TriggerRootFlowCustomInput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TriggerRootFlowCustomInput_NativeFunction);
        TriggerRootFlowCustomInput_EventName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerRootFlowCustomInput_NativeFunction, "EventName");
        SaveRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveRootFlow");
        SaveRootFlow_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveRootFlow_NativeFunction);
        SaveRootFlow_SavedFlowInstances_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveRootFlow_NativeFunction, "SavedFlowInstances");
        SaveRootFlow_SavedFlowInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(SaveRootFlow_NativeFunction, "SavedFlowInstances");
        LoadRootFlow_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadRootFlow");
        SaveInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveInstance");
        SaveInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveInstance_NativeFunction);
        SaveInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveInstance_NativeFunction, "ReturnValue");
        LoadInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadInstance");
        LoadInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadInstance_NativeFunction);
        LoadInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadInstance_NativeFunction, "ReturnValue");
        IntPtr BP_OnRootFlowCustomEvent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "BP_OnRootFlowCustomEvent");
        BP_OnRootFlowCustomEvent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(BP_OnRootFlowCustomEvent_NativeFunction);
        BP_OnRootFlowCustomEvent_RootFlowInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BP_OnRootFlowCustomEvent_NativeFunction, "RootFlowInstance");
        BP_OnRootFlowCustomEvent_EventName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BP_OnRootFlowCustomEvent_NativeFunction, "EventName");
    }
    
    static int IdentityTags_Offset;
    
    /// <summary>
    /// Identity Tags
    /// </summary>
    public UnrealSharp.GameplayTags.FGameplayTagContainer IdentityTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, IdentityTags_Offset), 0);
        }
        init
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(NativeObject, IdentityTags_Offset), 0, value);
        }
    }
    
    
    static int AddedIdentityTags_Offset;
    
    /// <summary>
    /// Used to replicate tags added during gameplay
    /// </summary>
    private UnrealSharp.GameplayTags.FGameplayTagContainer AddedIdentityTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, AddedIdentityTags_Offset), 0);
        }
    }
    
    
    static int RemovedIdentityTags_Offset;
    
    /// <summary>
    /// Used to replicate tags removed during gameplay
    /// </summary>
    private UnrealSharp.GameplayTags.FGameplayTagContainer RemovedIdentityTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, RemovedIdentityTags_Offset), 0);
        }
    }
    
    
    static int OnIdentityTagsAdded_Offset;
    static IntPtr OnIdentityTagsAdded_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.FlowComponentTagsReplicated> OnIdentityTagsAdded_BackingField;
    
    public TMulticastDelegate<UnrealSharp.Flow.FlowComponentTagsReplicated> OnIdentityTagsAdded
    {
        get
        {
            if (OnIdentityTagsAdded_BackingField == null)
            {
                OnIdentityTagsAdded_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentTagsReplicated>.FromNative(IntPtr.Add(NativeObject, OnIdentityTagsAdded_Offset), OnIdentityTagsAdded_NativeProperty, 0);
            }
            return OnIdentityTagsAdded_BackingField;
        }
        set
        {
            if (value == OnIdentityTagsAdded_BackingField)
            {
                return;
            }
            OnIdentityTagsAdded_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentTagsReplicated>.ToNative(IntPtr.Add(NativeObject, OnIdentityTagsAdded_Offset), 0, value);
        }
    }
    
    
    static int OnIdentityTagsRemoved_Offset;
    static IntPtr OnIdentityTagsRemoved_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.FlowComponentTagsReplicated> OnIdentityTagsRemoved_BackingField;
    
    public TMulticastDelegate<UnrealSharp.Flow.FlowComponentTagsReplicated> OnIdentityTagsRemoved
    {
        get
        {
            if (OnIdentityTagsRemoved_BackingField == null)
            {
                OnIdentityTagsRemoved_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentTagsReplicated>.FromNative(IntPtr.Add(NativeObject, OnIdentityTagsRemoved_Offset), OnIdentityTagsRemoved_NativeProperty, 0);
            }
            return OnIdentityTagsRemoved_BackingField;
        }
        set
        {
            if (value == OnIdentityTagsRemoved_BackingField)
            {
                return;
            }
            OnIdentityTagsRemoved_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentTagsReplicated>.ToNative(IntPtr.Add(NativeObject, OnIdentityTagsRemoved_Offset), 0, value);
        }
    }
    
    
    static int RecentlySentNotifyTags_Offset;
    
    /// <summary>
    /// Stores only recently sent tags
    /// </summary>
    private UnrealSharp.GameplayTags.FGameplayTagContainer RecentlySentNotifyTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, RecentlySentNotifyTags_Offset), 0);
        }
    }
    
    
    static int NotifyTagsFromGraph_Offset;
    
    /// <summary>
    /// Stores only recently replicated tags
    /// </summary>
    private UnrealSharp.GameplayTags.FGameplayTagContainer NotifyTagsFromGraph
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, NotifyTagsFromGraph_Offset), 0);
        }
    }
    
    
    static int ReceiveNotify_Offset;
    static IntPtr ReceiveNotify_NativeProperty;
    private TMulticastDelegate<UnrealSharp.Flow.FlowComponentDynamicNotify> ReceiveNotify_BackingField;
    
    /// <summary>
    /// Receive notification from Flow graph or another Flow Component
    /// </summary>
    public TMulticastDelegate<UnrealSharp.Flow.FlowComponentDynamicNotify> ReceiveNotify
    {
        get
        {
            if (ReceiveNotify_BackingField == null)
            {
                ReceiveNotify_BackingField = MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentDynamicNotify>.FromNative(IntPtr.Add(NativeObject, ReceiveNotify_Offset), ReceiveNotify_NativeProperty, 0);
            }
            return ReceiveNotify_BackingField;
        }
        set
        {
            if (value == ReceiveNotify_BackingField)
            {
                return;
            }
            ReceiveNotify_BackingField = value;
            MulticastDelegateMarshaller<UnrealSharp.Flow.FlowComponentDynamicNotify>.ToNative(IntPtr.Add(NativeObject, ReceiveNotify_Offset), 0, value);
        }
    }
    
    
    static int NotifyTagsFromAnotherComponent_Offset;
    static IntPtr NotifyTagsFromAnotherComponent_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FNotifyTagReplication> NotifyTagsFromAnotherComponent_Marshaller = null;
    
    /// <summary>
    /// Stores only recently replicated tags
    /// </summary>
    private System.Collections.Generic.IList<UnrealSharp.Flow.FNotifyTagReplication> NotifyTagsFromAnotherComponent
    {
        get
        {
            NotifyTagsFromAnotherComponent_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FNotifyTagReplication>(NotifyTagsFromAnotherComponent_NativeProperty, StructMarshaller<UnrealSharp.Flow.FNotifyTagReplication>.ToNative, StructMarshaller<UnrealSharp.Flow.FNotifyTagReplication>.FromNative);
            return NotifyTagsFromAnotherComponent_Marshaller.FromNative(IntPtr.Add(NativeObject, NotifyTagsFromAnotherComponent_Offset), 0);
        }
    }
    
    
    static int RootFlow_Offset;
    
    /// <summary>
    /// Asset that might instantiated as "Root Flow"
    /// </summary>
    public UnrealSharp.Flow.UFlowAsset RootFlow
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, RootFlow_Offset), 0);
        }
        set
        {
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(NativeObject, RootFlow_Offset), 0, value);
        }
    }
    
    
    static int bAutoStartRootFlow_Offset;
    
    /// <summary>
    /// If true, component will start Root Flow on Begin Play
    /// </summary>
    public bool AutoStartRootFlow
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAutoStartRootFlow_Offset), 0);
        }
        init
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAutoStartRootFlow_Offset), 0, value);
        }
    }
    
    
    static int RootFlowMode_Offset;
    
    /// <summary>
    /// Networking mode for creating this Root Flow
    /// </summary>
    public UnrealSharp.Flow.EFlowNetMode RootFlowMode
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.FromNative(IntPtr.Add(NativeObject, RootFlowMode_Offset), 0);
        }
        init
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(NativeObject, RootFlowMode_Offset), 0, value);
        }
    }
    
    
    static int bAllowMultipleInstances_Offset;
    
    /// <summary>
    /// If false, another Root Flow instance won't be created from this component, if this Flow Asset is already instantiated
    /// </summary>
    public bool AllowMultipleInstances
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAllowMultipleInstances_Offset), 0);
        }
        init
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAllowMultipleInstances_Offset), 0, value);
        }
    }
    
    
    static int SavedAssetInstanceName_Offset;
    static IntPtr SavedAssetInstanceName_NativeProperty;
    
    public string SavedAssetInstanceName
    {
        get
        {
            IntPtr SavedAssetInstanceName_NativePtr = IntPtr.Add(NativeObject,SavedAssetInstanceName_Offset);
            return StringMarshaller.FromNative(SavedAssetInstanceName_NativePtr,0);
        }
    }
    
    
    // GetRootFlowInstance
    static IntPtr GetRootFlowInstance_NativeFunction;
    static int GetRootFlowInstance_ParamsSize;
    static int GetRootFlowInstance_ReturnValue_Offset;
    
    public UnrealSharp.Flow.UFlowAsset RootFlowInstance
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetRootFlowInstance_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetRootFlowInstance_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootFlowInstance_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowAsset returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(ParamsBuffer, GetRootFlowInstance_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    // AddIdentityTag
    static IntPtr AddIdentityTag_NativeFunction;
    static int AddIdentityTag_ParamsSize;
    static int AddIdentityTag_Tag_Offset;
    static int AddIdentityTag_NetMode_Offset;
    
    public void AddIdentityTag(UnrealSharp.GameplayTags.FGameplayTag tag)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        AddIdentityTag(tag, netMode);
    }
    
    [UFunction, GeneratedType("AddIdentityTag")]
    public void AddIdentityTag(UnrealSharp.GameplayTags.FGameplayTag tag, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddIdentityTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AddIdentityTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, AddIdentityTag_Tag_Offset), 0, tag);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, AddIdentityTag_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddIdentityTag_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // AddIdentityTags
    static IntPtr AddIdentityTags_NativeFunction;
    static int AddIdentityTags_ParamsSize;
    static int AddIdentityTags_Tags_Offset;
    static int AddIdentityTags_NetMode_Offset;
    
    public void AddIdentityTags(UnrealSharp.GameplayTags.FGameplayTagContainer tags)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        AddIdentityTags(tags, netMode);
    }
    
    [UFunction, GeneratedType("AddIdentityTags")]
    public void AddIdentityTags(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddIdentityTags_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AddIdentityTags_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, AddIdentityTags_Tags_Offset), 0, tags);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, AddIdentityTags_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddIdentityTags_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // RemoveIdentityTag
    static IntPtr RemoveIdentityTag_NativeFunction;
    static int RemoveIdentityTag_ParamsSize;
    static int RemoveIdentityTag_Tag_Offset;
    static int RemoveIdentityTag_NetMode_Offset;
    
    public void RemoveIdentityTag(UnrealSharp.GameplayTags.FGameplayTag tag)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        RemoveIdentityTag(tag, netMode);
    }
    
    [UFunction, GeneratedType("RemoveIdentityTag")]
    public void RemoveIdentityTag(UnrealSharp.GameplayTags.FGameplayTag tag, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveIdentityTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(RemoveIdentityTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, RemoveIdentityTag_Tag_Offset), 0, tag);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, RemoveIdentityTag_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveIdentityTag_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // RemoveIdentityTags
    static IntPtr RemoveIdentityTags_NativeFunction;
    static int RemoveIdentityTags_ParamsSize;
    static int RemoveIdentityTags_Tags_Offset;
    static int RemoveIdentityTags_NetMode_Offset;
    
    public void RemoveIdentityTags(UnrealSharp.GameplayTags.FGameplayTagContainer tags)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        RemoveIdentityTags(tags, netMode);
    }
    
    [UFunction, GeneratedType("RemoveIdentityTags")]
    public void RemoveIdentityTags(UnrealSharp.GameplayTags.FGameplayTagContainer tags, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveIdentityTags_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(RemoveIdentityTags_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, RemoveIdentityTags_Tags_Offset), 0, tags);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, RemoveIdentityTags_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveIdentityTags_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnRep_AddedIdentityTags
    static IntPtr OnRep_AddedIdentityTags_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_AddedIdentityTags")]
    public void OnRep_AddedIdentityTags()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_AddedIdentityTags_NativeFunction, IntPtr.Zero);
        }
    }
    
    // OnRep_RemovedIdentityTags
    static IntPtr OnRep_RemovedIdentityTags_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_RemovedIdentityTags")]
    public void OnRep_RemovedIdentityTags()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_RemovedIdentityTags_NativeFunction, IntPtr.Zero);
        }
    }
    
    // LogError
    static IntPtr LogError_NativeFunction;
    static int LogError_ParamsSize;
    static int LogError_Message_Offset;
    static int LogError_OnScreenMessageType_Offset;
    
    public void LogError(string message)
    {
        UnrealSharp.Flow.EFlowOnScreenMessageType onScreenMessageType = UnrealSharp.Flow.EFlowOnScreenMessageType.Permanent;
        LogError(message, onScreenMessageType);
    }
    
    [UFunction, GeneratedType("LogError")]
    public void LogError(string message, UnrealSharp.Flow.EFlowOnScreenMessageType onScreenMessageType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LogError_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LogError_NativeFunction, ParamsBuffer);
            IntPtr Message_NativePtr = IntPtr.Add(ParamsBuffer, LogError_Message_Offset);
            StringMarshaller.ToNative(Message_NativePtr,0,message);
            EnumMarshaller<UnrealSharp.Flow.EFlowOnScreenMessageType>.ToNative(IntPtr.Add(ParamsBuffer, LogError_OnScreenMessageType_Offset), 0, onScreenMessageType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LogError_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Message_NativePtr, 0);
        }
    }
    
    // NotifyGraph
    static IntPtr NotifyGraph_NativeFunction;
    static int NotifyGraph_ParamsSize;
    static int NotifyGraph_NotifyTag_Offset;
    static int NotifyGraph_NetMode_Offset;
    
    public void NotifyGraph(UnrealSharp.GameplayTags.FGameplayTag notifyTag)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        NotifyGraph(notifyTag, netMode);
    }
    
    /// <summary>
    /// Send single notification from the actor to Flow graphs
    /// If set on server, it's always going to be replicated to clients
    /// </summary>
    [UFunction, GeneratedType("NotifyGraph")]
    public void NotifyGraph(UnrealSharp.GameplayTags.FGameplayTag notifyTag, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[NotifyGraph_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(NotifyGraph_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, NotifyGraph_NotifyTag_Offset), 0, notifyTag);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, NotifyGraph_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, NotifyGraph_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // BulkNotifyGraph
    static IntPtr BulkNotifyGraph_NativeFunction;
    static int BulkNotifyGraph_ParamsSize;
    static int BulkNotifyGraph_NotifyTags_Offset;
    static int BulkNotifyGraph_NetMode_Offset;
    
    public void BulkNotifyGraph(UnrealSharp.GameplayTags.FGameplayTagContainer notifyTags)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        BulkNotifyGraph(notifyTags, netMode);
    }
    
    /// <summary>
    /// Send multiple notifications at once - from the actor to Flow graphs
    /// If set on server, it's always going to be replicated to clients
    /// </summary>
    [UFunction, GeneratedType("BulkNotifyGraph")]
    public void BulkNotifyGraph(UnrealSharp.GameplayTags.FGameplayTagContainer notifyTags, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[BulkNotifyGraph_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(BulkNotifyGraph_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, BulkNotifyGraph_NotifyTags_Offset), 0, notifyTags);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, BulkNotifyGraph_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, BulkNotifyGraph_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnRep_SentNotifyTags
    static IntPtr OnRep_SentNotifyTags_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_SentNotifyTags")]
    public void OnRep_SentNotifyTags()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_SentNotifyTags_NativeFunction, IntPtr.Zero);
        }
    }
    
    // OnRep_NotifyTagsFromGraph
    static IntPtr OnRep_NotifyTagsFromGraph_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_NotifyTagsFromGraph")]
    public void OnRep_NotifyTagsFromGraph()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_NotifyTagsFromGraph_NativeFunction, IntPtr.Zero);
        }
    }
    
    // NotifyActor
    static IntPtr NotifyActor_NativeFunction;
    static int NotifyActor_ParamsSize;
    static int NotifyActor_ActorTag_Offset;
    static int NotifyActor_NotifyTag_Offset;
    static int NotifyActor_NetMode_Offset;
    
    public void NotifyActor(UnrealSharp.GameplayTags.FGameplayTag actorTag, UnrealSharp.GameplayTags.FGameplayTag notifyTag)
    {
        UnrealSharp.Flow.EFlowNetMode netMode = UnrealSharp.Flow.EFlowNetMode.Authority;
        NotifyActor(actorTag, notifyTag, netMode);
    }
    
    /// <summary>
    /// Send notification to another actor containing Flow Component
    /// </summary>
    [UFunction, GeneratedType("NotifyActor")]
    public void NotifyActor(UnrealSharp.GameplayTags.FGameplayTag actorTag, UnrealSharp.GameplayTags.FGameplayTag notifyTag, UnrealSharp.Flow.EFlowNetMode netMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[NotifyActor_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(NotifyActor_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, NotifyActor_ActorTag_Offset), 0, actorTag);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, NotifyActor_NotifyTag_Offset), 0, notifyTag);
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(ParamsBuffer, NotifyActor_NetMode_Offset), 0, netMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, NotifyActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnRep_NotifyTagsFromAnotherComponent
    static IntPtr OnRep_NotifyTagsFromAnotherComponent_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_NotifyTagsFromAnotherComponent")]
    public void OnRep_NotifyTagsFromAnotherComponent()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_NotifyTagsFromAnotherComponent_NativeFunction, IntPtr.Zero);
        }
    }
    
    // StartRootFlow
    static IntPtr StartRootFlow_NativeFunction;
    
    /// <summary>
    /// This will instantiate Flow Asset assigned on this component.
    /// Created Flow Asset instance will be a "root flow", as additional Flow Assets can be instantiated via Sub Graph node
    /// </summary>
    [UFunction, GeneratedType("StartRootFlow")]
    public void StartRootFlow()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, StartRootFlow_NativeFunction, IntPtr.Zero);
        }
    }
    
    // FinishRootFlow
    static IntPtr FinishRootFlow_NativeFunction;
    static int FinishRootFlow_ParamsSize;
    static int FinishRootFlow_TemplateAsset_Offset;
    static int FinishRootFlow_FinishPolicy_Offset;
    
    /// <summary>
    /// This will destroy instantiated Flow Asset - created from asset assigned on this component.
    /// </summary>
    [UFunction, GeneratedType("FinishRootFlow")]
    public void FinishRootFlow(UnrealSharp.Flow.UFlowAsset templateAsset, UnrealSharp.Flow.EFlowFinishPolicy finishPolicy)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FinishRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FinishRootFlow_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, FinishRootFlow_TemplateAsset_Offset), 0, templateAsset);
            EnumMarshaller<UnrealSharp.Flow.EFlowFinishPolicy>.ToNative(IntPtr.Add(ParamsBuffer, FinishRootFlow_FinishPolicy_Offset), 0, finishPolicy);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinishRootFlow_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // GetRootInstances
    static IntPtr GetRootInstances_NativeFunction;
    static int GetRootInstances_ParamsSize;
    static int GetRootInstances_Owner_Offset;
    static int GetRootInstances_ReturnValue_Offset;
    static IntPtr GetRootInstances_ReturnValue_NativeProperty;
    SetCopyMarshaller<UnrealSharp.Flow.UFlowAsset> GetRootInstances_ReturnValue_Marshaller = null;
    
    [UFunction, GeneratedType("GetRootInstances")]
    public System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowAsset> GetRootInstances(UnrealSharp.CoreUObject.UObject owner)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRootInstances_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetRootInstances_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, GetRootInstances_Owner_Offset), 0, owner);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootInstances_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowAsset> returnValue;
            GetRootInstances_ReturnValue_Marshaller ??= new SetCopyMarshaller<UnrealSharp.Flow.UFlowAsset>(GetRootInstances_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetRootInstances_ReturnValue_Offset);
            returnValue = GetRootInstances_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetRootInstances_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // TriggerRootFlowCustomInput
    static IntPtr TriggerRootFlowCustomInput_NativeFunction;
    static int TriggerRootFlowCustomInput_ParamsSize;
    static int TriggerRootFlowCustomInput_EventName_Offset;
    
    /// <summary>
    /// This will trigger a specific CustomInput on this components root flow
    /// </summary>
    [UFunction, GeneratedType("TriggerRootFlowCustomInput")]
    public void TriggerRootFlowCustomInput(FName eventName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TriggerRootFlowCustomInput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TriggerRootFlowCustomInput_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TriggerRootFlowCustomInput_EventName_Offset), 0, eventName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TriggerRootFlowCustomInput_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // SaveRootFlow
    static IntPtr SaveRootFlow_NativeFunction;
    static int SaveRootFlow_ParamsSize;
    static int SaveRootFlow_SavedFlowInstances_Offset;
    static IntPtr SaveRootFlow_SavedFlowInstances_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.FFlowAssetSaveData> SaveRootFlow_SavedFlowInstances_Marshaller = null;
    
    [UFunction, GeneratedType("SaveRootFlow")]
    public void SaveRootFlow(out System.Collections.Generic.IList<UnrealSharp.Flow.FFlowAssetSaveData> savedFlowInstances)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveRootFlow_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SaveRootFlow_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveRootFlow_NativeFunction, ParamsBuffer);
            
            SaveRootFlow_SavedFlowInstances_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>(SaveRootFlow_SavedFlowInstances_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.FromNative);
            IntPtr SavedFlowInstances_NativeBuffer = IntPtr.Add(ParamsBuffer, SaveRootFlow_SavedFlowInstances_Offset);
            savedFlowInstances = SaveRootFlow_SavedFlowInstances_Marshaller.FromNative(SavedFlowInstances_NativeBuffer, 0);
            SaveRootFlow_SavedFlowInstances_Marshaller.DestructInstance(SavedFlowInstances_NativeBuffer, 0);
            
        }
    }
    
    // LoadRootFlow
    static IntPtr LoadRootFlow_NativeFunction;
    
    [UFunction, GeneratedType("LoadRootFlow")]
    public void LoadRootFlow()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadRootFlow_NativeFunction, IntPtr.Zero);
        }
    }
    
    // SaveInstance
    static IntPtr SaveInstance_NativeFunction;
    static int SaveInstance_ParamsSize;
    static int SaveInstance_ReturnValue_Offset;
    
    [UFunction, GeneratedType("SaveInstance")]
    public UnrealSharp.Flow.FFlowComponentSaveData SaveInstance()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SaveInstance_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveInstance_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowComponentSaveData returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowComponentSaveData>.FromNative(IntPtr.Add(ParamsBuffer, SaveInstance_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // LoadInstance
    static IntPtr LoadInstance_NativeFunction;
    static int LoadInstance_ParamsSize;
    static int LoadInstance_ReturnValue_Offset;
    
    [UFunction, GeneratedType("LoadInstance")]
    public bool LoadInstance()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LoadInstance_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadInstance_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, LoadInstance_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // BP_OnRootFlowCustomEvent
    IntPtr BP_OnRootFlowCustomEvent_NativeFunction;
    static int BP_OnRootFlowCustomEvent_ParamsSize;
    static int BP_OnRootFlowCustomEvent_RootFlowInstance_Offset;
    static int BP_OnRootFlowCustomEvent_EventName_Offset;
    
    /// <summary>
    /// Called when a Root flow asset triggers a CustomOutput
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("BP_OnRootFlowCustomEvent")]
    public virtual void OnRootFlowCustomEvent(UnrealSharp.Flow.UFlowAsset rootFlowInstance, FName eventName)
    {
        unsafe
        {
            if (BP_OnRootFlowCustomEvent_NativeFunction == IntPtr.Zero)
            {
                BP_OnRootFlowCustomEvent_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "BP_OnRootFlowCustomEvent");
            }
            byte* ParamsBufferAllocation = stackalloc byte[BP_OnRootFlowCustomEvent_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(BP_OnRootFlowCustomEvent_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, BP_OnRootFlowCustomEvent_RootFlowInstance_Offset), 0, rootFlowInstance);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, BP_OnRootFlowCustomEvent_EventName_Offset), 0, eventName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, BP_OnRootFlowCustomEvent_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnRootFlowCustomEvent_Implementation(UnrealSharp.Flow.UFlowAsset RootFlowInstance, FName EventName)
    {
    }
    void Invoke_BP_OnRootFlowCustomEvent(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Flow.UFlowAsset RootFlowInstance =  ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(buffer, BP_OnRootFlowCustomEvent_RootFlowInstance_Offset), 0);
            FName EventName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, BP_OnRootFlowCustomEvent_EventName_Offset), 0);
            OnRootFlowCustomEvent_Implementation(RootFlowInstance, EventName);
        }
    }
    
    // OnSave
    IntPtr OnSave_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("OnSave")]
    protected virtual void OnSave()
    {
        unsafe
        {
            if (OnSave_NativeFunction == IntPtr.Zero)
            {
                OnSave_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnSave");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnSave_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnSave_Implementation()
    {
    }
    void Invoke_OnSave(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnSave_Implementation();
        }
    }
    
    // OnLoad
    IntPtr OnLoad_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("OnLoad")]
    protected virtual void OnLoad()
    {
        unsafe
        {
            if (OnLoad_NativeFunction == IntPtr.Zero)
            {
                OnLoad_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnLoad");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnLoad_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnLoad_Implementation()
    {
    }
    void Invoke_OnLoad(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnLoad_Implementation();
        }
    }
    
    
}