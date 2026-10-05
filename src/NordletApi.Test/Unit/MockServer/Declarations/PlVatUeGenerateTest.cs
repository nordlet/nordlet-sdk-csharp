using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PlVatUeGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "nip": "nip",
              "companyName": "companyName",
              "rows": [
                {
                  "section": "C",
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "documents": [
                    "documents",
                    "documents"
                  ]
                },
                {
                  "section": "C",
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "documents": [
                    "documents",
                    "documents"
                  ]
                }
              ],
              "totals": [
                {
                  "section": "C",
                  "counterparties": 1000000,
                  "amount": "amount"
                },
                {
                  "section": "C",
                  "counterparties": 1000000,
                  "amount": "amount"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/vat-ue/generate")
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

        var response = await Client.Declarations.PlVatUeGenerateAsync(
            new PlVatUeGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "nip": "nip",
              "companyName": "companyName",
              "rows": [
                {
                  "section": "C",
                  "countryCode": "countryCode",
                  "vatNumber": "vatNumber",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "documents": [
                    "documents"
                  ]
                }
              ],
              "totals": [
                {
                  "section": "C",
                  "counterparties": 1000000,
                  "amount": "amount"
                }
              ],
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/vat-ue/generate")
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

        var response = await Client.Declarations.PlVatUeGenerateAsync(
            new PlVatUeGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
