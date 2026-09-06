using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PurchasesOrdersCancelTest : BaseMockServerTest
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
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "receivedQty": "receivedQty",
                  "remainingQty": "remainingQty",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "x",
                  "projectId": "x",
                  "accountCode": "accountCode",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "receivedQty": "receivedQty",
                  "remainingQty": "remainingQty",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "x",
                  "projectId": "x",
                  "accountCode": "accountCode",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/orders/cancel")
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

        var response = await Client.Purchases.PostV1PurchasesOrdersCancelAsync(
            new PostV1PurchasesOrdersCancelRequest { Id = "x", Reason = null }
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
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "receivedQty": "receivedQty",
                  "remainingQty": "remainingQty",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatClassifierCode": "vatClassifierCode",
                  "costCenterId": "costCenterId",
                  "projectId": "projectId",
                  "accountCode": "accountCode",
                  "lineNet": "lineNet",
                  "lineVat": "lineVat",
                  "lineGross": "lineGross",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/orders/cancel")
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

        var response = await Client.Purchases.PostV1PurchasesOrdersCancelAsync(
            new PostV1PurchasesOrdersCancelRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
