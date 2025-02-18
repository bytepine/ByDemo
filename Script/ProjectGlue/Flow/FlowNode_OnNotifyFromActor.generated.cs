using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Triggers output when Flow Component with matching Identity Tag calls NotifyGraph function with matching Notify Tag
/// </summary>
[UClass, GeneratedType("FlowNode_OnNotifyFromActor", "UnrealSharp.Flow.FlowNode_OnNotifyFromActor")]
public partial class UFlowNode_OnNotifyFromActor : UnrealSharp.Flow.UFlowNode_ComponentObserver
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_OnNotifyFromActor()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_OnNotifyFromActor");
        IntPtr NotifyTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NotifyTags");
        NotifyTags_Offset = FPropertyExporter.CallGetPropertyOffset(NotifyTags_NativeProperty);
        IntPtr bRetroactive_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRetroactive");
        bRetroactive_Offset = FPropertyExporter.CallGetPropertyOffset(bRetroactive_NativeProperty);
    }
    
    static int NotifyTags_Offset;
    
    protected UnrealSharp.GameplayTags.FGameplayTagContainer NotifyTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, NotifyTags_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(NativeObject, NotifyTags_Offset), 0, value);
        }
    }
    
    
    static int bRetroactive_Offset;
    
    /// <summary>
    /// If true, node will check given Notify Tag is present in the Recently Sent Notify Tags
    /// This might be helpful in multiplayer, if client-side Flow Node started work after server sent the notify
    /// </summary>
    protected bool Retroactive
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRetroactive_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRetroactive_Offset), 0, value);
        }
    }
    
    
}