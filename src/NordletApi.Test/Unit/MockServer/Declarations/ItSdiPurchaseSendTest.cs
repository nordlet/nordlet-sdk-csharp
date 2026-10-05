using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItSdiPurchaseSendTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "purchaseInvoiceId": "x"
            }
            """;

        const string mockResponse = """
            {
              "sent": true,
              "system": "system",
              "transport": "bridge",
              "tipoDocumento": "TD16",
              "messageId": "messageId",
              "nationalNumber": "nationalNumber",
              "status": "sent",
              "detail": "detail",
              "fileId": "x",
              "net": "net",
              "vat": "vat",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/sdi/purchase-send")
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

        var response = await Client.Declarations.ItSdiPurchaseSendAsync(
            new ItSdiPurchaseSendDeclarationsRequest
            {
                PurchaseInvoiceId = "x",
                VatRatePercent = null,
                TipoDocumento = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "purchaseInvoiceId": "purchaseInvoiceId"
            }
            """;

        const string mockResponse = """
            {
              "sent": true,
              "system": "system",
              "transport": "bridge",
              "tipoDocumento": "TD16",
              "messageId": "messageId",
              "nationalNumber": "nationalNumber",
              "status": "sent",
              "detail": "detail",
              "fileId": "fileId",
              "net": "net",
              "vat": "vat",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/sdi/purchase-send")
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

        var response = await Client.Declarations.ItSdiPurchaseSendAsync(
            new ItSdiPurchaseSendDeclarationsRequest { PurchaseInvoiceId = "purchaseInvoiceId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
