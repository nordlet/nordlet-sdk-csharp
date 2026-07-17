using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsMonthlySummaryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "year": 1000000,
                  "month": 1000000,
                  "receivables": "receivables",
                  "payables": "payables",
                  "revenue": "revenue",
                  "expenses": "expenses",
                  "netResult": "netResult"
                },
                {
                  "year": 1000000,
                  "month": 1000000,
                  "receivables": "receivables",
                  "payables": "payables",
                  "revenue": "revenue",
                  "expenses": "expenses",
                  "netResult": "netResult"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/monthly-summary")
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

        var response = await Client.Reports.PostV1ReportsMonthlySummaryAsync(
            new PostV1ReportsMonthlySummaryRequest { Months = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "year": 1000000,
                  "month": 1000000,
                  "receivables": "receivables",
                  "payables": "payables",
                  "revenue": "revenue",
                  "expenses": "expenses",
                  "netResult": "netResult"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/monthly-summary")
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

        var response = await Client.Reports.PostV1ReportsMonthlySummaryAsync(
            new PostV1ReportsMonthlySummaryRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
