using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesIssueTest : BaseMockServerTest
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
                  "vatExemptionBasis": "vatExemptionBasis",
                  "costCenterId": "x",
                  "projectId": "x",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "2023-01-15",
                  "recognitionEndDate": "2023-01-15",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "expectedDate": "2023-01-15",
                      "percent": "percent"
                    },
                    {
                      "description": "description",
                      "expectedDate": "2023-01-15",
                      "percent": "percent"
                    }
                  ],
                  "standaloneSellingPrice": "standaloneSellingPrice",
                  "allocatedNet": "allocatedNet",
                  "refundEstimatePercent": "refundEstimatePercent"
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
                  "vatExemptionBasis": "vatExemptionBasis",
                  "costCenterId": "x",
                  "projectId": "x",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "2023-01-15",
                  "recognitionEndDate": "2023-01-15",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "expectedDate": "2023-01-15",
                      "percent": "percent"
                    },
                    {
                      "description": "description",
                      "expectedDate": "2023-01-15",
                      "percent": "percent"
                    }
                  ],
                  "standaloneSellingPrice": "standaloneSellingPrice",
                  "allocatedNet": "allocatedNet",
                  "refundEstimatePercent": "refundEstimatePercent"
                }
              ],
              "vatEvidence": {
                "capturedAt": "2024-01-15T09:30:00.000Z",
                "issueDate": "2023-01-15",
                "scheme": {
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true
                },
                "partner": {
                  "id": "x",
                  "vatCode": "vatCode",
                  "vatValid": true,
                  "vatValidatedAt": "2024-01-15T09:30:00.000Z"
                },
                "vies": {
                  "valid": true,
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "name": "name",
                  "address": "address",
                  "requestIdentifier": "requestIdentifier",
                  "checkedAt": "2024-01-15T09:30:00.000Z"
                },
                "location": {
                  "billingCountryCode": "billingCountryCode",
                  "source": "source"
                },
                "rateTable": {
                  "importId": "x",
                  "situationOn": "situationOn",
                  "trigger": "trigger",
                  "startedAt": "2024-01-15T09:30:00.000Z"
                },
                "rates": [
                  {
                    "ratePercent": "ratePercent",
                    "country": "country",
                    "category": "category"
                  },
                  {
                    "ratePercent": "ratePercent",
                    "country": "country",
                    "category": "category"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/issue")
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

        var response = await Client.Sales.InvoicesIssueAsync(
            new InvoicesIssueSalesRequest
            {
                Id = "x",
                Series = null,
                IssueDate = null,
                WarehouseId = null,
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
                  "vatExemptionBasis": "vatExemptionBasis",
                  "costCenterId": "costCenterId",
                  "projectId": "projectId",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "2026-07-01",
                  "recognitionEndDate": "2026-07-01",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "expectedDate": "2026-07-01",
                      "percent": "percent"
                    }
                  ],
                  "standaloneSellingPrice": "standaloneSellingPrice",
                  "allocatedNet": "allocatedNet",
                  "refundEstimatePercent": "refundEstimatePercent"
                }
              ],
              "vatEvidence": {
                "capturedAt": "2026-07-01T09:30:00.000Z",
                "issueDate": "2026-07-01",
                "scheme": {
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true
                },
                "partner": {
                  "id": "id",
                  "vatCode": "vatCode",
                  "vatValid": true,
                  "vatValidatedAt": "2026-07-01T09:30:00.000Z"
                },
                "vies": {
                  "valid": true,
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "name": "name",
                  "address": "address",
                  "requestIdentifier": "requestIdentifier",
                  "checkedAt": "2026-07-01T09:30:00.000Z"
                },
                "location": {
                  "billingCountryCode": "billingCountryCode",
                  "source": "source"
                },
                "rateTable": {
                  "importId": "importId",
                  "situationOn": "situationOn",
                  "trigger": "trigger",
                  "startedAt": "2026-07-01T09:30:00.000Z"
                },
                "rates": [
                  {
                    "ratePercent": "ratePercent",
                    "country": "country"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/issue")
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

        var response = await Client.Sales.InvoicesIssueAsync(
            new InvoicesIssueSalesRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
