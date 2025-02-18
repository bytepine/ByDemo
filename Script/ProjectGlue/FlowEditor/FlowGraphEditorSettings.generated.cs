using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass, GeneratedType("FlowGraphEditorSettings", "UnrealSharp.FlowEditor.FlowGraphEditorSettings")]
public partial class UFlowGraphEditorSettings : UnrealSharp.DeveloperSettings.UDeveloperSettings
{
    static readonly IntPtr NativeClassPtr;
    static UFlowGraphEditorSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowGraphEditorSettings");
        IntPtr NodeDoubleClickTarget_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDoubleClickTarget");
        NodeDoubleClickTarget_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDoubleClickTarget_NativeProperty);
        IntPtr bShowNodeClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowNodeClass");
        bShowNodeClass_Offset = FPropertyExporter.CallGetPropertyOffset(bShowNodeClass_NativeProperty);
        IntPtr bShowNodeDescriptionWhilePlaying_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowNodeDescriptionWhilePlaying");
        bShowNodeDescriptionWhilePlaying_Offset = FPropertyExporter.CallGetPropertyOffset(bShowNodeDescriptionWhilePlaying_NativeProperty);
        IntPtr bEnforceFriendlyPinNames_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnforceFriendlyPinNames");
        bEnforceFriendlyPinNames_Offset = FPropertyExporter.CallGetPropertyOffset(bEnforceFriendlyPinNames_NativeProperty);
        IntPtr bShowSubGraphPreview_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowSubGraphPreview");
        bShowSubGraphPreview_Offset = FPropertyExporter.CallGetPropertyOffset(bShowSubGraphPreview_NativeProperty);
        IntPtr bShowSubGraphPath_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowSubGraphPath");
        bShowSubGraphPath_Offset = FPropertyExporter.CallGetPropertyOffset(bShowSubGraphPath_NativeProperty);
        IntPtr SubGraphPreviewSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubGraphPreviewSize");
        SubGraphPreviewSize_Offset = FPropertyExporter.CallGetPropertyOffset(SubGraphPreviewSize_NativeProperty);
        IntPtr bHotReloadNativeNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHotReloadNativeNodes");
        bHotReloadNativeNodes_Offset = FPropertyExporter.CallGetPropertyOffset(bHotReloadNativeNodes_NativeProperty);
        IntPtr bHighlightInputWiresOfSelectedNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHighlightInputWiresOfSelectedNodes");
        bHighlightInputWiresOfSelectedNodes_Offset = FPropertyExporter.CallGetPropertyOffset(bHighlightInputWiresOfSelectedNodes_NativeProperty);
        IntPtr bHighlightOutputWiresOfSelectedNodes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHighlightOutputWiresOfSelectedNodes");
        bHighlightOutputWiresOfSelectedNodes_Offset = FPropertyExporter.CallGetPropertyOffset(bHighlightOutputWiresOfSelectedNodes_NativeProperty);
    }
    
    static int NodeDoubleClickTarget_Offset;
    
    /// <summary>
    /// Double-clicking a Flow Node might open relevant asset/code editor
    /// </summary>
    public UnrealSharp.FlowEditor.EFlowNodeDoubleClickTarget NodeDoubleClickTarget
    {
        get
        {
            return EnumMarshaller<UnrealSharp.FlowEditor.EFlowNodeDoubleClickTarget>.FromNative(IntPtr.Add(NativeObject, NodeDoubleClickTarget_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.FlowEditor.EFlowNodeDoubleClickTarget>.ToNative(IntPtr.Add(NativeObject, NodeDoubleClickTarget_Offset), 0, value);
        }
    }
    
    
    static int bShowNodeClass_Offset;
    
    /// <summary>
    /// Displays information on the graph node, either C++ class name or path to blueprint asset
    /// </summary>
    public bool ShowNodeClass
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowNodeClass_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowNodeClass_Offset), 0, value);
        }
    }
    
    
    static int bShowNodeDescriptionWhilePlaying_Offset;
    
    /// <summary>
    /// Shows the node description when you play in editor
    /// </summary>
    public bool ShowNodeDescriptionWhilePlaying
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowNodeDescriptionWhilePlaying_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowNodeDescriptionWhilePlaying_Offset), 0, value);
        }
    }
    
    
    static int bEnforceFriendlyPinNames_Offset;
    
    /// <summary>
    /// Pin names will will be displayed in a format that is easier to read, even if PinFriendlyName wasn't set
    /// </summary>
    public bool EnforceFriendlyPinNames
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnforceFriendlyPinNames_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnforceFriendlyPinNames_Offset), 0, value);
        }
    }
    
    
    static int bShowSubGraphPreview_Offset;
    
    /// <summary>
    /// Renders preview of entire graph while hovering over
    /// </summary>
    public bool ShowSubGraphPreview
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowSubGraphPreview_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowSubGraphPreview_Offset), 0, value);
        }
    }
    
    
    static int bShowSubGraphPath_Offset;
    
    public bool ShowSubGraphPath
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowSubGraphPath_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowSubGraphPath_Offset), 0, value);
        }
    }
    
    
    static int SubGraphPreviewSize_Offset;
    
    public UnrealSharp.CoreUObject.FVector2D SubGraphPreviewSize
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FVector2D>.FromNative(IntPtr.Add(NativeObject, SubGraphPreviewSize_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FVector2D>.ToNative(IntPtr.Add(NativeObject, SubGraphPreviewSize_Offset), 0, value);
        }
    }
    
    
    static int bHotReloadNativeNodes_Offset;
    
    /// <summary>
    /// Enable hot reload for native flow nodes?
    /// WARNING: hot reload can easily crash the editor and you can lose progress
    /// </summary>
    public bool HotReloadNativeNodes
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bHotReloadNativeNodes_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bHotReloadNativeNodes_Offset), 0, value);
        }
    }
    
    
    static int bHighlightInputWiresOfSelectedNodes_Offset;
    
    public bool HighlightInputWiresOfSelectedNodes
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bHighlightInputWiresOfSelectedNodes_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bHighlightInputWiresOfSelectedNodes_Offset), 0, value);
        }
    }
    
    
    static int bHighlightOutputWiresOfSelectedNodes_Offset;
    
    public bool HighlightOutputWiresOfSelectedNodes
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bHighlightOutputWiresOfSelectedNodes_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bHighlightOutputWiresOfSelectedNodes_Offset), 0, value);
        }
    }
    
    
}