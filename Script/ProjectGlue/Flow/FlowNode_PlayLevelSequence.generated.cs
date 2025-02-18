using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Order of triggering outputs after calling Start
/// - PreStart, just before starting playback
/// - Started
/// - Out (always, even if Sequence is invalid)
/// - Completed
/// </summary>
[UClass, GeneratedType("FlowNode_PlayLevelSequence", "UnrealSharp.Flow.FlowNode_PlayLevelSequence")]
public partial class UFlowNode_PlayLevelSequence : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_PlayLevelSequence()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_PlayLevelSequence");
        IntPtr Sequence_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Sequence");
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffset(Sequence_NativeProperty);
        IntPtr PlaybackSettings_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PlaybackSettings");
        PlaybackSettings_Offset = FPropertyExporter.CallGetPropertyOffset(PlaybackSettings_NativeProperty);
        IntPtr bPlayReverse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPlayReverse");
        bPlayReverse_Offset = FPropertyExporter.CallGetPropertyOffset(bPlayReverse_NativeProperty);
        IntPtr CameraSettings_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CameraSettings");
        CameraSettings_Offset = FPropertyExporter.CallGetPropertyOffset(CameraSettings_NativeProperty);
        IntPtr bUseGraphOwnerAsTransformOrigin_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseGraphOwnerAsTransformOrigin");
        bUseGraphOwnerAsTransformOrigin_Offset = FPropertyExporter.CallGetPropertyOffset(bUseGraphOwnerAsTransformOrigin_NativeProperty);
        IntPtr bReplicates_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReplicates");
        bReplicates_Offset = FPropertyExporter.CallGetPropertyOffset(bReplicates_NativeProperty);
        IntPtr bAlwaysRelevant_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAlwaysRelevant");
        bAlwaysRelevant_Offset = FPropertyExporter.CallGetPropertyOffset(bAlwaysRelevant_NativeProperty);
        IntPtr bApplyOwnerTimeDilation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bApplyOwnerTimeDilation");
        bApplyOwnerTimeDilation_Offset = FPropertyExporter.CallGetPropertyOffset(bApplyOwnerTimeDilation_NativeProperty);
        IntPtr LoadedSequence_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LoadedSequence");
        LoadedSequence_Offset = FPropertyExporter.CallGetPropertyOffset(LoadedSequence_NativeProperty);
        IntPtr SequencePlayer_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SequencePlayer");
        SequencePlayer_Offset = FPropertyExporter.CallGetPropertyOffset(SequencePlayer_NativeProperty);
        IntPtr StartTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "StartTime");
        StartTime_Offset = FPropertyExporter.CallGetPropertyOffset(StartTime_NativeProperty);
        IntPtr ElapsedTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ElapsedTime");
        ElapsedTime_Offset = FPropertyExporter.CallGetPropertyOffset(ElapsedTime_NativeProperty);
        IntPtr TimeDilation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TimeDilation");
        TimeDilation_Offset = FPropertyExporter.CallGetPropertyOffset(TimeDilation_NativeProperty);
        OnPlaybackFinished_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnPlaybackFinished");
    }
    
    static int Sequence_Offset;
    
    public TSoftObjectPtr<UnrealSharp.LevelSequence.ULevelSequence> Sequence
    {
        get
        {
            return SoftObjectMarshaller<UnrealSharp.LevelSequence.ULevelSequence>.FromNative(IntPtr.Add(NativeObject, Sequence_Offset), 0);
        }
        set
        {
            SoftObjectMarshaller<UnrealSharp.LevelSequence.ULevelSequence>.ToNative(IntPtr.Add(NativeObject, Sequence_Offset), 0, value);
        }
    }
    
    
    static int PlaybackSettings_Offset;
    
    public UnrealSharp.MovieScene.FMovieSceneSequencePlaybackSettings PlaybackSettings
    {
        get
        {
            return StructMarshaller<UnrealSharp.MovieScene.FMovieSceneSequencePlaybackSettings>.FromNative(IntPtr.Add(NativeObject, PlaybackSettings_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.MovieScene.FMovieSceneSequencePlaybackSettings>.ToNative(IntPtr.Add(NativeObject, PlaybackSettings_Offset), 0, value);
        }
    }
    
    
    static int bPlayReverse_Offset;
    
    public bool PlayReverse
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bPlayReverse_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bPlayReverse_Offset), 0, value);
        }
    }
    
    
    static int CameraSettings_Offset;
    
    public UnrealSharp.LevelSequence.FLevelSequenceCameraSettings CameraSettings
    {
        get
        {
            return StructMarshaller<UnrealSharp.LevelSequence.FLevelSequenceCameraSettings>.FromNative(IntPtr.Add(NativeObject, CameraSettings_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.LevelSequence.FLevelSequenceCameraSettings>.ToNative(IntPtr.Add(NativeObject, CameraSettings_Offset), 0, value);
        }
    }
    
    
    static int bUseGraphOwnerAsTransformOrigin_Offset;
    
    /// <summary>
    /// Level Sequence playback can be moved to any place in the world by applying Transform Origin
    /// Enabling this option will use actor that created Root Flow instance, i.e. World Settings or Player Controller
    /// https:docs.unrealengine.com/5.0/en-US/creating-level-sequences-with-dynamic-transforms-in-unreal-engine/
    /// </summary>
    public bool UseGraphOwnerAsTransformOrigin
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseGraphOwnerAsTransformOrigin_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseGraphOwnerAsTransformOrigin_Offset), 0, value);
        }
    }
    
    
    static int bReplicates_Offset;
    
    /// <summary>
    /// If true, playback of this level sequence on the server will be synchronized across other clients
    /// </summary>
    public bool Replicates
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bReplicates_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bReplicates_Offset), 0, value);
        }
    }
    
    
    static int bAlwaysRelevant_Offset;
    
    /// <summary>
    /// Always relevant for network (overrides bOnlyRelevantToOwner)
    /// </summary>
    public bool AlwaysRelevant
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAlwaysRelevant_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAlwaysRelevant_Offset), 0, value);
        }
    }
    
    
    static int bApplyOwnerTimeDilation_Offset;
    
    /// <summary>
    /// If True, Play Rate will by multiplied by Custom Time Dilation
    /// Enabling this option will use Custom Time Dilation from actor that created Root Flow instance, i.e. World Settings or Player Controller
    /// </summary>
    public bool ApplyOwnerTimeDilation
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bApplyOwnerTimeDilation_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bApplyOwnerTimeDilation_Offset), 0, value);
        }
    }
    
    
    static int LoadedSequence_Offset;
    
    protected UnrealSharp.LevelSequence.ULevelSequence LoadedSequence
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.LevelSequence.ULevelSequence>.FromNative(IntPtr.Add(NativeObject, LoadedSequence_Offset), 0);
        }
    }
    
    
    static int SequencePlayer_Offset;
    
    protected UnrealSharp.Flow.UFlowLevelSequencePlayer SequencePlayer
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Flow.UFlowLevelSequencePlayer>.FromNative(IntPtr.Add(NativeObject, SequencePlayer_Offset), 0);
        }
    }
    
    
    static int StartTime_Offset;
    
    protected float StartTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, StartTime_Offset), 0);
        }
    }
    
    
    static int ElapsedTime_Offset;
    
    protected float ElapsedTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ElapsedTime_Offset), 0);
        }
    }
    
    
    static int TimeDilation_Offset;
    
    protected float TimeDilation
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, TimeDilation_Offset), 0);
        }
    }
    
    // OnPlaybackFinished
    static IntPtr OnPlaybackFinished_NativeFunction;
    
    [UFunction, GeneratedType("OnPlaybackFinished")]
    protected void OnPlaybackFinished()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPlaybackFinished_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}