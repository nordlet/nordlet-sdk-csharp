using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AssignmentsListTest : BaseMockServerTest
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
                  "vehicleId": "x",
                  "plateNumber": "plateNumber",
                  "employeeId": "x",
                  "employeeName": "employeeName",
                  "fromDate": "2023-01-15",
                  "toDate": "2023-01-15",
                  "privateUse": true,
                  "employerPaysFuel": true,
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "vehicleId": "x",
                  "plateNumber": "plateNumber",
                  "employeeId": "x",
                  "employeeName": "employeeName",
                  "fromDate": "2023-01-15",
                  "toDate": "2023-01-15",
                  "privateUse": true,
                  "employerPaysFuel": true,
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assignments/list")
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

        var response = await Client.Fleet.AssignmentsListAsync(
            new AssignmentsListFleetRequest
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
                  "vehicleId": "vehicleId",
                  "plateNumber": "plateNumber",
                  "employeeId": "employeeId",
                  "employeeName": "employeeName",
                  "fromDate": "2026-07-01",
                  "toDate": "2026-07-01",
                  "privateUse": true,
                  "employerPaysFuel": true,
                  "notes": "notes",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assignments/list")
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

        var response = await Client.Fleet.AssignmentsListAsync(new AssignmentsListFleetRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
