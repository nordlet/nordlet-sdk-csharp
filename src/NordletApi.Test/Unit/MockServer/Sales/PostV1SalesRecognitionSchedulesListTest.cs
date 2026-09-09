using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesRecognitionSchedulesListTest : BaseMockServerTest
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
                  "scheduleDate": "scheduleDate",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "x",
                  "recognizedAt": "recognizedAt",
                  "sortOrder": 1000000,
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "invoiceId": "x",
                  "invoiceLineId": "x",
                  "method": "point_in_time",
                  "status": "pending",
                  "scheduleDate": "scheduleDate",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "x",
                  "recognizedAt": "recognizedAt",
                  "sortOrder": 1000000,
                  "createdAt": "createdAt"
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

        var response = await Client.Sales.PostV1SalesRecognitionSchedulesListAsync(
            new PostV1SalesRecognitionSchedulesListRequest
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
                  "scheduleDate": "scheduleDate",
                  "description": "description",
                  "amount": "amount",
                  "journalTransactionId": "journalTransactionId",
                  "recognizedAt": "recognizedAt",
                  "sortOrder": 1000000,
                  "createdAt": "createdAt"
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

        var response = await Client.Sales.PostV1SalesRecognitionSchedulesListAsync(
            new PostV1SalesRecognitionSchedulesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
