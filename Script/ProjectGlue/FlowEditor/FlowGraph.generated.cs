using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass, GeneratedType("FlowGraph", "UnrealSharp.FlowEditor.FlowGraph")]
public partial class UFlowGraph : UnrealSharp.Engine.UEdGraph
{
    static readonly IntPtr NativeClassPtr;
    static UFlowGraph()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowGraph");
        IntPtr GraphVersion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "GraphVersion");
        GraphVersion_Offset = FPropertyExporter.CallGetPropertyOffset(GraphVersion_NativeProperty);
    }
    
    static int GraphVersion_Offset;
    
    /// <summary>
    /// Graph version number
    /// </summary>
    protected int GraphVersion
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, GraphVersion_Offset), 0);
        }
    }
    
    
}