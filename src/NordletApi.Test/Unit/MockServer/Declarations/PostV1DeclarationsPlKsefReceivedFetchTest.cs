using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsPlKsefReceivedFetchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "ksefNumber": "x"
            }
            """;

        const string mockResponse = """
            {
              "ksefNumber": "ksefNumber",
              "xml": "xml",
              "attachedTo": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/ksef/received/fetch")
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

        var response = await Client.Declarations.PostV1DeclarationsPlKsefReceivedFetchAsync(
            new PostV1DeclarationsPlKsefReceivedFetchRequest
            {
                KsefNumber = "x",
                PurchaseInvoiceId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "ksefNumber": "ksefNumber"
            }
            """;

        const string mockResponse = """
            {
              "ksefNumber": "ksefNumber",
              "xml": "xml",
              "attachedTo": "attachedTo"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/ksef/received/fetch")
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

        var response = await Client.Declarations.PostV1DeclarationsPlKsefReceivedFetchAsync(
            new PostV1DeclarationsPlKsefReceivedFetchRequest { KsefNumber = "ksefNumber" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
