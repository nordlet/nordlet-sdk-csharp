using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsVatDetailTest : BaseMockServerTest
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
              "side": "side",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "documentId": "x",
                  "documentNumber": "documentNumber",
                  "date": "date",
                  "partnerName": "partnerName",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross"
                },
                {
                  "documentId": "x",
                  "documentNumber": "documentNumber",
                  "date": "date",
                  "partnerName": "partnerName",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross"
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat",
                "gross": "gross"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/vat-detail")
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

        var response = await Client.Reports.PostV1ReportsVatDetailAsync(
            new PostV1ReportsVatDetailRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                Side = null,
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
              "side": "side",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "documentId": "documentId",
                  "documentNumber": "documentNumber",
                  "date": "date",
                  "partnerName": "partnerName",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross"
                }
              ],
              "totals": {
                "net": "net",
                "vat": "vat",
                "gross": "gross"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/vat-detail")
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

        var response = await Client.Reports.PostV1ReportsVatDetailAsync(
            new PostV1ReportsVatDetailRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
