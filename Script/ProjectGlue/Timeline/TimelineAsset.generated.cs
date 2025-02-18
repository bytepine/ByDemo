using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Timeline;

[UClass, GeneratedType("TimelineAsset", "UnrealSharp.Timeline.TimelineAsset")]
public partial class UTimelineAsset : UnrealSharp.CoreUObject.UObject
{
    static readonly IntPtr NativeClassPtr;
    static UTimelineAsset()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TimelineAsset");
        IntPtr PlayRate_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PlayRate");
        PlayRate_Offset = FPropertyExporter.CallGetPropertyOffset(PlayRate_NativeProperty);
    }
    
    static int PlayRate_Offset;
    
    protected float PlayRate
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, PlayRate_Offset), 0);
        }
        init
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, PlayRate_Offset), 0, value);
        }
    }
    
    
}