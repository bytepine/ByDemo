using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("MovieSceneFlowTriggerTemplate", "UnrealSharp.Flow.MovieSceneFlowTriggerTemplate")]
public partial struct FMovieSceneFlowTriggerTemplate : MarshalledStruct<FMovieSceneFlowTriggerTemplate>
{
    // FireEventsWhenForwards
    
    static byte bFireEventsWhenForwards_FieldMask;
    static int bFireEventsWhenForwards_Offset;
    public bool FireEventsWhenForwards;
    
    // FireEventsWhenBackwards
    
    static byte bFireEventsWhenBackwards_FieldMask;
    static int bFireEventsWhenBackwards_Offset;
    public bool FireEventsWhenBackwards;
    
    // EventTimes
    
    static int EventTimes_Offset;
    static IntPtr EventTimes_NativeProperty;
    static ArrayCopyMarshaller<UnrealSharp.CoreUObject.FFrameNumber> EventTimes_Marshaller = null;
    public System.Collections.Generic.IList<UnrealSharp.CoreUObject.FFrameNumber> EventTimes;
    
    // EventNames
    
    static int EventNames_Offset;
    static IntPtr EventNames_NativeProperty;
    static ArrayCopyMarshaller<string> EventNames_Marshaller = null;
    public System.Collections.Generic.IList<string> EventNames;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FMovieSceneFlowTriggerTemplate()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneFlowTriggerTemplate");
        bFireEventsWhenForwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenForwards");
        IntPtr bFireEventsWhenForwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenForwards");
        bFireEventsWhenForwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenForwards_NativeProperty);
        bFireEventsWhenBackwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        IntPtr bFireEventsWhenBackwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        bFireEventsWhenBackwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenBackwards_NativeProperty);
        EventTimes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventTimes");
        EventTimes_Offset = FPropertyExporter.CallGetPropertyOffset(EventTimes_NativeProperty);
        EventNames_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventNames");
        EventNames_Offset = FPropertyExporter.CallGetPropertyOffset(EventNames_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FMovieSceneFlowTriggerTemplate(IntPtr InNativeStruct)
    {
        unsafe
        {
            FireEventsWhenForwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask);
            FireEventsWhenBackwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask);
            EventTimes_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.CoreUObject.FFrameNumber>(EventTimes_NativeProperty, StructMarshaller<UnrealSharp.CoreUObject.FFrameNumber>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FFrameNumber>.FromNative);
            IntPtr EventTimes_NativeBuffer = IntPtr.Add(InNativeStruct, EventTimes_Offset);
            EventTimes = EventTimes_Marshaller.FromNative(EventTimes_NativeBuffer, 0);
            EventNames_Marshaller ??= new ArrayCopyMarshaller<string>(EventNames_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr EventNames_NativeBuffer = IntPtr.Add(InNativeStruct, EventNames_Offset);
            EventNames = EventNames_Marshaller.FromNative(EventNames_NativeBuffer, 0);
        }
    }
    
    public static FMovieSceneFlowTriggerTemplate FromNative(IntPtr buffer) => new FMovieSceneFlowTriggerTemplate(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask, FireEventsWhenForwards);
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask, FireEventsWhenBackwards);
            EventTimes_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.CoreUObject.FFrameNumber>(EventTimes_NativeProperty, StructMarshaller<UnrealSharp.CoreUObject.FFrameNumber>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FFrameNumber>.FromNative);
            IntPtr EventTimes_NativeBuffer = IntPtr.Add(buffer, EventTimes_Offset);
            EventTimes_Marshaller.ToNative(EventTimes_NativeBuffer, 0, EventTimes);
            EventNames_Marshaller ??= new ArrayCopyMarshaller<string>(EventNames_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr EventNames_NativeBuffer = IntPtr.Add(buffer, EventNames_Offset);
            EventNames_Marshaller.ToNative(EventNames_NativeBuffer, 0, EventNames);
        }
    }
}

public static class FMovieSceneFlowTriggerTemplateMarshaller
{
    public static FMovieSceneFlowTriggerTemplate FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FMovieSceneFlowTriggerTemplate(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FMovieSceneFlowTriggerTemplate obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FMovieSceneFlowTriggerTemplate.NativeDataSize;
    }
}