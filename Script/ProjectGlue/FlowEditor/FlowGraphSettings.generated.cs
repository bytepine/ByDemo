using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

[UClass, GeneratedType("FlowGraphSettings", "UnrealSharp.FlowEditor.FlowGraphSettings")]
public partial class UFlowGraphSettings : UnrealSharp.DeveloperSettings.UDeveloperSettings
{
    static readonly IntPtr NativeClassPtr;
    static UFlowGraphSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowGraphSettings");
        IntPtr bExposeFlowAssetCreation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExposeFlowAssetCreation");
        bExposeFlowAssetCreation_Offset = FPropertyExporter.CallGetPropertyOffset(bExposeFlowAssetCreation_NativeProperty);
        IntPtr bExposeFlowNodeCreation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExposeFlowNodeCreation");
        bExposeFlowNodeCreation_Offset = FPropertyExporter.CallGetPropertyOffset(bExposeFlowNodeCreation_NativeProperty);
        IntPtr bShowAssetToolbarAboveLevelEditor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowAssetToolbarAboveLevelEditor");
        bShowAssetToolbarAboveLevelEditor_Offset = FPropertyExporter.CallGetPropertyOffset(bShowAssetToolbarAboveLevelEditor_NativeProperty);
        IntPtr FlowAssetCategoryName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FlowAssetCategoryName");
        FlowAssetCategoryName_Offset = FPropertyExporter.CallGetPropertyOffset(FlowAssetCategoryName_NativeProperty);
        IntPtr DefaultFlowAssetClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultFlowAssetClass");
        DefaultFlowAssetClass_Offset = FPropertyExporter.CallGetPropertyOffset(DefaultFlowAssetClass_NativeProperty);
        IntPtr WorldAssetClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "WorldAssetClass");
        WorldAssetClass_Offset = FPropertyExporter.CallGetPropertyOffset(WorldAssetClass_NativeProperty);
        NodesHiddenFromPalette_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodesHiddenFromPalette");
        NodesHiddenFromPalette_Offset = FPropertyExporter.CallGetPropertyOffset(NodesHiddenFromPalette_NativeProperty);
        OverridenNodeCategories_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "OverridenNodeCategories");
        OverridenNodeCategories_Offset = FPropertyExporter.CallGetPropertyOffset(OverridenNodeCategories_NativeProperty);
        IntPtr bShowDefaultPinNames_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowDefaultPinNames");
        bShowDefaultPinNames_Offset = FPropertyExporter.CallGetPropertyOffset(bShowDefaultPinNames_NativeProperty);
        NodePrefixesToRemove_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodePrefixesToRemove");
        NodePrefixesToRemove_Offset = FPropertyExporter.CallGetPropertyOffset(NodePrefixesToRemove_NativeProperty);
        NodeDisplayStyles_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDisplayStyles");
        NodeDisplayStyles_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDisplayStyles_NativeProperty);
        #if WITH_EDITOR
        IntPtr NodeDisplayStylesAuthoredTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDisplayStylesAuthoredTags");
        NodeDisplayStylesAuthoredTags_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDisplayStylesAuthoredTags_NativeProperty);
        #endif
        #if WITH_EDITOR
        NodeDisplayStylesMap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDisplayStylesMap");
        NodeDisplayStylesMap_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDisplayStylesMap_NativeProperty);
        #endif
        NodeTitleColors_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeTitleColors");
        NodeTitleColors_Offset = FPropertyExporter.CallGetPropertyOffset(NodeTitleColors_NativeProperty);
        NodeSpecificColors_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeSpecificColors");
        NodeSpecificColors_Offset = FPropertyExporter.CallGetPropertyOffset(NodeSpecificColors_NativeProperty);
        IntPtr ExecPinColorModifier_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ExecPinColorModifier");
        ExecPinColorModifier_Offset = FPropertyExporter.CallGetPropertyOffset(ExecPinColorModifier_NativeProperty);
        IntPtr NodeDescriptionBackground_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeDescriptionBackground");
        NodeDescriptionBackground_Offset = FPropertyExporter.CallGetPropertyOffset(NodeDescriptionBackground_NativeProperty);
        IntPtr NodeStatusBackground_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodeStatusBackground");
        NodeStatusBackground_Offset = FPropertyExporter.CallGetPropertyOffset(NodeStatusBackground_NativeProperty);
        IntPtr NodePreloadedBackground_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NodePreloadedBackground");
        NodePreloadedBackground_Offset = FPropertyExporter.CallGetPropertyOffset(NodePreloadedBackground_NativeProperty);
        IntPtr ConnectionDrawType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ConnectionDrawType");
        ConnectionDrawType_Offset = FPropertyExporter.CallGetPropertyOffset(ConnectionDrawType_NativeProperty);
        IntPtr CircuitConnectionAngle_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CircuitConnectionAngle");
        CircuitConnectionAngle_Offset = FPropertyExporter.CallGetPropertyOffset(CircuitConnectionAngle_NativeProperty);
        IntPtr CircuitConnectionSpacing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CircuitConnectionSpacing");
        CircuitConnectionSpacing_Offset = FPropertyExporter.CallGetPropertyOffset(CircuitConnectionSpacing_NativeProperty);
        IntPtr InactiveWireColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InactiveWireColor");
        InactiveWireColor_Offset = FPropertyExporter.CallGetPropertyOffset(InactiveWireColor_NativeProperty);
        IntPtr InactiveWireThickness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "InactiveWireThickness");
        InactiveWireThickness_Offset = FPropertyExporter.CallGetPropertyOffset(InactiveWireThickness_NativeProperty);
        IntPtr RecentWireDuration_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecentWireDuration");
        RecentWireDuration_Offset = FPropertyExporter.CallGetPropertyOffset(RecentWireDuration_NativeProperty);
        IntPtr RecentWireColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecentWireColor");
        RecentWireColor_Offset = FPropertyExporter.CallGetPropertyOffset(RecentWireColor_NativeProperty);
        IntPtr RecentWireThickness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecentWireThickness");
        RecentWireThickness_Offset = FPropertyExporter.CallGetPropertyOffset(RecentWireThickness_NativeProperty);
        IntPtr RecordedWireColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecordedWireColor");
        RecordedWireColor_Offset = FPropertyExporter.CallGetPropertyOffset(RecordedWireColor_NativeProperty);
        IntPtr RecordedWireThickness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RecordedWireThickness");
        RecordedWireThickness_Offset = FPropertyExporter.CallGetPropertyOffset(RecordedWireThickness_NativeProperty);
        IntPtr SelectedWireColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SelectedWireColor");
        SelectedWireColor_Offset = FPropertyExporter.CallGetPropertyOffset(SelectedWireColor_NativeProperty);
        IntPtr SelectedWireThickness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SelectedWireThickness");
        SelectedWireThickness_Offset = FPropertyExporter.CallGetPropertyOffset(SelectedWireThickness_NativeProperty);
    }
    
    static int bExposeFlowAssetCreation_Offset;
    
    /// <summary>
    /// Show Flow Asset in Flow category of "Create Asset" menu?
    /// Requires restart after making a change.
    /// </summary>
    public bool ExposeFlowAssetCreation
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bExposeFlowAssetCreation_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bExposeFlowAssetCreation_Offset), 0, value);
        }
    }
    
    
    static int bExposeFlowNodeCreation_Offset;
    
    /// <summary>
    /// Show Flow Node blueprint in Flow category of "Create Asset" menu?
    /// Requires restart after making a change.
    /// </summary>
    public bool ExposeFlowNodeCreation
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bExposeFlowNodeCreation_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bExposeFlowNodeCreation_Offset), 0, value);
        }
    }
    
    
    static int bShowAssetToolbarAboveLevelEditor_Offset;
    
    /// <summary>
    /// Show Flow Asset toolbar?
    /// Requires restart after making a change.
    /// </summary>
    public bool ShowAssetToolbarAboveLevelEditor
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowAssetToolbarAboveLevelEditor_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowAssetToolbarAboveLevelEditor_Offset), 0, value);
        }
    }
    
    
    static int FlowAssetCategoryName_Offset;
    
    public FText FlowAssetCategoryName
    {
        get
        {
            return TextMarshaller.FromNative(IntPtr.Add(NativeObject, FlowAssetCategoryName_Offset), 0);
        }
        set
        {
            TextMarshaller.ToNative(IntPtr.Add(NativeObject, FlowAssetCategoryName_Offset), 0, value);
        }
    }
    
    
    static int DefaultFlowAssetClass_Offset;
    
    /// <summary>
    /// Use this class to create new assets. Class picker will show up if None
    /// </summary>
    public TSubclassOf<UnrealSharp.Flow.UFlowAsset> DefaultFlowAssetClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, DefaultFlowAssetClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(NativeObject, DefaultFlowAssetClass_Offset), 0, value);
        }
    }
    
    
    static int WorldAssetClass_Offset;
    
    /// <summary>
    /// Flow Asset class allowed to be assigned via Level Editor toolbar
    /// </summary>
    public TSubclassOf<UnrealSharp.Flow.UFlowAsset> WorldAssetClass
    {
        get
        {
            return SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.FromNative(IntPtr.Add(NativeObject, WorldAssetClass_Offset), 0);
        }
        set
        {
            SubclassOfMarshaller<UnrealSharp.Flow.UFlowAsset>.ToNative(IntPtr.Add(NativeObject, WorldAssetClass_Offset), 0, value);
        }
    }
    
    
    static int NodesHiddenFromPalette_Offset;
    static IntPtr NodesHiddenFromPalette_NativeProperty;
    ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>> NodesHiddenFromPalette_Marshaller = null;
    
    /// <summary>
    /// Hide specific nodes from the Flow Palette without changing the source code.
    /// Requires restart after making a change.
    /// </summary>
    public System.Collections.Generic.IList<TSubclassOf<UnrealSharp.Flow.UFlowNode>> NodesHiddenFromPalette
    {
        get
        {
            NodesHiddenFromPalette_Marshaller ??= new ArrayMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>>(NodesHiddenFromPalette_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative);
            return NodesHiddenFromPalette_Marshaller.FromNative(IntPtr.Add(NativeObject, NodesHiddenFromPalette_Offset), 0);
        }
    }
    
    
    static int OverridenNodeCategories_Offset;
    static IntPtr OverridenNodeCategories_NativeProperty;
    MapMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, string> OverridenNodeCategories_Marshaller = null;
    
    /// <summary>
    /// Allows anyone to override Flow Palette category for specific nodes without modifying source code.
    /// </summary>
    public System.Collections.Generic.IDictionary<TSubclassOf<UnrealSharp.Flow.UFlowNode>, string> OverridenNodeCategories
    {
        get
        {
            OverridenNodeCategories_Marshaller ??= new MapMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, string>(OverridenNodeCategories_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative, StringMarshaller.ToNative, StringMarshaller.FromNative);
            return OverridenNodeCategories_Marshaller.FromNative(IntPtr.Add(NativeObject, OverridenNodeCategories_Offset), 0);
        }
    }
    
    
    static int bShowDefaultPinNames_Offset;
    
    /// <summary>
    /// Hide default pin names on simple nodes, reduces UI clutter
    /// </summary>
    public bool ShowDefaultPinNames
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowDefaultPinNames_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowDefaultPinNames_Offset), 0, value);
        }
    }
    
    
    static int NodePrefixesToRemove_Offset;
    static IntPtr NodePrefixesToRemove_NativeProperty;
    ArrayMarshaller<string> NodePrefixesToRemove_Marshaller = null;
    
    /// <summary>
    /// List of prefixes to hide on node titles and palette without need to add custom DisplayName.
    /// If node class has meta = (DisplayName = ... ) or BlueprintDisplayName, those texts will be displayed
    /// </summary>
    public System.Collections.Generic.IList<string> NodePrefixesToRemove
    {
        get
        {
            NodePrefixesToRemove_Marshaller ??= new ArrayMarshaller<string>(NodePrefixesToRemove_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            return NodePrefixesToRemove_Marshaller.FromNative(IntPtr.Add(NativeObject, NodePrefixesToRemove_Offset), 0);
        }
    }
    
    
    static int NodeDisplayStyles_Offset;
    static IntPtr NodeDisplayStyles_NativeProperty;
    ArrayMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig> NodeDisplayStyles_Marshaller = null;
    
    /// <summary>
    /// Display Styles for nodes, keyed by Gameplay Tag
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig> NodeDisplayStyles
    {
        get
        {
            NodeDisplayStyles_Marshaller ??= new ArrayMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>(NodeDisplayStyles_NativeProperty, StructMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>.ToNative, StructMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>.FromNative);
            return NodeDisplayStyles_Marshaller.FromNative(IntPtr.Add(NativeObject, NodeDisplayStyles_Offset), 0);
        }
    }
    
    
    #if WITH_EDITOR
    static int NodeDisplayStylesAuthoredTags_Offset;
    
    /// <summary>
    /// Tags in the NodeDisplayStylesMap, used to detect when the map needs updating
    /// </summary>
    public UnrealSharp.GameplayTags.FGameplayTagContainer NodeDisplayStylesAuthoredTags
    {
        get
        {
            return StructMarshaller<UnrealSharp.GameplayTags.FGameplayTagContainer>.FromNative(IntPtr.Add(NativeObject, NodeDisplayStylesAuthoredTags_Offset), 0);
        }
    }
    #endif
    
    
    #if WITH_EDITOR
    static int NodeDisplayStylesMap_Offset;
    static IntPtr NodeDisplayStylesMap_NativeProperty;
    MapMarshaller<UnrealSharp.GameplayTags.FGameplayTag, UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig> NodeDisplayStylesMap_Marshaller = null;
    
    /// <summary>
    /// Cached map of the data in NodeDisplayStyles for GameplayTag-keyed lookup
    /// </summary>
    public System.Collections.Generic.IDictionary<UnrealSharp.GameplayTags.FGameplayTag, UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig> NodeDisplayStylesMap
    {
        get
        {
            NodeDisplayStylesMap_Marshaller ??= new MapMarshaller<UnrealSharp.GameplayTags.FGameplayTag, UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>(NodeDisplayStylesMap_NativeProperty, StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.ToNative, StructMarshaller<UnrealSharp.GameplayTags.FGameplayTag>.FromNative, StructMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>.ToNative, StructMarshaller<UnrealSharp.FlowEditor.FFlowNodeDisplayStyleConfig>.FromNative);
            return NodeDisplayStylesMap_Marshaller.FromNative(IntPtr.Add(NativeObject, NodeDisplayStylesMap_Offset), 0);
        }
    }
    #endif
    
    
    static int NodeTitleColors_Offset;
    static IntPtr NodeTitleColors_NativeProperty;
    MapMarshaller<UnrealSharp.Flow.EFlowNodeStyle, UnrealSharp.CoreUObject.FLinearColor> NodeTitleColors_Marshaller = null;
    
    public System.Collections.Generic.IDictionary<UnrealSharp.Flow.EFlowNodeStyle, UnrealSharp.CoreUObject.FLinearColor> NodeTitleColors
    {
        get
        {
            NodeTitleColors_Marshaller ??= new MapMarshaller<UnrealSharp.Flow.EFlowNodeStyle, UnrealSharp.CoreUObject.FLinearColor>(NodeTitleColors_NativeProperty, EnumMarshaller<UnrealSharp.Flow.EFlowNodeStyle>.ToNative, EnumMarshaller<UnrealSharp.Flow.EFlowNodeStyle>.FromNative, StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative);
            return NodeTitleColors_Marshaller.FromNative(IntPtr.Add(NativeObject, NodeTitleColors_Offset), 0);
        }
    }
    
    
    static int NodeSpecificColors_Offset;
    static IntPtr NodeSpecificColors_NativeProperty;
    MapMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.CoreUObject.FLinearColor> NodeSpecificColors_Marshaller = null;
    
    public System.Collections.Generic.IDictionary<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.CoreUObject.FLinearColor> NodeSpecificColors
    {
        get
        {
            NodeSpecificColors_Marshaller ??= new MapMarshaller<TSubclassOf<UnrealSharp.Flow.UFlowNode>, UnrealSharp.CoreUObject.FLinearColor>(NodeSpecificColors_NativeProperty, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.ToNative, SubclassOfMarshaller<UnrealSharp.Flow.UFlowNode>.FromNative, StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative, StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative);
            return NodeSpecificColors_Marshaller.FromNative(IntPtr.Add(NativeObject, NodeSpecificColors_Offset), 0);
        }
    }
    
    
    static int ExecPinColorModifier_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor ExecPinColorModifier
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, ExecPinColorModifier_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, ExecPinColorModifier_Offset), 0, value);
        }
    }
    
    
    static int NodeDescriptionBackground_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor NodeDescriptionBackground
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, NodeDescriptionBackground_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, NodeDescriptionBackground_Offset), 0, value);
        }
    }
    
    
    static int NodeStatusBackground_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor NodeStatusBackground
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, NodeStatusBackground_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, NodeStatusBackground_Offset), 0, value);
        }
    }
    
    
    static int NodePreloadedBackground_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor NodePreloadedBackground
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, NodePreloadedBackground_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, NodePreloadedBackground_Offset), 0, value);
        }
    }
    
    
    static int ConnectionDrawType_Offset;
    
    public UnrealSharp.FlowEditor.EFlowConnectionDrawType ConnectionDrawType
    {
        get
        {
            return EnumMarshaller<UnrealSharp.FlowEditor.EFlowConnectionDrawType>.FromNative(IntPtr.Add(NativeObject, ConnectionDrawType_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.FlowEditor.EFlowConnectionDrawType>.ToNative(IntPtr.Add(NativeObject, ConnectionDrawType_Offset), 0, value);
        }
    }
    
    
    static int CircuitConnectionAngle_Offset;
    
    public float CircuitConnectionAngle
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CircuitConnectionAngle_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CircuitConnectionAngle_Offset), 0, value);
        }
    }
    
    
    static int CircuitConnectionSpacing_Offset;
    
    public UnrealSharp.CoreUObject.FVector2D CircuitConnectionSpacing
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FVector2D>.FromNative(IntPtr.Add(NativeObject, CircuitConnectionSpacing_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FVector2D>.ToNative(IntPtr.Add(NativeObject, CircuitConnectionSpacing_Offset), 0, value);
        }
    }
    
    
    static int InactiveWireColor_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor InactiveWireColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, InactiveWireColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, InactiveWireColor_Offset), 0, value);
        }
    }
    
    
    static int InactiveWireThickness_Offset;
    
    public float InactiveWireThickness
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, InactiveWireThickness_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, InactiveWireThickness_Offset), 0, value);
        }
    }
    
    
    static int RecentWireDuration_Offset;
    
    public float RecentWireDuration
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RecentWireDuration_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, RecentWireDuration_Offset), 0, value);
        }
    }
    
    
    static int RecentWireColor_Offset;
    
    /// <summary>
    /// The color to display execution wires that were just executed
    /// </summary>
    public UnrealSharp.CoreUObject.FLinearColor RecentWireColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, RecentWireColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, RecentWireColor_Offset), 0, value);
        }
    }
    
    
    static int RecentWireThickness_Offset;
    
    public float RecentWireThickness
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RecentWireThickness_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, RecentWireThickness_Offset), 0, value);
        }
    }
    
    
    static int RecordedWireColor_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor RecordedWireColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, RecordedWireColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, RecordedWireColor_Offset), 0, value);
        }
    }
    
    
    static int RecordedWireThickness_Offset;
    
    public float RecordedWireThickness
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, RecordedWireThickness_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, RecordedWireThickness_Offset), 0, value);
        }
    }
    
    
    static int SelectedWireColor_Offset;
    
    public UnrealSharp.CoreUObject.FLinearColor SelectedWireColor
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.FromNative(IntPtr.Add(NativeObject, SelectedWireColor_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FLinearColor>.ToNative(IntPtr.Add(NativeObject, SelectedWireColor_Offset), 0, value);
        }
    }
    
    
    static int SelectedWireThickness_Offset;
    
    public float SelectedWireThickness
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SelectedWireThickness_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, SelectedWireThickness_Offset), 0, value);
        }
    }
    
    
}