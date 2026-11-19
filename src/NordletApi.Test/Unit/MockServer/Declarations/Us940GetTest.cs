using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class Us940GetTest : BaseMockServerTest
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
              "year": 1.1,
              "line1a": "line1a",
              "line1b": true,
              "line3": "line3",
              "line4": "line4",
              "line5": "line5",
              "line6": "line6",
              "line7": "line7",
              "line8": "line8",
              "line12": "line12",
              "part5": {
                "line16": [
                  "line16",
                  "line16"
                ],
                "line17": "line17"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/940/get")
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

        var response = await Client.Declarations.Us940GetAsync(
            new Us940GetDeclarationsRequest { Year = 1000000 }
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
              "year": 1.1,
              "line1a": "line1a",
              "line1b": true,
              "line3": "line3",
              "line4": "line4",
              "line5": "line5",
              "line6": "line6",
              "line7": "line7",
              "line8": "line8",
              "line12": "line12",
              "part5": {
                "line16": [
                  "line16"
                ],
                "line17": "line17"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/940/get")
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

        var response = await Client.Declarations.Us940GetAsync(
            new Us940GetDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
