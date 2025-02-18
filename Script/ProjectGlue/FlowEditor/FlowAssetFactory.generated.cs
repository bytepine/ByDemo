using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass, GeneratedType("FlowAssetFactory", "UnrealSharp.FlowEditor.FlowAssetFactory")]
public partial class UFlowAssetFactory : UnrealSharp.UnrealEd.UFactory
{
    static readonly IntPtr NativeClassPtr;
    static UFlowAssetFactory()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowAssetFactory");
        IntPtr AssetClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AssetClass");
        AssetClass_Offset = FPropertyExporter.CallGetPropertyOffset(AssetClass_NativeProperty);
    }
    
    static int AssetClass_Offset;
    
    public TSubclassOf<UnrealSharp.Flow.UFlowAsset> AssetClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, AssetClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(NativeObject, AssetClass_Offset), 0, value);
        }
    }
    
    
}