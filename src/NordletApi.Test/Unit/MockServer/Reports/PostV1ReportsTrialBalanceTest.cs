using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsTrialBalanceTest : BaseMockServerTest
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
                  "accountId": "x",
                  "code": "code",
                  "name": "name",
                  "type": "asset",
                  "opening": "opening",
                  "debit": "debit",
                  "credit": "credit",
                  "closing": "closing"
                },
                {
                  "accountId": "x",
                  "code": "code",
                  "name": "name",
                  "type": "asset",
                  "opening": "opening",
                  "debit": "debit",
                  "credit": "credit",
                  "closing": "closing"
                }
              ],
              "totals": {
                "debit": "debit",
                "credit": "credit"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/trial-balance")
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

        var response = await Client.Reports.PostV1ReportsTrialBalanceAsync(
            new PostV1ReportsTrialBalanceRequest { FromDate = "fromDate", ToDate = "toDate" }
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
                  "accountId": "accountId",
                  "code": "code",
                  "name": "name",
                  "type": "asset",
                  "opening": "opening",
                  "debit": "debit",
                  "credit": "credit",
                  "closing": "closing"
                }
              ],
              "totals": {
                "debit": "debit",
                "credit": "credit"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/trial-balance")
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

        var response = await Client.Reports.PostV1ReportsTrialBalanceAsync(
            new PostV1ReportsTrialBalanceRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
