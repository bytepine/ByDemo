// Copyright Byteyang Games, Inc. All Rights Reserved.

#pragma once

#include "Toolkits/AssetEditorToolkit.h"

class UTimelineAsset;

class TIMELINEEDITOR_API FTimelineAssetEditor : public FAssetEditorToolkit, public FEditorUndoClient
{
public:
	FTimelineAssetEditor();
	virtual ~FTimelineAssetEditor() override;
	
	/** Edits the specified FlowAsset object */
	void InitTimelineAssetEditor(const EToolkitMode::Type Mode, const TSharedPtr<class IToolkitHost>& InitToolkitHost, UObject* ObjectToEdit);

	// IToolkit
	virtual FName GetToolkitFName() const override;
	virtual FText GetBaseToolkitName() const override;
	virtual FString GetWorldCentricTabPrefix() const override;
	virtual FLinearColor GetWorldCentricTabColorScale() const override;

	// FAssetEditorToolkit
	virtual void InitToolMenuContext(FToolMenuContext& MenuContext) override;
	virtual void PostRegenerateMenusAndToolbars() override;
	virtual void SaveAsset_Execute() override;
	virtual void SaveAssetAs_Execute() override;
	
protected:
	/** The Flow Asset being edited */
	TObjectPtr<UTimelineAsset> TimelineAsset;
};
