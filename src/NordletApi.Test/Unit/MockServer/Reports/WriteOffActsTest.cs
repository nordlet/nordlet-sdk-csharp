using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WriteOffActsTest : BaseMockServerTest
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
                  "movementId": "x",
                  "date": "2023-01-15",
                  "documentType": "documentType",
                  "itemName": "itemName",
                  "warehouseCode": "warehouseCode",
                  "quantity": "quantity",
                  "totalCost": "totalCost",
                  "notes": "notes"
                },
                {
                  "movementId": "x",
                  "date": "2023-01-15",
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

        var response = await Client.Reports.WriteOffActsAsync(
            new WriteOffActsReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
                  "movementId": "movementId",
                  "date": "2026-07-01",
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

        var response = await Client.Reports.WriteOffActsAsync(
            new WriteOffActsReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
