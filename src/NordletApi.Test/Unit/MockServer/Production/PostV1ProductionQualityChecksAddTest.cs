using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionQualityChecksAddTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "orderId": "x",
              "name": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "orderId": "x",
              "routingOperationId": "x",
              "name": "name",
              "result": "pending",
              "notes": "notes",
              "checkedAt": "checkedAt",
              "checkedBy": "checkedBy",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/quality-checks/add")
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

        var response = await Client.Production.PostV1ProductionQualityChecksAddAsync(
            new PostV1ProductionQualityChecksAddRequest
            {
                OrderId = "x",
                Name = "x",
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "orderId": "orderId",
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "orderId": "orderId",
              "routingOperationId": "routingOperationId",
              "name": "name",
              "result": "pending",
              "notes": "notes",
              "checkedAt": "checkedAt",
              "checkedBy": "checkedBy",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/quality-checks/add")
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

        var response = await Client.Production.PostV1ProductionQualityChecksAddAsync(
            new PostV1ProductionQualityChecksAddRequest { OrderId = "orderId", Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
