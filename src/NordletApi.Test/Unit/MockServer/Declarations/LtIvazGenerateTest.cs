using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LtIvazGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "waybillIds": [
                "waybillIds",
                "waybillIds"
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "fileId": "x",
              "counts": {
                "documents": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/ivaz/generate")
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

        var response = await Client.Declarations.LtIvazGenerateAsync(
            new LtIvazGenerateDeclarationsRequest
            {
                WaybillIds = new List<string>() { "waybillIds", "waybillIds" },
                Persist = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "waybillIds": [
                "waybillIds"
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "fileId": "fileId",
              "counts": {
                "documents": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/ivaz/generate")
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

        var response = await Client.Declarations.LtIvazGenerateAsync(
            new LtIvazGenerateDeclarationsRequest
            {
                WaybillIds = new List<string>() { "waybillIds" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
