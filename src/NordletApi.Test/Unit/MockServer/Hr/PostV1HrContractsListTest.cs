using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrContractsListTest : BaseMockServerTest
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Hr.PostV1HrContractsListAsync(
            new PostV1HrContractsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Hr.PostV1HrContractsListAsync(
            new PostV1HrContractsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
