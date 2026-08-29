using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListThePsd2BanksAspsPsAvailableToConnectTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "provider": "provider",
              "banks": [
                {
                  "name": "name",
                  "country": "country",
                  "logoUrl": "logoUrl",
                  "psuTypes": [
                    "business",
                    "business"
                  ],
                  "maxConsentDays": 1000000
                },
                {
                  "name": "name",
                  "country": "country",
                  "logoUrl": "logoUrl",
                  "psuTypes": [
                    "business",
                    "business"
                  ],
                  "maxConsentDays": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/banks/list")
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

        var response = await Client.Bank.ListThePsd2BanksAspsPsAvailableToConnectAsync(
            new PostV1BankFeedsBanksListRequest { Country = null }
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
              "provider": "provider",
              "banks": [
                {
                  "name": "name",
                  "country": "country",
                  "logoUrl": "logoUrl",
                  "psuTypes": [
                    "business"
                  ],
                  "maxConsentDays": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/banks/list")
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

        var response = await Client.Bank.ListThePsd2BanksAspsPsAvailableToConnectAsync(
            new PostV1BankFeedsBanksListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
