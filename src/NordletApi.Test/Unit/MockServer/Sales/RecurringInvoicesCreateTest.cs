using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecurringInvoicesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "templateId": "x",
              "startDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recurring-invoices/create")
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

        var response = await Client.Sales.RecurringInvoicesCreateAsync(
            new RecurringInvoicesCreateSalesRequest
            {
                TemplateId = "x",
                PartnerId = null,
                Frequency = null,
                Interval = null,
                StartDate = new DateOnly(2023, 1, 15),
                EndDate = null,
                Locale = null,
                AutoIssue = null,
                AutoSend = null,
                SendTo = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "templateId": "templateId",
              "startDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recurring-invoices/create")
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

        var response = await Client.Sales.RecurringInvoicesCreateAsync(
            new RecurringInvoicesCreateSalesRequest
            {
                TemplateId = "templateId",
                StartDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
