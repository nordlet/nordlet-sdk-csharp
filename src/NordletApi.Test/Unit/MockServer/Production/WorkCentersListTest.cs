using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WorkCentersListTest : BaseMockServerTest
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
                  "code": "code",
                  "name": "name",
                  "costPerHour": "costPerHour",
                  "costAccountCode": "costAccountCode",
                  "maintenanceIntervalDays": 1000000,
                  "nextMaintenanceDate": "2023-01-15",
                  "isActive": true,
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "code": "code",
                  "name": "name",
                  "costPerHour": "costPerHour",
                  "costAccountCode": "costAccountCode",
                  "maintenanceIntervalDays": 1000000,
                  "nextMaintenanceDate": "2023-01-15",
                  "isActive": true,
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
                    .WithPath("/v1/production/work-centers/list")
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

        var response = await Client.Production.WorkCentersListAsync(
            new WorkCentersListProductionRequest
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
                  "code": "code",
                  "name": "name",
                  "costPerHour": "costPerHour",
                  "costAccountCode": "costAccountCode",
                  "maintenanceIntervalDays": 1000000,
                  "nextMaintenanceDate": "2026-07-01",
                  "isActive": true,
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
                    .WithPath("/v1/production/work-centers/list")
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

        var response = await Client.Production.WorkCentersListAsync(
            new WorkCentersListProductionRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
