using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Transform
{
    public static implicit operator UnrealSharp.CoreUObject.FTransform(UnrealSharp.Flow.FFlowDataPinOutputProperty_Transform value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyTransformToTransform(value);
}