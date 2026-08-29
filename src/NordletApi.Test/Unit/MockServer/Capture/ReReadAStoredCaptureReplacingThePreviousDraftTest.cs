using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReReadAStoredCaptureReplacingThePreviousDraftTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "fileId": "x",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "sizeBytes": 1000000,
              "status": "pending",
              "provider": "provider",
              "model": "model",
              "pagesProcessed": 1000000,
              "extraction": {
                "supplier": {
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "countryCode": "countryCode",
                  "iban": "iban"
                },
                "documentNumber": "documentNumber",
                "documentDate": "documentDate",
                "dueDate": "dueDate",
                "currency": "currency",
                "netTotal": "netTotal",
                "vatTotal": "vatTotal",
                "grossTotal": "grossTotal",
                "notes": "notes",
                "lines": [
                  {
                    "description": "description",
                    "quantity": "quantity",
                    "unit": "unit",
                    "unitPriceExclVat": "unitPriceExclVat",
                    "vatRatePercent": "vatRatePercent",
                    "lineNet": "lineNet",
                    "lineVat": "lineVat",
                    "lineGross": "lineGross"
                  },
                  {
                    "description": "description",
                    "quantity": "quantity",
                    "unit": "unit",
                    "unitPriceExclVat": "unitPriceExclVat",
                    "vatRatePercent": "vatRatePercent",
                    "lineNet": "lineNet",
                    "lineVat": "lineVat",
                    "lineGross": "lineGross"
                  }
                ]
              },
              "matchedPartnerId": "x",
              "purchaseInvoiceId": "x",
              "error": "error",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "rawText": "rawText"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/extract")
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

        var response = await Client.Capture.ReReadAStoredCaptureReplacingThePreviousDraftAsync(
            new PostV1CaptureDocumentsExtractRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "fileId": "fileId",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "sizeBytes": 1000000,
              "status": "pending",
              "provider": "provider",
              "model": "model",
              "pagesProcessed": 1000000,
              "extraction": {
                "supplier": {
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "countryCode": "countryCode",
                  "iban": "iban"
                },
                "documentNumber": "documentNumber",
                "documentDate": "documentDate",
                "dueDate": "dueDate",
                "currency": "currency",
                "netTotal": "netTotal",
                "vatTotal": "vatTotal",
                "grossTotal": "grossTotal",
                "notes": "notes",
                "lines": [
                  {
                    "description": "description",
                    "quantity": "quantity"
                  }
                ]
              },
              "matchedPartnerId": "matchedPartnerId",
              "purchaseInvoiceId": "purchaseInvoiceId",
              "error": "error",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "rawText": "rawText"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/extract")
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

        var response = await Client.Capture.ReReadAStoredCaptureReplacingThePreviousDraftAsync(
            new PostV1CaptureDocumentsExtractRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
