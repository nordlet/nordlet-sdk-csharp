using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLiLohnlistenGenerateTest : BaseMockServerTest
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
              "fileName": "fileName",
              "content": "content",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "peid": "peid",
                  "name": "name",
                  "vorname": "vorname",
                  "geburtsdatum": "geburtsdatum",
                  "strasse": "strasse",
                  "hausnummer": "hausnummer",
                  "plz": "plz",
                  "ort": "ort",
                  "wohnland": "wohnland",
                  "brutto": "brutto",
                  "lohnsteuer": "lohnsteuer",
                  "abrechnungVon": "abrechnungVon",
                  "abrechnungBis": "abrechnungBis",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "peid": "peid",
                  "name": "name",
                  "vorname": "vorname",
                  "geburtsdatum": "geburtsdatum",
                  "strasse": "strasse",
                  "hausnummer": "hausnummer",
                  "plz": "plz",
                  "ort": "ort",
                  "wohnland": "wohnland",
                  "brutto": "brutto",
                  "lohnsteuer": "lohnsteuer",
                  "abrechnungVon": "abrechnungVon",
                  "abrechnungBis": "abrechnungBis",
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
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/li/lohnlisten/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLiLohnlistenGenerateAsync(
            new PostV1DeclarationsLiLohnlistenGenerateRequest { Year = 1000000 }
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
              "fileName": "fileName",
              "content": "content",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "peid": "peid",
                  "name": "name",
                  "vorname": "vorname",
                  "geburtsdatum": "geburtsdatum",
                  "strasse": "strasse",
                  "hausnummer": "hausnummer",
                  "plz": "plz",
                  "ort": "ort",
                  "wohnland": "wohnland",
                  "brutto": "brutto",
                  "lohnsteuer": "lohnsteuer",
                  "abrechnungVon": "abrechnungVon",
                  "abrechnungBis": "abrechnungBis",
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
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/li/lohnlisten/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLiLohnlistenGenerateAsync(
            new PostV1DeclarationsLiLohnlistenGenerateRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
