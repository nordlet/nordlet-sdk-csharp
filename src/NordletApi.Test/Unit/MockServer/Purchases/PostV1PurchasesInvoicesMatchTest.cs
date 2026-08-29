using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PurchasesInvoicesMatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "invoiceId": "x"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "x",
              "orderId": "x",
              "status": "matched",
              "rows": [
                {
                  "itemId": "x",
                  "description": "description",
                  "orderedQty": "orderedQty",
                  "receivedQty": "receivedQty",
                  "invoicedQty": "invoicedQty",
                  "orderedUnitPrice": "orderedUnitPrice",
                  "invoicedUnitPrice": "invoicedUnitPrice",
                  "priceVariancePercent": "priceVariancePercent",
                  "status": "matched"
                },
                {
                  "itemId": "x",
                  "description": "description",
                  "orderedQty": "orderedQty",
                  "receivedQty": "receivedQty",
                  "invoicedQty": "invoicedQty",
                  "orderedUnitPrice": "orderedUnitPrice",
                  "invoicedUnitPrice": "invoicedUnitPrice",
                  "priceVariancePercent": "priceVariancePercent",
                  "status": "matched"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/match")
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

        var response = await Client.Purchases.PostV1PurchasesInvoicesMatchAsync(
            new PostV1PurchasesInvoicesMatchRequest
            {
                InvoiceId = "x",
                PriceTolerancePercent = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "invoiceId": "invoiceId"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "invoiceId",
              "orderId": "orderId",
              "status": "matched",
              "rows": [
                {
                  "itemId": "itemId",
                  "description": "description",
                  "orderedQty": "orderedQty",
                  "receivedQty": "receivedQty",
                  "invoicedQty": "invoicedQty",
                  "orderedUnitPrice": "orderedUnitPrice",
                  "invoicedUnitPrice": "invoicedUnitPrice",
                  "priceVariancePercent": "priceVariancePercent",
                  "status": "matched"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/match")
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

        var response = await Client.Purchases.PostV1PurchasesInvoicesMatchAsync(
            new PostV1PurchasesInvoicesMatchRequest { InvoiceId = "invoiceId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
