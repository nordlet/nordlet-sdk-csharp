using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeDeuevGenerateTest : BaseMockServerTest
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
                  "employeeId": "employeeId",
                  "name": "name",
                  "abgabegrund": "abgabegrund",
                  "versicherungsnummer": "versicherungsnummer",
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "personengruppe": "personengruppe",
                  "beitragsgruppe": "beitragsgruppe",
                  "zeitraumBeginn": "zeitraumBeginn",
                  "zeitraumEnde": "zeitraumEnde",
                  "entgelt": "entgelt",
                  "record": "record",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "abgabegrund": "abgabegrund",
                  "versicherungsnummer": "versicherungsnummer",
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "personengruppe": "personengruppe",
                  "beitragsgruppe": "beitragsgruppe",
                  "zeitraumBeginn": "zeitraumBeginn",
                  "zeitraumEnde": "zeitraumEnde",
                  "entgelt": "entgelt",
                  "record": "record",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
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
                    .WithPath("/v1/declarations/de/deuev/generate")
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

        var response = await Client.Declarations.DeDeuevGenerateAsync(
            new DeDeuevGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
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
                  "employeeId": "employeeId",
                  "name": "name",
                  "abgabegrund": "abgabegrund",
                  "versicherungsnummer": "versicherungsnummer",
                  "betriebsnummerKrankenkasse": "betriebsnummerKrankenkasse",
                  "personengruppe": "personengruppe",
                  "beitragsgruppe": "beitragsgruppe",
                  "zeitraumBeginn": "zeitraumBeginn",
                  "zeitraumEnde": "zeitraumEnde",
                  "entgelt": "entgelt",
                  "record": "record",
                  "warnings": [
                    "warnings"
                  ]
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
                    .WithPath("/v1/declarations/de/deuev/generate")
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

        var response = await Client.Declarations.DeDeuevGenerateAsync(
            new DeDeuevGenerateDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
