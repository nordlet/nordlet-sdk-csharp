using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Files;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FilesListTest : BaseMockServerTest
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
                  "entity": "entity",
                  "entityId": "entityId",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "sha256": "sha256",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "entity": "entity",
                  "entityId": "entityId",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "sha256": "sha256",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/list")
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

        var response = await Client.Files.PostV1FilesListAsync(
            new PostV1FilesListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
            }
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
                  "entity": "entity",
                  "entityId": "entityId",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "sha256": "sha256",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/list")
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

        var response = await Client.Files.PostV1FilesListAsync(new PostV1FilesListRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
