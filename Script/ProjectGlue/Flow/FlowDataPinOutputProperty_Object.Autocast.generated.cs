using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Object
{
    public static implicit operator UnrealSharp.CoreUObject.UObject(UnrealSharp.Flow.FFlowDataPinOutputProperty_Object value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyObjectToObject(value);
}