using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Flow section that will trigger its event exactly once, every time it is evaluated.
/// </summary>
[UClass, GeneratedType("MovieSceneFlowRepeaterSection", "UnrealSharp.Flow.MovieSceneFlowRepeaterSection")]
public partial class UMovieSceneFlowRepeaterSection : UnrealSharp.Flow.UMovieSceneFlowSectionBase
{
    static readonly IntPtr NativeClassPtr;
    static UMovieSceneFlowRepeaterSection()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneFlowRepeaterSection");
        EventName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventName");
        EventName_Offset = FPropertyExporter.CallGetPropertyOffset(EventName_NativeProperty);
    }
    
    static int EventName_Offset;
    static IntPtr EventName_NativeProperty;
    
    /// <summary>
    /// The event that should be triggered each time this section is evaluated
    /// </summary>
    public string EventName
    {
        get
        {
            IntPtr EventName_NativePtr = IntPtr.Add(NativeObject,EventName_Offset);
            return StringMarshaller.FromNative(EventName_NativePtr,0);
        }
        set
        {
            IntPtr EventName_NativePtr = IntPtr.Add(NativeObject, EventName_Offset);
            StringMarshaller.ToNative(EventName_NativePtr,0,value);
        }
    }
    
    
}