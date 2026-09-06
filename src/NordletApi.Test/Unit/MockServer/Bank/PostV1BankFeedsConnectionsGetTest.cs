using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankFeedsConnectionsGetTest : BaseMockServerTest
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
              "provider": "provider",
              "aspspName": "aspspName",
              "aspspCountry": "aspspCountry",
              "psuType": "business",
              "status": "pending",
              "reference": "reference",
              "consentExpiresAt": "consentExpiresAt",
              "lastSyncedAt": "lastSyncedAt",
              "error": "error",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "accounts": [
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
                  "lastSyncedAt": "lastSyncedAt"
                },
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
                  "lastSyncedAt": "lastSyncedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/get")
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

        var response = await Client.Bank.PostV1BankFeedsConnectionsGetAsync(
            new PostV1BankFeedsConnectionsGetRequest { Id = "x" }
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
              "provider": "provider",
              "aspspName": "aspspName",
              "aspspCountry": "aspspCountry",
              "psuType": "business",
              "status": "pending",
              "reference": "reference",
              "consentExpiresAt": "consentExpiresAt",
              "lastSyncedAt": "lastSyncedAt",
              "error": "error",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "accounts": [
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
                  "lastSyncedAt": "lastSyncedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/get")
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

        var response = await Client.Bank.PostV1BankFeedsConnectionsGetAsync(
            new PostV1BankFeedsConnectionsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
