using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ChangeARecordedOfficerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
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
              "birthDate": "birthDate",
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
                    .WithPath("/v1/officers/update")
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

        var response = await Client.Ledger.ChangeARecordedOfficerAsync(
            new PostV1OfficersUpdateRequest
            {
                Id = "x",
                Name = "x",
                Role = PostV1OfficersUpdateRequestRole.Director,
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
              "id": "id",
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
              "birthDate": "birthDate",
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
                    .WithPath("/v1/officers/update")
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

        var response = await Client.Ledger.ChangeARecordedOfficerAsync(
            new PostV1OfficersUpdateRequest
            {
                Id = "id",
                Name = "name",
                Role = PostV1OfficersUpdateRequestRole.Director,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
