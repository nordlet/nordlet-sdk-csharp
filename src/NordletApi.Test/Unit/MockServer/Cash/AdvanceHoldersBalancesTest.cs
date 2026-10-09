using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AdvanceHoldersBalancesTest : BaseMockServerTest
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
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "issued": "issued",
                  "returned": "returned",
                  "settled": "settled",
                  "balance": "balance"
                },
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "issued": "issued",
                  "returned": "returned",
                  "settled": "settled",
                  "balance": "balance"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/advance-holders/balances")
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

        var response = await Client.Cash.AdvanceHoldersBalancesAsync(
            new AdvanceHoldersBalancesCashRequest()
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
                  "employeeId": "employeeId",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "issued": "issued",
                  "returned": "returned",
                  "settled": "settled",
                  "balance": "balance"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/advance-holders/balances")
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

        var response = await Client.Cash.AdvanceHoldersBalancesAsync(
            new AdvanceHoldersBalancesCashRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
