using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbP11DItemsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "taxYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "items": [
                {
                  "id": "id",
                  "employeeId": "employeeId",
                  "taxYear": 1.1,
                  "section": "section",
                  "class1A": true,
                  "cashEquivalent": "cashEquivalent",
                  "item": {
                    "type": "asset-transferred",
                    "asset": "cars",
                    "otherDescription": "x",
                    "cost": "cost",
                    "madeGood": "madeGood"
                  }
                },
                {
                  "id": "id",
                  "employeeId": "employeeId",
                  "taxYear": 1.1,
                  "section": "section",
                  "class1A": true,
                  "cashEquivalent": "cashEquivalent",
                  "item": {
                    "type": "asset-transferred",
                    "asset": "cars",
                    "otherDescription": "x",
                    "cost": "cost",
                    "madeGood": "madeGood"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p11d/items/list")
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

        var response = await Client.Declarations.GbP11DItemsListAsync(
            new GbP11DItemsListDeclarationsRequest { TaxYear = 1000000, EmployeeId = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "taxYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "items": [
                {
                  "id": "id",
                  "employeeId": "employeeId",
                  "taxYear": 1.1,
                  "section": "section",
                  "class1A": true,
                  "cashEquivalent": "cashEquivalent",
                  "item": {
                    "type": "asset-transferred",
                    "asset": "cars",
                    "cost": "121.00",
                    "madeGood": "121.00"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p11d/items/list")
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

        var response = await Client.Declarations.GbP11DItemsListAsync(
            new GbP11DItemsListDeclarationsRequest { TaxYear = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
