-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: ppx

local flatbuffers = require('flatbuffers')

local Bernoulli = {} -- the module
local Bernoulli_mt = {} -- the class metatable

function Bernoulli.New()
    local o = {}
    setmetatable(o, {__index = Bernoulli_mt})
    return o
end
function Bernoulli.GetRootAsBernoulli(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = Bernoulli.New()
    o:Init(buf, n + offset)
    return o
end
function Bernoulli_mt:Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end
function Bernoulli_mt:Probs()
    local o = self.view:Offset(4)
    if o ~= 0 then
        local x = self.view:Indirect(o + self.view.pos)
        local obj = require('ppx.Tensor').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end
function Bernoulli.Start(builder) builder:StartObject(1) end
function Bernoulli.AddProbs(builder, probs) builder:PrependUOffsetTRelativeSlot(0, probs, 0) end
function Bernoulli.End(builder) return builder:EndObject() end

return Bernoulli -- return the module