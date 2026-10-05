using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PaymentsExportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "purchaseInvoiceIds": [
                "purchaseInvoiceIds",
                "purchaseInvoiceIds"
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
                    .WithPath("/v1/bank/payments/export")
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

        var response = await Client.Bank.PaymentsExportAsync(
            new PaymentsExportBankRequest
            {
                BankAccountId = "x",
                PurchaseInvoiceIds = new List<string>()
                {
                    "purchaseInvoiceIds",
                    "purchaseInvoiceIds",
                },
                ExecutionDate = null,
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
              "purchaseInvoiceIds": [
                "purchaseInvoiceIds"
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
                    .WithPath("/v1/bank/payments/export")
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

        var response = await Client.Bank.PaymentsExportAsync(
            new PaymentsExportBankRequest
            {
                BankAccountId = "bankAccountId",
                PurchaseInvoiceIds = new List<string>() { "purchaseInvoiceIds" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
