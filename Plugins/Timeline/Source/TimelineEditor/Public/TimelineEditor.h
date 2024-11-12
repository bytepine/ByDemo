#pragma once

#include "CoreMinimal.h"
#include "AssetTypeCategories.h"
#include "Modules/ModuleManager.h"
#include "IAssetTypeActions.h"

class FTimelineEditorModule : public IModuleInterface
{
public:
    static EAssetTypeCategories::Type TimelineAssetCategory;
public:
    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
    
private:
    void RegisterAssets();
    void UnregisterAssets();

public:
private:
    TArray<TSharedRef<IAssetTypeActions>> RegisteredAssetActions;
};
