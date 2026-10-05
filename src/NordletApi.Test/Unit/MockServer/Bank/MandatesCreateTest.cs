using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MandatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
              "iban": "blackcurrant...",
              "signatureDate": "2023-01-15"
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
                    .WithPath("/v1/bank/mandates/create")
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

        var response = await Client.Bank.MandatesCreateAsync(
            new MandatesCreateBankRequest
            {
                PartnerId = "x",
                Iban = "blackcurrant...",
                Bic = null,
                Scheme = null,
                SequenceType = null,
                SignatureDate = new DateOnly(2023, 1, 15),
                Reference = null,
                DebtorName = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "partnerId": "partnerId",
              "iban": "iban",
              "signatureDate": "2026-07-01"
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
                    .WithPath("/v1/bank/mandates/create")
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

        var response = await Client.Bank.MandatesCreateAsync(
            new MandatesCreateBankRequest
            {
                PartnerId = "partnerId",
                Iban = "iban",
                SignatureDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
