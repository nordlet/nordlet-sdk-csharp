using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DevicesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x",
              "serialNumber": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "serialNumber": "serialNumber",
              "model": "model",
              "registrationNumber": "registrationNumber",
              "address": "address",
              "isActive": true,
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/devices/create")
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

        var response = await Client.Pos.DevicesCreateAsync(
            new DevicesCreatePosRequest
            {
                Name = "x",
                SerialNumber = "x",
                Model = null,
                RegistrationNumber = null,
                Address = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name",
              "serialNumber": "serialNumber"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "serialNumber": "serialNumber",
              "model": "model",
              "registrationNumber": "registrationNumber",
              "address": "address",
              "isActive": true,
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/devices/create")
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

        var response = await Client.Pos.DevicesCreateAsync(
            new DevicesCreatePosRequest { Name = "name", SerialNumber = "serialNumber" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
