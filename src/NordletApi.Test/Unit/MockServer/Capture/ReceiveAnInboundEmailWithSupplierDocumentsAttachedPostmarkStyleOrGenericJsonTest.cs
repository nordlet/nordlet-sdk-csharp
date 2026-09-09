using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiveAnInboundEmailWithSupplierDocumentsAttachedPostmarkStyleOrGenericJsonTest
    : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "accepted": 1000000,
              "skipped": 1000000,
              "captureIds": [
                "captureIds",
                "captureIds"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/inbound-email")
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

        var response =
            await Client.Capture.ReceiveAnInboundEmailWithSupplierDocumentsAttachedPostmarkStyleOrGenericJsonAsync(
                new PostV1CaptureInboundEmailRequest
                {
                    PostmarkTo = null,
                    ToFull = null,
                    PostmarkFrom = null,
                    PostmarkSubject = null,
                    PostmarkAttachments = null,
                    To = null,
                    From = null,
                    Subject = null,
                    Attachments = null,
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "accepted": 1000000,
              "skipped": 1000000,
              "captureIds": [
                "captureIds"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/inbound-email")
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

        var response =
            await Client.Capture.ReceiveAnInboundEmailWithSupplierDocumentsAttachedPostmarkStyleOrGenericJsonAsync(
                new PostV1CaptureInboundEmailRequest()
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
