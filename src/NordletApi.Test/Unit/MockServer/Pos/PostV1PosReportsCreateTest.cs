using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PosReportsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "reportNumber": "x",
              "date": "date",
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
              "date": "date",
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
              "createdAt": "createdAt",
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

        var response = await Client.Pos.PostV1PosReportsCreateAsync(
            new PostV1PosReportsCreateRequest
            {
                ReportNumber = "x",
                Date = "date",
                DeviceId = null,
                WarehouseId = null,
                VatLines = new List<PostV1PosReportsCreateRequestVatLinesItem>()
                {
                    new PostV1PosReportsCreateRequestVatLinesItem
                    {
                        VatRatePercent = "vatRatePercent",
                        NetAmount = "netAmount",
                        VatAmount = "vatAmount",
                    },
                    new PostV1PosReportsCreateRequestVatLinesItem
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
              "date": "date",
              "vatLines": [
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
              "id": "id",
              "reportNumber": "reportNumber",
              "date": "date",
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
              "createdAt": "createdAt",
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

        var response = await Client.Pos.PostV1PosReportsCreateAsync(
            new PostV1PosReportsCreateRequest
            {
                ReportNumber = "reportNumber",
                Date = "date",
                VatLines = new List<PostV1PosReportsCreateRequestVatLinesItem>()
                {
                    new PostV1PosReportsCreateRequestVatLinesItem
                    {
                        VatRatePercent = "vatRatePercent",
                        NetAmount = "netAmount",
                        VatAmount = "vatAmount",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
