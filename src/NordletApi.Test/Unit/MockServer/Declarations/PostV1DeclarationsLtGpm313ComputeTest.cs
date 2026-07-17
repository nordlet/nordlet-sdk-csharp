using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtGpm313ComputeTest : BaseMockServerTest
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
              "declarationYear": 1000000,
              "declarationMonth": 1000000,
              "runPeriod": {
                "year": 1000000,
                "month": 1000000
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/gpm313/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtGpm313ComputeAsync(
            new PostV1DeclarationsLtGpm313ComputeRequest
            {
                Year = 1000000,
                Month = 1000000,
                PayoutTiming = null,
                PaymentDay = null,
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
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "declarationYear": 1000000,
              "declarationMonth": 1000000,
              "runPeriod": {
                "year": 1000000,
                "month": 1000000
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/gpm313/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtGpm313ComputeAsync(
            new PostV1DeclarationsLtGpm313ComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
