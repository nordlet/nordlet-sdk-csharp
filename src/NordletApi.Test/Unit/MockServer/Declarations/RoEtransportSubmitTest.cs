using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RoEtransportSubmitTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "waybillId": "x"
            }
            """;

        const string mockResponse = """
            {
              "waybillId": "x",
              "reference": "reference",
              "state": "submitted",
              "uit": "uit",
              "detail": "detail",
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
                    .WithPath("/v1/declarations/ro/etransport/submit")
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

        var response = await Client.Declarations.RoEtransportSubmitAsync(
            new RoEtransportSubmitDeclarationsRequest { WaybillId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "waybillId": "waybillId"
            }
            """;

        const string mockResponse = """
            {
              "waybillId": "waybillId",
              "reference": "reference",
              "state": "submitted",
              "uit": "uit",
              "detail": "detail",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ro/etransport/submit")
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

        var response = await Client.Declarations.RoEtransportSubmitAsync(
            new RoEtransportSubmitDeclarationsRequest { WaybillId = "waybillId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
