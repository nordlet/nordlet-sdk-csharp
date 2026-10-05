using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RefundLiabilityTrueUpTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "invoiceId": "x",
              "estimatedTotal": "estimatedTotal"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "x",
              "estimated": "estimated",
              "consumed": "consumed",
              "remaining": "remaining",
              "delta": "delta",
              "journalTransactionId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/refund-liability/true-up")
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

        var response = await Client.Sales.RefundLiabilityTrueUpAsync(
            new RefundLiabilityTrueUpSalesRequest
            {
                InvoiceId = "x",
                EstimatedTotal = "estimatedTotal",
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
              "invoiceId": "invoiceId",
              "estimatedTotal": "121.0000"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "invoiceId",
              "estimated": "estimated",
              "consumed": "consumed",
              "remaining": "remaining",
              "delta": "delta",
              "journalTransactionId": "journalTransactionId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/refund-liability/true-up")
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

        var response = await Client.Sales.RefundLiabilityTrueUpAsync(
            new RefundLiabilityTrueUpSalesRequest
            {
                InvoiceId = "invoiceId",
                EstimatedTotal = "121.0000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
