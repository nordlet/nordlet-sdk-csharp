using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
              "documentNumber": "x",
              "documentDate": "2023-01-15",
              "lines": [
                {},
                {}
              ]
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
                    .WithPath("/v1/purchases/invoices/create")
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

        var response = await Client.Purchases.InvoicesCreateAsync(
            new InvoicesCreatePurchasesRequest
            {
                PartnerId = "x",
                Type = null,
                DocumentNumber = "x",
                DocumentDate = new DateOnly(2023, 1, 15),
                DueDate = null,
                Currency = null,
                CreditedInvoiceId = null,
                PurchaseOrderId = null,
                OperationTypeId = null,
                Notes = null,
                IntrastatTransportMode = null,
                IntrastatDeliveryTerms = null,
                IntrastatRegion = null,
                IntrastatNatureOfTransaction = null,
                EinvoiceNumber = null,
                DocumentRef = null,
                Lines = new List<InvoicesCreatePurchasesRequestLinesItem>()
                {
                    new InvoicesCreatePurchasesRequestLinesItem
                    {
                        ItemId = null,
                        Description = null,
                        Unit = null,
                        Quantity = null,
                        UnitPriceExclVat = null,
                        UnitPriceInclVat = null,
                        VatRatePercent = null,
                        VatClassifierCode = null,
                        CostCenterId = null,
                        ProjectId = null,
                        AccountCode = null,
                        DeferralStartDate = null,
                        DeferralEndDate = null,
                    },
                    new InvoicesCreatePurchasesRequestLinesItem
                    {
                        ItemId = null,
                        Description = null,
                        Unit = null,
                        Quantity = null,
                        UnitPriceExclVat = null,
                        UnitPriceInclVat = null,
                        VatRatePercent = null,
                        VatClassifierCode = null,
                        CostCenterId = null,
                        ProjectId = null,
                        AccountCode = null,
                        DeferralStartDate = null,
                        DeferralEndDate = null,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "partnerId": "partnerId",
              "documentNumber": "documentNumber",
              "documentDate": "2026-07-01",
              "lines": [
                {}
              ]
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
                    .WithPath("/v1/purchases/invoices/create")
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

        var response = await Client.Purchases.InvoicesCreateAsync(
            new InvoicesCreatePurchasesRequest
            {
                PartnerId = "partnerId",
                DocumentNumber = "documentNumber",
                DocumentDate = new DateOnly(2026, 7, 1),
                Lines = new List<InvoicesCreatePurchasesRequestLinesItem>()
                {
                    new InvoicesCreatePurchasesRequestLinesItem(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
