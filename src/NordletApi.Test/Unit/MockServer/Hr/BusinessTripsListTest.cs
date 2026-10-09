using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BusinessTripsListTest : BaseMockServerTest
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
                  "destinationCountryCode": "destinationCountryCode",
                  "purpose": "purpose",
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "days": 1000000,
                  "dailyRate": "dailyRate",
                  "perDiemAmount": "perDiemAmount",
                  "status": "draft",
                  "payrollRunId": "x",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "employeeId": "x",
                  "destinationCountryCode": "destinationCountryCode",
                  "purpose": "purpose",
                  "startDate": "2023-01-15",
                  "endDate": "2023-01-15",
                  "days": 1000000,
                  "dailyRate": "dailyRate",
                  "perDiemAmount": "perDiemAmount",
                  "status": "draft",
                  "payrollRunId": "x",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/hr/business-trips/list")
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

        var response = await Client.Hr.BusinessTripsListAsync(
            new BusinessTripsListHrRequest
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
                  "destinationCountryCode": "destinationCountryCode",
                  "purpose": "purpose",
                  "startDate": "2026-07-01",
                  "endDate": "2026-07-01",
                  "days": 1000000,
                  "dailyRate": "dailyRate",
                  "perDiemAmount": "perDiemAmount",
                  "status": "draft",
                  "payrollRunId": "payrollRunId",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/hr/business-trips/list")
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

        var response = await Client.Hr.BusinessTripsListAsync(new BusinessTripsListHrRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
