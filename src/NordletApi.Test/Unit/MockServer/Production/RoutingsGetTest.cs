using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RoutingsGetTest : BaseMockServerTest
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
              "code": "code",
              "name": "name",
              "isActive": true,
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "operations": [
                {
                  "id": "x",
                  "sequence": 1000000,
                  "name": "name",
                  "workCenterId": "x",
                  "setupMinutes": "setupMinutes",
                  "runMinutesPerUnit": "runMinutesPerUnit",
                  "qualityCheckName": "qualityCheckName",
                  "notes": "notes"
                },
                {
                  "id": "x",
                  "sequence": 1000000,
                  "name": "name",
                  "workCenterId": "x",
                  "setupMinutes": "setupMinutes",
                  "runMinutesPerUnit": "runMinutesPerUnit",
                  "qualityCheckName": "qualityCheckName",
                  "notes": "notes"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/routings/get")
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

        var response = await Client.Production.RoutingsGetAsync(
            new RoutingsGetProductionRequest { Id = "x" }
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
              "code": "code",
              "name": "name",
              "isActive": true,
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "operations": [
                {
                  "id": "id",
                  "sequence": 1000000,
                  "name": "name",
                  "workCenterId": "workCenterId",
                  "setupMinutes": "setupMinutes",
                  "runMinutesPerUnit": "runMinutesPerUnit",
                  "qualityCheckName": "qualityCheckName",
                  "notes": "notes"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/production/routings/get")
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

        var response = await Client.Production.RoutingsGetAsync(
            new RoutingsGetProductionRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
