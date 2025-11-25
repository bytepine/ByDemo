// Fill out your copyright notice in the Description page of Project Settings.


#include "RPGPlayerBase.h"

#include "Kismet/KismetMathLibrary.h"


// Sets default values
ARPGPlayerBase::ARPGPlayerBase()
{
	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ARPGPlayerBase::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ARPGPlayerBase::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

// Called to bind functionality to input
void ARPGPlayerBase::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);
}

void ARPGPlayerBase::InputMove(const FVector2D& Axis)
{
	const FRotator Rotation = GetControlRotation();
	const FVector RightVector = UKismetMathLibrary::GetRightVector(FRotator(Rotation.Roll, 0, Rotation.Yaw));
	AddMovementInput(RightVector, Axis.X);
	
	const FVector ForwardVector = UKismetMathLibrary::GetForwardVector(FRotator(0, 0, Rotation.Yaw));
	AddMovementInput(ForwardVector, Axis.Y);
}

void ARPGPlayerBase::InputAim(const FVector2D& Axis)
{
	AddControllerYawInput(Axis.X);
	AddControllerPitchInput(Axis.Y);
}

