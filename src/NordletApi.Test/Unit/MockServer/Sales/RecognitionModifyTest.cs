using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecognitionModifyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "invoiceLineId": "x",
              "approach": "prospective"
            }
            """;

        const string mockResponse = """
            {
              "invoiceLineId": "x",
              "approach": "prospective",
              "cancelledCount": 1000000,
              "newPendingCount": 1000000,
              "catchUpAmount": "catchUpAmount",
              "journalTransactionId": "x",
              "newEndDate": "2023-01-15"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/modify")
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

        var response = await Client.Sales.RecognitionModifyAsync(
            new RecognitionModifySalesRequest
            {
                InvoiceLineId = "x",
                Approach = RecognitionModifySalesRequestApproach.Prospective,
                Date = null,
                NewEndDate = null,
                NewMilestones = null,
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
              "approach": "prospective"
            }
            """;

        const string mockResponse = """
            {
              "invoiceLineId": "invoiceLineId",
              "approach": "prospective",
              "cancelledCount": 1000000,
              "newPendingCount": 1000000,
              "catchUpAmount": "catchUpAmount",
              "journalTransactionId": "journalTransactionId",
              "newEndDate": "2026-07-01"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/recognition/modify")
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

        var response = await Client.Sales.RecognitionModifyAsync(
            new RecognitionModifySalesRequest
            {
                InvoiceLineId = "invoiceLineId",
                Approach = RecognitionModifySalesRequestApproach.Prospective,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
