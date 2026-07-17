using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceSeriesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "documentType": "x",
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "documentType": "documentType",
              "prefix": "prefix",
              "year": 1000000,
              "nextNumber": 1000000,
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/series/create")
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

        var response = await Client.Reference.PostV1ReferenceSeriesCreateAsync(
            new PostV1ReferenceSeriesCreateRequest
            {
                DocumentType = "x",
                Prefix = null,
                Year = 1000000,
                StartAt = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "documentType": "documentType",
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "documentType": "documentType",
              "prefix": "prefix",
              "year": 1000000,
              "nextNumber": 1000000,
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/series/create")
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

        var response = await Client.Reference.PostV1ReferenceSeriesCreateAsync(
            new PostV1ReferenceSeriesCreateRequest { DocumentType = "documentType", Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
