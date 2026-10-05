using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LtPln204ComputeTest : BaseMockServerTest
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "variant": "PLN204",
              "registrationNumber": "registrationNumber",
              "companyName": "companyName",
              "ratePercent": "ratePercent",
              "rateCode": "rateCode",
              "smallEntity": true,
              "criteria": {
                "netTurnover": "netTurnover",
                "avgEmployees": 1.1
              },
              "totalIncome": "totalIncome",
              "boxes": {
                "boxes": "boxes"
              },
              "annexS": [
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                },
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "annexZ": [
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                },
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "lines": [
                {
                  "key": "key",
                  "label": "label",
                  "value": "value"
                },
                {
                  "key": "key",
                  "label": "label",
                  "value": "value"
                }
              ],
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
                    .WithPath("/v1/declarations/lt/pln204/compute")
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

        var response = await Client.Declarations.LtPln204ComputeAsync(
            new LtPln204ComputeDeclarationsRequest { Year = 1000000 }
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "variant": "PLN204",
              "registrationNumber": "registrationNumber",
              "companyName": "companyName",
              "ratePercent": "ratePercent",
              "rateCode": "rateCode",
              "smallEntity": true,
              "criteria": {
                "netTurnover": "netTurnover",
                "avgEmployees": 1.1
              },
              "totalIncome": "totalIncome",
              "boxes": {
                "key": "value"
              },
              "annexS": [
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "annexZ": [
                {
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "lines": [
                {
                  "key": "key",
                  "label": "label",
                  "value": "value"
                }
              ],
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
                    .WithPath("/v1/declarations/lt/pln204/compute")
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

        var response = await Client.Declarations.LtPln204ComputeAsync(
            new LtPln204ComputeDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
