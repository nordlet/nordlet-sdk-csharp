using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PurchasesOrdersListTest : BaseMockServerTest
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
                  "orderDate": "orderDate",
                  "expectedDate": "expectedDate",
                  "warehouseId": "x",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "approvedAt",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "status": "draft",
                  "orderNumber": "orderNumber",
                  "orderDate": "orderDate",
                  "expectedDate": "expectedDate",
                  "warehouseId": "x",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "approvedAt",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Purchases.PostV1PurchasesOrdersListAsync(
            new PostV1PurchasesOrdersListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
                  "orderDate": "orderDate",
                  "expectedDate": "expectedDate",
                  "warehouseId": "warehouseId",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "approvedBy": "approvedBy",
                  "approvedAt": "approvedAt",
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Purchases.PostV1PurchasesOrdersListAsync(
            new PostV1PurchasesOrdersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
