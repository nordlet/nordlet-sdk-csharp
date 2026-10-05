using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IncapacityCertificatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "number": "x",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "series": "series",
              "number": "number",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "reason": "reason",
              "notes": "notes"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/incapacity-certificates/create")
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

        var response = await Client.Hr.IncapacityCertificatesCreateAsync(
            new IncapacityCertificatesCreateHrRequest
            {
                EmployeeId = "x",
                Series = null,
                Number = "x",
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
                Reason = null,
                Notes = null,
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
              "number": "number",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "series": "series",
              "number": "number",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "reason": "reason",
              "notes": "notes"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/incapacity-certificates/create")
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

        var response = await Client.Hr.IncapacityCertificatesCreateAsync(
            new IncapacityCertificatesCreateHrRequest
            {
                EmployeeId = "employeeId",
                Number = "number",
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
