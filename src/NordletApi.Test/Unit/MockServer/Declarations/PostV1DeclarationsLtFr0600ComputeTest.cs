using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtFr0600ComputeTest : BaseMockServerTest
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "deductionPercent": 1000000,
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                },
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "breakdown": [
                {
                  "direction": "sales",
                  "taxCode": "taxCode",
                  "net": "net",
                  "vat": "vat",
                  "taxableFields": [
                    "taxableFields",
                    "taxableFields"
                  ],
                  "vatFields": [
                    "vatFields",
                    "vatFields"
                  ]
                },
                {
                  "direction": "sales",
                  "taxCode": "taxCode",
                  "net": "net",
                  "vat": "vat",
                  "taxableFields": [
                    "taxableFields",
                    "taxableFields"
                  ],
                  "vatFields": [
                    "vatFields",
                    "vatFields"
                  ]
                }
              ],
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/fr0600/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtFr0600ComputeAsync(
            new PostV1DeclarationsLtFr0600ComputeRequest
            {
                Year = 1000000,
                Month = 1000000,
                Months = null,
                DeductionPercent = null,
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "deductionPercent": 1000000,
              "fields": [
                {
                  "field": "field",
                  "label": "label",
                  "value": "value"
                }
              ],
              "breakdown": [
                {
                  "direction": "sales",
                  "taxCode": "taxCode",
                  "net": "net",
                  "vat": "vat",
                  "taxableFields": [
                    "taxableFields"
                  ],
                  "vatFields": [
                    "vatFields"
                  ]
                }
              ],
              "counts": {
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/fr0600/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtFr0600ComputeAsync(
            new PostV1DeclarationsLtFr0600ComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
