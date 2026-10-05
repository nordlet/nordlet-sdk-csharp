using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeReturnsGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "ruleKey": "de-e-bilanz",
              "period": "buzz"
            }
            """;

        const string mockResponse = """
            {
              "ruleKey": "ruleKey",
              "period": "period",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "variant": "variant",
              "content": "content",
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
                    .WithPath("/v1/declarations/de/returns/generate")
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

        var response = await Client.Declarations.DeReturnsGenerateAsync(
            new DeReturnsGenerateDeclarationsRequest
            {
                RuleKey = DeReturnsGenerateDeclarationsRequestRuleKey.DeEBilanz,
                Period = "buzz",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "ruleKey": "de-e-bilanz",
              "period": "period"
            }
            """;

        const string mockResponse = """
            {
              "ruleKey": "ruleKey",
              "period": "period",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "variant": "variant",
              "content": "content",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/returns/generate")
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

        var response = await Client.Declarations.DeReturnsGenerateAsync(
            new DeReturnsGenerateDeclarationsRequest
            {
                RuleKey = DeReturnsGenerateDeclarationsRequestRuleKey.DeEBilanz,
                Period = "period",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
