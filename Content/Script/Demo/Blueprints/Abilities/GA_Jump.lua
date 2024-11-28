--
-- DESCRIPTION
--
-- @COMPANY **
-- @AUTHOR **
-- @DATE ${date} ${time}
--

---@type GA_Jump_C
local GA_Jump = UnLua.Class()

function GA_Jump:K2_ActivateAbility()
    print("GA_Jump:K2_ActivateAbility")

    self:K2_CommitAbilityCooldown(false, false)

    local ActorInfo = self:GetActorInfo()
    ---@type ACharacter
    local OwnerActor = ActorInfo.OwnerActor

    if OwnerActor:CanJump() then
        OwnerActor:Jump()
    end
end

function GA_Jump:K2_OnEndAbility(bWasCancelled)
    print("GA_Jump:K2_OnEndAbility", bWasCancelled)

    local ActorInfo = self:GetActorInfo()
    ---@type ACharacter
    local OwnerActor = ActorInfo.OwnerActor

    OwnerActor:StopJumping()
end

return GA_Jump