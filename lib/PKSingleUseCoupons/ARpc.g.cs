// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/single_use_coupons/a_rpc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKSingleUseCoupons {

  /// <summary>Holder for reflection information generated from io/single_use_coupons/a_rpc.proto</summary>
  public static partial class ARpcReflection {

    #region Descriptor
    /// <summary>File descriptor for io/single_use_coupons/a_rpc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFpby9zaW5nbGVfdXNlX2NvdXBvbnMvYV9ycGMucHJvdG8SEnNpbmdsZV91",
            "c2VfY291cG9ucxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvGh5pby9jb21tb24vY29tbW9uX29i",
            "amVjdHMucHJvdG8aGmlvL2NvbW1vbi9wYWdpbmF0aW9uLnByb3RvGhZpby9j",
            "b21tb24vZmlsdGVyLnByb3RvGhlpby9jb21tb24vcmVwb3J0aW5nLnByb3Rv",
            "GiRpby9zaW5nbGVfdXNlX2NvdXBvbnMvY2FtcGFpZ24ucHJvdG8aIWlvL3Np",
            "bmdsZV91c2VfY291cG9ucy9vZmZlci5wcm90bxoiaW8vc2luZ2xlX3VzZV9j",
            "b3Vwb25zL2NvdXBvbi5wcm90bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29wdGlv",
            "bnMvYW5ub3RhdGlvbnMucHJvdG8yuzAKEFNpbmdsZVVzZUNvdXBvbnMSwAEK",
            "FGNyZWF0ZUNvdXBvbkNhbXBhaWduEiIuc2luZ2xlX3VzZV9jb3Vwb25zLkNv",
            "dXBvbkNhbXBhaWduGgYuaW8uSWQifILT5JMCHyIaL2NvdXBvbi9zaW5nbGVV",
            "c2UvY2FtcGFpZ246ASqSQVQKEENvdXBvbiBDYW1wYWlnbnMSFkNyZWF0ZSBD",
            "b3Vwb24gQ2FtcGFpZ24aKENyZWF0ZXMgYSBuZXcgU2luZ2xlIFVzZSBDb3Vw",
            "b24gQ2FtcGFpZ24S1AEKFHVwZGF0ZUNvdXBvbkNhbXBhaWduEiIuc2luZ2xl",
            "X3VzZV9jb3Vwb25zLkNvdXBvbkNhbXBhaWduGiIuc2luZ2xlX3VzZV9jb3Vw",
            "b25zLkNvdXBvbkNhbXBhaWduInSC0+STAh8aGi9jb3Vwb24vc2luZ2xlVXNl",
            "L2NhbXBhaWduOgEqkkFMChBDb3Vwb24gQ2FtcGFpZ25zEhZVcGRhdGUgQ291",
            "cG9uIENhbXBhaWduGiBVcGRhdGVzIGFuIGV4aXN0aW5nIFBhc3MgUHJvamVj",
            "dBK0AQoRZ2V0Q291cG9uQ2FtcGFpZ24SBi5pby5JZBoiLnNpbmdsZV91c2Vf",
            "Y291cG9ucy5Db3Vwb25DYW1wYWlnbiJzgtPkkwIhEh8vY291cG9uL3Npbmds",
            "ZVVzZS9jYW1wYWlnbi97aWR9kkFJChBDb3Vwb24gQ2FtcGFpZ25zEhNHZXQg",
            "Q291cG9uIENhbXBhaWduGiBHZXRzIGFuIGV4aXN0aW5nIENvdXBvbiBDYW1w",
            "YWlnbhKeAwoUZGVsZXRlQ291cG9uQ2FtcGFpZ24SBi5pby5JZBoWLmdvb2ds",
            "ZS5wcm90b2J1Zi5FbXB0eSLlAoLT5JMCJCofL2NvdXBvbi9zaW5nbGVVc2Uv",
            "Y2FtcGFpZ24ve2lkfToBKpJBtwIKEENvdXBvbiBDYW1wYWlnbnMSFkRlbGV0",
            "ZSBDb3Vwb24gQ2FtcGFpZ24aigJEZWxldGVzIGFuIGV4aXN0aW5nIENvdXBv",
            "biBDYW1wYWlnbiBieSBpZC4gRGVsZXRpbmcgYSBDb3Vwb24gQ2FtcGFpZ24g",
            "cmVzdWx0cyBpbiB0aGUgcmVsYXRlZCBvZmZlciBiZWluZyBkZWxldGVkLCBh",
            "bmQgYWxsIGNvdXBvbnMgYmVpbmcgaW52YWxpZGF0ZWQgaW4gdGhlIGN1c3Rv",
            "bWVycyBNb2JpbGUgV2FsbGV0OyByZW5kZXJpbmcgdGhlbSB1bnVzYWJsZS4g",
            "VGhpcyBtZXRob2QgbmVlZHMgdG8gYmUgdXNlZCB3aXRoIGNhcmUsIHRoaXMg",
            "aXMgaXJyZXZlcnNpYmxlLhKUAgodbGlzdENvdXBvbkNhbXBhaWduc0RlcHJl",
            "Y2F0ZWQSDi5pby5QYWdpbmF0aW9uGiIuc2luZ2xlX3VzZV9jb3Vwb25zLkNv",
            "dXBvbkNhbXBhaWduIrwBgtPkkwIdEhsvY291cG9uL3NpbmdsZVVzZS9jYW1w",
            "YWlnbnOSQZUBChBDb3Vwb24gQ2FtcGFpZ25zEiJMaXN0IENvdXBvbiBDYW1w",
            "YWlnbnMgW0RFUFJFQ0FURURdGl1bREVQUkVDQVRFRDogT1Igb3BlcmF0b3Ig",
            "aXMgbm90IHN1cHBvcnRlZF0gTGlzdHMgYWxsIENvdXBvbiBDYW1wYWlnbnMg",
            "Zm9yIHRoZSBsb2dnZWQgaW4gdXNlci4wARLWAQoTbGlzdENvdXBvbkNhbXBh",
            "aWducxILLmlvLkZpbHRlcnMaIi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9u",
            "Q2FtcGFpZ24iiwGC0+STAiUiIC9jb3Vwb24vc2luZ2xlVXNlL2NhbXBhaWdu",
            "cy9saXN0OgEqkkFdChBDb3Vwb24gQ2FtcGFpZ25zEhVMaXN0IENvdXBvbiBD",
            "YW1wYWlnbnMaMkxpc3RzIGFsbCBDb3Vwb24gQ2FtcGFpZ25zIGZvciB0aGUg",
            "bG9nZ2VkIGluIHVzZXIuMAES8gEKDGdldEFuYWx5dGljcxIULmlvLkFuYWx5",
            "dGljc1JlcXVlc3QaMy5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uQ2FtcGFp",
            "Z25BbmFseXRpY3NSZXNwb25zZSKWAYLT5JMCMBIuL2NvdXBvbi9zaW5nbGVV",
            "c2UvY2FtcGFpZ24ve2NsYXNzSWR9L2FuYWx5dGljc5JBXQoQQ291cG9uIENh",
            "bXBhaWducxIdR2V0IENvdXBvbiBDYW1wYWlnbiBBbmFseXRpY3MaKlJldHJp",
            "ZXZlcyBwcm90b2NvbCBzcGVjaWZpYyBhbmFseXRpY3MgZGF0YRKjAQoRY3Jl",
            "YXRlQ291cG9uT2ZmZXISHy5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uT2Zm",
            "ZXIaBi5pby5JZCJlgtPkkwIcIhcvY291cG9uL3NpbmdsZVVzZS9vZmZlcjoB",
            "KpJBQAoNQ291cG9uIE9mZmVycxITQ3JlYXRlIENvdXBvbiBPZmZlchoaQ3Jl",
            "YXRlcyBhIG5ldyBDb3Vwb24gT2ZmZXISwgEKEXVwZGF0ZUNvdXBvbk9mZmVy",
            "Eh8uc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBvbk9mZmVyGh8uc2luZ2xlX3Vz",
            "ZV9jb3Vwb25zLkNvdXBvbk9mZmVyImuC0+STAhwaFy9jb3Vwb24vc2luZ2xl",
            "VXNlL29mZmVyOgEqkkFGCg1Db3Vwb24gT2ZmZXJzEhNVcGRhdGUgQ291cG9u",
            "IE9mZmVyGiBVcGRhdGVzIGFuIGV4aXN0aW5nIENvdXBvbiBPZmZlchKiAQoO",
            "Z2V0Q291cG9uT2ZmZXISBi5pby5JZBofLnNpbmdsZV91c2VfY291cG9ucy5D",
            "b3Vwb25PZmZlciJngtPkkwIeEhwvY291cG9uL3NpbmdsZVVzZS9vZmZlci97",
            "aWR9kkFACg1Db3Vwb24gT2ZmZXJzEhBHZXQgQ291cG9uIE9mZmVyGh1HZXRz",
            "IGFuIGV4aXN0aW5nIENvdXBvbiBPZmZlchLbAgoRZGVsZXRlQ291cG9uT2Zm",
            "ZXISBi5pby5JZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSKlAoLT5JMCISoc",
            "L2NvdXBvbi9zaW5nbGVVc2Uvb2ZmZXIve2lkfToBKpJB+gEKDUNvdXBvbiBP",
            "ZmZlcnMSE0RlbGV0ZSBDb3Vwb24gT2ZmZXIa0wFEZWxldGVzIGFuIGV4aXN0",
            "aW5nIENvdXBvbiBPZmZlciBieSBpZC4gRGVsZXRpbmcgYSBDb3Vwb24gT2Zm",
            "ZXIgcmVzdWx0cyBpbiBhbGwgY291cG9ucyBiZWluZyBpbnZhbGlkYXRlZCBp",
            "biB0aGUgY3VzdG9tZXJzIE1vYmlsZSBXYWxsZXQ7IHJlbmRlcmluZyB0aGVt",
            "IHVudXNhYmxlLiBOZWVkcyB0byBiZSB1c2VkIHdpdGggY2FyZSwgdGhpcyBp",
            "cyBpcnJldmVyc2libGUuEqECChpsaXN0Q291cG9uT2ZmZXJzRGVwcmVjYXRl",
            "ZBI1LnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25PZmZlcnNMaXN0UmVxdWVz",
            "dERlcHJlY2F0ZWQaHy5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uT2ZmZXIi",
            "qAGC0+STAhoSGC9jb3Vwb24vc2luZ2xlVXNlL29mZmVyc5JBhAEKDUNvdXBv",
            "biBPZmZlcnMSH0xpc3QgQ291cG9uIE9mZmVycyBbREVQUkVDQVRFRF0aUltE",
            "RVBSRUNBVEVEOiBPUiBvcGVyYXRvciBpcyBub3Qgc3VwcG9ydGVkXSBMaXN0",
            "cyBhbGwgQ291cG9uIE9mZmVycyBmb3IgYSBjYW1wYWlnbi4wARLbAQoQbGlz",
            "dENvdXBvbk9mZmVycxIrLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25PZmZl",
            "cnNMaXN0UmVxdWVzdBofLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25PZmZl",
            "ciJ3gtPkkwIiIh0vY291cG9uL3NpbmdsZVVzZS9vZmZlcnMvbGlzdDoBKpJB",
            "TAoNQ291cG9uIE9mZmVycxISTGlzdCBDb3Vwb24gT2ZmZXJzGidMaXN0cyBh",
            "bGwgQ291cG9uIE9mZmVycyBmb3IgYSBjYW1wYWlnbi4wARKPAQoMY3JlYXRl",
            "Q291cG9uEhouc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBvbhoGLmlvLklkIluC",
            "0+STAh0iGC9jb3Vwb24vc2luZ2xlVXNlL2NvdXBvbjoBKpJBNQoHQ291cG9u",
            "cxINQ3JlYXRlIENvdXBvbhobQ3JlYXRlcyBhIG5ldyB1bmlxdWUgQ291cG9u",
            "Eo4BCgx1cGRhdGVDb3Vwb24SGi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9u",
            "GgYuaW8uSWQiWoLT5JMCHRoYL2NvdXBvbi9zaW5nbGVVc2UvY291cG9uOgEq",
            "kkE0CgdDb3Vwb25zEg1VcGRhdGUgQ291cG9uGhpVcGRhdGVzIGFuIGV4aXN0",
            "aW5nIENvdXBvbhLNAQoTc3RyZWFtQ291cG9uVXBkYXRlcxIaLnNpbmdsZV91",
            "c2VfY291cG9ucy5Db3Vwb24aBi5pby5JZCKNAZJBiQEKB0NvdXBvbnMSNFN0",
            "cmVhbSBDb3Vwb24gVXBkYXRlcyAob2ZmaWNpYWwgU0RLJ3Mgb25seSwgbm8g",
            "UkVTVCkaSFVwZGF0ZXMgZXhpc3RpbmcgQ291cG9uIHJlY29yZHMgdmlhIHN0",
            "cmVhbS4gVG8gYmUgdXNlZCBmb3IgYmF0Y2ggdXBkYXRlLigBMAES6wIKDHJl",
            "ZGVlbUNvdXBvbhIaLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb24aBi5pby5J",
            "ZCK2AoLT5JMCJBofL2NvdXBvbi9zaW5nbGVVc2UvY291cG9uL3JlZGVlbToB",
            "KpJBiAIKB0NvdXBvbnMSDVJlZGVlbSBDb3Vwb24a7QFSZWRlZW1zIGFuIGV4",
            "aXN0aW5nIENvdXBvbi4gVXNlIHRoaXMgZW5kcG9pbnQgd2hlbiB5b3Ugd2Fu",
            "dCB0byBjYXB0dXJlIHJlZGVtcHRpb24gZGF0YSBhbmQgdHJpZ2dlciB0aGUg",
            "c3dpdGNoIHRvIHRoZSByZWRlbXB0aW9uIGRlc2lnbiBvZiB0aGUgY291cG9u",
            "LiBUaGUgY291cG9uIGNhbm5vdCBiZSB1c2VkIGFnYWluIGFmdGVyIGNhbGxp",
            "bmcgdGhpcyBlbmRwb2ludCwgYW5kIGlzIG1hcmtlZCBhcyByZWRlZW1lZC4S",
            "2QEKF3N0cmVhbUNvdXBvblJlZGVtcHRpb25zEhouc2luZ2xlX3VzZV9jb3Vw",
            "b25zLkNvdXBvbhoGLmlvLklkIpUBkkGRAQoHQ291cG9ucxI4U3RyZWFtIENv",
            "dXBvbiBSZWRlbXB0aW9ucyAob2ZmaWNpYWwgU0RLJ3Mgb25seSwgbm8gUkVT",
            "VCkaTFJlZGVlbXMgZXhpc3RpbmcgQ291cG9uIHJlY29yZHMgdmlhIHN0cmVh",
            "bS4gVG8gYmUgdXNlZCBmb3IgYmF0Y2ggcmVkZW1wdGlvbi4oATABEo4BCg1n",
            "ZXRDb3Vwb25CeUlkEgYuaW8uSWQaGi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291",
            "cG9uIlmC0+STAh8SHS9jb3Vwb24vc2luZ2xlVXNlL2NvdXBvbi97aWR9kkEx",
            "CgdDb3Vwb25zEhBHZXQgQ291cG9uIGJ5IElEGhRHZXRzIGEgQ291cG9uIHJl",
            "Y29yZBL0AQoVZ2V0Q291cG9uQnlFeHRlcm5hbElkEiUuc2luZ2xlX3VzZV9j",
            "b3Vwb25zLkV4dGVybmFsSWRSZXF1ZXN0Ghouc2luZ2xlX3VzZV9jb3Vwb25z",
            "LkNvdXBvbiKXAYLT5JMCRRJDL2NvdXBvbi9zaW5nbGVVc2UvY291cG9uL2V4",
            "dGVybmFsSWQve2NvdXBvbkNhbXBhaWduSWR9L3tleHRlcm5hbElkfZJBSQoH",
            "Q291cG9ucxIZR2V0IENvdXBvbiBieSBFeHRlcm5hbCBJRBojR2V0cyBhIENv",
            "dXBvbiByZWNvcmQgYnkgRXh0ZXJuYWwgSUQSwgIKCnZvaWRDb3Vwb24SGi5z",
            "aW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uGhYuZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5Iv8BgtPkkwIdKhgvY291cG9uL3NpbmdsZVVzZS9jb3Vwb246ASqSQdgB",
            "CgdDb3Vwb25zEgtWb2lkIENvdXBvbhq/AVZvaWRzIChkZWxldGVzKSBhbiBl",
            "eGlzdGluZyBDb3Vwb24gYnkgSUQgb3IgRXh0ZXJuYWwgSUQuIEludmFsaWRh",
            "dGVzIHRoZSBjb3Vwb24gaW4gdGhlIGN1c3RvbWVycyBNb2JpbGUgV2FsbGV0",
            "OyByZW5kZXJpbmcgaXQgdXNlbGVzcy4gVGhpcyBtZXRob2QgaXMgaXJyZXZl",
            "cnNpYmxlIGFuZCBzaG91bGQgYmUgdXNlZCB3aXRoIGNhcmUuErgCCiVsaXN0",
            "Q291cG9uc0J5Q291cG9uQ2FtcGFpZ25EZXByZWNhdGVkEikuc2luZ2xlX3Vz",
            "ZV9jb3Vwb25zLkxpc3RSZXF1ZXN0RGVwcmVjYXRlZBoaLnNpbmdsZV91c2Vf",
            "Y291cG9ucy5Db3Vwb24ixQGC0+STAi4SLC9jb3Vwb24vc2luZ2xlVXNlL2Nv",
            "dXBvbnMve2NvdXBvbkNhbXBhaWduSWR9kkGNAQoHQ291cG9ucxIZTGlzdCBD",
            "b3Vwb25zIFtERVBSRUNBVEVEXRpnW0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9y",
            "IGlzIG5vdCBzdXBwb3J0ZWRdIExpc3QgYWxsIGNvdXBvbnMgZm9yIGEgQ291",
            "cG9uIENhbXBhaWduLiBTdXBwb3J0cyBwYWdpbmF0aW9uLjABEvMBChtsaXN0",
            "Q291cG9uc0J5Q291cG9uQ2FtcGFpZ24SHy5zaW5nbGVfdXNlX2NvdXBvbnMu",
            "TGlzdFJlcXVlc3QaGi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uIpQBgtPk",
            "kwI2IjEvY291cG9uL3NpbmdsZVVzZS9jb3Vwb25zL2xpc3Qve2NvdXBvbkNh",
            "bXBhaWduSWR9OgEqkkFVCgdDb3Vwb25zEgxMaXN0IENvdXBvbnMaPExpc3Qg",
            "YWxsIGNvdXBvbnMgZm9yIGEgQ291cG9uIENhbXBhaWduLiBTdXBwb3J0cyBw",
            "YWdpbmF0aW9uLjABEpcCCiZjb3VudENvdXBvbnNCeUNvdXBvbkNhbXBhaWdu",
            "RGVwcmVjYXRlZBIpLnNpbmdsZV91c2VfY291cG9ucy5MaXN0UmVxdWVzdERl",
            "cHJlY2F0ZWQaCS5pby5Db3VudCK2AYLT5JMCNBIyL2NvdXBvbi9zaW5nbGVV",
            "c2UvY291cG9ucy9jb3VudC97Y291cG9uQ2FtcGFpZ25JZH2SQXkKB0NvdXBv",
            "bnMSGUxpc3QgQ291cG9ucyBbREVQUkVDQVRFRF0aU1tERVBSRUNBVEVEOiBP",
            "UiBvcGVyYXRvciBpcyBub3Qgc3VwcG9ydGVkXSBDb3VudCBhbGwgY291cG9u",
            "cyBmb3IgYSBDb3Vwb24gQ2FtcGFpZ24uEs4BChxjb3VudENvdXBvbnNCeUNv",
            "dXBvbkNhbXBhaWduEh8uc2luZ2xlX3VzZV9jb3Vwb25zLkxpc3RSZXF1ZXN0",
            "GgkuaW8uQ291bnQigQGC0+STAjciMi9jb3Vwb24vc2luZ2xlVXNlL2NvdXBv",
            "bnMvY291bnQve2NvdXBvbkNhbXBhaWduSWR9OgEqkkFBCgdDb3Vwb25zEgxM",
            "aXN0IENvdXBvbnMaKENvdW50IGFsbCBjb3Vwb25zIGZvciBhIENvdXBvbiBD",
            "YW1wYWlnbi4SuQEKEmNvcHlDb3Vwb25DYW1wYWlnbhInLnNpbmdsZV91c2Vf",
            "Y291cG9ucy5DYW1wYWlnbkNvcHlSZXF1ZXN0GgYuaW8uSWQicoLT5JMCJCIf",
            "L2NvdXBvbi9zaW5nbGVVc2UvY2FtcGFpZ24vY29weToBKpJBRQoQQ291cG9u",
            "IENhbXBhaWducxINQ29weSBDYW1wYWlnbhoiQ29waWVzIGFuIGV4aXN0aW5n",
            "IGNhbXBhaWduIHJlY29yZEKVBwogaW8ucGFzc2tpdC5QS2lvLlNpbmdsZVVz",
            "ZUNvdXBvbnNaN3N0YXNoLnBhc3NraXQuY29tL2lvL21vZGVsL3Nkay9nby9p",
            "by9zaW5nbGVfdXNlX2NvdXBvbnOqAhJQS1NpbmdsZVVzZUNvdXBvbnOSQaEG",
            "Er4CCh1QYXNzS2l0IFNpbmdsZSBVc2UgQ291cG9uIEFQSRKcAVRoaXMgcHJv",
            "dG9jb2wgaXMgc3VpdCBmb3IgY2FzZXMgd2hlcmUgdGhlIHVzZXIgcmVxdWly",
            "ZXMgYSBjbGVhbiBhbmQgc2ltcGxlIHNpbmdsZSB1c2UgY291cG9uIGZvciBz",
            "aG9ydCB0ZXJtIGNvdXBvbiBjYW1wYWlnbnMgaW4gQXBwbGUgV2FsbGV0IGFu",
            "ZCBHb29nbGUgUGF5Lho4aHR0cHM6Ly9wYXNza2l0LmNvbS9sZWdhbC90ZXJt",
            "cy1vZi1zdWJzY3JpcHRpb24tc2VydmljZS8iPwoPUGFzc0tpdCBTdXBwb3J0",
            "EhdodHRwczovL2RvY3MucGFzc2tpdC5pbxoTc3VwcG9ydEBwYXNza2l0LmNv",
            "bTIDMC4xKgECMhBhcHBsaWNhdGlvbi9qc29uOhBhcHBsaWNhdGlvbi9qc29u",
            "UjkKAzIwMBIyCihSZXR1cm5lZCB3aGVuIHRoZSByZXF1ZXN0IGlzIHN1Y2Nl",
            "c3NmdWwuEgYKBJoCAQdSUAoDNDAzEkkKR1JldHVybmVkIHdoZW4gdGhlIHVz",
            "ZXIgZG9lcyBub3QgaGF2ZSBwZXJtaXNzaW9uIHRvIGFjY2VzcyB0aGUgcmVz",
            "b3VyY2UuUjsKAzQwNBI0CipSZXR1cm5lZCB3aGVuIHRoZSByZXNvdXJjZSBk",
            "b2VzIG5vdCBleGlzdC4SBgoEmgIBB1I8CgM1MDASNQorUmV0dXJuZWQgd2hl",
            "biB0aGVyZSBpcyBhbiB1bmV4cGVjdGVkIGVycm9yLhIGCgSaAgEHUl0KAzUw",
            "MxJWClRSZXR1cm5lZCB3aGVuIHRoZSB1c2VyIGlzIGJlaW5nIHRocm90dGxl",
            "ZC4gQmFjayBvZmYgZm9yIGEgZmV3IG1zIGFuZCB0aGVuIHRyeSBhZ2Fpbi5a",
            "Pgo8CgphcGlLZXlBdXRoEi4IAhIZSldUIEF1dGhlbnRpY2F0aW9uIHRva2Vu",
            "LhoNQXV0aG9yaXphdGlvbiACYhAKDgoKYXBpS2V5QXV0aBIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.PaginationReflection.Descriptor, global::PKIo.FilterReflection.Descriptor, global::PKIo.ReportingReflection.Descriptor, global::PKSingleUseCoupons.CampaignReflection.Descriptor, global::PKSingleUseCoupons.OfferReflection.Descriptor, global::PKSingleUseCoupons.CouponReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
