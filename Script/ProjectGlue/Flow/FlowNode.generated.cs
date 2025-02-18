using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// A Flow Node is UObject-based node designed to handle entire gameplay feature within single node.
/// </summary>
[UClass(ClassFlags.Abstract), GeneratedType("FlowNode", "UnrealSharp.Flow.FlowNode")]
public partial class UFlowNode : UnrealSharp.Flow.UFlowNodeBase, UnrealSharp.Flow.IFlowDataPinValueSupplierInterface, UnrealSharp.Engine.IVisualLoggerDebugSnapshotInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode");
        #if WITH_EDITOR
        AllowedAssetClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AllowedAssetClasses");
        AllowedAssetClasses_Offset = FPropertyExporter.CallGetPropertyOffset(AllowedAssetClasses_NativeProperty);
        #endif
        #if WITH_EDITOR
        DeniedAssetClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DeniedAssetClasses");
        DeniedAssetClasses_Offset = FPropertyExporter.CallGetPropertyOffset(DeniedAssetClasses_NativeProperty);
        #endif
        IntPtr NodeGuid_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeGuid");
        NodeGuid_Offset = FPropertyExporter.CallGetPropertyOffset(NodeGuid_NativeProperty);
        AllowedSignalModes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AllowedSignalModes");
        AllowedSignalModes_Offset = FPropertyExporter.CallGetPropertyOffset(AllowedSignalModes_NativeProperty);
        IntPtr SignalMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SignalMode");
        SignalMode_Offset = FPropertyExporter.CallGetPropertyOffset(SignalMode_NativeProperty);
        InputPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InputPins");
        InputPins_Offset = FPropertyExporter.CallGetPropertyOffset(InputPins_NativeProperty);
        OutputPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OutputPins");
        OutputPins_Offset = FPropertyExporter.CallGetPropertyOffset(OutputPins_NativeProperty);
        Connections_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Connections");
        Connections_Offset = FPropertyExporter.CallGetPropertyOffset(Connections_NativeProperty);
        PinNameToBoundPropertyNameMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinNameToBoundPropertyNameMap");
        PinNameToBoundPropertyNameMap_Offset = FPropertyExporter.CallGetPropertyOffset(PinNameToBoundPropertyNameMap_NativeProperty);
        #if WITH_EDITOR
        AutoInputDataPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AutoInputDataPins");
        AutoInputDataPins_Offset = FPropertyExporter.CallGetPropertyOffset(AutoInputDataPins_NativeProperty);
        #endif
        #if WITH_EDITOR
        AutoOutputDataPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AutoOutputDataPins");
        AutoOutputDataPins_Offset = FPropertyExporter.CallGetPropertyOffset(AutoOutputDataPins_NativeProperty);
        #endif
        IntPtr ActivationState_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActivationState");
        ActivationState_Offset = FPropertyExporter.CallGetPropertyOffset(ActivationState_NativeProperty);
        GetGuid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetGuid");
        GetGuid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetGuid_NativeFunction);
        GetGuid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetGuid_NativeFunction, "ReturnValue");
        GetInputNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInputNames");
        GetInputNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInputNames_NativeFunction);
        GetInputNames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInputNames_NativeFunction, "ReturnValue");
        GetInputNames_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetInputNames_NativeFunction, "ReturnValue");
        GetOutputNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOutputNames");
        GetOutputNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOutputNames_NativeFunction);
        GetOutputNames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOutputNames_NativeFunction, "ReturnValue");
        GetOutputNames_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GetOutputNames_NativeFunction, "ReturnValue");
        SetGuid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetGuid");
        SetGuid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetGuid_NativeFunction);
        SetGuid_NewGuid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetGuid_NativeFunction, "NewGuid");
        GatherConnectedNodes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GatherConnectedNodes");
        GatherConnectedNodes_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GatherConnectedNodes_NativeFunction);
        GatherConnectedNodes_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GatherConnectedNodes_NativeFunction, "ReturnValue");
        GatherConnectedNodes_ReturnValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(GatherConnectedNodes_NativeFunction, "ReturnValue");
        IsInputConnected_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsInputConnected");
        IsInputConnected_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsInputConnected_NativeFunction);
        IsInputConnected_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInputConnected_NativeFunction, "PinName");
        IsInputConnected_bErrorIfPinNotFound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInputConnected_NativeFunction, "bErrorIfPinNotFound");
        IsInputConnected_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInputConnected_NativeFunction, "ReturnValue");
        IsOutputConnected_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsOutputConnected");
        IsOutputConnected_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsOutputConnected_NativeFunction);
        IsOutputConnected_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOutputConnected_NativeFunction, "PinName");
        IsOutputConnected_bErrorIfPinNotFound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOutputConnected_NativeFunction, "bErrorIfPinNotFound");
        IsOutputConnected_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOutputConnected_NativeFunction, "ReturnValue");
        SaveInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveInstance");
        SaveInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveInstance_NativeFunction);
        SaveInstance_NodeRecord_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveInstance_NativeFunction, "NodeRecord");
        LoadInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadInstance");
        LoadInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadInstance_NativeFunction);
        LoadInstance_NodeRecord_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadInstance_NativeFunction, "NodeRecord");
        GetIdentityTagDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetIdentityTagDescription");
        GetIdentityTagDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetIdentityTagDescription_NativeFunction);
        GetIdentityTagDescription_Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIdentityTagDescription_NativeFunction, "Tag");
        GetIdentityTagDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIdentityTagDescription_NativeFunction, "ReturnValue");
        GetIdentityTagsDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetIdentityTagsDescription");
        GetIdentityTagsDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetIdentityTagsDescription_NativeFunction);
        GetIdentityTagsDescription_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIdentityTagsDescription_NativeFunction, "Tags");
        GetIdentityTagsDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIdentityTagsDescription_NativeFunction, "ReturnValue");
        GetNotifyTagsDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNotifyTagsDescription");
        GetNotifyTagsDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNotifyTagsDescription_NativeFunction);
        GetNotifyTagsDescription_Tags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNotifyTagsDescription_NativeFunction, "Tags");
        GetNotifyTagsDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNotifyTagsDescription_NativeFunction, "ReturnValue");
        GetClassDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetClassDescription");
        GetClassDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetClassDescription_NativeFunction);
        GetClassDescription_Class_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetClassDescription_NativeFunction, "Class");
        GetClassDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetClassDescription_NativeFunction, "ReturnValue");
        GetProgressAsString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetProgressAsString");
        GetProgressAsString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetProgressAsString_NativeFunction);
        GetProgressAsString_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetProgressAsString_NativeFunction, "Value");
        GetProgressAsString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetProgressAsString_NativeFunction, "ReturnValue");
        IntPtr K2_CanUserAddInput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_CanUserAddInput");
        K2_CanUserAddInput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_CanUserAddInput_NativeFunction);
        K2_CanUserAddInput_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_CanUserAddInput_NativeFunction, "ReturnValue");
        IntPtr K2_CanUserAddOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_CanUserAddOutput");
        K2_CanUserAddOutput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_CanUserAddOutput_NativeFunction);
        K2_CanUserAddOutput_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_CanUserAddOutput_NativeFunction, "ReturnValue");
        IntPtr K2_GetStatusBackgroundColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetStatusBackgroundColor");
        K2_GetStatusBackgroundColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetStatusBackgroundColor_NativeFunction);
        K2_GetStatusBackgroundColor_OutColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetStatusBackgroundColor_NativeFunction, "OutColor");
        K2_GetStatusBackgroundColor_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetStatusBackgroundColor_NativeFunction, "ReturnValue");
        IntPtr K2_GetAssetPath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetAssetPath");
        K2_GetAssetPath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetAssetPath_NativeFunction);
        K2_GetAssetPath_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetAssetPath_NativeFunction, "ReturnValue");
        IntPtr K2_GetAssetToEdit_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetAssetToEdit");
        K2_GetAssetToEdit_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetAssetToEdit_NativeFunction);
        K2_GetAssetToEdit_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetAssetToEdit_NativeFunction, "ReturnValue");
        IntPtr K2_GetActorToFocus_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetActorToFocus");
        K2_GetActorToFocus_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetActorToFocus_NativeFunction);
        K2_GetActorToFocus_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetActorToFocus_NativeFunction, "ReturnValue");
        IntPtr CanSupplyDataPinValues_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CanSupplyDataPinValues");
        CanSupplyDataPinValues_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CanSupplyDataPinValues_NativeFunction);
        CanSupplyDataPinValues_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanSupplyDataPinValues_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsBool");
        TrySupplyDataPinAsBool_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsBool_NativeFunction);
        TrySupplyDataPinAsBool_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsBool_NativeFunction, "PinName");
        TrySupplyDataPinAsBool_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsBool_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsInt_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsInt");
        TrySupplyDataPinAsInt_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsInt_NativeFunction);
        TrySupplyDataPinAsInt_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsInt_NativeFunction, "PinName");
        TrySupplyDataPinAsInt_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsInt_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsFloat_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsFloat");
        TrySupplyDataPinAsFloat_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsFloat_NativeFunction);
        TrySupplyDataPinAsFloat_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsFloat_NativeFunction, "PinName");
        TrySupplyDataPinAsFloat_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsFloat_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsName");
        TrySupplyDataPinAsName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsName_NativeFunction);
        TrySupplyDataPinAsName_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsName_NativeFunction, "PinName");
        TrySupplyDataPinAsName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsName_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsString");
        TrySupplyDataPinAsString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsString_NativeFunction);
        TrySupplyDataPinAsString_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsString_NativeFunction, "PinName");
        TrySupplyDataPinAsString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsString_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsText");
        TrySupplyDataPinAsText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsText_NativeFunction);
        TrySupplyDataPinAsText_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsText_NativeFunction, "PinName");
        TrySupplyDataPinAsText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsText_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsEnum");
        TrySupplyDataPinAsEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsEnum_NativeFunction);
        TrySupplyDataPinAsEnum_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsEnum_NativeFunction, "PinName");
        TrySupplyDataPinAsEnum_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsEnum_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsVector");
        TrySupplyDataPinAsVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsVector_NativeFunction);
        TrySupplyDataPinAsVector_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsVector_NativeFunction, "PinName");
        TrySupplyDataPinAsVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsVector_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsRotator_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsRotator");
        TrySupplyDataPinAsRotator_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsRotator_NativeFunction);
        TrySupplyDataPinAsRotator_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsRotator_NativeFunction, "PinName");
        TrySupplyDataPinAsRotator_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsRotator_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsTransform");
        TrySupplyDataPinAsTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsTransform_NativeFunction);
        TrySupplyDataPinAsTransform_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsTransform_NativeFunction, "PinName");
        TrySupplyDataPinAsTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsTransform_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsGameplayTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsGameplayTag");
        TrySupplyDataPinAsGameplayTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsGameplayTag_NativeFunction);
        TrySupplyDataPinAsGameplayTag_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsGameplayTag_NativeFunction, "PinName");
        TrySupplyDataPinAsGameplayTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsGameplayTag_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsGameplayTagContainer");
        TrySupplyDataPinAsGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsGameplayTagContainer_NativeFunction);
        TrySupplyDataPinAsGameplayTagContainer_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsGameplayTagContainer_NativeFunction, "PinName");
        TrySupplyDataPinAsGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsGameplayTagContainer_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsInstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsInstancedStruct");
        TrySupplyDataPinAsInstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsInstancedStruct_NativeFunction);
        TrySupplyDataPinAsInstancedStruct_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsInstancedStruct_NativeFunction, "PinName");
        TrySupplyDataPinAsInstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsInstancedStruct_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsObject");
        TrySupplyDataPinAsObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsObject_NativeFunction);
        TrySupplyDataPinAsObject_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsObject_NativeFunction, "PinName");
        TrySupplyDataPinAsObject_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsObject_NativeFunction, "ReturnValue");
        IntPtr TrySupplyDataPinAsClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TrySupplyDataPinAsClass");
        TrySupplyDataPinAsClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TrySupplyDataPinAsClass_NativeFunction);
        TrySupplyDataPinAsClass_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsClass_NativeFunction, "PinName");
        TrySupplyDataPinAsClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TrySupplyDataPinAsClass_NativeFunction, "ReturnValue");
    }
    
    #if WITH_EDITOR
    static int AllowedAssetClasses_Offset;
    static IntPtr AllowedAssetClasses_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> AllowedAssetClasses_Marshaller = null;
    
    protected System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> AllowedAssetClasses
    {
        get
        {
            AllowedAssetClasses_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>>(AllowedAssetClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return AllowedAssetClasses_Marshaller.FromNative(IntPtr.Add(NativeObject, AllowedAssetClasses_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int DeniedAssetClasses_Offset;
    static IntPtr DeniedAssetClasses_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> DeniedAssetClasses_Marshaller = null;
    
    protected System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> DeniedAssetClasses
    {
        get
        {
            DeniedAssetClasses_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>>(DeniedAssetClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return DeniedAssetClasses_Marshaller.FromNative(IntPtr.Add(NativeObject, DeniedAssetClasses_Offset), 0);
        }
    }
    #endif
    
    
    static int NodeGuid_Offset;
    
    /// <summary>
    /// Inherits Guid after graph node
    /// </summary>
    public UnrealSharp.CoreUObject.FGuid NodeGuid
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative(IntPtr.Add(NativeObject, NodeGuid_Offset), 0);
        }
    }
    
    
    static int AllowedSignalModes_Offset;
    static IntPtr AllowedSignalModes_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.EFlowSignalMode> AllowedSignalModes_Marshaller = null;
    
    protected System.Collections.Generic.IList<UnrealSharp.Flow.EFlowSignalMode> AllowedSignalModes
    {
        get
        {
            AllowedSignalModes_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.EFlowSignalMode>(AllowedSignalModes_NativeProperty, EnumMarshaller<UnrealSharp.Flow.EFlowSignalMode>.ToNative, EnumMarshaller<UnrealSharp.Flow.EFlowSignalMode>.FromNative);
            return AllowedSignalModes_Marshaller.FromNative(IntPtr.Add(NativeObject, AllowedSignalModes_Offset), 0);
        }
    }
    
    
    static int SignalMode_Offset;
    
    /// <summary>
    /// If enabled, signal will pass through node without calling ExecuteInput()
    /// Designed to handle patching
    /// </summary>
    protected UnrealSharp.Flow.EFlowSignalMode SignalMode
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowSignalMode>.FromNative(IntPtr.Add(NativeObject, SignalMode_Offset), 0);
        }
    }
    
    
    static int InputPins_Offset;
    static IntPtr InputPins_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowPin> InputPins_Marshaller = null;
    
    /// <summary>
    /// Class-specific and user-added inputs
    /// </summary>
    protected System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> InputPins
    {
        get
        {
            InputPins_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowPin>(InputPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return InputPins_Marshaller.FromNative(IntPtr.Add(NativeObject, InputPins_Offset), 0);
        }
    }
    
    
    static int OutputPins_Offset;
    static IntPtr OutputPins_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowPin> OutputPins_Marshaller = null;
    
    /// <summary>
    /// Class-specific and user-added outputs
    /// </summary>
    protected System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> OutputPins
    {
        get
        {
            OutputPins_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowPin>(OutputPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return OutputPins_Marshaller.FromNative(IntPtr.Add(NativeObject, OutputPins_Offset), 0);
        }
    }
    
    
    static int Connections_Offset;
    static IntPtr Connections_NativeProperty;
    MapMarshaller<FName, UnrealSharp.Flow.FConnectedPin> Connections_Marshaller = null;
    
    /// <summary>
    /// Map input/outputs to the connected node and input pin
    /// </summary>
    protected System.Collections.Generic.IDictionary<FName, UnrealSharp.Flow.FConnectedPin> Connections
    {
        get
        {
            Connections_Marshaller ??= new MapMarshaller<FName, UnrealSharp.Flow.FConnectedPin>(Connections_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, StructMarshaller<UnrealSharp.Flow.FConnectedPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FConnectedPin>.FromNative);
            return Connections_Marshaller.FromNative(IntPtr.Add(NativeObject, Connections_Offset), 0);
        }
    }
    
    
    static int PinNameToBoundPropertyNameMap_Offset;
    static IntPtr PinNameToBoundPropertyNameMap_NativeProperty;
    MapMarshaller<FName, FName> PinNameToBoundPropertyNameMap_Marshaller = null;
    
    /// <summary>
    /// Map of DataPin Name to its Bound Property,
    /// when using metadata tag 'BindOutputFlowDataPin' to bind properties to data pins for automatic supplier support
    /// </summary>
    public System.Collections.Generic.IDictionary<FName, FName> PinNameToBoundPropertyNameMap
    {
        get
        {
            PinNameToBoundPropertyNameMap_Marshaller ??= new MapMarshaller<FName, FName>(PinNameToBoundPropertyNameMap_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            return PinNameToBoundPropertyNameMap_Marshaller.FromNative(IntPtr.Add(NativeObject, PinNameToBoundPropertyNameMap_Offset), 0);
        }
    }
    
    
    #if WITH_EDITOR
    static int AutoInputDataPins_Offset;
    static IntPtr AutoInputDataPins_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowPin> AutoInputDataPins_Marshaller = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> AutoInputDataPins
    {
        get
        {
            AutoInputDataPins_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowPin>(AutoInputDataPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return AutoInputDataPins_Marshaller.FromNative(IntPtr.Add(NativeObject, AutoInputDataPins_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int AutoOutputDataPins_Offset;
    static IntPtr AutoOutputDataPins_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowPin> AutoOutputDataPins_Marshaller = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowPin> AutoOutputDataPins
    {
        get
        {
            AutoOutputDataPins_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowPin>(AutoOutputDataPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return AutoOutputDataPins_Marshaller.FromNative(IntPtr.Add(NativeObject, AutoOutputDataPins_Offset), 0);
        }
    }
    #endif
    
    
    static int ActivationState_Offset;
    
    protected UnrealSharp.Flow.EFlowNodeState ActivationState
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowNodeState>.FromNative(IntPtr.Add(NativeObject, ActivationState_Offset), 0);
        }
    }
    
    
    // GetGuid
    static IntPtr GetGuid_NativeFunction;
    static int GetGuid_ParamsSize;
    static int GetGuid_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.FGuid Guid
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetGuid_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetGuid_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetGuid_NativeFunction, ParamsBuffer);
                
                UnrealSharp.CoreUObject.FGuid returnValue;
                returnValue = StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative(IntPtr.Add(ParamsBuffer, GetGuid_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetInputNames
    static IntPtr GetInputNames_NativeFunction;
    static int GetInputNames_ParamsSize;
    static int GetInputNames_ReturnValue_Offset;
    static IntPtr GetInputNames_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<FName> GetInputNames_ReturnValue_Marshaller = null;
    
    public System.Collections.Generic.IList<FName> InputNames
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetInputNames_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetInputNames_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInputNames_NativeFunction, ParamsBuffer);
                
                System.Collections.Generic.IList<FName> returnValue;
                GetInputNames_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<FName>(GetInputNames_ReturnValue_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
                IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetInputNames_ReturnValue_Offset);
                returnValue = GetInputNames_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
                GetInputNames_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
                
                return returnValue;
            }
        }
    }
    
    
    // GetOutputNames
    static IntPtr GetOutputNames_NativeFunction;
    static int GetOutputNames_ParamsSize;
    static int GetOutputNames_ReturnValue_Offset;
    static IntPtr GetOutputNames_ReturnValue_NativeProperty;
    ArrayCopyMarshaller<FName> GetOutputNames_ReturnValue_Marshaller = null;
    
    public System.Collections.Generic.IList<FName> OutputNames
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetOutputNames_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetOutputNames_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOutputNames_NativeFunction, ParamsBuffer);
                
                System.Collections.Generic.IList<FName> returnValue;
                GetOutputNames_ReturnValue_Marshaller ??= new ArrayCopyMarshaller<FName>(GetOutputNames_ReturnValue_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
                IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetOutputNames_ReturnValue_Offset);
                returnValue = GetOutputNames_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
                GetOutputNames_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
                
                return returnValue;
            }
        }
    }
    
    // SetGuid
    static IntPtr SetGuid_NativeFunction;
    static int SetGuid_ParamsSize;
    static int SetGuid_NewGuid_Offset;
    
    [UFunction, GeneratedType("SetGuid")]
    public void SetGuid(UnrealSharp.CoreUObject.FGuid newGuid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetGuid_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SetGuid_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative(IntPtr.Add(ParamsBuffer, SetGuid_NewGuid_Offset), 0, newGuid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetGuid_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // GatherConnectedNodes
    static IntPtr GatherConnectedNodes_NativeFunction;
    static int GatherConnectedNodes_ParamsSize;
    static int GatherConnectedNodes_ReturnValue_Offset;
    static IntPtr GatherConnectedNodes_ReturnValue_NativeProperty;
    SetCopyMarshaller<UnrealSharp.Flow.UFlowNode> GatherConnectedNodes_ReturnValue_Marshaller = null;
    
    [UFunction, GeneratedType("GatherConnectedNodes")]
    public System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowNode> GatherConnectedNodes()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GatherConnectedNodes_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GatherConnectedNodes_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GatherConnectedNodes_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.ISet<UnrealSharp.Flow.UFlowNode> returnValue;
            GatherConnectedNodes_ReturnValue_Marshaller ??= new SetCopyMarshaller<UnrealSharp.Flow.UFlowNode>(GatherConnectedNodes_ReturnValue_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GatherConnectedNodes_ReturnValue_Offset);
            returnValue = GatherConnectedNodes_ReturnValue_Marshaller.FromNative(ReturnValue_NativeBuffer, 0);
            GatherConnectedNodes_ReturnValue_Marshaller.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // IsInputConnected
    static IntPtr IsInputConnected_NativeFunction;
    static int IsInputConnected_ParamsSize;
    static int IsInputConnected_PinName_Offset;
    static int IsInputConnected_bErrorIfPinNotFound_Offset;
    static int IsInputConnected_ReturnValue_Offset;
    
    [UFunction, GeneratedType("IsInputConnected")]
    public bool IsInputConnected(FName pinName, bool errorIfPinNotFound = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsInputConnected_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(IsInputConnected_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, IsInputConnected_PinName_Offset), 0, pinName);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, IsInputConnected_bErrorIfPinNotFound_Offset), 0, errorIfPinNotFound);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsInputConnected_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsInputConnected_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // IsOutputConnected
    static IntPtr IsOutputConnected_NativeFunction;
    static int IsOutputConnected_ParamsSize;
    static int IsOutputConnected_PinName_Offset;
    static int IsOutputConnected_bErrorIfPinNotFound_Offset;
    static int IsOutputConnected_ReturnValue_Offset;
    
    [UFunction, GeneratedType("IsOutputConnected")]
    public bool IsOutputConnected(FName pinName, bool errorIfPinNotFound = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsOutputConnected_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(IsOutputConnected_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, IsOutputConnected_PinName_Offset), 0, pinName);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, IsOutputConnected_bErrorIfPinNotFound_Offset), 0, errorIfPinNotFound);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsOutputConnected_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsOutputConnected_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // SaveInstance
    static IntPtr SaveInstance_NativeFunction;
    static int SaveInstance_ParamsSize;
    static int SaveInstance_NodeRecord_Offset;
    
    [UFunction, GeneratedType("SaveInstance")]
    public void SaveInstance(out UnrealSharp.Flow.FFlowNodeSaveData nodeRecord)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(SaveInstance_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveInstance_NativeFunction, ParamsBuffer);
            
            nodeRecord = StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.FromNative(IntPtr.Add(ParamsBuffer, SaveInstance_NodeRecord_Offset), 0);
            
        }
    }
    
    // LoadInstance
    static IntPtr LoadInstance_NativeFunction;
    static int LoadInstance_ParamsSize;
    static int LoadInstance_NodeRecord_Offset;
    
    [UFunction, GeneratedType("LoadInstance")]
    public void LoadInstance(UnrealSharp.Flow.FFlowNodeSaveData nodeRecord)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadInstance_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(LoadInstance_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.ToNative(IntPtr.Add(ParamsBuffer, LoadInstance_NodeRecord_Offset), 0, nodeRecord);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadInstance_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // GetIdentityTagDescription
    static IntPtr GetIdentityTagDescription_NativeFunction;
    static int GetIdentityTagDescription_ParamsSize;
    static int GetIdentityTagDescription_Tag_Offset;
    static int GetIdentityTagDescription_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetIdentityTagDescription")]
    public static string GetIdentityTagDescription(UnrealSharp.GameplayTags.FGameplayTag tag)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetIdentityTagDescription_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetIdentityTagDescription_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, GetIdentityTagDescription_Tag_Offset), 0, tag);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetIdentityTagDescription_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetIdentityTagDescription_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // GetIdentityTagsDescription
    static IntPtr GetIdentityTagsDescription_NativeFunction;
    static int GetIdentityTagsDescription_ParamsSize;
    static int GetIdentityTagsDescription_Tags_Offset;
    static int GetIdentityTagsDescription_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetIdentityTagsDescription")]
    public static string GetIdentityTagsDescription(UnrealSharp.GameplayTags.FGameplayTagContainer tags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetIdentityTagsDescription_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetIdentityTagsDescription_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, GetIdentityTagsDescription_Tags_Offset), 0, tags);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetIdentityTagsDescription_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetIdentityTagsDescription_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // GetNotifyTagsDescription
    static IntPtr GetNotifyTagsDescription_NativeFunction;
    static int GetNotifyTagsDescription_ParamsSize;
    static int GetNotifyTagsDescription_Tags_Offset;
    static int GetNotifyTagsDescription_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetNotifyTagsDescription")]
    public static string GetNotifyTagsDescription(UnrealSharp.GameplayTags.FGameplayTagContainer tags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNotifyTagsDescription_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetNotifyTagsDescription_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, GetNotifyTagsDescription_Tags_Offset), 0, tags);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetNotifyTagsDescription_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetNotifyTagsDescription_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // GetClassDescription
    static IntPtr GetClassDescription_NativeFunction;
    static int GetClassDescription_ParamsSize;
    static int GetClassDescription_Class_Offset;
    static int GetClassDescription_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetClassDescription")]
    public static string GetClassDescription(TSubclassOf<UnrealSharp.CoreUObject.UObject> _class)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetClassDescription_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetClassDescription_NativeFunction, ParamsBuffer);
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, GetClassDescription_Class_Offset), 0, _class);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetClassDescription_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetClassDescription_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // GetProgressAsString
    static IntPtr GetProgressAsString_NativeFunction;
    static int GetProgressAsString_ParamsSize;
    static int GetProgressAsString_Value_Offset;
    static int GetProgressAsString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("GetProgressAsString")]
    public static string GetProgressAsString(float value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetProgressAsString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(GetProgressAsString_NativeFunction, ParamsBuffer);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, GetProgressAsString_Value_Offset), 0, value);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetProgressAsString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetProgressAsString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // K2_CanUserAddInput
    IntPtr K2_CanUserAddInput_NativeFunction;
    static int K2_CanUserAddInput_ParamsSize;
    static int K2_CanUserAddInput_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_CanUserAddInput")]
    protected virtual bool CanUserAddInput()
    {
        unsafe
        {
            if (K2_CanUserAddInput_NativeFunction == IntPtr.Zero)
            {
                K2_CanUserAddInput_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_CanUserAddInput");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_CanUserAddInput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_CanUserAddInput_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_CanUserAddInput_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_CanUserAddInput_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool CanUserAddInput_Implementation()
    {
        return default(bool);
    }
    void Invoke_K2_CanUserAddInput(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = CanUserAddInput_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // K2_CanUserAddOutput
    IntPtr K2_CanUserAddOutput_NativeFunction;
    static int K2_CanUserAddOutput_ParamsSize;
    static int K2_CanUserAddOutput_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_CanUserAddOutput")]
    protected virtual bool CanUserAddOutput()
    {
        unsafe
        {
            if (K2_CanUserAddOutput_NativeFunction == IntPtr.Zero)
            {
                K2_CanUserAddOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_CanUserAddOutput");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_CanUserAddOutput_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_CanUserAddOutput_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_CanUserAddOutput_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_CanUserAddOutput_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool CanUserAddOutput_Implementation()
    {
        return default(bool);
    }
    void Invoke_K2_CanUserAddOutput(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = CanUserAddOutput_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
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
    
    // OnPassThrough
    IntPtr OnPassThrough_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("OnPassThrough")]
    protected virtual void OnPassThrough()
    {
        unsafe
        {
            if (OnPassThrough_NativeFunction == IntPtr.Zero)
            {
                OnPassThrough_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPassThrough");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPassThrough_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPassThrough_Implementation()
    {
    }
    void Invoke_OnPassThrough(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnPassThrough_Implementation();
        }
    }
    
    // K2_GetStatusBackgroundColor
    IntPtr K2_GetStatusBackgroundColor_NativeFunction;
    static int K2_GetStatusBackgroundColor_ParamsSize;
    static int K2_GetStatusBackgroundColor_OutColor_Offset;
    static int K2_GetStatusBackgroundColor_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetStatusBackgroundColor")]
    protected virtual bool GetStatusBackgroundColor(out UnrealSharp.CoreUObject.FLinearColor outColor)
    {
        unsafe
        {
            if (K2_GetStatusBackgroundColor_NativeFunction == IntPtr.Zero)
            {
                K2_GetStatusBackgroundColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetStatusBackgroundColor");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetStatusBackgroundColor_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetStatusBackgroundColor_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetStatusBackgroundColor_NativeFunction, ParamsBuffer);
            
            outColor = StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(ParamsBuffer, K2_GetStatusBackgroundColor_OutColor_Offset), 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_GetStatusBackgroundColor_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool GetStatusBackgroundColor_Implementation(out UnrealSharp.CoreUObject.FLinearColor OutColor)
    {
        OutColor = default(UnrealSharp.CoreUObject.FLinearColor);
        return default(bool);
    }
    void Invoke_K2_GetStatusBackgroundColor(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.FLinearColor OutColor = default;
            bool returnValue = GetStatusBackgroundColor_Implementation(out OutColor);
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(buffer, K2_GetStatusBackgroundColor_OutColor_Offset), 0, OutColor);
        }
    }
    
    // K2_GetAssetPath
    IntPtr K2_GetAssetPath_NativeFunction;
    static int K2_GetAssetPath_ParamsSize;
    static int K2_GetAssetPath_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetAssetPath")]
    protected virtual string GetAssetPath()
    {
        unsafe
        {
            if (K2_GetAssetPath_NativeFunction == IntPtr.Zero)
            {
                K2_GetAssetPath_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetAssetPath");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetAssetPath_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetAssetPath_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetAssetPath_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,K2_GetAssetPath_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual string GetAssetPath_Implementation()
    {
        return "";
    }
    void Invoke_K2_GetAssetPath(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            string returnValue = GetAssetPath_Implementation();
            IntPtr ReturnValue_NativePtr = IntPtr.Add(returnBuffer, 0);
            StringMarshaller.ToNative(ReturnValue_NativePtr,0,returnValue);
        }
    }
    
    // K2_GetAssetToEdit
    IntPtr K2_GetAssetToEdit_NativeFunction;
    static int K2_GetAssetToEdit_ParamsSize;
    static int K2_GetAssetToEdit_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetAssetToEdit")]
    protected virtual UnrealSharp.CoreUObject.UObject GetAssetToEdit()
    {
        unsafe
        {
            if (K2_GetAssetToEdit_NativeFunction == IntPtr.Zero)
            {
                K2_GetAssetToEdit_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetAssetToEdit");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetAssetToEdit_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetAssetToEdit_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetAssetToEdit_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.UObject returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, K2_GetAssetToEdit_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.CoreUObject.UObject GetAssetToEdit_Implementation()
    {
        return default(UnrealSharp.CoreUObject.UObject);
    }
    void Invoke_K2_GetAssetToEdit(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.UObject returnValue = GetAssetToEdit_Implementation();
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // K2_GetActorToFocus
    IntPtr K2_GetActorToFocus_NativeFunction;
    static int K2_GetActorToFocus_ParamsSize;
    static int K2_GetActorToFocus_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_GetActorToFocus")]
    protected virtual UnrealSharp.Engine.AActor GetActorToFocus()
    {
        unsafe
        {
            if (K2_GetActorToFocus_NativeFunction == IntPtr.Zero)
            {
                K2_GetActorToFocus_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_GetActorToFocus");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetActorToFocus_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_GetActorToFocus_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetActorToFocus_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.AActor returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.AActor>.FromNative(IntPtr.Add(ParamsBuffer, K2_GetActorToFocus_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Engine.AActor GetActorToFocus_Implementation()
    {
        return default(UnrealSharp.Engine.AActor);
    }
    void Invoke_K2_GetActorToFocus(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.AActor returnValue = GetActorToFocus_Implementation();
            ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // CanSupplyDataPinValues
    IntPtr CanSupplyDataPinValues_NativeFunction;
    static int CanSupplyDataPinValues_ParamsSize;
    static int CanSupplyDataPinValues_ReturnValue_Offset;
    
    /// <summary>
    /// Can this node actually supply Data Pin values?
    /// Implementers of this interface will need to use their own logic to answer this question.
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("CanSupplyDataPinValues")]
    public bool CanSupplyDataPinValues()
    {
        unsafe
        {
            if (CanSupplyDataPinValues_NativeFunction == IntPtr.Zero)
            {
                CanSupplyDataPinValues_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "CanSupplyDataPinValues");
            }
            byte* ParamsBufferAllocation = stackalloc byte[CanSupplyDataPinValues_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(CanSupplyDataPinValues_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CanSupplyDataPinValues_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, CanSupplyDataPinValues_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool CanSupplyDataPinValues_Implementation()
    {
        return default(bool);
    }
    void Invoke_CanSupplyDataPinValues(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = CanSupplyDataPinValues_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsBool
    IntPtr TrySupplyDataPinAsBool_NativeFunction;
    static int TrySupplyDataPinAsBool_ParamsSize;
    static int TrySupplyDataPinAsBool_PinName_Offset;
    static int TrySupplyDataPinAsBool_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Bool pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsBool")]
    public UnrealSharp.Flow.FFlowDataPinResult_Bool TrySupplyDataPinAsBool(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsBool_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsBool");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsBool_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsBool_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsBool_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsBool_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Bool returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Bool>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsBool_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Bool TrySupplyDataPinAsBool_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Bool);
    }
    void Invoke_TrySupplyDataPinAsBool(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsBool_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Bool returnValue = TrySupplyDataPinAsBool_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Bool>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsInt
    IntPtr TrySupplyDataPinAsInt_NativeFunction;
    static int TrySupplyDataPinAsInt_ParamsSize;
    static int TrySupplyDataPinAsInt_PinName_Offset;
    static int TrySupplyDataPinAsInt_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Int pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsInt")]
    public UnrealSharp.Flow.FFlowDataPinResult_Int TrySupplyDataPinAsInt(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsInt_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsInt_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsInt");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsInt_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsInt_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsInt_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsInt_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Int returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsInt_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Int TrySupplyDataPinAsInt_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Int);
    }
    void Invoke_TrySupplyDataPinAsInt(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsInt_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Int returnValue = TrySupplyDataPinAsInt_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsFloat
    IntPtr TrySupplyDataPinAsFloat_NativeFunction;
    static int TrySupplyDataPinAsFloat_ParamsSize;
    static int TrySupplyDataPinAsFloat_PinName_Offset;
    static int TrySupplyDataPinAsFloat_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Float pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsFloat")]
    public UnrealSharp.Flow.FFlowDataPinResult_Float TrySupplyDataPinAsFloat(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsFloat_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsFloat_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsFloat");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsFloat_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsFloat_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsFloat_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsFloat_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Float returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Float>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsFloat_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Float TrySupplyDataPinAsFloat_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Float);
    }
    void Invoke_TrySupplyDataPinAsFloat(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsFloat_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Float returnValue = TrySupplyDataPinAsFloat_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Float>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsName
    IntPtr TrySupplyDataPinAsName_NativeFunction;
    static int TrySupplyDataPinAsName_ParamsSize;
    static int TrySupplyDataPinAsName_PinName_Offset;
    static int TrySupplyDataPinAsName_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Name pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsName")]
    public UnrealSharp.Flow.FFlowDataPinResult_Name TrySupplyDataPinAsName(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsName_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsName_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsName");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsName_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsName_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Name returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Name TrySupplyDataPinAsName_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Name);
    }
    void Invoke_TrySupplyDataPinAsName(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsName_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Name returnValue = TrySupplyDataPinAsName_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsString
    IntPtr TrySupplyDataPinAsString_NativeFunction;
    static int TrySupplyDataPinAsString_ParamsSize;
    static int TrySupplyDataPinAsString_PinName_Offset;
    static int TrySupplyDataPinAsString_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data String pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsString")]
    public UnrealSharp.Flow.FFlowDataPinResult_String TrySupplyDataPinAsString(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsString_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsString_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsString");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsString_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsString_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsString_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_String returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsString_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_String TrySupplyDataPinAsString_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_String);
    }
    void Invoke_TrySupplyDataPinAsString(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsString_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_String returnValue = TrySupplyDataPinAsString_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsText
    IntPtr TrySupplyDataPinAsText_NativeFunction;
    static int TrySupplyDataPinAsText_ParamsSize;
    static int TrySupplyDataPinAsText_PinName_Offset;
    static int TrySupplyDataPinAsText_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Text pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsText")]
    public UnrealSharp.Flow.FFlowDataPinResult_Text TrySupplyDataPinAsText(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsText_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsText_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsText");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsText_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsText_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsText_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Text returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Text TrySupplyDataPinAsText_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Text);
    }
    void Invoke_TrySupplyDataPinAsText(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsText_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Text returnValue = TrySupplyDataPinAsText_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsEnum
    IntPtr TrySupplyDataPinAsEnum_NativeFunction;
    static int TrySupplyDataPinAsEnum_ParamsSize;
    static int TrySupplyDataPinAsEnum_PinName_Offset;
    static int TrySupplyDataPinAsEnum_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Enum pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsEnum")]
    public UnrealSharp.Flow.FFlowDataPinResult_Enum TrySupplyDataPinAsEnum(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsEnum_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsEnum");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsEnum_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsEnum_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsEnum_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsEnum_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Enum returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Enum>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsEnum_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Enum TrySupplyDataPinAsEnum_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Enum);
    }
    void Invoke_TrySupplyDataPinAsEnum(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsEnum_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Enum returnValue = TrySupplyDataPinAsEnum_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Enum>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsVector
    IntPtr TrySupplyDataPinAsVector_NativeFunction;
    static int TrySupplyDataPinAsVector_ParamsSize;
    static int TrySupplyDataPinAsVector_PinName_Offset;
    static int TrySupplyDataPinAsVector_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Vector pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsVector")]
    public UnrealSharp.Flow.FFlowDataPinResult_Vector TrySupplyDataPinAsVector(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsVector_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsVector");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsVector_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsVector_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsVector_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsVector_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Vector returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Vector>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsVector_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Vector TrySupplyDataPinAsVector_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Vector);
    }
    void Invoke_TrySupplyDataPinAsVector(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsVector_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Vector returnValue = TrySupplyDataPinAsVector_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Vector>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsRotator
    IntPtr TrySupplyDataPinAsRotator_NativeFunction;
    static int TrySupplyDataPinAsRotator_ParamsSize;
    static int TrySupplyDataPinAsRotator_PinName_Offset;
    static int TrySupplyDataPinAsRotator_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Rotator pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsRotator")]
    public UnrealSharp.Flow.FFlowDataPinResult_Rotator TrySupplyDataPinAsRotator(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsRotator_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsRotator_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsRotator");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsRotator_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsRotator_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsRotator_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsRotator_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Rotator returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Rotator>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsRotator_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Rotator TrySupplyDataPinAsRotator_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Rotator);
    }
    void Invoke_TrySupplyDataPinAsRotator(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsRotator_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Rotator returnValue = TrySupplyDataPinAsRotator_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Rotator>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsTransform
    IntPtr TrySupplyDataPinAsTransform_NativeFunction;
    static int TrySupplyDataPinAsTransform_ParamsSize;
    static int TrySupplyDataPinAsTransform_PinName_Offset;
    static int TrySupplyDataPinAsTransform_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Transform pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsTransform")]
    public UnrealSharp.Flow.FFlowDataPinResult_Transform TrySupplyDataPinAsTransform(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsTransform_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsTransform");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsTransform_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsTransform_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsTransform_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsTransform_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Transform returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Transform>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsTransform_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Transform TrySupplyDataPinAsTransform_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Transform);
    }
    void Invoke_TrySupplyDataPinAsTransform(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsTransform_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Transform returnValue = TrySupplyDataPinAsTransform_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Transform>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsGameplayTag
    IntPtr TrySupplyDataPinAsGameplayTag_NativeFunction;
    static int TrySupplyDataPinAsGameplayTag_ParamsSize;
    static int TrySupplyDataPinAsGameplayTag_PinName_Offset;
    static int TrySupplyDataPinAsGameplayTag_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data GameplayTag pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsGameplayTag")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTag TrySupplyDataPinAsGameplayTag(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsGameplayTag_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsGameplayTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsGameplayTag");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsGameplayTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsGameplayTag_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsGameplayTag_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsGameplayTag_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTag returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTag>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsGameplayTag_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_GameplayTag TrySupplyDataPinAsGameplayTag_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_GameplayTag);
    }
    void Invoke_TrySupplyDataPinAsGameplayTag(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsGameplayTag_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTag returnValue = TrySupplyDataPinAsGameplayTag_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTag>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsGameplayTagContainer
    IntPtr TrySupplyDataPinAsGameplayTagContainer_NativeFunction;
    static int TrySupplyDataPinAsGameplayTagContainer_ParamsSize;
    static int TrySupplyDataPinAsGameplayTagContainer_PinName_Offset;
    static int TrySupplyDataPinAsGameplayTagContainer_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data GameplayTagContainer pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsGameplayTagContainer")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer TrySupplyDataPinAsGameplayTagContainer(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsGameplayTagContainer_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsGameplayTagContainer");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsGameplayTagContainer_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsGameplayTagContainer_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer TrySupplyDataPinAsGameplayTagContainer_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer);
    }
    void Invoke_TrySupplyDataPinAsGameplayTagContainer(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsGameplayTagContainer_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer returnValue = TrySupplyDataPinAsGameplayTagContainer_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsInstancedStruct
    IntPtr TrySupplyDataPinAsInstancedStruct_NativeFunction;
    static int TrySupplyDataPinAsInstancedStruct_ParamsSize;
    static int TrySupplyDataPinAsInstancedStruct_PinName_Offset;
    static int TrySupplyDataPinAsInstancedStruct_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data InstancedStruct pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsInstancedStruct")]
    public UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct TrySupplyDataPinAsInstancedStruct(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsInstancedStruct_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsInstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsInstancedStruct");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsInstancedStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsInstancedStruct_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsInstancedStruct_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsInstancedStruct_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsInstancedStruct_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct TrySupplyDataPinAsInstancedStruct_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct);
    }
    void Invoke_TrySupplyDataPinAsInstancedStruct(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsInstancedStruct_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct returnValue = TrySupplyDataPinAsInstancedStruct_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsObject
    IntPtr TrySupplyDataPinAsObject_NativeFunction;
    static int TrySupplyDataPinAsObject_ParamsSize;
    static int TrySupplyDataPinAsObject_PinName_Offset;
    static int TrySupplyDataPinAsObject_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Object pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsObject")]
    public UnrealSharp.Flow.FFlowDataPinResult_Object TrySupplyDataPinAsObject(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsObject_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsObject");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsObject_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsObject_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsObject_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsObject_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Object returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Object>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsObject_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Object TrySupplyDataPinAsObject_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Object);
    }
    void Invoke_TrySupplyDataPinAsObject(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsObject_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Object returnValue = TrySupplyDataPinAsObject_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Object>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // TrySupplyDataPinAsClass
    IntPtr TrySupplyDataPinAsClass_NativeFunction;
    static int TrySupplyDataPinAsClass_ParamsSize;
    static int TrySupplyDataPinAsClass_PinName_Offset;
    static int TrySupplyDataPinAsClass_ReturnValue_Offset;
    
    /// <summary>
    /// Try to supply the value for a data Class pin
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("TrySupplyDataPinAsClass")]
    public UnrealSharp.Flow.FFlowDataPinResult_Class TrySupplyDataPinAsClass(FName pinName)
    {
        unsafe
        {
            if (TrySupplyDataPinAsClass_NativeFunction == IntPtr.Zero)
            {
                TrySupplyDataPinAsClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "TrySupplyDataPinAsClass");
            }
            byte* ParamsBufferAllocation = stackalloc byte[TrySupplyDataPinAsClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(TrySupplyDataPinAsClass_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsClass_PinName_Offset), 0, pinName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, TrySupplyDataPinAsClass_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowDataPinResult_Class returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Class>.FromNative(IntPtr.Add(ParamsBuffer, TrySupplyDataPinAsClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.FFlowDataPinResult_Class TrySupplyDataPinAsClass_Implementation(FName PinName)
    {
        return default(UnrealSharp.Flow.FFlowDataPinResult_Class);
    }
    void Invoke_TrySupplyDataPinAsClass(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            FName PinName =  BlittableMarshaller<FName>.FromNative(IntPtr.Add(buffer, TrySupplyDataPinAsClass_PinName_Offset), 0);
            UnrealSharp.Flow.FFlowDataPinResult_Class returnValue = TrySupplyDataPinAsClass_Implementation(PinName);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Class>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    
}