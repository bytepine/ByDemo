using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UInterface, GeneratedType("FlowDataPinValueSupplierInterface")]
public partial interface IFlowDataPinValueSupplierInterface
{
    /// <summary>
    /// Can this node actually supply Data Pin values?
    /// Implementers of this interface will need to use their own logic to answer this question.
    /// </summary>
    [UFunction, GeneratedType("CanSupplyDataPinValues")]
    public bool CanSupplyDataPinValues();
    /// <summary>
    /// Try to supply the value for a data Bool pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsBool")]
    public UnrealSharp.Flow.FFlowDataPinResult_Bool TrySupplyDataPinAsBool(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Int pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsInt")]
    public UnrealSharp.Flow.FFlowDataPinResult_Int TrySupplyDataPinAsInt(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Float pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsFloat")]
    public UnrealSharp.Flow.FFlowDataPinResult_Float TrySupplyDataPinAsFloat(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Name pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsName")]
    public UnrealSharp.Flow.FFlowDataPinResult_Name TrySupplyDataPinAsName(FName pinName);
    /// <summary>
    /// Try to supply the value for a data String pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsString")]
    public UnrealSharp.Flow.FFlowDataPinResult_String TrySupplyDataPinAsString(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Text pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsText")]
    public UnrealSharp.Flow.FFlowDataPinResult_Text TrySupplyDataPinAsText(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Enum pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsEnum")]
    public UnrealSharp.Flow.FFlowDataPinResult_Enum TrySupplyDataPinAsEnum(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Vector pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsVector")]
    public UnrealSharp.Flow.FFlowDataPinResult_Vector TrySupplyDataPinAsVector(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Rotator pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsRotator")]
    public UnrealSharp.Flow.FFlowDataPinResult_Rotator TrySupplyDataPinAsRotator(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Transform pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsTransform")]
    public UnrealSharp.Flow.FFlowDataPinResult_Transform TrySupplyDataPinAsTransform(FName pinName);
    /// <summary>
    /// Try to supply the value for a data GameplayTag pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsGameplayTag")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTag TrySupplyDataPinAsGameplayTag(FName pinName);
    /// <summary>
    /// Try to supply the value for a data GameplayTagContainer pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsGameplayTagContainer")]
    public UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer TrySupplyDataPinAsGameplayTagContainer(FName pinName);
    /// <summary>
    /// Try to supply the value for a data InstancedStruct pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsInstancedStruct")]
    public UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct TrySupplyDataPinAsInstancedStruct(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Object pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsObject")]
    public UnrealSharp.Flow.FFlowDataPinResult_Object TrySupplyDataPinAsObject(FName pinName);
    /// <summary>
    /// Try to supply the value for a data Class pin
    /// </summary>
    [UFunction, GeneratedType("TrySupplyDataPinAsClass")]
    public UnrealSharp.Flow.FFlowDataPinResult_Class TrySupplyDataPinAsClass(FName pinName);
}

public static class IFlowDataPinValueSupplierInterfaceMarshaller
{
    static readonly IntPtr NativeInterfaceClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowDataPinValueSupplierInterface");
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IFlowDataPinValueSupplierInterface obj)
    {
        UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinValueSupplierInterface>.ToNative(nativeBuffer, arrayIndex, obj, NativeInterfaceClassPtr);
    }
    
    public static IFlowDataPinValueSupplierInterface FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return UnrealSharp.CoreUObject.ScriptInterfaceMarshaller<IFlowDataPinValueSupplierInterface>.FromNative(nativeBuffer, arrayIndex);
    }
}