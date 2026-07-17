using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Files;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FilesUploadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "entity": "x",
              "entityId": "x",
              "fileName": "x",
              "mimeType": "x",
              "content": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/upload")
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

        var response = await Client.Files.PostV1FilesUploadAsync(
            new PostV1FilesUploadRequest
            {
                Entity = "x",
                EntityId = "x",
                FileName = "x",
                MimeType = "x",
                Content = "x",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "entity": "entity",
              "entityId": "entityId",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "content": "content"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/upload")
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

        var response = await Client.Files.PostV1FilesUploadAsync(
            new PostV1FilesUploadRequest
            {
                Entity = "entity",
                EntityId = "entityId",
                FileName = "fileName",
                MimeType = "mimeType",
                Content = "content",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
