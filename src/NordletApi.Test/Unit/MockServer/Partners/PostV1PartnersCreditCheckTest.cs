using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersCreditCheckTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x"
            }
            """;

        const string mockResponse = """
            {
              "partnerId": "x",
              "partnerName": "partnerName",
              "creditLimit": "creditLimit",
              "openReceivables": "openReceivables",
              "additionalAmount": "additionalAmount",
              "totalExposure": "totalExposure",
              "available": "available",
              "exceeded": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/credit-check")
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

        var response = await Client.Partners.PostV1PartnersCreditCheckAsync(
            new PostV1PartnersCreditCheckRequest { PartnerId = "x", AdditionalAmount = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "partnerId": "partnerId"
            }
            """;

        const string mockResponse = """
            {
              "partnerId": "partnerId",
              "partnerName": "partnerName",
              "creditLimit": "creditLimit",
              "openReceivables": "openReceivables",
              "additionalAmount": "additionalAmount",
              "totalExposure": "totalExposure",
              "available": "available",
              "exceeded": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/credit-check")
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

        var response = await Client.Partners.PostV1PartnersCreditCheckAsync(
            new PostV1PartnersCreditCheckRequest { PartnerId = "partnerId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
