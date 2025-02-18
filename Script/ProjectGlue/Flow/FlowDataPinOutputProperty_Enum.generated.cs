using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Wrapper struct for an enum that will generate and link to a Data Pin with its same name
/// </summary>
[UStruct, GeneratedType("FlowDataPinOutputProperty_Enum", "UnrealSharp.Flow.FlowDataPinOutputProperty_Enum")]
public partial struct FFlowDataPinOutputProperty_Enum : MarshalledStruct<FFlowDataPinOutputProperty_Enum>
{
    // Value
    
    static int Value_Offset;
    /// <summary>
    /// The selected enum Value
    /// </summary>
    public FName Value;
    
    // EnumClass
    
    static int EnumClass_Offset;
    /// <summary>
    /// Class for this enum
    /// </summary>
    public UnrealSharp.CoreUObject.UEnum EnumClass;
    
    // EnumName
    
    static int EnumName_Offset;
    static IntPtr EnumName_NativeProperty;
    /// <summary>
    /// name of enum defined in c++ code, will take priority over asset from EnumType property
    ///  (this is a work-around because EnumClass cannot find C++ Enums,
    ///   so you need to type the name of the enum in here, manually)
    /// See also: UBlackboardKeyType_Enum::PostEditChangeProperty()
    /// </summary>
    public string EnumName;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowDataPinOutputProperty_Enum()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowDataPinOutputProperty_Enum");
        IntPtr Value_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Value");
        Value_Offset = FPropertyExporter.CallGetPropertyOffset(Value_NativeProperty);
        IntPtr EnumClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EnumClass");
        EnumClass_Offset = FPropertyExporter.CallGetPropertyOffset(EnumClass_NativeProperty);
        #if WITH_EDITOR
        EnumName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EnumName");
        EnumName_Offset = FPropertyExporter.CallGetPropertyOffset(EnumName_NativeProperty);
        #endif
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowDataPinOutputProperty_Enum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0);
            EnumClass = ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.FromNative(IntPtr.Add(InNativeStruct, EnumClass_Offset), 0);
            #if WITH_EDITOR
            IntPtr EnumName_NativePtr = IntPtr.Add(InNativeStruct,EnumName_Offset);
            EnumName = StringMarshaller.FromNative(EnumName_NativePtr,0);
            #endif
        }
    }
    
    public static FFlowDataPinOutputProperty_Enum FromNative(IntPtr buffer) => new FFlowDataPinOutputProperty_Enum(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, Value_Offset), 0, Value);
            ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.ToNative(IntPtr.Add(buffer, EnumClass_Offset), 0, EnumClass);
            #if WITH_EDITOR
            IntPtr EnumName_NativePtr = IntPtr.Add(buffer, EnumName_Offset);
            StringMarshaller.ToNative(EnumName_NativePtr,0,EnumName);
            #endif
        }
    }
}

public static class FFlowDataPinOutputProperty_EnumMarshaller
{
    public static FFlowDataPinOutputProperty_Enum FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowDataPinOutputProperty_Enum(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowDataPinOutputProperty_Enum obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowDataPinOutputProperty_Enum.NativeDataSize;
    }
}