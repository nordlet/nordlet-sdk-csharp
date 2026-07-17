using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionBomsCreateTest : BaseMockServerTest
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
              "isActive": true,
              "lines": [
                {
                  "id": "x",
                  "componentItemId": "x",
                  "quantity": "quantity"
                },
                {
                  "id": "x",
                  "componentItemId": "x",
                  "quantity": "quantity"
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

        var response = await Client.Production.PostV1ProductionBomsCreateAsync(
            new PostV1ProductionBomsCreateRequest
            {
                Code = "x",
                Name = "x",
                FinishedItemId = "x",
                OutputQuantity = null,
                Lines = new List<PostV1ProductionBomsCreateRequestLinesItem>()
                {
                    new PostV1ProductionBomsCreateRequestLinesItem
                    {
                        ComponentItemId = "x",
                        Quantity = "quantity",
                    },
                    new PostV1ProductionBomsCreateRequestLinesItem
                    {
                        ComponentItemId = "x",
                        Quantity = "quantity",
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
                  "quantity": "quantity"
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
              "isActive": true,
              "lines": [
                {
                  "id": "id",
                  "componentItemId": "componentItemId",
                  "quantity": "quantity"
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

        var response = await Client.Production.PostV1ProductionBomsCreateAsync(
            new PostV1ProductionBomsCreateRequest
            {
                Code = "code",
                Name = "name",
                FinishedItemId = "finishedItemId",
                Lines = new List<PostV1ProductionBomsCreateRequestLinesItem>()
                {
                    new PostV1ProductionBomsCreateRequestLinesItem
                    {
                        ComponentItemId = "componentItemId",
                        Quantity = "quantity",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
