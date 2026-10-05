using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PlJpkMagGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "dateFrom": "2023-01-15",
              "dateTo": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source",
              "warehouseCode": "warehouseCode",
              "counts": {
                "pz": 1000000,
                "pw": 1000000,
                "wz": 1000000,
                "rw": 1000000,
                "rows": 1000000
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-mag/generate")
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

        var response = await Client.Declarations.PlJpkMagGenerateAsync(
            new PlJpkMagGenerateDeclarationsRequest
            {
                DateFrom = new DateOnly(2023, 1, 15),
                DateTo = new DateOnly(2023, 1, 15),
                WarehouseId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "dateFrom": "2026-07-01",
              "dateTo": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "xml": "xml",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source",
              "warehouseCode": "warehouseCode",
              "counts": {
                "pz": 1000000,
                "pw": 1000000,
                "wz": 1000000,
                "rw": 1000000,
                "rows": 1000000
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/jpk-mag/generate")
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

        var response = await Client.Declarations.PlJpkMagGenerateAsync(
            new PlJpkMagGenerateDeclarationsRequest
            {
                DateFrom = new DateOnly(2026, 7, 1),
                DateTo = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
