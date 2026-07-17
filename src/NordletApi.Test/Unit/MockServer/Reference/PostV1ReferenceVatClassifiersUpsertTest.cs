using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceVatClassifiersUpsertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "rows": [
                {
                  "code": "x",
                  "name": "x"
                },
                {
                  "code": "x",
                  "name": "x"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "upserted": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/vat-classifiers/upsert")
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

        var response = await Client.Reference.PostV1ReferenceVatClassifiersUpsertAsync(
            new PostV1ReferenceVatClassifiersUpsertRequest
            {
                Rows = new List<PostV1ReferenceVatClassifiersUpsertRequestRowsItem>()
                {
                    new PostV1ReferenceVatClassifiersUpsertRequestRowsItem
                    {
                        Code = "x",
                        CountryCode = null,
                        Name = "x",
                        RatePercent = null,
                    },
                    new PostV1ReferenceVatClassifiersUpsertRequestRowsItem
                    {
                        Code = "x",
                        CountryCode = null,
                        Name = "x",
                        RatePercent = null,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "rows": [
                {
                  "code": "code",
                  "name": "name"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "upserted": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/vat-classifiers/upsert")
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

        var response = await Client.Reference.PostV1ReferenceVatClassifiersUpsertAsync(
            new PostV1ReferenceVatClassifiersUpsertRequest
            {
                Rows = new List<PostV1ReferenceVatClassifiersUpsertRequestRowsItem>()
                {
                    new PostV1ReferenceVatClassifiersUpsertRequestRowsItem
                    {
                        Code = "code",
                        Name = "name",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
