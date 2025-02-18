using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Base class for nodes operating on actors with the Flow Component
/// Such nodes usually wait until a specific action occurs in the actor
/// </summary>
[UClass(ClassFlags.Abstract), GeneratedType("FlowNode_ComponentObserver", "UnrealSharp.Flow.FlowNode_ComponentObserver")]
public partial class UFlowNode_ComponentObserver : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_ComponentObserver()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_ComponentObserver");
        IntPtr IdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "IdentityTags");
        IdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(IdentityTags_NativeProperty);
        IntPtr IdentityMatchType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "IdentityMatchType");
        IdentityMatchType_Offset = FPropertyExporter.CallGetPropertyOffset(IdentityMatchType_NativeProperty);
        IntPtr SuccessLimit_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SuccessLimit");
        SuccessLimit_Offset = FPropertyExporter.CallGetPropertyOffset(SuccessLimit_NativeProperty);
        IntPtr SuccessCount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SuccessCount");
        SuccessCount_Offset = FPropertyExporter.CallGetPropertyOffset(SuccessCount_NativeProperty);
        OnComponentRegistered_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnComponentRegistered");
        OnComponentRegistered_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnComponentRegistered_NativeFunction);
        OnComponentRegistered_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentRegistered_NativeFunction, "Component");
        OnComponentTagAdded_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnComponentTagAdded");
        OnComponentTagAdded_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnComponentTagAdded_NativeFunction);
        OnComponentTagAdded_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentTagAdded_NativeFunction, "Component");
        OnComponentTagAdded_AddedTags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentTagAdded_NativeFunction, "AddedTags");
        OnComponentTagRemoved_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnComponentTagRemoved");
        OnComponentTagRemoved_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnComponentTagRemoved_NativeFunction);
        OnComponentTagRemoved_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentTagRemoved_NativeFunction, "Component");
        OnComponentTagRemoved_RemovedTags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentTagRemoved_NativeFunction, "RemovedTags");
        OnComponentUnregistered_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnComponentUnregistered");
        OnComponentUnregistered_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnComponentUnregistered_NativeFunction);
        OnComponentUnregistered_Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnComponentUnregistered_NativeFunction, "Component");
        OnEventReceived_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnEventReceived");
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
    
    
    static int IdentityMatchType_Offset;
    
    /// <summary>
    /// Container A: Identity Tags in Flow Component
    /// Container B: Identity Tags listed above
    /// </summary>
    protected UnrealSharp.Flow.EFlowTagContainerMatchType IdentityMatchType
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowTagContainerMatchType>.FromNative(IntPtr.Add(NativeObject, IdentityMatchType_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowTagContainerMatchType>.ToNative(IntPtr.Add(NativeObject, IdentityMatchType_Offset), 0, value);
        }
    }
    
    
    static int SuccessLimit_Offset;
    
    /// <summary>
    /// This node will become Completed, if Success Limit > 0 and Success Count reaches this limit
    /// Set this to zero, if you'd like receive events indefinitely (node would finish work only if explicitly Stopped)
    /// </summary>
    protected int SuccessLimit
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, SuccessLimit_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, SuccessLimit_Offset), 0, value);
        }
    }
    
    
    static int SuccessCount_Offset;
    
    /// <summary>
    /// This node will become Completed, if Success Limit > 0 and Success Count reaches this limit
    /// </summary>
    protected int SuccessCount
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, SuccessCount_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, SuccessCount_Offset), 0, value);
        }
    }
    
    // OnComponentRegistered
    static IntPtr OnComponentRegistered_NativeFunction;
    static int OnComponentRegistered_ParamsSize;
    static int OnComponentRegistered_Component_Offset;
    
    [UFunction, GeneratedType("OnComponentRegistered")]
    protected void OnComponentRegistered(UnrealSharp.Flow.UFlowComponent component)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnComponentRegistered_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnComponentRegistered_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentRegistered_Component_Offset), 0, component);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnComponentRegistered_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnComponentTagAdded
    static IntPtr OnComponentTagAdded_NativeFunction;
    static int OnComponentTagAdded_ParamsSize;
    static int OnComponentTagAdded_Component_Offset;
    static int OnComponentTagAdded_AddedTags_Offset;
    
    [UFunction, GeneratedType("OnComponentTagAdded")]
    protected void OnComponentTagAdded(UnrealSharp.Flow.UFlowComponent component, UnrealSharp.GameplayTags.FGameplayTagContainer addedTags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnComponentTagAdded_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnComponentTagAdded_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentTagAdded_Component_Offset), 0, component);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentTagAdded_AddedTags_Offset), 0, addedTags);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnComponentTagAdded_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // OnComponentTagRemoved
    static IntPtr OnComponentTagRemoved_NativeFunction;
    static int OnComponentTagRemoved_ParamsSize;
    static int OnComponentTagRemoved_Component_Offset;
    static int OnComponentTagRemoved_RemovedTags_Offset;
    
    [UFunction, GeneratedType("OnComponentTagRemoved")]
    protected void OnComponentTagRemoved(UnrealSharp.Flow.UFlowComponent component, UnrealSharp.GameplayTags.FGameplayTagContainer removedTags)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnComponentTagRemoved_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnComponentTagRemoved_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentTagRemoved_Component_Offset), 0, component);
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentTagRemoved_RemovedTags_Offset), 0, removedTags);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnComponentTagRemoved_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // OnComponentUnregistered
    static IntPtr OnComponentUnregistered_NativeFunction;
    static int OnComponentUnregistered_ParamsSize;
    static int OnComponentUnregistered_Component_Offset;
    
    [UFunction, GeneratedType("OnComponentUnregistered")]
    protected void OnComponentUnregistered(UnrealSharp.Flow.UFlowComponent component)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[OnComponentUnregistered_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(OnComponentUnregistered_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowComponent>.ToNative(IntPtr.Add(ParamsBuffer, OnComponentUnregistered_Component_Offset), 0, component);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnComponentUnregistered_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // OnEventReceived
    static IntPtr OnEventReceived_NativeFunction;
    
    [UFunction, GeneratedType("OnEventReceived")]
    protected void OnEventReceived()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnEventReceived_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}