using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuSmeThresholdsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "nationalCapEur": "nationalCapEur",
              "unionTurnoverCapEur": "unionTurnoverCapEur",
              "thresholds": [
                {
                  "countryCode": "countryCode",
                  "currency": "currency",
                  "nationalThreshold": "nationalThreshold",
                  "sectors": [
                    {
                      "label": "label",
                      "amount": "amount",
                      "note": "note"
                    },
                    {
                      "label": "label",
                      "amount": "amount",
                      "note": "note"
                    }
                  ],
                  "intraEuAcquisitionsTrigger": {
                    "amount": "amount",
                    "currency": "currency",
                    "note": "note"
                  },
                  "note": "note",
                  "source": "source"
                },
                {
                  "countryCode": "countryCode",
                  "currency": "currency",
                  "nationalThreshold": "nationalThreshold",
                  "sectors": [
                    {
                      "label": "label",
                      "amount": "amount",
                      "note": "note"
                    },
                    {
                      "label": "label",
                      "amount": "amount",
                      "note": "note"
                    }
                  ],
                  "intraEuAcquisitionsTrigger": {
                    "amount": "amount",
                    "currency": "currency",
                    "note": "note"
                  },
                  "note": "note",
                  "source": "source"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/sme-thresholds/list")
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

        var response = await Client.Declarations.PostV1DeclarationsEuSmeThresholdsListAsync(
            new PostV1DeclarationsEuSmeThresholdsListRequest()
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
              "nationalCapEur": "nationalCapEur",
              "unionTurnoverCapEur": "unionTurnoverCapEur",
              "thresholds": [
                {
                  "countryCode": "countryCode",
                  "currency": "currency",
                  "nationalThreshold": "nationalThreshold",
                  "sectors": [
                    {
                      "label": "label",
                      "amount": "amount"
                    }
                  ],
                  "intraEuAcquisitionsTrigger": {
                    "amount": "amount",
                    "currency": "currency",
                    "note": "note"
                  },
                  "note": "note",
                  "source": "source"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/sme-thresholds/list")
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

        var response = await Client.Declarations.PostV1DeclarationsEuSmeThresholdsListAsync(
            new PostV1DeclarationsEuSmeThresholdsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
