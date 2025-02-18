using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Float
{
    public static implicit operator float(UnrealSharp.Flow.FFlowDataPinResult_Float value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultFloat64ToFloat32(value);
    public static implicit operator double(UnrealSharp.Flow.FFlowDataPinResult_Float value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultFloat64ToFloat64(value);
}