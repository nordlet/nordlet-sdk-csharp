using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SubmissionsCorrectionPreviewTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "needed": true,
              "changeCount": 1000000,
              "changes": [
                {
                  "field": "field",
                  "line": 1000000,
                  "filed": "filed",
                  "current": "current"
                },
                {
                  "field": "field",
                  "line": 1000000,
                  "filed": "filed",
                  "current": "current"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/correction-preview")
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

        var response = await Client.Declarations.SubmissionsCorrectionPreviewAsync(
            new SubmissionsCorrectionPreviewDeclarationsRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "needed": true,
              "changeCount": 1000000,
              "changes": [
                {
                  "field": "field",
                  "line": 1000000,
                  "filed": "filed",
                  "current": "current"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/correction-preview")
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

        var response = await Client.Declarations.SubmissionsCorrectionPreviewAsync(
            new SubmissionsCorrectionPreviewDeclarationsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
