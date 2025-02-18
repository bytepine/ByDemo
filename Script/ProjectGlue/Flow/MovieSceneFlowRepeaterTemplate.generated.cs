using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("MovieSceneFlowRepeaterTemplate", "UnrealSharp.Flow.MovieSceneFlowRepeaterTemplate")]
public partial struct FMovieSceneFlowRepeaterTemplate : MarshalledStruct<FMovieSceneFlowRepeaterTemplate>
{
    // FireEventsWhenForwards
    
    static byte bFireEventsWhenForwards_FieldMask;
    static int bFireEventsWhenForwards_Offset;
    public bool FireEventsWhenForwards;
    
    // FireEventsWhenBackwards
    
    static byte bFireEventsWhenBackwards_FieldMask;
    static int bFireEventsWhenBackwards_Offset;
    public bool FireEventsWhenBackwards;
    
    // EventName
    
    static int EventName_Offset;
    static IntPtr EventName_NativeProperty;
    public string EventName;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FMovieSceneFlowRepeaterTemplate()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneFlowRepeaterTemplate");
        bFireEventsWhenForwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenForwards");
        IntPtr bFireEventsWhenForwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenForwards");
        bFireEventsWhenForwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenForwards_NativeProperty);
        bFireEventsWhenBackwards_FieldMask = FPropertyExporter.CallGetBoolPropertyFieldMaskFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        IntPtr bFireEventsWhenBackwards_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bFireEventsWhenBackwards");
        bFireEventsWhenBackwards_Offset = FPropertyExporter.CallGetPropertyOffset(bFireEventsWhenBackwards_NativeProperty);
        EventName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EventName");
        EventName_Offset = FPropertyExporter.CallGetPropertyOffset(EventName_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FMovieSceneFlowRepeaterTemplate(IntPtr InNativeStruct)
    {
        unsafe
        {
            FireEventsWhenForwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask);
            FireEventsWhenBackwards = BitfieldBoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask);
            IntPtr EventName_NativePtr = IntPtr.Add(InNativeStruct,EventName_Offset);
            EventName = StringMarshaller.FromNative(EventName_NativePtr,0);
        }
    }
    
    public static FMovieSceneFlowRepeaterTemplate FromNative(IntPtr buffer) => new FMovieSceneFlowRepeaterTemplate(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenForwards_Offset), bFireEventsWhenForwards_FieldMask, FireEventsWhenForwards);
            BitfieldBoolMarshaller.ToNative(IntPtr.Add(buffer, bFireEventsWhenBackwards_Offset), bFireEventsWhenBackwards_FieldMask, FireEventsWhenBackwards);
            IntPtr EventName_NativePtr = IntPtr.Add(buffer, EventName_Offset);
            StringMarshaller.ToNative(EventName_NativePtr,0,EventName);
        }
    }
}

public static class FMovieSceneFlowRepeaterTemplateMarshaller
{
    public static FMovieSceneFlowRepeaterTemplate FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FMovieSceneFlowRepeaterTemplate(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FMovieSceneFlowRepeaterTemplate obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FMovieSceneFlowRepeaterTemplate.NativeDataSize;
    }
}