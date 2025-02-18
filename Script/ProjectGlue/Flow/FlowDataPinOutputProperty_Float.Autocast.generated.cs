using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Float
{
    public static implicit operator float(UnrealSharp.Flow.FFlowDataPinOutputProperty_Float value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat32ToFloat32(value);
    public static implicit operator double(UnrealSharp.Flow.FFlowDataPinOutputProperty_Float value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat32ToFloat64(value);
}