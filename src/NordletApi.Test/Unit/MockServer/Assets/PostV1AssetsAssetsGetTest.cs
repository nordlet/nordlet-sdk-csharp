using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsAssetsGetTest : BaseMockServerTest
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
              "id": "x",
              "groupId": "x",
              "code": "code",
              "name": "name",
              "acquisitionDate": "acquisitionDate",
              "depreciationStartDate": "depreciationStartDate",
              "acquisitionCost": "acquisitionCost",
              "salvageValue": "salvageValue",
              "usefulLifeMonths": 1000000,
              "totalCost": "totalCost",
              "accumulatedDepreciation": "accumulatedDepreciation",
              "netBookValue": "netBookValue",
              "depreciatedMonths": 1000000,
              "totalLifeMonths": 1000000,
              "status": "active",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/get")
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

        var response = await Client.Assets.PostV1AssetsAssetsGetAsync(
            new PostV1AssetsAssetsGetRequest { Id = "x" }
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
              "id": "id",
              "groupId": "groupId",
              "code": "code",
              "name": "name",
              "acquisitionDate": "acquisitionDate",
              "depreciationStartDate": "depreciationStartDate",
              "acquisitionCost": "acquisitionCost",
              "salvageValue": "salvageValue",
              "usefulLifeMonths": 1000000,
              "totalCost": "totalCost",
              "accumulatedDepreciation": "accumulatedDepreciation",
              "netBookValue": "netBookValue",
              "depreciatedMonths": 1000000,
              "totalLifeMonths": 1000000,
              "status": "active",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/get")
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

        var response = await Client.Assets.PostV1AssetsAssetsGetAsync(
            new PostV1AssetsAssetsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
