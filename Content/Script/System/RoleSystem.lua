---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by byteyang.
--- DateTime: 2023/11/21 14:49
---

---@class RoleSystem : System
local RoleSystem = System()

function RoleSystem:Initialize()
    self._Managers = {}
end

function RoleSystem:RegisterManager(Name, Manager)
    self._Managers[Name] = Manager
end

function RoleSystem:GetManager(Name)
    return self._Managers[Name]
end

return RoleSystem