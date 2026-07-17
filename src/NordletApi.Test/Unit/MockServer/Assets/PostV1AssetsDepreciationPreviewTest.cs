using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsDepreciationPreviewTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "assetId": "x",
                  "code": "code",
                  "name": "name",
                  "amount": "amount",
                  "alreadyPosted": true
                },
                {
                  "assetId": "x",
                  "code": "code",
                  "name": "name",
                  "amount": "amount",
                  "alreadyPosted": true
                }
              ],
              "total": "total"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/depreciation/preview")
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

        var response = await Client.Assets.PostV1AssetsDepreciationPreviewAsync(
            new PostV1AssetsDepreciationPreviewRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "assetId": "assetId",
                  "code": "code",
                  "name": "name",
                  "amount": "amount",
                  "alreadyPosted": true
                }
              ],
              "total": "total"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/depreciation/preview")
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

        var response = await Client.Assets.PostV1AssetsDepreciationPreviewAsync(
            new PostV1AssetsDepreciationPreviewRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
