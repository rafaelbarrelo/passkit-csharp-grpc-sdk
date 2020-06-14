// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/pagination.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/pagination.proto</summary>
  public static partial class PaginationReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/pagination.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaginationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chppby9jb21tb24vcGFnaW5hdGlvbi5wcm90bxICaW8aLHByb3RvYy1nZW4t",
            "c3dhZ2dlci9vcHRpb25zL2Fubm90YXRpb25zLnByb3RvIuABCgpQYWdpbmF0",
            "aW9uEg0KBWxpbWl0GAEgASgFEg4KBm9mZnNldBgCIAEoBRITCgtmaWx0ZXJG",
            "aWVsZBgDIAMoCRITCgtmaWx0ZXJWYWx1ZRgEIAMoCRIWCg5maWx0ZXJPcGVy",
            "YXRvchgFIAMoCRIPCgdvcmRlckJ5GAYgASgJEhAKCG9yZGVyQXNjGAcgASgI",
            "Ok6SQUsKSSoKUGFnaW5hdGlvbjI7UGFnaW5hdGlvbiBvYmplY3QgdXNlZCB0",
            "byBzcGxpdCBjb250ZW50IGludG8gc21hbGxlciBwYXJ0cy4iSgoGRmlsdGVy",
            "EhMKC2ZpbHRlckZpZWxkGAEgAygJEhMKC2ZpbHRlclZhbHVlGAIgAygJEhYK",
            "DmZpbHRlck9wZXJhdG9yGAMgAygJQj4KD2lvLnBhc3NraXQuUEtpb1okc3Rh",
            "c2gucGFzc2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvqgIEUEtJb2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Pagination), global::PKIo.Pagination.Parser, new[]{ "Limit", "Offset", "FilterField", "FilterValue", "FilterOperator", "OrderBy", "OrderAsc" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Filter), global::PKIo.Filter.Parser, new[]{ "FilterField", "FilterValue", "FilterOperator" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Pagination : pb::IMessage<Pagination> {
    private static readonly pb::MessageParser<Pagination> _parser = new pb::MessageParser<Pagination>(() => new Pagination());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pagination> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.PaginationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pagination() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pagination(Pagination other) : this() {
      limit_ = other.limit_;
      offset_ = other.offset_;
      filterField_ = other.filterField_.Clone();
      filterValue_ = other.filterValue_.Clone();
      filterOperator_ = other.filterOperator_.Clone();
      orderBy_ = other.orderBy_;
      orderAsc_ = other.orderAsc_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pagination Clone() {
      return new Pagination(this);
    }

    /// <summary>Field number for the "limit" field.</summary>
    public const int LimitFieldNumber = 1;
    private int limit_;
    /// <summary>
    /// Limit the number of records returned. If not specified, a default of 25 is used.  Enter -1 for all records.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Limit {
      get { return limit_; }
      set {
        limit_ = value;
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 2;
    private int offset_;
    /// <summary>
    /// Allows you to offset the first record returned by the limit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    /// <summary>Field number for the "filterField" field.</summary>
    public const int FilterFieldFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_filterField_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> filterField_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Array of column names to filter results by.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterField {
      get { return filterField_; }
    }

    /// <summary>Field number for the "filterValue" field.</summary>
    public const int FilterValueFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_filterValue_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> filterValue_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Array of values to test against the filter fields.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterValue {
      get { return filterValue_; }
    }

    /// <summary>Field number for the "filterOperator" field.</summary>
    public const int FilterOperatorFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_filterOperator_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> filterOperator_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// will be whitelisted operators in io core
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterOperator {
      get { return filterOperator_; }
    }

    /// <summary>Field number for the "orderBy" field.</summary>
    public const int OrderByFieldNumber = 6;
    private string orderBy_ = "";
    /// <summary>
    /// Field to order results by.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OrderBy {
      get { return orderBy_; }
      set {
        orderBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "orderAsc" field.</summary>
    public const int OrderAscFieldNumber = 7;
    private bool orderAsc_;
    /// <summary>
    /// Will return in ascending order if true, or descending order if false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool OrderAsc {
      get { return orderAsc_; }
      set {
        orderAsc_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pagination);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pagination other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Limit != other.Limit) return false;
      if (Offset != other.Offset) return false;
      if(!filterField_.Equals(other.filterField_)) return false;
      if(!filterValue_.Equals(other.filterValue_)) return false;
      if(!filterOperator_.Equals(other.filterOperator_)) return false;
      if (OrderBy != other.OrderBy) return false;
      if (OrderAsc != other.OrderAsc) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Limit != 0) hash ^= Limit.GetHashCode();
      if (Offset != 0) hash ^= Offset.GetHashCode();
      hash ^= filterField_.GetHashCode();
      hash ^= filterValue_.GetHashCode();
      hash ^= filterOperator_.GetHashCode();
      if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
      if (OrderAsc != false) hash ^= OrderAsc.GetHashCode();
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
      if (Limit != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Limit);
      }
      if (Offset != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Offset);
      }
      filterField_.WriteTo(output, _repeated_filterField_codec);
      filterValue_.WriteTo(output, _repeated_filterValue_codec);
      filterOperator_.WriteTo(output, _repeated_filterOperator_codec);
      if (OrderBy.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OrderBy);
      }
      if (OrderAsc != false) {
        output.WriteRawTag(56);
        output.WriteBool(OrderAsc);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Limit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Limit);
      }
      if (Offset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Offset);
      }
      size += filterField_.CalculateSize(_repeated_filterField_codec);
      size += filterValue_.CalculateSize(_repeated_filterValue_codec);
      size += filterOperator_.CalculateSize(_repeated_filterOperator_codec);
      if (OrderBy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderBy);
      }
      if (OrderAsc != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pagination other) {
      if (other == null) {
        return;
      }
      if (other.Limit != 0) {
        Limit = other.Limit;
      }
      if (other.Offset != 0) {
        Offset = other.Offset;
      }
      filterField_.Add(other.filterField_);
      filterValue_.Add(other.filterValue_);
      filterOperator_.Add(other.filterOperator_);
      if (other.OrderBy.Length != 0) {
        OrderBy = other.OrderBy;
      }
      if (other.OrderAsc != false) {
        OrderAsc = other.OrderAsc;
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
            Limit = input.ReadInt32();
            break;
          }
          case 16: {
            Offset = input.ReadInt32();
            break;
          }
          case 26: {
            filterField_.AddEntriesFrom(input, _repeated_filterField_codec);
            break;
          }
          case 34: {
            filterValue_.AddEntriesFrom(input, _repeated_filterValue_codec);
            break;
          }
          case 42: {
            filterOperator_.AddEntriesFrom(input, _repeated_filterOperator_codec);
            break;
          }
          case 50: {
            OrderBy = input.ReadString();
            break;
          }
          case 56: {
            OrderAsc = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Filter : pb::IMessage<Filter> {
    private static readonly pb::MessageParser<Filter> _parser = new pb::MessageParser<Filter>(() => new Filter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Filter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.PaginationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter(Filter other) : this() {
      filterField_ = other.filterField_.Clone();
      filterValue_ = other.filterValue_.Clone();
      filterOperator_ = other.filterOperator_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Filter Clone() {
      return new Filter(this);
    }

    /// <summary>Field number for the "filterField" field.</summary>
    public const int FilterFieldFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_filterField_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> filterField_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Array of column names to filter results by.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterField {
      get { return filterField_; }
    }

    /// <summary>Field number for the "filterValue" field.</summary>
    public const int FilterValueFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_filterValue_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> filterValue_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Array of values to test against the filter fields.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterValue {
      get { return filterValue_; }
    }

    /// <summary>Field number for the "filterOperator" field.</summary>
    public const int FilterOperatorFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_filterOperator_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> filterOperator_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// will be whitelisted operators in io core
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilterOperator {
      get { return filterOperator_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Filter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Filter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!filterField_.Equals(other.filterField_)) return false;
      if(!filterValue_.Equals(other.filterValue_)) return false;
      if(!filterOperator_.Equals(other.filterOperator_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= filterField_.GetHashCode();
      hash ^= filterValue_.GetHashCode();
      hash ^= filterOperator_.GetHashCode();
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
      filterField_.WriteTo(output, _repeated_filterField_codec);
      filterValue_.WriteTo(output, _repeated_filterValue_codec);
      filterOperator_.WriteTo(output, _repeated_filterOperator_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += filterField_.CalculateSize(_repeated_filterField_codec);
      size += filterValue_.CalculateSize(_repeated_filterValue_codec);
      size += filterOperator_.CalculateSize(_repeated_filterOperator_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Filter other) {
      if (other == null) {
        return;
      }
      filterField_.Add(other.filterField_);
      filterValue_.Add(other.filterValue_);
      filterOperator_.Add(other.filterOperator_);
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
            filterField_.AddEntriesFrom(input, _repeated_filterField_codec);
            break;
          }
          case 18: {
            filterValue_.AddEntriesFrom(input, _repeated_filterValue_codec);
            break;
          }
          case 26: {
            filterOperator_.AddEntriesFrom(input, _repeated_filterOperator_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code