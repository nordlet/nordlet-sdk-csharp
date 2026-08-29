using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountCompaniesUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "code": "code",
              "vatCode": "vatCode",
              "smeExemptionNumber": "smeExemptionNumber",
              "isVatPayer": true,
              "isSandbox": true,
              "countryCode": "countryCode",
              "baseCurrency": "baseCurrency",
              "defaultInvoiceCurrency": "defaultInvoiceCurrency",
              "status": "active",
              "address": {
                "street": "street",
                "city": "city",
                "postalCode": "postalCode",
                "countryCode": "xy"
              },
              "email": "email",
              "phone": "phone",
              "iban": "iban",
              "bankName": "bankName",
              "peppolId": "peppolId",
              "sepaCreditorId": "sepaCreditorId",
              "logoFileId": "logoFileId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/update")
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

        var response = await Client.Account.PostV1AccountCompaniesUpdateAsync(
            new PostV1AccountCompaniesUpdateRequest
            {
                Name = null,
                Code = null,
                VatCode = null,
                SmeExemptionNumber = null,
                IsVatPayer = null,
                Address = null,
                Email = null,
                Phone = null,
                Iban = null,
                BankName = null,
                PeppolId = null,
                SepaCreditorId = null,
                DefaultInvoiceCurrency = null,
                Logo = null,
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
              "id": "id",
              "name": "name",
              "code": "code",
              "vatCode": "vatCode",
              "smeExemptionNumber": "smeExemptionNumber",
              "isVatPayer": true,
              "isSandbox": true,
              "countryCode": "countryCode",
              "baseCurrency": "baseCurrency",
              "defaultInvoiceCurrency": "defaultInvoiceCurrency",
              "status": "active",
              "address": {
                "street": "street",
                "city": "city",
                "postalCode": "postalCode",
                "countryCode": "countryCode"
              },
              "email": "email",
              "phone": "phone",
              "iban": "iban",
              "bankName": "bankName",
              "peppolId": "peppolId",
              "sepaCreditorId": "sepaCreditorId",
              "logoFileId": "logoFileId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/update")
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

        var response = await Client.Account.PostV1AccountCompaniesUpdateAsync(
            new PostV1AccountCompaniesUpdateRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
