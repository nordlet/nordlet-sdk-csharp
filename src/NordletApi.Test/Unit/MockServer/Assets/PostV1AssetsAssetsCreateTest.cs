using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsAssetsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "groupId": "x",
              "code": "x",
              "name": "x",
              "acquisitionDate": "acquisitionDate",
              "acquisitionCost": "acquisitionCost"
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
                    .WithPath("/v1/assets/assets/create")
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

        var response = await Client.Assets.PostV1AssetsAssetsCreateAsync(
            new PostV1AssetsAssetsCreateRequest
            {
                GroupId = "x",
                Code = "x",
                Name = "x",
                AcquisitionDate = "acquisitionDate",
                DepreciationStartDate = null,
                AcquisitionCost = "acquisitionCost",
                SalvageValue = null,
                UsefulLifeMonths = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "groupId": "groupId",
              "code": "code",
              "name": "name",
              "acquisitionDate": "acquisitionDate",
              "acquisitionCost": "acquisitionCost"
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
                    .WithPath("/v1/assets/assets/create")
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

        var response = await Client.Assets.PostV1AssetsAssetsCreateAsync(
            new PostV1AssetsAssetsCreateRequest
            {
                GroupId = "groupId",
                Code = "code",
                Name = "name",
                AcquisitionDate = "acquisitionDate",
                AcquisitionCost = "acquisitionCost",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
