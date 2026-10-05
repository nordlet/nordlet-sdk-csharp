using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LtSdFfdataTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "type": "1-SD",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fileName": "fileName",
              "xml": "xml",
              "rows": 1000000,
              "pageCount": 1000000,
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/sd/ffdata")
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

        var response = await Client.Declarations.LtSdFfdataAsync(
            new LtSdFfdataDeclarationsRequest
            {
                Type = LtSdFfdataDeclarationsRequestType.OneSd,
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
                ManagerFullName = null,
                PreparatorDetails = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "type": "1-SD",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fileName": "fileName",
              "xml": "xml",
              "rows": 1000000,
              "pageCount": 1000000,
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/sd/ffdata")
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

        var response = await Client.Declarations.LtSdFfdataAsync(
            new LtSdFfdataDeclarationsRequest
            {
                Type = LtSdFfdataDeclarationsRequestType.OneSd,
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
