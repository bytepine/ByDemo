using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_InstancedStruct
{
    public static implicit operator UnrealSharp.CoreUObject.FInstancedStruct(UnrealSharp.Flow.FFlowDataPinResult_InstancedStruct value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultInstancedStructToInstancedStruct(value);
}