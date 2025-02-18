using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Creates instance of provided Flow Asset and starts its execution
/// </summary>
[UClass, GeneratedType("FlowNode_SubGraph", "UnrealSharp.Flow.FlowNode_SubGraph")]
public partial class UFlowNode_SubGraph : UnrealSharp.Flow.UFlowNode, UnrealSharp.Flow.IFlowDataPinGeneratorNodeInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_SubGraph()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_SubGraph");
        IntPtr Asset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Asset");
        Asset_Offset = FPropertyExporter.CallGetPropertyOffset(Asset_NativeProperty);
        IntPtr bCanInstanceIdenticalAsset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanInstanceIdenticalAsset");
        bCanInstanceIdenticalAsset_Offset = FPropertyExporter.CallGetPropertyOffset(bCanInstanceIdenticalAsset_NativeProperty);
        SavedAssetInstanceName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SavedAssetInstanceName");
        SavedAssetInstanceName_Offset = FPropertyExporter.CallGetPropertyOffset(SavedAssetInstanceName_NativeProperty);
        #if WITH_EDITOR
        AllowedAssignedAssetClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AllowedAssignedAssetClasses");
        AllowedAssignedAssetClasses_Offset = FPropertyExporter.CallGetPropertyOffset(AllowedAssignedAssetClasses_NativeProperty);
        #endif
        #if WITH_EDITOR
        DeniedAssignedAssetClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DeniedAssignedAssetClasses");
        DeniedAssignedAssetClasses_Offset = FPropertyExporter.CallGetPropertyOffset(DeniedAssignedAssetClasses_NativeProperty);
        #endif
    }
    
    static int Asset_Offset;
    
    private TSoftObjectPtr<UnrealSharp.Flow.UFlowAsset> Asset
    {
        get
        {
            return SoftObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, Asset_Offset), 0);
        }
        set
        {
            SoftObjectMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(NativeObject, Asset_Offset), 0, value);
        }
    }
    
    
    static int bCanInstanceIdenticalAsset_Offset;
    
    /// <summary>
    /// * Allow to create instance of the same Flow Asset as the asset containing this node
    /// * Enabling it may cause an infinite loop, if graph would keep creating copies of itself
    /// </summary>
    private bool CanInstanceIdenticalAsset
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCanInstanceIdenticalAsset_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCanInstanceIdenticalAsset_Offset), 0, value);
        }
    }
    
    
    static int SavedAssetInstanceName_Offset;
    static IntPtr SavedAssetInstanceName_NativeProperty;
    
    private string SavedAssetInstanceName
    {
        get
        {
            IntPtr SavedAssetInstanceName_NativePtr = IntPtr.Add(NativeObject,SavedAssetInstanceName_Offset);
            return StringMarshaller.FromNative(SavedAssetInstanceName_NativePtr,0);
        }
    }
    
    
    #if WITH_EDITOR
    static int AllowedAssignedAssetClasses_Offset;
    static IntPtr AllowedAssignedAssetClasses_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> AllowedAssignedAssetClasses_Marshaller = null;
    
    /// <summary>
    /// All the classes allowed to be used as assets on this subgraph node
    /// </summary>
    protected System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> AllowedAssignedAssetClasses
    {
        get
        {
            AllowedAssignedAssetClasses_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>>(AllowedAssignedAssetClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return AllowedAssignedAssetClasses_Marshaller.FromNative(IntPtr.Add(NativeObject, AllowedAssignedAssetClasses_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int DeniedAssignedAssetClasses_Offset;
    static IntPtr DeniedAssignedAssetClasses_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> DeniedAssignedAssetClasses_Marshaller = null;
    
    /// <summary>
    /// All the classes disallowed to be used as assets on this subgraph node
    /// </summary>
    protected System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowAsset>> DeniedAssignedAssetClasses
    {
        get
        {
            DeniedAssignedAssetClasses_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowAsset>>(DeniedAssignedAssetClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative);
            return DeniedAssignedAssetClasses_Marshaller.FromNative(IntPtr.Add(NativeObject, DeniedAssignedAssetClasses_Offset), 0);
        }
    }
    #endif
    
    
}