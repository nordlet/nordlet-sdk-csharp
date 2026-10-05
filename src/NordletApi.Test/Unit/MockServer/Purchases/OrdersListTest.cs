using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersListTest : BaseMockServerTest
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
                  "partnerId": "x",
                  "status": "draft",
                  "orderNumber": "orderNumber",
                  "orderDate": "2023-01-15",
                  "expectedDate": "2023-01-15",
                  "warehouseId": "x",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "2024-01-15T09:30:00.000Z",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "status": "draft",
                  "orderNumber": "orderNumber",
                  "orderDate": "2023-01-15",
                  "expectedDate": "2023-01-15",
                  "warehouseId": "x",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "2024-01-15T09:30:00.000Z",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "partnerName": "partnerName"
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
                    .WithPath("/v1/purchases/orders/list")
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

        var response = await Client.Purchases.OrdersListAsync(
            new OrdersListPurchasesRequest
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
                  "partnerId": "partnerId",
                  "status": "draft",
                  "orderNumber": "orderNumber",
                  "orderDate": "2026-07-01",
                  "expectedDate": "2026-07-01",
                  "warehouseId": "warehouseId",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "2026-07-01T09:30:00.000Z",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z",
                  "partnerName": "partnerName"
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
                    .WithPath("/v1/purchases/orders/list")
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

        var response = await Client.Purchases.OrdersListAsync(new OrdersListPurchasesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
