using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UClass, GeneratedType("FlowSaveGame", "UnrealSharp.Flow.FlowSaveGame")]
public partial class UFlowSaveGame : UnrealSharp.Engine.USaveGame
{
    static readonly IntPtr NativeClassPtr;
    static UFlowSaveGame()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowSaveGame");
        SaveSlotName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SaveSlotName");
        SaveSlotName_Offset = FPropertyExporter.CallGetPropertyOffset(SaveSlotName_NativeProperty);
        FlowComponents_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowComponents");
        FlowComponents_Offset = FPropertyExporter.CallGetPropertyOffset(FlowComponents_NativeProperty);
        FlowInstances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowInstances");
        FlowInstances_Offset = FPropertyExporter.CallGetPropertyOffset(FlowInstances_NativeProperty);
    }
    
    static int SaveSlotName_Offset;
    static IntPtr SaveSlotName_NativeProperty;
    
    public string SaveSlotName
    {
        get
        {
            IntPtr SaveSlotName_NativePtr = IntPtr.Add(NativeObject,SaveSlotName_Offset);
            return StringMarshaller.FromNative(SaveSlotName_NativePtr,0);
        }
        set
        {
            IntPtr SaveSlotName_NativePtr = IntPtr.Add(NativeObject, SaveSlotName_Offset);
            StringMarshaller.ToNative(SaveSlotName_NativePtr,0,value);
        }
    }
    
    
    static int FlowComponents_Offset;
    static IntPtr FlowComponents_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowComponentSaveData> FlowComponents_Marshaller = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowComponentSaveData> FlowComponents
    {
        get
        {
            FlowComponents_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowComponentSaveData>(FlowComponents_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowComponentSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowComponentSaveData>.FromNative);
            return FlowComponents_Marshaller.FromNative(IntPtr.Add(NativeObject, FlowComponents_Offset), 0);
        }
    }
    
    
    static int FlowInstances_Offset;
    static IntPtr FlowInstances_NativeProperty;
    ArrayMarshaller<UnrealSharp.Flow.FFlowAssetSaveData> FlowInstances_Marshaller = null;
    
    public System.Collections.Generic.IList<UnrealSharp.Flow.FFlowAssetSaveData> FlowInstances
    {
        get
        {
            FlowInstances_Marshaller ??= new ArrayMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>(FlowInstances_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowAssetSaveData>.FromNative);
            return FlowInstances_Marshaller.FromNative(IntPtr.Add(NativeObject, FlowInstances_Offset), 0);
        }
    }
    
    
}