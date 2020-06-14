// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/billing.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/billing.proto</summary>
  public static partial class BillingReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/billing.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BillingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdpby9jb21tb24vYmlsbGluZy5wcm90bxICaW8icgoFUXVvdGESJwoHZGV0",
            "YWlscxgBIAMoCzIWLmlvLlF1b3RhLkRldGFpbHNFbnRyeRpACgxEZXRhaWxz",
            "RW50cnkSCwoDa2V5GAEgASgNEh8KBXZhbHVlGAIgASgLMhAuaW8uUXVvdGFE",
            "ZXRhaWxzOgI4ASItCgxRdW90YURldGFpbHMSDQoFcXVvdGEYASABKAUSDgoG",
            "c3RhdHVzGAIgASgEQj4KD2lvLnBhc3NraXQuUEtpb1okc3Rhc2gucGFzc2tp",
            "dC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvqgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Quota), global::PKIo.Quota.Parser, new[]{ "Details" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.QuotaDetails), global::PKIo.QuotaDetails.Parser, new[]{ "Quota", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Quota : pb::IMessage<Quota> {
    private static readonly pb::MessageParser<Quota> _parser = new pb::MessageParser<Quota>(() => new Quota());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Quota> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.BillingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quota() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quota(Quota other) : this() {
      details_ = other.details_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quota Clone() {
      return new Quota(this);
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::PKIo.QuotaDetails>.Codec _map_details_codec
        = new pbc::MapField<uint, global::PKIo.QuotaDetails>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::PKIo.QuotaDetails.Parser), 10);
    private readonly pbc::MapField<uint, global::PKIo.QuotaDetails> details_ = new pbc::MapField<uint, global::PKIo.QuotaDetails>();
    /// <summary>
    /// key is one of pk.MeteredEventType
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<uint, global::PKIo.QuotaDetails> Details {
      get { return details_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Quota);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Quota other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Details.Equals(other.Details)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Details.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      details_.WriteTo(output, _map_details_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += details_.CalculateSize(_map_details_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Quota other) {
      if (other == null) {
        return;
      }
      details_.Add(other.details_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            details_.AddEntriesFrom(input, _map_details_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class QuotaDetails : pb::IMessage<QuotaDetails> {
    private static readonly pb::MessageParser<QuotaDetails> _parser = new pb::MessageParser<QuotaDetails>(() => new QuotaDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuotaDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.BillingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuotaDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuotaDetails(QuotaDetails other) : this() {
      quota_ = other.quota_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuotaDetails Clone() {
      return new QuotaDetails(this);
    }

    /// <summary>Field number for the "quota" field.</summary>
    public const int QuotaFieldNumber = 1;
    private int quota_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quota {
      get { return quota_; }
      set {
        quota_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private ulong status_;
    /// <summary>
    /// contains bitmas of pk.Status
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuotaDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuotaDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Quota != other.Quota) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Quota != 0) hash ^= Quota.GetHashCode();
      if (Status != 0UL) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Quota != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Quota);
      }
      if (Status != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Quota != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quota);
      }
      if (Status != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuotaDetails other) {
      if (other == null) {
        return;
      }
      if (other.Quota != 0) {
        Quota = other.Quota;
      }
      if (other.Status != 0UL) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Quota = input.ReadInt32();
            break;
          }
          case 16: {
            Status = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
