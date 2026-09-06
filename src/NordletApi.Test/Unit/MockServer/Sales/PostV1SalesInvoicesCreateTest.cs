using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesInvoicesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
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
              "series": "series",
              "number": 1000000,
              "fullNumber": "fullNumber",
              "issueDate": "issueDate",
              "dueDate": "dueDate",
              "currency": "currency",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "paidAmount": "paidAmount",
              "journalTransactionId": "x",
              "appliedToInvoiceId": "x",
              "creditedInvoiceId": "x",
              "agreementId": "x",
              "vatScheme": "domestic",
              "vatCountryCode": "vatCountryCode",
              "deemedSupplier": true,
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
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "recognitionStartDate",
                  "recognitionEndDate": "recognitionEndDate",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "expectedDate": "expectedDate",
                      "percent": "percent"
                    },
                    {
                      "description": "description",
                      "expectedDate": "expectedDate",
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
                  "costCenterId": "x",
                  "projectId": "x",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "recognitionStartDate",
                  "recognitionEndDate": "recognitionEndDate",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "expectedDate": "expectedDate",
                      "percent": "percent"
                    },
                    {
                      "description": "description",
                      "expectedDate": "expectedDate",
                      "percent": "percent"
                    }
                  ],
                  "standaloneSellingPrice": "standaloneSellingPrice",
                  "allocatedNet": "allocatedNet",
                  "refundEstimatePercent": "refundEstimatePercent"
                }
              ],
              "vatEvidence": {
                "capturedAt": "capturedAt",
                "issueDate": "issueDate",
                "scheme": {
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true
                },
                "partner": {
                  "id": "x",
                  "vatCode": "vatCode",
                  "vatValid": true,
                  "vatValidatedAt": "vatValidatedAt"
                },
                "vies": {
                  "valid": true,
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "name": "name",
                  "address": "address",
                  "requestIdentifier": "requestIdentifier",
                  "checkedAt": "checkedAt"
                },
                "location": {
                  "billingCountryCode": "billingCountryCode",
                  "source": "source"
                },
                "rateTable": {
                  "importId": "x",
                  "situationOn": "situationOn",
                  "trigger": "trigger",
                  "startedAt": "startedAt"
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
                    .WithPath("/v1/sales/invoices/create")
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

        var response = await Client.Sales.PostV1SalesInvoicesCreateAsync(
            new PostV1SalesInvoicesCreateRequest
            {
                PartnerId = "x",
                Type = null,
                Currency = null,
                IssueDate = null,
                DueDate = null,
                CreditedInvoiceId = null,
                VatScheme = null,
                VatCountryCode = null,
                DeemedSupplier = null,
                Notes = null,
                DocumentRef = null,
                Lines = new List<PostV1SalesInvoicesCreateRequestLinesItem>()
                {
                    new PostV1SalesInvoicesCreateRequestLinesItem
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
                        Recognition = null,
                        StandaloneSellingPrice = null,
                        RefundEstimatePercent = null,
                    },
                    new PostV1SalesInvoicesCreateRequestLinesItem
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
                        Recognition = null,
                        StandaloneSellingPrice = null,
                        RefundEstimatePercent = null,
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
              "series": "series",
              "number": 1000000,
              "fullNumber": "fullNumber",
              "issueDate": "issueDate",
              "dueDate": "dueDate",
              "currency": "currency",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "paidAmount": "paidAmount",
              "journalTransactionId": "journalTransactionId",
              "appliedToInvoiceId": "appliedToInvoiceId",
              "creditedInvoiceId": "creditedInvoiceId",
              "agreementId": "agreementId",
              "vatScheme": "domestic",
              "vatCountryCode": "vatCountryCode",
              "deemedSupplier": true,
              "notes": "notes",
              "documentRef": "documentRef",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
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
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000,
                  "recognitionMethod": "point_in_time",
                  "recognitionStartDate": "recognitionStartDate",
                  "recognitionEndDate": "recognitionEndDate",
                  "recognitionMilestones": [
                    {
                      "description": "description",
                      "percent": "percent"
                    }
                  ],
                  "standaloneSellingPrice": "standaloneSellingPrice",
                  "allocatedNet": "allocatedNet",
                  "refundEstimatePercent": "refundEstimatePercent"
                }
              ],
              "vatEvidence": {
                "capturedAt": "capturedAt",
                "issueDate": "issueDate",
                "scheme": {
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true
                },
                "partner": {
                  "id": "id",
                  "vatCode": "vatCode",
                  "vatValid": true,
                  "vatValidatedAt": "vatValidatedAt"
                },
                "vies": {
                  "valid": true,
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "name": "name",
                  "address": "address",
                  "requestIdentifier": "requestIdentifier",
                  "checkedAt": "checkedAt"
                },
                "location": {
                  "billingCountryCode": "billingCountryCode",
                  "source": "source"
                },
                "rateTable": {
                  "importId": "importId",
                  "situationOn": "situationOn",
                  "trigger": "trigger",
                  "startedAt": "startedAt"
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
                    .WithPath("/v1/sales/invoices/create")
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

        var response = await Client.Sales.PostV1SalesInvoicesCreateAsync(
            new PostV1SalesInvoicesCreateRequest
            {
                PartnerId = "partnerId",
                Lines = new List<PostV1SalesInvoicesCreateRequestLinesItem>()
                {
                    new PostV1SalesInvoicesCreateRequestLinesItem(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
