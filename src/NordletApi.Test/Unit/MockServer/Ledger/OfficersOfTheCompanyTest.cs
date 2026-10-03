using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OfficersOfTheCompanyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/officers/list")
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

        var response = await Client.Ledger.OfficersOfTheCompanyAsync(
            new PostV1OfficersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/officers/list")
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

        var response = await Client.Ledger.OfficersOfTheCompanyAsync(
            new PostV1OfficersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
