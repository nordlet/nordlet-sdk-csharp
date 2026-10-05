using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IntercompanyReportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "directions": [
                {
                  "sellerCompanyId": "x",
                  "sellerName": "sellerName",
                  "buyerCompanyId": "x",
                  "buyerName": "buyerName",
                  "documents": [
                    {
                      "sourceInvoiceId": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "type": "invoice",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "paymentStatus": "unpaid",
                      "match": "mirrored",
                      "counterpart": {
                        "invoiceId": "x",
                        "status": "draft",
                        "paymentStatus": "unpaid",
                        "grossTotal": "grossTotal",
                        "amountsMatch": true
                      }
                    },
                    {
                      "sourceInvoiceId": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "type": "invoice",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "paymentStatus": "unpaid",
                      "match": "mirrored",
                      "counterpart": {
                        "invoiceId": "x",
                        "status": "draft",
                        "paymentStatus": "unpaid",
                        "grossTotal": "grossTotal",
                        "amountsMatch": true
                      }
                    }
                  ],
                  "unmatchedPurchases": [
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    },
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    }
                  ],
                  "totals": [
                    {
                      "currency": "currency",
                      "salesGross": "salesGross",
                      "purchasesGross": "purchasesGross",
                      "grossDifference": "grossDifference",
                      "openReceivable": "openReceivable",
                      "openPayable": "openPayable",
                      "openDifference": "openDifference"
                    },
                    {
                      "currency": "currency",
                      "salesGross": "salesGross",
                      "purchasesGross": "purchasesGross",
                      "grossDifference": "grossDifference",
                      "openReceivable": "openReceivable",
                      "openPayable": "openPayable",
                      "openDifference": "openDifference"
                    }
                  ]
                },
                {
                  "sellerCompanyId": "x",
                  "sellerName": "sellerName",
                  "buyerCompanyId": "x",
                  "buyerName": "buyerName",
                  "documents": [
                    {
                      "sourceInvoiceId": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "type": "invoice",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "paymentStatus": "unpaid",
                      "match": "mirrored",
                      "counterpart": {
                        "invoiceId": "x",
                        "status": "draft",
                        "paymentStatus": "unpaid",
                        "grossTotal": "grossTotal",
                        "amountsMatch": true
                      }
                    },
                    {
                      "sourceInvoiceId": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "type": "invoice",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "paymentStatus": "unpaid",
                      "match": "mirrored",
                      "counterpart": {
                        "invoiceId": "x",
                        "status": "draft",
                        "paymentStatus": "unpaid",
                        "grossTotal": "grossTotal",
                        "amountsMatch": true
                      }
                    }
                  ],
                  "unmatchedPurchases": [
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    },
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    }
                  ],
                  "totals": [
                    {
                      "currency": "currency",
                      "salesGross": "salesGross",
                      "purchasesGross": "purchasesGross",
                      "grossDifference": "grossDifference",
                      "openReceivable": "openReceivable",
                      "openPayable": "openPayable",
                      "openDifference": "openDifference"
                    },
                    {
                      "currency": "currency",
                      "salesGross": "salesGross",
                      "purchasesGross": "purchasesGross",
                      "grossDifference": "grossDifference",
                      "openReceivable": "openReceivable",
                      "openPayable": "openPayable",
                      "openDifference": "openDifference"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/report")
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

        var response = await Client.Consolidation.IntercompanyReportAsync(
            new IntercompanyReportConsolidationRequest
            {
                GroupId = "x",
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "groupId": "groupId",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "directions": [
                {
                  "sellerCompanyId": "sellerCompanyId",
                  "sellerName": "sellerName",
                  "buyerCompanyId": "buyerCompanyId",
                  "buyerName": "buyerName",
                  "documents": [
                    {
                      "sourceInvoiceId": "sourceInvoiceId",
                      "fullNumber": "fullNumber",
                      "issueDate": "2026-07-01",
                      "type": "invoice",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "paymentStatus": "unpaid",
                      "match": "mirrored"
                    }
                  ],
                  "unmatchedPurchases": [
                    {
                      "invoiceId": "invoiceId",
                      "documentNumber": "documentNumber",
                      "documentDate": "2026-07-01",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    }
                  ],
                  "totals": [
                    {
                      "currency": "currency",
                      "salesGross": "salesGross",
                      "purchasesGross": "purchasesGross",
                      "grossDifference": "grossDifference",
                      "openReceivable": "openReceivable",
                      "openPayable": "openPayable",
                      "openDifference": "openDifference"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/intercompany/report")
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

        var response = await Client.Consolidation.IntercompanyReportAsync(
            new IntercompanyReportConsolidationRequest
            {
                GroupId = "groupId",
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
