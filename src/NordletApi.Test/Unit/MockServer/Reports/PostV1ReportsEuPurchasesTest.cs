using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsEuPurchasesTest : BaseMockServerTest
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
                  "countryCode": "countryCode",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "documents": 1000000
                },
                {
                  "countryCode": "countryCode",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "documents": 1000000
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/eu-purchases")
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

        var response = await Client.Reports.PostV1ReportsEuPurchasesAsync(
            new PostV1ReportsEuPurchasesRequest { FromDate = "fromDate", ToDate = "toDate" }
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
                  "countryCode": "countryCode",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "documents": 1000000
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/eu-purchases")
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

        var response = await Client.Reports.PostV1ReportsEuPurchasesAsync(
            new PostV1ReportsEuPurchasesRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
