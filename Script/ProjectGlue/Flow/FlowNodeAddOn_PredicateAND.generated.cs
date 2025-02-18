using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UClass, GeneratedType("FlowNodeAddOn_PredicateAND", "UnrealSharp.Flow.FlowNodeAddOn_PredicateAND")]
public partial class UFlowNodeAddOn_PredicateAND : UnrealSharp.Flow.UFlowNodeAddOn, UnrealSharp.Flow.IFlowPredicateInterface
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNodeAddOn_PredicateAND()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNodeAddOn_PredicateAND");
        IntPtr EvaluatePredicate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "EvaluatePredicate");
        EvaluatePredicate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(EvaluatePredicate_NativeFunction);
        EvaluatePredicate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EvaluatePredicate_NativeFunction, "ReturnValue");
    }
    // EvaluatePredicate
    IntPtr EvaluatePredicate_NativeFunction;
    static int EvaluatePredicate_ParamsSize;
    static int EvaluatePredicate_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("EvaluatePredicate")]
    public bool EvaluatePredicate()
    {
        unsafe
        {
            if (EvaluatePredicate_NativeFunction == IntPtr.Zero)
            {
                EvaluatePredicate_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "EvaluatePredicate");
            }
            byte* ParamsBufferAllocation = stackalloc byte[EvaluatePredicate_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(EvaluatePredicate_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, EvaluatePredicate_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, EvaluatePredicate_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool EvaluatePredicate_Implementation()
    {
        return default(bool);
    }
    void Invoke_EvaluatePredicate(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = EvaluatePredicate_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    
}