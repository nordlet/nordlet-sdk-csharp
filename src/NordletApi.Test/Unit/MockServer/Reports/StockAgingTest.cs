using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockAgingTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "asOf": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "asOf": "asOf",
              "rows": [
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "warehouseId": "x",
                  "d0to30Qty": "d0to30Qty",
                  "d0to30Value": "d0to30Value",
                  "d31to60Qty": "d31to60Qty",
                  "d31to60Value": "d31to60Value",
                  "d61to90Qty": "d61to90Qty",
                  "d61to90Value": "d61to90Value",
                  "over90Qty": "over90Qty",
                  "over90Value": "over90Value",
                  "totalQty": "totalQty",
                  "totalValue": "totalValue"
                },
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "warehouseId": "x",
                  "d0to30Qty": "d0to30Qty",
                  "d0to30Value": "d0to30Value",
                  "d31to60Qty": "d31to60Qty",
                  "d31to60Value": "d31to60Value",
                  "d61to90Qty": "d61to90Qty",
                  "d61to90Value": "d61to90Value",
                  "over90Qty": "over90Qty",
                  "over90Value": "over90Value",
                  "totalQty": "totalQty",
                  "totalValue": "totalValue"
                }
              ],
              "totalValue": "totalValue"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-aging")
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

        var response = await Client.Reports.StockAgingAsync(
            new StockAgingReportsRequest { AsOf = new DateOnly(2023, 1, 15), WarehouseId = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "asOf": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "asOf": "asOf",
              "rows": [
                {
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "warehouseId": "warehouseId",
                  "d0to30Qty": "d0to30Qty",
                  "d0to30Value": "d0to30Value",
                  "d31to60Qty": "d31to60Qty",
                  "d31to60Value": "d31to60Value",
                  "d61to90Qty": "d61to90Qty",
                  "d61to90Value": "d61to90Value",
                  "over90Qty": "over90Qty",
                  "over90Value": "over90Value",
                  "totalQty": "totalQty",
                  "totalValue": "totalValue"
                }
              ],
              "totalValue": "totalValue"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-aging")
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

        var response = await Client.Reports.StockAgingAsync(
            new StockAgingReportsRequest { AsOf = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
