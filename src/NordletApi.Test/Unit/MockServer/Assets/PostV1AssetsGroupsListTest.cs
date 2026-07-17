using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsGroupsListTest : BaseMockServerTest
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
                  "code": "x",
                  "name": "x",
                  "defaultUsefulLifeMonths": 1000000,
                  "assetAccountCode": "x",
                  "depreciationAccountCode": "x",
                  "expenseAccountCode": "6206",
                  "id": "x",
                  "createdAt": "createdAt"
                },
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
                    .WithPath("/v1/assets/groups/list")
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

        var response = await Client.Assets.PostV1AssetsGroupsListAsync(
            new PostV1AssetsGroupsListRequest
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
                  "code": "code",
                  "name": "name",
                  "defaultUsefulLifeMonths": 1000000,
                  "assetAccountCode": "assetAccountCode",
                  "depreciationAccountCode": "depreciationAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "id": "id",
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
                    .WithPath("/v1/assets/groups/list")
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

        var response = await Client.Assets.PostV1AssetsGroupsListAsync(
            new PostV1AssetsGroupsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
