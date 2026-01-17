// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "ByGameInstance.h"

#include "ByDefine.h"

void UByGameInstance::Init()
{
	Super::Init();
	
	UE_LOG(LogByDemo, Log, TEXT("UByGameInstance::Init"));
}

void UByGameInstance::Shutdown()
{
	Super::Shutdown();
	
	UE_LOG(LogByDemo, Log, TEXT("UByGameInstance::Shutdown"));
}
