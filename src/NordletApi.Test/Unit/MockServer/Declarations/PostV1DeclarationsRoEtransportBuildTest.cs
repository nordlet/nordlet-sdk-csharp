using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsRoEtransportBuildTest : BaseMockServerTest
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
              "fileId": "x",
              "fileName": "fileName",
              "xml": "xml",
              "operationType": "operationType",
              "vehiclePlate": "vehiclePlate",
              "blockers": [
                "blockers",
                "blockers"
              ],
              "goods": 1000000,
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ro/etransport/build")
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

        var response = await Client.Declarations.PostV1DeclarationsRoEtransportBuildAsync(
            new PostV1DeclarationsRoEtransportBuildRequest { WaybillId = "x" }
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
              "fileId": "fileId",
              "fileName": "fileName",
              "xml": "xml",
              "operationType": "operationType",
              "vehiclePlate": "vehiclePlate",
              "blockers": [
                "blockers"
              ],
              "goods": 1000000,
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ro/etransport/build")
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

        var response = await Client.Declarations.PostV1DeclarationsRoEtransportBuildAsync(
            new PostV1DeclarationsRoEtransportBuildRequest { WaybillId = "waybillId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
