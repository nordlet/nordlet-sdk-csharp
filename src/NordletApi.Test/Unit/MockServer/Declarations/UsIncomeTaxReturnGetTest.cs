using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsIncomeTaxReturnGetTest : BaseMockServerTest
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
              "form": "1065",
              "scheme": "scheme",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "page1": [
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                },
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                }
              ],
              "scheduleL": [
                {
                  "line": "line",
                  "label": "label",
                  "beginning": "beginning",
                  "end": "end"
                },
                {
                  "line": "line",
                  "label": "label",
                  "beginning": "beginning",
                  "end": "end"
                }
              ],
              "otherLines": [
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                },
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/income-tax-return/get")
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

        var response = await Client.Declarations.UsIncomeTaxReturnGetAsync(
            new UsIncomeTaxReturnGetDeclarationsRequest { Year = 1000000 }
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
              "form": "1065",
              "scheme": "scheme",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "page1": [
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                }
              ],
              "scheduleL": [
                {
                  "line": "line",
                  "label": "label",
                  "beginning": "beginning",
                  "end": "end"
                }
              ],
              "otherLines": [
                {
                  "line": "line",
                  "label": "label",
                  "amount": "amount"
                }
              ],
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/income-tax-return/get")
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

        var response = await Client.Declarations.UsIncomeTaxReturnGetAsync(
            new UsIncomeTaxReturnGetDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
