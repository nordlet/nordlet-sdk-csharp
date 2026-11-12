using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PeriodChecklistTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "period": "period"
            }
            """;

        const string mockResponse = """
            {
              "period": "period",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "items": [
                {
                  "code": "draft_sale_documents",
                  "count": 1000000,
                  "message": "message",
                  "ids": [
                    "ids",
                    "ids"
                  ]
                },
                {
                  "code": "draft_sale_documents",
                  "count": 1000000,
                  "message": "message",
                  "ids": [
                    "ids",
                    "ids"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/period-checklist")
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

        var response = await Client.Reports.PeriodChecklistAsync(
            new PeriodChecklistReportsRequest { Period = "period" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "period": "period"
            }
            """;

        const string mockResponse = """
            {
              "period": "period",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "items": [
                {
                  "code": "draft_sale_documents",
                  "count": 1000000,
                  "message": "message",
                  "ids": [
                    "ids"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/period-checklist")
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

        var response = await Client.Reports.PeriodChecklistAsync(
            new PeriodChecklistReportsRequest { Period = "period" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
