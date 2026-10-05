using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LeaveBalancesSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "year": 1000000,
              "entitledDays": "entitledDays"
            }
            """;

        const string mockResponse = """
            {
              "employeeId": "x",
              "year": 1000000,
              "entitledDays": "entitledDays",
              "usedDays": "usedDays",
              "remainingDays": "remainingDays"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/leave-balances/set")
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

        var response = await Client.Hr.LeaveBalancesSetAsync(
            new LeaveBalancesSetHrRequest
            {
                EmployeeId = "x",
                Year = 1000000,
                EntitledDays = "entitledDays",
                UsedDays = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId",
              "year": 1000000,
              "entitledDays": "121.00"
            }
            """;

        const string mockResponse = """
            {
              "employeeId": "employeeId",
              "year": 1000000,
              "entitledDays": "entitledDays",
              "usedDays": "usedDays",
              "remainingDays": "remainingDays"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/leave-balances/set")
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

        var response = await Client.Hr.LeaveBalancesSetAsync(
            new LeaveBalancesSetHrRequest
            {
                EmployeeId = "employeeId",
                Year = 1000000,
                EntitledDays = "121.00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
