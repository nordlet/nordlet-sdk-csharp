using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationGroupsListTest : BaseMockServerTest
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
                  "name": "name",
                  "presentationCurrency": "presentationCurrency",
                  "memberCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "name": "name",
                  "presentationCurrency": "presentationCurrency",
                  "memberCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/groups/list")
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

        var response = await Client.Consolidation.PostV1ConsolidationGroupsListAsync(
            new PostV1ConsolidationGroupsListRequest()
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
                  "name": "name",
                  "presentationCurrency": "presentationCurrency",
                  "memberCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/groups/list")
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

        var response = await Client.Consolidation.PostV1ConsolidationGroupsListAsync(
            new PostV1ConsolidationGroupsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
