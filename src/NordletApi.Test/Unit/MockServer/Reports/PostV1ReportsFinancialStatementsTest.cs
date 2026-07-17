using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsFinancialStatementsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "category": "micro",
              "layout": "layout",
              "requiredStatements": [
                "requiredStatements",
                "requiredStatements"
              ],
              "asOf": "asOf",
              "balanceSheet": {
                "nonCurrentAssets": "nonCurrentAssets",
                "currentAssets": "currentAssets",
                "totalAssets": "totalAssets",
                "equity": "equity",
                "ofWhichResult": "ofWhichResult",
                "liabilities": "liabilities",
                "totalEquityAndLiabilities": "totalEquityAndLiabilities",
                "balanced": true
              },
              "profitLoss": {
                "fromDate": "fromDate",
                "toDate": "toDate",
                "revenue": "revenue",
                "expenses": "expenses",
                "netResult": "netResult"
              },
              "balanceSheetDetail": {
                "nonCurrentAssets": {
                  "intangible": "intangible",
                  "tangible": "tangible",
                  "financial": "financial",
                  "other": "other",
                  "total": "total"
                },
                "currentAssets": {
                  "inventories": "inventories",
                  "receivables": "receivables",
                  "otherCurrent": "otherCurrent",
                  "cash": "cash",
                  "total": "total"
                },
                "equity": {
                  "capital": "capital",
                  "reserves": "reserves",
                  "retainedEarnings": "retainedEarnings",
                  "otherEquity": "otherEquity",
                  "periodResult": "periodResult",
                  "total": "total"
                },
                "liabilities": {
                  "nonCurrent": "nonCurrent",
                  "current": "current",
                  "other": "other",
                  "total": "total"
                }
              },
              "profitLossDetail": {
                "salesRevenue": "salesRevenue",
                "costOfSales": "costOfSales",
                "grossProfit": "grossProfit",
                "sellingExpenses": "sellingExpenses",
                "adminExpenses": "adminExpenses",
                "operatingProfit": "operatingProfit",
                "otherActivityResult": "otherActivityResult",
                "financialActivityResult": "financialActivityResult",
                "profitBeforeTax": "profitBeforeTax",
                "incomeTax": "incomeTax",
                "netProfit": "netProfit"
              },
              "equityChanges": [
                {
                  "code": "code",
                  "name": "name",
                  "opening": "opening",
                  "increase": "increase",
                  "decrease": "decrease",
                  "closing": "closing"
                },
                {
                  "code": "code",
                  "name": "name",
                  "opening": "opening",
                  "increase": "increase",
                  "decrease": "decrease",
                  "closing": "closing"
                }
              ],
              "cashFlow": {
                "openingCash": "openingCash",
                "operating": "operating",
                "investing": "investing",
                "financing": "financing",
                "netChange": "netChange",
                "closingCash": "closingCash"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/financial-statements")
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

        var response = await Client.Reports.PostV1ReportsFinancialStatementsAsync(
            new PostV1ReportsFinancialStatementsRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                Category = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "category": "micro",
              "layout": "layout",
              "requiredStatements": [
                "requiredStatements"
              ],
              "asOf": "asOf",
              "balanceSheet": {
                "nonCurrentAssets": "nonCurrentAssets",
                "currentAssets": "currentAssets",
                "totalAssets": "totalAssets",
                "equity": "equity",
                "ofWhichResult": "ofWhichResult",
                "liabilities": "liabilities",
                "totalEquityAndLiabilities": "totalEquityAndLiabilities",
                "balanced": true
              },
              "profitLoss": {
                "fromDate": "fromDate",
                "toDate": "toDate",
                "revenue": "revenue",
                "expenses": "expenses",
                "netResult": "netResult"
              },
              "balanceSheetDetail": {
                "nonCurrentAssets": {
                  "intangible": "intangible",
                  "tangible": "tangible",
                  "financial": "financial",
                  "other": "other",
                  "total": "total"
                },
                "currentAssets": {
                  "inventories": "inventories",
                  "receivables": "receivables",
                  "otherCurrent": "otherCurrent",
                  "cash": "cash",
                  "total": "total"
                },
                "equity": {
                  "capital": "capital",
                  "reserves": "reserves",
                  "retainedEarnings": "retainedEarnings",
                  "otherEquity": "otherEquity",
                  "periodResult": "periodResult",
                  "total": "total"
                },
                "liabilities": {
                  "nonCurrent": "nonCurrent",
                  "current": "current",
                  "other": "other",
                  "total": "total"
                }
              },
              "profitLossDetail": {
                "salesRevenue": "salesRevenue",
                "costOfSales": "costOfSales",
                "grossProfit": "grossProfit",
                "sellingExpenses": "sellingExpenses",
                "adminExpenses": "adminExpenses",
                "operatingProfit": "operatingProfit",
                "otherActivityResult": "otherActivityResult",
                "financialActivityResult": "financialActivityResult",
                "profitBeforeTax": "profitBeforeTax",
                "incomeTax": "incomeTax",
                "netProfit": "netProfit"
              },
              "equityChanges": [
                {
                  "code": "code",
                  "name": "name",
                  "opening": "opening",
                  "increase": "increase",
                  "decrease": "decrease",
                  "closing": "closing"
                }
              ],
              "cashFlow": {
                "openingCash": "openingCash",
                "operating": "operating",
                "investing": "investing",
                "financing": "financing",
                "netChange": "netChange",
                "closingCash": "closingCash"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/financial-statements")
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

        var response = await Client.Reports.PostV1ReportsFinancialStatementsAsync(
            new PostV1ReportsFinancialStatementsRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
