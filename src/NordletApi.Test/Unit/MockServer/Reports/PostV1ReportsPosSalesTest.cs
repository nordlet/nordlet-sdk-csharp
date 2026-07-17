using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsPosSalesTest : BaseMockServerTest
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
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "reportId": "x",
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross",
                  "cash": "cash",
                  "card": "card",
                  "cogs": "cogs"
                },
                {
                  "reportId": "x",
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross",
                  "cash": "cash",
                  "card": "card",
                  "cogs": "cogs"
                }
              ],
              "byRate": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat"
                },
                {
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat"
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat",
                "gross": "gross",
                "cash": "cash",
                "card": "card",
                "cogs": "cogs"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/pos-sales")
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

        var response = await Client.Reports.PostV1ReportsPosSalesAsync(
            new PostV1ReportsPosSalesRequest { FromDate = "fromDate", ToDate = "toDate" }
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
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "reportId": "reportId",
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross",
                  "cash": "cash",
                  "card": "card",
                  "cogs": "cogs"
                }
              ],
              "byRate": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat"
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat",
                "gross": "gross",
                "cash": "cash",
                "card": "card",
                "cogs": "cogs"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/pos-sales")
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

        var response = await Client.Reports.PostV1ReportsPosSalesAsync(
            new PostV1ReportsPosSalesRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
