using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class Us1099NecListTest : BaseMockServerTest
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
              "year": 1.1,
              "threshold": "threshold",
              "forms": [
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "nameType": "B",
                  "tinType": "tinType",
                  "tin": "tin",
                  "taxClassification": "taxClassification",
                  "box1": "box1"
                },
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "nameType": "B",
                  "tinType": "tinType",
                  "tin": "tin",
                  "taxClassification": "taxClassification",
                  "box1": "box1"
                }
              ],
              "excluded": [
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "paid": "paid",
                  "reason": "reason"
                },
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "paid": "paid",
                  "reason": "reason"
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
                    .WithPath("/v1/declarations/us/1099-nec/list")
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

        var response = await Client.Declarations.Us1099NecListAsync(
            new Us1099NecListDeclarationsRequest { Year = 1000000 }
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
              "year": 1.1,
              "threshold": "threshold",
              "forms": [
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "nameType": "B",
                  "tinType": "tinType",
                  "tin": "tin",
                  "taxClassification": "taxClassification",
                  "box1": "box1"
                }
              ],
              "excluded": [
                {
                  "partnerId": "partnerId",
                  "name": "name",
                  "paid": "paid",
                  "reason": "reason"
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
                    .WithPath("/v1/declarations/us/1099-nec/list")
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

        var response = await Client.Declarations.Us1099NecListAsync(
            new Us1099NecListDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
