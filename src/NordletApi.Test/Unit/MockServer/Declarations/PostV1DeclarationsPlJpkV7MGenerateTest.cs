using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsPlJpkV7MGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000,
              "kodUrzedu": "kodUrzedu",
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "declaration": [
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
              "counts": {
                "salesRows": 1000000,
                "purchaseRows": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-v7m/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsPlJpkV7MGenerateAsync(
            new PostV1DeclarationsPlJpkV7MGenerateRequest
            {
                Year = 1000000,
                Month = 1000000,
                KodUrzedu = "kodUrzedu",
                Email = "email",
                CelZlozenia = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000,
              "kodUrzedu": "kodUrzedu",
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "declaration": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "counts": {
                "salesRows": 1000000,
                "purchaseRows": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-v7m/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsPlJpkV7MGenerateAsync(
            new PostV1DeclarationsPlJpkV7MGenerateRequest
            {
                Year = 1000000,
                Month = 1000000,
                KodUrzedu = "kodUrzedu",
                Email = "email",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
