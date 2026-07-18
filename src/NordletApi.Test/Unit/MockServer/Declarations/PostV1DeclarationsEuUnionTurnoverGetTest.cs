using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuUnionTurnoverGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "capEur": "capEur",
              "currency": "currency",
              "isVatPayer": true,
              "currentYear": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "previousYear": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "status": "below",
              "headroomAmount": "headroomAmount",
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
                    .WithPath("/v1/declarations/eu/union-turnover/get")
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

        var response = await Client.Declarations.PostV1DeclarationsEuUnionTurnoverGetAsync(
            new PostV1DeclarationsEuUnionTurnoverGetRequest { Date = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "capEur": "capEur",
              "currency": "currency",
              "isVatPayer": true,
              "currentYear": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "previousYear": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "status": "below",
              "headroomAmount": "headroomAmount",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/union-turnover/get")
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

        var response = await Client.Declarations.PostV1DeclarationsEuUnionTurnoverGetAsync(
            new PostV1DeclarationsEuUnionTurnoverGetRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
