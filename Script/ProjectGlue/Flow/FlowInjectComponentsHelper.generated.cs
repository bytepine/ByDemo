using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Configuration helper struct for injecting components onto actors
/// </summary>
[UStruct, GeneratedType("FlowInjectComponentsHelper", "UnrealSharp.Flow.FlowInjectComponentsHelper")]
public partial struct FFlowInjectComponentsHelper : MarshalledStruct<FFlowInjectComponentsHelper>
{
    // ComponentTemplates
    
    static int ComponentTemplates_Offset;
    static IntPtr ComponentTemplates_NativeProperty;
    static ArrayCopyMarshaller<UnrealSharp.Engine.UActorComponent> ComponentTemplates_Marshaller = null;
    /// <summary>
    /// Component (template) to inject on the spawned actor
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.Engine.UActorComponent> ComponentTemplates;
    
    // ComponentClasses
    
    static int ComponentClasses_Offset;
    static IntPtr ComponentClasses_NativeProperty;
    static ArrayCopyMarshaller<TSubclassOf<UnrealSharp.Engine.UActorComponent>> ComponentClasses_Marshaller = null;
    /// <summary>
    /// Component (template) to inject on the spawned actor
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Engine.UActorComponent>> ComponentClasses;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowInjectComponentsHelper()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowInjectComponentsHelper");
        ComponentTemplates_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentTemplates");
        ComponentTemplates_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentTemplates_NativeProperty);
        ComponentClasses_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ComponentClasses");
        ComponentClasses_Offset = FPropertyExporter.CallGetPropertyOffset(ComponentClasses_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowInjectComponentsHelper(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentTemplates_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Engine.UActorComponent>(ComponentTemplates_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative, ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative);
            IntPtr ComponentTemplates_NativeBuffer = IntPtr.Add(InNativeStruct, ComponentTemplates_Offset);
            ComponentTemplates = ComponentTemplates_Marshaller.FromNative(ComponentTemplates_NativeBuffer, 0);
            ComponentClasses_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.Engine.UActorComponent>>(ComponentClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative, SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative);
            IntPtr ComponentClasses_NativeBuffer = IntPtr.Add(InNativeStruct, ComponentClasses_Offset);
            ComponentClasses = ComponentClasses_Marshaller.FromNative(ComponentClasses_NativeBuffer, 0);
        }
    }
    
    public static FFlowInjectComponentsHelper FromNative(IntPtr buffer) => new FFlowInjectComponentsHelper(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            ComponentTemplates_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Engine.UActorComponent>(ComponentTemplates_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative, ObjectMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative);
            IntPtr ComponentTemplates_NativeBuffer = IntPtr.Add(buffer, ComponentTemplates_Offset);
            ComponentTemplates_Marshaller.ToNative(ComponentTemplates_NativeBuffer, 0, ComponentTemplates);
            ComponentClasses_Marshaller ??= new ArrayCopyMarshaller<TSubclassOf<UnrealSharp.Engine.UActorComponent>>(ComponentClasses_NativeProperty, SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.ToNative, SubclassOfMarshaller<UnrealSharp.Engine.UActorComponent>.FromNative);
            IntPtr ComponentClasses_NativeBuffer = IntPtr.Add(buffer, ComponentClasses_Offset);
            ComponentClasses_Marshaller.ToNative(ComponentClasses_NativeBuffer, 0, ComponentClasses);
        }
    }
}

public static class FFlowInjectComponentsHelperMarshaller
{
    public static FFlowInjectComponentsHelper FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowInjectComponentsHelper(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowInjectComponentsHelper obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowInjectComponentsHelper.NativeDataSize;
    }
}