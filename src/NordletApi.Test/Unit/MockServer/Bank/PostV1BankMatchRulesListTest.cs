using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankMatchRulesListTest : BaseMockServerTest
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
                  "name": "name",
                  "provider": "provider",
                  "pattern": "pattern",
                  "payoutIdPrefix": "payoutIdPrefix",
                  "bankAccountId": "x",
                  "dateWindowDays": 1000000,
                  "isActive": true,
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "name": "name",
                  "provider": "provider",
                  "pattern": "pattern",
                  "payoutIdPrefix": "payoutIdPrefix",
                  "bankAccountId": "x",
                  "dateWindowDays": 1000000,
                  "isActive": true,
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/match-rules/list")
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

        var response = await Client.Bank.PostV1BankMatchRulesListAsync(
            new PostV1BankMatchRulesListRequest()
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
                  "name": "name",
                  "provider": "provider",
                  "pattern": "pattern",
                  "payoutIdPrefix": "payoutIdPrefix",
                  "bankAccountId": "bankAccountId",
                  "dateWindowDays": 1000000,
                  "isActive": true,
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/match-rules/list")
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

        var response = await Client.Bank.PostV1BankMatchRulesListAsync(
            new PostV1BankMatchRulesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
