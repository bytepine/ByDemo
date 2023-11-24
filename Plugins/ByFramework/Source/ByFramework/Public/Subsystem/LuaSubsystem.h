// Copyright Byteyang Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "LuaSubsystem.generated.h"

/**
 * 
 */
UCLASS()
class BYFRAMEWORK_API ULuaSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()

public:
	template <typename... T>
	void CallEnv(const char* TableName, const char* FuncName, T&&... Args);
	
	/**
	 * 广播事件
	 * @tparam T 类型
	 * @param EventKey 事件Key
	 * @param Args 参数列表
	 */
	template <typename... T>
	void BroadcastEvent(int32 EventKey, T&&... Args);
	
	/**
	 * 打开面板
	 * @tparam T 类型
	 * @param PanelKey 事件Key
	 * @param Args 参数列表
	 */
	template <typename... T>
	void OpenPanel(int32 PanelKey, T&&... Args);

	/**
	 * 关闭面板
	 * @param PanelKey 面板Key
	 */
	void ClosePanel(int32 PanelKey);
};
