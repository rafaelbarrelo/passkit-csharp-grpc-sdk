// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/protocols.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/protocols.proto</summary>
  public static partial class ProtocolsReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/protocols.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlpby9jb21tb24vcHJvdG9jb2xzLnByb3RvEgJpbyqoAgoMUGFzc1Byb3Rv",
            "Y29sEhwKGFBBU1NfUFJPVE9DT0xfRE9fTk9UX1VTRRAAEhAKDFJBV19QUk9U",
            "T0NPTBABEg8KC1YxX1BST1RPQ09MEAISEwoPRkxJR0hUX1BST1RPQ09MEAMS",
            "FAoQTE9ZQUxUWV9QUk9UT0NPTBAEEhkKFUVWRU5UX1RJQ0tFVF9QUk9UT0NP",
            "TBAFEhMKD0NPVVBPTl9QUk9UT0NPTBAGEhkKFVNUT1JFRF9WQUxVRV9QUk9U",
            "T0NPTBAHEhoKFlRSQU5TSVRfVkFMVUVfUFJPVE9DT0wQCBIOCgpNRU1CRVJT",
            "SElQEGQSFQoRU0lOR0xFX1VTRV9DT1VQT04QZRIOCglQUk9QXzAwMDEQ6AcS",
            "DgoJUFJPUF8wMDAyEOkHKo4CChRQcm90b2NvbENvbW1vbkV2ZW50cxIlCiFQ",
            "Uk9UT0NPTF9DT01NT05fRVZFTlRTX0RPX05PVF9VU0UQABIYChRFVkVOVF9P",
            "QkpFQ1RfQ1JFQVRFRBABEhgKFEVWRU5UX09CSkVDVF9VUERBVEVEEAISGAoU",
            "RVZFTlRfT0JKRUNUX0VYUElSRUQQAxIYChRFVkVOVF9PQkpFQ1RfREVMRVRF",
            "RBAEEhUKEUVWRU5UX1BBU1NfSVNTVUVEEAUSGAoURVZFTlRfUEFTU19JTlNU",
            "QUxMRUQQBhIaChZFVkVOVF9QQVNTX1VOSU5TVEFMTEVEEAcSGgoWRVZFTlRf",
            "UEFTU19JTlZBTElEQVRFRBAIQj4KD2lvLnBhc3NraXQuUEtpb1okc3Rhc2gu",
            "cGFzc2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvqgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PKIo.PassProtocol), typeof(global::PKIo.ProtocolCommonEvents), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PassProtocol {
    [pbr::OriginalName("PASS_PROTOCOL_DO_NOT_USE")] DoNotUse = 0,
    /// <summary>
    /// Reserved for v2 v3 legacy pass protocol.
    /// </summary>
    [pbr::OriginalName("RAW_PROTOCOL")] RawProtocol = 1,
    /// <summary>
    /// Reserved for migrating legacy v1 passes.
    /// </summary>
    [pbr::OriginalName("V1_PROTOCOL")] V1Protocol = 2,
    /// <summary>
    /// Flights - mapped to Google's boarding passes class.
    /// </summary>
    [pbr::OriginalName("FLIGHT_PROTOCOL")] FlightProtocol = 3,
    /// <summary>
    /// Loyalty - mapped to Google's loyalty class.
    /// </summary>
    [pbr::OriginalName("LOYALTY_PROTOCOL")] LoyaltyProtocol = 4,
    /// <summary>
    /// Event Tickets; - mapped to Google's event ticket class.
    /// </summary>
    [pbr::OriginalName("EVENT_TICKET_PROTOCOL")] EventTicketProtocol = 5,
    /// <summary>
    /// Coupons - mapped to Google's offer class.
    /// </summary>
    [pbr::OriginalName("COUPON_PROTOCOL")] CouponProtocol = 6,
    /// <summary>
    /// Stored Value - mapped to Google's gift class.
    /// </summary>
    [pbr::OriginalName("STORED_VALUE_PROTOCOL")] StoredValueProtocol = 7,
    /// <summary>
    /// Stored Value - mapped to Google's transit class.
    /// </summary>
    [pbr::OriginalName("TRANSIT_VALUE_PROTOCOL")] TransitValueProtocol = 8,
    /// <summary>
    /// Values 100 onwards are for PassKit generic protocols.
    /// Generic Membership protocol
    /// </summary>
    [pbr::OriginalName("MEMBERSHIP")] Membership = 100,
    /// <summary>
    /// Single Use Coupon protocol
    /// </summary>
    [pbr::OriginalName("SINGLE_USE_COUPON")] SingleUseCoupon = 101,
    /// <summary>
    /// Values 1000 onwards are for proprietary protocols
    /// Proprietary protocol.
    /// </summary>
    [pbr::OriginalName("PROP_0001")] Prop0001 = 1000,
    /// <summary>
    /// Proprietary protocol.
    /// </summary>
    [pbr::OriginalName("PROP_0002")] Prop0002 = 1001,
  }

  public enum ProtocolCommonEvents {
    [pbr::OriginalName("PROTOCOL_COMMON_EVENTS_DO_NOT_USE")] DoNotUse = 0,
    /// <summary>
    /// Values 0-100 onwards are for PassKit events
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_CREATED")] EventObjectCreated = 1,
    /// <summary>
    /// Set to when the object was updated
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_UPDATED")] EventObjectUpdated = 2,
    /// <summary>
    /// Set to when the object was expired
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_EXPIRED")] EventObjectExpired = 3,
    /// <summary>
    /// Set to when the object was deleted
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_DELETED")] EventObjectDeleted = 4,
    /// <summary>
    /// Pass has been issued.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_ISSUED")] EventPassIssued = 5,
    /// <summary>
    /// Pass has been installed in a wallet.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_INSTALLED")] EventPassInstalled = 6,
    /// <summary>
    /// Pass has been uninstalled (possibly deleted) from a wallet.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_UNINSTALLED")] EventPassUninstalled = 7,
    /// <summary>
    /// Pass has been invalidated.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_INVALIDATED")] EventPassInvalidated = 8,
  }

  #endregion

}

#endregion Designer generated code