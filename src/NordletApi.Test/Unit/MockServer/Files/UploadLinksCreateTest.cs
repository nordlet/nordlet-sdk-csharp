using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Files;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UploadLinksCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "entity": "x",
              "fileName": "x"
            }
            """;

        const string mockResponse = """
            {
              "url": "url",
              "fileId": "x",
              "storageKey": "storageKey",
              "expiresAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/upload-links/create")
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

        var response = await Client.Files.UploadLinksCreateAsync(
            new UploadLinksCreateFilesRequest
            {
                Entity = "x",
                EntityId = null,
                FileName = "x",
                MimeType = null,
                ExpiresInMinutes = null,
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
              "fileName": "fileName"
            }
            """;

        const string mockResponse = """
            {
              "url": "url",
              "fileId": "fileId",
              "storageKey": "storageKey",
              "expiresAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/files/upload-links/create")
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

        var response = await Client.Files.UploadLinksCreateAsync(
            new UploadLinksCreateFilesRequest { Entity = "entity", FileName = "fileName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
