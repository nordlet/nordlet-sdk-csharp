using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Peppol;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WebhooksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "handled": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/peppol/webhooks/recommand/companyId")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Peppol.WebhooksAsync(
            new WebhooksPeppolRequest
            {
                Provider = WebhooksPeppolRequestProvider.Recommand,
                CompanyId = "companyId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "handled": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/peppol/webhooks/recommand/companyId")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Peppol.WebhooksAsync(
            new WebhooksPeppolRequest
            {
                Provider = WebhooksPeppolRequestProvider.Recommand,
                CompanyId = "companyId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
