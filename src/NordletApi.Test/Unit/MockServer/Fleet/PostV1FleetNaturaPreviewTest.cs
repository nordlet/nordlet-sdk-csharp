using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FleetNaturaPreviewTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "employeeId": "x",
                  "employeeName": "employeeName",
                  "vehicleId": "x",
                  "plateNumber": "plateNumber",
                  "make": "make",
                  "model": "model",
                  "marketValue": "marketValue",
                  "employerPaysFuel": true,
                  "ratePercent": "ratePercent",
                  "amount": "amount"
                },
                {
                  "employeeId": "x",
                  "employeeName": "employeeName",
                  "vehicleId": "x",
                  "plateNumber": "plateNumber",
                  "make": "make",
                  "model": "model",
                  "marketValue": "marketValue",
                  "employerPaysFuel": true,
                  "ratePercent": "ratePercent",
                  "amount": "amount"
                }
              ],
              "total": "total"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/natura/preview")
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

        var response = await Client.Fleet.PostV1FleetNaturaPreviewAsync(
            new PostV1FleetNaturaPreviewRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "employeeId": "employeeId",
                  "employeeName": "employeeName",
                  "vehicleId": "vehicleId",
                  "plateNumber": "plateNumber",
                  "make": "make",
                  "model": "model",
                  "marketValue": "marketValue",
                  "employerPaysFuel": true,
                  "ratePercent": "ratePercent",
                  "amount": "amount"
                }
              ],
              "total": "total"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/natura/preview")
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

        var response = await Client.Fleet.PostV1FleetNaturaPreviewAsync(
            new PostV1FleetNaturaPreviewRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
