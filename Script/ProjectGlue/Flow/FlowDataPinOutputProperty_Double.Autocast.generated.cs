using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Double
{
    public static implicit operator float(UnrealSharp.Flow.FFlowDataPinOutputProperty_Double value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat64ToFloat32(value);
    public static implicit operator double(UnrealSharp.Flow.FFlowDataPinOutputProperty_Double value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyFloat64ToFloat64(value);
}