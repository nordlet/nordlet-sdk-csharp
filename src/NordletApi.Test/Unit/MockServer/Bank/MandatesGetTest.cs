using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MandatesGetTest : BaseMockServerTest
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
              "partnerId": "x",
              "reference": "reference",
              "scheme": "CORE",
              "sequenceType": "recurrent",
              "status": "active",
              "debtorName": "debtorName",
              "iban": "iban",
              "bic": "bic",
              "signatureDate": "2023-01-15",
              "collectionsCount": 1000000,
              "lastCollectionDate": "2023-01-15",
              "expiresOn": "expiresOn",
              "cancelledAt": "2024-01-15T09:30:00.000Z",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/get")
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

        var response = await Client.Bank.MandatesGetAsync(new MandatesGetBankRequest { Id = "x" });
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
              "partnerId": "partnerId",
              "reference": "reference",
              "scheme": "CORE",
              "sequenceType": "recurrent",
              "status": "active",
              "debtorName": "debtorName",
              "iban": "iban",
              "bic": "bic",
              "signatureDate": "2026-07-01",
              "collectionsCount": 1000000,
              "lastCollectionDate": "2026-07-01",
              "expiresOn": "expiresOn",
              "cancelledAt": "2026-07-01T09:30:00.000Z",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/get")
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

        var response = await Client.Bank.MandatesGetAsync(new MandatesGetBankRequest { Id = "id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
