using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsSubmissionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "obligation": "lt-isaf",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "obligation": "obligation",
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "variant": "variant",
              "status": "generated",
              "fileName": "fileName",
              "fileId": "x",
              "externalRef": "externalRef",
              "message": "message",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/create")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsCreateAsync(
            new PostV1DeclarationsSubmissionsCreateRequest
            {
                Obligation = PostV1DeclarationsSubmissionsCreateRequestObligation.LtIsaf,
                Year = 1000000,
                Month = 1000000,
                DataType = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "obligation": "lt-isaf",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "obligation": "obligation",
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "variant": "variant",
              "status": "generated",
              "fileName": "fileName",
              "fileId": "fileId",
              "externalRef": "externalRef",
              "message": "message",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/create")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsCreateAsync(
            new PostV1DeclarationsSubmissionsCreateRequest
            {
                Obligation = PostV1DeclarationsSubmissionsCreateRequestObligation.LtIsaf,
                Year = 1000000,
                Month = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
