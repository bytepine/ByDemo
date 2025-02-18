using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Rotator
{
    public static implicit operator UnrealSharp.CoreUObject.FRotator(UnrealSharp.Flow.FFlowDataPinOutputProperty_Rotator value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyRotatorToRotator(value);
}