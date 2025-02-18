using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Int
{
    public static implicit operator int(UnrealSharp.Flow.FFlowDataPinResult_Int value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToInt32(value);
    public static implicit operator long(UnrealSharp.Flow.FFlowDataPinResult_Int value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToInt64(value);
    public static implicit operator byte(UnrealSharp.Flow.FFlowDataPinResult_Int value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInt64ToUint8(value);
}