//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UGE;
   
// Generated from: Inner/test.proto
namespace UGE.Metadata
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TestData")]
  public partial class TestData : global::ProtoBuf.IExtensible
  {
    public TestData() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _UserName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName
    {
      get { return _UserName; }
      set { _UserName = value; }
    }
    private string _UserName2;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"UserName2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName2
    {
      get { return _UserName2; }
      set { _UserName2 = value; }
    }
    private string _UserName3;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"UserName3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName3
    {
      get { return _UserName3; }
      set { _UserName3 = value; }
    }
    private string _UserName4;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"UserName4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName4
    {
      get { return _UserName4; }
      set { _UserName4 = value; }
    }
    private string _UserName5;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"UserName5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName5
    {
      get { return _UserName5; }
      set { _UserName5 = value; }
    }
    private float _value;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TestDataTable")]
  public partial class TestDataTable : global::ProtoBuf.IExtensible
  {
    public TestDataTable() {}
    
    private readonly global::System.Collections.Generic.List<TestData> _data = new global::System.Collections.Generic.List<TestData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TestData> data
    {
      get { return _data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}