using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MandatesAuddisExportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x"
            }
            """;

        const string mockResponse = """
            {
              "format": "pain.001.001.03",
              "messageId": "messageId",
              "fileName": "fileName",
              "contentType": "contentType",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "content": "content",
              "processingDate": "2023-01-15",
              "lodged": [
                "lodged",
                "lodged"
              ],
              "cancelled": [
                "cancelled",
                "cancelled"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/auddis-export")
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

        var response = await Client.Bank.MandatesAuddisExportAsync(
            new MandatesAuddisExportBankRequest
            {
                BankAccountId = "x",
                MandateIds = null,
                ProcessingDate = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "bankAccountId": "bankAccountId"
            }
            """;

        const string mockResponse = """
            {
              "format": "pain.001.001.03",
              "messageId": "messageId",
              "fileName": "fileName",
              "contentType": "contentType",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "content": "content",
              "processingDate": "2026-07-01",
              "lodged": [
                "lodged"
              ],
              "cancelled": [
                "cancelled"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/auddis-export")
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

        var response = await Client.Bank.MandatesAuddisExportAsync(
            new MandatesAuddisExportBankRequest { BankAccountId = "bankAccountId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
