using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowComponentSaveData", "UnrealSharp.Flow.FlowComponentSaveData")]
public partial struct FFlowComponentSaveData : MarshalledStruct<FFlowComponentSaveData>
{
    // WorldName
    
    static int WorldName_Offset;
    static IntPtr WorldName_NativeProperty;
    public string WorldName;
    
    // ActorInstanceName
    
    static int ActorInstanceName_Offset;
    static IntPtr ActorInstanceName_NativeProperty;
    public string ActorInstanceName;
    
    // ComponentData
    
    static int ComponentData_Offset;
    static IntPtr ComponentData_NativeProperty;
    static ArrayCopyMarshaller<byte> ComponentData_Marshaller = null;
    public System.Collections.Generic.IList<byte> ComponentData;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowComponentSaveData()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowComponentSaveData");
        WorldName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "WorldName");
        WorldName_Offset = FPropertyExporter.CallGetPropertyOffset(WorldName_NativeProperty);
        ActorInstanceName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActorInstanceName");
        ActorInstanceName_Offset = FPropertyExporter.CallGetPropertyOffset(ActorInstanceName_NativeProperty);
        ComponentData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentData");
        ComponentData_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentData_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowComponentSaveData(IntPtr InNativeStruct)
    {
        unsafe
        {
            IntPtr WorldName_NativePtr = IntPtr.Add(InNativeStruct,WorldName_Offset);
            WorldName = StringMarshaller.FromNative(WorldName_NativePtr,0);
            IntPtr ActorInstanceName_NativePtr = IntPtr.Add(InNativeStruct,ActorInstanceName_Offset);
            ActorInstanceName = StringMarshaller.FromNative(ActorInstanceName_NativePtr,0);
            ComponentData_Marshaller ??= new ArrayCopyMarshaller<byte>(ComponentData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr ComponentData_NativeBuffer = IntPtr.Add(InNativeStruct, ComponentData_Offset);
            ComponentData = ComponentData_Marshaller.FromNative(ComponentData_NativeBuffer, 0);
        }
    }
    
    public static FFlowComponentSaveData FromNative(IntPtr buffer) => new FFlowComponentSaveData(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            IntPtr WorldName_NativePtr = IntPtr.Add(buffer, WorldName_Offset);
            StringMarshaller.ToNative(WorldName_NativePtr,0,WorldName);
            IntPtr ActorInstanceName_NativePtr = IntPtr.Add(buffer, ActorInstanceName_Offset);
            StringMarshaller.ToNative(ActorInstanceName_NativePtr,0,ActorInstanceName);
            ComponentData_Marshaller ??= new ArrayCopyMarshaller<byte>(ComponentData_NativeProperty, BlittableMarshaller<byte>.ToNative, BlittableMarshaller<byte>.FromNative);
            IntPtr ComponentData_NativeBuffer = IntPtr.Add(buffer, ComponentData_Offset);
            ComponentData_Marshaller.ToNative(ComponentData_NativeBuffer, 0, ComponentData);
        }
    }
}

public static class FFlowComponentSaveDataMarshaller
{
    public static FFlowComponentSaveData FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowComponentSaveData(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowComponentSaveData obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowComponentSaveData.NativeDataSize;
    }
}