using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// The base class for UFlowNode and UFlowNodeAddOn, with their shared functionality
/// </summary>
[UClass(ClassFlags.Abstract), GeneratedType("FlowNodeBase", "UnrealSharp.Flow.FlowNodeBase")]
public partial class UFlowNodeBase : UnrealSharp.CoreUObject.UObject, UnrealSharp.Flow.IFlowCoreExecutableInterface, UnrealSharp.Flow.IFlowContextPinSupplierInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNodeBase()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNodeBase");
        AddOns_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AddOns");
        AddOns_Offset = FPropertyExporter.CallGetPropertyOffset(AddOns_NativeProperty);
        IntPtr GraphNode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "GraphNode");
        GraphNode_Offset = FPropertyExporter.CallGetPropertyOffset(GraphNode_NativeProperty);
        #if WITH_EDITOR
        bDisplayNodeTitleWithoutPrefix_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bDisplayNodeTitleWithoutPrefix");
        IntPtr bDisplayNodeTitleWithoutPrefix_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisplayNodeTitleWithoutPrefix");
        bDisplayNodeTitleWithoutPrefix_Offset = FPropertyExporter.CallGetPropertyOffset(bDisplayNodeTitleWithoutPrefix_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr bNodeDeprecated_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bNodeDeprecated");
        bNodeDeprecated_Offset = FPropertyExporter.CallGetPropertyOffset(bNodeDeprecated_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr ReplacedBy_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ReplacedBy");
        ReplacedBy_Offset = FPropertyExporter.CallGetPropertyOffset(ReplacedBy_NativeProperty);
        #endif
        #if WITH_EDITOR
        Category_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Category");
        Category_Offset = FPropertyExporter.CallGetPropertyOffset(Category_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr NodeDisplayStyle_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDisplayStyle");
        NodeDisplayStyle_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDisplayStyle_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr NodeStyle_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeStyle");
        NodeStyle_Offset = FPropertyExporter.CallGetPropertyOffset(NodeStyle_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr NodeColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeColor");
        NodeColor_Offset = FPropertyExporter.CallGetPropertyOffset(NodeColor_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr DevNodeConfigText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DevNodeConfigText");
        DevNodeConfigText_Offset = FPropertyExporter.CallGetPropertyOffset(DevNodeConfigText_NativeProperty);
        #endif
        GetFlowAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowAsset");
        GetFlowAsset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowAsset_NativeFunction);
        GetFlowAsset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowAsset_NativeFunction, "ReturnValue");
        GetFlowSubsystem_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowSubsystem");
        GetFlowSubsystem_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowSubsystem_NativeFunction);
        GetFlowSubsystem_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowSubsystem_NativeFunction, "ReturnValue");
        Finish_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Finish");
        TriggerFirstOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TriggerFirstOutput");
        TriggerFirstOutput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TriggerFirstOutput_NativeFunction);
        TriggerFirstOutput_bFinish_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerFirstOutput_NativeFunction, "bFinish");
        TriggerOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TriggerOutput");
        TriggerOutput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TriggerOutput_NativeFunction);
        TriggerOutput_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutput_NativeFunction, "PinName");
        TriggerOutput_bFinish_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutput_NativeFunction, "bFinish");
        TriggerOutput_ActivationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutput_NativeFunction, "ActivationType");
        TriggerOutputPin_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TriggerOutputPin");
        TriggerOutputPin_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TriggerOutputPin_NativeFunction);
        TriggerOutputPin_Pin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutputPin_NativeFunction, "Pin");
        TriggerOutputPin_bFinish_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutputPin_NativeFunction, "bFinish");
        TriggerOutputPin_ActivationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TriggerOutputPin_NativeFunction, "ActivationType");
        TryGetRootFlowActorOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryGetRootFlowActorOwner");
        TryGetRootFlowActorOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryGetRootFlowActorOwner_NativeFunction);
        TryGetRootFlowActorOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryGetRootFlowActorOwner_NativeFunction, "ReturnValue");
        TryGetRootFlowObjectOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryGetRootFlowObjectOwner");
        TryGetRootFlowObjectOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryGetRootFlowObjectOwner_NativeFunction);
        TryGetRootFlowObjectOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryGetRootFlowObjectOwner_NativeFunction, "ReturnValue");
        TryResolveDataPinAsBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsBool");
        TryResolveDataPinAsBool_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsBool_NativeFunction);
        TryResolveDataPinAsBool_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsBool_NativeFunction, "PinName");
        TryResolveDataPinAsBool_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsBool_NativeFunction, "ReturnValue");
        TryResolveDataPinAsInt_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsInt");
        TryResolveDataPinAsInt_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsInt_NativeFunction);
        TryResolveDataPinAsInt_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsInt_NativeFunction, "PinName");
        TryResolveDataPinAsInt_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsInt_NativeFunction, "ReturnValue");
        TryResolveDataPinAsFloat_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsFloat");
        TryResolveDataPinAsFloat_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsFloat_NativeFunction);
        TryResolveDataPinAsFloat_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsFloat_NativeFunction, "PinName");
        TryResolveDataPinAsFloat_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsFloat_NativeFunction, "ReturnValue");
        TryResolveDataPinAsName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsName");
        TryResolveDataPinAsName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsName_NativeFunction);
        TryResolveDataPinAsName_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsName_NativeFunction, "PinName");
        TryResolveDataPinAsName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsName_NativeFunction, "ReturnValue");
        TryResolveDataPinAsString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsString");
        TryResolveDataPinAsString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsString_NativeFunction);
        TryResolveDataPinAsString_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsString_NativeFunction, "PinName");
        TryResolveDataPinAsString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsString_NativeFunction, "ReturnValue");
        TryResolveDataPinAsText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsText");
        TryResolveDataPinAsText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsText_NativeFunction);
        TryResolveDataPinAsText_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsText_NativeFunction, "PinName");
        TryResolveDataPinAsText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsText_NativeFunction, "ReturnValue");
        TryResolveDataPinAsEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsEnum");
        TryResolveDataPinAsEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsEnum_NativeFunction);
        TryResolveDataPinAsEnum_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsEnum_NativeFunction, "PinName");
        TryResolveDataPinAsEnum_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsEnum_NativeFunction, "ReturnValue");
        TryResolveDataPinAsVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsVector");
        TryResolveDataPinAsVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsVector_NativeFunction);
        TryResolveDataPinAsVector_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsVector_NativeFunction, "PinName");
        TryResolveDataPinAsVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsVector_NativeFunction, "ReturnValue");
        TryResolveDataPinAsRotator_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsRotator");
        TryResolveDataPinAsRotator_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsRotator_NativeFunction);
        TryResolveDataPinAsRotator_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsRotator_NativeFunction, "PinName");
        TryResolveDataPinAsRotator_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsRotator_NativeFunction, "ReturnValue");
        TryResolveDataPinAsTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsTransform");
        TryResolveDataPinAsTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsTransform_NativeFunction);
        TryResolveDataPinAsTransform_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsTransform_NativeFunction, "PinName");
        TryResolveDataPinAsTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsTransform_NativeFunction, "ReturnValue");
        TryResolveDataPinAsGameplayTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsGameplayTag");
        TryResolveDataPinAsGameplayTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsGameplayTag_NativeFunction);
        TryResolveDataPinAsGameplayTag_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsGameplayTag_NativeFunction, "PinName");
        TryResolveDataPinAsGameplayTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsGameplayTag_NativeFunction, "ReturnValue");
        TryResolveDataPinAsGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsGameplayTagContainer");
        TryResolveDataPinAsGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsGameplayTagContainer_NativeFunction);
        TryResolveDataPinAsGameplayTagContainer_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsGameplayTagContainer_NativeFunction, "PinName");
        TryResolveDataPinAsGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsGameplayTagContainer_NativeFunction, "ReturnValue");
        TryResolveDataPinAsInstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsInstancedStruct");
        TryResolveDataPinAsInstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsInstancedStruct_NativeFunction);
        TryResolveDataPinAsInstancedStruct_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsInstancedStruct_NativeFunction, "PinName");
        TryResolveDataPinAsInstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsInstancedStruct_NativeFunction, "ReturnValue");
        TryResolveDataPinAsObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsObject");
        TryResolveDataPinAsObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsObject_NativeFunction);
        TryResolveDataPinAsObject_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsObject_NativeFunction, "PinName");
        TryResolveDataPinAsObject_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsObject_NativeFunction, "ReturnValue");
        TryResolveDataPinAsClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TryResolveDataPinAsClass");
        TryResolveDataPinAsClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TryResolveDataPinAsClass_NativeFunction);
        TryResolveDataPinAsClass_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsClass_NativeFunction, "PinName");
        TryResolveDataPinAsClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TryResolveDataPinAsClass_NativeFunction, "ReturnValue");
        SetNodeConfigText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNodeConfigText");
        SetNodeConfigText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNodeConfigText_NativeFunction);
        SetNodeConfigText_NodeConfigText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNodeConfigText_NativeFunction, "NodeConfigText");
        LogError_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LogError");
        LogError_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LogError_NativeFunction);
        LogError_Message_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogError_NativeFunction, "Message");
        LogError_OnScreenMessageType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogError_NativeFunction, "OnScreenMessageType");
        LogWarning_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LogWarning");
        LogWarning_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LogWarning_NativeFunction);
        LogWarning_Message_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogWarning_NativeFunction, "Message");
        LogNote_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LogNote");
        LogNote_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LogNote_NativeFunction);
        LogNote_Message_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogNote_NativeFunction, "Message");
        LogVerbose_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LogVerbose");
        LogVerbose_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LogVerbose_NativeFunction);
        LogVerbose_Message_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LogVerbose_NativeFunction, "Message");
        IntPtr AcceptFlowNodeAddOnChild_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AcceptFlowNodeAddOnChild");
        AcceptFlowNodeAddOnChild_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AcceptFlowNodeAddOnChild_NativeFunction);
        AcceptFlowNodeAddOnChild_AddOnTemplate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnChild_NativeFunction, "AddOnTemplate");
        AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnChild_NativeFunction, "AdditionalAddOnsToAssumeAreChildren");
        AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(AcceptFlowNodeAddOnChild_NativeFunction, "AdditionalAddOnsToAssumeAreChildren");
        AcceptFlowNodeAddOnChild_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnChild_NativeFunction, "ReturnValue");
        IntPtr K2_GetStatusString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetStatusString");
        K2_GetStatusString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetStatusString_NativeFunction);
        K2_GetStatusString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetStatusString_NativeFunction, "ReturnValue");
        IntPtr K2_GetNodeDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetNodeDescription");
        K2_GetNodeDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetNodeDescription_NativeFunction);
        K2_GetNodeDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetNodeDescription_NativeFunction, "ReturnValue");
        IntPtr K2_ExecuteInput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_ExecuteInput");
        K2_ExecuteInput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_ExecuteInput_NativeFunction);
        K2_ExecuteInput_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_ExecuteInput_NativeFunction, "PinName");
        IntPtr K2_SupportsContextPins_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_SupportsContextPins");
        K2_SupportsContextPins_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_SupportsContextPins_NativeFunction);
        K2_SupportsContextPins_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_SupportsContextPins_NativeFunction, "ReturnValue");
        IntPtr K2_GetContextInputs_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetContextInputs");
        K2_GetContextInputs_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetContextInputs_NativeFunction);
        K2_GetContextInputs_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetContextInputs_NativeFunction, "ReturnValue");
        K2_GetContextInputs_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(K2_GetContextInputs_NativeFunction, "ReturnValue");
        IntPtr K2_GetContextOutputs_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetContextOutputs");
        K2_GetContextOutputs_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetContextOutputs_NativeFunction);
        K2_GetContextOutputs_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetContextOutputs_NativeFunction, "ReturnValue");
        K2_GetContextOutputs_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(K2_GetContextOutputs_NativeFunction, "ReturnValue");
    }
    
    static int AddOns_Offset;
    static IntPtr AddOns_NativeProperty;
    ArrayReadOnlyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn> AddOns_Marshaller = null;
    
    /// <summary>
    /// Flow Node AddOn attachments
    /// </summary>
    protected System.Collections.Generic.IReadOnlyList<UnrealSharp.Flow.UFlowNodeAddOn> AddOns
    {
        get
        {
            AddOns_Marshaller ??= new ArrayReadOnlyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>(AddOns_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative);
            return AddOns_Marshaller.FromNative(IntPtr.Add(NativeObject, AddOns_Offset), 0);
        }
    }
    
    
    static int GraphNode_Offset;
    
    /// <summary>
    /// Editor
    /// (some editor symbols exposed to enabled creation of non-editor tooling)
    /// </summary>
    public UnrealSharp.Engine.UEdGraphNode GraphNode
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.UEdGraphNode>.FromNative(IntPtr.Add(NativeObject, GraphNode_Offset), 0);
        }
    }
    
    
    #if WITH_EDITOR
    static byte bDisplayNodeTitleWithoutPrefix_FieldMask;
    static int bDisplayNodeTitleWithoutPrefix_Offset;
    
    protected bool DisplayNodeTitleWithoutPrefix
    {
        get
        {
            return BitfieldBoolMarshaller.FromNative(IntPtr.Add(NativeObject, bDisplayNodeTitleWithoutPrefix_Offset), bDisplayNodeTitleWithoutPrefix_FieldMask);
        }
        set
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(NativeObject, bDisplayNodeTitleWithoutPrefix_Offset), bDisplayNodeTitleWithoutPrefix_FieldMask, value);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int bNodeDeprecated_Offset;
    
    protected bool NodeDeprecated
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bNodeDeprecated_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bNodeDeprecated_Offset), 0, value);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int ReplacedBy_Offset;
    
    /// <summary>
    /// If this node is deprecated, it might be replaced by another node
    /// </summary>
    protected TSubclassOf<UnrealSharp.Flow.UFlowNode> ReplacedBy
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative(IntPtr.Add(NativeObject, ReplacedBy_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative(IntPtr.Add(NativeObject, ReplacedBy_Offset), 0, value);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int Category_Offset;
    static IntPtr Category_NativeProperty;
    
    protected string Category
    {
        get
        {
            IntPtr Category_NativePtr = IntPtr.Add(NativeObject,Category_Offset);
            return StringMarshaller.FromNative(Category_NativePtr,0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int NodeDisplayStyle_Offset;
    
    protected UnrealSharp.GameplayTags.FGameplayTag NodeDisplayStyle
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(NativeObject, NodeDisplayStyle_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(NativeObject, NodeDisplayStyle_Offset), 0, value);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int NodeStyle_Offset;
    
    /// <summary>
    /// Deprecated NodeStyle, replaced by NodeDisplayStyle
    /// </summary>
    protected UnrealSharp.Flow.EFlowNodeStyle NodeStyle
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowNodeStyle>.FromNative(IntPtr.Add(NativeObject, NodeStyle_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int NodeColor_Offset;
    
    /// <summary>
    /// Set Node Style to custom to use your own color for this node (if using Flow.NodeStyle.Custom)
    /// </summary>
    protected UnrealSharp.CoreUObject.FLinearColor CustomNodeColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, NodeColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, NodeColor_Offset), 0, value);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int DevNodeConfigText_Offset;
    
    /// <summary>
    /// Optional developer-facing text to explain the configuration of this node when viewed in the editor
    /// may be authored or set procedurally via UpdateNodeConfigText and SetNodeConfigText
    /// </summary>
    protected FText DevNodeConfigText
    {
        get
        {
            return TextMarshaller.FromNative(IntPtr.Add(NativeObject, DevNodeConfigText_Offset), 0);
        }
        set
        {
            TextMarshaller.ToNative(IntPtr.Add(NativeObject, DevNodeConfigText_Offset), 0, value);
        }
    }
    #endif
    
    
    // GetFlowAsset
    static IntPtr GetFlowAsset_NativeFunction;
    static int GetFlowAsset_ParamsSize;
    static int GetFlowAsset_ReturnValue_Offset;
    
    public UnrealSharp.Flow.UFlowAsset FlowAsset
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetFlowAsset_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetFlowAsset_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowAsset_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowAsset returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(ParamsBuffer, GetFlowAsset_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetFlowSubsystem
    static IntPtr GetFlowSubsystem_NativeFunction;
    static int GetFlowSubsystem_ParamsSize;
    static int GetFlowSubsystem_ReturnValue_Offset;
    
    public UnrealSharp.Flow.UFlowSubsystem FlowSubsystem
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetFlowSubsystem_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetFlowSubsystem_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowSubsystem_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowSubsystem returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowSubsystem>.FromNative(IntPtr.Add(ParamsBuffer, GetFlowSubsystem_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    // Finish
    static IntPtr Finish_NativeFunction;
    
    /// <summary>
    /// Finish execution of node, it will call Cleanup
    /// </summary>
    [UFunction, GeneratedType("Finish")]
    public void Finish()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Finish_NativeFunction, IntPtr.Zero);
        }
    }
    
    // TriggerFirstOutput
    static IntPtr TriggerFirstOutput_NativeFunction;
    static int TriggerFirstOutput_ParamsSize;
    static int TriggerFirstOutput_bFinish_Offset;
    
    /// <summary>
    /// Simply trigger the first Output Pin, convenient to use if node has only one output
    /// </summary>
    [UFunction, GeneratedType("TriggerFirstOutput")]
    public void TriggerFirstOutput(bool finish)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TriggerFirstOutput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TriggerFirstOutput_NativeFunction, ParamsBuffer);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, TriggerFirstOutput_bFinish_Offset), 0, finish);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TriggerFirstOutput_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // TriggerOutput
    static IntPtr TriggerOutput_NativeFunction;
    static int TriggerOutput_ParamsSize;
    static int TriggerOutput_PinName_Offset;
    static int TriggerOutput_bFinish_Offset;
    static int TriggerOutput_ActivationType_Offset;
    
    public void TriggerOutput(FName pinName, bool finish = false)
    {
        UnrealSharp.Flow.EFlowPinActivationType activationType = UnrealSharp.Flow.EFlowPinActivationType.Default;
        TriggerOutput(pinName, finish, activationType);
    }
    
    /// <summary>
    /// Cause a specific output to be triggered (by PinName)
    /// </summary>
    [UFunction, GeneratedType("TriggerOutput")]
    public void TriggerOutput(FName pinName, bool finish, UnrealSharp.Flow.EFlowPinActivationType activationType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TriggerOutput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TriggerOutput_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutput_PinName_Offset), 0, pinName);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutput_bFinish_Offset), 0, finish);
            EnumMarshaller<UnrealSharp.Flow.EFlowPinActivationType>.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutput_ActivationType_Offset), 0, activationType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TriggerOutput_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // TriggerOutputPin
    static IntPtr TriggerOutputPin_NativeFunction;
    static int TriggerOutputPin_ParamsSize;
    static int TriggerOutputPin_Pin_Offset;
    static int TriggerOutputPin_bFinish_Offset;
    static int TriggerOutputPin_ActivationType_Offset;
    
    public void TriggerOutputPin(UnrealSharp.Flow.FFlowOutputPinHandle pin, bool finish = false)
    {
        UnrealSharp.Flow.EFlowPinActivationType activationType = UnrealSharp.Flow.EFlowPinActivationType.Default;
        TriggerOutputPin(pin, finish, activationType);
    }
    
    /// <summary>
    /// Cause a specific output to be triggered (by PinHandle)
    /// </summary>
    [UFunction, GeneratedType("TriggerOutputPin")]
    public void TriggerOutputPin(UnrealSharp.Flow.FFlowOutputPinHandle pin, bool finish, UnrealSharp.Flow.EFlowPinActivationType activationType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TriggerOutputPin_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TriggerOutputPin_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowOutputPinHandle>.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutputPin_Pin_Offset), 0, pin);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutputPin_bFinish_Offset), 0, finish);
            EnumMarshaller<UnrealSharp.Flow.EFlowPinActivationType>.ToNative(IntPtr.Add(ParamsBuffer, TriggerOutputPin_ActivationType_Offset), 0, activationType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TriggerOutputPin_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // TryGetRootFlowActorOwner
    static IntPtr TryGetRootFlowActorOwner_NativeFunction;
    static int TryGetRootFlowActorOwner_ParamsSize;
    static int TryGetRootFlowActorOwner_ReturnValue_Offset;
    
    /// <summary>
    /// Gets the Owning Actor for this Node's RootFlow
    /// (if the immediate parent is an UActorComponent, it will get that Component's actor)
    /// </summary>
    [UFunction, GeneratedType("TryGetRootFlowActorOwner")]
    public UnrealSharp.Engine.AActor TryGetRootFlowActorOwner()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryGetRootFlowActorOwner_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryGetRootFlowActorOwner_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryGetRootFlowActorOwner_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.AActor returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative(IntPtr.Add(ParamsBuffer, TryGetRootFlowActorOwner_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryGetRootFlowObjectOwner
    static IntPtr TryGetRootFlowObjectOwner_NativeFunction;
    static int TryGetRootFlowObjectOwner_ParamsSize;
    static int TryGetRootFlowObjectOwner_ReturnValue_Offset;
    
    /// <summary>
    /// Gets the Owning Object for this Node's RootFlow
    /// </summary>
    [UFunction, GeneratedType("TryGetRootFlowObjectOwner")]
    public UnrealSharp.CoreUObject.UObject TryGetRootFlowObjectOwner()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryGetRootFlowObjectOwner_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryGetRootFlowObjectOwner_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryGetRootFlowObjectOwner_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.UObject returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, TryGetRootFlowObjectOwner_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsBool
    static IntPtr TryResolveDataPinAsBool_NativeFunction;
    static int TryResolveDataPinAsBool_ParamsSize;
    static int TryResolveDataPinAsBool_PinName_Offset;
    static int TryResolveDataPinAsBool_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsBool")]
    public UnrealSharp.Flow.FFlowDataPinResult_Bool TryResolveDataPinAsBool(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsBool_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsBool_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsBool_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsBool_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Bool returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Bool>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsBool_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsInt
    static IntPtr TryResolveDataPinAsInt_NativeFunction;
    static int TryResolveDataPinAsInt_ParamsSize;
    static int TryResolveDataPinAsInt_PinName_Offset;
    static int TryResolveDataPinAsInt_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsInt")]
    public UnrealSharp.Flow.FFlowDataPinResult_Int TryResolveDataPinAsInt(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsInt_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsInt_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsInt_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsInt_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Int returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsInt_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsFloat
    static IntPtr TryResolveDataPinAsFloat_NativeFunction;
    static int TryResolveDataPinAsFloat_ParamsSize;
    static int TryResolveDataPinAsFloat_PinName_Offset;
    static int TryResolveDataPinAsFloat_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsFloat")]
    public UnrealSharp.Flow.FFlowDataPinResult_Float TryResolveDataPinAsFloat(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsFloat_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsFloat_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsFloat_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsFloat_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Float returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Float>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsFloat_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsName
    static IntPtr TryResolveDataPinAsName_NativeFunction;
    static int TryResolveDataPinAsName_ParamsSize;
    static int TryResolveDataPinAsName_PinName_Offset;
    static int TryResolveDataPinAsName_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsName")]
    public UnrealSharp.Flow.FFlowDataPinResult_Name TryResolveDataPinAsName(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsName_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsName_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Name returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsString
    static IntPtr TryResolveDataPinAsString_NativeFunction;
    static int TryResolveDataPinAsString_ParamsSize;
    static int TryResolveDataPinAsString_PinName_Offset;
    static int TryResolveDataPinAsString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsString")]
    public UnrealSharp.Flow.FFlowDataPinResult_String TryResolveDataPinAsString(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsString_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsString_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsString_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_String returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsString_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsText
    static IntPtr TryResolveDataPinAsText_NativeFunction;
    static int TryResolveDataPinAsText_ParamsSize;
    static int TryResolveDataPinAsText_PinName_Offset;
    static int TryResolveDataPinAsText_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsText")]
    public UnrealSharp.Flow.FFlowDataPinResult_Text TryResolveDataPinAsText(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsText_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsText_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsText_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Text returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsEnum
    static IntPtr TryResolveDataPinAsEnum_NativeFunction;
    static int TryResolveDataPinAsEnum_ParamsSize;
    static int TryResolveDataPinAsEnum_PinName_Offset;
    static int TryResolveDataPinAsEnum_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsEnum")]
    public UnrealSharp.Flow.FFlowDataPinResult_Enum TryResolveDataPinAsEnum(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsEnum_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsEnum_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsEnum_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsEnum_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Enum returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Enum>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsEnum_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsVector
    static IntPtr TryResolveDataPinAsVector_NativeFunction;
    static int TryResolveDataPinAsVector_ParamsSize;
    static int TryResolveDataPinAsVector_PinName_Offset;
    static int TryResolveDataPinAsVector_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsVector")]
    public UnrealSharp.Flow.FFlowDataPinResult_Vector TryResolveDataPinAsVector(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsVector_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsVector_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsVector_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsVector_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Vector returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Vector>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsVector_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsRotator
    static IntPtr TryResolveDataPinAsRotator_NativeFunction;
    static int TryResolveDataPinAsRotator_ParamsSize;
    static int TryResolveDataPinAsRotator_PinName_Offset;
    static int TryResolveDataPinAsRotator_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsRotator")]
    public UnrealSharp.Flow.FFlowDataPinResult_Rotator TryResolveDataPinAsRotator(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsRotator_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsRotator_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsRotator_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsRotator_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Rotator returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Rotator>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsRotator_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsTransform
    static IntPtr TryResolveDataPinAsTransform_NativeFunction;
    static int TryResolveDataPinAsTransform_ParamsSize;
    static int TryResolveDataPinAsTransform_PinName_Offset;
    static int TryResolveDataPinAsTransform_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsTransform")]
    public UnrealSharp.Flow.FFlowDataPinResult_Transform TryResolveDataPinAsTransform(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsTransform_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsTransform_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsTransform_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsTransform_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Transform returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Transform>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsTransform_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsGameplayTag
    static IntPtr TryResolveDataPinAsGameplayTag_NativeFunction;
    static int TryResolveDataPinAsGameplayTag_ParamsSize;
    static int TryResolveDataPinAsGameplayTag_PinName_Offset;
    static int TryResolveDataPinAsGameplayTag_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsGameplayTag")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTag TryResolveDataPinAsGameplayTag(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsGameplayTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsGameplayTag_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsGameplayTag_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsGameplayTag_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTag returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTag>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsGameplayTag_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsGameplayTagContainer
    static IntPtr TryResolveDataPinAsGameplayTagContainer_NativeFunction;
    static int TryResolveDataPinAsGameplayTagContainer_ParamsSize;
    static int TryResolveDataPinAsGameplayTagContainer_PinName_Offset;
    static int TryResolveDataPinAsGameplayTagContainer_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsGameplayTagContainer")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer TryResolveDataPinAsGameplayTagContainer(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsGameplayTagContainer_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsGameplayTagContainer_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsInstancedStruct
    static IntPtr TryResolveDataPinAsInstancedStruct_NativeFunction;
    static int TryResolveDataPinAsInstancedStruct_ParamsSize;
    static int TryResolveDataPinAsInstancedStruct_PinName_Offset;
    static int TryResolveDataPinAsInstancedStruct_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsInstancedStruct")]
    public UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct TryResolveDataPinAsInstancedStruct(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsInstancedStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsInstancedStruct_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsInstancedStruct_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsInstancedStruct_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsInstancedStruct_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsObject
    static IntPtr TryResolveDataPinAsObject_NativeFunction;
    static int TryResolveDataPinAsObject_ParamsSize;
    static int TryResolveDataPinAsObject_PinName_Offset;
    static int TryResolveDataPinAsObject_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsObject")]
    public UnrealSharp.Flow.FFlowDataPinResult_Object TryResolveDataPinAsObject(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsObject_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsObject_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsObject_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsObject_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Object returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Object>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsObject_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // TryResolveDataPinAsClass
    static IntPtr TryResolveDataPinAsClass_NativeFunction;
    static int TryResolveDataPinAsClass_ParamsSize;
    static int TryResolveDataPinAsClass_PinName_Offset;
    static int TryResolveDataPinAsClass_ReturnValue_Offset;
    
    [UFunction, GeneratedType("TryResolveDataPinAsClass")]
    public UnrealSharp.Flow.FFlowDataPinResult_Class TryResolveDataPinAsClass(FName pinName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TryResolveDataPinAsClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TryResolveDataPinAsClass_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsClass_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TryResolveDataPinAsClass_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Class returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Class>.FromNative(IntPtr.Add(ParamsBuffer, TryResolveDataPinAsClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // SetNodeConfigText
    static IntPtr SetNodeConfigText_NativeFunction;
    static int SetNodeConfigText_ParamsSize;
    static int SetNodeConfigText_NodeConfigText_Offset;
    
    /// <summary>
    /// Set the editor-only Config Text
    /// (for displaying config info on the Node in the flow graph, ignored in non-editor builds)
    /// </summary>
    [UFunction, GeneratedType("SetNodeConfigText")]
    protected void SetNodeConfigText(FText nodeConfigText)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNodeConfigText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SetNodeConfigText_NativeFunction, ParamsBuffer);
            TextMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetNodeConfigText_NodeConfigText_Offset), 0, nodeConfigText);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNodeConfigText_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // LogError
    static IntPtr LogError_NativeFunction;
    static int LogError_ParamsSize;
    static int LogError_Message_Offset;
    static int LogError_OnScreenMessageType_Offset;
    
    protected void LogError(string message)
    {
        UnrealSharp.Flow.EFlowOnScreenMessageType onScreenMessageType = UnrealSharp.Flow.EFlowOnScreenMessageType.Permanent;
        LogError(message, onScreenMessageType);
    }
    
    [UFunction, GeneratedType("LogError")]
    protected void LogError(string message, UnrealSharp.Flow.EFlowOnScreenMessageType onScreenMessageType)
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
    
    // LogWarning
    static IntPtr LogWarning_NativeFunction;
    static int LogWarning_ParamsSize;
    static int LogWarning_Message_Offset;
    
    [UFunction, GeneratedType("LogWarning")]
    protected void LogWarning(string message)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LogWarning_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LogWarning_NativeFunction, ParamsBuffer);
            IntPtr Message_NativePtr = IntPtr.Add(ParamsBuffer, LogWarning_Message_Offset);
            StringMarshaller.ToNative(Message_NativePtr,0,message);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LogWarning_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Message_NativePtr, 0);
        }
    }
    
    // LogNote
    static IntPtr LogNote_NativeFunction;
    static int LogNote_ParamsSize;
    static int LogNote_Message_Offset;
    
    [UFunction, GeneratedType("LogNote")]
    protected void LogNote(string message)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LogNote_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LogNote_NativeFunction, ParamsBuffer);
            IntPtr Message_NativePtr = IntPtr.Add(ParamsBuffer, LogNote_Message_Offset);
            StringMarshaller.ToNative(Message_NativePtr,0,message);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LogNote_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Message_NativePtr, 0);
        }
    }
    
    // LogVerbose
    static IntPtr LogVerbose_NativeFunction;
    static int LogVerbose_ParamsSize;
    static int LogVerbose_Message_Offset;
    
    [UFunction, GeneratedType("LogVerbose")]
    protected void LogVerbose(string message)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LogVerbose_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LogVerbose_NativeFunction, ParamsBuffer);
            IntPtr Message_NativePtr = IntPtr.Add(ParamsBuffer, LogVerbose_Message_Offset);
            StringMarshaller.ToNative(Message_NativePtr,0,message);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LogVerbose_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Message_NativePtr, 0);
        }
    }
    
    // AcceptFlowNodeAddOnChild
    IntPtr AcceptFlowNodeAddOnChild_NativeFunction;
    static int AcceptFlowNodeAddOnChild_ParamsSize;
    static int AcceptFlowNodeAddOnChild_AddOnTemplate_Offset;
    static int AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Offset;
    static IntPtr AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn> AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Marshaller = null;
    static int AcceptFlowNodeAddOnChild_ReturnValue_Offset;
    
    /// <summary>
    /// FlowNodes and AddOns may determine which AddOns are eligible to be their children
    /// - AddOnTemplate - the template of the FlowNodeAddOn that is being considered to be added as a child
    /// - AdditionalAddOnsToAssumeAreChildren - other AddOns to assume that are already child AddOns for the purposes of checking is AddOnTemplate is allowed.
    ///   This list will be populated with the 'other' AddOns in a multi-paste operation in the editor,
    ///   because some paste-targets can only accept a certain mix of addons, so we must know the rest of the set being pasted
    ///   to make the correct decision about whether to allow AddOnTemplate to be added.
    /// https:forums.unrealengine.com/t/default-parameters-with-tarrays/330225 for details on AutoCreateRefTerm
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("AcceptFlowNodeAddOnChild")]
    protected virtual UnrealSharp.Flow.EFlowAddOnAcceptResult AcceptFlowNodeAddOnChild(UnrealSharp.Flow.UFlowNodeAddOn addOnTemplate, System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> additionalAddOnsToAssumeAreChildren)
    {
        unsafe
        {
            if (AcceptFlowNodeAddOnChild_NativeFunction == IntPtr.Zero)
            {
                AcceptFlowNodeAddOnChild_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "AcceptFlowNodeAddOnChild");
            }
            byte* ParamsBufferAllocation = stackalloc byte[AcceptFlowNodeAddOnChild_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AcceptFlowNodeAddOnChild_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative(IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnChild_AddOnTemplate_Offset), 0, addOnTemplate);
            AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>(AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative);
            IntPtr AdditionalAddOnsToAssumeAreChildren_NativeBuffer = IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Offset);
            AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Marshaller.ToNative(AdditionalAddOnsToAssumeAreChildren_NativeBuffer, 0, additionalAddOnsToAssumeAreChildren);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AcceptFlowNodeAddOnChild_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.EFlowAddOnAcceptResult returnValue;
            returnValue = EnumMarshaller<UnrealSharp.Flow.EFlowAddOnAcceptResult>.FromNative(IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnChild_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.EFlowAddOnAcceptResult AcceptFlowNodeAddOnChild_Implementation(UnrealSharp.Flow.UFlowNodeAddOn AddOnTemplate, System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> AdditionalAddOnsToAssumeAreChildren)
    {
        return default(UnrealSharp.Flow.EFlowAddOnAcceptResult);
    }
    void Invoke_AcceptFlowNodeAddOnChild(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Flow.UFlowNodeAddOn AddOnTemplate =  ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative(IntPtr.Add(buffer, AcceptFlowNodeAddOnChild_AddOnTemplate_Offset), 0);
            AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>(AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative);
            IntPtr AdditionalAddOnsToAssumeAreChildren_NativeBuffer = IntPtr.Add(buffer, AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Offset);
            System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> AdditionalAddOnsToAssumeAreChildren =  AcceptFlowNodeAddOnChild_AdditionalAddOnsToAssumeAreChildren_Marshaller.FromNative(AdditionalAddOnsToAssumeAreChildren_NativeBuffer, 0);
            UnrealSharp.Flow.EFlowAddOnAcceptResult returnValue = AcceptFlowNodeAddOnChild_Implementation(AddOnTemplate, AdditionalAddOnsToAssumeAreChildren);
            EnumMarshaller<UnrealSharp.Flow.EFlowAddOnAcceptResult>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // K2_GetStatusString
    IntPtr K2_GetStatusString_NativeFunction;
    static int K2_GetStatusString_ParamsSize;
    static int K2_GetStatusString_ReturnValue_Offset;
    
    /// <summary>
    /// Information displayed while node is working - displayed over node as NodeInfoPopup
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetStatusString")]
    protected virtual string GetStatusString()
    {
        unsafe
        {
            if (K2_GetStatusString_NativeFunction == IntPtr.Zero)
            {
                K2_GetStatusString_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetStatusString");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetStatusString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetStatusString_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetStatusString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,K2_GetStatusString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual string GetStatusString_Implementation()
    {
        return "";
    }
    void Invoke_K2_GetStatusString(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            string returnValue = GetStatusString_Implementation();
            IntPtr ReturnValue_NativePtr = IntPtr.Add(returnBuffer, 0);
            StringMarshaller.ToNative(ReturnValue_NativePtr,0,returnValue);
        }
    }
    
    // UpdateNodeConfigText
    IntPtr UpdateNodeConfigText_NativeFunction;
    
    /// <summary>
    /// Called whenever a property change event occurs on this flow node object,
    /// giving the implementor a chance to update their NodeConfigText (via SetNodeConfigText)
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("UpdateNodeConfigText")]
    protected virtual void UpdateNodeConfigText()
    {
        unsafe
        {
            if (UpdateNodeConfigText_NativeFunction == IntPtr.Zero)
            {
                UpdateNodeConfigText_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "UpdateNodeConfigText");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, UpdateNodeConfigText_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void UpdateNodeConfigText_Implementation()
    {
    }
    void Invoke_UpdateNodeConfigText(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UpdateNodeConfigText_Implementation();
        }
    }
    
    // K2_GetNodeDescription
    IntPtr K2_GetNodeDescription_NativeFunction;
    static int K2_GetNodeDescription_ParamsSize;
    static int K2_GetNodeDescription_ReturnValue_Offset;
    
    /// <summary>
    /// Short summary of node's content - displayed over node as NodeInfoPopup
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetNodeDescription")]
    protected virtual string GetNodeDescription()
    {
        unsafe
        {
            if (K2_GetNodeDescription_NativeFunction == IntPtr.Zero)
            {
                K2_GetNodeDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetNodeDescription");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetNodeDescription_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetNodeDescription_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetNodeDescription_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,K2_GetNodeDescription_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual string GetNodeDescription_Implementation()
    {
        return "";
    }
    void Invoke_K2_GetNodeDescription(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            string returnValue = GetNodeDescription_Implementation();
            IntPtr ReturnValue_NativePtr = IntPtr.Add(returnBuffer, 0);
            StringMarshaller.ToNative(ReturnValue_NativePtr,0,returnValue);
        }
    }
    
    // K2_InitializeInstance
    IntPtr K2_InitializeInstance_NativeFunction;
    
    /// <summary>
    /// Method called just after creating the node instance, while initializing the Flow Asset instance
    /// This happens before executing graph, only called during gameplay
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_InitializeInstance")]
    public void InitializeInstance()
    {
        unsafe
        {
            if (K2_InitializeInstance_NativeFunction == IntPtr.Zero)
            {
                K2_InitializeInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_InitializeInstance");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_InitializeInstance_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void InitializeInstance_Implementation()
    {
    }
    void Invoke_K2_InitializeInstance(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            InitializeInstance_Implementation();
        }
    }
    
    // K2_DeinitializeInstance
    IntPtr K2_DeinitializeInstance_NativeFunction;
    
    /// <summary>
    /// Event called from UMKTFlowNode::DeinitializeInstance()
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_DeinitializeInstance")]
    public void DeinitializeInstance()
    {
        unsafe
        {
            if (K2_DeinitializeInstance_NativeFunction == IntPtr.Zero)
            {
                K2_DeinitializeInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_DeinitializeInstance");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_DeinitializeInstance_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void DeinitializeInstance_Implementation()
    {
    }
    void Invoke_K2_DeinitializeInstance(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            DeinitializeInstance_Implementation();
        }
    }
    
    // K2_PreloadContent
    IntPtr K2_PreloadContent_NativeFunction;
    
    /// <summary>
    /// If preloading is enabled, will be called to preload content
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_PreloadContent")]
    public void PreloadContent()
    {
        unsafe
        {
            if (K2_PreloadContent_NativeFunction == IntPtr.Zero)
            {
                K2_PreloadContent_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_PreloadContent");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_PreloadContent_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void PreloadContent_Implementation()
    {
    }
    void Invoke_K2_PreloadContent(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            PreloadContent_Implementation();
        }
    }
    
    // K2_FlushContent
    IntPtr K2_FlushContent_NativeFunction;
    
    /// <summary>
    /// If preloading is enabled, will be called to flush content
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_FlushContent")]
    public void FlushContent()
    {
        unsafe
        {
            if (K2_FlushContent_NativeFunction == IntPtr.Zero)
            {
                K2_FlushContent_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_FlushContent");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_FlushContent_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void FlushContent_Implementation()
    {
    }
    void Invoke_K2_FlushContent(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FlushContent_Implementation();
        }
    }
    
    // K2_OnActivate
    IntPtr K2_OnActivate_NativeFunction;
    
    /// <summary>
    /// Called immediately before the first input is triggered
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_OnActivate")]
    public void OnActivate()
    {
        unsafe
        {
            if (K2_OnActivate_NativeFunction == IntPtr.Zero)
            {
                K2_OnActivate_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_OnActivate");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_OnActivate_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnActivate_Implementation()
    {
    }
    void Invoke_K2_OnActivate(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnActivate_Implementation();
        }
    }
    
    // K2_Cleanup
    IntPtr K2_Cleanup_NativeFunction;
    
    /// <summary>
    /// Event called after node finished the work
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_Cleanup")]
    public void Cleanup()
    {
        unsafe
        {
            if (K2_Cleanup_NativeFunction == IntPtr.Zero)
            {
                K2_Cleanup_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Cleanup");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Cleanup_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void Cleanup_Implementation()
    {
    }
    void Invoke_K2_Cleanup(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            Cleanup_Implementation();
        }
    }
    
    // K2_ForceFinishNode
    IntPtr K2_ForceFinishNode_NativeFunction;
    
    /// <summary>
    /// Define what happens when node is terminated from the outside
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_ForceFinishNode")]
    public void ForceFinishNode()
    {
        unsafe
        {
            if (K2_ForceFinishNode_NativeFunction == IntPtr.Zero)
            {
                K2_ForceFinishNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_ForceFinishNode");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_ForceFinishNode_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ForceFinishNode_Implementation()
    {
    }
    void Invoke_K2_ForceFinishNode(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            ForceFinishNode_Implementation();
        }
    }
    
    // K2_ExecuteInput
    IntPtr K2_ExecuteInput_NativeFunction;
    static int K2_ExecuteInput_ParamsSize;
    static int K2_ExecuteInput_PinName_Offset;
    
    /// <summary>
    /// Event reacting on triggering Input pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_ExecuteInput")]
    public void ExecuteInput(FName pinName)
    {
        unsafe
        {
            if (K2_ExecuteInput_NativeFunction == IntPtr.Zero)
            {
                K2_ExecuteInput_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_ExecuteInput");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_ExecuteInput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_ExecuteInput_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, K2_ExecuteInput_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_ExecuteInput_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ExecuteInput_Implementation(FName PinName)
    {
    }
    void Invoke_K2_ExecuteInput(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, K2_ExecuteInput_PinName_Offset), 0);
            ExecuteInput_Implementation(PinName);
        }
    }
    
    // K2_SupportsContextPins
    IntPtr K2_SupportsContextPins_NativeFunction;
    static int K2_SupportsContextPins_ParamsSize;
    static int K2_SupportsContextPins_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_SupportsContextPins")]
    public bool SupportsContextPins()
    {
        unsafe
        {
            if (K2_SupportsContextPins_NativeFunction == IntPtr.Zero)
            {
                K2_SupportsContextPins_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_SupportsContextPins");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_SupportsContextPins_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_SupportsContextPins_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_SupportsContextPins_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_SupportsContextPins_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool SupportsContextPins_Implementation()
    {
        return default(bool);
    }
    void Invoke_K2_SupportsContextPins(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = SupportsContextPins_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // K2_GetContextInputs
    IntPtr K2_GetContextInputs_NativeFunction;
    static int K2_GetContextInputs_ParamsSize;
    static int K2_GetContextInputs_ReturnValue_Offset;
    static IntPtr K2_GetContextInputs_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin> K2_GetContextInputs_ReturnValue_Marshaller = null;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetContextInputs")]
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextInputs()
    {
        unsafe
        {
            if (K2_GetContextInputs_NativeFunction == IntPtr.Zero)
            {
                K2_GetContextInputs_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetContextInputs");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetContextInputs_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetContextInputs_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetContextInputs_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> returnValue;
            K2_GetContextInputs_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin>(K2_GetContextInputs_ReturnValue_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, K2_GetContextInputs_ReturnValue_Offset);
            returnValue = K2_GetContextInputs_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            K2_GetContextInputs_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextInputs_Implementation()
    {
        return null;
    }
    void Invoke_K2_GetContextInputs(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> returnValue = GetContextInputs_Implementation();
            K2_GetContextInputs_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin>(K2_GetContextInputs_ReturnValue_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(returnBuffer, 0);
            K2_GetContextInputs_ReturnValue_Marshaller.ToNative(ReturnValue_NativeBuffer, 0, returnValue);
        }
    }
    
    // K2_GetContextOutputs
    IntPtr K2_GetContextOutputs_NativeFunction;
    static int K2_GetContextOutputs_ParamsSize;
    static int K2_GetContextOutputs_ReturnValue_Offset;
    static IntPtr K2_GetContextOutputs_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin> K2_GetContextOutputs_ReturnValue_Marshaller = null;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetContextOutputs")]
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextOutputs()
    {
        unsafe
        {
            if (K2_GetContextOutputs_NativeFunction == IntPtr.Zero)
            {
                K2_GetContextOutputs_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetContextOutputs");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetContextOutputs_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetContextOutputs_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetContextOutputs_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> returnValue;
            K2_GetContextOutputs_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin>(K2_GetContextOutputs_ReturnValue_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, K2_GetContextOutputs_ReturnValue_Offset);
            returnValue = K2_GetContextOutputs_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            K2_GetContextOutputs_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> GetContextOutputs_Implementation()
    {
        return null;
    }
    void Invoke_K2_GetContextOutputs(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> returnValue = GetContextOutputs_Implementation();
            K2_GetContextOutputs_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowPin>(K2_GetContextOutputs_ReturnValue_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(returnBuffer, 0);
            K2_GetContextOutputs_ReturnValue_Marshaller.ToNative(ReturnValue_NativeBuffer, 0, returnValue);
        }
    }
    
    
}