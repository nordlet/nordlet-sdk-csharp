using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GroupsListTest : BaseMockServerTest
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
                  "expenseAccountCode": "expenseAccountCode",
                  "id": "x",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "code": "x",
                  "name": "x",
                  "defaultUsefulLifeMonths": 1000000,
                  "assetAccountCode": "x",
                  "depreciationAccountCode": "x",
                  "expenseAccountCode": "expenseAccountCode",
                  "id": "x",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
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

        var response = await Client.Assets.GroupsListAsync(
            new GroupsListAssetsRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
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

        var response = await Client.Assets.GroupsListAsync(new GroupsListAssetsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
