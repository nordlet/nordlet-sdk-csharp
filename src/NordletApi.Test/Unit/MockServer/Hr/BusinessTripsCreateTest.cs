using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BusinessTripsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "destinationCountryCode": "xy",
              "purpose": "x",
              "startDate": "2023-01-15",
              "endDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "destinationCountryCode": "destinationCountryCode",
              "purpose": "purpose",
              "startDate": "2023-01-15",
              "endDate": "2023-01-15",
              "days": 1000000,
              "dailyRate": "dailyRate",
              "perDiemAmount": "perDiemAmount",
              "status": "draft",
              "payrollRunId": "x",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/business-trips/create")
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

        var response = await Client.Hr.BusinessTripsCreateAsync(
            new BusinessTripsCreateHrRequest
            {
                EmployeeId = "x",
                DestinationCountryCode = "xy",
                Purpose = "x",
                StartDate = new DateOnly(2023, 1, 15),
                EndDate = new DateOnly(2023, 1, 15),
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
              "destinationCountryCode": "destinationCountryCode",
              "purpose": "purpose",
              "startDate": "2026-07-01",
              "endDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "destinationCountryCode": "destinationCountryCode",
              "purpose": "purpose",
              "startDate": "2026-07-01",
              "endDate": "2026-07-01",
              "days": 1000000,
              "dailyRate": "dailyRate",
              "perDiemAmount": "perDiemAmount",
              "status": "draft",
              "payrollRunId": "payrollRunId",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/business-trips/create")
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

        var response = await Client.Hr.BusinessTripsCreateAsync(
            new BusinessTripsCreateHrRequest
            {
                EmployeeId = "employeeId",
                DestinationCountryCode = "destinationCountryCode",
                Purpose = "purpose",
                StartDate = new DateOnly(2026, 7, 1),
                EndDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
