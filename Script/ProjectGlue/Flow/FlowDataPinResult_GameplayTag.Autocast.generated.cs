using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_GameplayTag
{
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTag(UnrealSharp.Flow.FFlowDataPinResult_GameplayTag value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagToGameplayTag(value);
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinResult_GameplayTag value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultGameplayTagToGameplayTagContainer(value);
}