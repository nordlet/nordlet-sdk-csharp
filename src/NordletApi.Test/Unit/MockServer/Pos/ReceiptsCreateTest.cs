using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiptsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "shiftId": "x",
              "lines": [
                {
                  "quantity": "quantity",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent"
                },
                {
                  "quantity": "quantity",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "shiftId": "x",
              "number": 1000000,
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cardAmount": "cardAmount",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount",
                  "grossAmount": "grossAmount"
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount",
                  "grossAmount": "grossAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/receipts/create")
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

        var response = await Client.Pos.ReceiptsCreateAsync(
            new ReceiptsCreatePosRequest
            {
                ShiftId = "x",
                Lines = new List<ReceiptsCreatePosRequestLinesItem>()
                {
                    new ReceiptsCreatePosRequestLinesItem
                    {
                        ItemId = null,
                        Description = null,
                        Quantity = "quantity",
                        UnitPriceInclVat = "unitPriceInclVat",
                        VatRatePercent = "vatRatePercent",
                    },
                    new ReceiptsCreatePosRequestLinesItem
                    {
                        ItemId = null,
                        Description = null,
                        Quantity = "quantity",
                        UnitPriceInclVat = "unitPriceInclVat",
                        VatRatePercent = "vatRatePercent",
                    },
                },
                CashAmount = null,
                CardAmount = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "shiftId": "shiftId",
              "lines": [
                {
                  "quantity": "121.0000",
                  "unitPriceInclVat": "121.0000",
                  "vatRatePercent": "121.00"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "shiftId": "shiftId",
              "number": 1000000,
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cardAmount": "cardAmount",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceInclVat": "unitPriceInclVat",
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount",
                  "grossAmount": "grossAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/receipts/create")
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

        var response = await Client.Pos.ReceiptsCreateAsync(
            new ReceiptsCreatePosRequest
            {
                ShiftId = "shiftId",
                Lines = new List<ReceiptsCreatePosRequestLinesItem>()
                {
                    new ReceiptsCreatePosRequestLinesItem
                    {
                        Quantity = "121.0000",
                        UnitPriceInclVat = "121.0000",
                        VatRatePercent = "121.00",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
