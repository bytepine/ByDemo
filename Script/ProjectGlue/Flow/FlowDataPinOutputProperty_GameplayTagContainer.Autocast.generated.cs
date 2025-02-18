using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_GameplayTagContainer
{
    public static implicit operator UnrealSharp.GameplayTags.FGameplayTagContainer(UnrealSharp.Flow.FFlowDataPinOutputProperty_GameplayTagContainer value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyGameplayTagContainerToGameplayTagContainer(value);
}