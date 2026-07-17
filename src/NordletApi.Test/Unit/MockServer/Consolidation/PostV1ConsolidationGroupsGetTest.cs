using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationGroupsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "presentationCurrency": "presentationCurrency",
              "memberCount": 1000000,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "members": [
                {
                  "memberCompanyId": "x",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full"
                },
                {
                  "memberCompanyId": "x",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/groups/get")
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

        var response = await Client.Consolidation.PostV1ConsolidationGroupsGetAsync(
            new PostV1ConsolidationGroupsGetRequest { GroupId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "groupId": "groupId"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "presentationCurrency": "presentationCurrency",
              "memberCount": 1000000,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "members": [
                {
                  "memberCompanyId": "memberCompanyId",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/groups/get")
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

        var response = await Client.Consolidation.PostV1ConsolidationGroupsGetAsync(
            new PostV1ConsolidationGroupsGetRequest { GroupId = "groupId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
