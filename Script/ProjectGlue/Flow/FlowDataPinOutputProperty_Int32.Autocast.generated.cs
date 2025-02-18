using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Int32
{
    public static implicit operator int(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt32ToInt32(value);
    public static implicit operator long(UnrealSharp.Flow.FFlowDataPinOutputProperty_Int32 value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInt32ToInt64(value);
}