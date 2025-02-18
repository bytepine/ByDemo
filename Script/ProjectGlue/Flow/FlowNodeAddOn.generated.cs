using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// A Flow Node AddOn allows user to extend given node instance in the graph with additional logic.
/// </summary>
[UClass(ClassFlags.Abstract), GeneratedType("FlowNodeAddOn", "UnrealSharp.Flow.FlowNodeAddOn")]
public partial class UFlowNodeAddOn : UnrealSharp.Flow.UFlowNodeBase
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNodeAddOn()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNodeAddOn");
        InputPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InputPins");
        InputPins_Offset = FPropertyExporter.CallGetPropertyOffset(InputPins_NativeProperty);
        #if WITH_EDITOR
        OutputPins_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OutputPins");
        OutputPins_Offset = FPropertyExporter.CallGetPropertyOffset(OutputPins_NativeProperty);
        #endif
        IntPtr FlowNode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowNode");
        FlowNode_Offset = FPropertyExporter.CallGetPropertyOffset(FlowNode_NativeProperty);
        GetFlowNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlowNode");
        GetFlowNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlowNode_NativeFunction);
        GetFlowNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlowNode_NativeFunction, "ReturnValue");
        IntPtr AcceptFlowNodeAddOnParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AcceptFlowNodeAddOnParent");
        AcceptFlowNodeAddOnParent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AcceptFlowNodeAddOnParent_NativeFunction);
        AcceptFlowNodeAddOnParent_ParentTemplate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnParent_NativeFunction, "ParentTemplate");
        AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnParent_NativeFunction, "AdditionalAddOnsToAssumeAreChildren");
        AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(AcceptFlowNodeAddOnParent_NativeFunction, "AdditionalAddOnsToAssumeAreChildren");
        AcceptFlowNodeAddOnParent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AcceptFlowNodeAddOnParent_NativeFunction, "ReturnValue");
    }
    
    static int InputPins_Offset;
    static IntPtr InputPins_NativeProperty;
    ArrayReadOnlyMarshaller<UnrealSharp.Flow.FFlowPin> InputPins_Marshaller = null;
    
    /// <summary>
    /// Input pins to add to the owning flow node
    /// If defined, ExecuteInput will only be executed for these inputs
    /// </summary>
    protected System.Collections.Generic.IReadOnlyList<UnrealSharp.Flow.FFlowPin> InputPins
    {
        get
        {
            InputPins_Marshaller ??= new ArrayReadOnlyMarshaller<UnrealSharp.Flow.FFlowPin>(InputPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return InputPins_Marshaller.FromNative(IntPtr.Add(NativeObject, InputPins_Offset), 0);
        }
    }
    
    
    #if WITH_EDITOR
    static int OutputPins_Offset;
    static IntPtr OutputPins_NativeProperty;
    ArrayReadOnlyMarshaller<UnrealSharp.Flow.FFlowPin> OutputPins_Marshaller = null;
    
    /// <summary>
    /// Output pins to add to the owning flow node
    /// </summary>
    protected System.Collections.Generic.IReadOnlyList<UnrealSharp.Flow.FFlowPin> OutputPins
    {
        get
        {
            OutputPins_Marshaller ??= new ArrayReadOnlyMarshaller<UnrealSharp.Flow.FFlowPin>(OutputPins_NativeProperty, StructMarshaller<UnrealSharp.Flow.FFlowPin>.ToNative, StructMarshaller<UnrealSharp.Flow.FFlowPin>.FromNative);
            return OutputPins_Marshaller.FromNative(IntPtr.Add(NativeObject, OutputPins_Offset), 0);
        }
    }
    #endif
    
    
    // GetFlowNode
    static IntPtr GetFlowNode_NativeFunction;
    static int GetFlowNode_ParamsSize;
    static int GetFlowNode_ReturnValue_Offset;
    static int FlowNode_Offset;
    static IntPtr FlowNode_NativeProperty;
    static int FlowNode_Size;
    
    /// <summary>
    /// The FlowNode that contains this AddOn
    /// (accessible only when initialized, runtime only)
    /// </summary>
    public UnrealSharp.Flow.UFlowNode FlowNode
    {
        get
        {
            unsafe
            {
                byte* ParamsBufferAllocation = stackalloc byte[GetFlowNode_ParamsSize];
                nint ParamsBuffer = (nint) ParamsBufferAllocation;
                UFunctionExporter.CallInitializeFunctionParams(GetFlowNode_NativeFunction, ParamsBuffer);
                
                UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlowNode_NativeFunction, ParamsBuffer);
                
                UnrealSharp.Flow.UFlowNode returnValue;
                returnValue = ObjectMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative(IntPtr.Add(ParamsBuffer, GetFlowNode_ReturnValue_Offset), 0);
                
                return returnValue;
            }
        }
    }
    
    // AcceptFlowNodeAddOnParent
    IntPtr AcceptFlowNodeAddOnParent_NativeFunction;
    static int AcceptFlowNodeAddOnParent_ParamsSize;
    static int AcceptFlowNodeAddOnParent_ParentTemplate_Offset;
    static int AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Offset;
    static IntPtr AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_NativeProperty;
    ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn> AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Marshaller = null;
    static int AcceptFlowNodeAddOnParent_ReturnValue_Offset;
    
    /// <summary>
    /// AddOns may opt in to be eligible for a given parent
    /// - ParentTemplate - the template of the FlowNode or FlowNodeAddOn that is being considered as a potential parent
    /// - AdditionalAddOnsToAssumeAreChildren - other AddOns to assume that are already child AddOns for the purposes of this test.
    ///   This list will be populated with the 'other' AddOns in a multi-paste operation in the editor,
    ///   because some paste-targets can only accept a certain mix of addons, so we must know the rest of the set being pasted
    ///   to make the correct decision about whether to allow AddOnTemplate to be added.
    /// https:forums.unrealengine.com/t/default-parameters-with-tarrays/330225 for details on AutoCreateRefTerm
    /// </summary>
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("AcceptFlowNodeAddOnParent")]
    public virtual UnrealSharp.Flow.EFlowAddOnAcceptResult AcceptFlowNodeAddOnParent(UnrealSharp.Flow.UFlowNodeBase parentTemplate, System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> additionalAddOnsToAssumeAreChildren)
    {
        unsafe
        {
            if (AcceptFlowNodeAddOnParent_NativeFunction == IntPtr.Zero)
            {
                AcceptFlowNodeAddOnParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "AcceptFlowNodeAddOnParent");
            }
            byte* ParamsBufferAllocation = stackalloc byte[AcceptFlowNodeAddOnParent_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(AcceptFlowNodeAddOnParent_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Flow.UFlowNodeBase>.ToNative(IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnParent_ParentTemplate_Offset), 0, parentTemplate);
            AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>(AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative);
            IntPtr AdditionalAddOnsToAssumeAreChildren_NativeBuffer = IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Offset);
            AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Marshaller.ToNative(AdditionalAddOnsToAssumeAreChildren_NativeBuffer, 0, additionalAddOnsToAssumeAreChildren);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AcceptFlowNodeAddOnParent_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Flow.EFlowAddOnAcceptResult returnValue;
            returnValue = EnumMarshaller<UnrealSharp.Flow.EFlowAddOnAcceptResult>.FromNative(IntPtr.Add(ParamsBuffer, AcceptFlowNodeAddOnParent_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.Flow.EFlowAddOnAcceptResult AcceptFlowNodeAddOnParent_Implementation(UnrealSharp.Flow.UFlowNodeBase ParentTemplate, System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> AdditionalAddOnsToAssumeAreChildren)
    {
        return default(UnrealSharp.Flow.EFlowAddOnAcceptResult);
    }
    void Invoke_AcceptFlowNodeAddOnParent(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Flow.UFlowNodeBase ParentTemplate =  ObjectMarshaller<UnrealSharp.Flow.UFlowNodeBase>.FromNative(IntPtr.Add(buffer, AcceptFlowNodeAddOnParent_ParentTemplate_Offset), 0);
            AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>(AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_NativeProperty, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.ToNative, ObjectMarshaller<UnrealSharp.Flow.UFlowNodeAddOn>.FromNative);
            IntPtr AdditionalAddOnsToAssumeAreChildren_NativeBuffer = IntPtr.Add(buffer, AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Offset);
            System.Collections.Generic.IList<UnrealSharp.Flow.UFlowNodeAddOn> AdditionalAddOnsToAssumeAreChildren =  AcceptFlowNodeAddOnParent_AdditionalAddOnsToAssumeAreChildren_Marshaller.FromNative(AdditionalAddOnsToAssumeAreChildren_NativeBuffer, 0);
            UnrealSharp.Flow.EFlowAddOnAcceptResult returnValue = AcceptFlowNodeAddOnParent_Implementation(ParentTemplate, AdditionalAddOnsToAssumeAreChildren);
            EnumMarshaller<UnrealSharp.Flow.EFlowAddOnAcceptResult>.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    
}