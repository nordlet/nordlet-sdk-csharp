using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceEuVatRatesImportsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "situationOn": "situationOn",
                  "status": "running",
                  "trigger": "seed",
                  "ratesFetched": 1000000,
                  "ratesInserted": 1000000,
                  "ratesClosed": 1000000,
                  "error": "error",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
                },
                {
                  "id": "x",
                  "situationOn": "situationOn",
                  "status": "running",
                  "trigger": "seed",
                  "ratesFetched": 1000000,
                  "ratesInserted": 1000000,
                  "ratesClosed": 1000000,
                  "error": "error",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/imports/list")
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

        var response = await Client.Reference.PostV1ReferenceEuVatRatesImportsListAsync(
            new PostV1ReferenceEuVatRatesImportsListRequest { Limit = null }
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
              "rows": [
                {
                  "id": "id",
                  "situationOn": "situationOn",
                  "status": "running",
                  "trigger": "seed",
                  "ratesFetched": 1000000,
                  "ratesInserted": 1000000,
                  "ratesClosed": 1000000,
                  "error": "error",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/imports/list")
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

        var response = await Client.Reference.PostV1ReferenceEuVatRatesImportsListAsync(
            new PostV1ReferenceEuVatRatesImportsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
