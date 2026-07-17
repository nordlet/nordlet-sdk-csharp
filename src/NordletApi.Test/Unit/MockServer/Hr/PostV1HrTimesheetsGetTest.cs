using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrTimesheetsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "employeeName": "employeeName",
              "year": 1000000,
              "month": 1000000,
              "days": [
                {
                  "day": 1000000,
                  "hours": "hours",
                  "type": "work"
                },
                {
                  "day": 1000000,
                  "hours": "hours",
                  "type": "work"
                }
              ],
              "workedDays": "workedDays",
              "workedHours": "workedHours",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/get")
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

        var response = await Client.Hr.PostV1HrTimesheetsGetAsync(
            new PostV1HrTimesheetsGetRequest
            {
                EmployeeId = "x",
                Year = 1000000,
                Month = 1000000,
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
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "employeeName": "employeeName",
              "year": 1000000,
              "month": 1000000,
              "days": [
                {
                  "day": 1000000,
                  "hours": "hours",
                  "type": "work"
                }
              ],
              "workedDays": "workedDays",
              "workedHours": "workedHours",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/get")
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

        var response = await Client.Hr.PostV1HrTimesheetsGetAsync(
            new PostV1HrTimesheetsGetRequest
            {
                EmployeeId = "employeeId",
                Year = 1000000,
                Month = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
