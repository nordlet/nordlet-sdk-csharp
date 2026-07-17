using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationMembersRemoveTest : BaseMockServerTest
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
              "ok": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/members/remove")
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

        var response = await Client.Consolidation.PostV1ConsolidationMembersRemoveAsync(
            new PostV1ConsolidationMembersRemoveRequest { GroupId = "x", MemberCompanyId = "x" }
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
              "ok": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/members/remove")
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

        var response = await Client.Consolidation.PostV1ConsolidationMembersRemoveAsync(
            new PostV1ConsolidationMembersRemoveRequest
            {
                GroupId = "groupId",
                MemberCompanyId = "memberCompanyId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
