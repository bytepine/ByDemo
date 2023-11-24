// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "Subsystem/LuaSubsystem.h"
#include "UnLuaLegacy.h"

template <typename ... T>
void ULuaSubsystem::CallEnv(const char* TableName, const char* FuncName, T&&... Args)
{
	lua_State* L = UnLua::GetState();
	if (lua_getglobal(L, "Env") == LUA_TTABLE)
	{
		lua_getfield(L, -1, TableName);
		UnLua::FLuaTable EventSystem(L, -1);
		EventSystem.Call(FuncName, EventSystem, Forward<T>(Args)...);
		lua_pop(L, 1);
	}
	lua_pop(L, 1);
}

template <typename ... T>
void ULuaSubsystem::BroadcastEvent(int32 EventKey, T&&... Args)
{
	CallEnv("EventSystem", "Broadcast", EventKey, Forward<T>(Args)...);
}

template <typename ... T>
void ULuaSubsystem::OpenPanel(int32 PanelKey, T&&... Args)
{
	CallEnv("PanelSystem", "OpenPanel", PanelKey, Forward<T>(Args)...);
}

void ULuaSubsystem::ClosePanel(int32 PanelKey)
{
	CallEnv("PanelSystem", "ClosePanel", PanelKey);
}
