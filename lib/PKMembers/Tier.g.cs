// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/member/tier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKMembers {

  /// <summary>Holder for reflection information generated from io/member/tier.proto</summary>
  public static partial class TierReflection {

    #region Descriptor
    /// <summary>File descriptor for io/member/tier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRpby9tZW1iZXIvdGllci5wcm90bxIHbWVtYmVycxofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29wdGlv",
            "bnMvYW5ub3RhdGlvbnMucHJvdG8aHGlvL2NvbW1vbi9sb2NhbGl6YXRpb24u",
            "cHJvdG8aHmlvL2NvbW1vbi9jb21tb25fb2JqZWN0cy5wcm90bxoWaW8vY29t",
            "bW9uL2V4cGlyeS5wcm90byLoBQoEVGllchIKCgJpZBgBIAEoCRIRCgl0aWVy",
            "SW5kZXgYAiABKA0SDAoEbmFtZRgDIAEoCRIqCg1sb2NhbGl6ZWROYW1lGAQg",
            "ASgLMhMuaW8uTG9jYWxpemVkU3RyaW5nEhkKEXNlY29uZGFyeVRpZXJOYW1l",
            "GAUgASgJEjcKGmxvY2FsaXplZFNlY29uZGFyeVRpZXJOYW1lGAYgASgLMhMu",
            "aW8uTG9jYWxpemVkU3RyaW5nEhEKCXByb2dyYW1JZBgHIAEoCRIWCg5wYXNz",
            "VGVtcGxhdGVJZBgIIAEoCRIaChJ0aWVyVXBncmFkZU1lc3NhZ2UYCSABKAkS",
            "OAobbG9jYWxpemVkVGllclVwZ3JhZGVNZXNzYWdlGAogASgLMhMuaW8uTG9j",
            "YWxpemVkU3RyaW5nEhwKFHRpZXJEb3duZ3JhZGVNZXNzYWdlGAsgASgJEjoK",
            "HWxvY2FsaXplZFRpZXJEb3duZ3JhZGVNZXNzYWdlGAwgASgLMhMuaW8uTG9j",
            "YWxpemVkU3RyaW5nEisKB2NyZWF0ZWQYDSABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wEisKB3VwZGF0ZWQYDiABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wEhcKD3BvaW50c092ZXJkcmF3bhgPIAEoCBIgChhzZWNv",
            "bmRhcnlQb2ludHNPdmVyZHJhd24YECABKAgSKgoOZXhwaXJ5U2V0dGluZ3MY",
            "ESABKAsyEi5pby5FeHBpcnlTZXR0aW5ncxIQCgh0aW1lem9uZRgSIAEoCTqE",
            "AZJBgAEKfioEVGllcjJBVGllciBhbGxvd3MgYSBjb21wYW55IHRvIG92ZXJy",
            "aWRlIGNlcnRhaW4gZGV0YWlscyBpbiB0aGUgcHJvZ3JhbS7SAQJpZNIBCXRp",
            "ZXJJbmRleNIBCXByb2dyYW1JZNIBBG5hbWXSAQ5wYXNzVGVtcGxhdGVJZCI1",
            "ChBUaWVyUmVxdWVzdElucHV0EhEKCXByb2dyYW1JZBgBIAEoCRIOCgZ0aWVy",
            "SWQYAiABKAlCUwoXaW8ucGFzc2tpdC5QS2lvLk1lbWJlcnNaLHN0YXNoLnBh",
            "c3NraXQuY29tL2lvL21vZGVsL3Nkay9nby9pby9tZW1iZXJzqgIJUEtNZW1i",
            "ZXJzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, global::PKIo.LocalizationReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.ExpiryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKMembers.Tier), global::PKMembers.Tier.Parser, new[]{ "Id", "TierIndex", "Name", "LocalizedName", "SecondaryTierName", "LocalizedSecondaryTierName", "ProgramId", "PassTemplateId", "TierUpgradeMessage", "LocalizedTierUpgradeMessage", "TierDowngradeMessage", "LocalizedTierDowngradeMessage", "Created", "Updated", "PointsOverdrawn", "SecondaryPointsOverdrawn", "ExpirySettings", "Timezone" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKMembers.TierRequestInput), global::PKMembers.TierRequestInput.Parser, new[]{ "ProgramId", "TierId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The Tier object; will override certain details of the pass (colours, logo's, dynamic back fields, and labels).
  /// </summary>
  public sealed partial class Tier : pb::IMessage<Tier> {
    private static readonly pb::MessageParser<Tier> _parser = new pb::MessageParser<Tier>(() => new Tier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Tier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKMembers.TierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tier(Tier other) : this() {
      id_ = other.id_;
      tierIndex_ = other.tierIndex_;
      name_ = other.name_;
      localizedName_ = other.localizedName_ != null ? other.localizedName_.Clone() : null;
      secondaryTierName_ = other.secondaryTierName_;
      localizedSecondaryTierName_ = other.localizedSecondaryTierName_ != null ? other.localizedSecondaryTierName_.Clone() : null;
      programId_ = other.programId_;
      passTemplateId_ = other.passTemplateId_;
      tierUpgradeMessage_ = other.tierUpgradeMessage_;
      localizedTierUpgradeMessage_ = other.localizedTierUpgradeMessage_ != null ? other.localizedTierUpgradeMessage_.Clone() : null;
      tierDowngradeMessage_ = other.tierDowngradeMessage_;
      localizedTierDowngradeMessage_ = other.localizedTierDowngradeMessage_ != null ? other.localizedTierDowngradeMessage_.Clone() : null;
      created_ = other.created_ != null ? other.created_.Clone() : null;
      updated_ = other.updated_ != null ? other.updated_.Clone() : null;
      pointsOverdrawn_ = other.pointsOverdrawn_;
      secondaryPointsOverdrawn_ = other.secondaryPointsOverdrawn_;
      expirySettings_ = other.expirySettings_ != null ? other.expirySettings_.Clone() : null;
      timezone_ = other.timezone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Tier Clone() {
      return new Tier(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Tier identifier (could just be: blue, gold, etc); needs to be lower case. Tier ID needs to be uique within the program.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tierIndex" field.</summary>
    public const int TierIndexFieldNumber = 2;
    private uint tierIndex_;
    /// <summary>
    /// Index of the tier; can be used for managing downgrades / upgrade messaging; needs to be unique within the program.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint TierIndex {
      get { return tierIndex_; }
      set {
        tierIndex_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Name of tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedName" field.</summary>
    public const int LocalizedNameFieldNumber = 4;
    private global::PKIo.LocalizedString localizedName_;
    /// <summary>
    /// Localized name of tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedName {
      get { return localizedName_; }
      set {
        localizedName_ = value;
      }
    }

    /// <summary>Field number for the "secondaryTierName" field.</summary>
    public const int SecondaryTierNameFieldNumber = 5;
    private string secondaryTierName_ = "";
    /// <summary>
    /// Name of the secondary reward tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SecondaryTierName {
      get { return secondaryTierName_; }
      set {
        secondaryTierName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedSecondaryTierName" field.</summary>
    public const int LocalizedSecondaryTierNameFieldNumber = 6;
    private global::PKIo.LocalizedString localizedSecondaryTierName_;
    /// <summary>
    /// Localized name of the secondary reward tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedSecondaryTierName {
      get { return localizedSecondaryTierName_; }
      set {
        localizedSecondaryTierName_ = value;
      }
    }

    /// <summary>Field number for the "programId" field.</summary>
    public const int ProgramIdFieldNumber = 7;
    private string programId_ = "";
    /// <summary>
    /// The program id that the tier belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProgramId {
      get { return programId_; }
      set {
        programId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "passTemplateId" field.</summary>
    public const int PassTemplateIdFieldNumber = 8;
    private string passTemplateId_ = "";
    /// <summary>
    /// Identifier of pass template which identifies design and data elements for this tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PassTemplateId {
      get { return passTemplateId_; }
      set {
        passTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tierUpgradeMessage" field.</summary>
    public const int TierUpgradeMessageFieldNumber = 9;
    private string tierUpgradeMessage_ = "";
    /// <summary>
    /// Notification to be shown when someone upgrades tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TierUpgradeMessage {
      get { return tierUpgradeMessage_; }
      set {
        tierUpgradeMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedTierUpgradeMessage" field.</summary>
    public const int LocalizedTierUpgradeMessageFieldNumber = 10;
    private global::PKIo.LocalizedString localizedTierUpgradeMessage_;
    /// <summary>
    /// Localized notification to be shown when someone upgrades tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedTierUpgradeMessage {
      get { return localizedTierUpgradeMessage_; }
      set {
        localizedTierUpgradeMessage_ = value;
      }
    }

    /// <summary>Field number for the "tierDowngradeMessage" field.</summary>
    public const int TierDowngradeMessageFieldNumber = 11;
    private string tierDowngradeMessage_ = "";
    /// <summary>
    /// Notification to be shown when someone downgrades tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TierDowngradeMessage {
      get { return tierDowngradeMessage_; }
      set {
        tierDowngradeMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedTierDowngradeMessage" field.</summary>
    public const int LocalizedTierDowngradeMessageFieldNumber = 12;
    private global::PKIo.LocalizedString localizedTierDowngradeMessage_;
    /// <summary>
    /// Localized notification to be shown when someone upgrades tier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedTierDowngradeMessage {
      get { return localizedTierDowngradeMessage_; }
      set {
        localizedTierDowngradeMessage_ = value;
      }
    }

    /// <summary>Field number for the "created" field.</summary>
    public const int CreatedFieldNumber = 13;
    private global::Google.Protobuf.WellKnownTypes.Timestamp created_;
    /// <summary>
    /// The date the tier was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Created {
      get { return created_; }
      set {
        created_ = value;
      }
    }

    /// <summary>Field number for the "updated" field.</summary>
    public const int UpdatedFieldNumber = 14;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updated_;
    /// <summary>
    /// The date the tier was updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Updated {
      get { return updated_; }
      set {
        updated_ = value;
      }
    }

    /// <summary>Field number for the "pointsOverdrawn" field.</summary>
    public const int PointsOverdrawnFieldNumber = 15;
    private bool pointsOverdrawn_;
    /// <summary>
    /// Set true to accept a negative point balance. Default is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PointsOverdrawn {
      get { return pointsOverdrawn_; }
      set {
        pointsOverdrawn_ = value;
      }
    }

    /// <summary>Field number for the "secondaryPointsOverdrawn" field.</summary>
    public const int SecondaryPointsOverdrawnFieldNumber = 16;
    private bool secondaryPointsOverdrawn_;
    /// <summary>
    /// Set true to accept a negative secondary point balance. Default is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SecondaryPointsOverdrawn {
      get { return secondaryPointsOverdrawn_; }
      set {
        secondaryPointsOverdrawn_ = value;
      }
    }

    /// <summary>Field number for the "expirySettings" field.</summary>
    public const int ExpirySettingsFieldNumber = 17;
    private global::PKIo.ExpirySettings expirySettings_;
    /// <summary>
    /// Expiry date setting. You can set expiry logic here. Default no expiry logic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.ExpirySettings ExpirySettings {
      get { return expirySettings_; }
      set {
        expirySettings_ = value;
      }
    }

    /// <summary>Field number for the "timezone" field.</summary>
    public const int TimezoneFieldNumber = 18;
    private string timezone_ = "";
    /// <summary>
    /// Timezone string in IANA timezone format. If not provided defaults to Etc/UTC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Timezone {
      get { return timezone_; }
      set {
        timezone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Tier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Tier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (TierIndex != other.TierIndex) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(LocalizedName, other.LocalizedName)) return false;
      if (SecondaryTierName != other.SecondaryTierName) return false;
      if (!object.Equals(LocalizedSecondaryTierName, other.LocalizedSecondaryTierName)) return false;
      if (ProgramId != other.ProgramId) return false;
      if (PassTemplateId != other.PassTemplateId) return false;
      if (TierUpgradeMessage != other.TierUpgradeMessage) return false;
      if (!object.Equals(LocalizedTierUpgradeMessage, other.LocalizedTierUpgradeMessage)) return false;
      if (TierDowngradeMessage != other.TierDowngradeMessage) return false;
      if (!object.Equals(LocalizedTierDowngradeMessage, other.LocalizedTierDowngradeMessage)) return false;
      if (!object.Equals(Created, other.Created)) return false;
      if (!object.Equals(Updated, other.Updated)) return false;
      if (PointsOverdrawn != other.PointsOverdrawn) return false;
      if (SecondaryPointsOverdrawn != other.SecondaryPointsOverdrawn) return false;
      if (!object.Equals(ExpirySettings, other.ExpirySettings)) return false;
      if (Timezone != other.Timezone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (TierIndex != 0) hash ^= TierIndex.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (localizedName_ != null) hash ^= LocalizedName.GetHashCode();
      if (SecondaryTierName.Length != 0) hash ^= SecondaryTierName.GetHashCode();
      if (localizedSecondaryTierName_ != null) hash ^= LocalizedSecondaryTierName.GetHashCode();
      if (ProgramId.Length != 0) hash ^= ProgramId.GetHashCode();
      if (PassTemplateId.Length != 0) hash ^= PassTemplateId.GetHashCode();
      if (TierUpgradeMessage.Length != 0) hash ^= TierUpgradeMessage.GetHashCode();
      if (localizedTierUpgradeMessage_ != null) hash ^= LocalizedTierUpgradeMessage.GetHashCode();
      if (TierDowngradeMessage.Length != 0) hash ^= TierDowngradeMessage.GetHashCode();
      if (localizedTierDowngradeMessage_ != null) hash ^= LocalizedTierDowngradeMessage.GetHashCode();
      if (created_ != null) hash ^= Created.GetHashCode();
      if (updated_ != null) hash ^= Updated.GetHashCode();
      if (PointsOverdrawn != false) hash ^= PointsOverdrawn.GetHashCode();
      if (SecondaryPointsOverdrawn != false) hash ^= SecondaryPointsOverdrawn.GetHashCode();
      if (expirySettings_ != null) hash ^= ExpirySettings.GetHashCode();
      if (Timezone.Length != 0) hash ^= Timezone.GetHashCode();
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
      if (TierIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TierIndex);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (localizedName_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LocalizedName);
      }
      if (SecondaryTierName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SecondaryTierName);
      }
      if (localizedSecondaryTierName_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LocalizedSecondaryTierName);
      }
      if (ProgramId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ProgramId);
      }
      if (PassTemplateId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(PassTemplateId);
      }
      if (TierUpgradeMessage.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(TierUpgradeMessage);
      }
      if (localizedTierUpgradeMessage_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LocalizedTierUpgradeMessage);
      }
      if (TierDowngradeMessage.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(TierDowngradeMessage);
      }
      if (localizedTierDowngradeMessage_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LocalizedTierDowngradeMessage);
      }
      if (created_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Created);
      }
      if (updated_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Updated);
      }
      if (PointsOverdrawn != false) {
        output.WriteRawTag(120);
        output.WriteBool(PointsOverdrawn);
      }
      if (SecondaryPointsOverdrawn != false) {
        output.WriteRawTag(128, 1);
        output.WriteBool(SecondaryPointsOverdrawn);
      }
      if (expirySettings_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(ExpirySettings);
      }
      if (Timezone.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteString(Timezone);
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
      if (TierIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TierIndex);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (localizedName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedName);
      }
      if (SecondaryTierName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SecondaryTierName);
      }
      if (localizedSecondaryTierName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedSecondaryTierName);
      }
      if (ProgramId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProgramId);
      }
      if (PassTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PassTemplateId);
      }
      if (TierUpgradeMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TierUpgradeMessage);
      }
      if (localizedTierUpgradeMessage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedTierUpgradeMessage);
      }
      if (TierDowngradeMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TierDowngradeMessage);
      }
      if (localizedTierDowngradeMessage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedTierDowngradeMessage);
      }
      if (created_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Created);
      }
      if (updated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Updated);
      }
      if (PointsOverdrawn != false) {
        size += 1 + 1;
      }
      if (SecondaryPointsOverdrawn != false) {
        size += 2 + 1;
      }
      if (expirySettings_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ExpirySettings);
      }
      if (Timezone.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Timezone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Tier other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.TierIndex != 0) {
        TierIndex = other.TierIndex;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.localizedName_ != null) {
        if (localizedName_ == null) {
          LocalizedName = new global::PKIo.LocalizedString();
        }
        LocalizedName.MergeFrom(other.LocalizedName);
      }
      if (other.SecondaryTierName.Length != 0) {
        SecondaryTierName = other.SecondaryTierName;
      }
      if (other.localizedSecondaryTierName_ != null) {
        if (localizedSecondaryTierName_ == null) {
          LocalizedSecondaryTierName = new global::PKIo.LocalizedString();
        }
        LocalizedSecondaryTierName.MergeFrom(other.LocalizedSecondaryTierName);
      }
      if (other.ProgramId.Length != 0) {
        ProgramId = other.ProgramId;
      }
      if (other.PassTemplateId.Length != 0) {
        PassTemplateId = other.PassTemplateId;
      }
      if (other.TierUpgradeMessage.Length != 0) {
        TierUpgradeMessage = other.TierUpgradeMessage;
      }
      if (other.localizedTierUpgradeMessage_ != null) {
        if (localizedTierUpgradeMessage_ == null) {
          LocalizedTierUpgradeMessage = new global::PKIo.LocalizedString();
        }
        LocalizedTierUpgradeMessage.MergeFrom(other.LocalizedTierUpgradeMessage);
      }
      if (other.TierDowngradeMessage.Length != 0) {
        TierDowngradeMessage = other.TierDowngradeMessage;
      }
      if (other.localizedTierDowngradeMessage_ != null) {
        if (localizedTierDowngradeMessage_ == null) {
          LocalizedTierDowngradeMessage = new global::PKIo.LocalizedString();
        }
        LocalizedTierDowngradeMessage.MergeFrom(other.LocalizedTierDowngradeMessage);
      }
      if (other.created_ != null) {
        if (created_ == null) {
          Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Created.MergeFrom(other.Created);
      }
      if (other.updated_ != null) {
        if (updated_ == null) {
          Updated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Updated.MergeFrom(other.Updated);
      }
      if (other.PointsOverdrawn != false) {
        PointsOverdrawn = other.PointsOverdrawn;
      }
      if (other.SecondaryPointsOverdrawn != false) {
        SecondaryPointsOverdrawn = other.SecondaryPointsOverdrawn;
      }
      if (other.expirySettings_ != null) {
        if (expirySettings_ == null) {
          ExpirySettings = new global::PKIo.ExpirySettings();
        }
        ExpirySettings.MergeFrom(other.ExpirySettings);
      }
      if (other.Timezone.Length != 0) {
        Timezone = other.Timezone;
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
          case 16: {
            TierIndex = input.ReadUInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            if (localizedName_ == null) {
              LocalizedName = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedName);
            break;
          }
          case 42: {
            SecondaryTierName = input.ReadString();
            break;
          }
          case 50: {
            if (localizedSecondaryTierName_ == null) {
              LocalizedSecondaryTierName = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedSecondaryTierName);
            break;
          }
          case 58: {
            ProgramId = input.ReadString();
            break;
          }
          case 66: {
            PassTemplateId = input.ReadString();
            break;
          }
          case 74: {
            TierUpgradeMessage = input.ReadString();
            break;
          }
          case 82: {
            if (localizedTierUpgradeMessage_ == null) {
              LocalizedTierUpgradeMessage = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedTierUpgradeMessage);
            break;
          }
          case 90: {
            TierDowngradeMessage = input.ReadString();
            break;
          }
          case 98: {
            if (localizedTierDowngradeMessage_ == null) {
              LocalizedTierDowngradeMessage = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedTierDowngradeMessage);
            break;
          }
          case 106: {
            if (created_ == null) {
              Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Created);
            break;
          }
          case 114: {
            if (updated_ == null) {
              Updated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Updated);
            break;
          }
          case 120: {
            PointsOverdrawn = input.ReadBool();
            break;
          }
          case 128: {
            SecondaryPointsOverdrawn = input.ReadBool();
            break;
          }
          case 138: {
            if (expirySettings_ == null) {
              ExpirySettings = new global::PKIo.ExpirySettings();
            }
            input.ReadMessage(ExpirySettings);
            break;
          }
          case 146: {
            Timezone = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Used to request member tier record by tier id.
  /// </summary>
  public sealed partial class TierRequestInput : pb::IMessage<TierRequestInput> {
    private static readonly pb::MessageParser<TierRequestInput> _parser = new pb::MessageParser<TierRequestInput>(() => new TierRequestInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TierRequestInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKMembers.TierReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TierRequestInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TierRequestInput(TierRequestInput other) : this() {
      programId_ = other.programId_;
      tierId_ = other.tierId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TierRequestInput Clone() {
      return new TierRequestInput(this);
    }

    /// <summary>Field number for the "programId" field.</summary>
    public const int ProgramIdFieldNumber = 1;
    private string programId_ = "";
    /// <summary>
    /// Program ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProgramId {
      get { return programId_; }
      set {
        programId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tierId" field.</summary>
    public const int TierIdFieldNumber = 2;
    private string tierId_ = "";
    /// <summary>
    /// Tier ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TierId {
      get { return tierId_; }
      set {
        tierId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TierRequestInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TierRequestInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProgramId != other.ProgramId) return false;
      if (TierId != other.TierId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProgramId.Length != 0) hash ^= ProgramId.GetHashCode();
      if (TierId.Length != 0) hash ^= TierId.GetHashCode();
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
      if (ProgramId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProgramId);
      }
      if (TierId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TierId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProgramId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProgramId);
      }
      if (TierId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TierId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TierRequestInput other) {
      if (other == null) {
        return;
      }
      if (other.ProgramId.Length != 0) {
        ProgramId = other.ProgramId;
      }
      if (other.TierId.Length != 0) {
        TierId = other.TierId;
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
            ProgramId = input.ReadString();
            break;
          }
          case 18: {
            TierId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code