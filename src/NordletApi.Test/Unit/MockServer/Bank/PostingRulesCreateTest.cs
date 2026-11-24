using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostingRulesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "accountCode": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "counterpartyContains": "counterpartyContains",
              "descriptionContains": "descriptionContains",
              "accountCode": "accountCode",
              "partnerId": "x",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/posting-rules/create")
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

        var response = await Client.Bank.PostingRulesCreateAsync(
            new PostingRulesCreateBankRequest
            {
                CounterpartyContains = null,
                DescriptionContains = null,
                AccountCode = "x",
                PartnerId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "accountCode": "accountCode"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "counterpartyContains": "counterpartyContains",
              "descriptionContains": "descriptionContains",
              "accountCode": "accountCode",
              "partnerId": "partnerId",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/posting-rules/create")
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

        var response = await Client.Bank.PostingRulesCreateAsync(
            new PostingRulesCreateBankRequest { AccountCode = "accountCode" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
