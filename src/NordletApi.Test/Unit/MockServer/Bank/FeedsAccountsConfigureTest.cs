using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FeedsAccountsConfigureTest : BaseMockServerTest
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
              "connectionId": "x",
              "bankAccountId": "x",
              "importTemplateId": "x",
              "syncSchedule": "manual",
              "externalId": "externalId",
              "iban": "iban",
              "currency": "currency",
              "name": "name",
              "product": "product",
              "syncFrom": "syncFrom",
              "lastSyncedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/accounts/configure")
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

        var response = await Client.Bank.FeedsAccountsConfigureAsync(
            new FeedsAccountsConfigureBankRequest
            {
                Id = "x",
                ImportTemplateId = null,
                SyncSchedule = null,
            }
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
              "connectionId": "connectionId",
              "bankAccountId": "bankAccountId",
              "importTemplateId": "importTemplateId",
              "syncSchedule": "manual",
              "externalId": "externalId",
              "iban": "iban",
              "currency": "currency",
              "name": "name",
              "product": "product",
              "syncFrom": "syncFrom",
              "lastSyncedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/accounts/configure")
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

        var response = await Client.Bank.FeedsAccountsConfigureAsync(
            new FeedsAccountsConfigureBankRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
