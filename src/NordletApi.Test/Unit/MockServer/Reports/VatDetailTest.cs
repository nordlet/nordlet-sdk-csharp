using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatDetailTest : BaseMockServerTest
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
              "side": "side",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "rows": [
                {
                  "documentId": "x",
                  "documentNumber": "documentNumber",
                  "date": "2023-01-15",
                  "partnerName": "partnerName",
                  "vatRatePercent": "vatRatePercent",
                  "net": "net",
                  "vat": "vat",
                  "gross": "gross"
                },
                {
                  "documentId": "x",
                  "documentNumber": "documentNumber",
                  "date": "2023-01-15",
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

        var response = await Client.Reports.VatDetailAsync(
            new VatDetailReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "side": "side",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "rows": [
                {
                  "documentId": "documentId",
                  "documentNumber": "documentNumber",
                  "date": "2026-07-01",
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

        var response = await Client.Reports.VatDetailAsync(
            new VatDetailReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
