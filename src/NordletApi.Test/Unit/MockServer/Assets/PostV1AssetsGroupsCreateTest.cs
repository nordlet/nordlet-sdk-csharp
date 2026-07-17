using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsGroupsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "x",
              "name": "x",
              "assetAccountCode": "x",
              "depreciationAccountCode": "x"
            }
            """;

        const string mockResponse = """
            {
              "code": "x",
              "name": "x",
              "defaultUsefulLifeMonths": 1000000,
              "assetAccountCode": "x",
              "depreciationAccountCode": "x",
              "expenseAccountCode": "6206",
              "id": "x",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/groups/create")
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

        var response = await Client.Assets.PostV1AssetsGroupsCreateAsync(
            new PostV1AssetsGroupsCreateRequest
            {
                Code = "x",
                Name = "x",
                DefaultUsefulLifeMonths = null,
                AssetAccountCode = "x",
                DepreciationAccountCode = "x",
                ExpenseAccountCode = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "code": "code",
              "name": "name",
              "assetAccountCode": "assetAccountCode",
              "depreciationAccountCode": "depreciationAccountCode"
            }
            """;

        const string mockResponse = """
            {
              "code": "code",
              "name": "name",
              "defaultUsefulLifeMonths": 1000000,
              "assetAccountCode": "assetAccountCode",
              "depreciationAccountCode": "depreciationAccountCode",
              "expenseAccountCode": "expenseAccountCode",
              "id": "id",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/groups/create")
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

        var response = await Client.Assets.PostV1AssetsGroupsCreateAsync(
            new PostV1AssetsGroupsCreateRequest
            {
                Code = "code",
                Name = "name",
                AssetAccountCode = "assetAccountCode",
                DepreciationAccountCode = "depreciationAccountCode",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
