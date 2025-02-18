using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Enum
{
    public static implicit operator byte(UnrealSharp.Flow.FFlowDataPinResult_Enum value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultEnumToEnum(value);
}