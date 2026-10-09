using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ShiftsCloseTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "countedCash": "countedCash"
            }
            """;

        const string mockResponse = """
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
              "closedAt": "2024-01-15T09:30:00.000Z",
              "expectedCash": "expectedCash",
              "cashDifference": "cashDifference"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/shifts/close")
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

        var response = await Client.Pos.ShiftsCloseAsync(
            new ShiftsClosePosRequest
            {
                Id = "x",
                CountedCash = "countedCash",
                Date = null,
                ReportNumber = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "countedCash": "121.00"
            }
            """;

        const string mockResponse = """
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
              "closedAt": "2026-07-01T09:30:00.000Z",
              "expectedCash": "expectedCash",
              "cashDifference": "cashDifference"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/shifts/close")
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

        var response = await Client.Pos.ShiftsCloseAsync(
            new ShiftsClosePosRequest { Id = "id", CountedCash = "121.00" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
