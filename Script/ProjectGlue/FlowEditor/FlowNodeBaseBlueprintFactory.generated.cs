using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass(ClassFlags.Abstract), GeneratedType("FlowNodeBaseBlueprintFactory", "UnrealSharp.FlowEditor.FlowNodeBaseBlueprintFactory")]
public partial class UFlowNodeBaseBlueprintFactory : UnrealSharp.UnrealEd.UFactory
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNodeBaseBlueprintFactory()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNodeBaseBlueprintFactory");
        IntPtr DefaultParentClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultParentClass");
        DefaultParentClass_Offset = FPropertyExporter.CallGetPropertyOffset(DefaultParentClass_NativeProperty);
        IntPtr ParentClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ParentClass");
        ParentClass_Offset = FPropertyExporter.CallGetPropertyOffset(ParentClass_NativeProperty);
    }
    
    static int DefaultParentClass_Offset;
    
    /// <summary>
    /// The Default parent class of the created blueprint (set by subclasses)
    /// </summary>
    public TSubclassOf<UnrealSharp.Flow.UFlowNodeBase> DefaultParentClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowNodeBase>.FromNative(IntPtr.Add(NativeObject, DefaultParentClass_Offset), 0);
        }
    }
    
    
    static int ParentClass_Offset;
    
    /// <summary>
    /// The parent class of the created blueprint
    /// </summary>
    public TSubclassOf<UnrealSharp.Flow.UFlowNodeBase> ParentClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowNodeBase>.FromNative(IntPtr.Add(NativeObject, ParentClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowNodeBase>.ToNative(IntPtr.Add(NativeObject, ParentClass_Offset), 0, value);
        }
    }
    
    
}