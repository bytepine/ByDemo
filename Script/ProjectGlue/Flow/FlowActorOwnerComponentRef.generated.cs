using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Similar to FAnimNodeFunctionRef, providing a FName-based Component binding
///  that is resolved at runtime
/// </summary>
[UStruct, GeneratedType("FlowActorOwnerComponentRef", "UnrealSharp.Flow.FlowActorOwnerComponentRef")]
public partial struct FFlowActorOwnerComponentRef : MarshalledStruct<FFlowActorOwnerComponentRef>
{
    // ComponentName
    
    static int ComponentName_Offset;
    /// <summary>
    /// The name of the component
    /// </summary>
    public FName ComponentName;
    
    // ResolvedComponent
    
    static int ResolvedComponent_Offset;
    /// <summary>
    /// Cached resolved component (resolved at runtime by calling TryResolveComponent)
    /// </summary>
    public UnrealSharp.Engine.UActorComponent ResolvedComponent;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowActorOwnerComponentRef()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowActorOwnerComponentRef");
        IntPtr ComponentName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentName");
        ComponentName_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentName_NativeProperty);
        IntPtr ResolvedComponent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ResolvedComponent");
        ResolvedComponent_Offset = FPropertyExporter.CallGetPropertyOffset(ResolvedComponent_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowActorOwnerComponentRef(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, ComponentName_Offset), 0);
            ResolvedComponent = ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative(IntPtr.Add(InNativeStruct, ResolvedComponent_Offset), 0);
        }
    }
    
    public static FFlowActorOwnerComponentRef FromNative(IntPtr buffer) => new FFlowActorOwnerComponentRef(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, ComponentName_Offset), 0, ComponentName);
            ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative(IntPtr.Add(buffer, ResolvedComponent_Offset), 0, ResolvedComponent);
        }
    }
}

public static class FFlowActorOwnerComponentRefMarshaller
{
    public static FFlowActorOwnerComponentRef FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowActorOwnerComponentRef(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowActorOwnerComponentRef obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowActorOwnerComponentRef.NativeDataSize;
    }
}