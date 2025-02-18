using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Executes a series of pins in order
/// </summary>
[UClass, GeneratedType("FlowNode_ExecutionMultiGate", "UnrealSharp.Flow.FlowNode_ExecutionMultiGate")]
public partial class UFlowNode_ExecutionMultiGate : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_ExecutionMultiGate()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_ExecutionMultiGate");
        IntPtr bRandom_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRandom");
        bRandom_Offset = FPropertyExporter.CallGetPropertyOffset(bRandom_NativeProperty);
        IntPtr bLoop_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLoop");
        bLoop_Offset = FPropertyExporter.CallGetPropertyOffset(bLoop_NativeProperty);
        IntPtr StartIndex_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "StartIndex");
        StartIndex_Offset = FPropertyExporter.CallGetPropertyOffset(StartIndex_NativeProperty);
        IntPtr NextOutput_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NextOutput");
        NextOutput_Offset = FPropertyExporter.CallGetPropertyOffset(NextOutput_NativeProperty);
        Completed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Completed");
        Completed_Offset = FPropertyExporter.CallGetPropertyOffset(Completed_NativeProperty);
    }
    
    static int bRandom_Offset;
    
    public bool Random
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRandom_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRandom_Offset), 0, value);
        }
    }
    
    
    static int bLoop_Offset;
    
    /// <summary>
    /// Allow executing output pins again, without triggering Reset pin
    /// If set to False, every output pin can be triggered only once
    /// </summary>
    public bool Loop
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLoop_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLoop_Offset), 0, value);
        }
    }
    
    
    static int StartIndex_Offset;
    
    public int StartIndex
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, StartIndex_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, StartIndex_Offset), 0, value);
        }
    }
    
    
    static int NextOutput_Offset;
    
    private int NextOutput
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, NextOutput_Offset), 0);
        }
    }
    
    
    static int Completed_Offset;
    static IntPtr Completed_NativeProperty;
    ArrayMarshaller<bool> Completed_Marshaller = null;
    
    private System.Collections.Generic.IList<bool> Completed
    {
        get
        {
            Completed_Marshaller ??= new ArrayMarshaller<bool>(Completed_NativeProperty, BoolMarshaller.ToNative, BoolMarshaller.FromNative);
            return Completed_Marshaller.FromNative(IntPtr.Add(NativeObject, Completed_Offset), 0);
        }
    }
    
    
}