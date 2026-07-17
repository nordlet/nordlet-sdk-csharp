using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsStockMovementTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate",
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

        var response = await Client.Reports.PostV1ReportsStockMovementAsync(
            new PostV1ReportsStockMovementRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
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
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate",
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

        var response = await Client.Reports.PostV1ReportsStockMovementAsync(
            new PostV1ReportsStockMovementRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
