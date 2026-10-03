using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsIeB1GenerateTest : BaseMockServerTest
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
              "croNumber": "croNumber",
              "companyName": "companyName",
              "annualReturnDate": "annualReturnDate",
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
              "directors": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "appointedOn": "appointedOn"
                },
                {
                  "name": "name",
                  "identifier": "identifier",
                  "appointedOn": "appointedOn"
                }
              ],
              "secretary": {
                "name": "name",
                "identifier": "identifier"
              },
              "members": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "acquisitionDate": "acquisitionDate"
                },
                {
                  "name": "name",
                  "identifier": "identifier",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "acquisitionDate": "acquisitionDate"
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
                    .WithPath("/v1/declarations/ie/b1/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsIeB1GenerateAsync(
            new PostV1DeclarationsIeB1GenerateRequest { Year = 1000000 }
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
              "croNumber": "croNumber",
              "companyName": "companyName",
              "annualReturnDate": "annualReturnDate",
              "fileName": "fileName",
              "xml": "xml",
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "directors": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "appointedOn": "appointedOn"
                }
              ],
              "secretary": {
                "name": "name",
                "identifier": "identifier"
              },
              "members": [
                {
                  "name": "name",
                  "identifier": "identifier",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "acquisitionDate": "acquisitionDate"
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
                    .WithPath("/v1/declarations/ie/b1/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsIeB1GenerateAsync(
            new PostV1DeclarationsIeB1GenerateRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
