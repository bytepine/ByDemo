// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerController.h"
#include "RPGPlayerControllerBase.generated.h"

class UNovaUIComponent;
class UInputMappingContext;
class UUserWidget;

/**
 * 
 */
UCLASS(Abstract)
class BYDEMO_API ARPGPlayerControllerBase : public APlayerController
{
	GENERATED_BODY()
	
protected:
	ARPGPlayerControllerBase(const FObjectInitializer& ObjectInitializer);
	
	/** Gameplay initialization */
	virtual void BeginPlay() override;
	
	/** Input mapping context setup */
	virtual void SetupInputComponent() override;
	
	/** Returns true if the player should use UMG touch controls */
	bool ShouldUseTouchControls() const;
	
	/** Input Mapping Contexts */
	UPROPERTY(EditAnywhere, Category ="Input|Input Mappings")
	TArray<UInputMappingContext*> DefaultMappingContexts;

	/** Input Mapping Contexts */
	UPROPERTY(EditAnywhere, Category="Input|Input Mappings")
	TArray<UInputMappingContext*> MobileExcludedMappingContexts;
	
	/** Mobile controls widget to spawn */
	UPROPERTY(EditAnywhere, Category="Input|Touch Controls")
	TSubclassOf<UUserWidget> MobileControlsWidgetClass;

	/** Pointer to the mobile controls widget */
	UPROPERTY()
	TObjectPtr<UUserWidget> MobileControlsWidget;
	
	/** If true, the player will use UMG touch controls even if not playing on mobile platforms */
	UPROPERTY(EditAnywhere, Config, Category = "Input|Touch Controls")
	bool bForceTouchControls = false;
	
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly)
	UNovaUIComponent* NovaUIComponent;
};
