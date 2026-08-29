using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankMandatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
              "iban": "blackcurrant...",
              "signatureDate": "signatureDate"
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
              "signatureDate": "signatureDate",
              "collectionsCount": 1000000,
              "lastCollectionDate": "lastCollectionDate",
              "expiresOn": "expiresOn",
              "cancelledAt": "cancelledAt",
              "notes": "notes",
              "createdAt": "createdAt"
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

        var response = await Client.Bank.PostV1BankMandatesCreateAsync(
            new PostV1BankMandatesCreateRequest
            {
                PartnerId = "x",
                Iban = "blackcurrant...",
                Bic = null,
                Scheme = null,
                SequenceType = null,
                SignatureDate = "signatureDate",
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
              "signatureDate": "signatureDate"
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
              "signatureDate": "signatureDate",
              "collectionsCount": 1000000,
              "lastCollectionDate": "lastCollectionDate",
              "expiresOn": "expiresOn",
              "cancelledAt": "cancelledAt",
              "notes": "notes",
              "createdAt": "createdAt"
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

        var response = await Client.Bank.PostV1BankMandatesCreateAsync(
            new PostV1BankMandatesCreateRequest
            {
                PartnerId = "partnerId",
                Iban = "iban",
                SignatureDate = "signatureDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
