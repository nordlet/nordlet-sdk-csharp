using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FeedsConnectionsStartTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "aspspName": "x",
              "aspspCountry": "xy"
            }
            """;

        const string mockResponse = """
            {
              "connectionId": "x",
              "reference": "reference",
              "url": "url",
              "expiresAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/start")
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

        var response = await Client.Bank.FeedsConnectionsStartAsync(
            new FeedsConnectionsStartBankRequest
            {
                AspspName = "x",
                AspspCountry = "xy",
                PsuType = null,
                RedirectUrl = null,
                ValidForDays = null,
                Language = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "aspspName": "aspspName",
              "aspspCountry": "aspspCountry"
            }
            """;

        const string mockResponse = """
            {
              "connectionId": "connectionId",
              "reference": "reference",
              "url": "url",
              "expiresAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/start")
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

        var response = await Client.Bank.FeedsConnectionsStartAsync(
            new FeedsConnectionsStartBankRequest
            {
                AspspName = "aspspName",
                AspspCountry = "aspspCountry",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
