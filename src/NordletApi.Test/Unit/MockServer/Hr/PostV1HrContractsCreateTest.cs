using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrContractsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "startDate": "startDate",
              "baseSalary": "baseSalary"
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
                    .WithPath("/v1/hr/contracts/create")
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

        var response = await Client.Hr.PostV1HrContractsCreateAsync(
            new PostV1HrContractsCreateRequest
            {
                EmployeeId = "x",
                PositionId = null,
                DepartmentId = null,
                ScheduleId = null,
                AgreementId = null,
                ContractNo = null,
                Type = null,
                StartDate = "startDate",
                EndDate = null,
                BaseSalary = "baseSalary",
                SalaryType = null,
                WorkHours = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId",
              "startDate": "startDate",
              "baseSalary": "baseSalary"
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
                    .WithPath("/v1/hr/contracts/create")
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

        var response = await Client.Hr.PostV1HrContractsCreateAsync(
            new PostV1HrContractsCreateRequest
            {
                EmployeeId = "employeeId",
                StartDate = "startDate",
                BaseSalary = "baseSalary",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
