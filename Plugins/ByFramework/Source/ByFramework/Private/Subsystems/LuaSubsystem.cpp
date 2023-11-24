// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "Subsystems/LuaSubsystem.h"
#include "UnLuaLegacy.h"

void ULuaSubsystem::Initialize(FSubsystemCollectionBase& Collection)
{
	Super::Initialize(Collection);
	
	PostWorldInitializationHandle = FWorldDelegates::OnPostWorldInitialization.AddUObject(this, &ULuaSubsystem::OnPostWorldInitialization);
}

void ULuaSubsystem::Deinitialize()
{
	Super::Deinitialize();
	
	FWorldDelegates::OnPostWorldInitialization.Remove(PostWorldInitializationHandle);
}

template <typename ... T>
void ULuaSubsystem::CallSystem(const char* TableName, const char* FuncName, T&&... Args)
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
	CallSystem("EventSystem", "Broadcast", EventKey, Forward<T>(Args)...);
}

template <typename ... T>
void ULuaSubsystem::OpenPanel(int32 PanelKey, T&&... Args)
{
	CallSystem("PanelSystem", "OpenPanel", PanelKey, Forward<T>(Args)...);
}

void ULuaSubsystem::ClosePanel(int32 PanelKey)
{
	CallSystem("PanelSystem", "ClosePanel", PanelKey);
}

void ULuaSubsystem::OnPostWorldInitialization(UWorld* World, const UWorld::InitializationValues IVS)
{
	CallSystem("WorldSystem", "OnPostWorldInitialization", World->GetName());
}
