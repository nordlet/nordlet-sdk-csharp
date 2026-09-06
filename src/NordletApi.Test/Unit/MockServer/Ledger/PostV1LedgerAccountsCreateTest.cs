using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerAccountsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "x",
              "name": "x",
              "type": "asset"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/accounts/create")
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

        var response = await Client.Ledger.PostV1LedgerAccountsCreateAsync(
            new PostV1LedgerAccountsCreateRequest
            {
                Code = "x",
                Name = "x",
                Translations = null,
                Type = PostV1LedgerAccountsCreateRequestType.Asset,
                ParentId = null,
                IsPostable = null,
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
              "type": "asset"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "code": "code",
              "name": "name",
              "translations": {
                "lt": {
                  "name": "name"
                },
                "en": {
                  "name": "name"
                },
                "ru": {
                  "name": "name"
                }
              },
              "type": "asset",
              "parentId": "parentId",
              "isPostable": true,
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/accounts/create")
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

        var response = await Client.Ledger.PostV1LedgerAccountsCreateAsync(
            new PostV1LedgerAccountsCreateRequest
            {
                Code = "code",
                Name = "name",
                Type = PostV1LedgerAccountsCreateRequestType.Asset,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
