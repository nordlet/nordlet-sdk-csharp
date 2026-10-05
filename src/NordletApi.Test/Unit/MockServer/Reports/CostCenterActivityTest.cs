using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CostCenterActivityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
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
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
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

        var response = await Client.Reports.CostCenterActivityAsync(
            new CostCenterActivityReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
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

        var response = await Client.Reports.CostCenterActivityAsync(
            new CostCenterActivityReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
                CostCenterId = "costCenterId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
