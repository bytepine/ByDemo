using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Rotator
{
    public static implicit operator UnrealSharp.CoreUObject.FRotator(UnrealSharp.Flow.FFlowDataPinResult_Rotator value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultRotatorToRotator(value);
}