using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.PlatformSellers;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "kind": "individual",
              "address": {
                "countryCode": "countryCode"
              }
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "kind": "individual",
              "name": "name",
              "partnerId": "partnerId",
              "firstName": "firstName",
              "middleName": "middleName",
              "lastName": "lastName",
              "entityName": "entityName",
              "taxResidences": [
                {
                  "countryCode": "countryCode",
                  "tin": "tin"
                },
                {
                  "countryCode": "countryCode",
                  "tin": "tin"
                }
              ],
              "vatCode": "vatCode",
              "businessRegistrationNumber": "businessRegistrationNumber",
              "address": {
                "countryCode": "countryCode",
                "street": "street",
                "buildingIdentifier": "buildingIdentifier",
                "postCode": "postCode",
                "city": "city",
                "free": "free"
              },
              "birthDate": "2023-01-15",
              "birthCity": "birthCity",
              "birthCountryCode": "birthCountryCode",
              "iban": "iban",
              "accountHolderName": "accountHolderName",
              "governmentEntity": true,
              "listedEntity": true,
              "permanentEstablishments": [
                "permanentEstablishments",
                "permanentEstablishments"
              ],
              "createdAt": "2024-01-15T09:30:00.000Z",
              "activities": [
                {
                  "year": 1000000,
                  "activity": "immovable_property",
                  "propertyAddress": {
                    "countryCode": "countryCode",
                    "street": "street",
                    "buildingIdentifier": "buildingIdentifier",
                    "postCode": "postCode",
                    "city": "city",
                    "free": "free"
                  },
                  "landRegistrationNumber": "landRegistrationNumber",
                  "propertyType": "DPI901",
                  "otherPropertyType": "otherPropertyType",
                  "rentedDays": 1000000,
                  "consideration": [
                    "consideration",
                    "consideration"
                  ],
                  "fees": [
                    "fees",
                    "fees"
                  ],
                  "taxes": [
                    "taxes",
                    "taxes"
                  ],
                  "numberOfActivities": [
                    1000000,
                    1000000
                  ],
                  "id": "x"
                },
                {
                  "year": 1000000,
                  "activity": "immovable_property",
                  "propertyAddress": {
                    "countryCode": "countryCode",
                    "street": "street",
                    "buildingIdentifier": "buildingIdentifier",
                    "postCode": "postCode",
                    "city": "city",
                    "free": "free"
                  },
                  "landRegistrationNumber": "landRegistrationNumber",
                  "propertyType": "DPI901",
                  "otherPropertyType": "otherPropertyType",
                  "rentedDays": 1000000,
                  "consideration": [
                    "consideration",
                    "consideration"
                  ],
                  "fees": [
                    "fees",
                    "fees"
                  ],
                  "taxes": [
                    "taxes",
                    "taxes"
                  ],
                  "numberOfActivities": [
                    1000000,
                    1000000
                  ],
                  "id": "x"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/platform-sellers/update")
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

        var response = await Client.PlatformSellers.UpdateAsync(
            new UpdatePlatformSellersRequest
            {
                Id = "x",
                Kind = UpdatePlatformSellersRequestKind.Individual,
                PartnerId = null,
                FirstName = null,
                MiddleName = null,
                LastName = null,
                EntityName = null,
                TaxResidences = null,
                VatCode = null,
                BusinessRegistrationNumber = null,
                Address = new UpdatePlatformSellersRequestAddress
                {
                    CountryCode = "countryCode",
                    Street = null,
                    BuildingIdentifier = null,
                    PostCode = null,
                    City = null,
                    Free = null,
                },
                BirthDate = null,
                BirthCity = null,
                BirthCountryCode = null,
                Iban = null,
                AccountHolderName = null,
                GovernmentEntity = null,
                ListedEntity = null,
                PermanentEstablishments = null,
                Activities = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "kind": "individual",
              "address": {
                "countryCode": "countryCode"
              }
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "kind": "individual",
              "name": "name",
              "partnerId": "partnerId",
              "firstName": "firstName",
              "middleName": "middleName",
              "lastName": "lastName",
              "entityName": "entityName",
              "taxResidences": [
                {
                  "countryCode": "countryCode",
                  "tin": "tin"
                }
              ],
              "vatCode": "vatCode",
              "businessRegistrationNumber": "businessRegistrationNumber",
              "address": {
                "countryCode": "countryCode",
                "street": "street",
                "buildingIdentifier": "buildingIdentifier",
                "postCode": "postCode",
                "city": "city",
                "free": "free"
              },
              "birthDate": "2026-07-01",
              "birthCity": "birthCity",
              "birthCountryCode": "birthCountryCode",
              "iban": "iban",
              "accountHolderName": "accountHolderName",
              "governmentEntity": true,
              "listedEntity": true,
              "permanentEstablishments": [
                "permanentEstablishments"
              ],
              "createdAt": "2026-07-01T09:30:00.000Z",
              "activities": [
                {
                  "year": 1000000,
                  "activity": "immovable_property",
                  "propertyAddress": {
                    "countryCode": "countryCode"
                  },
                  "landRegistrationNumber": "landRegistrationNumber",
                  "propertyType": "DPI901",
                  "otherPropertyType": "otherPropertyType",
                  "rentedDays": 1000000,
                  "consideration": [
                    "-121.00"
                  ],
                  "fees": [
                    "-121.00"
                  ],
                  "taxes": [
                    "-121.00"
                  ],
                  "numberOfActivities": [
                    1000000
                  ],
                  "id": "id"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/platform-sellers/update")
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

        var response = await Client.PlatformSellers.UpdateAsync(
            new UpdatePlatformSellersRequest
            {
                Id = "id",
                Kind = UpdatePlatformSellersRequestKind.Individual,
                Address = new UpdatePlatformSellersRequestAddress { CountryCode = "countryCode" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
