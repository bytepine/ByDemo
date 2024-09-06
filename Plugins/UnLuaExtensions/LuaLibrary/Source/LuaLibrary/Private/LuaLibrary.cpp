// Copyright Epic Games, Inc. All Rights Reserved.

#include "LuaLibrary.h"
#include "UnLuaDelegates.h"

#define LOCTEXT_NAMESPACE "FLuaLibraryModule"

void FLuaLibraryModule::StartupModule()
{
	UnLua::FLuaEnv::OnCreated.AddStatic(&FLuaLibraryModule::OnLuaStateCreated);
}

void FLuaLibraryModule::ShutdownModule()
{
	UnLua::FLuaEnv::OnCreated.RemoveAll(this);
}

void FLuaLibraryModule::OnLuaStateCreated(UnLua::FLuaEnv& Env)
{
	FString EmmyDir = FPaths::ConvertRelativePathToFull(FPaths::ProjectPluginsDir()) + TEXT("UnLuaExtensions/LuaLibrary/Source/ThirdParty/Emmy");
#if PLATFORM_WINDOWS
	FString String = FString::Printf(TEXT("package.cpath = package.cpath .. ';%s/windows/x64/?.dll'"), *EmmyDir);
	Env.DoString(String);
#endif
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FLuaLibraryModule, LuaLibrary)