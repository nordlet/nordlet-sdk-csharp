using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SettlementsGetTest : BaseMockServerTest
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
              "bankAccountId": "x",
              "provider": "provider",
              "payoutId": "payoutId",
              "payoutDate": "2023-01-15",
              "currency": "currency",
              "grossTotal": "grossTotal",
              "feeTotal": "feeTotal",
              "netTotal": "netTotal",
              "fxRate": "fxRate",
              "status": "imported",
              "journalTransactionId": "x",
              "bankTransactionId": "x",
              "lineCount": 1000000,
              "matchedCount": 1000000,
              "unmatchedCount": 1000000,
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "lines": [
                {
                  "id": "x",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "2023-01-15",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
                  "commissionPercent": "commissionPercent",
                  "commissionAmount": "commissionAmount",
                  "reference": "reference",
                  "matchedInvoiceId": "x",
                  "matchStatus": "unmatched"
                },
                {
                  "id": "x",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "2023-01-15",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
                  "commissionPercent": "commissionPercent",
                  "commissionAmount": "commissionAmount",
                  "reference": "reference",
                  "matchedInvoiceId": "x",
                  "matchStatus": "unmatched"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/get")
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

        var response = await Client.Bank.SettlementsGetAsync(
            new SettlementsGetBankRequest { Id = "x" }
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
              "bankAccountId": "bankAccountId",
              "provider": "provider",
              "payoutId": "payoutId",
              "payoutDate": "2026-07-01",
              "currency": "currency",
              "grossTotal": "grossTotal",
              "feeTotal": "feeTotal",
              "netTotal": "netTotal",
              "fxRate": "fxRate",
              "status": "imported",
              "journalTransactionId": "journalTransactionId",
              "bankTransactionId": "bankTransactionId",
              "lineCount": 1000000,
              "matchedCount": 1000000,
              "unmatchedCount": 1000000,
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "lines": [
                {
                  "id": "id",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "2026-07-01",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
                  "commissionPercent": "commissionPercent",
                  "commissionAmount": "commissionAmount",
                  "reference": "reference",
                  "matchedInvoiceId": "matchedInvoiceId",
                  "matchStatus": "unmatched"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/get")
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

        var response = await Client.Bank.SettlementsGetAsync(
            new SettlementsGetBankRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
