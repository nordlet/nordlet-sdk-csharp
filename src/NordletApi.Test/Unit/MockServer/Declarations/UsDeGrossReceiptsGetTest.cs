using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsDeGrossReceiptsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "period": "period",
              "activity": "services"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "activity": "activity",
              "grossReceipts": "grossReceipts",
              "excludedReceipts": "excludedReceipts",
              "deduction": "deduction",
              "taxableReceipts": "taxableReceipts",
              "rate": "rate",
              "tax": "tax",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/gross-receipts/get")
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

        var response = await Client.Declarations.UsDeGrossReceiptsGetAsync(
            new UsDeGrossReceiptsGetDeclarationsRequest
            {
                Period = "period",
                Activity = UsDeGrossReceiptsGetDeclarationsRequestActivity.Services,
                ExcludedReceipts = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "period": "period",
              "activity": "services"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "activity": "activity",
              "grossReceipts": "grossReceipts",
              "excludedReceipts": "excludedReceipts",
              "deduction": "deduction",
              "taxableReceipts": "taxableReceipts",
              "rate": "rate",
              "tax": "tax",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/gross-receipts/get")
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

        var response = await Client.Declarations.UsDeGrossReceiptsGetAsync(
            new UsDeGrossReceiptsGetDeclarationsRequest
            {
                Period = "period",
                Activity = UsDeGrossReceiptsGetDeclarationsRequestActivity.Services,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
