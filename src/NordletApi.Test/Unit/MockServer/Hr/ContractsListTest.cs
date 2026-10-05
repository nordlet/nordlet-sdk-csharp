using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ContractsListTest : BaseMockServerTest
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
                },
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
                    .WithPath("/v1/hr/contracts/list")
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

        var response = await Client.Hr.ContractsListAsync(
            new ContractsListHrRequest
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
                    .WithPath("/v1/hr/contracts/list")
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

        var response = await Client.Hr.ContractsListAsync(new ContractsListHrRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
