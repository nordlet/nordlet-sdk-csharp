using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IeRtdGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "taxRegNumber": "taxRegNumber",
              "rows": [
                {
                  "rate": "rate",
                  "label": "label",
                  "supplies": "supplies",
                  "acquisitions": "acquisitions",
                  "purchasesResale": "purchasesResale",
                  "purchasesNonResale": "purchasesNonResale"
                },
                {
                  "rate": "rate",
                  "label": "label",
                  "supplies": "supplies",
                  "acquisitions": "acquisitions",
                  "purchasesResale": "purchasesResale",
                  "purchasesNonResale": "purchasesNonResale"
                }
              ],
              "totals": {
                "supplies": "supplies",
                "acquisitions": "acquisitions",
                "purchasesResale": "purchasesResale",
                "purchasesNonResale": "purchasesNonResale"
              },
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000
              },
              "fileName": "fileName",
              "xml": "xml",
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
                    .WithPath("/v1/declarations/ie/rtd/generate")
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

        var response = await Client.Declarations.IeRtdGenerateAsync(
            new IeRtdGenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "taxRegNumber": "taxRegNumber",
              "rows": [
                {
                  "rate": "rate",
                  "label": "label",
                  "supplies": "supplies",
                  "acquisitions": "acquisitions",
                  "purchasesResale": "purchasesResale",
                  "purchasesNonResale": "purchasesNonResale"
                }
              ],
              "totals": {
                "supplies": "supplies",
                "acquisitions": "acquisitions",
                "purchasesResale": "purchasesResale",
                "purchasesNonResale": "purchasesNonResale"
              },
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000
              },
              "fileName": "fileName",
              "xml": "xml",
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
                    .WithPath("/v1/declarations/ie/rtd/generate")
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

        var response = await Client.Declarations.IeRtdGenerateAsync(
            new IeRtdGenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
