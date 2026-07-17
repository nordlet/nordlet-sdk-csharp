using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerPeriodsUnlockTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "year": 1000000,
              "month": 1000000,
              "status": "open"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/periods/unlock")
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

        var response = await Client.Ledger.PostV1LedgerPeriodsUnlockAsync(
            new PostV1LedgerPeriodsUnlockRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "year": 1000000,
              "month": 1000000,
              "status": "open"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/periods/unlock")
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

        var response = await Client.Ledger.PostV1LedgerPeriodsUnlockAsync(
            new PostV1LedgerPeriodsUnlockRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
