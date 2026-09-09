using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersGetTest : BaseMockServerTest
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
                "municipality": "municipality",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "xy"
              },
              "correspondenceAddress": {
                "street": "street",
                "city": "city",
                "municipality": "municipality",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "xy"
              },
              "notes": "notes",
              "documentRef": "documentRef",
              "shortName": "shortName",
              "website": "website",
              "fax": "fax",
              "eoriCode": "eoriCode",
              "otherCode": "otherCode",
              "foreignTaxNumber": "foreignTaxNumber",
              "autoDebtReminder": true,
              "lateInterestPercent": "lateInterestPercent",
              "firstCallDate": "firstCallDate",
              "lastCallDate": "lastCallDate",
              "nextCallDate": "nextCallDate",
              "rating": 1000000,
              "isEmployee": true,
              "isGroupMember": true,
              "isActive": true,
              "legalCountryClass": "lt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/get")
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

        var response = await Client.Partners.PostV1PartnersGetAsync(
            new PostV1PartnersGetRequest { Id = "x" }
        );
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
                "municipality": "municipality",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "countryCode"
              },
              "correspondenceAddress": {
                "street": "street",
                "city": "city",
                "municipality": "municipality",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "countryCode"
              },
              "notes": "notes",
              "documentRef": "documentRef",
              "shortName": "shortName",
              "website": "website",
              "fax": "fax",
              "eoriCode": "eoriCode",
              "otherCode": "otherCode",
              "foreignTaxNumber": "foreignTaxNumber",
              "autoDebtReminder": true,
              "lateInterestPercent": "lateInterestPercent",
              "firstCallDate": "firstCallDate",
              "lastCallDate": "lastCallDate",
              "nextCallDate": "nextCallDate",
              "rating": 1000000,
              "isEmployee": true,
              "isGroupMember": true,
              "isActive": true,
              "legalCountryClass": "lt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/get")
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

        var response = await Client.Partners.PostV1PartnersGetAsync(
            new PostV1PartnersGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
