using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Peppol;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ParticipantsLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "participantId": "participantId",
              "registered": true,
              "smpUrl": "smpUrl",
              "accessPointUrl": "accessPointUrl",
              "acceptsInvoice": true,
              "acceptsCreditNote": true,
              "acceptsCii": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/peppol/participants/lookup")
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

        var response = await Client.Peppol.ParticipantsLookupAsync(
            new ParticipantsLookupPeppolRequest { PartnerId = null, ParticipantId = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "participantId": "participantId",
              "registered": true,
              "smpUrl": "smpUrl",
              "accessPointUrl": "accessPointUrl",
              "acceptsInvoice": true,
              "acceptsCreditNote": true,
              "acceptsCii": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/peppol/participants/lookup")
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

        var response = await Client.Peppol.ParticipantsLookupAsync(
            new ParticipantsLookupPeppolRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
