using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinOutputProperty_Class
{
    public static implicit operator TSubclassOf<UnrealSharp.CoreUObject.UObject>(UnrealSharp.Flow.FFlowDataPinOutputProperty_Class value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyClassToClass(value);
    public static implicit operator UnrealSharp.CoreUObject.FSoftClassPath(UnrealSharp.Flow.FFlowDataPinOutputProperty_Class value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinPropertyClassToSoftClass(value);
}