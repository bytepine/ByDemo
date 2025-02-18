using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

/// <summary>
/// Adds message to log
/// Optionally shows message on screen
/// </summary>
[UClass, GeneratedType("FlowNode_Log", "UnrealSharp.Flow.FlowNode_Log")]
public partial class UFlowNode_Log : UnrealSharp.Flow.UFlowNode
{
    static readonly IntPtr NativeClassPtr;
    static UFlowNode_Log()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowNode_Log");
        Message_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Message");
        Message_Offset = FPropertyExporter.CallGetPropertyOffset(Message_NativeProperty);
        IntPtr Verbosity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Verbosity");
        Verbosity_Offset = FPropertyExporter.CallGetPropertyOffset(Verbosity_NativeProperty);
        IntPtr bPrintToScreen_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPrintToScreen");
        bPrintToScreen_Offset = FPropertyExporter.CallGetPropertyOffset(bPrintToScreen_NativeProperty);
        IntPtr Duration_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Duration");
        Duration_Offset = FPropertyExporter.CallGetPropertyOffset(Duration_NativeProperty);
        IntPtr TextColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TextColor");
        TextColor_Offset = FPropertyExporter.CallGetPropertyOffset(TextColor_NativeProperty);
    }
    
    static int Message_Offset;
    static IntPtr Message_NativeProperty;
    
    /// <summary>
    /// The message to write to the log
    /// (if the Message input pin is not connected to another source)
    /// </summary>
    private string Message
    {
        get
        {
            IntPtr Message_NativePtr = IntPtr.Add(NativeObject,Message_Offset);
            return StringMarshaller.FromNative(Message_NativePtr,0);
        }
        set
        {
            IntPtr Message_NativePtr = IntPtr.Add(NativeObject, Message_Offset);
            StringMarshaller.ToNative(Message_NativePtr,0,value);
        }
    }
    
    
    static int Verbosity_Offset;
    
    private UnrealSharp.Flow.EFlowLogVerbosity Verbosity
    {
        get
        {
            return EnumMarshaller<UnrealSharp.Flow.EFlowLogVerbosity>.FromNative(IntPtr.Add(NativeObject, Verbosity_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.Flow.EFlowLogVerbosity>.ToNative(IntPtr.Add(NativeObject, Verbosity_Offset), 0, value);
        }
    }
    
    
    static int bPrintToScreen_Offset;
    
    private bool PrintToScreen
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bPrintToScreen_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bPrintToScreen_Offset), 0, value);
        }
    }
    
    
    static int Duration_Offset;
    
    private float Duration
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Duration_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Duration_Offset), 0, value);
        }
    }
    
    
    static int TextColor_Offset;
    
    private UnrealSharp.CoreUObject.FColor TextColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FColor>.FromNative(IntPtr.Add(NativeObject, TextColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FColor>.ToNative(IntPtr.Add(NativeObject, TextColor_Offset), 0, value);
        }
    }
    
    
}