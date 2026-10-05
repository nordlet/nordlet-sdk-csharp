using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExchangeRatesSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "currency": "foo",
              "date": "2023-01-15",
              "rate": "rate"
            }
            """;

        const string mockResponse = """
            {
              "currencyCode": "currencyCode",
              "date": "2023-01-15",
              "rate": "rate"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/exchange-rates/set")
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

        var response = await Client.Reference.ExchangeRatesSetAsync(
            new ExchangeRatesSetReferenceRequest
            {
                Currency = "foo",
                Date = new DateOnly(2023, 1, 15),
                Rate = "rate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "currency": "currency",
              "date": "2026-07-01",
              "rate": "121.00000000"
            }
            """;

        const string mockResponse = """
            {
              "currencyCode": "currencyCode",
              "date": "2026-07-01",
              "rate": "rate"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/exchange-rates/set")
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

        var response = await Client.Reference.ExchangeRatesSetAsync(
            new ExchangeRatesSetReferenceRequest
            {
                Currency = "currency",
                Date = new DateOnly(2026, 7, 1),
                Rate = "121.00000000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
