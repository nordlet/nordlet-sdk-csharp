using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecurringInvoicesListTest : BaseMockServerTest
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
                  "templateId": "x",
                  "templateName": "templateName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "frequency": "weekly",
                  "interval": 1000000,
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "nextRunDate": "2023-01-15",
                  "status": "active",
                  "locale": "locale",
                  "autoIssue": true,
                  "autoSend": true,
                  "sendTo": "sendTo",
                  "occurrences": 1000000,
                  "lastRunAt": "2024-01-15T09:30:00.000Z",
                  "lastInvoiceId": "x",
                  "lastError": "lastError",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "templateId": "x",
                  "templateName": "templateName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "frequency": "weekly",
                  "interval": 1000000,
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "nextRunDate": "2023-01-15",
                  "status": "active",
                  "locale": "locale",
                  "autoIssue": true,
                  "autoSend": true,
                  "sendTo": "sendTo",
                  "occurrences": 1000000,
                  "lastRunAt": "2024-01-15T09:30:00.000Z",
                  "lastInvoiceId": "x",
                  "lastError": "lastError",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/sales/recurring-invoices/list")
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

        var response = await Client.Sales.RecurringInvoicesListAsync(
            new RecurringInvoicesListSalesRequest
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
                  "templateId": "templateId",
                  "templateName": "templateName",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "frequency": "weekly",
                  "interval": 1000000,
                  "startDate": "2026-07-01",
                  "endDate": "2026-07-01",
                  "nextRunDate": "2026-07-01",
                  "status": "active",
                  "locale": "locale",
                  "autoIssue": true,
                  "autoSend": true,
                  "sendTo": "sendTo",
                  "occurrences": 1000000,
                  "lastRunAt": "2026-07-01T09:30:00.000Z",
                  "lastInvoiceId": "lastInvoiceId",
                  "lastError": "lastError",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/sales/recurring-invoices/list")
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

        var response = await Client.Sales.RecurringInvoicesListAsync(
            new RecurringInvoicesListSalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
