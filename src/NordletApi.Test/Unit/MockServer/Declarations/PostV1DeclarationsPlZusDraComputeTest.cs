using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsPlZusDraComputeTest : BaseMockServerTest
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
              "year": 1000000,
              "month": 1000000,
              "source": "source",
              "runStatus": "runStatus",
              "insuredCount": 1000000,
              "rows": [
                {
                  "code": "code",
                  "label": "label",
                  "insured": "insured",
                  "payer": "payer",
                  "total": "total"
                },
                {
                  "code": "code",
                  "label": "label",
                  "insured": "insured",
                  "payer": "payer",
                  "total": "total"
                }
              ],
              "socialTotal": "socialTotal",
              "healthTotal": "healthTotal",
              "fundsTotal": "fundsTotal",
              "total": "total",
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
                    .WithPath("/v1/declarations/pl/zus-dra/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsPlZusDraComputeAsync(
            new PostV1DeclarationsPlZusDraComputeRequest { Year = 1000000, Month = 1000000 }
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
              "year": 1000000,
              "month": 1000000,
              "source": "source",
              "runStatus": "runStatus",
              "insuredCount": 1000000,
              "rows": [
                {
                  "code": "code",
                  "label": "label",
                  "insured": "insured",
                  "payer": "payer",
                  "total": "total"
                }
              ],
              "socialTotal": "socialTotal",
              "healthTotal": "healthTotal",
              "fundsTotal": "fundsTotal",
              "total": "total",
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
                    .WithPath("/v1/declarations/pl/zus-dra/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsPlZusDraComputeAsync(
            new PostV1DeclarationsPlZusDraComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
