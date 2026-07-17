using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankSettlementsMatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "lineId": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/match")
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

        var response = await Client.Bank.PostV1BankSettlementsMatchAsync(
            new PostV1BankSettlementsMatchRequest { LineId = "x", InvoiceId = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "lineId": "lineId"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/match")
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

        var response = await Client.Bank.PostV1BankSettlementsMatchAsync(
            new PostV1BankSettlementsMatchRequest { LineId = "lineId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
