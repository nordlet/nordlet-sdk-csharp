using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeferralsListTest : BaseMockServerTest
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
                  "invoiceId": "x",
                  "invoiceLineId": "x",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount",
                  "expenseAccountCode": "expenseAccountCode",
                  "prepaidAccountCode": "prepaidAccountCode",
                  "status": "pending",
                  "journalTransactionId": "x"
                },
                {
                  "id": "x",
                  "invoiceId": "x",
                  "invoiceLineId": "x",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount",
                  "expenseAccountCode": "expenseAccountCode",
                  "prepaidAccountCode": "prepaidAccountCode",
                  "status": "pending",
                  "journalTransactionId": "x"
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
                    .WithPath("/v1/purchases/deferrals/list")
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

        var response = await Client.Purchases.DeferralsListAsync(
            new DeferralsListPurchasesRequest
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
                  "invoiceId": "invoiceId",
                  "invoiceLineId": "invoiceLineId",
                  "scheduleDate": "2026-07-01",
                  "description": "description",
                  "amount": "amount",
                  "expenseAccountCode": "expenseAccountCode",
                  "prepaidAccountCode": "prepaidAccountCode",
                  "status": "pending",
                  "journalTransactionId": "journalTransactionId"
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
                    .WithPath("/v1/purchases/deferrals/list")
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

        var response = await Client.Purchases.DeferralsListAsync(
            new DeferralsListPurchasesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
