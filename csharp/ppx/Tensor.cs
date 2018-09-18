// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Tensor : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Tensor GetRootAsTensor(ByteBuffer _bb) { return GetRootAsTensor(_bb, new Tensor()); }
  public static Tensor GetRootAsTensor(ByteBuffer _bb, Tensor obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Tensor __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public double Data(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int DataLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(4); }
  public int Shape(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ShapeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetShapeBytes() { return __p.__vector_as_arraysegment(6); }

  public static Offset<Tensor> CreateTensor(FlatBufferBuilder builder,
      VectorOffset dataOffset = default(VectorOffset),
      VectorOffset shapeOffset = default(VectorOffset)) {
    builder.StartObject(2);
    Tensor.AddShape(builder, shapeOffset);
    Tensor.AddData(builder, dataOffset);
    return Tensor.EndTensor(builder);
  }

  public static void StartTensor(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(0, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddShape(FlatBufferBuilder builder, VectorOffset shapeOffset) { builder.AddOffset(1, shapeOffset.Value, 0); }
  public static VectorOffset CreateShapeVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShapeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Tensor> EndTensor(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Tensor>(o);
  }
};


}