using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReportsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "reportNumber": "x",
              "date": "2023-01-15",
              "vatLines": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                },
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "reportNumber": "reportNumber",
              "date": "2023-01-15",
              "deviceId": "x",
              "warehouseId": "x",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cardAmount": "cardAmount",
              "cogsTotal": "cogsTotal",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "vatLines": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                },
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/reports/create")
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

        var response = await Client.Pos.ReportsCreateAsync(
            new ReportsCreatePosRequest
            {
                ReportNumber = "x",
                Date = new DateOnly(2023, 1, 15),
                DeviceId = null,
                WarehouseId = null,
                VatLines = new List<ReportsCreatePosRequestVatLinesItem>()
                {
                    new ReportsCreatePosRequestVatLinesItem
                    {
                        VatRatePercent = "vatRatePercent",
                        NetAmount = "netAmount",
                        VatAmount = "vatAmount",
                    },
                    new ReportsCreatePosRequestVatLinesItem
                    {
                        VatRatePercent = "vatRatePercent",
                        NetAmount = "netAmount",
                        VatAmount = "vatAmount",
                    },
                },
                CashAmount = null,
                CardAmount = null,
                ItemLines = null,
                CashAccountCode = null,
                CardAccountCode = null,
                RevenueAccountCode = null,
                VatAccountCode = null,
                CogsAccountCode = null,
                InventoryAccountCode = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "reportNumber": "reportNumber",
              "date": "2026-07-01",
              "vatLines": [
                {
                  "vatRatePercent": "121.00",
                  "netAmount": "121.0000",
                  "vatAmount": "121.0000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "reportNumber": "reportNumber",
              "date": "2026-07-01",
              "deviceId": "deviceId",
              "warehouseId": "warehouseId",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cardAmount": "cardAmount",
              "cogsTotal": "cogsTotal",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "vatLines": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/reports/create")
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

        var response = await Client.Pos.ReportsCreateAsync(
            new ReportsCreatePosRequest
            {
                ReportNumber = "reportNumber",
                Date = new DateOnly(2026, 7, 1),
                VatLines = new List<ReportsCreatePosRequestVatLinesItem>()
                {
                    new ReportsCreatePosRequestVatLinesItem
                    {
                        VatRatePercent = "121.00",
                        NetAmount = "121.0000",
                        VatAmount = "121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
