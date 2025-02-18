using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Helper structure allowing to recreate blueprint graph as Flow Graph
/// </summary>
[UStruct, GeneratedType("ImportedGraphNode", "UnrealSharp.FlowEditor.ImportedGraphNode")]
public partial struct FImportedGraphNode : MarshalledStruct<FImportedGraphNode>
{
    // SourceGraphNode
    
    static int SourceGraphNode_Offset;
    public UnrealSharp.Engine.UEdGraphNode SourceGraphNode;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FImportedGraphNode()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ImportedGraphNode");
        IntPtr SourceGraphNode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SourceGraphNode");
        SourceGraphNode_Offset = FPropertyExporter.CallGetPropertyOffset(SourceGraphNode_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FImportedGraphNode(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourceGraphNode = ObjectMarshaller<UnrealSharp.Engine.UEdGraphNode>.FromNative(IntPtr.Add(InNativeStruct, SourceGraphNode_Offset), 0);
        }
    }
    
    public static FImportedGraphNode FromNative(IntPtr buffer) => new FImportedGraphNode(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.UEdGraphNode>.ToNative(IntPtr.Add(buffer, SourceGraphNode_Offset), 0, SourceGraphNode);
        }
    }
}

public static class FImportedGraphNodeMarshaller
{
    public static FImportedGraphNode FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FImportedGraphNode(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FImportedGraphNode obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FImportedGraphNode.NativeDataSize;
    }
}