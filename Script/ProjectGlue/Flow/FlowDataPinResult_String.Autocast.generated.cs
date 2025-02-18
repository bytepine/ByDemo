using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_String
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinResult_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinResult_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinResult_String value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultStringToText(value);
}