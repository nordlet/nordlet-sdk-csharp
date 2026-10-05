using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Migration;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BooksImportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "cutoverDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "dryRun": true,
              "cutoverDate": "2023-01-15",
              "accounts": {
                "created": 1000000,
                "existing": 1000000
              },
              "partners": {
                "created": 1000000,
                "existing": 1000000
              },
              "items": {
                "created": 1000000,
                "existing": 1000000
              },
              "assetGroups": {
                "created": 1000000,
                "existing": 1000000
              },
              "openingBalances": {
                "journalTransactionId": "journalTransactionId",
                "date": "2023-01-15",
                "entries": 1000000,
                "debitTotal": "debitTotal",
                "creditTotal": "creditTotal",
                "balancingAmount": "balancingAmount"
              },
              "journal": {
                "transactions": 1000000,
                "entries": 1000000
              },
              "openReceivables": {
                "created": 1000000,
                "outstandingTotal": "outstandingTotal"
              },
              "openPayables": {
                "created": 1000000,
                "outstandingTotal": "outstandingTotal"
              },
              "fixedAssets": {
                "created": 1000000,
                "costTotal": "costTotal",
                "accumulatedDepreciationTotal": "accumulatedDepreciationTotal"
              },
              "stock": {
                "movements": 1000000,
                "costTotal": "costTotal"
              },
              "numberSeries": [
                {
                  "prefix": "prefix",
                  "year": 1000000,
                  "nextNumber": 1000000
                },
                {
                  "prefix": "prefix",
                  "year": 1000000,
                  "nextNumber": 1000000
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/migration/books/import")
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

        var response = await Client.Migration.BooksImportAsync(
            new BooksImportMigrationRequest
            {
                CutoverDate = new DateOnly(2023, 1, 15),
                Source = null,
                Accounts = null,
                Partners = null,
                Items = null,
                OpeningBalances = null,
                Journal = null,
                OpenReceivables = null,
                OpenPayables = null,
                AssetGroups = null,
                FixedAssets = null,
                Stock = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "cutoverDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "dryRun": true,
              "cutoverDate": "2026-07-01",
              "accounts": {
                "created": 1000000,
                "existing": 1000000
              },
              "partners": {
                "created": 1000000,
                "existing": 1000000
              },
              "items": {
                "created": 1000000,
                "existing": 1000000
              },
              "assetGroups": {
                "created": 1000000,
                "existing": 1000000
              },
              "openingBalances": {
                "journalTransactionId": "journalTransactionId",
                "date": "2026-07-01",
                "entries": 1000000,
                "debitTotal": "debitTotal",
                "creditTotal": "creditTotal",
                "balancingAmount": "balancingAmount"
              },
              "journal": {
                "transactions": 1000000,
                "entries": 1000000
              },
              "openReceivables": {
                "created": 1000000,
                "outstandingTotal": "outstandingTotal"
              },
              "openPayables": {
                "created": 1000000,
                "outstandingTotal": "outstandingTotal"
              },
              "fixedAssets": {
                "created": 1000000,
                "costTotal": "costTotal",
                "accumulatedDepreciationTotal": "accumulatedDepreciationTotal"
              },
              "stock": {
                "movements": 1000000,
                "costTotal": "costTotal"
              },
              "numberSeries": [
                {
                  "prefix": "prefix",
                  "year": 1000000,
                  "nextNumber": 1000000
                }
              ],
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/migration/books/import")
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

        var response = await Client.Migration.BooksImportAsync(
            new BooksImportMigrationRequest { CutoverDate = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
