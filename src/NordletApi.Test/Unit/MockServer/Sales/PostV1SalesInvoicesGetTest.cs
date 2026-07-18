using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesInvoicesGetTest : BaseMockServerTest
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/get")
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

        var response = await Client.Sales.PostV1SalesInvoicesGetAsync(
            new PostV1SalesInvoicesGetRequest { Id = "x" }
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/get")
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

        var response = await Client.Sales.PostV1SalesInvoicesGetAsync(
            new PostV1SalesInvoicesGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
