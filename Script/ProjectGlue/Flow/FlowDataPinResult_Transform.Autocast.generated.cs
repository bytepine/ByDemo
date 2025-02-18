using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Transform
{
    public static implicit operator UnrealSharp.CoreUObject.FTransform(UnrealSharp.Flow.FFlowDataPinResult_Transform value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultTransformToTransform(value);
}