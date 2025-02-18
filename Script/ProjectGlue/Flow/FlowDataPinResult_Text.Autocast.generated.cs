using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Text
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinResult_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinResult_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinResult_Text value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTextToText(value);
}