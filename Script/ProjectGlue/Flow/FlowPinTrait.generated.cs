using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// It can represent any trait added on the specific node instance, i.e. breakpoint
/// </summary>
[UStruct, GeneratedType("FlowPinTrait", "UnrealSharp.Flow.FlowPinTrait")]
public partial struct FFlowPinTrait : MarshalledStruct<FFlowPinTrait>
{
    // TraitAllowed
    
    static byte bTraitAllowed_FieldMask;
    static int bTraitAllowed_Offset;
    public bool TraitAllowed;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowPinTrait()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowPinTrait");
        bTraitAllowed_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bTraitAllowed");
        IntPtr bTraitAllowed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bTraitAllowed");
        bTraitAllowed_Offset = FPropertyExporter.CallGetPropertyOffset(bTraitAllowed_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowPinTrait(IntPtr InNativeStruct)
    {
        unsafe
        {
            TraitAllowed = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTraitAllowed_Offset), bTraitAllowed_FieldMask);
        }
    }
    
    public static FFlowPinTrait FromNative(IntPtr buffer) => new FFlowPinTrait(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bTraitAllowed_Offset), bTraitAllowed_FieldMask, TraitAllowed);
        }
    }
}

public static class FFlowPinTraitMarshaller
{
    public static FFlowPinTrait FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowPinTrait(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowPinTrait obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowPinTrait.NativeDataSize;
    }
}