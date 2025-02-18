using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Name
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinResult_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinResult_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinResult_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultNameToText(value);
}