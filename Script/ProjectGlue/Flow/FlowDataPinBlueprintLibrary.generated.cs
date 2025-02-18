using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Auto-cast operators for blueprint to their inner types
/// </summary>
[UClass, GeneratedType("FlowDataPinBlueprintLibrary", "UnrealSharp.Flow.FlowDataPinBlueprintLibrary")]
public partial class UFlowDataPinBlueprintLibrary : UnrealSharp.Engine.UBlueprintFunctionLibrary
{
    static readonly IntPtr NativeClassPtr;
    static UFlowDataPinBlueprintLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowDataPinBlueprintLibrary");
        MakeStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "MakeStruct");
        MakeStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(MakeStruct_NativeFunction);
        MakeStruct_PinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MakeStruct_NativeFunction, "PinName");
        MakeStruct_PinFriendlyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MakeStruct_NativeFunction, "PinFriendlyName");
        MakeStruct_PinToolTip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MakeStruct_NativeFunction, "PinToolTip");
        MakeStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MakeStruct_NativeFunction, "ReturnValue");
        BreakStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "BreakStruct");
        BreakStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(BreakStruct_NativeFunction);
        BreakStruct_Ref_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BreakStruct_NativeFunction, "Ref");
        BreakStruct_OutPinName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BreakStruct_NativeFunction, "OutPinName");
        BreakStruct_OutPinFriendlyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BreakStruct_NativeFunction, "OutPinFriendlyName");
        BreakStruct_OutPinToolTip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(BreakStruct_NativeFunction, "OutPinToolTip");
        AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyBoolToBool");
        AutoConvert_FlowDataPinPropertyBoolToBool_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction);
        AutoConvert_FlowDataPinPropertyBoolToBool_BoolProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction, "BoolProperty");
        AutoConvert_FlowDataPinPropertyBoolToBool_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyInt32ToInt32");
        AutoConvert_FlowDataPinPropertyInt32ToInt32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction);
        AutoConvert_FlowDataPinPropertyInt32ToInt32_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinPropertyInt32ToInt32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyInt32ToInt64");
        AutoConvert_FlowDataPinPropertyInt32ToInt64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction);
        AutoConvert_FlowDataPinPropertyInt32ToInt64_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinPropertyInt32ToInt64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyInt64ToInt32");
        AutoConvert_FlowDataPinPropertyInt64ToInt32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction);
        AutoConvert_FlowDataPinPropertyInt64ToInt32_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinPropertyInt64ToInt32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyInt64ToInt64");
        AutoConvert_FlowDataPinPropertyInt64ToInt64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction);
        AutoConvert_FlowDataPinPropertyInt64ToInt64_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinPropertyInt64ToInt64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyFloat32ToFloat32");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction);
        AutoConvert_FlowDataPinPropertyFloat32ToFloat32_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyFloat32ToFloat64");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction);
        AutoConvert_FlowDataPinPropertyFloat32ToFloat64_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyFloat64ToFloat32");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction);
        AutoConvert_FlowDataPinPropertyFloat64ToFloat32_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyFloat64ToFloat64");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction);
        AutoConvert_FlowDataPinPropertyFloat64ToFloat64_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyNameToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyNameToName");
        AutoConvert_FlowDataPinPropertyNameToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyNameToName_NativeFunction);
        AutoConvert_FlowDataPinPropertyNameToName_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToName_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinPropertyNameToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyStringToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyStringToName");
        AutoConvert_FlowDataPinPropertyStringToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyStringToName_NativeFunction);
        AutoConvert_FlowDataPinPropertyStringToName_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToName_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinPropertyStringToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyTextToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyTextToName");
        AutoConvert_FlowDataPinPropertyTextToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyTextToName_NativeFunction);
        AutoConvert_FlowDataPinPropertyTextToName_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToName_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinPropertyTextToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyNameToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyNameToString");
        AutoConvert_FlowDataPinPropertyNameToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyNameToString_NativeFunction);
        AutoConvert_FlowDataPinPropertyNameToString_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToString_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinPropertyNameToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyStringToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyStringToString");
        AutoConvert_FlowDataPinPropertyStringToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyStringToString_NativeFunction);
        AutoConvert_FlowDataPinPropertyStringToString_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToString_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinPropertyStringToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyTextToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyTextToString");
        AutoConvert_FlowDataPinPropertyTextToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyTextToString_NativeFunction);
        AutoConvert_FlowDataPinPropertyTextToString_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToString_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinPropertyTextToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyNameToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyNameToText");
        AutoConvert_FlowDataPinPropertyNameToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyNameToText_NativeFunction);
        AutoConvert_FlowDataPinPropertyNameToText_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToText_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinPropertyNameToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyNameToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyStringToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyStringToText");
        AutoConvert_FlowDataPinPropertyStringToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyStringToText_NativeFunction);
        AutoConvert_FlowDataPinPropertyStringToText_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToText_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinPropertyStringToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyStringToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyTextToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyTextToText");
        AutoConvert_FlowDataPinPropertyTextToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyTextToText_NativeFunction);
        AutoConvert_FlowDataPinPropertyTextToText_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToText_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinPropertyTextToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTextToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyEnumToEnum");
        AutoConvert_FlowDataPinPropertyEnumToEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction);
        AutoConvert_FlowDataPinPropertyEnumToEnum_EnumProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction, "EnumProperty");
        AutoConvert_FlowDataPinPropertyEnumToEnum_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyVectorToVector");
        AutoConvert_FlowDataPinPropertyVectorToVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction);
        AutoConvert_FlowDataPinPropertyVectorToVector_VectorProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction, "VectorProperty");
        AutoConvert_FlowDataPinPropertyVectorToVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyRotatorToRotator");
        AutoConvert_FlowDataPinPropertyRotatorToRotator_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction);
        AutoConvert_FlowDataPinPropertyRotatorToRotator_RotatorProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction, "RotatorProperty");
        AutoConvert_FlowDataPinPropertyRotatorToRotator_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyTransformToTransform");
        AutoConvert_FlowDataPinPropertyTransformToTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction);
        AutoConvert_FlowDataPinPropertyTransformToTransform_TransformProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction, "TransformProperty");
        AutoConvert_FlowDataPinPropertyTransformToTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction);
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_GameplayTagProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction, "GameplayTagProperty");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction);
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction, "GameplayTagProperty");
        AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer");
        AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction);
        AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction, "GameplayTagContainerProperty");
        AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct");
        AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction);
        AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_InstancedStructProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction, "InstancedStructProperty");
        AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyObjectToObject");
        AutoConvert_FlowDataPinPropertyObjectToObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction);
        AutoConvert_FlowDataPinPropertyObjectToObject_ObjectProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction, "ObjectProperty");
        AutoConvert_FlowDataPinPropertyObjectToObject_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyClassToClass");
        AutoConvert_FlowDataPinPropertyClassToClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction);
        AutoConvert_FlowDataPinPropertyClassToClass_ClassProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction, "ClassProperty");
        AutoConvert_FlowDataPinPropertyClassToClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinPropertyClassToSoftClass");
        AutoConvert_FlowDataPinPropertyClassToSoftClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction);
        AutoConvert_FlowDataPinPropertyClassToSoftClass_ClassProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction, "ClassProperty");
        AutoConvert_FlowDataPinPropertyClassToSoftClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultBoolToBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultBoolToBool");
        AutoConvert_FlowDataPinResultBoolToBool_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultBoolToBool_NativeFunction);
        AutoConvert_FlowDataPinResultBoolToBool_BoolProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultBoolToBool_NativeFunction, "BoolProperty");
        AutoConvert_FlowDataPinResultBoolToBool_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultBoolToBool_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultInt64ToInt32");
        AutoConvert_FlowDataPinResultInt64ToInt32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction);
        AutoConvert_FlowDataPinResultInt64ToInt32_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinResultInt64ToInt32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultInt64ToInt64");
        AutoConvert_FlowDataPinResultInt64ToInt64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction);
        AutoConvert_FlowDataPinResultInt64ToInt64_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinResultInt64ToInt64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultInt64ToUint8");
        AutoConvert_FlowDataPinResultInt64ToUint8_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction);
        AutoConvert_FlowDataPinResultInt64ToUint8_IntProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction, "IntProperty");
        AutoConvert_FlowDataPinResultInt64ToUint8_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultFloat64ToFloat32");
        AutoConvert_FlowDataPinResultFloat64ToFloat32_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction);
        AutoConvert_FlowDataPinResultFloat64ToFloat32_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinResultFloat64ToFloat32_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultFloat64ToFloat64");
        AutoConvert_FlowDataPinResultFloat64ToFloat64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction);
        AutoConvert_FlowDataPinResultFloat64ToFloat64_FloatProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction, "FloatProperty");
        AutoConvert_FlowDataPinResultFloat64ToFloat64_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultNameToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultNameToName");
        AutoConvert_FlowDataPinResultNameToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultNameToName_NativeFunction);
        AutoConvert_FlowDataPinResultNameToName_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToName_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinResultNameToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultStringToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultStringToName");
        AutoConvert_FlowDataPinResultStringToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultStringToName_NativeFunction);
        AutoConvert_FlowDataPinResultStringToName_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToName_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinResultStringToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultTextToName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultTextToName");
        AutoConvert_FlowDataPinResultTextToName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultTextToName_NativeFunction);
        AutoConvert_FlowDataPinResultTextToName_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToName_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinResultTextToName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToName_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultNameToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultNameToString");
        AutoConvert_FlowDataPinResultNameToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultNameToString_NativeFunction);
        AutoConvert_FlowDataPinResultNameToString_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToString_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinResultNameToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultStringToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultStringToString");
        AutoConvert_FlowDataPinResultStringToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultStringToString_NativeFunction);
        AutoConvert_FlowDataPinResultStringToString_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToString_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinResultStringToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultTextToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultTextToString");
        AutoConvert_FlowDataPinResultTextToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultTextToString_NativeFunction);
        AutoConvert_FlowDataPinResultTextToString_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToString_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinResultTextToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToString_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultNameToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultNameToText");
        AutoConvert_FlowDataPinResultNameToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultNameToText_NativeFunction);
        AutoConvert_FlowDataPinResultNameToText_NameProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToText_NativeFunction, "NameProperty");
        AutoConvert_FlowDataPinResultNameToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultNameToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultStringToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultStringToText");
        AutoConvert_FlowDataPinResultStringToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultStringToText_NativeFunction);
        AutoConvert_FlowDataPinResultStringToText_StringProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToText_NativeFunction, "StringProperty");
        AutoConvert_FlowDataPinResultStringToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultStringToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultTextToText_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultTextToText");
        AutoConvert_FlowDataPinResultTextToText_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultTextToText_NativeFunction);
        AutoConvert_FlowDataPinResultTextToText_TextProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToText_NativeFunction, "TextProperty");
        AutoConvert_FlowDataPinResultTextToText_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTextToText_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultEnumToEnum");
        AutoConvert_FlowDataPinResultEnumToEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction);
        AutoConvert_FlowDataPinResultEnumToEnum_EnumProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction, "EnumProperty");
        AutoConvert_FlowDataPinResultEnumToEnum_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultVectorToVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultVectorToVector");
        AutoConvert_FlowDataPinResultVectorToVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultVectorToVector_NativeFunction);
        AutoConvert_FlowDataPinResultVectorToVector_VectorProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultVectorToVector_NativeFunction, "VectorProperty");
        AutoConvert_FlowDataPinResultVectorToVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultVectorToVector_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultRotatorToRotator");
        AutoConvert_FlowDataPinResultRotatorToRotator_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction);
        AutoConvert_FlowDataPinResultRotatorToRotator_RotatorProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction, "RotatorProperty");
        AutoConvert_FlowDataPinResultRotatorToRotator_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultTransformToTransform");
        AutoConvert_FlowDataPinResultTransformToTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction);
        AutoConvert_FlowDataPinResultTransformToTransform_TransformProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction, "TransformProperty");
        AutoConvert_FlowDataPinResultTransformToTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultGameplayTagToGameplayTag");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction);
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_GameplayTagProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction, "GameplayTagProperty");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction);
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction, "GameplayTagProperty");
        AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer");
        AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction);
        AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction, "GameplayTagContainerProperty");
        AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct");
        AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction);
        AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_InstancedStructProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction, "InstancedStructProperty");
        AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultObjectToObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultObjectToObject");
        AutoConvert_FlowDataPinResultObjectToObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultObjectToObject_NativeFunction);
        AutoConvert_FlowDataPinResultObjectToObject_ObjectProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultObjectToObject_NativeFunction, "ObjectProperty");
        AutoConvert_FlowDataPinResultObjectToObject_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultObjectToObject_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultClassToClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultClassToClass");
        AutoConvert_FlowDataPinResultClassToClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultClassToClass_NativeFunction);
        AutoConvert_FlowDataPinResultClassToClass_ClassProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultClassToClass_NativeFunction, "ClassProperty");
        AutoConvert_FlowDataPinResultClassToClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultClassToClass_NativeFunction, "ReturnValue");
        AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AutoConvert_FlowDataPinResultClassToSoftClass");
        AutoConvert_FlowDataPinResultClassToSoftClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction);
        AutoConvert_FlowDataPinResultClassToSoftClass_ClassProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction, "ClassProperty");
        AutoConvert_FlowDataPinResultClassToSoftClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction, "ReturnValue");
    }
    // MakeStruct
    static IntPtr MakeStruct_NativeFunction;
    static int MakeStruct_ParamsSize;
    static int MakeStruct_PinName_Offset;
    static int MakeStruct_PinFriendlyName_Offset;
    static int MakeStruct_PinToolTip_Offset;
    static int MakeStruct_ReturnValue_Offset;
    
    [UFunction, GeneratedType("MakeStruct")]
    public static UnrealSharp.Flow.FFlowPin MakeFlowPin(FName pinName, FText pinFriendlyName, string pinToolTip)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[MakeStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(MakeStruct_NativeFunction, ParamsBuffer);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, MakeStruct_PinName_Offset), 0, pinName);
            TextMarshaller.ToNative(IntPtr.Add(ParamsBuffer, MakeStruct_PinFriendlyName_Offset), 0, pinFriendlyName);
            IntPtr PinToolTip_NativePtr = IntPtr.Add(ParamsBuffer, MakeStruct_PinToolTip_Offset);
            StringMarshaller.ToNative(PinToolTip_NativePtr,0,pinToolTip);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, MakeStruct_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.FFlowPin returnValue;
            returnValue = StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative(IntPtr.Add(ParamsBuffer, MakeStruct_ReturnValue_Offset), 0);
            
            StringMarshaller.DestructInstance(PinToolTip_NativePtr, 0);
            return returnValue;
        }
    }
    
    // BreakStruct
    static IntPtr BreakStruct_NativeFunction;
    static int BreakStruct_ParamsSize;
    static int BreakStruct_Ref_Offset;
    static int BreakStruct_OutPinName_Offset;
    static int BreakStruct_OutPinFriendlyName_Offset;
    static int BreakStruct_OutPinToolTip_Offset;
    
    [UFunction, GeneratedType("BreakStruct")]
    public static void BreakFlowPin(UnrealSharp.Flow.FFlowPin flowPin, out FName outPinName, out FText outPinFriendlyName, out string outPinToolTip)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[BreakStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(BreakStruct_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative(IntPtr.Add(ParamsBuffer, BreakStruct_Ref_Offset), 0, flowPin);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, BreakStruct_NativeFunction, ParamsBuffer);
            
            outPinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, BreakStruct_OutPinName_Offset), 0);
            outPinFriendlyName = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, BreakStruct_OutPinFriendlyName_Offset), 0);
            IntPtr OutPinToolTip_NativePtr = IntPtr.Add(ParamsBuffer,BreakStruct_OutPinToolTip_Offset);
            outPinToolTip = StringMarshaller.FromNative(OutPinToolTip_NativePtr,0);
            
        }
    }
    
    // AutoConvert_FlowDataPinPropertyBoolToBool
    static IntPtr AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyBoolToBool_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyBoolToBool_BoolProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyBoolToBool_ReturnValue_Offset;
    
    /// <summary>
    /// Convert bool property values to their inner blue values
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyBoolToBool")]
    public static bool AutoConvert_FlowDataPinPropertyBoolToBool(UnrealSharp.Flow.FFlowDataPinOutputProperty_Bool boolProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyBoolToBool_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Bool>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyBoolToBool_BoolProperty_Offset), 0, boolProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyBoolToBool_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyBoolToBool_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyInt32ToInt32
    static IntPtr AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt32_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt32_IntProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt32_ReturnValue_Offset;
    
    /// <summary>
    /// to Int variants for all int types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyInt32ToInt32")]
    public static int AutoConvert_FlowDataPinPropertyInt32ToInt32(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyInt32ToInt32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt32ToInt32_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyInt32ToInt32_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt32ToInt32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyInt32ToInt64
    static IntPtr AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt64_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt64_IntProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyInt32ToInt64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyInt32ToInt64")]
    public static long AutoConvert_FlowDataPinPropertyInt32ToInt64(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyInt32ToInt64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt32ToInt64_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyInt32ToInt64_NativeFunction, ParamsBuffer);
            
            long returnValue;
            returnValue = BlittableMarshaller<long>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt32ToInt64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyInt64ToInt32
    static IntPtr AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt32_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt32_IntProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt32_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyInt64ToInt32")]
    public static int AutoConvert_FlowDataPinPropertyInt64ToInt32(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyInt64ToInt32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt64ToInt32_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyInt64ToInt32_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt64ToInt32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyInt64ToInt64
    static IntPtr AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt64_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt64_IntProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyInt64ToInt64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyInt64ToInt64")]
    public static long AutoConvert_FlowDataPinPropertyInt64ToInt64(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyInt64ToInt64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt64ToInt64_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyInt64ToInt64_NativeFunction, ParamsBuffer);
            
            long returnValue;
            returnValue = BlittableMarshaller<long>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInt64ToInt64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyFloat32ToFloat32
    static IntPtr AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat32_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ReturnValue_Offset;
    
    /// <summary>
    /// to Float variants for all float types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyFloat32ToFloat32")]
    public static float AutoConvert_FlowDataPinPropertyFloat32ToFloat32(UnrealSharp.Flow.FFlowDataPinOutputProperty_Float floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Float>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat32ToFloat32_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyFloat32ToFloat32_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat32ToFloat32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyFloat32ToFloat64
    static IntPtr AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat64_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyFloat32ToFloat64")]
    public static double AutoConvert_FlowDataPinPropertyFloat32ToFloat64(UnrealSharp.Flow.FFlowDataPinOutputProperty_Float floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Float>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat32ToFloat64_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyFloat32ToFloat64_NativeFunction, ParamsBuffer);
            
            double returnValue;
            returnValue = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat32ToFloat64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyFloat64ToFloat32
    static IntPtr AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat32_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyFloat64ToFloat32")]
    public static float AutoConvert_FlowDataPinPropertyFloat64ToFloat32(UnrealSharp.Flow.FFlowDataPinOutputProperty_Double floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Double>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat64ToFloat32_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyFloat64ToFloat32_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat64ToFloat32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyFloat64ToFloat64
    static IntPtr AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat64_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyFloat64ToFloat64")]
    public static double AutoConvert_FlowDataPinPropertyFloat64ToFloat64(UnrealSharp.Flow.FFlowDataPinOutputProperty_Double floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Double>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat64ToFloat64_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyFloat64ToFloat64_NativeFunction, ParamsBuffer);
            
            double returnValue;
            returnValue = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyFloat64ToFloat64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyNameToName
    static IntPtr AutoConvert_FlowDataPinPropertyNameToName_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyNameToName_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyNameToName_NameProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyNameToName_ReturnValue_Offset;
    
    /// <summary>
    /// to Name variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyNameToName")]
    public static FName AutoConvert_FlowDataPinPropertyNameToName(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyNameToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyNameToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyNameToName_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyNameToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyNameToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyStringToName
    static IntPtr AutoConvert_FlowDataPinPropertyStringToName_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyStringToName_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyStringToName_StringProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyStringToName_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyStringToName")]
    public static FName AutoConvert_FlowDataPinPropertyStringToName(UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyStringToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyStringToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyStringToName_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyStringToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyStringToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyTextToName
    static IntPtr AutoConvert_FlowDataPinPropertyTextToName_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyTextToName_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyTextToName_TextProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyTextToName_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyTextToName")]
    public static FName AutoConvert_FlowDataPinPropertyTextToName(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyTextToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyTextToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTextToName_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyTextToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTextToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyNameToString
    static IntPtr AutoConvert_FlowDataPinPropertyNameToString_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyNameToString_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyNameToString_NameProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyNameToString_ReturnValue_Offset;
    
    /// <summary>
    /// to String variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyNameToString")]
    public static string AutoConvert_FlowDataPinPropertyNameToString(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyNameToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyNameToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyNameToString_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyNameToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinPropertyNameToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyStringToString
    static IntPtr AutoConvert_FlowDataPinPropertyStringToString_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyStringToString_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyStringToString_StringProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyStringToString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyStringToString")]
    public static string AutoConvert_FlowDataPinPropertyStringToString(UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyStringToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyStringToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyStringToString_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyStringToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinPropertyStringToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyTextToString
    static IntPtr AutoConvert_FlowDataPinPropertyTextToString_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyTextToString_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyTextToString_TextProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyTextToString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyTextToString")]
    public static string AutoConvert_FlowDataPinPropertyTextToString(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyTextToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyTextToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTextToString_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyTextToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinPropertyTextToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyNameToText
    static IntPtr AutoConvert_FlowDataPinPropertyNameToText_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyNameToText_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyNameToText_NameProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyNameToText_ReturnValue_Offset;
    
    /// <summary>
    /// to Text variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyNameToText")]
    public static FText AutoConvert_FlowDataPinPropertyNameToText(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyNameToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyNameToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyNameToText_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyNameToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyNameToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyStringToText
    static IntPtr AutoConvert_FlowDataPinPropertyStringToText_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyStringToText_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyStringToText_StringProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyStringToText_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyStringToText")]
    public static FText AutoConvert_FlowDataPinPropertyStringToText(UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyStringToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyStringToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyStringToText_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyStringToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyStringToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyTextToText
    static IntPtr AutoConvert_FlowDataPinPropertyTextToText_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyTextToText_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyTextToText_TextProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyTextToText_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyTextToText")]
    public static FText AutoConvert_FlowDataPinPropertyTextToText(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyTextToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyTextToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTextToText_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyTextToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTextToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyEnumToEnum
    static IntPtr AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyEnumToEnum_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyEnumToEnum_EnumProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyEnumToEnum_ReturnValue_Offset;
    
    /// <summary>
    /// Convert enum property values to their inner enum values
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyEnumToEnum")]
    public static byte AutoConvert_FlowDataPinPropertyEnumToEnum(UnrealSharp.Flow.FFlowDataPinOutputProperty_Enum enumProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyEnumToEnum_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Enum>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyEnumToEnum_EnumProperty_Offset), 0, enumProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyEnumToEnum_NativeFunction, ParamsBuffer);
            
            byte returnValue;
            returnValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyEnumToEnum_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyVectorToVector
    static IntPtr AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyVectorToVector_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyVectorToVector_VectorProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyVectorToVector_ReturnValue_Offset;
    
    /// <summary>
    /// Convert vector property values to their inner Vector
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyVectorToVector")]
    public static UnrealSharp.CoreUObject.FVector AutoConvert_FlowDataPinPropertyVectorToVector(UnrealSharp.Flow.FFlowDataPinOutputProperty_Vector vectorProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyVectorToVector_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Vector>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyVectorToVector_VectorProperty_Offset), 0, vectorProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyVectorToVector_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FVector returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FVector>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyVectorToVector_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyRotatorToRotator
    static IntPtr AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyRotatorToRotator_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyRotatorToRotator_RotatorProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyRotatorToRotator_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Rotator property values to their inner Rotator
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyRotatorToRotator")]
    public static UnrealSharp.CoreUObject.FRotator AutoConvert_FlowDataPinPropertyRotatorToRotator(UnrealSharp.Flow.FFlowDataPinOutputProperty_Rotator rotatorProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyRotatorToRotator_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Rotator>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyRotatorToRotator_RotatorProperty_Offset), 0, rotatorProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyRotatorToRotator_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FRotator returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FRotator>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyRotatorToRotator_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyTransformToTransform
    static IntPtr AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyTransformToTransform_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyTransformToTransform_TransformProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyTransformToTransform_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Transform property values to their inner Transform
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyTransformToTransform")]
    public static UnrealSharp.CoreUObject.FTransform AutoConvert_FlowDataPinPropertyTransformToTransform(UnrealSharp.Flow.FFlowDataPinOutputProperty_Transform transformProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyTransformToTransform_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Transform>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTransformToTransform_TransformProperty_Offset), 0, transformProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyTransformToTransform_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FTransform returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FTransform>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyTransformToTransform_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag
    static IntPtr AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_GameplayTagProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ReturnValue_Offset;
    
    /// <summary>
    /// Convert GameplayTag property values to their inner GameplayTag
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag")]
    public static UnrealSharp.GameplayTags.FGameplayTag AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag gameplayTagProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_GameplayTagProperty_Offset), 0, gameplayTagProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTag returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer
    static IntPtr AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer")]
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag gameplayTagProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset), 0, gameplayTagProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer
    static IntPtr AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset;
    
    /// <summary>
    /// Convert GameplayTagContainer property values to their inner GameplayTagContainer
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer")]
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTagContainer gameplayTagContainerProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset), 0, gameplayTagContainerProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct
    static IntPtr AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_InstancedStructProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ReturnValue_Offset;
    
    /// <summary>
    /// Convert InstancedStruct property values to their inner InstancedStruct
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct")]
    public static UnrealSharp.CoreUObject.FInstancedStruct AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct(UnrealSharp.Flow.FFlowDataPinOutputProperty_InstancedStruct instancedStructProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_InstancedStruct>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_InstancedStructProperty_Offset), 0, instancedStructProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FInstancedStruct returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyObjectToObject
    static IntPtr AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyObjectToObject_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyObjectToObject_ObjectProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyObjectToObject_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Object property values to their inner Object
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyObjectToObject")]
    public static UnrealSharp.CoreUObject.UObject AutoConvert_FlowDataPinPropertyObjectToObject(UnrealSharp.Flow.FFlowDataPinOutputProperty_Object objectProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyObjectToObject_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Object>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyObjectToObject_ObjectProperty_Offset), 0, objectProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyObjectToObject_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.UObject returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyObjectToObject_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyClassToClass
    static IntPtr AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyClassToClass_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyClassToClass_ClassProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyClassToClass_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Class property values to their inner Class
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyClassToClass")]
    public static TSubclassOf<UnrealSharp.CoreUObject.UObject> AutoConvert_FlowDataPinPropertyClassToClass(UnrealSharp.Flow.FFlowDataPinOutputProperty_Class classProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyClassToClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Class>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyClassToClass_ClassProperty_Offset), 0, classProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyClassToClass_NativeFunction, ParamsBuffer);
            
            TSubclassOf<UnrealSharp.CoreUObject.UObject> returnValue;
            returnValue = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyClassToClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinPropertyClassToSoftClass
    static IntPtr AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction;
    static int AutoConvert_FlowDataPinPropertyClassToSoftClass_ParamsSize;
    static int AutoConvert_FlowDataPinPropertyClassToSoftClass_ClassProperty_Offset;
    static int AutoConvert_FlowDataPinPropertyClassToSoftClass_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Class property values to their FSoftClassPath
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinPropertyClassToSoftClass")]
    public static UnrealSharp.CoreUObject.FSoftClassPath AutoConvert_FlowDataPinPropertyClassToSoftClass(UnrealSharp.Flow.FFlowDataPinOutputProperty_Class classProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinPropertyClassToSoftClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinOutputProperty_Class>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyClassToSoftClass_ClassProperty_Offset), 0, classProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinPropertyClassToSoftClass_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FSoftClassPath returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinPropertyClassToSoftClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultBoolToBool
    static IntPtr AutoConvert_FlowDataPinResultBoolToBool_NativeFunction;
    static int AutoConvert_FlowDataPinResultBoolToBool_ParamsSize;
    static int AutoConvert_FlowDataPinResultBoolToBool_BoolProperty_Offset;
    static int AutoConvert_FlowDataPinResultBoolToBool_ReturnValue_Offset;
    
    /// <summary>
    /// Convert bool property values to their inner blueprint values
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultBoolToBool")]
    public static bool AutoConvert_FlowDataPinResultBoolToBool(UnrealSharp.Flow.FFlowDataPinResult_Bool boolProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultBoolToBool_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultBoolToBool_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Bool>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultBoolToBool_BoolProperty_Offset), 0, boolProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultBoolToBool_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultBoolToBool_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultInt64ToInt32
    static IntPtr AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction;
    static int AutoConvert_FlowDataPinResultInt64ToInt32_ParamsSize;
    static int AutoConvert_FlowDataPinResultInt64ToInt32_IntProperty_Offset;
    static int AutoConvert_FlowDataPinResultInt64ToInt32_ReturnValue_Offset;
    
    /// <summary>
    /// to Int variants for all int types (that blueprint supports
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultInt64ToInt32")]
    public static int AutoConvert_FlowDataPinResultInt64ToInt32(UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultInt64ToInt32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToInt32_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultInt64ToInt32_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToInt32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultInt64ToInt64
    static IntPtr AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction;
    static int AutoConvert_FlowDataPinResultInt64ToInt64_ParamsSize;
    static int AutoConvert_FlowDataPinResultInt64ToInt64_IntProperty_Offset;
    static int AutoConvert_FlowDataPinResultInt64ToInt64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultInt64ToInt64")]
    public static long AutoConvert_FlowDataPinResultInt64ToInt64(UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultInt64ToInt64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToInt64_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultInt64ToInt64_NativeFunction, ParamsBuffer);
            
            long returnValue;
            returnValue = BlittableMarshaller<long>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToInt64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultInt64ToUint8
    static IntPtr AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction;
    static int AutoConvert_FlowDataPinResultInt64ToUint8_ParamsSize;
    static int AutoConvert_FlowDataPinResultInt64ToUint8_IntProperty_Offset;
    static int AutoConvert_FlowDataPinResultInt64ToUint8_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultInt64ToUint8")]
    public static byte AutoConvert_FlowDataPinResultInt64ToUint8(UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultInt64ToUint8_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Int>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToUint8_IntProperty_Offset), 0, intProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultInt64ToUint8_NativeFunction, ParamsBuffer);
            
            byte returnValue;
            returnValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInt64ToUint8_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultFloat64ToFloat32
    static IntPtr AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat32_ParamsSize;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat32_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat32_ReturnValue_Offset;
    
    /// <summary>
    /// to Float variants for all float types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultFloat64ToFloat32")]
    public static float AutoConvert_FlowDataPinResultFloat64ToFloat32(UnrealSharp.Flow.FFlowDataPinResult_Float floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultFloat64ToFloat32_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Float>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultFloat64ToFloat32_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultFloat64ToFloat32_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultFloat64ToFloat32_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultFloat64ToFloat64
    static IntPtr AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat64_ParamsSize;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat64_FloatProperty_Offset;
    static int AutoConvert_FlowDataPinResultFloat64ToFloat64_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultFloat64ToFloat64")]
    public static double AutoConvert_FlowDataPinResultFloat64ToFloat64(UnrealSharp.Flow.FFlowDataPinResult_Float floatProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultFloat64ToFloat64_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Float>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultFloat64ToFloat64_FloatProperty_Offset), 0, floatProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultFloat64ToFloat64_NativeFunction, ParamsBuffer);
            
            double returnValue;
            returnValue = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultFloat64ToFloat64_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultNameToName
    static IntPtr AutoConvert_FlowDataPinResultNameToName_NativeFunction;
    static int AutoConvert_FlowDataPinResultNameToName_ParamsSize;
    static int AutoConvert_FlowDataPinResultNameToName_NameProperty_Offset;
    static int AutoConvert_FlowDataPinResultNameToName_ReturnValue_Offset;
    
    /// <summary>
    /// to Name variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultNameToName")]
    public static FName AutoConvert_FlowDataPinResultNameToName(UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultNameToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultNameToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultNameToName_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultNameToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultNameToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultStringToName
    static IntPtr AutoConvert_FlowDataPinResultStringToName_NativeFunction;
    static int AutoConvert_FlowDataPinResultStringToName_ParamsSize;
    static int AutoConvert_FlowDataPinResultStringToName_StringProperty_Offset;
    static int AutoConvert_FlowDataPinResultStringToName_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultStringToName")]
    public static FName AutoConvert_FlowDataPinResultStringToName(UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultStringToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultStringToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultStringToName_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultStringToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultStringToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultTextToName
    static IntPtr AutoConvert_FlowDataPinResultTextToName_NativeFunction;
    static int AutoConvert_FlowDataPinResultTextToName_ParamsSize;
    static int AutoConvert_FlowDataPinResultTextToName_TextProperty_Offset;
    static int AutoConvert_FlowDataPinResultTextToName_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultTextToName")]
    public static FName AutoConvert_FlowDataPinResultTextToName(UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultTextToName_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultTextToName_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTextToName_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultTextToName_NativeFunction, ParamsBuffer);
            
            FName returnValue;
            returnValue = BlittableMarshaller<FName>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTextToName_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultNameToString
    static IntPtr AutoConvert_FlowDataPinResultNameToString_NativeFunction;
    static int AutoConvert_FlowDataPinResultNameToString_ParamsSize;
    static int AutoConvert_FlowDataPinResultNameToString_NameProperty_Offset;
    static int AutoConvert_FlowDataPinResultNameToString_ReturnValue_Offset;
    
    /// <summary>
    /// to String variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultNameToString")]
    public static string AutoConvert_FlowDataPinResultNameToString(UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultNameToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultNameToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultNameToString_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultNameToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinResultNameToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultStringToString
    static IntPtr AutoConvert_FlowDataPinResultStringToString_NativeFunction;
    static int AutoConvert_FlowDataPinResultStringToString_ParamsSize;
    static int AutoConvert_FlowDataPinResultStringToString_StringProperty_Offset;
    static int AutoConvert_FlowDataPinResultStringToString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultStringToString")]
    public static string AutoConvert_FlowDataPinResultStringToString(UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultStringToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultStringToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultStringToString_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultStringToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinResultStringToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultTextToString
    static IntPtr AutoConvert_FlowDataPinResultTextToString_NativeFunction;
    static int AutoConvert_FlowDataPinResultTextToString_ParamsSize;
    static int AutoConvert_FlowDataPinResultTextToString_TextProperty_Offset;
    static int AutoConvert_FlowDataPinResultTextToString_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultTextToString")]
    public static string AutoConvert_FlowDataPinResultTextToString(UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultTextToString_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultTextToString_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTextToString_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultTextToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AutoConvert_FlowDataPinResultTextToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultNameToText
    static IntPtr AutoConvert_FlowDataPinResultNameToText_NativeFunction;
    static int AutoConvert_FlowDataPinResultNameToText_ParamsSize;
    static int AutoConvert_FlowDataPinResultNameToText_NameProperty_Offset;
    static int AutoConvert_FlowDataPinResultNameToText_ReturnValue_Offset;
    
    /// <summary>
    /// to Text variants for all text-based types
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultNameToText")]
    public static FText AutoConvert_FlowDataPinResultNameToText(UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultNameToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultNameToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Name>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultNameToText_NameProperty_Offset), 0, nameProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultNameToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultNameToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultStringToText
    static IntPtr AutoConvert_FlowDataPinResultStringToText_NativeFunction;
    static int AutoConvert_FlowDataPinResultStringToText_ParamsSize;
    static int AutoConvert_FlowDataPinResultStringToText_StringProperty_Offset;
    static int AutoConvert_FlowDataPinResultStringToText_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultStringToText")]
    public static FText AutoConvert_FlowDataPinResultStringToText(UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultStringToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultStringToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_String>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultStringToText_StringProperty_Offset), 0, stringProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultStringToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultStringToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultTextToText
    static IntPtr AutoConvert_FlowDataPinResultTextToText_NativeFunction;
    static int AutoConvert_FlowDataPinResultTextToText_ParamsSize;
    static int AutoConvert_FlowDataPinResultTextToText_TextProperty_Offset;
    static int AutoConvert_FlowDataPinResultTextToText_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultTextToText")]
    public static FText AutoConvert_FlowDataPinResultTextToText(UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultTextToText_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultTextToText_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Text>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTextToText_TextProperty_Offset), 0, textProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultTextToText_NativeFunction, ParamsBuffer);
            
            FText returnValue;
            returnValue = TextMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTextToText_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultEnumToEnum
    static IntPtr AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction;
    static int AutoConvert_FlowDataPinResultEnumToEnum_ParamsSize;
    static int AutoConvert_FlowDataPinResultEnumToEnum_EnumProperty_Offset;
    static int AutoConvert_FlowDataPinResultEnumToEnum_ReturnValue_Offset;
    
    /// <summary>
    /// Convert enum property values to their inner enum values
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultEnumToEnum")]
    public static byte AutoConvert_FlowDataPinResultEnumToEnum(UnrealSharp.Flow.FFlowDataPinResult_Enum enumProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultEnumToEnum_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Enum>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultEnumToEnum_EnumProperty_Offset), 0, enumProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultEnumToEnum_NativeFunction, ParamsBuffer);
            
            byte returnValue;
            returnValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultEnumToEnum_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultVectorToVector
    static IntPtr AutoConvert_FlowDataPinResultVectorToVector_NativeFunction;
    static int AutoConvert_FlowDataPinResultVectorToVector_ParamsSize;
    static int AutoConvert_FlowDataPinResultVectorToVector_VectorProperty_Offset;
    static int AutoConvert_FlowDataPinResultVectorToVector_ReturnValue_Offset;
    
    /// <summary>
    /// Convert vector property values to their inner Vector
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultVectorToVector")]
    public static UnrealSharp.CoreUObject.FVector AutoConvert_FlowDataPinResultVectorToVector(UnrealSharp.Flow.FFlowDataPinResult_Vector vectorProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultVectorToVector_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultVectorToVector_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Vector>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultVectorToVector_VectorProperty_Offset), 0, vectorProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultVectorToVector_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FVector returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FVector>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultVectorToVector_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultRotatorToRotator
    static IntPtr AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction;
    static int AutoConvert_FlowDataPinResultRotatorToRotator_ParamsSize;
    static int AutoConvert_FlowDataPinResultRotatorToRotator_RotatorProperty_Offset;
    static int AutoConvert_FlowDataPinResultRotatorToRotator_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Rotator property values to their inner Rotator
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultRotatorToRotator")]
    public static UnrealSharp.CoreUObject.FRotator AutoConvert_FlowDataPinResultRotatorToRotator(UnrealSharp.Flow.FFlowDataPinResult_Rotator rotatorProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultRotatorToRotator_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Rotator>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultRotatorToRotator_RotatorProperty_Offset), 0, rotatorProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultRotatorToRotator_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FRotator returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FRotator>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultRotatorToRotator_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultTransformToTransform
    static IntPtr AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction;
    static int AutoConvert_FlowDataPinResultTransformToTransform_ParamsSize;
    static int AutoConvert_FlowDataPinResultTransformToTransform_TransformProperty_Offset;
    static int AutoConvert_FlowDataPinResultTransformToTransform_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Transform property values to their inner Transform
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultTransformToTransform")]
    public static UnrealSharp.CoreUObject.FTransform AutoConvert_FlowDataPinResultTransformToTransform(UnrealSharp.Flow.FFlowDataPinResult_Transform transformProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultTransformToTransform_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Transform>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTransformToTransform_TransformProperty_Offset), 0, transformProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultTransformToTransform_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FTransform returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FTransform>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultTransformToTransform_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultGameplayTagToGameplayTag
    static IntPtr AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ParamsSize;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_GameplayTagProperty_Offset;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ReturnValue_Offset;
    
    /// <summary>
    /// Convert GameplayTag property values to their inner GameplayTag
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultGameplayTagToGameplayTag")]
    public static UnrealSharp.GameplayTags.FGameplayTag AutoConvert_FlowDataPinResultGameplayTagToGameplayTag(UnrealSharp.Flow.FFlowDataPinResult_GameplayTag gameplayTagProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_GameplayTagProperty_Offset), 0, gameplayTagProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTag returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagToGameplayTag_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer
    static IntPtr AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ParamsSize;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset;
    static int AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ReturnValue_Offset;
    
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer")]
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinResult_GameplayTag gameplayTagProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTag>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_GameplayTagProperty_Offset), 0, gameplayTagProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer
    static IntPtr AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction;
    static int AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ParamsSize;
    static int AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset;
    static int AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset;
    
    /// <summary>
    /// Convert GameplayTagContainer property values to their inner GameplayTagContainer
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer")]
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer gameplayTagContainerProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_GameplayTagContainerProperty_Offset), 0, gameplayTagContainerProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GameplayTags.FGameplayTagContainer returnValue;
            returnValue = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct
    static IntPtr AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction;
    static int AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ParamsSize;
    static int AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_InstancedStructProperty_Offset;
    static int AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ReturnValue_Offset;
    
    /// <summary>
    /// Convert InstancedStruct property values to their inner InstancedStruct
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct")]
    public static UnrealSharp.CoreUObject.FInstancedStruct AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct(UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct instancedStructProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_InstancedStructProperty_Offset), 0, instancedStructProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FInstancedStruct returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FInstancedStruct>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultObjectToObject
    static IntPtr AutoConvert_FlowDataPinResultObjectToObject_NativeFunction;
    static int AutoConvert_FlowDataPinResultObjectToObject_ParamsSize;
    static int AutoConvert_FlowDataPinResultObjectToObject_ObjectProperty_Offset;
    static int AutoConvert_FlowDataPinResultObjectToObject_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Object property values to their inner Object
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultObjectToObject")]
    public static UnrealSharp.CoreUObject.UObject AutoConvert_FlowDataPinResultObjectToObject(UnrealSharp.Flow.FFlowDataPinResult_Object objectProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultObjectToObject_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultObjectToObject_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Object>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultObjectToObject_ObjectProperty_Offset), 0, objectProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultObjectToObject_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.UObject returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultObjectToObject_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultClassToClass
    static IntPtr AutoConvert_FlowDataPinResultClassToClass_NativeFunction;
    static int AutoConvert_FlowDataPinResultClassToClass_ParamsSize;
    static int AutoConvert_FlowDataPinResultClassToClass_ClassProperty_Offset;
    static int AutoConvert_FlowDataPinResultClassToClass_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Class property values to their inner Class
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultClassToClass")]
    public static TSubclassOf<UnrealSharp.CoreUObject.UObject> AutoConvert_FlowDataPinResultClassToClass(UnrealSharp.Flow.FFlowDataPinResult_Class classProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultClassToClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultClassToClass_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Class>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultClassToClass_ClassProperty_Offset), 0, classProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultClassToClass_NativeFunction, ParamsBuffer);
            
            TSubclassOf<UnrealSharp.CoreUObject.UObject> returnValue;
            returnValue = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultClassToClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // AutoConvert_FlowDataPinResultClassToSoftClass
    static IntPtr AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction;
    static int AutoConvert_FlowDataPinResultClassToSoftClass_ParamsSize;
    static int AutoConvert_FlowDataPinResultClassToSoftClass_ClassProperty_Offset;
    static int AutoConvert_FlowDataPinResultClassToSoftClass_ReturnValue_Offset;
    
    /// <summary>
    /// Convert Class property values to their the FSoftClassPath
    /// </summary>
    [UFunction, GeneratedType("AutoConvert_FlowDataPinResultClassToSoftClass")]
    public static UnrealSharp.CoreUObject.FSoftClassPath AutoConvert_FlowDataPinResultClassToSoftClass(UnrealSharp.Flow.FFlowDataPinResult_Class classProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AutoConvert_FlowDataPinResultClassToSoftClass_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction, ParamsBuffer);
            StructMarshaller<UnrealSharp.Flow.FFlowDataPinResult_Class>.ToNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultClassToSoftClass_ClassProperty_Offset), 0, classProperty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AutoConvert_FlowDataPinResultClassToSoftClass_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FSoftClassPath returnValue;
            returnValue = StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.FromNative(IntPtr.Add(ParamsBuffer, AutoConvert_FlowDataPinResultClassToSoftClass_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    
}