using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrTimesheetsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/list")
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

        var response = await Client.Hr.PostV1HrTimesheetsListAsync(
            new PostV1HrTimesheetsListRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/list")
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

        var response = await Client.Hr.PostV1HrTimesheetsListAsync(
            new PostV1HrTimesheetsListRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
