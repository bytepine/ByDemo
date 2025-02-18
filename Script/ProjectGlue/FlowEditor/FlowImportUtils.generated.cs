using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Groundwork for converting blueprint graphs to Flow Graph.
/// It's NOT meant to be universal, out-of-box solution as complexity of blueprint graphs conflicts with simplicity of Flow Graph.
/// However, it might useful to provide this basic utility to anyone who would like to batch-convert their custom blueprint-based event system to Flow Graph.
/// Pull requests are welcome if you able to improve this utility w/o with minimal amount of code.
/// </summary>
[UClass, GeneratedType("FlowImportUtils", "UnrealSharp.FlowEditor.FlowImportUtils")]
public partial class FlowImportUtils : UnrealSharp.Engine.UBlueprintFunctionLibrary
{
    static readonly IntPtr NativeClassPtr;
    static FlowImportUtils()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowImportUtils");
        ImportBlueprintGraph_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ImportBlueprintGraph");
        ImportBlueprintGraph_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ImportBlueprintGraph_NativeFunction);
        ImportBlueprintGraph_BlueprintAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "BlueprintAsset");
        ImportBlueprintGraph_FlowAssetClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "FlowAssetClass");
        ImportBlueprintGraph_FlowAssetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "FlowAssetName");
        ImportBlueprintGraph_InFunctionsToFlowNodes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "InFunctionsToFlowNodes");
        ImportBlueprintGraph_InFunctionsToFlowNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(ImportBlueprintGraph_NativeFunction, "InFunctionsToFlowNodes");
        ImportBlueprintGraph_InPinMappings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "InPinMappings");
        ImportBlueprintGraph_InPinMappings_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(ImportBlueprintGraph_NativeFunction, "InPinMappings");
        ImportBlueprintGraph_StartEventName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "StartEventName");
        ImportBlueprintGraph_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ImportBlueprintGraph_NativeFunction, "ReturnValue");
    }
    // ImportBlueprintGraph
    static IntPtr ImportBlueprintGraph_NativeFunction;
    static int ImportBlueprintGraph_ParamsSize;
    static int ImportBlueprintGraph_BlueprintAsset_Offset;
    static int ImportBlueprintGraph_FlowAssetClass_Offset;
    static int ImportBlueprintGraph_FlowAssetName_Offset;
    static int ImportBlueprintGraph_InFunctionsToFlowNodes_Offset;
    static IntPtr ImportBlueprintGraph_InFunctionsToFlowNodes_NativeProperty;
    static MapCopyMarshaller<FName, TSubclassOf<UnrealSharp.Flow.UFlowNode>> ImportBlueprintGraph_InFunctionsToFlowNodes_Marshaller = null;
    static int ImportBlueprintGraph_InPinMappings_Offset;
    static IntPtr ImportBlueprintGraph_InPinMappings_NativeProperty;
    static MapCopyMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.FlowEditor.FBlueprintToFlowPinName> ImportBlueprintGraph_InPinMappings_Marshaller = null;
    static int ImportBlueprintGraph_StartEventName_Offset;
    static int ImportBlueprintGraph_ReturnValue_Offset;
    
    public static UnrealSharp.Flow.UFlowAsset ImportBlueprintGraph(UnrealSharp.CoreUObject.UObject blueprintAsset, TSubclassOf<UnrealSharp.Flow.UFlowAsset> flowAssetClass, string flowAssetName, System.Collections.Generic.IDictionary<FName, TSubclassOf<UnrealSharp.Flow.UFlowNode>> functionsToFlowNodes, System.Collections.Generic.IDictionary<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.FlowEditor.FBlueprintToFlowPinName> pinMappings)
    {
        FName startEventName = new FName("BeginPlay");
        return ImportBlueprintGraph(blueprintAsset, flowAssetClass, flowAssetName, functionsToFlowNodes, pinMappings, startEventName);
    }
    
    [UFunction, GeneratedType("ImportBlueprintGraph")]
    public static UnrealSharp.Flow.UFlowAsset ImportBlueprintGraph(UnrealSharp.CoreUObject.UObject blueprintAsset, TSubclassOf<UnrealSharp.Flow.UFlowAsset> flowAssetClass, string flowAssetName, System.Collections.Generic.IDictionary<FName, TSubclassOf<UnrealSharp.Flow.UFlowNode>> functionsToFlowNodes, System.Collections.Generic.IDictionary<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.FlowEditor.FBlueprintToFlowPinName> pinMappings, FName startEventName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ImportBlueprintGraph_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(ImportBlueprintGraph_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_BlueprintAsset_Offset), 0, blueprintAsset);
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_FlowAssetClass_Offset), 0, flowAssetClass);
            IntPtr FlowAssetName_NativePtr = IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_FlowAssetName_Offset);
            StringMarshaller.ToNative(FlowAssetName_NativePtr,0,flowAssetName);
            ImportBlueprintGraph_InFunctionsToFlowNodes_Marshaller ??= new MapCopyMarshaller<FName, TSubclassOf<UnrealSharp.Flow.UFlowNode>>(ImportBlueprintGraph_InFunctionsToFlowNodes_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
            IntPtr ImportBlueprintGraph_InFunctionsToFlowNodes_NativeProperty_NativeBuffer = IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_InFunctionsToFlowNodes_Offset);
            ImportBlueprintGraph_InFunctionsToFlowNodes_Marshaller.ToNative(ImportBlueprintGraph_InFunctionsToFlowNodes_NativeProperty_NativeBuffer, 0, functionsToFlowNodes);
            ImportBlueprintGraph_InPinMappings_Marshaller ??= new MapCopyMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.FlowEditor.FBlueprintToFlowPinName>(ImportBlueprintGraph_InPinMappings_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative, StructMarshaller<UnrealSharp.FlowEditor.FBlueprintToFlowPinName>.ToNative, StructMarshaller<UnrealSharp.FlowEditor.FBlueprintToFlowPinName>.FromNative);
            IntPtr ImportBlueprintGraph_InPinMappings_NativeProperty_NativeBuffer = IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_InPinMappings_Offset);
            ImportBlueprintGraph_InPinMappings_Marshaller.ToNative(ImportBlueprintGraph_InPinMappings_NativeProperty_NativeBuffer, 0, pinMappings);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_StartEventName_Offset), 0, startEventName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ImportBlueprintGraph_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.UFlowAsset returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(ParamsBuffer, ImportBlueprintGraph_ReturnValue_Offset), 0);
            
            StringMarshaller.DestructInstance(FlowAssetName_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}