using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesTest
    : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "reference": "x",
              "code": "x"
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
                    .WithPath("/v1/bank/feeds/connections/complete")
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

        var response =
            await Client.Bank.ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesAsync(
                new PostV1BankFeedsConnectionsCompleteRequest { Reference = "x", Code = "x" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "reference": "reference",
              "code": "code"
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
                    .WithPath("/v1/bank/feeds/connections/complete")
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

        var response =
            await Client.Bank.ExchangeTheRedirectCodeForASessionAndStoreTheBankAccountsItExposesAsync(
                new PostV1BankFeedsConnectionsCompleteRequest
                {
                    Reference = "reference",
                    Code = "code",
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
