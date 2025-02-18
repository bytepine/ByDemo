using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Object
{
    public static implicit operator UnrealSharp.CoreUObject.UObject(UnrealSharp.Flow.FFlowDataPinResult_Object value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultObjectToObject(value);
}