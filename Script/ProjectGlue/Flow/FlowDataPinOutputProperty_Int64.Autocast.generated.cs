using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Int64
{
    public static implicit operator int(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt64ToInt32(value);
    public static implicit operator long(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int64 value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt64ToInt64(value);
}