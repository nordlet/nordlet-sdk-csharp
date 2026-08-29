using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationIntercompanyLinksSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x",
              "partnerId": "x",
              "counterpartyCompanyId": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "groupId": "x",
              "companyId": "x",
              "partnerId": "x",
              "counterpartyCompanyId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/links/set")
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyLinksSetAsync(
            new PostV1ConsolidationIntercompanyLinksSetRequest
            {
                GroupId = "x",
                PartnerId = "x",
                CounterpartyCompanyId = "x",
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
              "partnerId": "partnerId",
              "counterpartyCompanyId": "counterpartyCompanyId"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "groupId": "groupId",
              "companyId": "companyId",
              "partnerId": "partnerId",
              "counterpartyCompanyId": "counterpartyCompanyId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/links/set")
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyLinksSetAsync(
            new PostV1ConsolidationIntercompanyLinksSetRequest
            {
                GroupId = "groupId",
                PartnerId = "partnerId",
                CounterpartyCompanyId = "counterpartyCompanyId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
