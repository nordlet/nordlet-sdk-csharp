using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceIntrastatThresholdsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "year": 1000000,
                  "arrivalsReporting": "arrivalsReporting",
                  "dispatchesReporting": "dispatchesReporting",
                  "arrivalsStatistical": "arrivalsStatistical",
                  "dispatchesStatistical": "dispatchesStatistical"
                },
                {
                  "year": 1000000,
                  "arrivalsReporting": "arrivalsReporting",
                  "dispatchesReporting": "dispatchesReporting",
                  "arrivalsStatistical": "arrivalsStatistical",
                  "dispatchesStatistical": "dispatchesStatistical"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/intrastat-thresholds/list")
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

        var response = await Client.Reference.PostV1ReferenceIntrastatThresholdsListAsync(
            new PostV1ReferenceIntrastatThresholdsListRequest()
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
              "rows": [
                {
                  "year": 1000000,
                  "arrivalsReporting": "arrivalsReporting",
                  "dispatchesReporting": "dispatchesReporting",
                  "arrivalsStatistical": "arrivalsStatistical",
                  "dispatchesStatistical": "dispatchesStatistical"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/intrastat-thresholds/list")
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

        var response = await Client.Reference.PostV1ReferenceIntrastatThresholdsListAsync(
            new PostV1ReferenceIntrastatThresholdsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
