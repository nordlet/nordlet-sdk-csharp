using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bomId": "x",
              "warehouseId": "x",
              "quantity": "quantity",
              "date": "2023-01-15"
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
              "date": "2023-01-15",
              "status": "draft",
              "scrappedQuantity": "scrappedQuantity",
              "materialCost": "materialCost",
              "laborCost": "laborCost",
              "scrapCost": "scrapCost",
              "totalCost": "totalCost",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
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
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/create")
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

        var response = await Client.Production.OrdersCreateAsync(
            new OrdersCreateProductionRequest
            {
                Type = null,
                BomId = "x",
                WarehouseId = "x",
                RoutingId = null,
                Quantity = "quantity",
                Date = new DateOnly(2023, 1, 15),
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
              "bomId": "bomId",
              "warehouseId": "warehouseId",
              "quantity": "121.0000",
              "date": "2026-07-01"
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
              "date": "2026-07-01",
              "status": "draft",
              "scrappedQuantity": "scrappedQuantity",
              "materialCost": "materialCost",
              "laborCost": "laborCost",
              "scrapCost": "scrapCost",
              "totalCost": "totalCost",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
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
                  "checkedAt": "2026-07-01T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/create")
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

        var response = await Client.Production.OrdersCreateAsync(
            new OrdersCreateProductionRequest
            {
                BomId = "bomId",
                WarehouseId = "warehouseId",
                Quantity = "121.0000",
                Date = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
