using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockMovementTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "rows": [
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "openingQty": "openingQty",
                  "openingValue": "openingValue",
                  "inQty": "inQty",
                  "inValue": "inValue",
                  "outQty": "outQty",
                  "outValue": "outValue",
                  "closingQty": "closingQty",
                  "closingValue": "closingValue"
                },
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "openingQty": "openingQty",
                  "openingValue": "openingValue",
                  "inQty": "inQty",
                  "inValue": "inValue",
                  "outQty": "outQty",
                  "outValue": "outValue",
                  "closingQty": "closingQty",
                  "closingValue": "closingValue"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-movement")
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

        var response = await Client.Reports.StockMovementAsync(
            new StockMovementReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
                WarehouseId = null,
                ItemId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "rows": [
                {
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "openingQty": "openingQty",
                  "openingValue": "openingValue",
                  "inQty": "inQty",
                  "inValue": "inValue",
                  "outQty": "outQty",
                  "outValue": "outValue",
                  "closingQty": "closingQty",
                  "closingValue": "closingValue"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/stock-movement")
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

        var response = await Client.Reports.StockMovementAsync(
            new StockMovementReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
