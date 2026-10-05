using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PlIntrastatGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000,
              "flow": "arrivals"
            }
            """;

        const string mockResponse = """
            {
              "flow": "arrivals",
              "referencePeriod": "referencePeriod",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "nip": "nip",
              "companyName": "companyName",
              "detailedThreshold": true,
              "rows": [
                {
                  "itemNumber": 1000000,
                  "cnCode": "cnCode",
                  "description": "description",
                  "countryCode": "countryCode",
                  "originCountry": "originCountry",
                  "partnerVat": "partnerVat",
                  "transactionNature": "transactionNature",
                  "transportMode": "transportMode",
                  "deliveryTerms": "deliveryTerms",
                  "netMassKg": "netMassKg",
                  "supplementaryUnit": "supplementaryUnit",
                  "supplementaryQty": "supplementaryQty",
                  "invoicedValue": "invoicedValue",
                  "statisticalValue": "statisticalValue"
                },
                {
                  "itemNumber": 1000000,
                  "cnCode": "cnCode",
                  "description": "description",
                  "countryCode": "countryCode",
                  "originCountry": "originCountry",
                  "partnerVat": "partnerVat",
                  "transactionNature": "transactionNature",
                  "transportMode": "transportMode",
                  "deliveryTerms": "deliveryTerms",
                  "netMassKg": "netMassKg",
                  "supplementaryUnit": "supplementaryUnit",
                  "supplementaryQty": "supplementaryQty",
                  "invoicedValue": "invoicedValue",
                  "statisticalValue": "statisticalValue"
                }
              ],
              "totals": {
                "invoicedValue": "invoicedValue",
                "statisticalValue": "statisticalValue",
                "netMassKg": "netMassKg",
                "lines": 1000000
              },
              "counts": {
                "invoices": 1000000,
                "linesIncluded": 1000000,
                "linesSkipped": 1000000,
                "returns": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/intrastat/generate")
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

        var response = await Client.Declarations.PlIntrastatGenerateAsync(
            new PlIntrastatGenerateDeclarationsRequest
            {
                Year = 1000000,
                Month = 1000000,
                Flow = PlIntrastatGenerateDeclarationsRequestFlow.Arrivals,
                TransactionNature = null,
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
              "month": 1000000,
              "flow": "arrivals"
            }
            """;

        const string mockResponse = """
            {
              "flow": "arrivals",
              "referencePeriod": "referencePeriod",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "nip": "nip",
              "companyName": "companyName",
              "detailedThreshold": true,
              "rows": [
                {
                  "itemNumber": 1000000,
                  "cnCode": "cnCode",
                  "description": "description",
                  "countryCode": "countryCode",
                  "originCountry": "originCountry",
                  "partnerVat": "partnerVat",
                  "transactionNature": "transactionNature",
                  "transportMode": "transportMode",
                  "deliveryTerms": "deliveryTerms",
                  "netMassKg": "netMassKg",
                  "supplementaryUnit": "supplementaryUnit",
                  "supplementaryQty": "supplementaryQty",
                  "invoicedValue": "invoicedValue",
                  "statisticalValue": "statisticalValue"
                }
              ],
              "totals": {
                "invoicedValue": "invoicedValue",
                "statisticalValue": "statisticalValue",
                "netMassKg": "netMassKg",
                "lines": 1000000
              },
              "counts": {
                "invoices": 1000000,
                "linesIncluded": 1000000,
                "linesSkipped": 1000000,
                "returns": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/intrastat/generate")
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

        var response = await Client.Declarations.PlIntrastatGenerateAsync(
            new PlIntrastatGenerateDeclarationsRequest
            {
                Year = 1000000,
                Month = 1000000,
                Flow = PlIntrastatGenerateDeclarationsRequestFlow.Arrivals,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
