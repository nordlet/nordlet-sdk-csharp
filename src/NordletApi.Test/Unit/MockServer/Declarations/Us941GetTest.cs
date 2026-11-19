using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class Us941GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "quarter": 1.1,
              "line1": 1.1,
              "line2": "line2",
              "line3": "line3",
              "line4": true,
              "line5a": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5c": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5d": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5e": "line5e",
              "line6": "line6",
              "line7": "line7",
              "line10": "line10",
              "line12": "line12",
              "line13": "line13",
              "line14": "line14",
              "line15": "line15",
              "line16": {
                "months": [
                  {
                    "month": 1.1,
                    "liability": "liability"
                  },
                  {
                    "month": 1.1,
                    "liability": "liability"
                  }
                ],
                "total": "total"
              },
              "scheduleB": [
                {
                  "payDate": "2023-01-15",
                  "liability": "liability"
                },
                {
                  "payDate": "2023-01-15",
                  "liability": "liability"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/941/get")
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

        var response = await Client.Declarations.Us941GetAsync(
            new Us941GetDeclarationsRequest
            {
                Year = 1000000,
                Quarter = 1000000,
                Deposits = null,
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
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "quarter": 1.1,
              "line1": 1.1,
              "line2": "line2",
              "line3": "line3",
              "line4": true,
              "line5a": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5c": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5d": {
                "wages": "wages",
                "tax": "tax"
              },
              "line5e": "line5e",
              "line6": "line6",
              "line7": "line7",
              "line10": "line10",
              "line12": "line12",
              "line13": "line13",
              "line14": "line14",
              "line15": "line15",
              "line16": {
                "months": [
                  {
                    "month": 1.1,
                    "liability": "liability"
                  }
                ],
                "total": "total"
              },
              "scheduleB": [
                {
                  "payDate": "2026-07-01",
                  "liability": "liability"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/941/get")
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

        var response = await Client.Declarations.Us941GetAsync(
            new Us941GetDeclarationsRequest { Year = 1000000, Quarter = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
