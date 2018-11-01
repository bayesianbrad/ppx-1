// Code generated by the FlatBuffers compiler. DO NOT EDIT.

package ppx

import (
	flatbuffers "github.com/google/flatbuffers/go"
)

type HandshakeResult struct {
	_tab flatbuffers.Table
}

func GetRootAsHandshakeResult(buf []byte, offset flatbuffers.UOffsetT) *HandshakeResult {
	n := flatbuffers.GetUOffsetT(buf[offset:])
	x := &HandshakeResult{}
	x.Init(buf, n+offset)
	return x
}

func (rcv *HandshakeResult) Init(buf []byte, i flatbuffers.UOffsetT) {
	rcv._tab.Bytes = buf
	rcv._tab.Pos = i
}

func (rcv *HandshakeResult) Table() flatbuffers.Table {
	return rcv._tab
}

func (rcv *HandshakeResult) SystemName() []byte {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(4))
	if o != 0 {
		return rcv._tab.ByteVector(o + rcv._tab.Pos)
	}
	return nil
}

func (rcv *HandshakeResult) ModelName() []byte {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(6))
	if o != 0 {
		return rcv._tab.ByteVector(o + rcv._tab.Pos)
	}
	return nil
}

func HandshakeResultStart(builder *flatbuffers.Builder) {
	builder.StartObject(2)
}
func HandshakeResultAddSystemName(builder *flatbuffers.Builder, systemName flatbuffers.UOffsetT) {
	builder.PrependUOffsetTSlot(0, flatbuffers.UOffsetT(systemName), 0)
}
func HandshakeResultAddModelName(builder *flatbuffers.Builder, modelName flatbuffers.UOffsetT) {
	builder.PrependUOffsetTSlot(1, flatbuffers.UOffsetT(modelName), 0)
}
func HandshakeResultEnd(builder *flatbuffers.Builder) flatbuffers.UOffsetT {
	return builder.EndObject()
}
