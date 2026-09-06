using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersFindOrCreateTest : BaseMockServerTest
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
              "created": true,
              "partner": {
                "id": "x",
                "type": "company",
                "name": "name",
                "code": "code",
                "vatCode": "vatCode",
                "peppolId": "peppolId",
                "email": "email",
                "phone": "phone",
                "selfEmploymentCertNo": "selfEmploymentCertNo",
                "birthDate": "birthDate",
                "isCustomer": true,
                "isSupplier": true,
                "paymentTermDays": 1000000,
                "creditLimit": "creditLimit",
                "priceListId": "x",
                "groupId": "x",
                "statusId": "x",
                "vatValid": true,
                "vatValidatedAt": "vatValidatedAt",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "xy"
                },
                "notes": "notes",
                "documentRef": "documentRef",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/find-or-create")
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

        var response = await Client.Partners.PostV1PartnersFindOrCreateAsync(
            new PostV1PartnersFindOrCreateRequest
            {
                Type = null,
                Name = "x",
                Code = null,
                VatCode = null,
                PeppolId = null,
                Email = null,
                Phone = null,
                SelfEmploymentCertNo = null,
                BirthDate = null,
                IsCustomer = null,
                IsSupplier = null,
                PaymentTermDays = null,
                CreditLimit = null,
                PriceListId = null,
                GroupId = null,
                StatusId = null,
                Address = null,
                Notes = null,
                DocumentRef = null,
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
              "created": true,
              "partner": {
                "id": "id",
                "type": "company",
                "name": "name",
                "code": "code",
                "vatCode": "vatCode",
                "peppolId": "peppolId",
                "email": "email",
                "phone": "phone",
                "selfEmploymentCertNo": "selfEmploymentCertNo",
                "birthDate": "birthDate",
                "isCustomer": true,
                "isSupplier": true,
                "paymentTermDays": 1000000,
                "creditLimit": "creditLimit",
                "priceListId": "priceListId",
                "groupId": "groupId",
                "statusId": "statusId",
                "vatValid": true,
                "vatValidatedAt": "vatValidatedAt",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode"
                },
                "notes": "notes",
                "documentRef": "documentRef",
                "createdAt": "createdAt",
                "updatedAt": "updatedAt"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/find-or-create")
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

        var response = await Client.Partners.PostV1PartnersFindOrCreateAsync(
            new PostV1PartnersFindOrCreateRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
