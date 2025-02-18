using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Graph representation of the Flow Node
/// </summary>
[UClass, GeneratedType("FlowGraphNode", "UnrealSharp.FlowEditor.FlowGraphNode")]
public partial class UFlowGraphNode : UnrealSharp.Engine.UEdGraphNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowGraphNode()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowGraphNode");
        IntPtr NodeInstance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeInstance");
        NodeInstance_Offset = FPropertyExporter.CallGetPropertyOffset(NodeInstance_NativeProperty);
        AssignedNodeClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AssignedNodeClasses");
        AssignedNodeClasses_Offset = FPropertyExporter.CallGetPropertyOffset(AssignedNodeClasses_NativeProperty);
        IntPtr NodeBreakpoint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeBreakpoint");
        NodeBreakpoint_Offset = FPropertyExporter.CallGetPropertyOffset(NodeBreakpoint_NativeProperty);
        PinBreakpoints_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinBreakpoints");
        PinBreakpoints_Offset = FPropertyExporter.CallGetPropertyOffset(PinBreakpoints_NativeProperty);
        IntPtr NodeInstanceClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeInstanceClass");
        NodeInstanceClass_Offset = FPropertyExporter.CallGetPropertyOffset(NodeInstanceClass_NativeProperty);
        SubNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubNodes");
        SubNodes_Offset = FPropertyExporter.CallGetPropertyOffset(SubNodes_NativeProperty);
        IntPtr CopySubNodeParentIndex_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CopySubNodeParentIndex");
        CopySubNodeParentIndex_Offset = FPropertyExporter.CallGetPropertyOffset(CopySubNodeParentIndex_NativeProperty);
        IntPtr CopySubNodeIndex_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CopySubNodeIndex");
        CopySubNodeIndex_Offset = FPropertyExporter.CallGetPropertyOffset(CopySubNodeIndex_NativeProperty);
        IntPtr bIsSubNode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsSubNode");
        bIsSubNode_Offset = FPropertyExporter.CallGetPropertyOffset(bIsSubNode_NativeProperty);
        IntPtr bHasContextPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHasContextPins");
        bHasContextPins_Offset = FPropertyExporter.CallGetPropertyOffset(bHasContextPins_NativeProperty);
        ErrorMessage_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ErrorMessage");
        ErrorMessage_Offset = FPropertyExporter.CallGetPropertyOffset(ErrorMessage_NativeProperty);
        IntPtr ParentNode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ParentNode");
        ParentNode_Offset = FPropertyExporter.CallGetPropertyOffset(ParentNode_NativeProperty);
    }
    
    static int NodeInstance_Offset;
    
    /// <summary>
    /// The FlowNode or FlowNodeAddOn runtime instance that is being edited by this UFlowGraphNode
    /// </summary>
    private UnrealSharp.Flow.UFlowNodeBase NodeInstance
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowNodeBase>.FromNative(IntPtr.Add(NativeObject, NodeInstance_Offset), 0);
        }
    }
    
    
    static int AssignedNodeClasses_Offset;
    static IntPtr AssignedNodeClasses_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNodeBase>> AssignedNodeClasses_Marshaller = null;
    
    /// <summary>
    /// It would be intuitive to assign a custom Graph Node class in Flow Node class
    /// However, we shouldn't assign class from editor module to runtime module class
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowNodeBase>> AssignedNodeClasses
    {
        get
        {
            AssignedNodeClasses_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNodeBase>>(AssignedNodeClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNodeBase>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNodeBase>.FromNative);
            return AssignedNodeClasses_Marshaller.FromNative(IntPtr.Add(NativeObject, AssignedNodeClasses_Offset), 0);
        }
    }
    
    
    static int NodeBreakpoint_Offset;
    
    public UnrealSharp.Flow.FFlowPinTrait NodeBreakpoint
    {
        get
        {
            return StructMarshaller<UnrealSharp.Flow.FFlowPinTrait>.FromNative(IntPtr.Add(NativeObject, NodeBreakpoint_Offset), 0);
        }
    }
    
    
    static int PinBreakpoints_Offset;
    static IntPtr PinBreakpoints_NativeProperty;
    MapMarshaller<UnrealSharp.Engine.FEdGraphPinReference, UnrealSharp.Flow.FFlowPinTrait> PinBreakpoints_Marshaller = null;
    
    public System.Collections.Generic.IDictionary<UnrealSharp.Engine.FEdGraphPinReference, UnrealSharp.Flow.FFlowPinTrait> PinBreakpoints
    {
        get
        {
            PinBreakpoints_Marshaller ??= new MapMarshaller<UnrealSharp.Engine.FEdGraphPinReference, UnrealSharp.Flow.FFlowPinTrait>(PinBreakpoints_NativeProperty, StructMarshaller<UnrealSharp.Engine.FEdGraphPinReference>.ToNative, StructMarshaller<UnrealSharp.Engine.FEdGraphPinReference>.FromNative, StructMarshaller<UnrealSharp.Flow.FFlowPinTrait>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPinTrait>.FromNative);
            return PinBreakpoints_Marshaller.FromNative(IntPtr.Add(NativeObject, PinBreakpoints_Offset), 0);
        }
    }
    
    
    static int NodeInstanceClass_Offset;
    
    /// <summary>
    /// instance class
    /// </summary>
    public TSoftClassPtr<UnrealSharp.CoreUObject.UClass> NodeInstanceClass
    {
        get
        {
            return SoftClassMarshaller<UnrealSharp.CoreUObject.UClass>.FromNative(IntPtr.Add(NativeObject, NodeInstanceClass_Offset), 0);
        }
    }
    
    
    static int SubNodes_Offset;
    static IntPtr SubNodes_NativeProperty;
    ArrayMarshaller<UnrealSharp.FlowEditor.UFlowGraphNode> SubNodes_Marshaller = null;
    
    /// <summary>
    /// SubNodes that are owned by this UFlowGraphNode
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.FlowEditor.UFlowGraphNode> SubNodes
    {
        get
        {
            SubNodes_Marshaller ??= new ArrayMarshaller<UnrealSharp.FlowEditor.UFlowGraphNode>(SubNodes_NativeProperty, ObjectMarshaller<UnrealSharp.FlowEditor.UFlowGraphNode>.ToNative, ObjectMarshaller<UnrealSharp.FlowEditor.UFlowGraphNode>.FromNative);
            return SubNodes_Marshaller.FromNative(IntPtr.Add(NativeObject, SubNodes_Offset), 0);
        }
    }
    
    
    static int CopySubNodeParentIndex_Offset;
    
    /// <summary>
    /// subnode's parent index assigned during copy operation to connect nodes again on paste
    /// </summary>
    public int CopySubNodeParentIndex
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, CopySubNodeParentIndex_Offset), 0);
        }
    }
    
    
    static int CopySubNodeIndex_Offset;
    
    /// <summary>
    /// subnode index assigned during copy operation to connect nodes again on paste
    /// </summary>
    public int CopySubNodeIndex
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, CopySubNodeIndex_Offset), 0);
        }
    }
    
    
    static int bIsSubNode_Offset;
    
    /// <summary>
    /// if set, this node will be always considered as subnode
    /// </summary>
    public bool IsSubNode
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsSubNode_Offset), 0);
        }
    }
    
    
    static int bHasContextPins_Offset;
    
    /// <summary>
    /// if set, this node has context pins from the last RefreshContextPins
    /// </summary>
    public bool HasContextPins
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bHasContextPins_Offset), 0);
        }
    }
    
    
    static int ErrorMessage_Offset;
    static IntPtr ErrorMessage_NativeProperty;
    
    /// <summary>
    /// error message for node
    /// </summary>
    public string ErrorMessage
    {
        get
        {
            IntPtr ErrorMessage_NativePtr = IntPtr.Add(NativeObject,ErrorMessage_Offset);
            return StringMarshaller.FromNative(ErrorMessage_NativePtr,0);
        }
    }
    
    
    static int ParentNode_Offset;
    
    /// <summary>
    /// parent UFlowGraphNode for this node,
    /// note, this is not saved, and is restored in when the graph is opened in the editor via
    /// UFlowGraph::RecursivelySetParentNodeForAllSubNodes
    /// </summary>
    private UnrealSharp.FlowEditor.UFlowGraphNode ParentNode
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.FlowEditor.UFlowGraphNode>.FromNative(IntPtr.Add(NativeObject, ParentNode_Offset), 0);
        }
    }
    
    
}