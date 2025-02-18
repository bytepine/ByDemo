using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Bool
{
    public static implicit operator bool(UnrealSharp.Flow.FFlowDataPinResult_Bool value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultBoolToBool(value);
}