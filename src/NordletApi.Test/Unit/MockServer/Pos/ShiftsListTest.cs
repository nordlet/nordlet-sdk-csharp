using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ShiftsListTest : BaseMockServerTest
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
                  "deviceId": "x",
                  "warehouseId": "x",
                  "status": "open",
                  "openingCash": "openingCash",
                  "countedCash": "countedCash",
                  "receiptCount": 1000000,
                  "reportId": "x",
                  "openedAt": "2024-01-15T09:30:00.000Z",
                  "closedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "deviceId": "x",
                  "warehouseId": "x",
                  "status": "open",
                  "openingCash": "openingCash",
                  "countedCash": "countedCash",
                  "receiptCount": 1000000,
                  "reportId": "x",
                  "openedAt": "2024-01-15T09:30:00.000Z",
                  "closedAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/shifts/list")
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

        var response = await Client.Pos.ShiftsListAsync(
            new ShiftsListPosRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
                  "deviceId": "deviceId",
                  "warehouseId": "warehouseId",
                  "status": "open",
                  "openingCash": "openingCash",
                  "countedCash": "countedCash",
                  "receiptCount": 1000000,
                  "reportId": "reportId",
                  "openedAt": "2026-07-01T09:30:00.000Z",
                  "closedAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/shifts/list")
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

        var response = await Client.Pos.ShiftsListAsync(new ShiftsListPosRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
