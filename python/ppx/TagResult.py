# automatically generated by the FlatBuffers compiler, do not modify

# namespace: ppx

import flatbuffers
from flatbuffers.compat import import_numpy
np = import_numpy()

class TagResult(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsTagResult(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = TagResult()
        x.Init(buf, n + offset)
        return x

    @classmethod
    def TagResultBufferHasIdentifier(cls, buf, offset, size_prefixed=False):
        return flatbuffers.util.BufferHasIdentifier(buf, offset, b"\x50\x50\x58\x46", size_prefixed=size_prefixed)

    # TagResult
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

def TagResultStart(builder): builder.StartObject(0)
def TagResultEnd(builder): return builder.EndObject()
