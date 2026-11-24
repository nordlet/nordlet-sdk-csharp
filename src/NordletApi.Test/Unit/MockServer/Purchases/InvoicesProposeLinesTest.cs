using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesProposeLinesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
              "lines": [
                {},
                {}
              ]
            }
            """;

        const string mockResponse = """
            {
              "lines": [
                {
                  "accountCode": "accountCode",
                  "accountReason": "accountReason",
                  "vatClassifierCode": "vatClassifierCode",
                  "vatReason": "vatReason",
                  "vatCandidates": [
                    "vatCandidates",
                    "vatCandidates"
                  ]
                },
                {
                  "accountCode": "accountCode",
                  "accountReason": "accountReason",
                  "vatClassifierCode": "vatClassifierCode",
                  "vatReason": "vatReason",
                  "vatCandidates": [
                    "vatCandidates",
                    "vatCandidates"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/propose-lines")
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

        var response = await Client.Purchases.InvoicesProposeLinesAsync(
            new InvoicesProposeLinesPurchasesRequest
            {
                PartnerId = "x",
                DocumentDate = null,
                Lines = new List<InvoicesProposeLinesPurchasesRequestLinesItem>()
                {
                    new InvoicesProposeLinesPurchasesRequestLinesItem
                    {
                        ItemId = null,
                        VatRatePercent = null,
                        VatAmount = null,
                    },
                    new InvoicesProposeLinesPurchasesRequestLinesItem
                    {
                        ItemId = null,
                        VatRatePercent = null,
                        VatAmount = null,
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
              "partnerId": "partnerId",
              "lines": [
                {}
              ]
            }
            """;

        const string mockResponse = """
            {
              "lines": [
                {
                  "accountCode": "accountCode",
                  "accountReason": "accountReason",
                  "vatClassifierCode": "vatClassifierCode",
                  "vatReason": "vatReason",
                  "vatCandidates": [
                    "vatCandidates"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/invoices/propose-lines")
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

        var response = await Client.Purchases.InvoicesProposeLinesAsync(
            new InvoicesProposeLinesPurchasesRequest
            {
                PartnerId = "partnerId",
                Lines = new List<InvoicesProposeLinesPurchasesRequestLinesItem>()
                {
                    new InvoicesProposeLinesPurchasesRequestLinesItem(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
