using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AgreementsListTest : BaseMockServerTest
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
                  "typeId": "x",
                  "kind": "customer",
                  "partnerId": "x",
                  "employeeId": "x",
                  "bankAccountId": "x",
                  "number": "number",
                  "name": "name",
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "autoRenew": true,
                  "value": "value",
                  "billingPeriod": "monthly",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
                },
                {
                  "id": "x",
                  "typeId": "x",
                  "kind": "customer",
                  "partnerId": "x",
                  "employeeId": "x",
                  "bankAccountId": "x",
                  "number": "number",
                  "name": "name",
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "autoRenew": true,
                  "value": "value",
                  "billingPeriod": "monthly",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/list")
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

        var response = await Client.Agreements.AgreementsListAsync(
            new AgreementsListAgreementsRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
            }
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
                  "typeId": "typeId",
                  "kind": "customer",
                  "partnerId": "partnerId",
                  "employeeId": "employeeId",
                  "bankAccountId": "bankAccountId",
                  "number": "number",
                  "name": "name",
                  "startDate": "2026-07-01",
                  "endDate": "2026-07-01",
                  "autoRenew": true,
                  "value": "value",
                  "billingPeriod": "monthly",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/list")
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

        var response = await Client.Agreements.AgreementsListAsync(
            new AgreementsListAgreementsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
