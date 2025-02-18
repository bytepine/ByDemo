using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public static class FlowDataPinBlueprintLibrary_Extensions
{
    
    /// <summary>
    /// Convert bool property values to their inner blue values
    /// </summary>
    public static bool AutoConvert_FlowDataPinPropertyBoolToBool(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Bool boolProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyBoolToBool(boolProperty);
    }
    
    /// <summary>
    /// to Int variants for all int types
    /// </summary>
    public static int AutoConvert_FlowDataPinPropertyInt32ToInt32(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt32ToInt32(intProperty);
    }
    
    public static long AutoConvert_FlowDataPinPropertyInt32ToInt64(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt32ToInt64(intProperty);
    }
    
    public static int AutoConvert_FlowDataPinPropertyInt64ToInt32(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt64ToInt32(intProperty);
    }
    
    public static long AutoConvert_FlowDataPinPropertyInt64ToInt64(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt64ToInt64(intProperty);
    }
    
    /// <summary>
    /// to Float variants for all float types
    /// </summary>
    public static float AutoConvert_FlowDataPinPropertyFloat32ToFloat32(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Float floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat32ToFloat32(floatProperty);
    }
    
    public static double AutoConvert_FlowDataPinPropertyFloat32ToFloat64(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Float floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat32ToFloat64(floatProperty);
    }
    
    public static float AutoConvert_FlowDataPinPropertyFloat64ToFloat32(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Double floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat64ToFloat32(floatProperty);
    }
    
    public static double AutoConvert_FlowDataPinPropertyFloat64ToFloat64(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Double floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat64ToFloat64(floatProperty);
    }
    
    /// <summary>
    /// to Name variants for all text-based types
    /// </summary>
    public static FName AutoConvert_FlowDataPinPropertyNameToName(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToName(nameProperty);
    }
    
    public static FName AutoConvert_FlowDataPinPropertyStringToName(this UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToName(stringProperty);
    }
    
    public static FName AutoConvert_FlowDataPinPropertyTextToName(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToName(textProperty);
    }
    
    /// <summary>
    /// to String variants for all text-based types
    /// </summary>
    public static string AutoConvert_FlowDataPinPropertyNameToString(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToString(nameProperty);
    }
    
    public static string AutoConvert_FlowDataPinPropertyStringToString(this UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToString(stringProperty);
    }
    
    public static string AutoConvert_FlowDataPinPropertyTextToString(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToString(textProperty);
    }
    
    /// <summary>
    /// to Text variants for all text-based types
    /// </summary>
    public static FText AutoConvert_FlowDataPinPropertyNameToText(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToText(nameProperty);
    }
    
    public static FText AutoConvert_FlowDataPinPropertyStringToText(this UnrealSharp.Flow.FFlowDataPinOutputProperty_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToText(stringProperty);
    }
    
    public static FText AutoConvert_FlowDataPinPropertyTextToText(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToText(textProperty);
    }
    
    /// <summary>
    /// Convert enum property values to their inner enum values
    /// </summary>
    public static byte AutoConvert_FlowDataPinPropertyEnumToEnum(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Enum enumProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyEnumToEnum(enumProperty);
    }
    
    /// <summary>
    /// Convert vector property values to their inner Vector
    /// </summary>
    public static UnrealSharp.CoreUObject.FVector AutoConvert_FlowDataPinPropertyVectorToVector(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Vector vectorProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyVectorToVector(vectorProperty);
    }
    
    /// <summary>
    /// Convert Rotator property values to their inner Rotator
    /// </summary>
    public static UnrealSharp.CoreUObject.FRotator AutoConvert_FlowDataPinPropertyRotatorToRotator(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Rotator rotatorProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyRotatorToRotator(rotatorProperty);
    }
    
    /// <summary>
    /// Convert Transform property values to their inner Transform
    /// </summary>
    public static UnrealSharp.CoreUObject.FTransform AutoConvert_FlowDataPinPropertyTransformToTransform(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Transform transformProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTransformToTransform(transformProperty);
    }
    
    /// <summary>
    /// Convert GameplayTag property values to their inner GameplayTag
    /// </summary>
    public static UnrealSharp.GameplayTags.FGameplayTag AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag(this UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag gameplayTagProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag(gameplayTagProperty);
    }
    
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer(this UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag gameplayTagProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer(gameplayTagProperty);
    }
    
    /// <summary>
    /// Convert GameplayTagContainer property values to their inner GameplayTagContainer
    /// </summary>
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer(this UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTagContainer gameplayTagContainerProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer(gameplayTagContainerProperty);
    }
    
    /// <summary>
    /// Convert InstancedStruct property values to their inner InstancedStruct
    /// </summary>
    public static UnrealSharp.CoreUObject.FInstancedStruct AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct(this UnrealSharp.Flow.FFlowDataPinOutputProperty_InstancedStruct instancedStructProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct(instancedStructProperty);
    }
    
    /// <summary>
    /// Convert Object property values to their inner Object
    /// </summary>
    public static UnrealSharp.CoreUObject.UObject AutoConvert_FlowDataPinPropertyObjectToObject(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Object objectProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyObjectToObject(objectProperty);
    }
    
    /// <summary>
    /// Convert Class property values to their inner Class
    /// </summary>
    public static TSubclassOf<UnrealSharp.CoreUObject.UObject> AutoConvert_FlowDataPinPropertyClassToClass(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Class classProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyClassToClass(classProperty);
    }
    
    /// <summary>
    /// Convert Class property values to their FSoftClassPath
    /// </summary>
    public static UnrealSharp.CoreUObject.FSoftClassPath AutoConvert_FlowDataPinPropertyClassToSoftClass(this UnrealSharp.Flow.FFlowDataPinOutputProperty_Class classProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyClassToSoftClass(classProperty);
    }
    
    /// <summary>
    /// Convert bool property values to their inner blueprint values
    /// </summary>
    public static bool AutoConvert_FlowDataPinResultBoolToBool(this UnrealSharp.Flow.FFlowDataPinResult_Bool boolProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultBoolToBool(boolProperty);
    }
    
    /// <summary>
    /// to Int variants for all int types (that blueprint supports
    /// </summary>
    public static int AutoConvert_FlowDataPinResultInt64ToInt32(this UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToInt32(intProperty);
    }
    
    public static long AutoConvert_FlowDataPinResultInt64ToInt64(this UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToInt64(intProperty);
    }
    
    public static byte AutoConvert_FlowDataPinResultInt64ToUint8(this UnrealSharp.Flow.FFlowDataPinResult_Int intProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToUint8(intProperty);
    }
    
    /// <summary>
    /// to Float variants for all float types
    /// </summary>
    public static float AutoConvert_FlowDataPinResultFloat64ToFloat32(this UnrealSharp.Flow.FFlowDataPinResult_Float floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultFloat64ToFloat32(floatProperty);
    }
    
    public static double AutoConvert_FlowDataPinResultFloat64ToFloat64(this UnrealSharp.Flow.FFlowDataPinResult_Float floatProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultFloat64ToFloat64(floatProperty);
    }
    
    /// <summary>
    /// to Name variants for all text-based types
    /// </summary>
    public static FName AutoConvert_FlowDataPinResultNameToName(this UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToName(nameProperty);
    }
    
    public static FName AutoConvert_FlowDataPinResultStringToName(this UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToName(stringProperty);
    }
    
    public static FName AutoConvert_FlowDataPinResultTextToName(this UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToName(textProperty);
    }
    
    /// <summary>
    /// to String variants for all text-based types
    /// </summary>
    public static string AutoConvert_FlowDataPinResultNameToString(this UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToString(nameProperty);
    }
    
    public static string AutoConvert_FlowDataPinResultStringToString(this UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToString(stringProperty);
    }
    
    public static string AutoConvert_FlowDataPinResultTextToString(this UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToString(textProperty);
    }
    
    /// <summary>
    /// to Text variants for all text-based types
    /// </summary>
    public static FText AutoConvert_FlowDataPinResultNameToText(this UnrealSharp.Flow.FFlowDataPinResult_Name nameProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToText(nameProperty);
    }
    
    public static FText AutoConvert_FlowDataPinResultStringToText(this UnrealSharp.Flow.FFlowDataPinResult_String stringProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToText(stringProperty);
    }
    
    public static FText AutoConvert_FlowDataPinResultTextToText(this UnrealSharp.Flow.FFlowDataPinResult_Text textProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToText(textProperty);
    }
    
    /// <summary>
    /// Convert enum property values to their inner enum values
    /// </summary>
    public static byte AutoConvert_FlowDataPinResultEnumToEnum(this UnrealSharp.Flow.FFlowDataPinResult_Enum enumProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultEnumToEnum(enumProperty);
    }
    
    /// <summary>
    /// Convert vector property values to their inner Vector
    /// </summary>
    public static UnrealSharp.CoreUObject.FVector AutoConvert_FlowDataPinResultVectorToVector(this UnrealSharp.Flow.FFlowDataPinResult_Vector vectorProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultVectorToVector(vectorProperty);
    }
    
    /// <summary>
    /// Convert Rotator property values to their inner Rotator
    /// </summary>
    public static UnrealSharp.CoreUObject.FRotator AutoConvert_FlowDataPinResultRotatorToRotator(this UnrealSharp.Flow.FFlowDataPinResult_Rotator rotatorProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultRotatorToRotator(rotatorProperty);
    }
    
    /// <summary>
    /// Convert Transform property values to their inner Transform
    /// </summary>
    public static UnrealSharp.CoreUObject.FTransform AutoConvert_FlowDataPinResultTransformToTransform(this UnrealSharp.Flow.FFlowDataPinResult_Transform transformProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTransformToTransform(transformProperty);
    }
    
    /// <summary>
    /// Convert GameplayTag property values to their inner GameplayTag
    /// </summary>
    public static UnrealSharp.GameplayTags.FGameplayTag AutoConvert_FlowDataPinResultGameplayTagToGameplayTag(this UnrealSharp.Flow.FFlowDataPinResult_GameplayTag gameplayTagProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagToGameplayTag(gameplayTagProperty);
    }
    
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer(this UnrealSharp.Flow.FFlowDataPinResult_GameplayTag gameplayTagProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer(gameplayTagProperty);
    }
    
    /// <summary>
    /// Convert GameplayTagContainer property values to their inner GameplayTagContainer
    /// </summary>
    public static UnrealSharp.GameplayTags.FGameplayTagContainer AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer(this UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer gameplayTagContainerProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer(gameplayTagContainerProperty);
    }
    
    /// <summary>
    /// Convert InstancedStruct property values to their inner InstancedStruct
    /// </summary>
    public static UnrealSharp.CoreUObject.FInstancedStruct AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct(this UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct instancedStructProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct(instancedStructProperty);
    }
    
    /// <summary>
    /// Convert Object property values to their inner Object
    /// </summary>
    public static UnrealSharp.CoreUObject.UObject AutoConvert_FlowDataPinResultObjectToObject(this UnrealSharp.Flow.FFlowDataPinResult_Object objectProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultObjectToObject(objectProperty);
    }
    
    /// <summary>
    /// Convert Class property values to their inner Class
    /// </summary>
    public static TSubclassOf<UnrealSharp.CoreUObject.UObject> AutoConvert_FlowDataPinResultClassToClass(this UnrealSharp.Flow.FFlowDataPinResult_Class classProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultClassToClass(classProperty);
    }
    
    /// <summary>
    /// Convert Class property values to their the FSoftClassPath
    /// </summary>
    public static UnrealSharp.CoreUObject.FSoftClassPath AutoConvert_FlowDataPinResultClassToSoftClass(this UnrealSharp.Flow.FFlowDataPinResult_Class classProperty)
    {
        return UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultClassToSoftClass(classProperty);
    }
}