using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Consolidation;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ConsolidationReportTest : BaseMockServerTest
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
              "presentationCurrency": "presentationCurrency",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "category": "micro",
              "statements": {
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
                }
              },
              "trialBalance": [
                {
                  "code": "code",
                  "type": "type",
                  "closing": "closing",
                  "period": "period"
                },
                {
                  "code": "code",
                  "type": "type",
                  "closing": "closing",
                  "period": "period"
                }
              ],
              "nonControllingInterest": {
                "equity": "equity",
                "result": "result"
              },
              "equityMethod": {
                "investmentsInAssociates": "investmentsInAssociates",
                "shareOfAssociatesResult": "shareOfAssociatesResult"
              },
              "members": [
                {
                  "companyId": "x",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full",
                  "fxFactor": "fxFactor",
                  "rateFrom": "rateFrom",
                  "rateTo": "rateTo",
                  "totalAssets": "totalAssets",
                  "netEquity": "netEquity",
                  "periodResult": "periodResult"
                },
                {
                  "companyId": "x",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full",
                  "fxFactor": "fxFactor",
                  "rateFrom": "rateFrom",
                  "rateTo": "rateTo",
                  "totalAssets": "totalAssets",
                  "netEquity": "netEquity",
                  "periodResult": "periodResult"
                }
              ],
              "eliminations": {
                "applied": [
                  {
                    "code": "code",
                    "amount": "amount",
                    "note": "note"
                  },
                  {
                    "code": "code",
                    "amount": "amount",
                    "note": "note"
                  }
                ],
                "balanced": true,
                "net": "net"
              },
              "intercompanyCandidates": [
                {
                  "memberCompanyId": "x",
                  "memberName": "memberName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "x",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code"
                },
                {
                  "memberCompanyId": "x",
                  "memberName": "memberName",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "x",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/report")
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

        var response = await Client.Consolidation.PostV1ConsolidationReportAsync(
            new PostV1ConsolidationReportRequest
            {
                GroupId = "x",
                FromDate = "fromDate",
                ToDate = "toDate",
                Category = null,
                Eliminations = null,
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
              "presentationCurrency": "presentationCurrency",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "category": "micro",
              "statements": {
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
                }
              },
              "trialBalance": [
                {
                  "code": "code",
                  "type": "type",
                  "closing": "closing",
                  "period": "period"
                }
              ],
              "nonControllingInterest": {
                "equity": "equity",
                "result": "result"
              },
              "equityMethod": {
                "investmentsInAssociates": "investmentsInAssociates",
                "shareOfAssociatesResult": "shareOfAssociatesResult"
              },
              "members": [
                {
                  "companyId": "companyId",
                  "name": "name",
                  "baseCurrency": "baseCurrency",
                  "ownershipPercent": "ownershipPercent",
                  "method": "full",
                  "fxFactor": "fxFactor",
                  "rateFrom": "rateFrom",
                  "rateTo": "rateTo",
                  "totalAssets": "totalAssets",
                  "netEquity": "netEquity",
                  "periodResult": "periodResult"
                }
              ],
              "eliminations": {
                "applied": [
                  {
                    "code": "code",
                    "amount": "amount"
                  }
                ],
                "balanced": true,
                "net": "net"
              },
              "intercompanyCandidates": [
                {
                  "memberCompanyId": "memberCompanyId",
                  "memberName": "memberName",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "partnerCode": "partnerCode",
                  "matchesCompanyId": "matchesCompanyId",
                  "matchesCompanyName": "matchesCompanyName",
                  "matchedOn": "code"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/consolidation/report")
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

        var response = await Client.Consolidation.PostV1ConsolidationReportAsync(
            new PostV1ConsolidationReportRequest
            {
                GroupId = "groupId",
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
