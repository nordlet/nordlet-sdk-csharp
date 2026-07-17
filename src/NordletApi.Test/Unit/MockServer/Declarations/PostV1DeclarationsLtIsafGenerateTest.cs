using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtIsafGenerateTest : BaseMockServerTest
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
              "fileName": "fileName",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000,
                "customers": 1000000,
                "suppliers": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/isaf/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtIsafGenerateAsync(
            new PostV1DeclarationsLtIsafGenerateRequest
            {
                Year = 1000000,
                Month = 1000000,
                DataType = null,
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
              "fileName": "fileName",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000,
                "customers": 1000000,
                "suppliers": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/isaf/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtIsafGenerateAsync(
            new PostV1DeclarationsLtIsafGenerateRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
