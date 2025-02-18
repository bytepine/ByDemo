using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Triggers outputs after time elapsed
/// </summary>
[UClass, GeneratedType("FlowNode_Timer", "UnrealSharp.Flow.FlowNode_Timer")]
public partial class UFlowNode_Timer : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_Timer()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_Timer");
        IntPtr CompletionTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CompletionTime");
        CompletionTime_Offset = FPropertyExporter.CallGetPropertyOffset(CompletionTime_NativeProperty);
        IntPtr StepTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "StepTime");
        StepTime_Offset = FPropertyExporter.CallGetPropertyOffset(StepTime_NativeProperty);
        IntPtr ResolvedCompletionTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ResolvedCompletionTime");
        ResolvedCompletionTime_Offset = FPropertyExporter.CallGetPropertyOffset(ResolvedCompletionTime_NativeProperty);
        IntPtr SumOfSteps_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SumOfSteps");
        SumOfSteps_Offset = FPropertyExporter.CallGetPropertyOffset(SumOfSteps_NativeProperty);
        IntPtr RemainingCompletionTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RemainingCompletionTime");
        RemainingCompletionTime_Offset = FPropertyExporter.CallGetPropertyOffset(RemainingCompletionTime_NativeProperty);
        IntPtr RemainingStepTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RemainingStepTime");
        RemainingStepTime_Offset = FPropertyExporter.CallGetPropertyOffset(RemainingStepTime_NativeProperty);
        OnStep_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnStep");
        OnCompletion_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnCompletion");
    }
    
    static int CompletionTime_Offset;
    
    /// <summary>
    /// If the value is closer to 0, Timer will complete in next tick
    /// </summary>
    protected float CompletionTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CompletionTime_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CompletionTime_Offset), 0, value);
        }
    }
    
    
    static int StepTime_Offset;
    
    /// <summary>
    /// this allows to trigger other nodes multiple times before completing the Timer
    /// </summary>
    protected float StepTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, StepTime_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, StepTime_Offset), 0, value);
        }
    }
    
    
    static int ResolvedCompletionTime_Offset;
    
    private float ResolvedCompletionTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ResolvedCompletionTime_Offset), 0);
        }
    }
    
    
    static int SumOfSteps_Offset;
    
    private float SumOfSteps
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SumOfSteps_Offset), 0);
        }
    }
    
    
    static int RemainingCompletionTime_Offset;
    
    private float RemainingCompletionTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RemainingCompletionTime_Offset), 0);
        }
    }
    
    
    static int RemainingStepTime_Offset;
    
    private float RemainingStepTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RemainingStepTime_Offset), 0);
        }
    }
    
    // OnStep
    static IntPtr OnStep_NativeFunction;
    
    [UFunction, GeneratedType("OnStep")]
    public void OnStep()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnStep_NativeFunction, IntPtr.Zero);
        }
    }
    
    // OnCompletion
    static IntPtr OnCompletion_NativeFunction;
    
    [UFunction, GeneratedType("OnCompletion")]
    public void OnCompletion()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnCompletion_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}