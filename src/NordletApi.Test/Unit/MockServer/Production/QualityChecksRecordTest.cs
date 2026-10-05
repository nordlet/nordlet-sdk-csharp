using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class QualityChecksRecordTest : BaseMockServerTest
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
              "checkedAt": "2024-01-15T09:30:00.000Z",
              "checkedBy": "checkedBy",
              "createdAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Production.QualityChecksRecordAsync(
            new QualityChecksRecordProductionRequest
            {
                Id = "x",
                Result = QualityChecksRecordProductionRequestResult.Passed,
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
              "checkedAt": "2026-07-01T09:30:00.000Z",
              "checkedBy": "checkedBy",
              "createdAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Production.QualityChecksRecordAsync(
            new QualityChecksRecordProductionRequest
            {
                Id = "id",
                Result = QualityChecksRecordProductionRequestResult.Passed,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
