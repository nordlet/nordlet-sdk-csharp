using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankDirectDebitsExportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "saleInvoiceIds": [
                "saleInvoiceIds",
                "saleInvoiceIds"
              ]
            }
            """;

        const string mockResponse = """
            {
              "messageId": "messageId",
              "fileName": "fileName",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/direct-debits/export")
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

        var response = await Client.Bank.PostV1BankDirectDebitsExportAsync(
            new PostV1BankDirectDebitsExportRequest
            {
                BankAccountId = "x",
                SaleInvoiceIds = new List<string>() { "saleInvoiceIds", "saleInvoiceIds" },
                CollectionDate = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "bankAccountId": "bankAccountId",
              "saleInvoiceIds": [
                "saleInvoiceIds"
              ]
            }
            """;

        const string mockResponse = """
            {
              "messageId": "messageId",
              "fileName": "fileName",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/direct-debits/export")
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

        var response = await Client.Bank.PostV1BankDirectDebitsExportAsync(
            new PostV1BankDirectDebitsExportRequest
            {
                BankAccountId = "bankAccountId",
                SaleInvoiceIds = new List<string>() { "saleInvoiceIds" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
