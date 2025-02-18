using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Processing Flow Nodes creates map of connected pins
/// </summary>
[UStruct, GeneratedType("ConnectedPin", "UnrealSharp.Flow.ConnectedPin")]
public partial struct FConnectedPin : MarshalledStruct<FConnectedPin>
{
    // NodeGuid
    
    static int NodeGuid_Offset;
    public UnrealSharp.CoreUObject.FGuid NodeGuid;
    
    // PinName
    
    static int PinName_Offset;
    public FName PinName;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FConnectedPin()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ConnectedPin");
        IntPtr NodeGuid_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeGuid");
        NodeGuid_Offset = FPropertyExporter.CallGetPropertyOffset(NodeGuid_NativeProperty);
        IntPtr PinName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinName");
        PinName_Offset = FPropertyExporter.CallGetPropertyOffset(PinName_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FConnectedPin(IntPtr InNativeStruct)
    {
        unsafe
        {
            NodeGuid = StructMarshaller<UnrealSharp.CoreUObject.FGuid>.FromNative(IntPtr.Add(InNativeStruct, NodeGuid_Offset), 0);
            PinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, PinName_Offset), 0);
        }
    }
    
    public static FConnectedPin FromNative(IntPtr buffer) => new FConnectedPin(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FGuid>.ToNative(IntPtr.Add(buffer, NodeGuid_Offset), 0, NodeGuid);
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, PinName_Offset), 0, PinName);
        }
    }
}

public static class FConnectedPinMarshaller
{
    public static FConnectedPin FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FConnectedPin(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FConnectedPin obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FConnectedPin.NativeDataSize;
    }
}