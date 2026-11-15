using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatProrataSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000,
              "percent": "percent"
            }
            """;

        const string mockResponse = """
            {
              "fiscalYear": 1000000,
              "percent": "percent"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/set")
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

        var response = await Client.Declarations.VatProrataSetAsync(
            new VatProrataSetDeclarationsRequest { FiscalYear = 1000000, Percent = "percent" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000,
              "percent": "percent"
            }
            """;

        const string mockResponse = """
            {
              "fiscalYear": 1000000,
              "percent": "percent"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/set")
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

        var response = await Client.Declarations.VatProrataSetAsync(
            new VatProrataSetDeclarationsRequest { FiscalYear = 1000000, Percent = "percent" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
