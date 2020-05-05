// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct Exponential : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static Exponential GetRootAsExponential(ByteBuffer _bb) { return GetRootAsExponential(_bb, new Exponential()); }
  public static Exponential GetRootAsExponential(ByteBuffer _bb, Exponential obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Exponential __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ppx.Tensor? Rate { get { int o = __p.__offset(4); return o != 0 ? (ppx.Tensor?)(new ppx.Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<ppx.Exponential> CreateExponential(FlatBufferBuilder builder,
      Offset<ppx.Tensor> rateOffset = default(Offset<ppx.Tensor>)) {
    builder.StartTable(1);
    Exponential.AddRate(builder, rateOffset);
    return Exponential.EndExponential(builder);
  }

  public static void StartExponential(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddRate(FlatBufferBuilder builder, Offset<ppx.Tensor> rateOffset) { builder.AddOffset(0, rateOffset.Value, 0); }
  public static Offset<ppx.Exponential> EndExponential(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ppx.Exponential>(o);
  }
};


}