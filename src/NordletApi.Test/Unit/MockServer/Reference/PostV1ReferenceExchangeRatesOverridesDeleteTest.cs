using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceExchangeRatesOverridesDeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "currency": "foo",
              "date": "date"
            }
            """;

        const string mockResponse = """
            {
              "deleted": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/exchange-rates/overrides/delete")
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

        var response = await Client.Reference.PostV1ReferenceExchangeRatesOverridesDeleteAsync(
            new PostV1ReferenceExchangeRatesOverridesDeleteRequest
            {
                Currency = "foo",
                Date = "date",
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
              "date": "date"
            }
            """;

        const string mockResponse = """
            {
              "deleted": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/exchange-rates/overrides/delete")
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

        var response = await Client.Reference.PostV1ReferenceExchangeRatesOverridesDeleteAsync(
            new PostV1ReferenceExchangeRatesOverridesDeleteRequest
            {
                Currency = "currency",
                Date = "date",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
