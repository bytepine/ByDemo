using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Helper structure allowing to copy properties from blueprint function pin to the Flow Node property of different name
/// </summary>
[UStruct, GeneratedType("BlueprintToFlowPinName", "UnrealSharp.FlowEditor.BlueprintToFlowPinName")]
public partial struct FBlueprintToFlowPinName : MarshalledStruct<FBlueprintToFlowPinName>
{
    // NodePropertiesToFunctionPins
    
    static int NodePropertiesToFunctionPins_Offset;
    static IntPtr NodePropertiesToFunctionPins_NativeProperty;
    static MapCopyMarshaller<FName, FName> NodePropertiesToFunctionPins_Marshaller = null;
    /// <summary>
    /// Key represents Flow Node property name
    /// Value represents Input Pin name of blueprint function
    /// </summary>
    public System.Collections.Generic.IDictionary<FName, FName> NodePropertiesToFunctionPins;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FBlueprintToFlowPinName()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BlueprintToFlowPinName");
        NodePropertiesToFunctionPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodePropertiesToFunctionPins");
        NodePropertiesToFunctionPins_Offset = FPropertyExporter.CallGetPropertyOffset(NodePropertiesToFunctionPins_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FBlueprintToFlowPinName(IntPtr InNativeStruct)
    {
        unsafe
        {
            NodePropertiesToFunctionPins_Marshaller ??= new MapCopyMarshaller<FName, FName>(NodePropertiesToFunctionPins_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            IntPtr NodePropertiesToFunctionPins_NativeProperty_ParamsBuffer = IntPtr.Add(InNativeStruct, NodePropertiesToFunctionPins_Offset);
            NodePropertiesToFunctionPins = NodePropertiesToFunctionPins_Marshaller.FromNative(InNativeStruct, 0);
        }
    }
    
    public static FBlueprintToFlowPinName FromNative(IntPtr buffer) => new FBlueprintToFlowPinName(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            NodePropertiesToFunctionPins_Marshaller ??= new MapCopyMarshaller<FName, FName>(NodePropertiesToFunctionPins_NativeProperty, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative, BlittableMarshaller<FName>.ToNative, BlittableMarshaller<FName>.FromNative);
            IntPtr NodePropertiesToFunctionPins_NativeProperty_NativeBuffer = IntPtr.Add(buffer, NodePropertiesToFunctionPins_Offset);
            NodePropertiesToFunctionPins_Marshaller.ToNative(NodePropertiesToFunctionPins_NativeProperty_NativeBuffer, 0, NodePropertiesToFunctionPins);
        }
    }
}

public static class FBlueprintToFlowPinNameMarshaller
{
    public static FBlueprintToFlowPinName FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FBlueprintToFlowPinName(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FBlueprintToFlowPinName obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FBlueprintToFlowPinName.NativeDataSize;
    }
}