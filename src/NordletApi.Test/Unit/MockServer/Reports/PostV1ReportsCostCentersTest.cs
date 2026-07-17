using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsCostCentersTest : BaseMockServerTest
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
                  "costCenterId": "x",
                  "code": "code",
                  "name": "name",
                  "income": "income",
                  "expenses": "expenses",
                  "result": "result"
                },
                {
                  "costCenterId": "x",
                  "code": "code",
                  "name": "name",
                  "income": "income",
                  "expenses": "expenses",
                  "result": "result"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-centers")
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

        var response = await Client.Reports.PostV1ReportsCostCentersAsync(
            new PostV1ReportsCostCentersRequest { FromDate = "fromDate", ToDate = "toDate" }
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
                  "costCenterId": "costCenterId",
                  "code": "code",
                  "name": "name",
                  "income": "income",
                  "expenses": "expenses",
                  "result": "result"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-centers")
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

        var response = await Client.Reports.PostV1ReportsCostCentersAsync(
            new PostV1ReportsCostCentersRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
