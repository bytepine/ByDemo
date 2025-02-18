using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Custom ALevelSequenceActor is needed to override ULevelSequencePlayer class
/// </summary>
[UClass, GeneratedType("FlowLevelSequenceActor", "UnrealSharp.Flow.FlowLevelSequenceActor")]
public partial class AFlowLevelSequenceActor : UnrealSharp.LevelSequence.ALevelSequenceActor
{
    static readonly IntPtr NativeClassPtr;
    static AFlowLevelSequenceActor()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowLevelSequenceActor");
        IntPtr ReplicatedLevelSequenceAsset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ReplicatedLevelSequenceAsset");
        ReplicatedLevelSequenceAsset_Offset = FPropertyExporter.CallGetPropertyOffset(ReplicatedLevelSequenceAsset_NativeProperty);
        OnRep_ReplicatedLevelSequenceAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnRep_ReplicatedLevelSequenceAsset");
    }
    
    static int ReplicatedLevelSequenceAsset_Offset;
    
    protected UnrealSharp.LevelSequence.ULevelSequence ReplicatedLevelSequenceAsset
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.LevelSequence.ULevelSequence>.FromNative(IntPtr.Add(NativeObject, ReplicatedLevelSequenceAsset_Offset), 0);
        }
    }
    
    // OnRep_ReplicatedLevelSequenceAsset
    static IntPtr OnRep_ReplicatedLevelSequenceAsset_NativeFunction;
    
    [UFunction, GeneratedType("OnRep_ReplicatedLevelSequenceAsset")]
    protected void OnRep_ReplicatedLevelSequenceAsset()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnRep_ReplicatedLevelSequenceAsset_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}