using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollSchedulesCreateTest : BaseMockServerTest
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
              "hoursPerWeek": "hoursPerWeek"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/schedules/create")
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

        var response = await Client.Payroll.PostV1PayrollSchedulesCreateAsync(
            new PostV1PayrollSchedulesCreateRequest
            {
                Code = "x",
                Name = "x",
                HoursPerWeek = null,
            }
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
              "hoursPerWeek": "hoursPerWeek"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/schedules/create")
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

        var response = await Client.Payroll.PostV1PayrollSchedulesCreateAsync(
            new PostV1PayrollSchedulesCreateRequest { Code = "code", Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
