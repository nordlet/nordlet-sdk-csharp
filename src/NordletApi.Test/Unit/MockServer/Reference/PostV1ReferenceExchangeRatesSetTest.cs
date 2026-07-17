using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceExchangeRatesSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "currency": "foo",
              "date": "date",
              "rate": "rate"
            }
            """;

        const string mockResponse = """
            {
              "currencyCode": "currencyCode",
              "date": "date",
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

        var response = await Client.Reference.PostV1ReferenceExchangeRatesSetAsync(
            new PostV1ReferenceExchangeRatesSetRequest
            {
                Currency = "foo",
                Date = "date",
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
              "date": "date",
              "rate": "rate"
            }
            """;

        const string mockResponse = """
            {
              "currencyCode": "currencyCode",
              "date": "date",
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

        var response = await Client.Reference.PostV1ReferenceExchangeRatesSetAsync(
            new PostV1ReferenceExchangeRatesSetRequest
            {
                Currency = "currency",
                Date = "date",
                Rate = "rate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
