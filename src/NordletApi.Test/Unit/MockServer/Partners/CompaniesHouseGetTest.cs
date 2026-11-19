using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CompaniesHouseGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "companyNumber": "x"
            }
            """;

        const string mockResponse = """
            {
              "companyNumber": "companyNumber",
              "name": "name",
              "status": "status",
              "type": "type",
              "jurisdiction": "jurisdiction",
              "incorporatedOn": "incorporatedOn",
              "ceasedOn": "ceasedOn",
              "address": {
                "street": "street",
                "city": "city",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "GB",
                "subdivision": "subdivision"
              },
              "accountingReferenceDate": {
                "day": 1000000,
                "month": 1000000
              },
              "nextAccountsDue": "nextAccountsDue",
              "nextConfirmationStatementDue": "nextConfirmationStatementDue",
              "sicCodes": [
                "sicCodes",
                "sicCodes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/companies-house/get")
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

        var response = await Client.Partners.CompaniesHouseGetAsync(
            new CompaniesHouseGetPartnersRequest { CompanyNumber = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "companyNumber": "companyNumber"
            }
            """;

        const string mockResponse = """
            {
              "companyNumber": "companyNumber",
              "name": "name",
              "status": "status",
              "type": "type",
              "jurisdiction": "jurisdiction",
              "incorporatedOn": "incorporatedOn",
              "ceasedOn": "ceasedOn",
              "address": {
                "street": "street",
                "city": "city",
                "county": "county",
                "postalCode": "postalCode",
                "countryCode": "GB",
                "subdivision": "subdivision"
              },
              "accountingReferenceDate": {
                "day": 1000000,
                "month": 1000000
              },
              "nextAccountsDue": "nextAccountsDue",
              "nextConfirmationStatementDue": "nextConfirmationStatementDue",
              "sicCodes": [
                "sicCodes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/companies-house/get")
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

        var response = await Client.Partners.CompaniesHouseGetAsync(
            new CompaniesHouseGetPartnersRequest { CompanyNumber = "companyNumber" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
