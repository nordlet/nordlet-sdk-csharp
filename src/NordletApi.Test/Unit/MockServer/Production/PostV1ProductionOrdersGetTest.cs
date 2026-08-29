using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionOrdersGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "type": "assembly",
              "bomId": "x",
              "warehouseId": "x",
              "routingId": "x",
              "quantity": "quantity",
              "date": "date",
              "status": "draft",
              "scrappedQuantity": "scrappedQuantity",
              "materialCost": "materialCost",
              "laborCost": "laborCost",
              "scrapCost": "scrapCost",
              "totalCost": "totalCost",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "createdAt",
              "operations": [
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
                },
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
              ],
              "qualityChecks": [
                {
                  "id": "x",
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/get")
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

        var response = await Client.Production.PostV1ProductionOrdersGetAsync(
            new PostV1ProductionOrdersGetRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "type": "assembly",
              "bomId": "bomId",
              "warehouseId": "warehouseId",
              "routingId": "routingId",
              "quantity": "quantity",
              "date": "date",
              "status": "draft",
              "scrappedQuantity": "scrappedQuantity",
              "materialCost": "materialCost",
              "laborCost": "laborCost",
              "scrapCost": "scrapCost",
              "totalCost": "totalCost",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "createdAt",
              "operations": [
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
              ],
              "qualityChecks": [
                {
                  "id": "id",
                  "orderId": "orderId",
                  "routingOperationId": "routingOperationId",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/get")
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

        var response = await Client.Production.PostV1ProductionOrdersGetAsync(
            new PostV1ProductionOrdersGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
