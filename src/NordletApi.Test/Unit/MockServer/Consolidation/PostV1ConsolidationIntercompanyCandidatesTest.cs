using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationIntercompanyCandidatesTest : BaseMockServerTest
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
              "rows": [
                {
                  "memberCompanyId": "x",
                  "memberName": "memberName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "x",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code",
                  "linkId": "x"
                },
                {
                  "memberCompanyId": "x",
                  "memberName": "memberName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "x",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code",
                  "linkId": "x"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/candidates")
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyCandidatesAsync(
            new PostV1ConsolidationIntercompanyCandidatesRequest { GroupId = "x" }
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
              "rows": [
                {
                  "memberCompanyId": "memberCompanyId",
                  "memberName": "memberName",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "matchesCompanyId",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code",
                  "linkId": "linkId"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/candidates")
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyCandidatesAsync(
            new PostV1ConsolidationIntercompanyCandidatesRequest { GroupId = "groupId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
