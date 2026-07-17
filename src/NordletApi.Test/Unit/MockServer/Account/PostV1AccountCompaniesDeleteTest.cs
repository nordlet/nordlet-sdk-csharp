using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountCompaniesDeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "companyId": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "status": "status",
              "purgeAfter": "purgeAfter"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/delete")
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

        var response = await Client.Account.PostV1AccountCompaniesDeleteAsync(
            new PostV1AccountCompaniesDeleteRequest { CompanyId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "companyId": "companyId"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "status": "status",
              "purgeAfter": "purgeAfter"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/delete")
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

        var response = await Client.Account.PostV1AccountCompaniesDeleteAsync(
            new PostV1AccountCompaniesDeleteRequest { CompanyId = "companyId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
