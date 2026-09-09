using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentTest
    : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "documentNumber": "x",
              "documentDate": "documentDate",
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
                  "documentDate": "documentDate",
                  "dueDate": "dueDate",
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
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              },
              "invoice": {
                "id": "x",
                "partnerId": "x",
                "type": "invoice",
                "status": "draft",
                "paymentStatus": "unpaid",
                "documentNumber": "documentNumber",
                "documentDate": "documentDate",
                "dueDate": "dueDate",
                "registrationDate": "registrationDate",
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
                "documentRef": "documentRef",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt",
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

        var response =
            await Client.Capture.SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentAsync(
                new PostV1CaptureDocumentsConfirmRequest
                {
                    Id = "x",
                    PartnerId = null,
                    NewSupplier = null,
                    DocumentNumber = "x",
                    DocumentDate = "documentDate",
                    DueDate = null,
                    Currency = null,
                    Notes = null,
                    Lines = new List<PostV1CaptureDocumentsConfirmRequestLinesItem>()
                    {
                        new PostV1CaptureDocumentsConfirmRequestLinesItem
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
                        },
                        new PostV1CaptureDocumentsConfirmRequestLinesItem
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
              "documentDate": "documentDate",
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
                  "documentDate": "documentDate",
                  "dueDate": "dueDate",
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
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              },
              "invoice": {
                "id": "id",
                "partnerId": "partnerId",
                "type": "invoice",
                "status": "draft",
                "paymentStatus": "unpaid",
                "documentNumber": "documentNumber",
                "documentDate": "documentDate",
                "dueDate": "dueDate",
                "registrationDate": "registrationDate",
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
                "documentRef": "documentRef",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt",
                "lines": [
                  {
                    "id": "id",
                    "description": "description",
                    "unit": "unit",
                    "quantity": "quantity",
                    "vatRatePercent": "vatRatePercent",
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

        var response =
            await Client.Capture.SaveTheReviewedDraftAsAPurchaseInvoiceAndAttachTheOriginalDocumentAsync(
                new PostV1CaptureDocumentsConfirmRequest
                {
                    Id = "id",
                    DocumentNumber = "documentNumber",
                    DocumentDate = "documentDate",
                    Lines = new List<PostV1CaptureDocumentsConfirmRequestLinesItem>()
                    {
                        new PostV1CaptureDocumentsConfirmRequestLinesItem(),
                    },
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
