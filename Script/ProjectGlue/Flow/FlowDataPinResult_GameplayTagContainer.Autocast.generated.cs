using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_GameplayTagContainer
{
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinResult_GameplayTagContainer value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagContainerToGameplayTagContainer(value);
}