using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankSettlementsGetTest : BaseMockServerTest
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
              "payoutDate": "payoutDate",
              "currency": "currency",
              "grossTotal": "grossTotal",
              "feeTotal": "feeTotal",
              "netTotal": "netTotal",
              "status": "imported",
              "journalTransactionId": "x",
              "lineCount": 1000000,
              "matchedCount": 1000000,
              "unmatchedCount": 1000000,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "x",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "date",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
                  "reference": "reference",
                  "matchedInvoiceId": "x",
                  "matchStatus": "unmatched"
                },
                {
                  "id": "x",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "date",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
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

        var response = await Client.Bank.PostV1BankSettlementsGetAsync(
            new PostV1BankSettlementsGetRequest { Id = "x" }
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
              "payoutDate": "payoutDate",
              "currency": "currency",
              "grossTotal": "grossTotal",
              "feeTotal": "feeTotal",
              "netTotal": "netTotal",
              "status": "imported",
              "journalTransactionId": "journalTransactionId",
              "lineCount": 1000000,
              "matchedCount": 1000000,
              "unmatchedCount": 1000000,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "id",
                  "externalId": "externalId",
                  "category": "category",
                  "date": "date",
                  "gross": "gross",
                  "fee": "fee",
                  "net": "net",
                  "description": "description",
                  "sourceId": "sourceId",
                  "chargeId": "chargeId",
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

        var response = await Client.Bank.PostV1BankSettlementsGetAsync(
            new PostV1BankSettlementsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
