using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtIvazCancelTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "entries": [
                {
                  "waybillId": "x",
                  "reason": "1"
                },
                {
                  "waybillId": "x",
                  "reason": "1"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "fileId": "x",
              "counts": {
                "documents": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/ivaz/cancel")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Declarations.PostV1DeclarationsLtIvazCancelAsync(
            new PostV1DeclarationsLtIvazCancelRequest
            {
                Entries = new List<PostV1DeclarationsLtIvazCancelRequestEntriesItem>()
                {
                    new PostV1DeclarationsLtIvazCancelRequestEntriesItem
                    {
                        WaybillId = "x",
                        Reason = PostV1DeclarationsLtIvazCancelRequestEntriesItemReason.One,
                        AdditionalInfo = null,
                    },
                    new PostV1DeclarationsLtIvazCancelRequestEntriesItem
                    {
                        WaybillId = "x",
                        Reason = PostV1DeclarationsLtIvazCancelRequestEntriesItemReason.One,
                        AdditionalInfo = null,
                    },
                },
                Persist = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "entries": [
                {
                  "waybillId": "waybillId",
                  "reason": "1"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "fileId": "fileId",
              "counts": {
                "documents": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/ivaz/cancel")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Declarations.PostV1DeclarationsLtIvazCancelAsync(
            new PostV1DeclarationsLtIvazCancelRequest
            {
                Entries = new List<PostV1DeclarationsLtIvazCancelRequestEntriesItem>()
                {
                    new PostV1DeclarationsLtIvazCancelRequestEntriesItem
                    {
                        WaybillId = "waybillId",
                        Reason = PostV1DeclarationsLtIvazCancelRequestEntriesItemReason.One,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
