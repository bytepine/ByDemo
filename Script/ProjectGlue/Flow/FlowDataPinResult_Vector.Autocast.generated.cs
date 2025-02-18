using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Vector
{
    public static implicit operator UnrealSharp.CoreUObject.FVector(UnrealSharp.Flow.FFlowDataPinResult_Vector value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultVectorToVector(value);
}