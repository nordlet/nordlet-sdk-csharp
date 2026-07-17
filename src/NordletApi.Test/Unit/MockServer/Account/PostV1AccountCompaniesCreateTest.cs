using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountCompaniesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "code": "code",
              "vatCode": "vatCode",
              "role": "role",
              "isSandbox": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/create")
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

        var response = await Client.Account.PostV1AccountCompaniesCreateAsync(
            new PostV1AccountCompaniesCreateRequest
            {
                Name = "x",
                Code = null,
                VatCode = null,
                IsVatPayer = null,
                Address = null,
                Email = null,
                Phone = null,
                Iban = null,
                BankName = null,
                PeppolId = null,
                DefaultInvoiceCurrency = null,
                CountryCode = null,
                IsSandbox = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "code": "code",
              "vatCode": "vatCode",
              "role": "role",
              "isSandbox": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/create")
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

        var response = await Client.Account.PostV1AccountCompaniesCreateAsync(
            new PostV1AccountCompaniesCreateRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
