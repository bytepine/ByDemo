#include "TimelineEditor.h"
#include "AssetToolsModule.h"
#include "AssetTypeActions_TimelineAsset.h"
#include "IAssetTools.h"

#define LOCTEXT_NAMESPACE "FTimelineEditorModule"

EAssetTypeCategories::Type FTimelineEditorModule::TimelineAssetCategory = static_cast<EAssetTypeCategories::Type>(0);

void FTimelineEditorModule::StartupModule()
{
    RegisterAssets();
}

void FTimelineEditorModule::ShutdownModule()
{
    UnregisterAssets();
}

void FTimelineEditorModule::RegisterAssets()
{
    IAssetTools& AssetTools = FModuleManager::LoadModuleChecked<FAssetToolsModule>("AssetTools").Get();

    // try to merge asset category with a built-in one
    {
    	const FText AssetCategoryText = LOCTEXT("TimelineAssetCategory", "Timeline");

    	// Find matching built-in category
    	if (!AssetCategoryText.IsEmpty())
    	{
    		TArray<FAdvancedAssetCategory> AllCategories;
    		AssetTools.GetAllAdvancedAssetCategories(AllCategories);
    		for (const FAdvancedAssetCategory& ExistingCategory : AllCategories)
    		{
    			if (ExistingCategory.CategoryName.EqualTo(AssetCategoryText))
    			{
    				TimelineAssetCategory = ExistingCategory.CategoryType;
    				break;
    			}
    		}
    	}

    	if (TimelineAssetCategory == EAssetTypeCategories::None)
    	{
    		TimelineAssetCategory = AssetTools.RegisterAdvancedAssetCategory(FName(TEXT("Timeline")), AssetCategoryText);
    	}
    }
    
    const TSharedRef<IAssetTypeActions> TimelineAssetActions = MakeShareable(new FAssetTypeActions_TimelineAsset());
    RegisteredAssetActions.Add(TimelineAssetActions);
    AssetTools.RegisterAssetTypeActions(TimelineAssetActions);
}

void FTimelineEditorModule::UnregisterAssets()
{
    if (FModuleManager::Get().IsModuleLoaded("AssetTools"))
    {
        IAssetTools& AssetTools = FModuleManager::GetModuleChecked<FAssetToolsModule>("AssetTools").Get();
        for (const TSharedRef<IAssetTypeActions>& TypeAction : RegisteredAssetActions)
        {
            AssetTools.UnregisterAssetTypeActions(TypeAction);
        }
    }

    RegisteredAssetActions.Empty();
}

#undef LOCTEXT_NAMESPACE
    
IMPLEMENT_MODULE(FTimelineEditorModule, TimelineEditor)