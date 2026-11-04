using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RefundsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "shiftId": "x",
              "receiptId": "x",
              "lines": [
                {
                  "receiptLineId": "x",
                  "quantity": "quantity"
                },
                {
                  "receiptLineId": "x",
                  "quantity": "quantity"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "shiftId": "x",
              "receiptId": "x",
              "date": "2023-01-15",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cogsTotal": "cogsTotal",
              "journalTransactionId": "x",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "lines": [
                {
                  "id": "x",
                  "receiptLineId": "x",
                  "itemId": "x",
                  "quantity": "quantity",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount",
                  "grossAmount": "grossAmount"
                },
                {
                  "id": "x",
                  "receiptLineId": "x",
                  "itemId": "x",
                  "quantity": "quantity",
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
                    .WithPath("/v1/pos/refunds/create")
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

        var response = await Client.Pos.RefundsCreateAsync(
            new RefundsCreatePosRequest
            {
                ShiftId = "x",
                ReceiptId = "x",
                Date = null,
                Lines = new List<RefundsCreatePosRequestLinesItem>()
                {
                    new RefundsCreatePosRequestLinesItem
                    {
                        ReceiptLineId = "x",
                        Quantity = "quantity",
                    },
                    new RefundsCreatePosRequestLinesItem
                    {
                        ReceiptLineId = "x",
                        Quantity = "quantity",
                    },
                },
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
              "receiptId": "receiptId",
              "lines": [
                {
                  "receiptLineId": "receiptLineId",
                  "quantity": "121.0000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "shiftId": "shiftId",
              "receiptId": "receiptId",
              "date": "2026-07-01",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal",
              "cashAmount": "cashAmount",
              "cogsTotal": "cogsTotal",
              "journalTransactionId": "journalTransactionId",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "lines": [
                {
                  "id": "id",
                  "receiptLineId": "receiptLineId",
                  "itemId": "itemId",
                  "quantity": "quantity",
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
                    .WithPath("/v1/pos/refunds/create")
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

        var response = await Client.Pos.RefundsCreateAsync(
            new RefundsCreatePosRequest
            {
                ShiftId = "shiftId",
                ReceiptId = "receiptId",
                Lines = new List<RefundsCreatePosRequestLinesItem>()
                {
                    new RefundsCreatePosRequestLinesItem
                    {
                        ReceiptLineId = "receiptLineId",
                        Quantity = "121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
