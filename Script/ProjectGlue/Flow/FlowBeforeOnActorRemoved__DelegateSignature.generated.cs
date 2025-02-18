using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;


[GeneratedType("FlowBeforeOnActorRemoved__DelegateSignature"), UMultiDelegate]
public delegate void FlowBeforeOnActorRemoved(UnrealSharp.Engine.AActor spawnedActor);

public partial class UFlowBeforeOnActorRemoved : MulticastDelegate<FlowBeforeOnActorRemoved>
{
    // FFlowBeforeOnActorRemoved
    static IntPtr FFlowBeforeOnActorRemoved_NativeFunction;
    static int FFlowBeforeOnActorRemoved_ParamsSize;
    static int FFlowBeforeOnActorRemoved_SpawnedActor_Offset;
    
    protected void Invoker(UnrealSharp.Engine.AActor spawnedActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FFlowBeforeOnActorRemoved_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(FFlowBeforeOnActorRemoved_NativeFunction, ParamsBuffer);
            ObjectMarshaller<UnrealSharp.Engine.AActor>.ToNative(IntPtr.Add(ParamsBuffer, FFlowBeforeOnActorRemoved_SpawnedActor_Offset), 0, spawnedActor);
            
            ProcessDelegate(ParamsBuffer);
            
        }
    }
    static public void InitializeUnrealDelegate(IntPtr nativeDelegateProperty)
    {
        FFlowBeforeOnActorRemoved_NativeFunction = FMulticastDelegatePropertyExporter.CallGetSignatureFunction(nativeDelegateProperty);
        FFlowBeforeOnActorRemoved_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FFlowBeforeOnActorRemoved_NativeFunction);
        FFlowBeforeOnActorRemoved_SpawnedActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FFlowBeforeOnActorRemoved_NativeFunction, "SpawnedActor");
    }
}