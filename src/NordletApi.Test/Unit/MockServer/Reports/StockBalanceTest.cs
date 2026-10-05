using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockBalanceTest : BaseMockServerTest
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
                  "quantity": "quantity",
                  "value": "value"
                },
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "warehouseId": "x",
                  "quantity": "quantity",
                  "value": "value"
                }
              ],
              "totalValue": "totalValue"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-balance")
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

        var response = await Client.Reports.StockBalanceAsync(
            new StockBalanceReportsRequest { AsOf = new DateOnly(2023, 1, 15), WarehouseId = null }
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
                  "quantity": "quantity",
                  "value": "value"
                }
              ],
              "totalValue": "totalValue"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-balance")
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

        var response = await Client.Reports.StockBalanceAsync(
            new StockBalanceReportsRequest { AsOf = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
