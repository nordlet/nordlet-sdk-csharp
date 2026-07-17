using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollRunsApproveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/approve")
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

        var response = await Client.Payroll.PostV1PayrollRunsApproveAsync(
            new PostV1PayrollRunsApproveRequest
            {
                Id = "x",
                WageAccountCode = null,
                EmployerAccountCode = null,
                PayableAccountCode = null,
                GpmAccountCode = null,
                SodraAccountCode = null,
                DeductionAccountCode = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/approve")
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

        var response = await Client.Payroll.PostV1PayrollRunsApproveAsync(
            new PostV1PayrollRunsApproveRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
