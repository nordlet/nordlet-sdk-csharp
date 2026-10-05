using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesListTest : BaseMockServerTest
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
                  "partnerId": "x",
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "documentNumber": "documentNumber",
                  "documentDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "registrationDate": "2023-01-15",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "creditedInvoiceId": "x",
                  "purchaseOrderId": "x",
                  "operationTypeId": "x",
                  "notes": "notes",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "einvoiceNumber": "einvoiceNumber",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "documentNumber": "documentNumber",
                  "documentDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "registrationDate": "2023-01-15",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "creditedInvoiceId": "x",
                  "purchaseOrderId": "x",
                  "operationTypeId": "x",
                  "notes": "notes",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "einvoiceNumber": "einvoiceNumber",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/list")
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

        var response = await Client.Purchases.InvoicesListAsync(
            new InvoicesListPurchasesRequest
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
                  "partnerId": "partnerId",
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "documentNumber": "documentNumber",
                  "documentDate": "2026-07-01",
                  "dueDate": "2026-07-01",
                  "registrationDate": "2026-07-01",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "journalTransactionId",
                  "creditedInvoiceId": "creditedInvoiceId",
                  "purchaseOrderId": "purchaseOrderId",
                  "operationTypeId": "operationTypeId",
                  "notes": "notes",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "einvoiceNumber": "einvoiceNumber",
                  "documentRef": "documentRef",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z",
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/list")
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

        var response = await Client.Purchases.InvoicesListAsync(new InvoicesListPurchasesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
