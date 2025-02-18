using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

public partial struct FFlowDataPinResult_Class
{
    public static implicit operator TSubclassOf<UnrealSharp.CoreUObject.UObject>(UnrealSharp.Flow.FFlowDataPinResult_Class value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultClassToClass(value);
    public static implicit operator UnrealSharp.CoreUObject.FSoftClassPath(UnrealSharp.Flow.FFlowDataPinResult_Class value) => UnrealSharp.Flow.UFlowDataPinBlueprintLibrary.AutoConvert_FlowDataPinResultClassToSoftClass(value);
}