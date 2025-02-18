using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_String
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinOutputProperty_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinOutputProperty_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinOutputProperty_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyStringToText(value);
}