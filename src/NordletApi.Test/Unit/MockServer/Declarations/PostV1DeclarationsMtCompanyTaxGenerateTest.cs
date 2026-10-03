using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsMtCompanyTaxGenerateTest : BaseMockServerTest
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
              "yearOfAssessment": 1000000,
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "incomeTaxNumber": "incomeTaxNumber",
              "fileName": "fileName",
              "xml": "xml",
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
              "taxAccounts": [
                {
                  "code": "code",
                  "label": "label",
                  "amount": "amount"
                },
                {
                  "code": "code",
                  "label": "label",
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
                    .WithPath("/v1/declarations/mt/company-tax/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsMtCompanyTaxGenerateAsync(
            new PostV1DeclarationsMtCompanyTaxGenerateRequest { Year = 1000000 }
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
              "yearOfAssessment": 1000000,
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "incomeTaxNumber": "incomeTaxNumber",
              "fileName": "fileName",
              "xml": "xml",
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "taxAccounts": [
                {
                  "code": "code",
                  "label": "label",
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
                    .WithPath("/v1/declarations/mt/company-tax/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsMtCompanyTaxGenerateAsync(
            new PostV1DeclarationsMtCompanyTaxGenerateRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
