using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass, GeneratedType("FlowAssetEditorContext", "UnrealSharp.FlowEditor.FlowAssetEditorContext")]
public partial class UFlowAssetEditorContext : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UFlowAssetEditorContext()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowAssetEditorContext");
        GetFlowAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowAsset");
        GetFlowAsset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowAsset_NativeFunction);
        GetFlowAsset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowAsset_NativeFunction, "ReturnValue");
    }
    
    // GetFlowAsset
    static IntPtr GetFlowAsset_NativeFunction;
    static int GetFlowAsset_ParamsSize;
    static int GetFlowAsset_ReturnValue_Offset;
    
    public UnrealSharp.Flow.UFlowAsset FlowAsset
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetFlowAsset_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetFlowAsset_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowAsset_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowAsset returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(ParamsBuffer, GetFlowAsset_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    
}