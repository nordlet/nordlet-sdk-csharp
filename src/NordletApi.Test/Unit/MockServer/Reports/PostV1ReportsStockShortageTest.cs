using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsStockShortageTest : BaseMockServerTest
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
                  "itemId": "x",
                  "itemName": "itemName",
                  "warehouseId": "x",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "shortage": "shortage"
                },
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "warehouseId": "x",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "shortage": "shortage"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-shortage")
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

        var response = await Client.Reports.PostV1ReportsStockShortageAsync(
            new PostV1ReportsStockShortageRequest { WarehouseId = null }
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
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "warehouseId": "warehouseId",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "shortage": "shortage"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-shortage")
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

        var response = await Client.Reports.PostV1ReportsStockShortageAsync(
            new PostV1ReportsStockShortageRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
