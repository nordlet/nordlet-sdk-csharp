using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsStateSalesGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "2023-01-15",
              "to": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "states": [
                {
                  "state": "state",
                  "documents": 1.1,
                  "net": "net"
                },
                {
                  "state": "state",
                  "documents": 1.1,
                  "net": "net"
                }
              ],
              "withoutState": {
                "documents": 1.1,
                "net": "net"
              },
              "outsideUs": {
                "documents": 1.1,
                "net": "net"
              },
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
                    .WithPath("/v1/declarations/us/state-sales/get")
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

        var response = await Client.Declarations.UsStateSalesGetAsync(
            new UsStateSalesGetDeclarationsRequest
            {
                From = new DateOnly(2023, 1, 15),
                To = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "2026-07-01",
              "to": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "states": [
                {
                  "state": "state",
                  "documents": 1.1,
                  "net": "net"
                }
              ],
              "withoutState": {
                "documents": 1.1,
                "net": "net"
              },
              "outsideUs": {
                "documents": 1.1,
                "net": "net"
              },
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/state-sales/get")
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

        var response = await Client.Declarations.UsStateSalesGetAsync(
            new UsStateSalesGetDeclarationsRequest
            {
                From = new DateOnly(2026, 7, 1),
                To = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
