using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeBeitragsnachweisGenerateTest : BaseMockServerTest
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
              "fileName": "fileName",
              "content": "content",
              "source": "source",
              "records": [
                {
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "faelligkeitstag": "faelligkeitstag",
                  "kvAllgemein": "kvAllgemein",
                  "kvZusatzbeitrag": "kvZusatzbeitrag",
                  "pauschsteuer": "pauschsteuer",
                  "beitragssatzAllgemein": "beitragssatzAllgemein",
                  "summe": "summe",
                  "positionen": [
                    {
                      "beitragsgruppe": "beitragsgruppe",
                      "betrag": "betrag"
                    },
                    {
                      "beitragsgruppe": "beitragsgruppe",
                      "betrag": "betrag"
                    }
                  ],
                  "record": "record"
                },
                {
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "faelligkeitstag": "faelligkeitstag",
                  "kvAllgemein": "kvAllgemein",
                  "kvZusatzbeitrag": "kvZusatzbeitrag",
                  "pauschsteuer": "pauschsteuer",
                  "beitragssatzAllgemein": "beitragssatzAllgemein",
                  "summe": "summe",
                  "positionen": [
                    {
                      "beitragsgruppe": "beitragsgruppe",
                      "betrag": "betrag"
                    },
                    {
                      "beitragsgruppe": "beitragsgruppe",
                      "betrag": "betrag"
                    }
                  ],
                  "record": "record"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/beitragsnachweis/generate")
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

        var response = await Client.Declarations.DeBeitragsnachweisGenerateAsync(
            new DeBeitragsnachweisGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
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
              "fileName": "fileName",
              "content": "content",
              "source": "source",
              "records": [
                {
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "faelligkeitstag": "faelligkeitstag",
                  "kvAllgemein": "kvAllgemein",
                  "kvZusatzbeitrag": "kvZusatzbeitrag",
                  "pauschsteuer": "pauschsteuer",
                  "beitragssatzAllgemein": "beitragssatzAllgemein",
                  "summe": "summe",
                  "positionen": [
                    {
                      "beitragsgruppe": "beitragsgruppe",
                      "betrag": "betrag"
                    }
                  ],
                  "record": "record"
                }
              ],
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/beitragsnachweis/generate")
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

        var response = await Client.Declarations.DeBeitragsnachweisGenerateAsync(
            new DeBeitragsnachweisGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
