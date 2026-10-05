using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FeedsConnectionsCompleteTest : BaseMockServerTest
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
              "consentExpiresAt": "2024-01-15T09:30:00.000Z",
              "lastSyncedAt": "2024-01-15T09:30:00.000Z",
              "error": "error",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
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
                  "lastSyncedAt": "2024-01-15T09:30:00.000Z"
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
                  "lastSyncedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Bank.FeedsConnectionsCompleteAsync(
            new FeedsConnectionsCompleteBankRequest { Reference = "x", Code = "x" }
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
              "consentExpiresAt": "2026-07-01T09:30:00.000Z",
              "lastSyncedAt": "2026-07-01T09:30:00.000Z",
              "error": "error",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
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
                  "lastSyncedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Bank.FeedsConnectionsCompleteAsync(
            new FeedsConnectionsCompleteBankRequest { Reference = "reference", Code = "code" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
