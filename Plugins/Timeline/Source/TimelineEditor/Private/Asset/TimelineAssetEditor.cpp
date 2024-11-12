#include "Asset/TimelineAssetEditor.h"
#include "TimelineAsset.h"

#define LOCTEXT_NAMESPACE "TimelineAssetEditor"

FTimelineAssetEditor::FTimelineAssetEditor()
	: TimelineAsset(nullptr)
{
	
}

FTimelineAssetEditor::~FTimelineAssetEditor()
{
	GEditor->UnregisterForUndo(this);
}

void FTimelineAssetEditor::InitTimelineAssetEditor(const EToolkitMode::Type Mode,
	const TSharedPtr<IToolkitHost>& InitToolkitHost, UObject* ObjectToEdit)
{
	TimelineAsset = CastChecked<UTimelineAsset>(ObjectToEdit);

	// Support undo/redo
	TimelineAsset->SetFlags(RF_Transactional);
	GEditor->RegisterForUndo(this);

	const TSharedRef<FTabManager::FLayout> StandaloneDefaultLayout = FTabManager::NewLayout("TimelineAssetEditor_Layout")
	->AddArea
	(
		FTabManager::NewPrimaryArea()->SetOrientation(Orient_Horizontal)
	);
	
	constexpr bool bCreateDefaultStandaloneMenu = true;
	constexpr bool bCreateDefaultToolbar = true;
	const FName AppIdentifier = TEXT("TimelineEditor");
	FAssetEditorToolkit::InitAssetEditor(Mode, InitToolkitHost, AppIdentifier, StandaloneDefaultLayout, bCreateDefaultStandaloneMenu, bCreateDefaultToolbar, ObjectToEdit, false);
}

FName FTimelineAssetEditor::GetToolkitFName() const
{
	return FName("TimelineEditor");
}

FText FTimelineAssetEditor::GetBaseToolkitName() const
{
	return LOCTEXT("AppLabel", "TimelineAsset Editor");
}

FString FTimelineAssetEditor::GetWorldCentricTabPrefix() const
{
	return LOCTEXT("WorldCentricTabPrefix", "TimelineAsset").ToString();
}

FLinearColor FTimelineAssetEditor::GetWorldCentricTabColorScale() const
{
	return FLinearColor(0.3f, 0.2f, 0.5f, 0.5f);
}

void FTimelineAssetEditor::InitToolMenuContext(FToolMenuContext& MenuContext)
{
	FAssetEditorToolkit::InitToolMenuContext(MenuContext);
}

void FTimelineAssetEditor::PostRegenerateMenusAndToolbars()
{
	FAssetEditorToolkit::PostRegenerateMenusAndToolbars();
}

void FTimelineAssetEditor::SaveAsset_Execute()
{
	FAssetEditorToolkit::SaveAsset_Execute();
}

void FTimelineAssetEditor::SaveAssetAs_Execute()
{
	FAssetEditorToolkit::SaveAssetAs_Execute();
}

#undef LOCTEXT_NAMESPACE
