using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtIntrastatObligationTest : BaseMockServerTest
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
              "isVatPayer": true,
              "notes": [
                "notes",
                "notes"
              ],
              "thresholds": {
                "arrivalsReporting": "arrivalsReporting",
                "dispatchesReporting": "dispatchesReporting",
                "arrivalsStatistical": "arrivalsStatistical",
                "dispatchesStatistical": "dispatchesStatistical"
              },
              "arrivals": {
                "previousYearValue": "previousYearValue",
                "obligatedFromMonth": 1000000,
                "statisticalValueRequired": true,
                "monthly": [
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  },
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  }
                ]
              },
              "dispatches": {
                "previousYearValue": "previousYearValue",
                "obligatedFromMonth": 1000000,
                "statisticalValueRequired": true,
                "monthly": [
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  },
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/intrastat/obligation")
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

        var response = await Client.Declarations.PostV1DeclarationsLtIntrastatObligationAsync(
            new PostV1DeclarationsLtIntrastatObligationRequest { Year = 1000000 }
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
              "isVatPayer": true,
              "notes": [
                "notes"
              ],
              "thresholds": {
                "arrivalsReporting": "arrivalsReporting",
                "dispatchesReporting": "dispatchesReporting",
                "arrivalsStatistical": "arrivalsStatistical",
                "dispatchesStatistical": "dispatchesStatistical"
              },
              "arrivals": {
                "previousYearValue": "previousYearValue",
                "obligatedFromMonth": 1000000,
                "statisticalValueRequired": true,
                "monthly": [
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  }
                ]
              },
              "dispatches": {
                "previousYearValue": "previousYearValue",
                "obligatedFromMonth": 1000000,
                "statisticalValueRequired": true,
                "monthly": [
                  {
                    "month": 1000000,
                    "value": "value",
                    "cumulative": "cumulative"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/intrastat/obligation")
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

        var response = await Client.Declarations.PostV1DeclarationsLtIntrastatObligationAsync(
            new PostV1DeclarationsLtIntrastatObligationRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
