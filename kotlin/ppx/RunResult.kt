// automatically generated by the FlatBuffers compiler, do not modify

package ppx

import java.nio.*
import kotlin.math.sign
import com.google.flatbuffers.*

@Suppress("unused")
@ExperimentalUnsignedTypes
class RunResult : Table() {

    fun __init(_i: Int, _bb: ByteBuffer)  {
        __reset(_i, _bb)
    }
    fun __assign(_i: Int, _bb: ByteBuffer) : RunResult {
        __init(_i, _bb)
        return this
    }
    val result : ppx.Tensor? get() = result(ppx.Tensor())
    fun result(obj: ppx.Tensor) : ppx.Tensor? {
        val o = __offset(4)
        return if (o != 0) {
            obj.__assign(__indirect(o + bb_pos), bb)
        } else {
            null
        }
    }
    companion object {
        fun validateVersion() = Constants.FLATBUFFERS_1_12_0()
        fun getRootAsRunResult(_bb: ByteBuffer): RunResult = getRootAsRunResult(_bb, RunResult())
        fun getRootAsRunResult(_bb: ByteBuffer, obj: RunResult): RunResult {
            _bb.order(ByteOrder.LITTLE_ENDIAN)
            return (obj.__assign(_bb.getInt(_bb.position()) + _bb.position(), _bb))
        }
        fun createRunResult(builder: FlatBufferBuilder, resultOffset: Int) : Int {
            builder.startTable(1)
            addResult(builder, resultOffset)
            return endRunResult(builder)
        }
        fun startRunResult(builder: FlatBufferBuilder) = builder.startTable(1)
        fun addResult(builder: FlatBufferBuilder, result: Int) = builder.addOffset(0, result, 0)
        fun endRunResult(builder: FlatBufferBuilder) : Int {
            val o = builder.endTable()
            return o
        }
    }
}