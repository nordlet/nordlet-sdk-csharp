using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerAccountsListTest : BaseMockServerTest
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
                  "code": "code",
                  "name": "name",
                  "translations": {
                    "lt": {
                      "name": "x"
                    },
                    "en": {
                      "name": "x"
                    },
                    "ru": {
                      "name": "x"
                    }
                  },
                  "type": "asset",
                  "parentId": "x",
                  "isPostable": true,
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "code": "code",
                  "name": "name",
                  "translations": {
                    "lt": {
                      "name": "x"
                    },
                    "en": {
                      "name": "x"
                    },
                    "ru": {
                      "name": "x"
                    }
                  },
                  "type": "asset",
                  "parentId": "x",
                  "isPostable": true,
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/ledger/accounts/list")
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

        var response = await Client.Ledger.PostV1LedgerAccountsListAsync(
            new PostV1LedgerAccountsListRequest
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
                  "id": "id",
                  "code": "code",
                  "name": "name",
                  "translations": {},
                  "type": "asset",
                  "parentId": "parentId",
                  "isPostable": true,
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/ledger/accounts/list")
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

        var response = await Client.Ledger.PostV1LedgerAccountsListAsync(
            new PostV1LedgerAccountsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
