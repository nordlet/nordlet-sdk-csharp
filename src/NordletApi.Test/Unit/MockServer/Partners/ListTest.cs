using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
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
                  "type": "company",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "peppolId": "peppolId",
                  "email": "email",
                  "phone": "phone",
                  "selfEmploymentCertNo": "selfEmploymentCertNo",
                  "birthDate": "2023-01-15",
                  "isCustomer": true,
                  "isSupplier": true,
                  "paymentTermDays": 1000000,
                  "creditLimit": "creditLimit",
                  "priceListId": "x",
                  "groupId": "x",
                  "statusId": "x",
                  "vatValid": true,
                  "vatValidatedAt": "2024-01-15T09:30:00.000Z",
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
                  "firstCallDate": "2023-01-15",
                  "lastCallDate": "2023-01-15",
                  "nextCallDate": "2023-01-15",
                  "rating": 1000000,
                  "isEmployee": true,
                  "isGroupMember": true,
                  "isActive": true,
                  "legalCountryClass": "lt",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
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
                  "birthDate": "2023-01-15",
                  "isCustomer": true,
                  "isSupplier": true,
                  "paymentTermDays": 1000000,
                  "creditLimit": "creditLimit",
                  "priceListId": "x",
                  "groupId": "x",
                  "statusId": "x",
                  "vatValid": true,
                  "vatValidatedAt": "2024-01-15T09:30:00.000Z",
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
                  "firstCallDate": "2023-01-15",
                  "lastCallDate": "2023-01-15",
                  "nextCallDate": "2023-01-15",
                  "rating": 1000000,
                  "isEmployee": true,
                  "isGroupMember": true,
                  "isActive": true,
                  "legalCountryClass": "lt",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/list")
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

        var response = await Client.Partners.ListAsync(
            new ListPartnersRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
                  "type": "company",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "peppolId": "peppolId",
                  "email": "email",
                  "phone": "phone",
                  "selfEmploymentCertNo": "selfEmploymentCertNo",
                  "birthDate": "2026-07-01",
                  "isCustomer": true,
                  "isSupplier": true,
                  "paymentTermDays": 1000000,
                  "creditLimit": "creditLimit",
                  "priceListId": "priceListId",
                  "groupId": "groupId",
                  "statusId": "statusId",
                  "vatValid": true,
                  "vatValidatedAt": "2026-07-01T09:30:00.000Z",
                  "address": {},
                  "correspondenceAddress": {},
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
                  "firstCallDate": "2026-07-01",
                  "lastCallDate": "2026-07-01",
                  "nextCallDate": "2026-07-01",
                  "rating": 1000000,
                  "isEmployee": true,
                  "isGroupMember": true,
                  "isActive": true,
                  "legalCountryClass": "lt",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/list")
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

        var response = await Client.Partners.ListAsync(new ListPartnersRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
