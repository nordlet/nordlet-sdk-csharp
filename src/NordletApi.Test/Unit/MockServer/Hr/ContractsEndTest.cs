using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ContractsEndTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "endDate": "2023-01-15"
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

        var response = await Client.Hr.ContractsEndAsync(
            new ContractsEndHrRequest
            {
                Id = "x",
                EndDate = new DateOnly(2023, 1, 15),
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
              "endDate": "2026-07-01"
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

        var response = await Client.Hr.ContractsEndAsync(
            new ContractsEndHrRequest { Id = "id", EndDate = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
