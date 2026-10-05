using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IntercompanyLinksListTest : BaseMockServerTest
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
                  "id": "x",
                  "companyId": "x",
                  "companyName": "companyName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "counterpartyCompanyId": "x",
                  "counterpartyCompanyName": "counterpartyCompanyName",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "companyId": "x",
                  "companyName": "companyName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "counterpartyCompanyId": "x",
                  "counterpartyCompanyName": "counterpartyCompanyName",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/links/list")
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

        var response = await Client.Consolidation.IntercompanyLinksListAsync(
            new IntercompanyLinksListConsolidationRequest { GroupId = "x" }
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
                  "id": "id",
                  "companyId": "companyId",
                  "companyName": "companyName",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "counterpartyCompanyId": "counterpartyCompanyId",
                  "counterpartyCompanyName": "counterpartyCompanyName",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/links/list")
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

        var response = await Client.Consolidation.IntercompanyLinksListAsync(
            new IntercompanyLinksListConsolidationRequest { GroupId = "groupId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
