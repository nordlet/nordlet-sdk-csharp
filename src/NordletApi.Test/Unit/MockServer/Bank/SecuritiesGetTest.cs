using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SecuritiesGetTest : BaseMockServerTest
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
              "broker": "broker",
              "brokerAccount": "brokerAccount",
              "period": "period",
              "fileName": "fileName",
              "operationCount": 1000000,
              "duplicateCount": 1000000,
              "postedCount": 1000000,
              "notPostedCount": 1000000,
              "realizedTotal": "realizedTotal",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "operations": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/get")
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

        var response = await Client.Bank.SecuritiesGetAsync(
            new SecuritiesGetBankRequest { Id = "x" }
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
              "broker": "broker",
              "brokerAccount": "brokerAccount",
              "period": "period",
              "fileName": "fileName",
              "operationCount": 1000000,
              "duplicateCount": 1000000,
              "postedCount": 1000000,
              "notPostedCount": 1000000,
              "realizedTotal": "realizedTotal",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "operations": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/get")
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

        var response = await Client.Bank.SecuritiesGetAsync(
            new SecuritiesGetBankRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
