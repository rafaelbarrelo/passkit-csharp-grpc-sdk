// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_images.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/core/a_rpc_images.proto</summary>
  public static partial class ARpcImagesReflection {

    #region Descriptor
    /// <summary>File descriptor for io/core/a_rpc_images.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcImagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chppby9jb3JlL2FfcnBjX2ltYWdlcy5wcm90bxICaW8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29wdGlvbnMvYW5ub3RhdGlvbnMucHJv",
            "dG8aHmlvL2NvbW1vbi9jb21tb25fb2JqZWN0cy5wcm90bxoaaW8vY29tbW9u",
            "L3BhZ2luYXRpb24ucHJvdG8aFGlvL2ltYWdlL2ltYWdlLnByb3RvMtIWCgZJ",
            "bWFnZXMSWwoPc2V0UHJvZmlsZUltYWdlEhUuaW8uUHJvZmlsZUltYWdlSW5w",
            "dXQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiGYLT5JMCEyIOL2ltYWdlL3By",
            "b2ZpbGU6ASoSSgoPZ2V0UHJvZmlsZUltYWdlEhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5GgcuaW8uVXJsIhaC0+STAhASDi9pbWFnZS9wcm9maWxlEkMKE2dl",
            "dFByb2ZpbGVJbWFnZUJ5SWQSBi5pby5JZBoHLmlvLlVybCIbgtPkkwIVEhMv",
            "aW1hZ2UvcHJvZmlsZS97aWR9EtkBCgxjcmVhdGVJbWFnZXMSFC5pby5DcmVh",
            "dGVJbWFnZUlucHV0GgwuaW8uSW1hZ2VJZHMipAGC0+STAgwiBy9pbWFnZXM6",
            "ASqSQY4BEg1DcmVhdGUgSW1hZ2VzGhVDcmVhdGVzIGltYWdlIHJlY29yZC5K",
            "MAoDNDAwEikKJ1RoZXJlIGlzIGEgcHJvYmxlbSB3aXRoIHRoZSBpbnB1dCBk",
            "YXRhLko0CgM0MDMSLQorUmV0dXJuZWQgd2hlbiB0aGUgdXNlciBsYWNrcyBh",
            "dXRob3JpemF0aW9uLhLDAgoLdXBkYXRlSW1hZ2USFC5pby5VcGRhdGVJbWFn",
            "ZUlucHV0Gg8uaW8uSW1hZ2VSZWNvcmQijAKC0+STAgsaBi9pbWFnZToBKpJB",
            "9wESDFVwZGF0ZSBJbWFnZRoYVXBkYXRlcyBhbiBpbWFnZSByZWNvcmQuSjAK",
            "AzQwMBIpCidUaGVyZSBpcyBhIHByb2JsZW0gd2l0aCB0aGUgaW5wdXQgZGF0",
            "YS5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0",
            "EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLkpXCgM1MDMSUApOU2VydmVyIGlz",
            "IHVuYXZhaWxhYmxlLiBCYWNrIG9mZiBmb3IgMjUwbXMgYW5kIHJlcGVhdCBy",
            "ZXF1ZXN0IHVudGlsIHN1Y2Nlc3NmdWwuEqMBCgtnZXRJbWFnZVVSTBIGLmlv",
            "LklkGgcuaW8uVXJsIoIBgtPkkwINEgsvaW1hZ2Uve2lkfZJBbBINR2V0IElt",
            "YWdlIFVSTBoXUmV0cmlldmVzIGFuIGltYWdlIHVybC5KIgoDNDAzEhsKGVVz",
            "ZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3YXMg",
            "bm90IGZvdW5kLhK7AQoOZ2V0SW1hZ2VCdW5kbGUSBi5pby5JZBoPLmlvLklt",
            "YWdlQnVuZGxlIo8BgtPkkwIUEhIvaW1hZ2UvYnVuZGxlL3tpZH2SQXISEEdl",
            "dCBJbWFnZSBCdW5kbGUaGlJldHJpZXZlcyBhbiBpbWFnZSBidW5kbGUuSiIK",
            "AzQwMxIbChlVc2VyIGxhY2tzIGF1dGhvcml6YXRpb24uSh4KAzQwNBIXChVS",
            "ZWNvcmQgd2FzIG5vdCBmb3VuZC4StQEKDGdldEltYWdlRGF0YRIGLmlvLklk",
            "Gg8uaW8uSW1hZ2VSZWNvcmQiiwGC0+STAhISEC9pbWFnZS9kYXRhL3tpZH2S",
            "QXASDkdldCBJbWFnZSBEYXRhGhpSZXRyaWV2ZXMgYW4gaW1hZ2UgcmVjb3Jk",
            "LkoiCgM0MDMSGwoZVXNlciBsYWNrcyBhdXRob3JpemF0aW9uLkoeCgM0MDQS",
            "FwoVUmVjb3JkIHdhcyBub3QgZm91bmQuEt8BChRnZXRMb2NhbGl6ZWRJbWFn",
            "ZVVSTBIXLmlvLkxvY2FsaXplZEltYWdlSW5wdXQaBy5pby5VcmwipAGC0+ST",
            "AhwSGi9pbWFnZS97aWR9L3tsYW5ndWFnZUNvZGV9kkF/EhdHZXQgTG9jYWxp",
            "emVkIEltYWdlIFVSTBogUmV0cmlldmVzIGEgbG9jYWxpemVkIGltYWdlIFVS",
            "TC5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0",
            "EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLhKxAQoLZGVsZXRlSW1hZ2USBi5p",
            "by5JZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSKBAYLT5JMCDSoLL2ltYWdl",
            "L3tpZH2SQWsSDERlbGV0ZSBJbWFnZRoXRGVsZXRlcyBhbiBpbWFnZSByZWNv",
            "cmRKIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0",
            "EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLhLmAQoUZGVsZXRlTG9jYWxpemVk",
            "SW1hZ2USFy5pby5Mb2NhbGl6ZWRJbWFnZUlucHV0Gg8uaW8uSW1hZ2VSZWNv",
            "cmQiowGC0+STAhwqGi9pbWFnZS97aWR9L3tsYW5ndWFnZUNvZGV9kkF+EhZE",
            "ZWxldGUgTG9jYWxpemVkIEltYWdlGiBEZWxldGVzIGEgbG9jYWxpemVkIGlt",
            "YWdlIHJlY29yZEoiCgM0MDMSGwoZVXNlciBsYWNrcyBhdXRob3JpemF0aW9u",
            "LkoeCgM0MDQSFwoVUmVjb3JkIHdhcyBub3QgZm91bmQuEuMBChFsaXN0SW1h",
            "Z2VzRm9yVXNlchIOLmlvLlBhZ2luYXRpb24aDy5pby5JbWFnZVJlY29yZCKq",
            "AYLT5JMCDhIML2ltYWdlcy91c2VykkGSARIXR2V0IEFsbCBJbWFnZXMgRm9y",
            "IFVzZXIaM1JldHJpZXZlcyBhbGwgaW1hZ2VzIHN0b3JlZCB1bmRlciB0aGUg",
            "dXNlciBhY2NvdW50LkoiCgM0MDMSGwoZVXNlciBsYWNrcyBhdXRob3JpemF0",
            "aW9uLkoeCgM0MDQSFwoVUmVjb3JkIHdhcyBub3QgZm91bmQuMAES0wEKCmxp",
            "c3RJbWFnZXMSDi5pby5QYWdpbmF0aW9uGg8uaW8uSW1hZ2VSZWNvcmQioQGC",
            "0+STAgkSBy9pbWFnZXOSQY4BEhhHZXQgQWxsIEF2YWlsYWJsZSBJbWFnZXMa",
            "LlJldHJpZXZlcyBhbGwgaW1hZ2VzIHN0b3JlZCB1bmRlciB0aGUgY29tcGFu",
            "eS5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0",
            "EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLjABEu4BCgtjb3VudEltYWdlcxIO",
            "LmlvLlBhZ2luYXRpb24aCS5pby5Db3VudCLDAYLT5JMCDxINL2ltYWdlcy9j",
            "b3VudJJBqgESJkNvdW50IEFsbCBJbWFnZXMgQXZhaWxhYmxlIHRvIFRoZSBV",
            "c2VyGjxSZXRyaWV2ZXMgYSBjb3VudCBvZiBpbWFnZXMgc3RvcmVkIHVuZGVy",
            "IHRoZSB1c2VyJ3MgY29tcGFueS5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0",
            "aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLhLv",
            "AQoSY291bnRJbWFnZXNGb3JVc2VyEg4uaW8uUGFnaW5hdGlvbhoJLmlvLkNv",
            "dW50Ir0BgtPkkwIUEhIvaW1hZ2VzL3VzZXIvY291bnSSQZ8BEiJDb3VudCBB",
            "bGwgSW1hZ2VzIE93bmVkIGJ5IFRoZSBVc2VyGjVSZXRyaWV2ZXMgYWxsIGlt",
            "YWdlcyBzdG9yZWQgdW5kZXIgdGhlIHVzZXIncyBhY2NvdW50LkoiCgM0MDMS",
            "GwoZVXNlciBsYWNrcyBhdXRob3JpemF0aW9uLkoeCgM0MDQSFwoVUmVjb3Jk",
            "IHdhcyBub3QgZm91bmQuQj4KD2lvLnBhc3NraXQuUEtpb1okc3Rhc2gucGFz",
            "c2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvqgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.PaginationReflection.Descriptor, global::PKIo.ImageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code