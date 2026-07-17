using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsStockBalanceTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "asOf": "asOf"
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

        var response = await Client.Reports.PostV1ReportsStockBalanceAsync(
            new PostV1ReportsStockBalanceRequest { AsOf = "asOf", WarehouseId = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "asOf": "asOf"
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

        var response = await Client.Reports.PostV1ReportsStockBalanceAsync(
            new PostV1ReportsStockBalanceRequest { AsOf = "asOf" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
