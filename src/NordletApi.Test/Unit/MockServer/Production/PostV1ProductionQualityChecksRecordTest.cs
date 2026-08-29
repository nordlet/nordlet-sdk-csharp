using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionQualityChecksRecordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "result": "passed"
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
                    .WithPath("/v1/production/quality-checks/record")
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

        var response = await Client.Production.PostV1ProductionQualityChecksRecordAsync(
            new PostV1ProductionQualityChecksRecordRequest
            {
                Id = "x",
                Result = PostV1ProductionQualityChecksRecordRequestResult.Passed,
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
              "id": "id",
              "result": "passed"
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
                    .WithPath("/v1/production/quality-checks/record")
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

        var response = await Client.Production.PostV1ProductionQualityChecksRecordAsync(
            new PostV1ProductionQualityChecksRecordRequest
            {
                Id = "id",
                Result = PostV1ProductionQualityChecksRecordRequestResult.Passed,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
