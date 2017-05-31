//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: client_email.proto
namespace PROTO_EMAIL
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TItemInfo")]
  public partial class TItemInfo : global::ProtoBuf.IExtensible
  {
    public TItemInfo() {}
    
    private uint _position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint position
    {
      get { return _position; }
      set { _position = value; }
    }
    private uint _id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TEmail")]
  public partial class TEmail : global::ProtoBuf.IExtensible
  {
    public TEmail() {}
    
    private PROTO_EMAIL.EEmailType _mailType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mailType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public PROTO_EMAIL.EEmailType mailType
    {
      get { return _mailType; }
      set { _mailType = value; }
    }
    private PROTO_EMAIL.EOPType _opType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"opType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public PROTO_EMAIL.EOPType opType
    {
      get { return _opType; }
      set { _opType = value; }
    }
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private string _from_roleid;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"from_roleid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string from_roleid
    {
      get { return _from_roleid; }
      set { _from_roleid = value; }
    }
    private string _from_rolename;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"from_rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string from_rolename
    {
      get { return _from_rolename; }
      set { _from_rolename = value; }
    }
    private bool _isread;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"isread", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isread
    {
      get { return _isread; }
      set { _isread = value; }
    }
    private string _title;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private string _content;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private readonly global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo> _items = new global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo>();
    [global::ProtoBuf.ProtoMember(9, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo> items
    {
      get { return _items; }
    }
  
    private string _SendTime;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"SendTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SendTime
    {
      get { return _SendTime; }
      set { _SendTime = value; }
    }
    private uint _RetentionDay;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"RetentionDay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint RetentionDay
    {
      get { return _RetentionDay; }
      set { _RetentionDay = value; }
    }
    private uint _Template;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Template", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Template
    {
      get { return _Template; }
      set { _Template = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _TemplateParam = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(13, Name=@"TemplateParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> TemplateParam
    {
      get { return _TemplateParam; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_ERROR")]
  public partial class TSM_ERROR : global::ProtoBuf.IExtensible
  {
    public TSM_ERROR() {}
    
    private PROTO_EMAIL.EEmailError _error;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public PROTO_EMAIL.EEmailError error
    {
      get { return _error; }
      set { _error = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_LIST")]
  public partial class TSM_LIST : global::ProtoBuf.IExtensible
  {
    public TSM_LIST() {}
    
    private readonly global::System.Collections.Generic.List<PROTO_EMAIL.TEmail> _Emails = new global::System.Collections.Generic.List<PROTO_EMAIL.TEmail>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Emails", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PROTO_EMAIL.TEmail> Emails
    {
      get { return _Emails; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_APPEND")]
  public partial class TSM_APPEND : global::ProtoBuf.IExtensible
  {
    public TSM_APPEND() {}
    
    private PROTO_EMAIL.TEmail _Email;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PROTO_EMAIL.TEmail Email
    {
      get { return _Email; }
      set { _Email = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_REMOVE")]
  public partial class TSM_REMOVE : global::ProtoBuf.IExtensible
  {
    public TSM_REMOVE() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_REMOVEITEM")]
  public partial class TSM_REMOVEITEM : global::ProtoBuf.IExtensible
  {
    public TSM_REMOVEITEM() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _Positions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Positions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> Positions
    {
      get { return _Positions; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_NEXTPAGE")]
  public partial class TCM_NEXTPAGE : global::ProtoBuf.IExtensible
  {
    public TCM_NEXTPAGE() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_REMOVE")]
  public partial class TCM_REMOVE : global::ProtoBuf.IExtensible
  {
    public TCM_REMOVE() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_GETITEM")]
  public partial class TCM_GETITEM : global::ProtoBuf.IExtensible
  {
    public TCM_GETITEM() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private uint _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_MARKREAD")]
  public partial class TCM_MARKREAD : global::ProtoBuf.IExtensible
  {
    public TCM_MARKREAD() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_ONEKYGETITEM")]
  public partial class TCM_ONEKYGETITEM : global::ProtoBuf.IExtensible
  {
    public TCM_ONEKYGETITEM() {}
    
    private PROTO_EMAIL.EEmailType _mailType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mailType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public PROTO_EMAIL.EEmailType mailType
    {
      get { return _mailType; }
      set { _mailType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TCM_GETITEM_1")]
  public partial class TCM_GETITEM_1 : global::ProtoBuf.IExtensible
  {
    public TCM_GETITEM_1() {}
    
    private uint _EmailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint EmailId
    {
      get { return _EmailId; }
      set { _EmailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_TOTALCOUNT")]
  public partial class TSM_TOTALCOUNT : global::ProtoBuf.IExtensible
  {
    public TSM_TOTALCOUNT() {}
    
    private uint _noreadcount;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"noreadcount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint noreadcount
    {
      get { return _noreadcount; }
      set { _noreadcount = value; }
    }
    private uint _totalcount;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"totalcount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint totalcount
    {
      get { return _totalcount; }
      set { _totalcount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TSM_GOTITEMS")]
  public partial class TSM_GOTITEMS : global::ProtoBuf.IExtensible
  {
    public TSM_GOTITEMS() {}
    
    private readonly global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo> _items = new global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PROTO_EMAIL.TItemInfo> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CLT_CMD")]
    public enum CLT_CMD
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_NEXTPAGE", Value=1)]
      CM_NEXTPAGE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_REMOVE", Value=2)]
      CM_REMOVE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_GETITEM", Value=3)]
      CM_GETITEM = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_ONEKEYDEL", Value=4)]
      CM_ONEKEYDEL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_MARKREAD", Value=5)]
      CM_MARKREAD = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_ONEKYGETITEM", Value=6)]
      CM_ONEKYGETITEM = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CM_GETITEM_1", Value=7)]
      CM_GETITEM_1 = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SVR_CMD")]
    public enum SVR_CMD
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_ERROR", Value=1)]
      SM_ERROR = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_CLEAR", Value=2)]
      SM_CLEAR = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_LIST", Value=3)]
      SM_LIST = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_APPEND", Value=4)]
      SM_APPEND = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_REMOVE", Value=5)]
      SM_REMOVE = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_REMOVEITEM", Value=6)]
      SM_REMOVEITEM = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_TOTALCOUNT", Value=7)]
      SM_TOTALCOUNT = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SM_GOTITEMS", Value=8)]
      SM_GOTITEMS = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EEmailType")]
    public enum EEmailType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EmailType_SYS", Value=1)]
      EmailType_SYS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EmailType_Normal", Value=2)]
      EmailType_Normal = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EOPType")]
    public enum EOPType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOPType_ReadDel", Value=1)]
      EOPType_ReadDel = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EOPType_ReadNoDel", Value=2)]
      EOPType_ReadNoDel = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ETemplate")]
    public enum ETemplate
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_NULL", Value=1)]
      ETemplate_NULL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_MercenaryItem", Value=2)]
      ETemplate_MercenaryItem = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_BattleItem", Value=3)]
      ETemplate_BattleItem = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_BattleFirstPassItem", Value=4)]
      ETemplate_BattleFirstPassItem = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_BattleFastPassItem", Value=5)]
      ETemplate_BattleFastPassItem = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ChapterItem", Value=6)]
      ETemplate_ChapterItem = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_MercenaryExpiration", Value=7)]
      ETemplate_MercenaryExpiration = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_SkinExpiration", Value=8)]
      ETemplate_SkinExpiration = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_SignInReward", Value=9)]
      ETemplate_SignInReward = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ExtractReward", Value=10)]
      ETemplate_ExtractReward = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_WeaponExpired", Value=11)]
      ETemplate_WeaponExpired = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_WeaponLevelUpReturnExpCard", Value=12)]
      ETemplate_WeaponLevelUpReturnExpCard = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_DiamondSignInReward", Value=13)]
      ETemplate_DiamondSignInReward = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_VIPSignInReward", Value=14)]
      ETemplate_VIPSignInReward = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_Task", Value=15)]
      ETemplate_Task = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_SkinAddHead", Value=16)]
      ETemplate_SkinAddHead = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ActivityBattle", Value=17)]
      ETemplate_ActivityBattle = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_MercenaryAddHead", Value=18)]
      ETemplate_MercenaryAddHead = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_RankingChallenge", Value=19)]
      ETemplate_RankingChallenge = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_SignInTotalReward", Value=20)]
      ETemplate_SignInTotalReward = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_KingOfPositionWorship", Value=21)]
      ETemplate_KingOfPositionWorship = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_KingOfPositionLuck", Value=22)]
      ETemplate_KingOfPositionLuck = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_KingOfPositionSuperior", Value=23)]
      ETemplate_KingOfPositionSuperior = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_OpenServerRanking_1", Value=24)]
      ETemplate_OpenServerRanking_1 = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_OpenServerRanking_2", Value=25)]
      ETemplate_OpenServerRanking_2 = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_OpenServerRanking_3", Value=26)]
      ETemplate_OpenServerRanking_3 = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_OpenServerRanking_4", Value=27)]
      ETemplate_OpenServerRanking_4 = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_OpenServerRanking_5", Value=28)]
      ETemplate_OpenServerRanking_5 = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_WorldBossRanking", Value=29)]
      ETemplate_WorldBossRanking = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_WorldBossKill", Value=30)]
      ETemplate_WorldBossKill = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_FirstRecharge", Value=31)]
      ETemplate_FirstRecharge = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_RankingMPVP", Value=32)]
      ETemplate_RankingMPVP = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyAssigning", Value=33)]
      ETemplate_ArmyAssigning = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyBossRankReward", Value=34)]
      ETemplate_ArmyBossRankReward = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyBossRandomLoot", Value=35)]
      ETemplate_ArmyBossRandomLoot = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyBossParticipation", Value=36)]
      ETemplate_ArmyBossParticipation = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyJoin", Value=37)]
      ETemplate_ArmyJoin = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyCreate", Value=38)]
      ETemplate_ArmyCreate = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyOfflineLong", Value=39)]
      ETemplate_ArmyOfflineLong = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_WeekCard_Reward", Value=40)]
      ETemplate_WeekCard_Reward = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_MonthCard_Reward", Value=41)]
      ETemplate_MonthCard_Reward = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ETemplate_ArmyKick", Value=42)]
      ETemplate_ArmyKick = 42
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EEmailError")]
    public enum EEmailError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EEmailError_ItemPackFull", Value=1)]
      EEmailError_ItemPackFull = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EEmailError_GoldFull", Value=2)]
      EEmailError_GoldFull = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EEmailError_WeaponFull", Value=3)]
      EEmailError_WeaponFull = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EEmailError_MercenaryFull", Value=4)]
      EEmailError_MercenaryFull = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EEmailError_SkinFull", Value=5)]
      EEmailError_SkinFull = 5
    }
  
}