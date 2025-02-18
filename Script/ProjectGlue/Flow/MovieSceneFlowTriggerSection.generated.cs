using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Flow section that triggers specific timed events.
/// </summary>
[UClass, GeneratedType("MovieSceneFlowTriggerSection", "UnrealSharp.Flow.MovieSceneFlowTriggerSection")]
public partial class UMovieSceneFlowTriggerSection : UnrealSharp.Flow.UMovieSceneFlowSectionBase
{
    static readonly IntPtr NativeClassPtr;
    static UMovieSceneFlowTriggerSection()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneFlowTriggerSection");
        IntPtr StringChannel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "StringChannel");
        StringChannel_Offset = FPropertyExporter.CallGetPropertyOffset(StringChannel_NativeProperty);
    }
    
    static int StringChannel_Offset;
    
    /// <summary>
    /// The channel that defines this section's timed events
    /// </summary>
    public UnrealSharp.MovieSceneTracks.FMovieSceneStringChannel StringChannel
    {
        get
        {
            return StructMarshaller<UnrealSharp.MovieSceneTracks.FMovieSceneStringChannel>.FromNative(IntPtr.Add(NativeObject, StringChannel_Offset), 0);
        }
    }
    
    
}