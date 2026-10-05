using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Officers;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x",
              "role": "director"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "role": "director",
              "personalCode": "personalCode",
              "birthDate": "2023-01-15",
              "appointedOn": "appointedOn",
              "powerNotary": "powerNotary",
              "resignedOn": "resignedOn",
              "signsAccounts": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/officers/create")
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

        var response = await Client.Officers.CreateAsync(
            new CreateOfficersRequest
            {
                Name = "x",
                Role = CreateOfficersRequestRole.Director,
                PersonalCode = null,
                BirthDate = null,
                AppointedOn = null,
                PowerNotary = null,
                ResignedOn = null,
                SignsAccounts = null,
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
              "role": "director"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "role": "director",
              "personalCode": "personalCode",
              "birthDate": "2026-07-01",
              "appointedOn": "appointedOn",
              "powerNotary": "powerNotary",
              "resignedOn": "resignedOn",
              "signsAccounts": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/officers/create")
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

        var response = await Client.Officers.CreateAsync(
            new CreateOfficersRequest { Name = "name", Role = CreateOfficersRequestRole.Director }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
