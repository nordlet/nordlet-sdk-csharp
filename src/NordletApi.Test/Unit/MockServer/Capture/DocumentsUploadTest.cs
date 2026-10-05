using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DocumentsUploadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fileName": "x",
              "mimeType": "x",
              "content": "x"
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
                "documentDate": "2023-01-15",
                "dueDate": "2023-01-15",
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
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "rawText": "rawText"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/upload")
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

        var response = await Client.Capture.DocumentsUploadAsync(
            new DocumentsUploadCaptureRequest
            {
                FileName = "x",
                MimeType = "x",
                Content = "x",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fileName": "fileName",
              "mimeType": "mimeType",
              "content": "content"
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
                "documentDate": "2026-07-01",
                "dueDate": "2026-07-01",
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
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "rawText": "rawText"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/capture/documents/upload")
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

        var response = await Client.Capture.DocumentsUploadAsync(
            new DocumentsUploadCaptureRequest
            {
                FileName = "fileName",
                MimeType = "mimeType",
                Content = "content",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
