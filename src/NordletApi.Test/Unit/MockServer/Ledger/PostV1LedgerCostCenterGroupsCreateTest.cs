using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerCostCenterGroupsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "x",
              "name": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "code": "code",
              "name": "name",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/cost-center-groups/create")
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

        var response = await Client.Ledger.PostV1LedgerCostCenterGroupsCreateAsync(
            new PostV1LedgerCostCenterGroupsCreateRequest { Code = "x", Name = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "code": "code",
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "code": "code",
              "name": "name",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/cost-center-groups/create")
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

        var response = await Client.Ledger.PostV1LedgerCostCenterGroupsCreateAsync(
            new PostV1LedgerCostCenterGroupsCreateRequest { Code = "code", Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
