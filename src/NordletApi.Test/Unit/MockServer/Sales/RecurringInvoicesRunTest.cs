using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecurringInvoicesRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "generated": [
                {
                  "recurringInvoiceId": "x",
                  "invoiceId": "x",
                  "issueDate": "2023-01-15",
                  "issued": true,
                  "sent": true
                },
                {
                  "recurringInvoiceId": "x",
                  "invoiceId": "x",
                  "issueDate": "2023-01-15",
                  "issued": true,
                  "sent": true
                }
              ],
              "errors": [
                {
                  "recurringInvoiceId": "x",
                  "message": "message"
                },
                {
                  "recurringInvoiceId": "x",
                  "message": "message"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recurring-invoices/run")
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

        var response = await Client.Sales.RecurringInvoicesRunAsync(
            new RecurringInvoicesRunSalesRequest { AsOfDate = null }
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
              "generated": [
                {
                  "recurringInvoiceId": "recurringInvoiceId",
                  "invoiceId": "invoiceId",
                  "issueDate": "2026-07-01",
                  "issued": true,
                  "sent": true
                }
              ],
              "errors": [
                {
                  "recurringInvoiceId": "recurringInvoiceId",
                  "message": "message"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recurring-invoices/run")
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

        var response = await Client.Sales.RecurringInvoicesRunAsync(
            new RecurringInvoicesRunSalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
