using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationMembersAddTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x",
              "memberCompanyId": "x"
            }
            """;

        const string mockResponse = """
            {
              "memberCompanyId": "x",
              "name": "name",
              "baseCurrency": "baseCurrency",
              "ownershipPercent": "ownershipPercent",
              "method": "full"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/members/add")
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

        var response = await Client.Consolidation.PostV1ConsolidationMembersAddAsync(
            new PostV1ConsolidationMembersAddRequest
            {
                GroupId = "x",
                MemberCompanyId = "x",
                OwnershipPercent = null,
                Method = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "groupId": "groupId",
              "memberCompanyId": "memberCompanyId"
            }
            """;

        const string mockResponse = """
            {
              "memberCompanyId": "memberCompanyId",
              "name": "name",
              "baseCurrency": "baseCurrency",
              "ownershipPercent": "ownershipPercent",
              "method": "full"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/members/add")
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

        var response = await Client.Consolidation.PostV1ConsolidationMembersAddAsync(
            new PostV1ConsolidationMembersAddRequest
            {
                GroupId = "groupId",
                MemberCompanyId = "memberCompanyId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
