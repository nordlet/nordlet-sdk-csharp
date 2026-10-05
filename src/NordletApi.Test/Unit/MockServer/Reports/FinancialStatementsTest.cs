using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FinancialStatementsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
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
                "fromDate": "2023-01-15",
                "toDate": "2023-01-15",
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

        var response = await Client.Reports.FinancialStatementsAsync(
            new FinancialStatementsReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
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
                "fromDate": "2026-07-01",
                "toDate": "2026-07-01",
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

        var response = await Client.Reports.FinancialStatementsAsync(
            new FinancialStatementsReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
