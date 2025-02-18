using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UStruct, GeneratedType("FlowNodeDisplayStyleConfig", "UnrealSharp.FlowEditor.FlowNodeDisplayStyleConfig")]
public partial struct FFlowNodeDisplayStyleConfig : MarshalledStruct<FFlowNodeDisplayStyleConfig>
{
    // Tag
    
    static int Tag_Offset;
    public UnrealSharp.GameplayTags.FGameplayTag Tag;
    
    // TitleColor
    
    static int TitleColor_Offset;
    public UnrealSharp.CoreUObject.FLinearColor TitleColor;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowNodeDisplayStyleConfig()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowNodeDisplayStyleConfig");
        IntPtr Tag_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Tag");
        Tag_Offset = FPropertyExporter.CallGetPropertyOffset(Tag_NativeProperty);
        IntPtr TitleColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TitleColor");
        TitleColor_Offset = FPropertyExporter.CallGetPropertyOffset(TitleColor_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowNodeDisplayStyleConfig(IntPtr InNativeStruct)
    {
        unsafe
        {
            Tag = StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0);
            TitleColor = StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(InNativeStruct, TitleColor_Offset), 0);
        }
    }
    
    public static FFlowNodeDisplayStyleConfig FromNative(IntPtr buffer) => new FFlowNodeDisplayStyleConfig(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative(IntPtr.Add(buffer, Tag_Offset), 0, Tag);
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(buffer, TitleColor_Offset), 0, TitleColor);
        }
    }
}

public static class FFlowNodeDisplayStyleConfigMarshaller
{
    public static FFlowNodeDisplayStyleConfig FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowNodeDisplayStyleConfig(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowNodeDisplayStyleConfig obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowNodeDisplayStyleConfig.NativeDataSize;
    }
}