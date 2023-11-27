// Copyright Byteyang Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "UnLuaLegacy.h"
#include "LuaSubsystem.generated.h"

/**
 * 
 */
UCLASS()
class BYFRAMEWORK_API ULuaSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()

public:
	/**
	 * 调用System方法
	 * @tparam T 类型
	 * @param SystemName 表名
	 * @param FuncName 方法名
	 * @param Args 参数列表
	 */
	template <typename... T>
	void CallSystemFunction(const char* SystemName, const char* FuncName, T&&... Args)
	{
		lua_State* L = UnLua::GetState();
		if (lua_getglobal(L, "Env") == LUA_TTABLE)
		{
			if (lua_getfield(L, -1, "Systems") == LUA_TTABLE)
			{
				if (lua_getfield(L, -1, SystemName) == LUA_TTABLE)
				{
					UnLua::FLuaTable EventSystem(L, -1);
					EventSystem.Call(FuncName, EventSystem, Forward<T>(Args)...);
				}
				lua_pop(L, 1);
			}
			lua_pop(L, 1);
		}
		lua_pop(L, 1);
	}

	/**
	 * 调用Manager方法
	 * @tparam T 类型
	 * @param ManagerName 表名
	 * @param FuncName 方法名
	 * @param Args 参数列表
	 */
	template <typename... T>
	void CallManagerFunction(const char* ManagerName, const char* FuncName, T&&... Args)
	{
		lua_State* L = UnLua::GetState();
		if (lua_getglobal(L, "Env") == LUA_TTABLE)
		{
			if (lua_getfield(L, -1, "Managers") == LUA_TTABLE)
			{
				if (lua_getfield(L, -1, ManagerName))
				{
					UnLua::FLuaTable EventSystem(L, -1);
					EventSystem.Call(FuncName, EventSystem, Forward<T>(Args)...);
				}
				lua_pop(L, 1);
			}
			lua_pop(L, 1);
		}
		lua_pop(L, 1);
	}
	
	/**
	 * 广播事件
	 * @tparam T 类型
	 * @param EventKey 事件Key
	 * @param Args 参数列表
	 */
	template <typename... T>
	void BroadcastEvent(int32 EventKey, T&&... Args)
	{
		CallSystemFunction("EventSystem", "Broadcast", EventKey, Forward<T>(Args)...);
	}
};
