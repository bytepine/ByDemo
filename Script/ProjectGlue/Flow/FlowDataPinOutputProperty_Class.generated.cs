using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for a UClass that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Class", "UnrealSharp.Flow.FlowDataPinOutputProperty_Class")]
public partial struct FFlowDataPinOutputProperty_Class : MarshalledStruct<FFlowDataPinOutputProperty_Class>
{
    // Value
    
    static int Value_Offset;
    public UnrealSharp.CoreUObject.FSoftClassPath Value;
    
    // ClassFilter
    
    static int ClassFilter_Offset;
    public TSubclassOf<UnrealSharp.CoreUObject.UObject> ClassFilter;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Class()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Class");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        #if WITH_EDITOR
        IntPtr ClassFilter_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ClassFilter");
        ClassFilter_Offset = FPropertyExporter.CallGetPropertyOffset(ClassFilter_NativeProperty);
        #endif
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Class(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
            #if WITH_EDITOR
            ClassFilter = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, ClassFilter_Offset), 0);
            #endif
        }
    }
    
    public static FFlowDataPinOutputProperty_Class FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Class(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
            #if WITH_EDITOR
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, ClassFilter_Offset), 0, ClassFilter);
            #endif
        }
    }
}

public static class FFlowDataPinOutputProperty_ClassMarshaller
{
    public static FFlowDataPinOutputProperty_Class FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Class(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Class obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Class.NativeDataSize;
    }
}