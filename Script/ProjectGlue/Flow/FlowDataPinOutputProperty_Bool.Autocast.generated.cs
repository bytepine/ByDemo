using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Bool
{
    public static implicit operator bool(UnrealSharp.Flow.FFlowDataPinOutputProperty_Bool value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyBoolToBool(value);
}