using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowNodeSaveData", "UnrealSharp.Flow.FlowNodeSaveData")]
public partial struct FFlowNodeSaveData : MarshalledStruct<FFlowNodeSaveData>
{
    // NodeGuid
    
    static int NodeGuid_Offset;
    public UnrealSharp.CoreUObject.FGuid NodeGuid;
    
    // NodeData
    
    static int NodeData_Offset;
    static IntPtr NodeData_NativeProperty;
    static ArrayCopyMarshaller<byte> NodeData_Marshaller = null;
    public System.Collections.Generic.IList<byte> NodeData;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowNodeSaveData()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowNodeSaveData");
        IntPtr NodeGuid_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeGuid");
        NodeGuid_Offset = FPropertyExporter.CallGetPropertyOffset(NodeGuid_NativeProperty);
        NodeData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeData");
        NodeData_Offset = FPropertyExporter.CallGetPropertyOffset(NodeData_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowNodeSaveData(IntPtr InNativeStruct)
    {
        unsafe
        {
            NodeGuid = StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative(IntPtr.Add(InNativeStruct, NodeGuid_Offset), 0);
            NodeData_Marshaller ??= new ArrayCopyMarshaller<byte>(NodeData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr NodeData_NativeBuffer = IntPtr.Add(InNativeStruct, NodeData_Offset);
            NodeData = NodeData_Marshaller.FromNative(NodeData_NativeBuffer, 0);
        }
    }
    
    public static FFlowNodeSaveData FromNative(IntPtr buffer) => new FFlowNodeSaveData(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative(IntPtr.Add(buffer, NodeGuid_Offset), 0, NodeGuid);
            NodeData_Marshaller ??= new ArrayCopyMarshaller<byte>(NodeData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr NodeData_NativeBuffer = IntPtr.Add(buffer, NodeData_Offset);
            NodeData_Marshaller.ToNative(NodeData_NativeBuffer, 0, NodeData);
        }
    }
}

public static class FFlowNodeSaveDataMarshaller
{
    public static FFlowNodeSaveData FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowNodeSaveData(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowNodeSaveData obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowNodeSaveData.NativeDataSize;
    }
}