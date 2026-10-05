using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecognitionComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "asOfDate": "2023-01-15",
              "totalAmount": "totalAmount",
              "rows": [
                {
                  "scheduleId": "x",
                  "invoiceId": "x",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "x",
                  "lineDescription": "lineDescription",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount"
                },
                {
                  "scheduleId": "x",
                  "invoiceId": "x",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "x",
                  "lineDescription": "lineDescription",
                  "scheduleDate": "2023-01-15",
                  "description": "description",
                  "amount": "amount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/compute")
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

        var response = await Client.Sales.RecognitionComputeAsync(
            new RecognitionComputeSalesRequest { AsOfDate = null }
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
              "asOfDate": "2026-07-01",
              "totalAmount": "totalAmount",
              "rows": [
                {
                  "scheduleId": "scheduleId",
                  "invoiceId": "invoiceId",
                  "invoiceFullNumber": "invoiceFullNumber",
                  "invoiceLineId": "invoiceLineId",
                  "lineDescription": "lineDescription",
                  "scheduleDate": "2026-07-01",
                  "description": "description",
                  "amount": "amount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/compute")
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

        var response = await Client.Sales.RecognitionComputeAsync(
            new RecognitionComputeSalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
