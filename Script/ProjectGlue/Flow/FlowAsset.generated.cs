using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Single asset containing flow nodes.
/// </summary>
[UClass, GeneratedType("FlowAsset", "UnrealSharp.Flow.FlowAsset")]
public partial class UFlowAsset : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UFlowAsset()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowAsset");
        IntPtr AssetGuid_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AssetGuid");
        AssetGuid_Offset = FPropertyExporter.CallGetPropertyOffset(AssetGuid_NativeProperty);
        IntPtr bWorldBound_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bWorldBound");
        bWorldBound_Offset = FPropertyExporter.CallGetPropertyOffset(bWorldBound_NativeProperty);
        #if WITH_EDITOR
        IntPtr FlowGraph_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowGraph");
        FlowGraph_Offset = FPropertyExporter.CallGetPropertyOffset(FlowGraph_NativeProperty);
        #endif
        Nodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Nodes");
        Nodes_Offset = FPropertyExporter.CallGetPropertyOffset(Nodes_NativeProperty);
        #if WITH_EDITOR
        CustomInputs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CustomInputs");
        CustomInputs_Offset = FPropertyExporter.CallGetPropertyOffset(CustomInputs_NativeProperty);
        #endif
        #if WITH_EDITOR
        CustomOutputs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CustomOutputs");
        CustomOutputs_Offset = FPropertyExporter.CallGetPropertyOffset(CustomOutputs_NativeProperty);
        #endif
        ActiveInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActiveInstances");
        ActiveInstances_Offset = FPropertyExporter.CallGetPropertyOffset(ActiveInstances_NativeProperty);
        IntPtr TemplateAsset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TemplateAsset");
        TemplateAsset_Offset = FPropertyExporter.CallGetPropertyOffset(TemplateAsset_NativeProperty);
        CustomInputNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CustomInputNodes");
        CustomInputNodes_Offset = FPropertyExporter.CallGetPropertyOffset(CustomInputNodes_NativeProperty);
        PreloadedNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PreloadedNodes");
        PreloadedNodes_Offset = FPropertyExporter.CallGetPropertyOffset(PreloadedNodes_NativeProperty);
        IntPtr ExpectedOwnerClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExpectedOwnerClass");
        ExpectedOwnerClass_Offset = FPropertyExporter.CallGetPropertyOffset(ExpectedOwnerClass_NativeProperty);
        ActiveNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActiveNodes");
        ActiveNodes_Offset = FPropertyExporter.CallGetPropertyOffset(ActiveNodes_NativeProperty);
        GetActiveNodes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetActiveNodes");
        GetActiveNodes_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetActiveNodes_NativeFunction);
        GetActiveNodes_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetActiveNodes_NativeFunction, "ReturnValue");
        GetActiveNodes_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetActiveNodes_NativeFunction, "ReturnValue");
        RecordedNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecordedNodes");
        RecordedNodes_Offset = FPropertyExporter.CallGetPropertyOffset(RecordedNodes_NativeProperty);
        GetRecordedNodes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRecordedNodes");
        GetRecordedNodes_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRecordedNodes_NativeFunction);
        GetRecordedNodes_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRecordedNodes_NativeFunction, "ReturnValue");
        GetRecordedNodes_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetRecordedNodes_NativeFunction, "ReturnValue");
        GetDefaultEntryNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDefaultEntryNode");
        GetDefaultEntryNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDefaultEntryNode_NativeFunction);
        GetDefaultEntryNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDefaultEntryNode_NativeFunction, "ReturnValue");
        GetOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOwner");
        GetOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOwner_NativeFunction);
        GetOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOwner_NativeFunction, "ReturnValue");
        GetNodesInExecutionOrder_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNodesInExecutionOrder");
        GetNodesInExecutionOrder_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNodesInExecutionOrder_NativeFunction);
        GetNodesInExecutionOrder_FirstIteratedNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodesInExecutionOrder_NativeFunction, "FirstIteratedNode");
        GetNodesInExecutionOrder_FlowNodeClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodesInExecutionOrder_NativeFunction, "FlowNodeClass");
        GetNodesInExecutionOrder_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodesInExecutionOrder_NativeFunction, "ReturnValue");
        GetNodesInExecutionOrder_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetNodesInExecutionOrder_NativeFunction, "ReturnValue");
        TryFindActorOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryFindActorOwner");
        TryFindActorOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryFindActorOwner_NativeFunction);
        TryFindActorOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryFindActorOwner_NativeFunction, "ReturnValue");
        IsActive_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsActive");
        IsActive_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsActive_NativeFunction);
        IsActive_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsActive_NativeFunction, "ReturnValue");
        SaveInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveInstance");
        SaveInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveInstance_NativeFunction);
        SaveInstance_SavedFlowInstances_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveInstance_NativeFunction, "SavedFlowInstances");
        SaveInstance_SavedFlowInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(SaveInstance_NativeFunction, "SavedFlowInstances");
        SaveInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveInstance_NativeFunction, "ReturnValue");
        LoadInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadInstance");
        LoadInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadInstance_NativeFunction);
        LoadInstance_AssetRecord_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadInstance_NativeFunction, "AssetRecord");
        IntPtr IsBoundToWorld_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsBoundToWorld");
        IsBoundToWorld_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsBoundToWorld_NativeFunction);
        IsBoundToWorld_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsBoundToWorld_NativeFunction, "ReturnValue");
    }
    
    static int AssetGuid_Offset;
    
    public UnrealSharp.CoreUObject.FGuid AssetGuid
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative(IntPtr.Add(NativeObject, AssetGuid_Offset), 0);
        }
        init
        {
            StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative(IntPtr.Add(NativeObject, AssetGuid_Offset), 0, value);
        }
    }
    
    
    static int bWorldBound_Offset;
    
    /// <summary>
    /// Set it to False, if this asset is instantiated as Root Flow for owner that doesn't live in the world
    /// This allows to SaveGame support works properly, if owner of Root Flow would be Game Instance or its subsystem
    /// </summary>
    public bool WorldBound
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bWorldBound_Offset), 0);
        }
        init
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bWorldBound_Offset), 0, value);
        }
    }
    
    
    #if WITH_EDITOR
    static int FlowGraph_Offset;
    
    private UnrealSharp.Engine.UEdGraph FlowGraph
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.UEdGraph>.FromNative(IntPtr.Add(NativeObject, FlowGraph_Offset), 0);
        }
    }
    #endif
    
    
    static int Nodes_Offset;
    static IntPtr Nodes_NativeProperty;
    MapMarshaller<UnrealSharp.CoreUObject.FGuid, UnrealSharp.Flow.UFlowNode> Nodes_Marshaller = null;
    
    private System.Collections.Generic.IDictionary<UnrealSharp.CoreUObject.FGuid, UnrealSharp.Flow.UFlowNode> Nodes
    {
        get
        {
            Nodes_Marshaller ??= new MapMarshaller<UnrealSharp.CoreUObject.FGuid, UnrealSharp.Flow.UFlowNode>(Nodes_NativeProperty, StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
            return Nodes_Marshaller.FromNative(IntPtr.Add(NativeObject, Nodes_Offset), 0);
        }
    }
    
    
    #if WITH_EDITOR
    static int CustomInputs_Offset;
    static IntPtr CustomInputs_NativeProperty;
    ArrayMarshaller<FName> CustomInputs_Marshaller = null;
    
    /// <summary>
    /// Custom Inputs define custom entry points in graph, it's similar to blueprint Custom Events
    /// Sub Graph node using this Flow Asset will generate context Input Pin for every valid Event name on this list
    /// </summary>
    protected System.Collections.Generic.IList<FName> CustomInputs
    {
        get
        {
            CustomInputs_Marshaller ??= new ArrayMarshaller<FName>(CustomInputs_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            return CustomInputs_Marshaller.FromNative(IntPtr.Add(NativeObject, CustomInputs_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int CustomOutputs_Offset;
    static IntPtr CustomOutputs_NativeProperty;
    ArrayMarshaller<FName> CustomOutputs_Marshaller = null;
    
    /// <summary>
    /// Custom Outputs define custom graph outputs, this allow to send signals to the parent graph while executing this graph
    /// Sub Graph node using this Flow Asset will generate context Output Pin for every valid Event name on this list
    /// </summary>
    protected System.Collections.Generic.IList<FName> CustomOutputs
    {
        get
        {
            CustomOutputs_Marshaller ??= new ArrayMarshaller<FName>(CustomOutputs_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            return CustomOutputs_Marshaller.FromNative(IntPtr.Add(NativeObject, CustomOutputs_Offset), 0);
        }
    }
    #endif
    
    
    static int ActiveInstances_Offset;
    static IntPtr ActiveInstances_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.UFlowAsset> ActiveInstances_Marshaller = null;
    
    /// <summary>
    /// Original object holds references to instances
    /// </summary>
    private System.Collections.Generic.IList<UnrealSharp.Flow.UFlowAsset> ActiveInstances
    {
        get
        {
            ActiveInstances_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.UFlowAsset>(ActiveInstances_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return ActiveInstances_Marshaller.FromNative(IntPtr.Add(NativeObject, ActiveInstances_Offset), 0);
        }
    }
    
    
    static int TemplateAsset_Offset;
    
    protected UnrealSharp.Flow.UFlowAsset TemplateAsset
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, TemplateAsset_Offset), 0);
        }
    }
    
    
    static int CustomInputNodes_Offset;
    static IntPtr CustomInputNodes_NativeProperty;
    SetMarshaller<UnrealSharp.Flow.UFlowNode_CustomInput> CustomInputNodes_Marshaller = null;
    
    /// <summary>
    /// Optional entry points to the graph, similar to blueprint Custom Events
    /// Contains nodes only if it is initialized instance (see InitializeInstance, IsInstanceInitialized), empty otherwise
    /// </summary>
    protected System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowNode_CustomInput> CustomInputNodes
    {
        get
        {
            CustomInputNodes_Marshaller ??= new SetMarshaller<UnrealSharp.Flow.UFlowNode_CustomInput>(CustomInputNodes_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode_CustomInput>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode_CustomInput>.FromNative);
            return CustomInputNodes_Marshaller.FromNative(IntPtr.Add(NativeObject, CustomInputNodes_Offset), 0);
        }
    }
    
    
    static int PreloadedNodes_Offset;
    static IntPtr PreloadedNodes_NativeProperty;
    SetMarshaller<UnrealSharp.Flow.UFlowNode> PreloadedNodes_Marshaller = null;
    
    protected System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowNode> PreloadedNodes
    {
        get
        {
            PreloadedNodes_Marshaller ??= new SetMarshaller<UnrealSharp.Flow.UFlowNode>(PreloadedNodes_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
            return PreloadedNodes_Marshaller.FromNative(IntPtr.Add(NativeObject, PreloadedNodes_Offset), 0);
        }
    }
    
    
    static int ExpectedOwnerClass_Offset;
    
    /// <summary>
    /// Expects to be owned (at runtime) by an object with this class (or one of its subclasses)
    /// NOTE - If the class is an AActor, and the flow asset is owned by a component,
    ///        it will consider the component's owner for the AActor
    /// </summary>
    protected TSubclassOf<UnrealSharp.CoreUObject.UObject> ExpectedOwnerClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(NativeObject, ExpectedOwnerClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(NativeObject, ExpectedOwnerClass_Offset), 0, value);
        }
    }
    
    
    // GetActiveNodes
    static IntPtr GetActiveNodes_NativeFunction;
    static int GetActiveNodes_ParamsSize;
    static int GetActiveNodes_ReturnValue_Offset;
    static IntPtr GetActiveNodes_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNode> GetActiveNodes_ReturnValue_Marshaller = null;
    static int ActiveNodes_Offset;
    static IntPtr ActiveNodes_NativeProperty;
    static int ActiveNodes_Size;
    ArrayMarshaller<UnrealSharp.Flow.UFlowNode> ActiveNodes_Marshaller = null;
    
    /// <summary>
    /// Nodes that have any work left, not marked as Finished yet
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNode> ActiveNodes
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetActiveNodes_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetActiveNodes_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetActiveNodes_NativeFunction, ParamsBuffer);
                
                System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNode> returnValue;
                GetActiveNodes_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNode>(GetActiveNodes_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
                IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetActiveNodes_ReturnValue_Offset);
                returnValue = GetActiveNodes_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
                GetActiveNodes_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetRecordedNodes
    static IntPtr GetRecordedNodes_NativeFunction;
    static int GetRecordedNodes_ParamsSize;
    static int GetRecordedNodes_ReturnValue_Offset;
    static IntPtr GetRecordedNodes_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNode> GetRecordedNodes_ReturnValue_Marshaller = null;
    static int RecordedNodes_Offset;
    static IntPtr RecordedNodes_NativeProperty;
    static int RecordedNodes_Size;
    ArrayMarshaller<UnrealSharp.Flow.UFlowNode> RecordedNodes_Marshaller = null;
    
    /// <summary>
    /// All nodes active in the past, done their work
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNode> RecordedNodes
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetRecordedNodes_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetRecordedNodes_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRecordedNodes_NativeFunction, ParamsBuffer);
                
                System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNode> returnValue;
                GetRecordedNodes_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNode>(GetRecordedNodes_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
                IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetRecordedNodes_ReturnValue_Offset);
                returnValue = GetRecordedNodes_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
                GetRecordedNodes_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetDefaultEntryNode
    static IntPtr GetDefaultEntryNode_NativeFunction;
    static int GetDefaultEntryNode_ParamsSize;
    static int GetDefaultEntryNode_ReturnValue_Offset;
    
    public UnrealSharp.Flow.UFlowNode DefaultEntryNode
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetDefaultEntryNode_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetDefaultEntryNode_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDefaultEntryNode_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowNode returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative(IntPtr.Add(ParamsBuffer, GetDefaultEntryNode_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetOwner
    static IntPtr GetOwner_NativeFunction;
    static int GetOwner_ParamsSize;
    static int GetOwner_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.UObject Owner
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetOwner_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetOwner_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOwner_NativeFunction, ParamsBuffer);
                
                UnrealSharp.CoreUObject.UObject returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, GetOwner_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    // GetNodesInExecutionOrder
    static IntPtr GetNodesInExecutionOrder_NativeFunction;
    static int GetNodesInExecutionOrder_ParamsSize;
    static int GetNodesInExecutionOrder_FirstIteratedNode_Offset;
    static int GetNodesInExecutionOrder_FlowNodeClass_Offset;
    static int GetNodesInExecutionOrder_ReturnValue_Offset;
    static IntPtr GetNodesInExecutionOrder_ReturnValue_NativeProperty;
    
    public System.Collections.Generic.IList<DOT> GetNodesInExecutionOrder<DOT>(UnrealSharp.Flow.UFlowNode firstIteratedNode)
        where DOT : UnrealSharp.Flow.UFlowNode
    {
        return GetNodesInExecutionOrder<DOT>(firstIteratedNode, typeof(DOT));
    }
    
    [UFunction, GeneratedType("GetNodesInExecutionOrder"), UMetaData("DeterminesOutputType", "FlowNodeClass")]
    public System.Collections.Generic.IList<DOT> GetNodesInExecutionOrder<DOT>(UnrealSharp.Flow.UFlowNode firstIteratedNode, TSubclassOf<DOT> flowNodeClass)
        where DOT : UnrealSharp.Flow.UFlowNode
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNodesInExecutionOrder_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetNodesInExecutionOrder_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative(IntPtr.Add(ParamsBuffer, GetNodesInExecutionOrder_FirstIteratedNode_Offset), 0, firstIteratedNode);
            SubclassOfMarshaller<DOT>.ToNative(IntPtr.Add(ParamsBuffer, GetNodesInExecutionOrder_FlowNodeClass_Offset), 0, flowNodeClass);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNodesInExecutionOrder_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<DOT> returnValue;
            var GetNodesInExecutionOrder_ReturnValue_Marshaller = new ArrayCopyMarshaller<DOT>(GetNodesInExecutionOrder_ReturnValue_NativeProperty, ObjectMarshaller<DOT>.ToNative, ObjectMarshaller<DOT>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetNodesInExecutionOrder_ReturnValue_Offset);
            returnValue = GetNodesInExecutionOrder_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GetNodesInExecutionOrder_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // TryFindActorOwner
    static IntPtr TryFindActorOwner_NativeFunction;
    static int TryFindActorOwner_ParamsSize;
    static int TryFindActorOwner_ReturnValue_Offset;
    
    /// <summary>
    /// Returns the Owner as an Actor, or if Owner is a Component, return its Owner as an Actor
    /// </summary>
    [UFunction, GeneratedType("TryFindActorOwner")]
    public UnrealSharp.Engine.AActor TryFindActorOwner()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryFindActorOwner_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryFindActorOwner_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryFindActorOwner_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.AActor returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative(IntPtr.Add(ParamsBuffer, TryFindActorOwner_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // IsActive
    static IntPtr IsActive_NativeFunction;
    static int IsActive_ParamsSize;
    static int IsActive_ReturnValue_Offset;
    
    /// <summary>
    /// Are there any active nodes?
    /// </summary>
    [UFunction, GeneratedType("IsActive")]
    public bool IsActive()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsActive_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(IsActive_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsActive_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsActive_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // SaveInstance
    static IntPtr SaveInstance_NativeFunction;
    static int SaveInstance_ParamsSize;
    static int SaveInstance_SavedFlowInstances_Offset;
    static IntPtr SaveInstance_SavedFlowInstances_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.FFlowAssetSaveData> SaveInstance_SavedFlowInstances_Marshaller = null;
    static int SaveInstance_ReturnValue_Offset;
    
    [UFunction, GeneratedType("SaveInstance")]
    public UnrealSharp.Flow.FFlowAssetSaveData SaveInstance(out System.Collections.Generic.IList<UnrealSharp.Flow.FFlowAssetSaveData> savedFlowInstances)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SaveInstance_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveInstance_NativeFunction, ParamsBuffer);
            
            SaveInstance_SavedFlowInstances_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>(SaveInstance_SavedFlowInstances_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.FromNative);
            IntPtr SavedFlowInstances_NativeBuffer = IntPtr.Add(ParamsBuffer, SaveInstance_SavedFlowInstances_Offset);
            savedFlowInstances = SaveInstance_SavedFlowInstances_Marshaller.FromNative(SavedFlowInstances_NativeBuffer, 0);
            SaveInstance_SavedFlowInstances_Marshaller.DestructInstance(SavedFlowInstances_NativeBuffer, 0);
            UnrealSharp.Flow.FFlowAssetSaveData returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.FromNative(IntPtr.Add(ParamsBuffer, SaveInstance_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // LoadInstance
    static IntPtr LoadInstance_NativeFunction;
    static int LoadInstance_ParamsSize;
    static int LoadInstance_AssetRecord_Offset;
    
    [UFunction, GeneratedType("LoadInstance")]
    public void LoadInstance(UnrealSharp.Flow.FFlowAssetSaveData assetRecord)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LoadInstance_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.ToNative(IntPtr.Add(ParamsBuffer, LoadInstance_AssetRecord_Offset), 0, assetRecord);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadInstance_NativeFunction, ParamsBuffer);
            
            
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
    
    // IsBoundToWorld
    IntPtr IsBoundToWorld_NativeFunction;
    static int IsBoundToWorld_ParamsSize;
    static int IsBoundToWorld_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("IsBoundToWorld")]
    public virtual bool IsBoundToWorld()
    {
        unsafe
        {
            if (IsBoundToWorld_NativeFunction == IntPtr.Zero)
            {
                IsBoundToWorld_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "IsBoundToWorld");
            }
            byte* ParamsBufferAllocation = stackalloc byte[IsBoundToWorld_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(IsBoundToWorld_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsBoundToWorld_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsBoundToWorld_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool IsBoundToWorld_Implementation()
    {
        return default(bool);
    }
    void Invoke_IsBoundToWorld(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = IsBoundToWorld_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    
}