using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecordAnOfficerOfTheCompanyTest : BaseMockServerTest
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

        var response = await Client.Ledger.RecordAnOfficerOfTheCompanyAsync(
            new PostV1OfficersCreateRequest
            {
                Name = "x",
                Role = PostV1OfficersCreateRequestRole.Director,
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

        var response = await Client.Ledger.RecordAnOfficerOfTheCompanyAsync(
            new PostV1OfficersCreateRequest
            {
                Name = "name",
                Role = PostV1OfficersCreateRequestRole.Director,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
