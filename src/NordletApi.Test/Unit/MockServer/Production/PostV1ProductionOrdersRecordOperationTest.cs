using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionOrdersRecordOperationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "actualMinutes": "actualMinutes"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "routingOperationId": "x",
              "workCenterId": "x",
              "sequence": 1000000,
              "name": "name",
              "plannedMinutes": "plannedMinutes",
              "actualMinutes": "actualMinutes",
              "costPerHour": "costPerHour",
              "cost": "cost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/record-operation")
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

        var response = await Client.Production.PostV1ProductionOrdersRecordOperationAsync(
            new PostV1ProductionOrdersRecordOperationRequest
            {
                Id = "x",
                ActualMinutes = "actualMinutes",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "actualMinutes": "actualMinutes"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "routingOperationId": "routingOperationId",
              "workCenterId": "workCenterId",
              "sequence": 1000000,
              "name": "name",
              "plannedMinutes": "plannedMinutes",
              "actualMinutes": "actualMinutes",
              "costPerHour": "costPerHour",
              "cost": "cost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/record-operation")
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

        var response = await Client.Production.PostV1ProductionOrdersRecordOperationAsync(
            new PostV1ProductionOrdersRecordOperationRequest
            {
                Id = "id",
                ActualMinutes = "actualMinutes",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
