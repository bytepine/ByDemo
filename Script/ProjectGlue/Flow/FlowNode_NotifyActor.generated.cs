using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Finds all Flow Components with matching Identity Tag and calls ReceiveNotify event on these components
/// </summary>
[UClass, GeneratedType("FlowNode_NotifyActor", "UnrealSharp.Flow.FlowNode_NotifyActor")]
public partial class UFlowNode_NotifyActor : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_NotifyActor()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_NotifyActor");
        IntPtr IdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "IdentityTags");
        IdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(IdentityTags_NativeProperty);
        IntPtr MatchType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "MatchType");
        MatchType_Offset = FPropertyExporter.CallGetPropertyOffset(MatchType_NativeProperty);
        IntPtr bExactMatch_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExactMatch");
        bExactMatch_Offset = FPropertyExporter.CallGetPropertyOffset(bExactMatch_NativeProperty);
        IntPtr NotifyTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NotifyTags");
        NotifyTags_Offset = FPropertyExporter.CallGetPropertyOffset(NotifyTags_NativeProperty);
        IntPtr NetMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NetMode");
        NetMode_Offset = FPropertyExporter.CallGetPropertyOffset(NetMode_NativeProperty);
    }
    
    static int IdentityTags_Offset;
    
    protected UnrealSharp.GameplayTags.FGameplayTagContainer IdentityTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, IdentityTags_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(NativeObject, IdentityTags_Offset), 0, value);
        }
    }
    
    
    static int MatchType_Offset;
    
    protected UnrealSharp.GameplayTags.EGameplayContainerMatchType MatchType
    {
        get
        {
            return EnumMarshaller<UnrealSharp.GameplayTags.EGameplayContainerMatchType>.FromNative(IntPtr.Add(NativeObject, MatchType_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.GameplayTags.EGameplayContainerMatchType>.ToNative(IntPtr.Add(NativeObject, MatchType_Offset), 0, value);
        }
    }
    
    
    static int bExactMatch_Offset;
    
    /// <summary>
    /// If true, identity tags must be an exact match.
    /// Be careful, setting this to false may be very expensive, as the
    /// search cost is proportional to the number of registered Gameplay Tags!
    /// </summary>
    protected bool ExactMatch
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bExactMatch_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bExactMatch_Offset), 0, value);
        }
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
    
    
    static int NetMode_Offset;
    
    protected UnrealSharp.Flow.EFlowNetMode NetMode
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.FromNative(IntPtr.Add(NativeObject, NetMode_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowNetMode>.ToNative(IntPtr.Add(NativeObject, NetMode_Offset), 0, value);
        }
    }
    
    
}