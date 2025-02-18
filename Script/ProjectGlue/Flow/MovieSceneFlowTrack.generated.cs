using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Implements a movie scene track that triggers events in the Flow System during playback.
/// </summary>
[UClass, GeneratedType("MovieSceneFlowTrack", "UnrealSharp.Flow.MovieSceneFlowTrack")]
public partial class UMovieSceneFlowTrack : UnrealSharp.MovieScene.UMovieSceneNameableTrack, UnrealSharp.MovieScene.IMovieSceneTrackTemplateProducer
{
    static readonly IntPtr NativeClassPtr;
    static UMovieSceneFlowTrack()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneFlowTrack");
        bFireEventsWhenForwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenForwards");
        IntPtr bFireEventsWhenForwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenForwards");
        bFireEventsWhenForwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenForwards_NativeProperty);
        bFireEventsWhenBackwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        IntPtr bFireEventsWhenBackwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        bFireEventsWhenBackwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenBackwards_NativeProperty);
        IntPtr EventPosition_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventPosition");
        EventPosition_Offset = FPropertyExporter.CallGetPropertyOffset(EventPosition_NativeProperty);
        Sections_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Sections");
        Sections_Offset = FPropertyExporter.CallGetPropertyOffset(Sections_NativeProperty);
    }
    
    static byte bFireEventsWhenForwards_FieldMask;
    static int bFireEventsWhenForwards_Offset;
    
    /// <summary>
    /// If events should be fired when passed playing the sequence forwards.
    /// </summary>
    public bool FireEventsWhenForwards
    {
        get
        {
            return BitfieldBoolMarshaller.FromNative(IntPtr.Add(NativeObject, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask);
        }
        set
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(NativeObject, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask, value);
        }
    }
    
    
    static byte bFireEventsWhenBackwards_FieldMask;
    static int bFireEventsWhenBackwards_Offset;
    
    /// <summary>
    /// If events should be fired when passed playing the sequence backwards.
    /// </summary>
    public bool FireEventsWhenBackwards
    {
        get
        {
            return BitfieldBoolMarshaller.FromNative(IntPtr.Add(NativeObject, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask);
        }
        set
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(NativeObject, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask, value);
        }
    }
    
    
    static int EventPosition_Offset;
    
    /// <summary>
    /// Defines where in the evaluation to trigger events
    /// </summary>
    public UnrealSharp.MovieSceneTracks.EFireEventsAtPosition EventPosition
    {
        get
        {
            return EnumMarshaller<UnrealSharp.MovieSceneTracks.EFireEventsAtPosition>.FromNative(IntPtr.Add(NativeObject, EventPosition_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.MovieSceneTracks.EFireEventsAtPosition>.ToNative(IntPtr.Add(NativeObject, EventPosition_Offset), 0, value);
        }
    }
    
    
    static int Sections_Offset;
    static IntPtr Sections_NativeProperty;
    ArrayMarshaller<UnrealSharp.MovieScene.UMovieSceneSection> Sections_Marshaller = null;
    
    /// <summary>
    /// The track's sections.
    /// </summary>
    private System.Collections.Generic.IList<UnrealSharp.MovieScene.UMovieSceneSection> Sections
    {
        get
        {
            Sections_Marshaller ??= new ArrayMarshaller<UnrealSharp.MovieScene.UMovieSceneSection>(Sections_NativeProperty, ObjectMarshaller<UnrealSharp.MovieScene.UMovieSceneSection>.ToNative, ObjectMarshaller<UnrealSharp.MovieScene.UMovieSceneSection>.FromNative);
            return Sections_Marshaller.FromNative(IntPtr.Add(NativeObject, Sections_Offset), 0);
        }
    }
    
    
}