using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionOrdersCompleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "type": "assembly",
              "bomId": "x",
              "warehouseId": "x",
              "quantity": "quantity",
              "date": "date",
              "status": "draft",
              "totalCost": "totalCost",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/complete")
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

        var response = await Client.Production.PostV1ProductionOrdersCompleteAsync(
            new PostV1ProductionOrdersCompleteRequest
            {
                Id = "x",
                ComponentsAccountCode = null,
                FinishedAccountCode = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "type": "assembly",
              "bomId": "bomId",
              "warehouseId": "warehouseId",
              "quantity": "quantity",
              "date": "date",
              "status": "draft",
              "totalCost": "totalCost",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/orders/complete")
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

        var response = await Client.Production.PostV1ProductionOrdersCompleteAsync(
            new PostV1ProductionOrdersCompleteRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
