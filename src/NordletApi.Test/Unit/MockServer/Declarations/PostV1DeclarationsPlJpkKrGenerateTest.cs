using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsPlJpkKrGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "dateFrom": "dateFrom",
              "dateTo": "dateTo"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source",
              "counts": {
                "accounts": 1000000,
                "journalRows": 1000000,
                "entryRows": 1000000
              },
              "totals": {
                "operations": "operations",
                "debit": "debit",
                "credit": "credit"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-kr/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsPlJpkKrGenerateAsync(
            new PostV1DeclarationsPlJpkKrGenerateRequest
            {
                DateFrom = "dateFrom",
                DateTo = "dateTo",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "dateFrom": "dateFrom",
              "dateTo": "dateTo"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source",
              "counts": {
                "accounts": 1000000,
                "journalRows": 1000000,
                "entryRows": 1000000
              },
              "totals": {
                "operations": "operations",
                "debit": "debit",
                "credit": "credit"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-kr/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsPlJpkKrGenerateAsync(
            new PostV1DeclarationsPlJpkKrGenerateRequest
            {
                DateFrom = "dateFrom",
                DateTo = "dateTo",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
