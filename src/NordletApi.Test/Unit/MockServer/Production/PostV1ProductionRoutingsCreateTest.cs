using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionRoutingsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "x",
              "name": "x",
              "operations": [
                {
                  "sequence": 1000000,
                  "name": "x",
                  "workCenterId": "x"
                },
                {
                  "sequence": 1000000,
                  "name": "x",
                  "workCenterId": "x"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "code": "code",
              "name": "name",
              "isActive": true,
              "notes": "notes",
              "createdAt": "createdAt",
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
                    .WithPath("/v1/production/routings/create")
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

        var response = await Client.Production.PostV1ProductionRoutingsCreateAsync(
            new PostV1ProductionRoutingsCreateRequest
            {
                Code = "x",
                Name = "x",
                Notes = null,
                Operations = new List<PostV1ProductionRoutingsCreateRequestOperationsItem>()
                {
                    new PostV1ProductionRoutingsCreateRequestOperationsItem
                    {
                        Sequence = 1000000,
                        Name = "x",
                        WorkCenterId = "x",
                        SetupMinutes = null,
                        RunMinutesPerUnit = null,
                        QualityCheckName = null,
                        Notes = null,
                    },
                    new PostV1ProductionRoutingsCreateRequestOperationsItem
                    {
                        Sequence = 1000000,
                        Name = "x",
                        WorkCenterId = "x",
                        SetupMinutes = null,
                        RunMinutesPerUnit = null,
                        QualityCheckName = null,
                        Notes = null,
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
              "operations": [
                {
                  "sequence": 1000000,
                  "name": "name",
                  "workCenterId": "workCenterId"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "code": "code",
              "name": "name",
              "isActive": true,
              "notes": "notes",
              "createdAt": "createdAt",
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
                    .WithPath("/v1/production/routings/create")
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

        var response = await Client.Production.PostV1ProductionRoutingsCreateAsync(
            new PostV1ProductionRoutingsCreateRequest
            {
                Code = "code",
                Name = "name",
                Operations = new List<PostV1ProductionRoutingsCreateRequestOperationsItem>()
                {
                    new PostV1ProductionRoutingsCreateRequestOperationsItem
                    {
                        Sequence = 1000000,
                        Name = "name",
                        WorkCenterId = "workCenterId",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
