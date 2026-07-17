using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsConfigsListTest : BaseMockServerTest
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
                },
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/configs/list")
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

        var response = await Client.Declarations.PostV1DeclarationsConfigsListAsync(
            new PostV1DeclarationsConfigsListRequest()
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
                  "system": "system",
                  "country": "country",
                  "title": "title",
                  "fields": [
                    {
                      "key": "key",
                      "kind": "text"
                    }
                  ],
                  "endpoints": [
                    {
                      "name": "name"
                    }
                  ],
                  "values": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/configs/list")
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

        var response = await Client.Declarations.PostV1DeclarationsConfigsListAsync(
            new PostV1DeclarationsConfigsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
