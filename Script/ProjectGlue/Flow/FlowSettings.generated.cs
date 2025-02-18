using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UClass, GeneratedType("FlowSettings", "UnrealSharp.Flow.FlowSettings")]
public partial class UFlowSettings : UnrealSharp.DeveloperSettings.UDeveloperSettings
{
    static readonly IntPtr NativeClassPtr;
    static UFlowSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FlowSettings");
        IntPtr bCreateFlowSubsystemOnClients_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCreateFlowSubsystemOnClients");
        bCreateFlowSubsystemOnClients_Offset = FPropertyExporter.CallGetPropertyOffset(bCreateFlowSubsystemOnClients_NativeProperty);
        IntPtr bWarnAboutMissingIdentityTags_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bWarnAboutMissingIdentityTags");
        bWarnAboutMissingIdentityTags_Offset = FPropertyExporter.CallGetPropertyOffset(bWarnAboutMissingIdentityTags_NativeProperty);
        IntPtr bLogOnSignalDisabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLogOnSignalDisabled");
        bLogOnSignalDisabled_Offset = FPropertyExporter.CallGetPropertyOffset(bLogOnSignalDisabled_NativeProperty);
        IntPtr bLogOnSignalPassthrough_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLogOnSignalPassthrough");
        bLogOnSignalPassthrough_Offset = FPropertyExporter.CallGetPropertyOffset(bLogOnSignalPassthrough_NativeProperty);
        IntPtr bUseAdaptiveNodeTitles_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseAdaptiveNodeTitles");
        bUseAdaptiveNodeTitles_Offset = FPropertyExporter.CallGetPropertyOffset(bUseAdaptiveNodeTitles_NativeProperty);
        IntPtr DefaultExpectedOwnerClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultExpectedOwnerClass");
        DefaultExpectedOwnerClass_Offset = FPropertyExporter.CallGetPropertyOffset(DefaultExpectedOwnerClass_NativeProperty);
    }
    
    static int bCreateFlowSubsystemOnClients_Offset;
    
    /// <summary>
    /// Set if to False, if you don't want to create client-side Flow Graphs
    /// And you don't access to the Flow Component registry on clients
    /// </summary>
    public bool CreateFlowSubsystemOnClients
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCreateFlowSubsystemOnClients_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCreateFlowSubsystemOnClients_Offset), 0, value);
        }
    }
    
    
    static int bWarnAboutMissingIdentityTags_Offset;
    
    public bool WarnAboutMissingIdentityTags
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bWarnAboutMissingIdentityTags_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bWarnAboutMissingIdentityTags_Offset), 0, value);
        }
    }
    
    
    static int bLogOnSignalDisabled_Offset;
    
    /// <summary>
    /// If enabled, runtime logs will be added when a flow node signal mode is set to Disabled
    /// </summary>
    public bool LogOnSignalDisabled
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLogOnSignalDisabled_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLogOnSignalDisabled_Offset), 0, value);
        }
    }
    
    
    static int bLogOnSignalPassthrough_Offset;
    
    /// <summary>
    /// If enabled, runtime logs will be added when a flow node signal mode is set to Pass-through
    /// </summary>
    public bool LogOnSignalPassthrough
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLogOnSignalPassthrough_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLogOnSignalPassthrough_Offset), 0, value);
        }
    }
    
    
    static int bUseAdaptiveNodeTitles_Offset;
    
    /// <summary>
    /// Adjust the Titles for FlowNodes to be more expressive than default
    /// by incorporating data that would otherwise go in the Description
    /// </summary>
    public bool UseAdaptiveNodeTitles
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseAdaptiveNodeTitles_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseAdaptiveNodeTitles_Offset), 0, value);
        }
    }
    
    
    static int DefaultExpectedOwnerClass_Offset;
    
    /// <summary>
    /// Default class to use as a FlowAsset's "ExpectedOwnerClass"
    /// </summary>
    public UnrealSharp.CoreUObject.FSoftClassPath DefaultExpectedOwnerClass
    {
        get
        {
            return StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.FromNative(IntPtr.Add(NativeObject, DefaultExpectedOwnerClass_Offset), 0);
        }
        set
        {
            StructMarshaller<UnrealSharp.CoreUObject.FSoftClassPath>.ToNative(IntPtr.Add(NativeObject, DefaultExpectedOwnerClass_Offset), 0, value);
        }
    }
    
    
}