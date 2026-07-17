using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsCashFlowTest : BaseMockServerTest
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

        var response = await Client.Reports.PostV1ReportsCashFlowAsync(
            new PostV1ReportsCashFlowRequest { FromDate = "fromDate", ToDate = "toDate" }
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

        var response = await Client.Reports.PostV1ReportsCashFlowAsync(
            new PostV1ReportsCashFlowRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
