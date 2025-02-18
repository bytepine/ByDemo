using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("SimpleFlowEvent__DelegateSignature"), UMultiDelegate]
public delegate void SimpleFlowEvent();

public partial class USimpleFlowEvent : MulticastDelegate<SimpleFlowEvent>
{
    // FSimpleFlowEvent
    static IntPtr FSimpleFlowEvent_NativeFunction;
    
    protected void Invoker()
    {
        unsafe
        {
            ProcessDelegate(IntPtr.Zero);
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FSimpleFlowEvent_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
    }
}