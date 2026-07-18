using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesRecognitionModifyTest : BaseMockServerTest
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
              "newEndDate": "newEndDate"
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

        var response = await Client.Sales.PostV1SalesRecognitionModifyAsync(
            new PostV1SalesRecognitionModifyRequest
            {
                InvoiceLineId = "x",
                Approach = PostV1SalesRecognitionModifyRequestApproach.Prospective,
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
              "newEndDate": "newEndDate"
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

        var response = await Client.Sales.PostV1SalesRecognitionModifyAsync(
            new PostV1SalesRecognitionModifyRequest
            {
                InvoiceLineId = "invoiceLineId",
                Approach = PostV1SalesRecognitionModifyRequestApproach.Prospective,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
