using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsCostCenterActivityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate",
              "costCenterId": "x"
            }
            """;

        const string mockResponse = """
            {
              "costCenter": {
                "id": "x",
                "code": "code",
                "name": "name"
              },
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "debit": "debit",
                  "credit": "credit",
                  "net": "net"
                },
                {
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "debit": "debit",
                  "credit": "credit",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-center-activity")
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

        var response = await Client.Reports.PostV1ReportsCostCenterActivityAsync(
            new PostV1ReportsCostCenterActivityRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                CostCenterId = "x",
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
              "toDate": "toDate",
              "costCenterId": "costCenterId"
            }
            """;

        const string mockResponse = """
            {
              "costCenter": {
                "id": "id",
                "code": "code",
                "name": "name"
              },
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "debit": "debit",
                  "credit": "credit",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/cost-center-activity")
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

        var response = await Client.Reports.PostV1ReportsCostCenterActivityAsync(
            new PostV1ReportsCostCenterActivityRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                CostCenterId = "costCenterId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
