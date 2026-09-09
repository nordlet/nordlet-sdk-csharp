using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollRunsListTest : BaseMockServerTest
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
                  "id": "x",
                  "year": 1000000,
                  "month": 1000000,
                  "status": "draft",
                  "grossTotal": "grossTotal",
                  "npdTotal": "npdTotal",
                  "gpmTotal": "gpmTotal",
                  "sodraEmployeeTotal": "sodraEmployeeTotal",
                  "sodraEmployerTotal": "sodraEmployerTotal",
                  "netTotal": "netTotal",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "approvedAt": "approvedAt"
                },
                {
                  "id": "x",
                  "year": 1000000,
                  "month": 1000000,
                  "status": "draft",
                  "grossTotal": "grossTotal",
                  "npdTotal": "npdTotal",
                  "gpmTotal": "gpmTotal",
                  "sodraEmployeeTotal": "sodraEmployeeTotal",
                  "sodraEmployerTotal": "sodraEmployerTotal",
                  "netTotal": "netTotal",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "approvedAt": "approvedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/list")
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

        var response = await Client.Payroll.PostV1PayrollRunsListAsync(
            new PostV1PayrollRunsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
            }
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
                  "id": "id",
                  "year": 1000000,
                  "month": 1000000,
                  "status": "draft",
                  "grossTotal": "grossTotal",
                  "npdTotal": "npdTotal",
                  "gpmTotal": "gpmTotal",
                  "sodraEmployeeTotal": "sodraEmployeeTotal",
                  "sodraEmployerTotal": "sodraEmployerTotal",
                  "netTotal": "netTotal",
                  "journalTransactionId": "journalTransactionId",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "approvedAt": "approvedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/list")
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

        var response = await Client.Payroll.PostV1PayrollRunsListAsync(
            new PostV1PayrollRunsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
