// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "LuaLib_ListView.h"
#include "UnLuaEx.h"
#include "Components/ListView.h"

static int32 UListView_SetListItems(lua_State* L)
{
	const int32 NumParams = lua_gettop(L);
	if (NumParams < 2)
		return luaL_error(L, "invalid parameters");

	UListView* ListView = static_cast<UListView*>(GetCppInstanceFast(L, 1));
	if (!IsValid(ListView))
		return luaL_error(L, "listview is invalid");

	if (!lua_istable(L, 2))
		return luaL_error(L, "items is not table");

	TArray<UObject*> ListViewItems;

	lua_pushnil(L);
	while (lua_next(L, 2))
	{
		UListViewItem* ListViewItem = NewObject<UListViewItem>(ListView);
		ListViewItems.Add(ListViewItem);
		UnLua::PushUObject(L, ListViewItem);
		if (lua_istable(L, -2))
			lua_insert(L, -2);
		else
			lua_newtable(L);
		lua_setfield(L, -2, "__item");
		lua_settop(L, 3);
	}
	ListView->SetListItems(ListViewItems);
	
	return 0;
}

static int32 ULIstView_GetItemObject(lua_State* L)
{
	const int32 NumParams = lua_gettop(L);
	if (NumParams < 2)
		return luaL_error(L, "invalid parameters");
	
	UListView* ListView = static_cast<UListView*>(GetCppInstanceFast(L, 1));
	if (!IsValid(ListView))
		return luaL_error(L, "listview is invalid");

	if (!lua_istable(L, 2))
		return luaL_error(L, "items is not table");

	TArray<UObject*> ListViewItems = ListView->GetListItems();
	for (UObject* ListViewItem : ListViewItems)
	{
		UnLua::PushUObject(L, ListViewItem);
		lua_getfield(L, -1, "__item");
		if (lua_compare(L, -1, 2, LUA_OPEQ))
			return 1;
		lua_settop(L, 2);
	}

	return 0;
}

static constexpr luaL_Reg UListViewLib[] =
{
	{"SetListItems", UListView_SetListItems},
	{"GetItemObject", ULIstView_GetItemObject},
	{nullptr, nullptr},
};

BEGIN_EXPORT_REFLECTED_CLASS(UListView)
	ADD_LIB(UListViewLib)
END_EXPORT_CLASS()

IMPLEMENT_EXPORTED_CLASS(UListView)