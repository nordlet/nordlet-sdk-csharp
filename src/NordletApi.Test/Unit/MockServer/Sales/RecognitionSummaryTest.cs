using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecognitionSummaryTest : BaseMockServerTest
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
                  "invoiceId": "x",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "x",
                  "lineDescription": "lineDescription",
                  "method": "point_in_time",
                  "deferredTotal": "deferredTotal",
                  "recognizedToDate": "2023-01-15",
                  "remaining": "remaining",
                  "pendingCount": 1000000,
                  "nextScheduleDate": "2023-01-15"
                },
                {
                  "invoiceId": "x",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "x",
                  "lineDescription": "lineDescription",
                  "method": "point_in_time",
                  "deferredTotal": "deferredTotal",
                  "recognizedToDate": "2023-01-15",
                  "remaining": "remaining",
                  "pendingCount": 1000000,
                  "nextScheduleDate": "2023-01-15"
                }
              ],
              "totals": {
                "deferredTotal": "deferredTotal",
                "recognizedToDate": "2023-01-15",
                "remaining": "remaining"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/summary")
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

        var response = await Client.Sales.RecognitionSummaryAsync(
            new RecognitionSummarySalesRequest { InvoiceId = null }
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
                  "invoiceId": "invoiceId",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "invoiceLineId",
                  "lineDescription": "lineDescription",
                  "method": "point_in_time",
                  "deferredTotal": "deferredTotal",
                  "recognizedToDate": "2026-07-01",
                  "remaining": "remaining",
                  "pendingCount": 1000000,
                  "nextScheduleDate": "2026-07-01"
                }
              ],
              "totals": {
                "deferredTotal": "deferredTotal",
                "recognizedToDate": "2026-07-01",
                "remaining": "remaining"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/summary")
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

        var response = await Client.Sales.RecognitionSummaryAsync(
            new RecognitionSummarySalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
