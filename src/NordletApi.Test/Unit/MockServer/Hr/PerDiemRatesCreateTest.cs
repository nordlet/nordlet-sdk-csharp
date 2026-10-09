using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PerDiemRatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "countryCode": "xy",
              "dailyAmount": "dailyAmount",
              "validFrom": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "countryCode": "countryCode",
              "dailyAmount": "dailyAmount",
              "validFrom": "validFrom",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/per-diem-rates/create")
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

        var response = await Client.Hr.PerDiemRatesCreateAsync(
            new PerDiemRatesCreateHrRequest
            {
                CountryCode = "xy",
                DailyAmount = "dailyAmount",
                ValidFrom = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "countryCode": "countryCode",
              "dailyAmount": "121.00",
              "validFrom": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "countryCode": "countryCode",
              "dailyAmount": "dailyAmount",
              "validFrom": "validFrom",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/per-diem-rates/create")
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

        var response = await Client.Hr.PerDiemRatesCreateAsync(
            new PerDiemRatesCreateHrRequest
            {
                CountryCode = "countryCode",
                DailyAmount = "121.00",
                ValidFrom = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
