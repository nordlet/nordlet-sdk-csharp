using global::System.Globalization;
using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PlKsefReceivedListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "2024-01-15T09:30:00.000Z",
              "to": "2024-01-15T09:30:00.000Z"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ksefReferenceNumber": "ksefReferenceNumber",
                  "invoiceNumber": "invoiceNumber",
                  "issuerNip": "issuerNip",
                  "issueDate": "2023-01-15",
                  "acquisitionTimestamp": "acquisitionTimestamp",
                  "grossAmount": "grossAmount",
                  "purchaseInvoiceId": "x"
                },
                {
                  "ksefReferenceNumber": "ksefReferenceNumber",
                  "invoiceNumber": "invoiceNumber",
                  "issuerNip": "issuerNip",
                  "issueDate": "2023-01-15",
                  "acquisitionTimestamp": "acquisitionTimestamp",
                  "grossAmount": "grossAmount",
                  "purchaseInvoiceId": "x"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/ksef/received/list")
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

        var response = await Client.Declarations.PlKsefReceivedListAsync(
            new PlKsefReceivedListDeclarationsRequest
            {
                From = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                To = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                PageSize = null,
                PageOffset = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "2024-01-15T09:30:00.000Z",
              "to": "2024-01-15T09:30:00.000Z"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ksefReferenceNumber": "ksefReferenceNumber",
                  "invoiceNumber": "invoiceNumber",
                  "issuerNip": "issuerNip",
                  "issueDate": "2026-07-01",
                  "acquisitionTimestamp": "acquisitionTimestamp",
                  "grossAmount": "grossAmount",
                  "purchaseInvoiceId": "purchaseInvoiceId"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/ksef/received/list")
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

        var response = await Client.Declarations.PlKsefReceivedListAsync(
            new PlKsefReceivedListDeclarationsRequest
            {
                From = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                To = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
