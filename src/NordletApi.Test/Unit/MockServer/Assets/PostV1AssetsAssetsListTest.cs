using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsAssetsListTest : BaseMockServerTest
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
                  "documents": [
                    {
                      "name": "x",
                      "ref": "x"
                    },
                    {
                      "name": "x",
                      "ref": "x"
                    }
                  ],
                  "createdAt": "createdAt"
                },
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
                  "documents": [
                    {
                      "name": "x",
                      "ref": "x"
                    },
                    {
                      "name": "x",
                      "ref": "x"
                    }
                  ],
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/list")
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

        var response = await Client.Assets.PostV1AssetsAssetsListAsync(
            new PostV1AssetsAssetsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
            }
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
                  "documents": [
                    {
                      "name": "name",
                      "ref": "ref"
                    }
                  ],
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/list")
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

        var response = await Client.Assets.PostV1AssetsAssetsListAsync(
            new PostV1AssetsAssetsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
