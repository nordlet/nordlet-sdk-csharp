using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MtAnnualReturnGenerateTest : BaseMockServerTest
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
              "madeUpTo": "madeUpTo",
              "mbrNumber": "mbrNumber",
              "companyName": "companyName",
              "fileName": "fileName",
              "xml": "xml",
              "pdfFileName": "pdfFileName",
              "pdf": "pdf",
              "formSource": "formSource",
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                },
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "members": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "shares": "shares",
                  "nominalValue": "nominalValue",
                  "shareClass": "shareClass"
                },
                {
                  "name": "name",
                  "identifier": "identifier",
                  "shares": "shares",
                  "nominalValue": "nominalValue",
                  "shareClass": "shareClass"
                }
              ],
              "officers": [
                {
                  "position": "position",
                  "name": "name",
                  "identifier": "identifier"
                },
                {
                  "position": "position",
                  "name": "name",
                  "identifier": "identifier"
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
                    .WithPath("/v1/declarations/mt/annual-return/generate")
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

        var response = await Client.Declarations.MtAnnualReturnGenerateAsync(
            new MtAnnualReturnGenerateDeclarationsRequest { Year = 1000000 }
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
              "madeUpTo": "madeUpTo",
              "mbrNumber": "mbrNumber",
              "companyName": "companyName",
              "fileName": "fileName",
              "xml": "xml",
              "pdfFileName": "pdfFileName",
              "pdf": "pdf",
              "formSource": "formSource",
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "members": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "shares": "shares",
                  "nominalValue": "nominalValue",
                  "shareClass": "shareClass"
                }
              ],
              "officers": [
                {
                  "position": "position",
                  "name": "name",
                  "identifier": "identifier"
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
                    .WithPath("/v1/declarations/mt/annual-return/generate")
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

        var response = await Client.Declarations.MtAnnualReturnGenerateAsync(
            new MtAnnualReturnGenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
