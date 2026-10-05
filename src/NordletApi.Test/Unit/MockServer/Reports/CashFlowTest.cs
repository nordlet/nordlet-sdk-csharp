using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CashFlowTest : BaseMockServerTest
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
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "openingCash": "openingCash",
              "closingCash": "closingCash",
              "netChange": "netChange",
              "operating": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  },
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "investing": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  },
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "financing": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  },
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "balanced": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cash-flow")
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

        var response = await Client.Reports.CashFlowAsync(
            new CashFlowReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "openingCash": "openingCash",
              "closingCash": "closingCash",
              "netChange": "netChange",
              "operating": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "investing": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "financing": {
                "inflow": "inflow",
                "outflow": "outflow",
                "net": "net",
                "rows": [
                  {
                    "code": "code",
                    "name": "name",
                    "inflow": "inflow",
                    "outflow": "outflow"
                  }
                ]
              },
              "balanced": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cash-flow")
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

        var response = await Client.Reports.CashFlowAsync(
            new CashFlowReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
