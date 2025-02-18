using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("NotifyTagReplication", "UnrealSharp.Flow.NotifyTagReplication")]
public partial struct FNotifyTagReplication : MarshalledStruct<FNotifyTagReplication>
{
    // ActorTag
    
    static int ActorTag_Offset;
    public UnrealSharp.GameplayTags.FGameplayTag ActorTag;
    
    // NotifyTag
    
    static int NotifyTag_Offset;
    public UnrealSharp.GameplayTags.FGameplayTag NotifyTag;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FNotifyTagReplication()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NotifyTagReplication");
        IntPtr ActorTag_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ActorTag");
        ActorTag_Offset = FPropertyExporter.CallGetPropertyOffset(ActorTag_NativeProperty);
        IntPtr NotifyTag_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NotifyTag");
        NotifyTag_Offset = FPropertyExporter.CallGetPropertyOffset(NotifyTag_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FNotifyTagReplication(IntPtr InNativeStruct)
    {
        unsafe
        {
            ActorTag = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(InNativeStruct, ActorTag_Offset), 0);
            NotifyTag = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(InNativeStruct, NotifyTag_Offset), 0);
        }
    }
    
    public static FNotifyTagReplication FromNative(IntPtr buffer) => new FNotifyTagReplication(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(buffer, ActorTag_Offset), 0, ActorTag);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(buffer, NotifyTag_Offset), 0, NotifyTag);
        }
    }
}

public static class FNotifyTagReplicationMarshaller
{
    public static FNotifyTagReplication FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FNotifyTagReplication(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FNotifyTagReplication obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FNotifyTagReplication.NativeDataSize;
    }
}