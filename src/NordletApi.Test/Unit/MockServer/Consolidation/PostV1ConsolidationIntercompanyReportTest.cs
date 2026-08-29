using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationIntercompanyReportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate",
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
                      "issueDate": "issueDate",
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
                      "issueDate": "issueDate",
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
                      "documentDate": "documentDate",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    },
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "documentDate",
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
                      "issueDate": "issueDate",
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
                      "issueDate": "issueDate",
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
                      "documentDate": "documentDate",
                      "currency": "currency",
                      "grossTotal": "grossTotal",
                      "status": "draft"
                    },
                    {
                      "invoiceId": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "documentDate",
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyReportAsync(
            new PostV1ConsolidationIntercompanyReportRequest
            {
                GroupId = "x",
                FromDate = "fromDate",
                ToDate = "toDate",
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
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate",
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
                      "issueDate": "issueDate",
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
                      "documentDate": "documentDate",
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

        var response = await Client.Consolidation.PostV1ConsolidationIntercompanyReportAsync(
            new PostV1ConsolidationIntercompanyReportRequest
            {
                GroupId = "groupId",
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
