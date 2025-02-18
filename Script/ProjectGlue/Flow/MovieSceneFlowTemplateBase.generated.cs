using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("MovieSceneFlowTemplateBase", "UnrealSharp.Flow.MovieSceneFlowTemplateBase")]
public partial struct FMovieSceneFlowTemplateBase : MarshalledStruct<FMovieSceneFlowTemplateBase>
{
    // CompletionMode
    
    static int CompletionMode_Offset;
    /// <summary>
    /// Enumeration value signifying whether we should restore any animated state stored by this entity when this eval tempalte is no longer evaluated
    /// </summary>
    public UnrealSharp.MovieScene.EMovieSceneCompletionMode CompletionMode;
    
    // SourceSectionPtr
    
    static int SourceSectionPtr_Offset;
    /// <summary>
    /// The section from which this template originates
    /// </summary>
    public TWeakObjectPtr<UnrealSharp.MovieScene.UMovieSceneSection> SourceSectionPtr;
    
    // FireEventsWhenForwards
    
    static byte bFireEventsWhenForwards_FieldMask;
    static int bFireEventsWhenForwards_Offset;
    public bool FireEventsWhenForwards;
    
    // FireEventsWhenBackwards
    
    static byte bFireEventsWhenBackwards_FieldMask;
    static int bFireEventsWhenBackwards_Offset;
    public bool FireEventsWhenBackwards;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FMovieSceneFlowTemplateBase()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneFlowTemplateBase");
        IntPtr CompletionMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CompletionMode");
        CompletionMode_Offset = FPropertyExporter.CallGetPropertyOffset(CompletionMode_NativeProperty);
        IntPtr SourceSectionPtr_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SourceSectionPtr");
        SourceSectionPtr_Offset = FPropertyExporter.CallGetPropertyOffset(SourceSectionPtr_NativeProperty);
        bFireEventsWhenForwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenForwards");
        IntPtr bFireEventsWhenForwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenForwards");
        bFireEventsWhenForwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenForwards_NativeProperty);
        bFireEventsWhenBackwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        IntPtr bFireEventsWhenBackwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        bFireEventsWhenBackwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenBackwards_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FMovieSceneFlowTemplateBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            CompletionMode = EnumMarshaller<UnrealSharp.MovieScene.EMovieSceneCompletionMode>.FromNative(IntPtr.Add(InNativeStruct, CompletionMode_Offset), 0);
            SourceSectionPtr = BlittableMarshaller<TWeakObjectPtr<UnrealSharp.MovieScene.UMovieSceneSection>>.FromNative(IntPtr.Add(InNativeStruct, SourceSectionPtr_Offset), 0);
            FireEventsWhenForwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask);
            FireEventsWhenBackwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask);
        }
    }
    
    public static FMovieSceneFlowTemplateBase FromNative(IntPtr buffer) => new FMovieSceneFlowTemplateBase(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            EnumMarshaller<UnrealSharp.MovieScene.EMovieSceneCompletionMode>.ToNative(IntPtr.Add(buffer, CompletionMode_Offset), 0, CompletionMode);
            BlittableMarshaller<TWeakObjectPtr<UnrealSharp.MovieScene.UMovieSceneSection>>.ToNative(IntPtr.Add(buffer, SourceSectionPtr_Offset), 0, SourceSectionPtr);
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask, FireEventsWhenForwards);
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask, FireEventsWhenBackwards);
        }
    }
}

public static class FMovieSceneFlowTemplateBaseMarshaller
{
    public static FMovieSceneFlowTemplateBase FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FMovieSceneFlowTemplateBase(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FMovieSceneFlowTemplateBase obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FMovieSceneFlowTemplateBase.NativeDataSize;
    }
}