using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsDeReturnFactsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "facts": {
                "changedShareholderIds": [
                  "changedShareholderIds",
                  "changedShareholderIds"
                ],
                "shareholderContracts": true,
                "contracts": [
                  {
                    "kind": "x",
                    "date": "date",
                    "partner": "x",
                    "amount": "amount"
                  },
                  {
                    "kind": "x",
                    "date": "date",
                    "partner": "x",
                    "amount": "amount"
                  }
                ],
                "harmfulShareAcquisition": true,
                "coronaAid": "coronaAid",
                "lossCarryback": "lossCarryback",
                "donationCarryforward": "donationCarryforward",
                "contributionAccountOpening": "contributionAccountOpening",
                "contributions": [
                  {
                    "name": "x",
                    "date": "date",
                    "kind": "cash",
                    "description": "description",
                    "amount": "amount"
                  },
                  {
                    "name": "x",
                    "date": "date",
                    "kind": "cash",
                    "description": "description",
                    "amount": "amount"
                  }
                ],
                "distributions": [
                  {
                    "resolutionDate": "resolutionDate",
                    "paidOn": "paidOn",
                    "amount": "amount",
                    "certifiedReduction": "certifiedReduction"
                  },
                  {
                    "resolutionDate": "resolutionDate",
                    "paidOn": "paidOn",
                    "amount": "amount",
                    "certifiedReduction": "certifiedReduction"
                  }
                ],
                "taxBalanceEquity": "taxBalanceEquity",
                "multipleMunicipalities": true,
                "relocation": {
                  "date": "date",
                  "from": "x",
                  "to": "x"
                },
                "municipalities": [
                  {
                    "name": "x",
                    "postalCode": "postalCode",
                    "ags": "ags",
                    "hebesatz": "hebesatz",
                    "wages": "wages"
                  },
                  {
                    "name": "x",
                    "postalCode": "postalCode",
                    "ags": "ags",
                    "hebesatz": "hebesatz",
                    "wages": "wages"
                  }
                ],
                "landHoldings": [
                  {
                    "fileNumber": "x",
                    "assessedValue": "assessedValue",
                    "category": "rental_east"
                  },
                  {
                    "fileNumber": "x",
                    "assessedValue": "assessedValue",
                    "category": "rental_east"
                  }
                ],
                "propertyTaxExpense": "propertyTaxExpense",
                "licencesToNonResidents": "licencesToNonResidents",
                "participations": [
                  {
                    "name": "x",
                    "countryCode": "countryCode",
                    "sharePercent": "sharePercent",
                    "dividends": "dividends"
                  },
                  {
                    "name": "x",
                    "countryCode": "countryCode",
                    "sharePercent": "sharePercent",
                    "dividends": "dividends"
                  }
                ],
                "foreignIncome": [
                  {
                    "countryCode": "countryCode",
                    "kind": "dividends",
                    "income": "income"
                  },
                  {
                    "countryCode": "countryCode",
                    "kind": "dividends",
                    "income": "income"
                  }
                ],
                "smallBusinessSwitchDate": "smallBusinessSwitchDate",
                "refundProcedureApplied": true,
                "bic": "bic",
                "representative": {
                  "role": "agent",
                  "name": "x",
                  "street": "x",
                  "houseNumber": "houseNumber",
                  "postalCode": "x",
                  "city": "x"
                },
                "singleTransportTax": "singleTransportTax",
                "distanceSales": "distanceSales"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/return-facts/get")
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

        var response = await Client.Declarations.PostV1DeclarationsDeReturnFactsGetAsync(
            new PostV1DeclarationsDeReturnFactsGetRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "facts": {
                "changedShareholderIds": [
                  "changedShareholderIds"
                ],
                "shareholderContracts": true,
                "contracts": [
                  {
                    "kind": "kind",
                    "date": "date",
                    "partner": "partner",
                    "amount": "amount"
                  }
                ],
                "harmfulShareAcquisition": true,
                "coronaAid": "coronaAid",
                "lossCarryback": "lossCarryback",
                "donationCarryforward": "donationCarryforward",
                "contributionAccountOpening": "contributionAccountOpening",
                "contributions": [
                  {
                    "name": "name",
                    "date": "date",
                    "kind": "cash",
                    "amount": "amount"
                  }
                ],
                "distributions": [
                  {
                    "resolutionDate": "resolutionDate",
                    "paidOn": "paidOn",
                    "amount": "amount",
                    "certifiedReduction": "certifiedReduction"
                  }
                ],
                "taxBalanceEquity": "taxBalanceEquity",
                "multipleMunicipalities": true,
                "relocation": {
                  "date": "date",
                  "from": "from",
                  "to": "to"
                },
                "municipalities": [
                  {
                    "name": "name",
                    "postalCode": "postalCode",
                    "ags": "ags",
                    "hebesatz": "hebesatz",
                    "wages": "wages"
                  }
                ],
                "landHoldings": [
                  {
                    "fileNumber": "fileNumber",
                    "assessedValue": "assessedValue",
                    "category": "rental_east"
                  }
                ],
                "propertyTaxExpense": "propertyTaxExpense",
                "licencesToNonResidents": "licencesToNonResidents",
                "participations": [
                  {
                    "name": "name",
                    "countryCode": "countryCode",
                    "sharePercent": "sharePercent",
                    "dividends": "dividends"
                  }
                ],
                "foreignIncome": [
                  {
                    "countryCode": "countryCode",
                    "kind": "dividends",
                    "income": "income"
                  }
                ],
                "smallBusinessSwitchDate": "smallBusinessSwitchDate",
                "refundProcedureApplied": true,
                "bic": "bic",
                "representative": {
                  "role": "agent",
                  "name": "name",
                  "street": "street",
                  "houseNumber": "houseNumber",
                  "postalCode": "postalCode",
                  "city": "city"
                },
                "singleTransportTax": "singleTransportTax",
                "distanceSales": "distanceSales"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/return-facts/get")
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

        var response = await Client.Declarations.PostV1DeclarationsDeReturnFactsGetAsync(
            new PostV1DeclarationsDeReturnFactsGetRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
