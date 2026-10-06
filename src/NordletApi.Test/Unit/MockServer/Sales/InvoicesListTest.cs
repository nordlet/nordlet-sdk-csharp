using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

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
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "currency": "currency",
                  "fxRate": "fxRate",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "appliedToInvoiceId": "x",
                  "creditedInvoiceId": "x",
                  "creditedInvoiceReference": "creditedInvoiceReference",
                  "creditedInvoiceDate": "2023-01-15",
                  "agreementId": "x",
                  "vatScheme": "domestic",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "operationTypeId": "x",
                  "documentSeriesId": "x",
                  "seriesLabel": "seriesLabel",
                  "discountPercent": "discountPercent",
                  "orderNumber": "orderNumber",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "lockedAt": "2024-01-15T09:30:00.000Z",
                  "lockedBy": "lockedBy",
                  "payToken": "payToken",
                  "einvoiceSystem": "einvoiceSystem",
                  "einvoiceTransport": "einvoiceTransport",
                  "einvoiceMessageId": "einvoiceMessageId",
                  "einvoiceNumber": "einvoiceNumber",
                  "einvoiceStatus": "einvoiceStatus",
                  "einvoiceDetail": "einvoiceDetail",
                  "einvoiceSentAt": "2024-01-15T09:30:00.000Z",
                  "einvoiceCheckedAt": "2024-01-15T09:30:00.000Z",
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
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "currency": "currency",
                  "fxRate": "fxRate",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "appliedToInvoiceId": "x",
                  "creditedInvoiceId": "x",
                  "creditedInvoiceReference": "creditedInvoiceReference",
                  "creditedInvoiceDate": "2023-01-15",
                  "agreementId": "x",
                  "vatScheme": "domestic",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "operationTypeId": "x",
                  "documentSeriesId": "x",
                  "seriesLabel": "seriesLabel",
                  "discountPercent": "discountPercent",
                  "orderNumber": "orderNumber",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "lockedAt": "2024-01-15T09:30:00.000Z",
                  "lockedBy": "lockedBy",
                  "payToken": "payToken",
                  "einvoiceSystem": "einvoiceSystem",
                  "einvoiceTransport": "einvoiceTransport",
                  "einvoiceMessageId": "einvoiceMessageId",
                  "einvoiceNumber": "einvoiceNumber",
                  "einvoiceStatus": "einvoiceStatus",
                  "einvoiceDetail": "einvoiceDetail",
                  "einvoiceSentAt": "2024-01-15T09:30:00.000Z",
                  "einvoiceCheckedAt": "2024-01-15T09:30:00.000Z",
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
                    .WithPath("/v1/sales/invoices/list")
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

        var response = await Client.Sales.InvoicesListAsync(
            new InvoicesListSalesRequest
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
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "2026-07-01",
                  "dueDate": "2026-07-01",
                  "currency": "currency",
                  "fxRate": "fxRate",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "journalTransactionId",
                  "appliedToInvoiceId": "appliedToInvoiceId",
                  "creditedInvoiceId": "creditedInvoiceId",
                  "creditedInvoiceReference": "creditedInvoiceReference",
                  "creditedInvoiceDate": "2026-07-01",
                  "agreementId": "agreementId",
                  "vatScheme": "domestic",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "operationTypeId": "operationTypeId",
                  "documentSeriesId": "documentSeriesId",
                  "seriesLabel": "seriesLabel",
                  "discountPercent": "discountPercent",
                  "orderNumber": "orderNumber",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "lockedAt": "2026-07-01T09:30:00.000Z",
                  "lockedBy": "lockedBy",
                  "payToken": "payToken",
                  "einvoiceSystem": "einvoiceSystem",
                  "einvoiceTransport": "einvoiceTransport",
                  "einvoiceMessageId": "einvoiceMessageId",
                  "einvoiceNumber": "einvoiceNumber",
                  "einvoiceStatus": "einvoiceStatus",
                  "einvoiceDetail": "einvoiceDetail",
                  "einvoiceSentAt": "2026-07-01T09:30:00.000Z",
                  "einvoiceCheckedAt": "2026-07-01T09:30:00.000Z",
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
                    .WithPath("/v1/sales/invoices/list")
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

        var response = await Client.Sales.InvoicesListAsync(new InvoicesListSalesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
