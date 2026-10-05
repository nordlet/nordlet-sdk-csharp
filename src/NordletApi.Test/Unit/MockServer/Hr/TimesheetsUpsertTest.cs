using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TimesheetsUpsertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
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
              ]
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
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/upsert")
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

        var response = await Client.Hr.TimesheetsUpsertAsync(
            new TimesheetsUpsertHrRequest
            {
                EmployeeId = "x",
                Year = 1000000,
                Month = 1000000,
                Days = new List<TimesheetsUpsertHrRequestDaysItem>()
                {
                    new TimesheetsUpsertHrRequestDaysItem
                    {
                        Day = 1000000,
                        Hours = "hours",
                        Type = TimesheetsUpsertHrRequestDaysItemType.Work,
                    },
                    new TimesheetsUpsertHrRequestDaysItem
                    {
                        Day = 1000000,
                        Hours = "hours",
                        Type = TimesheetsUpsertHrRequestDaysItemType.Work,
                    },
                },
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
              "month": 1000000,
              "days": [
                {
                  "day": 1000000,
                  "hours": "121.00",
                  "type": "work"
                }
              ]
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
                  "hours": "121.00",
                  "type": "work"
                }
              ],
              "workedDays": "workedDays",
              "workedHours": "workedHours",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/timesheets/upsert")
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

        var response = await Client.Hr.TimesheetsUpsertAsync(
            new TimesheetsUpsertHrRequest
            {
                EmployeeId = "employeeId",
                Year = 1000000,
                Month = 1000000,
                Days = new List<TimesheetsUpsertHrRequestDaysItem>()
                {
                    new TimesheetsUpsertHrRequestDaysItem
                    {
                        Day = 1000000,
                        Hours = "121.00",
                        Type = TimesheetsUpsertHrRequestDaysItemType.Work,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
