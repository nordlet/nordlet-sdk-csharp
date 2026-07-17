using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsCostCenterItemsTest : BaseMockServerTest
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
                  "costCenterCode": "costCenterCode",
                  "costCenterName": "costCenterName",
                  "itemName": "itemName",
                  "net": "net"
                },
                {
                  "costCenterCode": "costCenterCode",
                  "costCenterName": "costCenterName",
                  "itemName": "itemName",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-center-items")
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

        var response = await Client.Reports.PostV1ReportsCostCenterItemsAsync(
            new PostV1ReportsCostCenterItemsRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                CostCenterId = null,
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
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "costCenterCode": "costCenterCode",
                  "costCenterName": "costCenterName",
                  "itemName": "itemName",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-center-items")
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

        var response = await Client.Reports.PostV1ReportsCostCenterItemsAsync(
            new PostV1ReportsCostCenterItemsRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
