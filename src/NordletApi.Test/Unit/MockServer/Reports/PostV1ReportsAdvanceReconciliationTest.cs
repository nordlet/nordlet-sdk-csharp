using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsAdvanceReconciliationTest : BaseMockServerTest
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
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "opening": "opening",
                  "issued": "issued",
                  "returned": "returned",
                  "closing": "closing"
                },
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "opening": "opening",
                  "issued": "issued",
                  "returned": "returned",
                  "closing": "closing"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/advance-reconciliation")
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

        var response = await Client.Reports.PostV1ReportsAdvanceReconciliationAsync(
            new PostV1ReportsAdvanceReconciliationRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
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
                  "employeeId": "employeeId",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "opening": "opening",
                  "issued": "issued",
                  "returned": "returned",
                  "closing": "closing"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/advance-reconciliation")
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

        var response = await Client.Reports.PostV1ReportsAdvanceReconciliationAsync(
            new PostV1ReportsAdvanceReconciliationRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
