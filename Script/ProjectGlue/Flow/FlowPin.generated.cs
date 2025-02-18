using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.Flow;

[UStruct, GeneratedType("FlowPin", "UnrealSharp.Flow.FlowPin")]
public partial struct FFlowPin : MarshalledStruct<FFlowPin>
{
    // PinName
    
    static int PinName_Offset;
    /// <summary>
    /// A logical name, used during execution of pin
    /// </summary>
    public FName PinName;
    
    // PinFriendlyName
    
    static int PinFriendlyName_Offset;
    /// <summary>
    /// An optional Display Name, you can use it to override PinName without the need to update graph connections
    /// </summary>
    public FText PinFriendlyName;
    
    // PinToolTip
    
    static int PinToolTip_Offset;
    static IntPtr PinToolTip_NativeProperty;
    public string PinToolTip;
    
    // PinType
    
    static int PinType_Offset;
    /// <summary>
    /// PinType (implies PinCategory)
    /// </summary>
    public UnrealSharp.Flow.EFlowPinType PinType;
    
    // PinSubCategoryObject
    
    static int PinSubCategoryObject_Offset;
    /// <summary>
    /// Sub-category object
    /// (used to identify the struct or class type for some PinCategories, see IsSubtypeSupportedPinCategory)
    /// </summary>
    public TWeakObjectPtr<UnrealSharp.CoreUObject.UObject> PinSubCategoryObject;
    
    // SubCategoryClassFilter
    
    static int SubCategoryClassFilter_Offset;
    /// <summary>
    /// Filter for limiting the compatible classes for this data pin.
    /// This property is editor-only, but it is automatically copied into PinSubCategoryObject if the PinType matches (for runtime use).
    /// </summary>
    public TSubclassOf<UnrealSharp.CoreUObject.UClass> SubCategoryClassFilter;
    
    // SubCategoryObjectFilter
    
    static int SubCategoryObjectFilter_Offset;
    /// <summary>
    /// Filter for limiting the compatible object types for this data pin.
    /// This property is editor-only, but it is automatically copied into PinSubCategoryObject if the PinType matches (for runtime use).
    /// </summary>
    public TSubclassOf<UnrealSharp.CoreUObject.UObject> SubCategoryObjectFilter;
    
    // SubCategoryEnumClass
    
    static int SubCategoryEnumClass_Offset;
    /// <summary>
    /// Configuration option for setting the EnumClass to a Blueprint Enum
    /// (C++ enums must bind by name using SubCategoryEnumName, due to a limitation with UE's UEnum discovery).
    /// This property is editor-only, but it is automatically copied into PinSubCategoryObject if the PinType matches (for runtime use).
    /// </summary>
    public UnrealSharp.CoreUObject.UEnum SubCategoryEnumClass;
    
    // SubCategoryEnumName
    
    static int SubCategoryEnumName_Offset;
    static IntPtr SubCategoryEnumName_NativeProperty;
    /// <summary>
    /// name of enum defined in c++ code, will take priority over asset from EnumType property
    ///  (this is a work-around because EnumClass cannot find C++ Enums,
    ///   so you need to type the name of the enum in here, manually)
    /// See also: FFlowPin::PostEditChangedEnumName()
    /// </summary>
    public string SubCategoryEnumName;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowPin()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowPin");
        IntPtr PinName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinName");
        PinName_Offset = FPropertyExporter.CallGetPropertyOffset(PinName_NativeProperty);
        IntPtr PinFriendlyName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinFriendlyName");
        PinFriendlyName_Offset = FPropertyExporter.CallGetPropertyOffset(PinFriendlyName_NativeProperty);
        PinToolTip_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinToolTip");
        PinToolTip_Offset = FPropertyExporter.CallGetPropertyOffset(PinToolTip_NativeProperty);
        IntPtr PinType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinType");
        PinType_Offset = FPropertyExporter.CallGetPropertyOffset(PinType_NativeProperty);
        IntPtr PinSubCategoryObject_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PinSubCategoryObject");
        PinSubCategoryObject_Offset = FPropertyExporter.CallGetPropertyOffset(PinSubCategoryObject_NativeProperty);
        #if WITH_EDITOR
        IntPtr SubCategoryClassFilter_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubCategoryClassFilter");
        SubCategoryClassFilter_Offset = FPropertyExporter.CallGetPropertyOffset(SubCategoryClassFilter_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr SubCategoryObjectFilter_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubCategoryObjectFilter");
        SubCategoryObjectFilter_Offset = FPropertyExporter.CallGetPropertyOffset(SubCategoryObjectFilter_NativeProperty);
        #endif
        #if WITH_EDITOR
        IntPtr SubCategoryEnumClass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubCategoryEnumClass");
        SubCategoryEnumClass_Offset = FPropertyExporter.CallGetPropertyOffset(SubCategoryEnumClass_NativeProperty);
        #endif
        #if WITH_EDITOR
        SubCategoryEnumName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SubCategoryEnumName");
        SubCategoryEnumName_Offset = FPropertyExporter.CallGetPropertyOffset(SubCategoryEnumName_NativeProperty);
        #endif
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowPin(IntPtr InNativeStruct)
    {
        unsafe
        {
            PinName = BlittableMarshaller<FName>.FromNative(IntPtr.Add(InNativeStruct, PinName_Offset), 0);
            PinFriendlyName = TextMarshaller.FromNative(IntPtr.Add(InNativeStruct, PinFriendlyName_Offset), 0);
            IntPtr PinToolTip_NativePtr = IntPtr.Add(InNativeStruct,PinToolTip_Offset);
            PinToolTip = StringMarshaller.FromNative(PinToolTip_NativePtr,0);
            PinType = EnumMarshaller<UnrealSharp.Flow.EFlowPinType>.FromNative(IntPtr.Add(InNativeStruct, PinType_Offset), 0);
            PinSubCategoryObject = BlittableMarshaller<TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>>.FromNative(IntPtr.Add(InNativeStruct, PinSubCategoryObject_Offset), 0);
            #if WITH_EDITOR
            SubCategoryClassFilter = SubclassOfMarshaller<UnrealSharp.CoreUObject.UClass>.FromNative(IntPtr.Add(InNativeStruct, SubCategoryClassFilter_Offset), 0);
            #endif
            #if WITH_EDITOR
            SubCategoryObjectFilter = SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.FromNative(IntPtr.Add(InNativeStruct, SubCategoryObjectFilter_Offset), 0);
            #endif
            #if WITH_EDITOR
            SubCategoryEnumClass = ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.FromNative(IntPtr.Add(InNativeStruct, SubCategoryEnumClass_Offset), 0);
            #endif
            #if WITH_EDITOR
            IntPtr SubCategoryEnumName_NativePtr = IntPtr.Add(InNativeStruct,SubCategoryEnumName_Offset);
            SubCategoryEnumName = StringMarshaller.FromNative(SubCategoryEnumName_NativePtr,0);
            #endif
        }
    }
    
    public static FFlowPin FromNative(IntPtr buffer) => new FFlowPin(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<FName>.ToNative(IntPtr.Add(buffer, PinName_Offset), 0, PinName);
            TextMarshaller.ToNative(IntPtr.Add(buffer, PinFriendlyName_Offset), 0, PinFriendlyName);
            IntPtr PinToolTip_NativePtr = IntPtr.Add(buffer, PinToolTip_Offset);
            StringMarshaller.ToNative(PinToolTip_NativePtr,0,PinToolTip);
            EnumMarshaller<UnrealSharp.Flow.EFlowPinType>.ToNative(IntPtr.Add(buffer, PinType_Offset), 0, PinType);
            BlittableMarshaller<TWeakObjectPtr<UnrealSharp.CoreUObject.UObject>>.ToNative(IntPtr.Add(buffer, PinSubCategoryObject_Offset), 0, PinSubCategoryObject);
            #if WITH_EDITOR
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UClass>.ToNative(IntPtr.Add(buffer, SubCategoryClassFilter_Offset), 0, SubCategoryClassFilter);
            #endif
            #if WITH_EDITOR
            SubclassOfMarshaller<UnrealSharp.CoreUObject.UObject>.ToNative(IntPtr.Add(buffer, SubCategoryObjectFilter_Offset), 0, SubCategoryObjectFilter);
            #endif
            #if WITH_EDITOR
            ObjectMarshaller<UnrealSharp.CoreUObject.UEnum>.ToNative(IntPtr.Add(buffer, SubCategoryEnumClass_Offset), 0, SubCategoryEnumClass);
            #endif
            #if WITH_EDITOR
            IntPtr SubCategoryEnumName_NativePtr = IntPtr.Add(buffer, SubCategoryEnumName_Offset);
            StringMarshaller.ToNative(SubCategoryEnumName_NativePtr,0,SubCategoryEnumName);
            #endif
        }
    }
}

public static class FFlowPinMarshaller
{
    public static FFlowPin FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowPin(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowPin obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowPin.NativeDataSize;
    }
}