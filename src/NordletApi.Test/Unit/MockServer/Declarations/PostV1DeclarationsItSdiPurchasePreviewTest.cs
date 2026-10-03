using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsItSdiPurchasePreviewTest : BaseMockServerTest
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
              "tipoDocumento": "TD16",
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data",
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
                    .WithPath("/v1/declarations/it/sdi/purchase-preview")
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

        var response = await Client.Declarations.PostV1DeclarationsItSdiPurchasePreviewAsync(
            new PostV1DeclarationsItSdiPurchasePreviewRequest
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
              "tipoDocumento": "TD16",
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data",
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
                    .WithPath("/v1/declarations/it/sdi/purchase-preview")
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

        var response = await Client.Declarations.PostV1DeclarationsItSdiPurchasePreviewAsync(
            new PostV1DeclarationsItSdiPurchasePreviewRequest
            {
                PurchaseInvoiceId = "purchaseInvoiceId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
