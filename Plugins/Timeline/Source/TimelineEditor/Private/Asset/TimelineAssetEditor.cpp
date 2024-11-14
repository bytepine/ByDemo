#include "Asset/TimelineAssetEditor.h"
#include "Graph/TimelineGraphEditor.h"
#include "TimelineAsset.h"

#define LOCTEXT_NAMESPACE "TimelineAssetEditor"

const FName FTimelineAssetEditor::DetailsTab(TEXT("Details"));

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

	BindToolbarCommands();
	CreateToolbar();
	CreateWidgets();
	
	const TSharedRef<FTabManager::FLayout> StandaloneDefaultLayout = FTabManager::NewLayout("TimelineAssetEditor_Layout")
	->AddArea
	(
		FTabManager::NewPrimaryArea()->SetOrientation(Orient_Horizontal)
		->Split
		(
			FTabManager::NewStack()
			->SetSizeCoefficient(0.225f)
			->AddTab(DetailsTab, ETabState::OpenedTab)
		)
	);
	
	constexpr bool bCreateDefaultStandaloneMenu = true;
	constexpr bool bCreateDefaultToolbar = true;
	const FName AppIdentifier = TEXT("TimelineEditor");
	FAssetEditorToolkit::InitAssetEditor(Mode, InitToolkitHost, AppIdentifier, StandaloneDefaultLayout, bCreateDefaultStandaloneMenu, bCreateDefaultToolbar, ObjectToEdit, false);

	RegenerateMenusAndToolbars();
}

void FTimelineAssetEditor::AddReferencedObjects(FReferenceCollector& Collector)
{
	Collector.AddReferencedObject(TimelineAsset);
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

void FTimelineAssetEditor::RegisterTabSpawners(const TSharedRef<class FTabManager>& InTabManager)
{
	WorkspaceMenuCategory = InTabManager->AddLocalWorkspaceMenuCategory(LOCTEXT("WorkspaceMenu_TimelineAssetEditor", "Timeline Editor"));
	const auto WorkspaceMenuCategoryRef = WorkspaceMenuCategory.ToSharedRef();
	
	FAssetEditorToolkit::RegisterTabSpawners(InTabManager);

	InTabManager->RegisterTabSpawner(DetailsTab, FOnSpawnTab::CreateSP(this, &FTimelineAssetEditor::SpawnTab_Details))
			.SetDisplayName(LOCTEXT("DetailsTab", "Details"))
			.SetGroup(WorkspaceMenuCategoryRef)
			.SetIcon(FSlateIcon(FAppStyle::GetAppStyleSetName(), "LevelEditor.Tabs.Details"));
	
}

void FTimelineAssetEditor::UnregisterTabSpawners(const TSharedRef<class FTabManager>& InTabManager)
{
	FAssetEditorToolkit::UnregisterTabSpawners(InTabManager);

	InTabManager->UnregisterTabSpawner(DetailsTab);
}

void FTimelineAssetEditor::InitToolMenuContext(FToolMenuContext& MenuContext)
{
	FAssetEditorToolkit::InitToolMenuContext(MenuContext);
}

void FTimelineAssetEditor::PostRegenerateMenusAndToolbars()
{
	
}

void FTimelineAssetEditor::SaveAsset_Execute()
{
	FAssetEditorToolkit::SaveAsset_Execute();
}

void FTimelineAssetEditor::SaveAssetAs_Execute()
{
	FAssetEditorToolkit::SaveAssetAs_Execute();
}

void FTimelineAssetEditor::CreateToolbar()
{
	
}

void FTimelineAssetEditor::BindToolbarCommands()
{
	
}

void FTimelineAssetEditor::CreateWidgets()
{
	// Details View
	{
		FDetailsViewArgs Args;
		Args.bHideSelectionTip = true;
		Args.bShowPropertyMatrixButton = false;
		Args.DefaultsOnlyVisibility = EEditDefaultsOnlyNodeVisibility::Hide;
		Args.NotifyHook = this;

		FPropertyEditorModule& PropertyModule = FModuleManager::LoadModuleChecked<FPropertyEditorModule>("PropertyEditor");
		DetailsView = PropertyModule.CreateDetailView(Args);
		DetailsView->SetIsPropertyEditingEnabledDelegate(FIsPropertyEditingEnabled::CreateStatic(&FTimelineAssetEditor::CanEdit));
		DetailsView->SetObject(TimelineAsset);
	}

	// Graph
	CreateGraphWidget();
	// GraphEditor->OnSelectionChangedEvent.BindRaw(this, &FFlowAssetEditor::OnSelectedNodesChanged);
}

void FTimelineAssetEditor::CreateGraphWidget()
{
	SAssignNew(GraphEditor, STimelineGraphEditor, SharedThis(this))
		.DetailsView(DetailsView);
}

bool FTimelineAssetEditor::CanEdit()
{
	return GEditor->PlayWorld == nullptr;
}

TSharedRef<SDockTab> FTimelineAssetEditor::SpawnTab_Details(const FSpawnTabArgs& Args) const
{
	check(Args.GetTabId() == DetailsTab);

	return SNew(SDockTab)
		.Label(LOCTEXT("TimelineDetailsTitle", "Details"))
		[
			DetailsView.ToSharedRef()
		];
}

#undef LOCTEXT_NAMESPACE
