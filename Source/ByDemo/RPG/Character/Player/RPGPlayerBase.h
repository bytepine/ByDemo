// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "ByDemo/RPG/Character/RPGCharacterBase.h"
#include "RPGPlayerBase.generated.h"

class UInputAction;
struct FInputActionValue;

UCLASS(Abstract)
class BYDEMO_API ARPGPlayerBase : public ARPGCharacterBase
{
	GENERATED_BODY()

public:
	// Sets default values for this character's properties
	ARPGPlayerBase();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// Called to bind functionality to input
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;
	
protected:
	/** Jump Input Action */
	UPROPERTY(EditAnywhere, Category="Input")
	UInputAction* JumpAction;

	/** Move Input Action */
	UPROPERTY(EditAnywhere, Category="Input")
	UInputAction* MoveAction;

	/** Look Input Action */
	UPROPERTY(EditAnywhere, Category="Input")
	UInputAction* LookAction;
	
	/** Called for movement input */
	void InputMove(const FInputActionValue& Value);

	/** Called for looking input */
	void InputAim(const FInputActionValue& Value);
};
