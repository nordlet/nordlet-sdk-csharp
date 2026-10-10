using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EuDac7PreviewTest : BaseMockServerTest
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
              "country": "country",
              "system": "system",
              "sendsDirectly": true,
              "messageTypeIndic": "messageTypeIndic",
              "currency": "currency",
              "sellers": [
                {
                  "sellerId": "sellerId",
                  "name": "name",
                  "reportable": true,
                  "reason": "reason",
                  "consideration": "consideration",
                  "activities": 1000000,
                  "warnings": [
                    "warnings",
                    "warnings"
                  ]
                },
                {
                  "sellerId": "sellerId",
                  "name": "name",
                  "reportable": true,
                  "reason": "reason",
                  "consideration": "consideration",
                  "activities": 1000000,
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
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/dac7/preview")
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

        var response = await Client.Declarations.EuDac7PreviewAsync(
            new EuDac7PreviewDeclarationsRequest { Year = 1000000 }
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
              "country": "country",
              "system": "system",
              "sendsDirectly": true,
              "messageTypeIndic": "messageTypeIndic",
              "currency": "currency",
              "sellers": [
                {
                  "sellerId": "sellerId",
                  "name": "name",
                  "reportable": true,
                  "reason": "reason",
                  "consideration": "consideration",
                  "activities": 1000000,
                  "warnings": [
                    "warnings"
                  ]
                }
              ],
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/dac7/preview")
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

        var response = await Client.Declarations.EuDac7PreviewAsync(
            new EuDac7PreviewDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
