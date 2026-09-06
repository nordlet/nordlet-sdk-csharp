using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrContractsEndTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "endDate": "endDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "positionId": "x",
              "departmentId": "x",
              "scheduleId": "x",
              "agreementId": "x",
              "contractNo": "contractNo",
              "type": "permanent",
              "startDate": "startDate",
              "endDate": "endDate",
              "endReason": "endReason",
              "baseSalary": "baseSalary",
              "salaryType": "monthly",
              "workHours": "workHours",
              "workHoursUnit": "day",
              "status": "active",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/contracts/end")
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

        var response = await Client.Hr.PostV1HrContractsEndAsync(
            new PostV1HrContractsEndRequest
            {
                Id = "x",
                EndDate = "endDate",
                EndReason = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "endDate": "endDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "positionId": "positionId",
              "departmentId": "departmentId",
              "scheduleId": "scheduleId",
              "agreementId": "agreementId",
              "contractNo": "contractNo",
              "type": "permanent",
              "startDate": "startDate",
              "endDate": "endDate",
              "endReason": "endReason",
              "baseSalary": "baseSalary",
              "salaryType": "monthly",
              "workHours": "workHours",
              "workHoursUnit": "day",
              "status": "active",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/contracts/end")
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

        var response = await Client.Hr.PostV1HrContractsEndAsync(
            new PostV1HrContractsEndRequest { Id = "id", EndDate = "endDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
