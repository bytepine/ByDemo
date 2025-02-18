using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Container for injected component instances
/// </summary>
[UStruct, GeneratedType("FlowComponentInstances", "UnrealSharp.Flow.FlowComponentInstances")]
public partial struct FFlowComponentInstances : MarshalledStruct<FFlowComponentInstances>
{
    // Components
    
    static int Components_Offset;
    static IntPtr Components_NativeProperty;
    static ArrayCopyMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>> Components_Marshaller = null;
    public System.Collections.Generic.IList<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>> Components;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowComponentInstances()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowComponentInstances");
        Components_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Components");
        Components_Offset = FPropertyExporter.CallGetPropertyOffset(Components_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowComponentInstances(IntPtr InNativeStruct)
    {
        unsafe
        {
            Components_Marshaller ??= new ArrayCopyMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>(Components_NativeProperty, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>.ToNative, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>.FromNative);
            IntPtr Components_NativeBuffer = IntPtr.Add(InNativeStruct, Components_Offset);
            Components = Components_Marshaller.FromNative(Components_NativeBuffer, 0);
        }
    }
    
    public static FFlowComponentInstances FromNative(IntPtr buffer) => new FFlowComponentInstances(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            Components_Marshaller ??= new ArrayCopyMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>(Components_NativeProperty, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>.ToNative, BlittableMarshaller<TWeakObjectPtr<UnrealSharp.Engine.UActorComponent>>.FromNative);
            IntPtr Components_NativeBuffer = IntPtr.Add(buffer, Components_Offset);
            Components_Marshaller.ToNative(Components_NativeBuffer, 0, Components);
        }
    }
}

public static class FFlowComponentInstancesMarshaller
{
    public static FFlowComponentInstances FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowComponentInstances(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowComponentInstances obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowComponentInstances.NativeDataSize;
    }
}