using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceBanksUpsertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "countryCode": "xy",
              "name": "x",
              "bic": "mandarin"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "countryCode": "countryCode",
              "name": "name",
              "bic": "bic",
              "bankCode": "bankCode",
              "isActive": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/banks/upsert")
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

        var response = await Client.Reference.PostV1ReferenceBanksUpsertAsync(
            new PostV1ReferenceBanksUpsertRequest
            {
                CountryCode = "xy",
                Name = "x",
                Bic = "mandarin",
                BankCode = null,
                IsActive = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "countryCode": "countryCode",
              "name": "name",
              "bic": "bic"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "countryCode": "countryCode",
              "name": "name",
              "bic": "bic",
              "bankCode": "bankCode",
              "isActive": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/banks/upsert")
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

        var response = await Client.Reference.PostV1ReferenceBanksUpsertAsync(
            new PostV1ReferenceBanksUpsertRequest
            {
                CountryCode = "countryCode",
                Name = "name",
                Bic = "bic",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
