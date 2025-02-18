using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.FlowEditor;

/// <summary>
/// Action to create new comment
/// </summary>
[UStruct, GeneratedType("FlowGraphSchemaAction_NewComment", "UnrealSharp.FlowEditor.FlowGraphSchemaAction_NewComment")]
public partial struct FFlowGraphSchemaAction_NewComment : MarshalledStruct<FFlowGraphSchemaAction_NewComment>
{
    // MenuDescription
    
    static int MenuDescription_Offset;
    /// <summary>
    /// The menu text that should be displayed for this node in the creation menu.
    /// </summary>
    private FText MenuDescription;
    
    // TooltipDescription
    
    static int TooltipDescription_Offset;
    /// <summary>
    /// The tooltip text that should be displayed for this node in the creation menu.
    /// </summary>
    private FText TooltipDescription;
    
    // Category
    
    static int Category_Offset;
    /// <summary>
    /// This is the UI centric category the action fits in (e.g., Functions, Variables). Use this instead of the NodeType.NodeCategory because multiple NodeCategories might visually belong together.
    /// </summary>
    private FText Category;
    
    // Keywords
    
    static int Keywords_Offset;
    /// <summary>
    /// This is just an arbitrary dump of extra text that search will match on, in addition to the description and tooltip, e.g., Add might have the keyword Math.
    /// </summary>
    private FText Keywords;
    
    // CategoryChain
    
    static int CategoryChain_Offset;
    static IntPtr CategoryChain_NativeProperty;
    static ArrayCopyMarshaller<string> CategoryChain_Marshaller = null;
    /// <summary>
    /// Cached chain of pipe separated categories
    /// </summary>
    private System.Collections.Generic.IList<string> CategoryChain;
    
    // Grouping
    
    static int Grouping_Offset;
    /// <summary>
    /// This is a priority number for overriding alphabetical order in the action list (higher value  == higher in the list).
    /// </summary>
    public int Grouping;
    
    // SectionID
    
    static int SectionID_Offset;
    /// <summary>
    /// Section ID of the action list in which this action belongs.
    /// </summary>
    public int SectionID;
    
    // MenuDescriptionArray
    
    static int MenuDescriptionArray_Offset;
    static IntPtr MenuDescriptionArray_NativeProperty;
    static ArrayCopyMarshaller<string> MenuDescriptionArray_Marshaller = null;
    public System.Collections.Generic.IList<string> MenuDescriptionArray;
    
    // FullSearchTitlesArray
    
    static int FullSearchTitlesArray_Offset;
    static IntPtr FullSearchTitlesArray_NativeProperty;
    static ArrayCopyMarshaller<string> FullSearchTitlesArray_Marshaller = null;
    public System.Collections.Generic.IList<string> FullSearchTitlesArray;
    
    // FullSearchKeywordsArray
    
    static int FullSearchKeywordsArray_Offset;
    static IntPtr FullSearchKeywordsArray_NativeProperty;
    static ArrayCopyMarshaller<string> FullSearchKeywordsArray_Marshaller = null;
    public System.Collections.Generic.IList<string> FullSearchKeywordsArray;
    
    // FullSearchCategoryArray
    
    static int FullSearchCategoryArray_Offset;
    static IntPtr FullSearchCategoryArray_NativeProperty;
    static ArrayCopyMarshaller<string> FullSearchCategoryArray_Marshaller = null;
    public System.Collections.Generic.IList<string> FullSearchCategoryArray;
    
    // LocalizedMenuDescriptionArray
    
    static int LocalizedMenuDescriptionArray_Offset;
    static IntPtr LocalizedMenuDescriptionArray_NativeProperty;
    static ArrayCopyMarshaller<string> LocalizedMenuDescriptionArray_Marshaller = null;
    public System.Collections.Generic.IList<string> LocalizedMenuDescriptionArray;
    
    // LocalizedFullSearchTitlesArray
    
    static int LocalizedFullSearchTitlesArray_Offset;
    static IntPtr LocalizedFullSearchTitlesArray_NativeProperty;
    static ArrayCopyMarshaller<string> LocalizedFullSearchTitlesArray_Marshaller = null;
    public System.Collections.Generic.IList<string> LocalizedFullSearchTitlesArray;
    
    // LocalizedFullSearchKeywordsArray
    
    static int LocalizedFullSearchKeywordsArray_Offset;
    static IntPtr LocalizedFullSearchKeywordsArray_NativeProperty;
    static ArrayCopyMarshaller<string> LocalizedFullSearchKeywordsArray_Marshaller = null;
    public System.Collections.Generic.IList<string> LocalizedFullSearchKeywordsArray;
    
    // LocalizedFullSearchCategoryArray
    
    static int LocalizedFullSearchCategoryArray_Offset;
    static IntPtr LocalizedFullSearchCategoryArray_NativeProperty;
    static ArrayCopyMarshaller<string> LocalizedFullSearchCategoryArray_Marshaller = null;
    public System.Collections.Generic.IList<string> LocalizedFullSearchCategoryArray;
    
    // SearchText
    
    static int SearchText_Offset;
    static IntPtr SearchText_NativeProperty;
    public string SearchText;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FFlowGraphSchemaAction_NewComment()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FlowGraphSchemaAction_NewComment");
        IntPtr MenuDescription_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "MenuDescription");
        MenuDescription_Offset = FPropertyExporter.CallGetPropertyOffset(MenuDescription_NativeProperty);
        IntPtr TooltipDescription_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TooltipDescription");
        TooltipDescription_Offset = FPropertyExporter.CallGetPropertyOffset(TooltipDescription_NativeProperty);
        IntPtr Category_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Category");
        Category_Offset = FPropertyExporter.CallGetPropertyOffset(Category_NativeProperty);
        IntPtr Keywords_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Keywords");
        Keywords_Offset = FPropertyExporter.CallGetPropertyOffset(Keywords_NativeProperty);
        #if WITH_EDITOR
        CategoryChain_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CategoryChain");
        CategoryChain_Offset = FPropertyExporter.CallGetPropertyOffset(CategoryChain_NativeProperty);
        #endif
        IntPtr Grouping_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Grouping");
        Grouping_Offset = FPropertyExporter.CallGetPropertyOffset(Grouping_NativeProperty);
        IntPtr SectionID_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SectionID");
        SectionID_Offset = FPropertyExporter.CallGetPropertyOffset(SectionID_NativeProperty);
        MenuDescriptionArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "MenuDescriptionArray");
        MenuDescriptionArray_Offset = FPropertyExporter.CallGetPropertyOffset(MenuDescriptionArray_NativeProperty);
        FullSearchTitlesArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FullSearchTitlesArray");
        FullSearchTitlesArray_Offset = FPropertyExporter.CallGetPropertyOffset(FullSearchTitlesArray_NativeProperty);
        FullSearchKeywordsArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FullSearchKeywordsArray");
        FullSearchKeywordsArray_Offset = FPropertyExporter.CallGetPropertyOffset(FullSearchKeywordsArray_NativeProperty);
        FullSearchCategoryArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FullSearchCategoryArray");
        FullSearchCategoryArray_Offset = FPropertyExporter.CallGetPropertyOffset(FullSearchCategoryArray_NativeProperty);
        LocalizedMenuDescriptionArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LocalizedMenuDescriptionArray");
        LocalizedMenuDescriptionArray_Offset = FPropertyExporter.CallGetPropertyOffset(LocalizedMenuDescriptionArray_NativeProperty);
        LocalizedFullSearchTitlesArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LocalizedFullSearchTitlesArray");
        LocalizedFullSearchTitlesArray_Offset = FPropertyExporter.CallGetPropertyOffset(LocalizedFullSearchTitlesArray_NativeProperty);
        LocalizedFullSearchKeywordsArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LocalizedFullSearchKeywordsArray");
        LocalizedFullSearchKeywordsArray_Offset = FPropertyExporter.CallGetPropertyOffset(LocalizedFullSearchKeywordsArray_NativeProperty);
        LocalizedFullSearchCategoryArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LocalizedFullSearchCategoryArray");
        LocalizedFullSearchCategoryArray_Offset = FPropertyExporter.CallGetPropertyOffset(LocalizedFullSearchCategoryArray_NativeProperty);
        SearchText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SearchText");
        SearchText_Offset = FPropertyExporter.CallGetPropertyOffset(SearchText_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FFlowGraphSchemaAction_NewComment(IntPtr InNativeStruct)
    {
        unsafe
        {
            MenuDescription = TextMarshaller.FromNative(IntPtr.Add(InNativeStruct, MenuDescription_Offset), 0);
            TooltipDescription = TextMarshaller.FromNative(IntPtr.Add(InNativeStruct, TooltipDescription_Offset), 0);
            Category = TextMarshaller.FromNative(IntPtr.Add(InNativeStruct, Category_Offset), 0);
            Keywords = TextMarshaller.FromNative(IntPtr.Add(InNativeStruct, Keywords_Offset), 0);
            #if WITH_EDITOR
            CategoryChain_Marshaller ??= new ArrayCopyMarshaller<string>(CategoryChain_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr CategoryChain_NativeBuffer = IntPtr.Add(InNativeStruct, CategoryChain_Offset);
            CategoryChain = CategoryChain_Marshaller.FromNative(CategoryChain_NativeBuffer, 0);
            #endif
            Grouping = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Grouping_Offset), 0);
            SectionID = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SectionID_Offset), 0);
            MenuDescriptionArray_Marshaller ??= new ArrayCopyMarshaller<string>(MenuDescriptionArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr MenuDescriptionArray_NativeBuffer = IntPtr.Add(InNativeStruct, MenuDescriptionArray_Offset);
            MenuDescriptionArray = MenuDescriptionArray_Marshaller.FromNative(MenuDescriptionArray_NativeBuffer, 0);
            FullSearchTitlesArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchTitlesArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchTitlesArray_NativeBuffer = IntPtr.Add(InNativeStruct, FullSearchTitlesArray_Offset);
            FullSearchTitlesArray = FullSearchTitlesArray_Marshaller.FromNative(FullSearchTitlesArray_NativeBuffer, 0);
            FullSearchKeywordsArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchKeywordsArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchKeywordsArray_NativeBuffer = IntPtr.Add(InNativeStruct, FullSearchKeywordsArray_Offset);
            FullSearchKeywordsArray = FullSearchKeywordsArray_Marshaller.FromNative(FullSearchKeywordsArray_NativeBuffer, 0);
            FullSearchCategoryArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchCategoryArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchCategoryArray_NativeBuffer = IntPtr.Add(InNativeStruct, FullSearchCategoryArray_Offset);
            FullSearchCategoryArray = FullSearchCategoryArray_Marshaller.FromNative(FullSearchCategoryArray_NativeBuffer, 0);
            LocalizedMenuDescriptionArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedMenuDescriptionArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedMenuDescriptionArray_NativeBuffer = IntPtr.Add(InNativeStruct, LocalizedMenuDescriptionArray_Offset);
            LocalizedMenuDescriptionArray = LocalizedMenuDescriptionArray_Marshaller.FromNative(LocalizedMenuDescriptionArray_NativeBuffer, 0);
            LocalizedFullSearchTitlesArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchTitlesArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchTitlesArray_NativeBuffer = IntPtr.Add(InNativeStruct, LocalizedFullSearchTitlesArray_Offset);
            LocalizedFullSearchTitlesArray = LocalizedFullSearchTitlesArray_Marshaller.FromNative(LocalizedFullSearchTitlesArray_NativeBuffer, 0);
            LocalizedFullSearchKeywordsArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchKeywordsArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchKeywordsArray_NativeBuffer = IntPtr.Add(InNativeStruct, LocalizedFullSearchKeywordsArray_Offset);
            LocalizedFullSearchKeywordsArray = LocalizedFullSearchKeywordsArray_Marshaller.FromNative(LocalizedFullSearchKeywordsArray_NativeBuffer, 0);
            LocalizedFullSearchCategoryArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchCategoryArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchCategoryArray_NativeBuffer = IntPtr.Add(InNativeStruct, LocalizedFullSearchCategoryArray_Offset);
            LocalizedFullSearchCategoryArray = LocalizedFullSearchCategoryArray_Marshaller.FromNative(LocalizedFullSearchCategoryArray_NativeBuffer, 0);
            IntPtr SearchText_NativePtr = IntPtr.Add(InNativeStruct,SearchText_Offset);
            SearchText = StringMarshaller.FromNative(SearchText_NativePtr,0);
        }
    }
    
    public static FFlowGraphSchemaAction_NewComment FromNative(IntPtr buffer) => new FFlowGraphSchemaAction_NewComment(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            TextMarshaller.ToNative(IntPtr.Add(buffer, MenuDescription_Offset), 0, MenuDescription);
            TextMarshaller.ToNative(IntPtr.Add(buffer, TooltipDescription_Offset), 0, TooltipDescription);
            TextMarshaller.ToNative(IntPtr.Add(buffer, Category_Offset), 0, Category);
            TextMarshaller.ToNative(IntPtr.Add(buffer, Keywords_Offset), 0, Keywords);
            #if WITH_EDITOR
            CategoryChain_Marshaller ??= new ArrayCopyMarshaller<string>(CategoryChain_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr CategoryChain_NativeBuffer = IntPtr.Add(buffer, CategoryChain_Offset);
            CategoryChain_Marshaller.ToNative(CategoryChain_NativeBuffer, 0, CategoryChain);
            #endif
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, Grouping_Offset), 0, Grouping);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, SectionID_Offset), 0, SectionID);
            MenuDescriptionArray_Marshaller ??= new ArrayCopyMarshaller<string>(MenuDescriptionArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr MenuDescriptionArray_NativeBuffer = IntPtr.Add(buffer, MenuDescriptionArray_Offset);
            MenuDescriptionArray_Marshaller.ToNative(MenuDescriptionArray_NativeBuffer, 0, MenuDescriptionArray);
            FullSearchTitlesArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchTitlesArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchTitlesArray_NativeBuffer = IntPtr.Add(buffer, FullSearchTitlesArray_Offset);
            FullSearchTitlesArray_Marshaller.ToNative(FullSearchTitlesArray_NativeBuffer, 0, FullSearchTitlesArray);
            FullSearchKeywordsArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchKeywordsArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchKeywordsArray_NativeBuffer = IntPtr.Add(buffer, FullSearchKeywordsArray_Offset);
            FullSearchKeywordsArray_Marshaller.ToNative(FullSearchKeywordsArray_NativeBuffer, 0, FullSearchKeywordsArray);
            FullSearchCategoryArray_Marshaller ??= new ArrayCopyMarshaller<string>(FullSearchCategoryArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr FullSearchCategoryArray_NativeBuffer = IntPtr.Add(buffer, FullSearchCategoryArray_Offset);
            FullSearchCategoryArray_Marshaller.ToNative(FullSearchCategoryArray_NativeBuffer, 0, FullSearchCategoryArray);
            LocalizedMenuDescriptionArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedMenuDescriptionArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedMenuDescriptionArray_NativeBuffer = IntPtr.Add(buffer, LocalizedMenuDescriptionArray_Offset);
            LocalizedMenuDescriptionArray_Marshaller.ToNative(LocalizedMenuDescriptionArray_NativeBuffer, 0, LocalizedMenuDescriptionArray);
            LocalizedFullSearchTitlesArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchTitlesArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchTitlesArray_NativeBuffer = IntPtr.Add(buffer, LocalizedFullSearchTitlesArray_Offset);
            LocalizedFullSearchTitlesArray_Marshaller.ToNative(LocalizedFullSearchTitlesArray_NativeBuffer, 0, LocalizedFullSearchTitlesArray);
            LocalizedFullSearchKeywordsArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchKeywordsArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchKeywordsArray_NativeBuffer = IntPtr.Add(buffer, LocalizedFullSearchKeywordsArray_Offset);
            LocalizedFullSearchKeywordsArray_Marshaller.ToNative(LocalizedFullSearchKeywordsArray_NativeBuffer, 0, LocalizedFullSearchKeywordsArray);
            LocalizedFullSearchCategoryArray_Marshaller ??= new ArrayCopyMarshaller<string>(LocalizedFullSearchCategoryArray_NativeProperty, StringMarshaller.ToNative, StringMarshaller.FromNative);
            IntPtr LocalizedFullSearchCategoryArray_NativeBuffer = IntPtr.Add(buffer, LocalizedFullSearchCategoryArray_Offset);
            LocalizedFullSearchCategoryArray_Marshaller.ToNative(LocalizedFullSearchCategoryArray_NativeBuffer, 0, LocalizedFullSearchCategoryArray);
            IntPtr SearchText_NativePtr = IntPtr.Add(buffer, SearchText_Offset);
            StringMarshaller.ToNative(SearchText_NativePtr,0,SearchText);
        }
    }
}

public static class FFlowGraphSchemaAction_NewCommentMarshaller
{
    public static FFlowGraphSchemaAction_NewComment FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FFlowGraphSchemaAction_NewComment(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FFlowGraphSchemaAction_NewComment obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FFlowGraphSchemaAction_NewComment.NativeDataSize;
    }
}