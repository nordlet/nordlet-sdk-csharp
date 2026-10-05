using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeReturnFactsSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "facts": {}
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
                    "date": "2023-01-15",
                    "partner": "x",
                    "amount": "amount"
                  },
                  {
                    "kind": "x",
                    "date": "2023-01-15",
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
                    "date": "2023-01-15",
                    "kind": "cash",
                    "description": "description",
                    "amount": "amount"
                  },
                  {
                    "name": "x",
                    "date": "2023-01-15",
                    "kind": "cash",
                    "description": "description",
                    "amount": "amount"
                  }
                ],
                "distributions": [
                  {
                    "resolutionDate": "2023-01-15",
                    "paidOn": "2023-01-15",
                    "amount": "amount",
                    "certifiedReduction": "certifiedReduction"
                  },
                  {
                    "resolutionDate": "2023-01-15",
                    "paidOn": "2023-01-15",
                    "amount": "amount",
                    "certifiedReduction": "certifiedReduction"
                  }
                ],
                "taxBalanceEquity": "taxBalanceEquity",
                "multipleMunicipalities": true,
                "relocation": {
                  "date": "2023-01-15",
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
                "smallBusinessSwitchDate": "2023-01-15",
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
                    .WithPath("/v1/declarations/de/return-facts/set")
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

        var response = await Client.Declarations.DeReturnFactsSetAsync(
            new DeReturnFactsSetDeclarationsRequest
            {
                Year = 1000000,
                Facts = new DeReturnFactsSetDeclarationsRequestFacts
                {
                    ChangedShareholderIds = null,
                    ShareholderContracts = null,
                    Contracts = null,
                    HarmfulShareAcquisition = null,
                    CoronaAid = null,
                    LossCarryback = null,
                    DonationCarryforward = null,
                    ContributionAccountOpening = null,
                    Contributions = null,
                    Distributions = null,
                    TaxBalanceEquity = null,
                    MultipleMunicipalities = null,
                    Relocation = null,
                    Municipalities = null,
                    LandHoldings = null,
                    PropertyTaxExpense = null,
                    LicencesToNonResidents = null,
                    Participations = null,
                    ForeignIncome = null,
                    SmallBusinessSwitchDate = null,
                    RefundProcedureApplied = null,
                    Bic = null,
                    Representative = null,
                    SingleTransportTax = null,
                    DistanceSales = null,
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "facts": {}
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
                    "date": "2026-07-01",
                    "partner": "partner",
                    "amount": "-121.00"
                  }
                ],
                "harmfulShareAcquisition": true,
                "coronaAid": "-121.00",
                "lossCarryback": "-121.00",
                "donationCarryforward": "-121.00",
                "contributionAccountOpening": "-121.00",
                "contributions": [
                  {
                    "name": "name",
                    "date": "2026-07-01",
                    "kind": "cash",
                    "amount": "-121.00"
                  }
                ],
                "distributions": [
                  {
                    "resolutionDate": "2026-07-01",
                    "paidOn": "2026-07-01",
                    "amount": "-121.00",
                    "certifiedReduction": "-121.00"
                  }
                ],
                "taxBalanceEquity": "-121.00",
                "multipleMunicipalities": true,
                "relocation": {
                  "date": "2026-07-01",
                  "from": "from",
                  "to": "to"
                },
                "municipalities": [
                  {
                    "name": "name",
                    "postalCode": "postalCode",
                    "ags": "ags",
                    "hebesatz": "121.00",
                    "wages": "-121.00"
                  }
                ],
                "landHoldings": [
                  {
                    "fileNumber": "fileNumber",
                    "assessedValue": "-121.00",
                    "category": "rental_east"
                  }
                ],
                "propertyTaxExpense": "-121.00",
                "licencesToNonResidents": "-121.00",
                "participations": [
                  {
                    "name": "name",
                    "countryCode": "countryCode",
                    "sharePercent": "121.0000",
                    "dividends": "-121.00"
                  }
                ],
                "foreignIncome": [
                  {
                    "countryCode": "countryCode",
                    "kind": "dividends",
                    "income": "-121.00"
                  }
                ],
                "smallBusinessSwitchDate": "2026-07-01",
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
                "singleTransportTax": "-121.00",
                "distanceSales": "-121.00"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/de/return-facts/set")
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

        var response = await Client.Declarations.DeReturnFactsSetAsync(
            new DeReturnFactsSetDeclarationsRequest
            {
                Year = 1000000,
                Facts = new DeReturnFactsSetDeclarationsRequestFacts(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
