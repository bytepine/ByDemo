// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "Subsystems/PanelSubsystem.h"

void UPanelSubsystem::OnWorldBeginPlay(UWorld& InWorld)
{
	Super::OnWorldBeginPlay(InWorld);
	
	GetLuaSubsystem()->CallSystemFunction("WorldSystem", "OnWorldBeginPlay", &InWorld, InWorld.GetName());
}

ULuaSubsystem* UPanelSubsystem::GetLuaSubsystem()
{
	return GetWorld()->GetGameInstance()->GetSubsystem<ULuaSubsystem>();
}
