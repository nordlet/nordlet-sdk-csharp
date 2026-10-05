using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecognitionSchedulesListTest : BaseMockServerTest
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
                  "invoiceId": "x",
                  "invoiceLineId": "x",
                  "method": "point_in_time",
                  "status": "pending",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "x",
                  "recognizedAt": "2024-01-15T09:30:00.000Z",
                  "sortOrder": 1000000,
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "invoiceId": "x",
                  "invoiceLineId": "x",
                  "method": "point_in_time",
                  "status": "pending",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "x",
                  "recognizedAt": "2024-01-15T09:30:00.000Z",
                  "sortOrder": 1000000,
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition-schedules/list")
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

        var response = await Client.Sales.RecognitionSchedulesListAsync(
            new RecognitionSchedulesListSalesRequest
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
                  "invoiceId": "invoiceId",
                  "invoiceLineId": "invoiceLineId",
                  "method": "point_in_time",
                  "status": "pending",
                  "scheduleDate": "2026-07-01",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "journalTransactionId",
                  "recognizedAt": "2026-07-01T09:30:00.000Z",
                  "sortOrder": 1000000,
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition-schedules/list")
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

        var response = await Client.Sales.RecognitionSchedulesListAsync(
            new RecognitionSchedulesListSalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
