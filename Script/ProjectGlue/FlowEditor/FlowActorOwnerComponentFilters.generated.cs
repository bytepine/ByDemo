using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Metadata-derived filters to describe qualifying UActorComponents
/// for a given FFlowActorOwnerComponentRef
/// </summary>
[UStruct, GeneratedType("FlowActorOwnerComponentFilters", "UnrealSharp.FlowEditor.FlowActorOwnerComponentFilters")]
public partial struct FFlowActorOwnerComponentFilters : MarshalledStruct<FFlowActorOwnerComponentFilters>
{
    // AllowedComponentClassFilters
    
    static int AllowedComponentClassFilters_Offset;
    static IntPtr AllowedComponentClassFilters_NativeProperty;
    static ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>> AllowedComponentClassFilters_Marshaller = null;
    /// <summary>
    /// Classes that can be used with this property
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.CoreUObject.UObject>> AllowedComponentClassFilters;
    
    // DisallowedComponentClassFilters
    
    static int DisallowedComponentClassFilters_Offset;
    static IntPtr DisallowedComponentClassFilters_NativeProperty;
    static ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>> DisallowedComponentClassFilters_Marshaller = null;
    /// <summary>
    /// Classes that can NOT be used with this property
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.CoreUObject.UObject>> DisallowedComponentClassFilters;
    
    // RequiredInterfaceFilters
    
    static int RequiredInterfaceFilters_Offset;
    static IntPtr RequiredInterfaceFilters_NativeProperty;
    static ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>> RequiredInterfaceFilters_Marshaller = null;
    /// <summary>
    /// Must implement (all) interface(s)
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.CoreUObject.UObject>> RequiredInterfaceFilters;
    
    // HasBuiltFilters
    
    static int bHasBuiltFilters_Offset;
    /// <summary>
    /// Has BuildClassFiltersFromMetadata been called?
    /// </summary>
    public bool HasBuiltFilters;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowActorOwnerComponentFilters()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowActorOwnerComponentFilters");
        #if WITH_EDITOR
        AllowedComponentClassFilters_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AllowedComponentClassFilters");
        AllowedComponentClassFilters_Offset = FPropertyExporter.CallGetPropertyOffset(AllowedComponentClassFilters_NativeProperty);
        #endif
        #if WITH_EDITOR
        DisallowedComponentClassFilters_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DisallowedComponentClassFilters");
        DisallowedComponentClassFilters_Offset = FPropertyExporter.CallGetPropertyOffset(DisallowedComponentClassFilters_NativeProperty);
        #endif
        #if WITH_EDITOR
        RequiredInterfaceFilters_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RequiredInterfaceFilters");
        RequiredInterfaceFilters_Offset = FPropertyExporter.CallGetPropertyOffset(RequiredInterfaceFilters_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr bHasBuiltFilters_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHasBuiltFilters");
        bHasBuiltFilters_Offset = FPropertyExporter.CallGetPropertyOffset(bHasBuiltFilters_NativeProperty);
        #endif
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowActorOwnerComponentFilters(IntPtr InNativeStruct)
    {
        unsafe
        {
            #if WITH_EDITOR
            AllowedComponentClassFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(AllowedComponentClassFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr AllowedComponentClassFilters_NativeBuffer = IntPtr.Add(InNativeStruct, AllowedComponentClassFilters_Offset);
            AllowedComponentClassFilters = AllowedComponentClassFilters_Marshaller.FromNative(AllowedComponentClassFilters_NativeBuffer, 0);
            #endif
            #if WITH_EDITOR
            DisallowedComponentClassFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(DisallowedComponentClassFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr DisallowedComponentClassFilters_NativeBuffer = IntPtr.Add(InNativeStruct, DisallowedComponentClassFilters_Offset);
            DisallowedComponentClassFilters = DisallowedComponentClassFilters_Marshaller.FromNative(DisallowedComponentClassFilters_NativeBuffer, 0);
            #endif
            #if WITH_EDITOR
            RequiredInterfaceFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(RequiredInterfaceFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr RequiredInterfaceFilters_NativeBuffer = IntPtr.Add(InNativeStruct, RequiredInterfaceFilters_Offset);
            RequiredInterfaceFilters = RequiredInterfaceFilters_Marshaller.FromNative(RequiredInterfaceFilters_NativeBuffer, 0);
            #endif
            #if WITH_EDITOR
            HasBuiltFilters = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHasBuiltFilters_Offset), 0);
            #endif
        }
    }
    
    public static FFlowActorOwnerComponentFilters FromNative(IntPtr buffer) => new FFlowActorOwnerComponentFilters(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            #if WITH_EDITOR
            AllowedComponentClassFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(AllowedComponentClassFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr AllowedComponentClassFilters_NativeBuffer = IntPtr.Add(buffer, AllowedComponentClassFilters_Offset);
            AllowedComponentClassFilters_Marshaller.ToNative(AllowedComponentClassFilters_NativeBuffer, 0, AllowedComponentClassFilters);
            #endif
            #if WITH_EDITOR
            DisallowedComponentClassFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(DisallowedComponentClassFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr DisallowedComponentClassFilters_NativeBuffer = IntPtr.Add(buffer, DisallowedComponentClassFilters_Offset);
            DisallowedComponentClassFilters_Marshaller.ToNative(DisallowedComponentClassFilters_NativeBuffer, 0, DisallowedComponentClassFilters);
            #endif
            #if WITH_EDITOR
            RequiredInterfaceFilters_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.CoreUObject.UObject>>(RequiredInterfaceFilters_NativeProperty, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative, SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative);
            IntPtr RequiredInterfaceFilters_NativeBuffer = IntPtr.Add(buffer, RequiredInterfaceFilters_Offset);
            RequiredInterfaceFilters_Marshaller.ToNative(RequiredInterfaceFilters_NativeBuffer, 0, RequiredInterfaceFilters);
            #endif
            #if WITH_EDITOR
            BoolMarshaller.ToNative(IntPtr.Add(buffer, bHasBuiltFilters_Offset), 0, HasBuiltFilters);
            #endif
        }
    }
}

public static class FFlowActorOwnerComponentFiltersMarshaller
{
    public static FFlowActorOwnerComponentFilters FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowActorOwnerComponentFilters(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowActorOwnerComponentFilters obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowActorOwnerComponentFilters.NativeDataSize;
    }
}