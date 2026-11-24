using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EeTsdAnnexesSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "month": 1000000,
              "input": {
                "annex4": {
                  "housing": "housing",
                  "insurancePremiums": "insurancePremiums",
                  "carCompensationAboveLimit": "carCompensationAboveLimit",
                  "employerVehicle": "employerVehicle",
                  "otherProperty": "otherProperty",
                  "loanMarketInterest": "loanMarketInterest",
                  "loanContractInterest": "loanContractInterest",
                  "transferMarketPrice": "transferMarketPrice",
                  "transferAppliedPrice": "transferAppliedPrice",
                  "stockOption": {
                    "event": "sale",
                    "marketPrice": "marketPrice",
                    "exercisePrice": "exercisePrice",
                    "premium": "premium"
                  },
                  "purchaseAppliedPrice": "purchaseAppliedPrice",
                  "purchaseMarketPrice": "purchaseMarketPrice",
                  "waivedClaims": "waivedClaims",
                  "education": "education",
                  "healthPromotion": "healthPromotion",
                  "other": "other",
                  "notTaxedWithIncomeTax": "notTaxedWithIncomeTax",
                  "notTaxedWithSocialTax": "notTaxedWithSocialTax"
                },
                "annex5": {
                  "gifts": "gifts",
                  "giftsToListedPersons": "giftsToListedPersons",
                  "limit": "socialTax",
                  "lastYearProfit": "lastYearProfit",
                  "entertainment": "entertainment",
                  "listedPersonTaxableGifts": "listedPersonTaxableGifts"
                },
                "annex6": {
                  "relatedParties": [
                    {
                      "registryCode": "x",
                      "name": "x",
                      "country": "country",
                      "amount": "amount",
                      "typeCode": "621"
                    },
                    {
                      "registryCode": "x",
                      "name": "x",
                      "country": "country",
                      "amount": "amount",
                      "typeCode": "621"
                    }
                  ],
                  "fines": "fines",
                  "taxInterest": "taxInterest",
                  "confiscatedProperty": "confiscatedProperty",
                  "environmentalCharges": "environmentalCharges",
                  "bribes": "bribes",
                  "membershipFees": "membershipFees",
                  "undocumentedPayments": "undocumentedPayments",
                  "nonBusinessExpenses": "nonBusinessExpenses",
                  "lowTaxSecurities": "lowTaxSecurities",
                  "lowTaxHoldings": "lowTaxHoldings",
                  "lowTaxPenalties": "lowTaxPenalties",
                  "lowTaxLoans": "lowTaxLoans",
                  "creditInstitutionLosses": "creditInstitutionLosses",
                  "reductions": [
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "amount"
                    },
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "amount"
                    }
                  ]
                }
              },
              "annexes": {
                "annex4": [
                  {
                    "element": "element",
                    "amount": "amount"
                  },
                  {
                    "element": "element",
                    "amount": "amount"
                  }
                ],
                "annex5": [
                  {
                    "element": "element",
                    "amount": "amount"
                  },
                  {
                    "element": "element",
                    "amount": "amount"
                  }
                ],
                "annex6": {
                  "fields": [
                    {
                      "element": "element",
                      "amount": "amount"
                    },
                    {
                      "element": "element",
                      "amount": "amount"
                    }
                  ],
                  "reductions": [
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "amount"
                    },
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "amount"
                    }
                  ],
                  "relatedParties": [
                    {
                      "registryCode": "registryCode",
                      "name": "name",
                      "country": "country",
                      "amount": "amount",
                      "typeCode": "typeCode"
                    },
                    {
                      "registryCode": "registryCode",
                      "name": "name",
                      "country": "country",
                      "amount": "amount",
                      "typeCode": "typeCode"
                    }
                  ]
                },
                "incomeTax": "incomeTax",
                "socialTax": "socialTax"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ee/tsd-annexes/set")
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

        var response = await Client.Declarations.EeTsdAnnexesSetAsync(
            new EeTsdAnnexesSetDeclarationsRequest
            {
                Year = 1000000,
                Month = 1000000,
                Annex4 = null,
                Annex5 = null,
                Annex6 = null,
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
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "month": 1000000,
              "input": {
                "annex4": {
                  "housing": "121.00",
                  "insurancePremiums": "121.00",
                  "carCompensationAboveLimit": "121.00",
                  "employerVehicle": "121.00",
                  "otherProperty": "121.00",
                  "loanMarketInterest": "121.00",
                  "loanContractInterest": "121.00",
                  "transferMarketPrice": "121.00",
                  "transferAppliedPrice": "121.00",
                  "stockOption": {
                    "event": "sale",
                    "marketPrice": "121.00",
                    "exercisePrice": "121.00",
                    "premium": "121.00"
                  },
                  "purchaseAppliedPrice": "121.00",
                  "purchaseMarketPrice": "121.00",
                  "waivedClaims": "121.00",
                  "education": "121.00",
                  "healthPromotion": "121.00",
                  "other": "121.00",
                  "notTaxedWithIncomeTax": "121.00",
                  "notTaxedWithSocialTax": "121.00"
                },
                "annex5": {
                  "gifts": "121.00",
                  "giftsToListedPersons": "121.00",
                  "limit": "socialTax",
                  "lastYearProfit": "121.00",
                  "entertainment": "121.00",
                  "listedPersonTaxableGifts": "121.00"
                },
                "annex6": {
                  "relatedParties": [
                    {
                      "registryCode": "registryCode",
                      "name": "name",
                      "country": "country",
                      "amount": "121.00",
                      "typeCode": "621"
                    }
                  ],
                  "fines": "121.00",
                  "taxInterest": "121.00",
                  "confiscatedProperty": "121.00",
                  "environmentalCharges": "121.00",
                  "bribes": "121.00",
                  "membershipFees": "121.00",
                  "undocumentedPayments": "121.00",
                  "nonBusinessExpenses": "121.00",
                  "lowTaxSecurities": "121.00",
                  "lowTaxHoldings": "121.00",
                  "lowTaxPenalties": "121.00",
                  "lowTaxLoans": "121.00",
                  "creditInstitutionLosses": "121.00",
                  "reductions": [
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "121.00"
                    }
                  ]
                }
              },
              "annexes": {
                "annex4": [
                  {
                    "element": "element",
                    "amount": "amount"
                  }
                ],
                "annex5": [
                  {
                    "element": "element",
                    "amount": "amount"
                  }
                ],
                "annex6": {
                  "fields": [
                    {
                      "element": "element",
                      "amount": "amount"
                    }
                  ],
                  "reductions": [
                    {
                      "month": 1000000,
                      "year": 1000000,
                      "amount": "amount"
                    }
                  ],
                  "relatedParties": [
                    {
                      "registryCode": "registryCode",
                      "name": "name",
                      "country": "country",
                      "amount": "amount",
                      "typeCode": "typeCode"
                    }
                  ]
                },
                "incomeTax": "incomeTax",
                "socialTax": "socialTax"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ee/tsd-annexes/set")
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

        var response = await Client.Declarations.EeTsdAnnexesSetAsync(
            new EeTsdAnnexesSetDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
