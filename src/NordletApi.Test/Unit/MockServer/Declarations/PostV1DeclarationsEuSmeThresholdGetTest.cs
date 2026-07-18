using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuSmeThresholdGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "isVatPayer": true,
              "baseCurrency": "baseCurrency",
              "year": 1000000,
              "threshold": {
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
                "note": "note",
                "source": "source"
              },
              "turnover": {
                "amount": "amount",
                "currency": "currency",
                "documents": 1000000
              },
              "precedingTurnover": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "status": "not_applicable",
              "headroomAmount": "headroomAmount",
              "intraEu": {
                "trigger": "trigger",
                "currency": "currency",
                "acquisitionsFromMemberStates": "acquisitionsFromMemberStates",
                "servicesToMemberStates": "servicesToMemberStates",
                "total": "total",
                "status": "below",
                "note": "note"
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
                    .WithPath("/v1/declarations/eu/sme-threshold/get")
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

        var response = await Client.Declarations.PostV1DeclarationsEuSmeThresholdGetAsync(
            new PostV1DeclarationsEuSmeThresholdGetRequest { Date = null }
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
              "countryCode": "countryCode",
              "isVatPayer": true,
              "baseCurrency": "baseCurrency",
              "year": 1000000,
              "threshold": {
                "currency": "currency",
                "nationalThreshold": "nationalThreshold",
                "sectors": [
                  {
                    "label": "label",
                    "amount": "amount"
                  }
                ],
                "note": "note",
                "source": "source"
              },
              "turnover": {
                "amount": "amount",
                "currency": "currency",
                "documents": 1000000
              },
              "precedingTurnover": {
                "year": 1000000,
                "amount": "amount",
                "documents": 1000000
              },
              "status": "not_applicable",
              "headroomAmount": "headroomAmount",
              "intraEu": {
                "trigger": "trigger",
                "currency": "currency",
                "acquisitionsFromMemberStates": "acquisitionsFromMemberStates",
                "servicesToMemberStates": "servicesToMemberStates",
                "total": "total",
                "status": "below",
                "note": "note"
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
                    .WithPath("/v1/declarations/eu/sme-threshold/get")
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

        var response = await Client.Declarations.PostV1DeclarationsEuSmeThresholdGetAsync(
            new PostV1DeclarationsEuSmeThresholdGetRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
