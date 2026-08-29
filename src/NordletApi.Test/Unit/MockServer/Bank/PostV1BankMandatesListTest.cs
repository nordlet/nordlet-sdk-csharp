using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankMandatesListTest : BaseMockServerTest
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
                },
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/list")
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

        var response = await Client.Bank.PostV1BankMandatesListAsync(
            new PostV1BankMandatesListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/mandates/list")
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

        var response = await Client.Bank.PostV1BankMandatesListAsync(
            new PostV1BankMandatesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
