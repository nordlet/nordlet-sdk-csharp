using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountCompaniesActivateTest : BaseMockServerTest
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
              "status": "status"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/activate")
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

        var response = await Client.Account.PostV1AccountCompaniesActivateAsync(
            new PostV1AccountCompaniesActivateRequest { CompanyId = "x" }
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
              "status": "status"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/activate")
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

        var response = await Client.Account.PostV1AccountCompaniesActivateAsync(
            new PostV1AccountCompaniesActivateRequest { CompanyId = "companyId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
