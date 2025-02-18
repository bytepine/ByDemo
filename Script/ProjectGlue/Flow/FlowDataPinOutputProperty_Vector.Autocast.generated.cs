using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Vector
{
    public static implicit operator UnrealSharp.CoreUObject.FVector(UnrealSharp.Flow.FFlowDataPinOutputProperty_Vector value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyVectorToVector(value);
}