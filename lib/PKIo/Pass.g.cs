// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/pass.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/pass.proto</summary>
  public static partial class PassReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/pass.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PassReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRpby9jb21tb24vcGFzcy5wcm90bxICaW8aFGlvL2ltYWdlL2ltYWdlLnBy",
            "b3RvGhVpby9jb21tb24vbGlua3MucHJvdG8aF2lvL2NvbW1vbi9tZXRyaWNz",
            "LnByb3RvGhhpby9jb21tb24vcGVyc29uYWwucHJvdG8aGWlvL2NvbW1vbi9w",
            "cm90b2NvbHMucHJvdG8aGWlvL2NvbW1vbi9wcm94aW1pdHkucHJvdG8aGGlv",
            "L2NvbW1vbi90ZW1wbGF0ZS5wcm90bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29w",
            "dGlvbnMvYW5ub3RhdGlvbnMucHJvdG8iwwEKDVBhc3NPdmVycmlkZXMSHgoI",
            "aW1hZ2VJZHMYASABKAsyDC5pby5JbWFnZUlkcxIqCglsb2NhdGlvbnMYAyAD",
            "KAsyDy5pby5HUFNMb2NhdGlvbkIGkkEDoAEKEiMKB2JlYWNvbnMYBCADKAsy",
            "Ci5pby5CZWFjb25CBpJBA6ABChIfCgVsaW5rcxgFIAMoCzIILmlvLkxpbmtC",
            "BpJBA6ABChIaCgZjb2xvcnMYBiABKAsyCi5pby5Db2xvcnNKBAgCEAMiXAoL",
            "UGFzc09wdGlvbnMSJgoFYXBwbGUYASABKAsyFy5pby5BcHBsZVdhbGxldFNl",
            "dHRpbmdzEiUKBmdvb2dsZRgCIAEoCzIVLmlvLkdvb2dsZVBheVNldHRpbmdz",
            "Iv8BCgRQYXNzEgoKAmlkGAEgASgJEg8KB2NsYXNzSWQYAiABKAkSIgoIcHJv",
            "dG9jb2wYAyABKA4yEC5pby5QYXNzUHJvdG9jb2wSIQoNcGVyc29uRGV0YWls",
            "cxgEIAEoCzIKLmlvLlBlcnNvbhIeCghtZXRhZGF0YRgFIAEoCzIMLmlvLk1l",
            "dGFkYXRhEiwKCnJlY29yZERhdGEYBiADKAsyGC5pby5QYXNzLlJlY29yZERh",
            "dGFFbnRyeRISCgpleHRlcm5hbElkGAcgASgJGjEKD1JlY29yZERhdGFFbnRy",
            "eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBQj4KD2lvLnBhc3Nr",
            "aXQuUEtpb1okc3Rhc2gucGFzc2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lv",
            "qgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PKIo.ImageReflection.Descriptor, global::PKIo.LinksReflection.Descriptor, global::PKIo.MetricsReflection.Descriptor, global::PKIo.PersonalReflection.Descriptor, global::PKIo.ProtocolsReflection.Descriptor, global::PKIo.ProximityReflection.Descriptor, global::PKIo.TemplateReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.PassOverrides), global::PKIo.PassOverrides.Parser, new[]{ "ImageIds", "Locations", "Beacons", "Links", "Colors" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.PassOptions), global::PKIo.PassOptions.Parser, new[]{ "Apple", "Google" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Pass), global::PKIo.Pass.Parser, new[]{ "Id", "ClassId", "Protocol", "PersonDetails", "Metadata", "RecordData", "ExternalId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// PassObject contains pass-object level details that are common across protocols.
  /// </summary>
  public sealed partial class PassOverrides : pb::IMessage<PassOverrides> {
    private static readonly pb::MessageParser<PassOverrides> _parser = new pb::MessageParser<PassOverrides>(() => new PassOverrides());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PassOverrides> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.PassReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOverrides() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOverrides(PassOverrides other) : this() {
      imageIds_ = other.imageIds_ != null ? other.imageIds_.Clone() : null;
      locations_ = other.locations_.Clone();
      beacons_ = other.beacons_.Clone();
      links_ = other.links_.Clone();
      colors_ = other.colors_ != null ? other.colors_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOverrides Clone() {
      return new PassOverrides(this);
    }

    /// <summary>Field number for the "imageIds" field.</summary>
    public const int ImageIdsFieldNumber = 1;
    private global::PKIo.ImageIds imageIds_;
    /// <summary>
    /// Image ID's of images to override for this pass
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.ImageIds ImageIds {
      get { return imageIds_; }
      set {
        imageIds_ = value;
      }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::PKIo.GPSLocation> _repeated_locations_codec
        = pb::FieldCodec.ForMessage(26, global::PKIo.GPSLocation.Parser);
    private readonly pbc::RepeatedField<global::PKIo.GPSLocation> locations_ = new pbc::RepeatedField<global::PKIo.GPSLocation>();
    /// <summary>
    /// A list of up to 10 GPS locations where this pass should be presented on the lock-screen. Overrides any template level values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.GPSLocation> Locations {
      get { return locations_; }
    }

    /// <summary>Field number for the "beacons" field.</summary>
    public const int BeaconsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::PKIo.Beacon> _repeated_beacons_codec
        = pb::FieldCodec.ForMessage(34, global::PKIo.Beacon.Parser);
    private readonly pbc::RepeatedField<global::PKIo.Beacon> beacons_ = new pbc::RepeatedField<global::PKIo.Beacon>();
    /// <summary>
    /// A list of up to 10 Beacon UUIDs that should trigger the pass to be presented on the lock-screen. Overrides any template level values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.Beacon> Beacons {
      get { return beacons_; }
    }

    /// <summary>Field number for the "links" field.</summary>
    public const int LinksFieldNumber = 5;
    private static readonly pb::FieldCodec<global::PKIo.Link> _repeated_links_codec
        = pb::FieldCodec.ForMessage(42, global::PKIo.Link.Parser);
    private readonly pbc::RepeatedField<global::PKIo.Link> links_ = new pbc::RepeatedField<global::PKIo.Link>();
    /// <summary>
    /// A list of (personalized) links to be shown on the pass. Overrides any template level values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.Link> Links {
      get { return links_; }
    }

    /// <summary>Field number for the "colors" field.</summary>
    public const int ColorsFieldNumber = 6;
    private global::PKIo.Colors colors_;
    /// <summary>
    /// stores custom pass colors
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.Colors Colors {
      get { return colors_; }
      set {
        colors_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PassOverrides);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PassOverrides other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ImageIds, other.ImageIds)) return false;
      if(!locations_.Equals(other.locations_)) return false;
      if(!beacons_.Equals(other.beacons_)) return false;
      if(!links_.Equals(other.links_)) return false;
      if (!object.Equals(Colors, other.Colors)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (imageIds_ != null) hash ^= ImageIds.GetHashCode();
      hash ^= locations_.GetHashCode();
      hash ^= beacons_.GetHashCode();
      hash ^= links_.GetHashCode();
      if (colors_ != null) hash ^= Colors.GetHashCode();
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
      if (imageIds_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ImageIds);
      }
      locations_.WriteTo(output, _repeated_locations_codec);
      beacons_.WriteTo(output, _repeated_beacons_codec);
      links_.WriteTo(output, _repeated_links_codec);
      if (colors_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Colors);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (imageIds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ImageIds);
      }
      size += locations_.CalculateSize(_repeated_locations_codec);
      size += beacons_.CalculateSize(_repeated_beacons_codec);
      size += links_.CalculateSize(_repeated_links_codec);
      if (colors_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Colors);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PassOverrides other) {
      if (other == null) {
        return;
      }
      if (other.imageIds_ != null) {
        if (imageIds_ == null) {
          ImageIds = new global::PKIo.ImageIds();
        }
        ImageIds.MergeFrom(other.ImageIds);
      }
      locations_.Add(other.locations_);
      beacons_.Add(other.beacons_);
      links_.Add(other.links_);
      if (other.colors_ != null) {
        if (colors_ == null) {
          Colors = new global::PKIo.Colors();
        }
        Colors.MergeFrom(other.Colors);
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
          case 10: {
            if (imageIds_ == null) {
              ImageIds = new global::PKIo.ImageIds();
            }
            input.ReadMessage(ImageIds);
            break;
          }
          case 26: {
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
          case 34: {
            beacons_.AddEntriesFrom(input, _repeated_beacons_codec);
            break;
          }
          case 42: {
            links_.AddEntriesFrom(input, _repeated_links_codec);
            break;
          }
          case 50: {
            if (colors_ == null) {
              Colors = new global::PKIo.Colors();
            }
            input.ReadMessage(Colors);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PassOptions : pb::IMessage<PassOptions> {
    private static readonly pb::MessageParser<PassOptions> _parser = new pb::MessageParser<PassOptions>(() => new PassOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PassOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.PassReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOptions(PassOptions other) : this() {
      apple_ = other.apple_ != null ? other.apple_.Clone() : null;
      google_ = other.google_ != null ? other.google_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PassOptions Clone() {
      return new PassOptions(this);
    }

    /// <summary>Field number for the "apple" field.</summary>
    public const int AppleFieldNumber = 1;
    private global::PKIo.AppleWalletSettings apple_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.AppleWalletSettings Apple {
      get { return apple_; }
      set {
        apple_ = value;
      }
    }

    /// <summary>Field number for the "google" field.</summary>
    public const int GoogleFieldNumber = 2;
    private global::PKIo.GooglePaySettings google_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.GooglePaySettings Google {
      get { return google_; }
      set {
        google_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PassOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PassOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Apple, other.Apple)) return false;
      if (!object.Equals(Google, other.Google)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (apple_ != null) hash ^= Apple.GetHashCode();
      if (google_ != null) hash ^= Google.GetHashCode();
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
      if (apple_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Apple);
      }
      if (google_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Google);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (apple_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Apple);
      }
      if (google_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Google);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PassOptions other) {
      if (other == null) {
        return;
      }
      if (other.apple_ != null) {
        if (apple_ == null) {
          Apple = new global::PKIo.AppleWalletSettings();
        }
        Apple.MergeFrom(other.Apple);
      }
      if (other.google_ != null) {
        if (google_ == null) {
          Google = new global::PKIo.GooglePaySettings();
        }
        Google.MergeFrom(other.Google);
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
          case 10: {
            if (apple_ == null) {
              Apple = new global::PKIo.AppleWalletSettings();
            }
            input.ReadMessage(Apple);
            break;
          }
          case 18: {
            if (google_ == null) {
              Google = new global::PKIo.GooglePaySettings();
            }
            input.ReadMessage(Google);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Details of pass and pass holder.
  /// </summary>
  public sealed partial class Pass : pb::IMessage<Pass> {
    private static readonly pb::MessageParser<Pass> _parser = new pb::MessageParser<Pass>(() => new Pass());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pass> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.PassReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pass() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pass(Pass other) : this() {
      id_ = other.id_;
      classId_ = other.classId_;
      protocol_ = other.protocol_;
      personDetails_ = other.personDetails_ != null ? other.personDetails_.Clone() : null;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      recordData_ = other.recordData_.Clone();
      externalId_ = other.externalId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pass Clone() {
      return new Pass(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// The uuid of the pass.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "classId" field.</summary>
    public const int ClassIdFieldNumber = 2;
    private string classId_ = "";
    /// <summary>
    /// The class id of the pass which it belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClassId {
      get { return classId_; }
      set {
        classId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "protocol" field.</summary>
    public const int ProtocolFieldNumber = 3;
    private global::PKIo.PassProtocol protocol_ = global::PKIo.PassProtocol.DoNotUse;
    /// <summary>
    /// Protocol module which this pass was issued by.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.PassProtocol Protocol {
      get { return protocol_; }
      set {
        protocol_ = value;
      }
    }

    /// <summary>Field number for the "personDetails" field.</summary>
    public const int PersonDetailsFieldNumber = 4;
    private global::PKIo.Person personDetails_;
    /// <summary>
    /// PII data of pass holder.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.Person PersonDetails {
      get { return personDetails_; }
      set {
        personDetails_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 5;
    private global::PKIo.Metadata metadata_;
    /// <summary>
    /// Pass meta data such as install ip, user agent and other lifecycle data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.Metadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "recordData" field.</summary>
    public const int RecordDataFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_recordData_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> recordData_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Holds protocol specific data (e.g. tier points for Membership protocol, flight number for flight protocol)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> RecordData {
      get { return recordData_; }
    }

    /// <summary>Field number for the "externalId" field.</summary>
    public const int ExternalIdFieldNumber = 7;
    private string externalId_ = "";
    /// <summary>
    /// Will hold the external id of the object (as set by protocol)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExternalId {
      get { return externalId_; }
      set {
        externalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pass);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pass other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ClassId != other.ClassId) return false;
      if (Protocol != other.Protocol) return false;
      if (!object.Equals(PersonDetails, other.PersonDetails)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (!RecordData.Equals(other.RecordData)) return false;
      if (ExternalId != other.ExternalId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ClassId.Length != 0) hash ^= ClassId.GetHashCode();
      if (Protocol != global::PKIo.PassProtocol.DoNotUse) hash ^= Protocol.GetHashCode();
      if (personDetails_ != null) hash ^= PersonDetails.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= RecordData.GetHashCode();
      if (ExternalId.Length != 0) hash ^= ExternalId.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (ClassId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClassId);
      }
      if (Protocol != global::PKIo.PassProtocol.DoNotUse) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Protocol);
      }
      if (personDetails_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PersonDetails);
      }
      if (metadata_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Metadata);
      }
      recordData_.WriteTo(output, _map_recordData_codec);
      if (ExternalId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ExternalId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (ClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassId);
      }
      if (Protocol != global::PKIo.PassProtocol.DoNotUse) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Protocol);
      }
      if (personDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PersonDetails);
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += recordData_.CalculateSize(_map_recordData_codec);
      if (ExternalId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExternalId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pass other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ClassId.Length != 0) {
        ClassId = other.ClassId;
      }
      if (other.Protocol != global::PKIo.PassProtocol.DoNotUse) {
        Protocol = other.Protocol;
      }
      if (other.personDetails_ != null) {
        if (personDetails_ == null) {
          PersonDetails = new global::PKIo.Person();
        }
        PersonDetails.MergeFrom(other.PersonDetails);
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::PKIo.Metadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      recordData_.Add(other.recordData_);
      if (other.ExternalId.Length != 0) {
        ExternalId = other.ExternalId;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            ClassId = input.ReadString();
            break;
          }
          case 24: {
            Protocol = (global::PKIo.PassProtocol) input.ReadEnum();
            break;
          }
          case 34: {
            if (personDetails_ == null) {
              PersonDetails = new global::PKIo.Person();
            }
            input.ReadMessage(PersonDetails);
            break;
          }
          case 42: {
            if (metadata_ == null) {
              Metadata = new global::PKIo.Metadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 50: {
            recordData_.AddEntriesFrom(input, _map_recordData_codec);
            break;
          }
          case 58: {
            ExternalId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
