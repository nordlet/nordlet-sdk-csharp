using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsConfigsUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "system": "x",
              "config": {
                "config": "config"
              }
            }
            """;

        const string mockResponse = """
            {
              "system": "system",
              "country": "country",
              "title": "title",
              "fields": [
                {
                  "key": "key",
                  "kind": "text",
                  "multiline": true,
                  "options": [
                    "options",
                    "options"
                  ]
                },
                {
                  "key": "key",
                  "kind": "text",
                  "multiline": true,
                  "options": [
                    "options",
                    "options"
                  ]
                }
              ],
              "endpoints": [
                {
                  "name": "name",
                  "test": "test",
                  "production": "production"
                },
                {
                  "name": "name",
                  "test": "test",
                  "production": "production"
                }
              ],
              "values": {
                "values": "values"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/configs/update")
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

        var response = await Client.Declarations.PostV1DeclarationsConfigsUpdateAsync(
            new PostV1DeclarationsConfigsUpdateRequest
            {
                System = "x",
                Config = new Dictionary<string, string>() { { "config", "config" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "system": "system",
              "config": {
                "key": "value"
              }
            }
            """;

        const string mockResponse = """
            {
              "system": "system",
              "country": "country",
              "title": "title",
              "fields": [
                {
                  "key": "key",
                  "kind": "text",
                  "multiline": true,
                  "options": [
                    "options"
                  ]
                }
              ],
              "endpoints": [
                {
                  "name": "name",
                  "test": "test",
                  "production": "production"
                }
              ],
              "values": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/configs/update")
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

        var response = await Client.Declarations.PostV1DeclarationsConfigsUpdateAsync(
            new PostV1DeclarationsConfigsUpdateRequest
            {
                System = "system",
                Config = new Dictionary<string, string>() { { "key", "value" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
