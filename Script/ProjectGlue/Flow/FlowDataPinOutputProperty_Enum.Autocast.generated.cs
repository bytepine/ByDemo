using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Enum
{
    public static implicit operator byte(UnrealSharp.Flow.FFlowDataPinOutputProperty_Enum value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyEnumToEnum(value);
}