using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ContractsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "startDate": "2023-01-15",
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
              "startDate": "2023-01-15",
              "endDate": "2023-01-15",
              "endReason": "endReason",
              "baseSalary": "baseSalary",
              "salaryType": "monthly",
              "workHours": "workHours",
              "workHoursUnit": "day",
              "status": "active",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Hr.ContractsCreateAsync(
            new ContractsCreateHrRequest
            {
                EmployeeId = "x",
                PositionId = null,
                DepartmentId = null,
                ScheduleId = null,
                AgreementId = null,
                ContractNo = null,
                Type = null,
                StartDate = new DateOnly(2023, 1, 15),
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
              "startDate": "2026-07-01",
              "baseSalary": "121.0000"
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
              "startDate": "2026-07-01",
              "endDate": "2026-07-01",
              "endReason": "endReason",
              "baseSalary": "baseSalary",
              "salaryType": "monthly",
              "workHours": "workHours",
              "workHoursUnit": "day",
              "status": "active",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Hr.ContractsCreateAsync(
            new ContractsCreateHrRequest
            {
                EmployeeId = "employeeId",
                StartDate = new DateOnly(2026, 7, 1),
                BaseSalary = "121.0000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
