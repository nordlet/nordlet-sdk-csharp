using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DocumentsConfirmTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
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
              "capture": {
                "id": "x",
                "fileId": "x",
                "fileName": "fileName",
                "mimeType": "mimeType",
                "sizeBytes": 1000000,
                "status": "pending",
                "provider": "provider",
                "model": "model",
                "pagesProcessed": 1000000,
                "extraction": {
                  "supplier": {
                    "name": "name",
                    "code": "code",
                    "vatCode": "vatCode",
                    "countryCode": "countryCode",
                    "iban": "iban"
                  },
                  "documentNumber": "documentNumber",
                  "documentDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "notes": "notes",
                  "lines": [
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "lineNet": "lineNet",
                      "lineVat": "lineVat",
                      "lineGross": "lineGross"
                    },
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "lineNet": "lineNet",
                      "lineVat": "lineVat",
                      "lineGross": "lineGross"
                    }
                  ]
                },
                "matchedPartnerId": "x",
                "purchaseInvoiceId": "x",
                "error": "error",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "updatedAt": "2024-01-15T09:30:00.000Z"
              },
              "invoice": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/confirm")
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

        var response = await Client.Capture.DocumentsConfirmAsync(
            new DocumentsConfirmCaptureRequest
            {
                Id = "x",
                PartnerId = null,
                NewSupplier = null,
                DocumentNumber = "x",
                DocumentDate = new DateOnly(2023, 1, 15),
                DueDate = null,
                Currency = null,
                Notes = null,
                Lines = new List<DocumentsConfirmCaptureRequestLinesItem>()
                {
                    new DocumentsConfirmCaptureRequestLinesItem
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
                    new DocumentsConfirmCaptureRequestLinesItem
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
              "id": "id",
              "documentNumber": "documentNumber",
              "documentDate": "2026-07-01",
              "lines": [
                {}
              ]
            }
            """;

        const string mockResponse = """
            {
              "capture": {
                "id": "id",
                "fileId": "fileId",
                "fileName": "fileName",
                "mimeType": "mimeType",
                "sizeBytes": 1000000,
                "status": "pending",
                "provider": "provider",
                "model": "model",
                "pagesProcessed": 1000000,
                "extraction": {
                  "supplier": {},
                  "documentNumber": "documentNumber",
                  "documentDate": "2026-07-01",
                  "dueDate": "2026-07-01",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "notes": "notes",
                  "lines": [
                    {
                      "description": "description",
                      "quantity": "quantity"
                    }
                  ]
                },
                "matchedPartnerId": "matchedPartnerId",
                "purchaseInvoiceId": "purchaseInvoiceId",
                "error": "error",
                "createdAt": "2026-07-01T09:30:00.000Z",
                "updatedAt": "2026-07-01T09:30:00.000Z"
              },
              "invoice": {
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
                    "description": "description",
                    "unit": "unit",
                    "quantity": "quantity",
                    "vatRatePercent": "vatRatePercent",
                    "deferralStartDate": "2026-07-01",
                    "deferralEndDate": "2026-07-01",
                    "lineNet": "lineNet",
                    "lineVat": "lineVat",
                    "lineGross": "lineGross",
                    "sortOrder": 1000000
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/confirm")
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

        var response = await Client.Capture.DocumentsConfirmAsync(
            new DocumentsConfirmCaptureRequest
            {
                Id = "id",
                DocumentNumber = "documentNumber",
                DocumentDate = new DateOnly(2026, 7, 1),
                Lines = new List<DocumentsConfirmCaptureRequestLinesItem>()
                {
                    new DocumentsConfirmCaptureRequestLinesItem(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
