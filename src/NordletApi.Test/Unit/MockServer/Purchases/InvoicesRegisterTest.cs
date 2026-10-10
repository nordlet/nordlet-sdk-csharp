using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesRegisterTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
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
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "x",
                  "projectId": "x",
                  "accountCode": "accountCode",
                  "deferralStartDate": "2023-01-15",
                  "deferralEndDate": "2023-01-15",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "x",
                  "projectId": "x",
                  "accountCode": "accountCode",
                  "deferralStartDate": "2023-01-15",
                  "deferralEndDate": "2023-01-15",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/register")
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

        var response = await Client.Purchases.InvoicesRegisterAsync(
            new InvoicesRegisterPurchasesRequest
            {
                Id = "x",
                RegistrationDate = null,
                WarehouseId = null,
                ReturnFromStock = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
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
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "costCenterId",
                  "projectId": "projectId",
                  "accountCode": "accountCode",
                  "deferralStartDate": "2026-07-01",
                  "deferralEndDate": "2026-07-01",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/register")
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

        var response = await Client.Purchases.InvoicesRegisterAsync(
            new InvoicesRegisterPurchasesRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
