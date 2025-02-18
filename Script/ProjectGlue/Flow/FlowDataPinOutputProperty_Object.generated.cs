using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a UObject that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Object", "UnrealSharp.Flow.FlowDataPinOutputProperty_Object")]
public partial struct FFlowDataPinOutputProperty_Object : MarshalledStruct<FFlowDataPinOutputProperty_Object>
{
    // ReferenceValue
    
    static int ReferenceValue_Offset;
    /// <summary>
    /// Object reference if the object is a non-instanced UObject type (ie, not EditInlineNew)
    /// </summary>
    public UnrealSharp.CoreUObject.UObject ReferenceValue;
    
    // InlineValue
    
    static int InlineValue_Offset;
    /// <summary>
    /// Ofject reference if the object is an instanced UObject type (ie, EditInlineNew)
    /// </summary>
    public UnrealSharp.CoreUObject.UObject InlineValue;
    
    // ClassFilter
    
    static int ClassFilter_Offset;
    public TSubclassOf<UnrealSharp.CoreUObject.UObject> ClassFilter;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Object()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Object");
        IntPtr ReferenceValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ReferenceValue");
        ReferenceValue_Offset = FPropertyExporter.CallGetPropertyOffset(ReferenceValue_NativeProperty);
        IntPtr InlineValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InlineValue");
        InlineValue_Offset = FPropertyExporter.CallGetPropertyOffset(InlineValue_NativeProperty);
        #if WITH_EDITOR
        IntPtr ClassFilter_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ClassFilter");
        ClassFilter_Offset = FPropertyExporter.CallGetPropertyOffset(ClassFilter_NativeProperty);
        #endif
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Object(IntPtr InNativeStruct)
    {
        unsafe
        {
            ReferenceValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, ReferenceValue_Offset), 0);
            InlineValue = ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, InlineValue_Offset), 0);
            #if WITH_EDITOR
            ClassFilter = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, ClassFilter_Offset), 0);
            #endif
        }
    }
    
    public static FFlowDataPinOutputProperty_Object FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Object(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, ReferenceValue_Offset), 0, ReferenceValue);
            ObjectMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, InlineValue_Offset), 0, InlineValue);
            #if WITH_EDITOR
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, ClassFilter_Offset), 0, ClassFilter);
            #endif
        }
    }
}

public static class FFlowDataPinOutputProperty_ObjectMarshaller
{
    public static FFlowDataPinOutputProperty_Object FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Object(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Object obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Object.NativeDataSize;
    }
}