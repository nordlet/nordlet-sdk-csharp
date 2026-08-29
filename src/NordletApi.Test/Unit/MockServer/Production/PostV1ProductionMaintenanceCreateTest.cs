using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionMaintenanceCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "workCenterId": "x",
              "type": "preventive",
              "plannedDate": "plannedDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "workCenterId": "x",
              "type": "preventive",
              "status": "planned",
              "plannedDate": "plannedDate",
              "completedDate": "completedDate",
              "description": "description",
              "downtimeHours": "downtimeHours",
              "cost": "cost",
              "notes": "notes",
              "createdAt": "createdAt"
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

        var response = await Client.Production.PostV1ProductionMaintenanceCreateAsync(
            new PostV1ProductionMaintenanceCreateRequest
            {
                WorkCenterId = "x",
                Type = PostV1ProductionMaintenanceCreateRequestType.Preventive,
                PlannedDate = "plannedDate",
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
              "plannedDate": "plannedDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "workCenterId": "workCenterId",
              "type": "preventive",
              "status": "planned",
              "plannedDate": "plannedDate",
              "completedDate": "completedDate",
              "description": "description",
              "downtimeHours": "downtimeHours",
              "cost": "cost",
              "notes": "notes",
              "createdAt": "createdAt"
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

        var response = await Client.Production.PostV1ProductionMaintenanceCreateAsync(
            new PostV1ProductionMaintenanceCreateRequest
            {
                WorkCenterId = "workCenterId",
                Type = PostV1ProductionMaintenanceCreateRequestType.Preventive,
                PlannedDate = "plannedDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
