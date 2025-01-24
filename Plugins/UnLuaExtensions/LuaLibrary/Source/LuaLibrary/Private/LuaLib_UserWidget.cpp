// Copyright Byteyang Games, Inc. All Rights Reserved.


#include "LuaLib_UserWidget.h"
#include "UnLuaEx.h"
#include "Blueprint/UserWidget.h"
#include "Slate/SObjectWidget.h"

static int32 UUSerWidget_BubbleEvent(lua_State* L)
{
	const int32 NumParams = lua_gettop(L);
	if (NumParams < 2)
		return luaL_error(L, "invalid parameters");

	const UUserWidget* UserWidget = static_cast<UUserWidget*>(GetCppInstance(L, 1));
	if (!IsValid(UserWidget))
		return luaL_error(L, "user widget is invalid");

	TSharedPtr<SWidget> ParentWidget = UserWidget->GetCachedWidget();
    if (!ParentWidget)
        return 0;

    const int32 MaxIterations = 100; // 防止可能的死循环
    int32 IterationCount = 0;
    
    while (ParentWidget->IsParentValid() && IterationCount++ < MaxIterations)
	{
		ParentWidget = ParentWidget->GetParentWidget();
        if (!ParentWidget)
            break;

		if (ParentWidget->GetType() == TEXT("SObjectWidget"))
		{
            const TSharedPtr<SObjectWidget> ObjectWidget = StaticCastSharedPtr<SObjectWidget>(ParentWidget);
            if (!ObjectWidget.IsValid())
                continue;
			UUserWidget* ParentUserWidget = ObjectWidget->GetWidgetObject();
			if (IsValid(ParentUserWidget))
			{
				UnLua::PushUObject(L, ParentUserWidget);
				lua_getfield(L, -1, "OnBubbleEvent");
				if (lua_isfunction(L, -1))
				{
					lua_pushvalue(L, -2);
					for (int32 i = 2; i<= NumParams; i++)
						lua_pushvalue(L, i);
					lua_call(L, NumParams, 1);
					if (lua_toboolean(L, -1))
						return 0;
				}
				lua_settop(L, NumParams);
			}
		}
	}
	
	return 0;
}

static constexpr luaL_Reg UUSerWidgetLib[] =
{
	{"BubbleEvent", UUSerWidget_BubbleEvent},
	{nullptr, nullptr},
};

BEGIN_EXPORT_REFLECTED_CLASS(UUserWidget)
	ADD_LIB(UUSerWidgetLib)
END_EXPORT_CLASS()

IMPLEMENT_EXPORTED_CLASS(UUserWidget)