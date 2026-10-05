using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BomsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "x",
              "name": "x",
              "finishedItemId": "x",
              "lines": [
                {
                  "componentItemId": "x",
                  "quantity": "quantity"
                },
                {
                  "componentItemId": "x",
                  "quantity": "quantity"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "code": "code",
              "name": "name",
              "finishedItemId": "x",
              "outputQuantity": "outputQuantity",
              "routingId": "x",
              "isActive": true,
              "lines": [
                {
                  "id": "x",
                  "componentItemId": "x",
                  "quantity": "quantity",
                  "scrapPercent": "scrapPercent"
                },
                {
                  "id": "x",
                  "componentItemId": "x",
                  "quantity": "quantity",
                  "scrapPercent": "scrapPercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/boms/create")
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

        var response = await Client.Production.BomsCreateAsync(
            new BomsCreateProductionRequest
            {
                Code = "x",
                Name = "x",
                FinishedItemId = "x",
                OutputQuantity = null,
                RoutingId = null,
                Lines = new List<BomsCreateProductionRequestLinesItem>()
                {
                    new BomsCreateProductionRequestLinesItem
                    {
                        ComponentItemId = "x",
                        Quantity = "quantity",
                        ScrapPercent = null,
                    },
                    new BomsCreateProductionRequestLinesItem
                    {
                        ComponentItemId = "x",
                        Quantity = "quantity",
                        ScrapPercent = null,
                    },
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
              "code": "code",
              "name": "name",
              "finishedItemId": "finishedItemId",
              "lines": [
                {
                  "componentItemId": "componentItemId",
                  "quantity": "121.0000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "code": "code",
              "name": "name",
              "finishedItemId": "finishedItemId",
              "outputQuantity": "outputQuantity",
              "routingId": "routingId",
              "isActive": true,
              "lines": [
                {
                  "id": "id",
                  "componentItemId": "componentItemId",
                  "quantity": "quantity",
                  "scrapPercent": "scrapPercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/boms/create")
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

        var response = await Client.Production.BomsCreateAsync(
            new BomsCreateProductionRequest
            {
                Code = "code",
                Name = "name",
                FinishedItemId = "finishedItemId",
                Lines = new List<BomsCreateProductionRequestLinesItem>()
                {
                    new BomsCreateProductionRequestLinesItem
                    {
                        ComponentItemId = "componentItemId",
                        Quantity = "121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
