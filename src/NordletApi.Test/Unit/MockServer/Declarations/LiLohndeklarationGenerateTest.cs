using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LiLohndeklarationGenerateTest : BaseMockServerTest
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
                  "versichertennummer": "versichertennummer",
                  "vorname": "vorname",
                  "name": "name",
                  "geschlecht": "geschlecht",
                  "heimatstaat": "heimatstaat",
                  "eintrittsdatum": "eintrittsdatum",
                  "austrittsdatum": "austrittsdatum",
                  "beschaeftigtVon": "beschaeftigtVon",
                  "beschaeftigtBis": "beschaeftigtBis",
                  "beschaeftigungsgrad": "beschaeftigungsgrad",
                  "ahvLohn": "ahvLohn",
                  "alv": "alv",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "versichertennummer": "versichertennummer",
                  "vorname": "vorname",
                  "name": "name",
                  "geschlecht": "geschlecht",
                  "heimatstaat": "heimatstaat",
                  "eintrittsdatum": "eintrittsdatum",
                  "austrittsdatum": "austrittsdatum",
                  "beschaeftigtVon": "beschaeftigtVon",
                  "beschaeftigtBis": "beschaeftigtBis",
                  "beschaeftigungsgrad": "beschaeftigungsgrad",
                  "ahvLohn": "ahvLohn",
                  "alv": "alv",
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
                    .WithPath("/v1/declarations/li/lohndeklaration/generate")
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

        var response = await Client.Declarations.LiLohndeklarationGenerateAsync(
            new LiLohndeklarationGenerateDeclarationsRequest { Year = 1000000 }
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
                  "versichertennummer": "versichertennummer",
                  "vorname": "vorname",
                  "name": "name",
                  "geschlecht": "geschlecht",
                  "heimatstaat": "heimatstaat",
                  "eintrittsdatum": "eintrittsdatum",
                  "austrittsdatum": "austrittsdatum",
                  "beschaeftigtVon": "beschaeftigtVon",
                  "beschaeftigtBis": "beschaeftigtBis",
                  "beschaeftigungsgrad": "beschaeftigungsgrad",
                  "ahvLohn": "ahvLohn",
                  "alv": "alv",
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
                    .WithPath("/v1/declarations/li/lohndeklaration/generate")
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

        var response = await Client.Declarations.LiLohndeklarationGenerateAsync(
            new LiLohndeklarationGenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
