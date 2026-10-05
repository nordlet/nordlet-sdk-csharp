using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LeaveBalancesListTest : BaseMockServerTest
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
                  "year": 1000000,
                  "entitledDays": "entitledDays",
                  "usedDays": "usedDays",
                  "remainingDays": "remainingDays"
                },
                {
                  "employeeId": "x",
                  "year": 1000000,
                  "entitledDays": "entitledDays",
                  "usedDays": "usedDays",
                  "remainingDays": "remainingDays"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/leave-balances/list")
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

        var response = await Client.Hr.LeaveBalancesListAsync(
            new LeaveBalancesListHrRequest { EmployeeId = null, Year = null }
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
                  "year": 1000000,
                  "entitledDays": "entitledDays",
                  "usedDays": "usedDays",
                  "remainingDays": "remainingDays"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/leave-balances/list")
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

        var response = await Client.Hr.LeaveBalancesListAsync(new LeaveBalancesListHrRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
