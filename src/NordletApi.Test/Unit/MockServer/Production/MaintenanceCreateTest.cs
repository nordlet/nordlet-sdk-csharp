using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MaintenanceCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "workCenterId": "x",
              "type": "preventive",
              "plannedDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "workCenterId": "x",
              "type": "preventive",
              "status": "planned",
              "plannedDate": "2023-01-15",
              "completedDate": "2023-01-15",
              "description": "description",
              "downtimeHours": "downtimeHours",
              "cost": "cost",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/maintenance/create")
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

        var response = await Client.Production.MaintenanceCreateAsync(
            new MaintenanceCreateProductionRequest
            {
                WorkCenterId = "x",
                Type = MaintenanceCreateProductionRequestType.Preventive,
                PlannedDate = new DateOnly(2023, 1, 15),
                Description = null,
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
              "workCenterId": "workCenterId",
              "type": "preventive",
              "plannedDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "workCenterId": "workCenterId",
              "type": "preventive",
              "status": "planned",
              "plannedDate": "2026-07-01",
              "completedDate": "2026-07-01",
              "description": "description",
              "downtimeHours": "downtimeHours",
              "cost": "cost",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/maintenance/create")
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

        var response = await Client.Production.MaintenanceCreateAsync(
            new MaintenanceCreateProductionRequest
            {
                WorkCenterId = "workCenterId",
                Type = MaintenanceCreateProductionRequestType.Preventive,
                PlannedDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
