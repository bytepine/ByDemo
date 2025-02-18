using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Text
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinOutputProperty_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTextToText(value);
}