using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IeCt1GenerateTest : BaseMockServerTest
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
              "ct1": {
                "fileName": "fileName",
                "xml": "xml"
              },
              "accounts": {
                "fileName": "fileName",
                "xhtml": "xhtml"
              },
              "accountsBlocking": [
                "accountsBlocking",
                "accountsBlocking"
              ],
              "ixbrlMandatory": true,
              "criteria": {
                "balanceSheetTotal": "balanceSheetTotal",
                "turnover": "turnover",
                "averageEmployees": 1.1
              },
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
                    .WithPath("/v1/declarations/ie/ct1/generate")
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

        var response = await Client.Declarations.IeCt1GenerateAsync(
            new IeCt1GenerateDeclarationsRequest { Year = 1000000 }
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
              "ct1": {
                "fileName": "fileName",
                "xml": "xml"
              },
              "accounts": {
                "fileName": "fileName",
                "xhtml": "xhtml"
              },
              "accountsBlocking": [
                "accountsBlocking"
              ],
              "ixbrlMandatory": true,
              "criteria": {
                "balanceSheetTotal": "balanceSheetTotal",
                "turnover": "turnover",
                "averageEmployees": 1.1
              },
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
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
                    .WithPath("/v1/declarations/ie/ct1/generate")
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

        var response = await Client.Declarations.IeCt1GenerateAsync(
            new IeCt1GenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
