using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecognitionProgressTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "invoiceLineId": "x",
              "percentComplete": "percentComplete"
            }
            """;

        const string mockResponse = """
            {
              "runId": "x",
              "runDate": "2023-01-15",
              "scheduleCount": 1000000,
              "totalAmount": "totalAmount",
              "journalTransactionId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/progress")
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

        var response = await Client.Sales.RecognitionProgressAsync(
            new RecognitionProgressSalesRequest
            {
                InvoiceLineId = "x",
                PercentComplete = "percentComplete",
                Date = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "invoiceLineId": "invoiceLineId",
              "percentComplete": "121.00"
            }
            """;

        const string mockResponse = """
            {
              "runId": "runId",
              "runDate": "2026-07-01",
              "scheduleCount": 1000000,
              "totalAmount": "totalAmount",
              "journalTransactionId": "journalTransactionId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/progress")
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

        var response = await Client.Sales.RecognitionProgressAsync(
            new RecognitionProgressSalesRequest
            {
                InvoiceLineId = "invoiceLineId",
                PercentComplete = "121.00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
