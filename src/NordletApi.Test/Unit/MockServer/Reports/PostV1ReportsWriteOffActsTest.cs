using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsWriteOffActsTest : BaseMockServerTest
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
                  "movementId": "x",
                  "date": "date",
                  "documentType": "documentType",
                  "itemName": "itemName",
                  "warehouseCode": "warehouseCode",
                  "quantity": "quantity",
                  "totalCost": "totalCost",
                  "notes": "notes"
                },
                {
                  "movementId": "x",
                  "date": "date",
                  "documentType": "documentType",
                  "itemName": "itemName",
                  "warehouseCode": "warehouseCode",
                  "quantity": "quantity",
                  "totalCost": "totalCost",
                  "notes": "notes"
                }
              ],
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/write-off-acts")
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

        var response = await Client.Reports.PostV1ReportsWriteOffActsAsync(
            new PostV1ReportsWriteOffActsRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                WarehouseId = null,
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
                  "movementId": "movementId",
                  "date": "date",
                  "documentType": "documentType",
                  "itemName": "itemName",
                  "warehouseCode": "warehouseCode",
                  "quantity": "quantity",
                  "totalCost": "totalCost",
                  "notes": "notes"
                }
              ],
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/write-off-acts")
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

        var response = await Client.Reports.PostV1ReportsWriteOffActsAsync(
            new PostV1ReportsWriteOffActsRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
