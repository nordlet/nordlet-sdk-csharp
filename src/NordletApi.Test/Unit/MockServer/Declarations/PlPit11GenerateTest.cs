using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PlPit11GenerateTest : BaseMockServerTest
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
              "source": "source",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "persons": [
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "revenue": "revenue",
                  "deductibleCosts": "deductibleCosts",
                  "advanceWithheld": "advanceWithheld",
                  "socialContributions": "socialContributions",
                  "healthContributions": "healthContributions",
                  "fileName": "fileName",
                  "xml": "xml",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                },
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "revenue": "revenue",
                  "deductibleCosts": "deductibleCosts",
                  "advanceWithheld": "advanceWithheld",
                  "socialContributions": "socialContributions",
                  "healthContributions": "healthContributions",
                  "fileName": "fileName",
                  "xml": "xml",
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/pit-11/generate")
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

        var response = await Client.Declarations.PlPit11GenerateAsync(
            new PlPit11GenerateDeclarationsRequest { Year = 1000000 }
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
              "source": "source",
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "persons": [
                {
                  "employeeId": "employeeId",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "revenue": "revenue",
                  "deductibleCosts": "deductibleCosts",
                  "advanceWithheld": "advanceWithheld",
                  "socialContributions": "socialContributions",
                  "healthContributions": "healthContributions",
                  "fileName": "fileName",
                  "xml": "xml",
                  "warnings": [
                    "warnings"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/pit-11/generate")
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

        var response = await Client.Declarations.PlPit11GenerateAsync(
            new PlPit11GenerateDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
