using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_InstancedStruct
{
    public static implicit operator UnrealSharp.CoreUObject.FInstancedStruct(UnrealSharp.Flow.FFlowDataPinOutputProperty_InstancedStruct value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyInstancedStructToInstancedStruct(value);
}