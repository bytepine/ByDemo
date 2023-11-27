// Copyright Byteyang Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "LuaSubsystem.h"
#include "Subsystems/WorldSubsystem.h"
#include "PanelSubsystem.generated.h"

/**
 * 
 */
UCLASS()
class BYFRAMEWORK_API UPanelSubsystem : public UWorldSubsystem
{
	GENERATED_BODY()

public:
	/** Called when world is ready to start gameplay before the game mode transitions to the correct state and call BeginPlay on all actors */
	virtual void OnWorldBeginPlay(UWorld& InWorld) override;

protected:
	ULuaSubsystem* GetLuaSubsystem();
	
public:
	/**
	 * 打开面板
	 * @tparam T 类型
	 * @param PanelKey 事件Key
	 * @param Args 参数列表
	 */
	template <typename... T>
	void OpenPanel(int32 PanelKey, T&&... Args)
	{
		GetLuaSubsystem()->CallSystemFunction("PanelSystem", "OpenPanel", PanelKey, Forward<T>(Args)...);
	}

	/**
 * 关闭面板
 * @param PanelKey 面板Key
 */
	void ClosePanel(int32 PanelKey)
	{
		GetLuaSubsystem()->CallSystemFunction("PanelSystem", "ClosePanel", PanelKey);
	}
};
