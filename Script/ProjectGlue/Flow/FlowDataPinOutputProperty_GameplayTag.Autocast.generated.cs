using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_GameplayTag
{
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTag(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTag(value);
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTag value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagToGameplayTagContainer(value);
}