using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Name
{
    public static implicit operator FName(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToName(value);
    public static implicit operator string(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToString(value);
    public static implicit operator FText(UnrealSharp.Flow.FFlowDataPinOutputProperty_Name value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyNameToText(value);
}