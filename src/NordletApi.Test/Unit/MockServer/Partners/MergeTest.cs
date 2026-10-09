using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MergeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "sourceId": "x",
              "targetId": "x"
            }
            """;

        const string mockResponse = """
            {
              "targetId": "x",
              "sourceId": "x",
              "moved": [
                {
                  "table": "table",
                  "column": "column",
                  "rows": 1000000
                },
                {
                  "table": "table",
                  "column": "column",
                  "rows": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/merge")
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

        var response = await Client.Partners.MergeAsync(
            new MergePartnersRequest { SourceId = "x", TargetId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "sourceId": "sourceId",
              "targetId": "targetId"
            }
            """;

        const string mockResponse = """
            {
              "targetId": "targetId",
              "sourceId": "sourceId",
              "moved": [
                {
                  "table": "table",
                  "column": "column",
                  "rows": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/merge")
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

        var response = await Client.Partners.MergeAsync(
            new MergePartnersRequest { SourceId = "sourceId", TargetId = "targetId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
