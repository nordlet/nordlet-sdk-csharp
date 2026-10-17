using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SecuritiesOperationsListTest : BaseMockServerTest
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
                  "bankAccountId": "x",
                  "kind": "kind",
                  "date": "2023-01-15",
                  "time": "time",
                  "assetCategory": "assetCategory",
                  "symbol": "symbol",
                  "description": "description",
                  "currency": "currency",
                  "quantity": "quantity",
                  "price": "price",
                  "amount": "amount",
                  "fee": "fee",
                  "brokerRealized": "brokerRealized",
                  "code": "code",
                  "fxRate": "fxRate",
                  "cashBase": "cashBase",
                  "costBase": "costBase",
                  "realizedBase": "realizedBase",
                  "status": "posted",
                  "note": "note",
                  "journalTransactionId": "x"
                },
                {
                  "id": "x",
                  "bankAccountId": "x",
                  "kind": "kind",
                  "date": "2023-01-15",
                  "time": "time",
                  "assetCategory": "assetCategory",
                  "symbol": "symbol",
                  "description": "description",
                  "currency": "currency",
                  "quantity": "quantity",
                  "price": "price",
                  "amount": "amount",
                  "fee": "fee",
                  "brokerRealized": "brokerRealized",
                  "code": "code",
                  "fxRate": "fxRate",
                  "cashBase": "cashBase",
                  "costBase": "costBase",
                  "realizedBase": "realizedBase",
                  "status": "posted",
                  "note": "note",
                  "journalTransactionId": "x"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/operations/list")
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

        var response = await Client.Bank.SecuritiesOperationsListAsync(
            new SecuritiesOperationsListBankRequest
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
                  "bankAccountId": "bankAccountId",
                  "kind": "kind",
                  "date": "2026-07-01",
                  "time": "time",
                  "assetCategory": "assetCategory",
                  "symbol": "symbol",
                  "description": "description",
                  "currency": "currency",
                  "quantity": "quantity",
                  "price": "price",
                  "amount": "amount",
                  "fee": "fee",
                  "brokerRealized": "brokerRealized",
                  "code": "code",
                  "fxRate": "fxRate",
                  "cashBase": "cashBase",
                  "costBase": "costBase",
                  "realizedBase": "realizedBase",
                  "status": "posted",
                  "note": "note",
                  "journalTransactionId": "journalTransactionId"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/operations/list")
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

        var response = await Client.Bank.SecuritiesOperationsListAsync(
            new SecuritiesOperationsListBankRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
