using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowAssetSaveData", "UnrealSharp.Flow.FlowAssetSaveData")]
public partial struct FFlowAssetSaveData : MarshalledStruct<FFlowAssetSaveData>
{
    // WorldName
    
    static int WorldName_Offset;
    static IntPtr WorldName_NativeProperty;
    public string WorldName;
    
    // InstanceName
    
    static int InstanceName_Offset;
    static IntPtr InstanceName_NativeProperty;
    public string InstanceName;
    
    // AssetData
    
    static int AssetData_Offset;
    static IntPtr AssetData_NativeProperty;
    static ArrayCopyMarshaller<byte> AssetData_Marshaller = null;
    public System.Collections.Generic.IList<byte> AssetData;
    
    // NodeRecords
    
    static int NodeRecords_Offset;
    static IntPtr NodeRecords_NativeProperty;
    static ArrayCopyMarshaller<UnrealSharp.Flow.FFlowNodeSaveData> NodeRecords_Marshaller = null;
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowNodeSaveData> NodeRecords;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowAssetSaveData()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowAssetSaveData");
        WorldName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "WorldName");
        WorldName_Offset = FPropertyExporter.CallGetPropertyOffset(WorldName_NativeProperty);
        InstanceName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InstanceName");
        InstanceName_Offset = FPropertyExporter.CallGetPropertyOffset(InstanceName_NativeProperty);
        AssetData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AssetData");
        AssetData_Offset = FPropertyExporter.CallGetPropertyOffset(AssetData_NativeProperty);
        NodeRecords_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeRecords");
        NodeRecords_Offset = FPropertyExporter.CallGetPropertyOffset(NodeRecords_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowAssetSaveData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IntPtr WorldName_NativePtr = IntPtr.Add(InNativeStruct,WorldName_Offset);
            WorldName = StringMarshaller.FromNative(WorldName_NativePtr,0);
            IntPtr InstanceName_NativePtr = IntPtr.Add(InNativeStruct,InstanceName_Offset);
            InstanceName = StringMarshaller.FromNative(InstanceName_NativePtr,0);
            AssetData_Marshaller ??= new ArrayCopyMarshaller<byte>(AssetData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr AssetData_NativeBuffer = IntPtr.Add(InNativeStruct, AssetData_Offset);
            AssetData = AssetData_Marshaller.FromNative(AssetData_NativeBuffer, 0);
            NodeRecords_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>(NodeRecords_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.FromNative);
            IntPtr NodeRecords_NativeBuffer = IntPtr.Add(InNativeStruct, NodeRecords_Offset);
            NodeRecords = NodeRecords_Marshaller.FromNative(NodeRecords_NativeBuffer, 0);
        }
    }
    
    public static FFlowAssetSaveData FromNative(IntPtr buffer) => new FFlowAssetSaveData(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            IntPtr WorldName_NativePtr = IntPtr.Add(buffer, WorldName_Offset);
            StringMarshaller.ToNative(WorldName_NativePtr,0,WorldName);
            IntPtr InstanceName_NativePtr = IntPtr.Add(buffer, InstanceName_Offset);
            StringMarshaller.ToNative(InstanceName_NativePtr,0,InstanceName);
            AssetData_Marshaller ??= new ArrayCopyMarshaller<byte>(AssetData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr AssetData_NativeBuffer = IntPtr.Add(buffer, AssetData_Offset);
            AssetData_Marshaller.ToNative(AssetData_NativeBuffer, 0, AssetData);
            NodeRecords_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>(NodeRecords_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowNodeSaveData>.FromNative);
            IntPtr NodeRecords_NativeBuffer = IntPtr.Add(buffer, NodeRecords_Offset);
            NodeRecords_Marshaller.ToNative(NodeRecords_NativeBuffer, 0, NodeRecords);
        }
    }
}

public static class FFlowAssetSaveDataMarshaller
{
    public static FFlowAssetSaveData FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowAssetSaveData(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowAssetSaveData obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowAssetSaveData.NativeDataSize;
    }
}