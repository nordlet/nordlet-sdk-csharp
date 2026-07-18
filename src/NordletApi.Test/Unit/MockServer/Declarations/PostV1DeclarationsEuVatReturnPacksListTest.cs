using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuVatReturnPacksListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "packs": [
                {
                  "countryCode": "countryCode",
                  "formKey": "formKey",
                  "formName": "formName",
                  "frequency": "monthly",
                  "source": "source"
                },
                {
                  "countryCode": "countryCode",
                  "formKey": "formKey",
                  "formName": "formName",
                  "frequency": "monthly",
                  "source": "source"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/vat-return/packs/list")
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

        var response = await Client.Declarations.PostV1DeclarationsEuVatReturnPacksListAsync(
            new PostV1DeclarationsEuVatReturnPacksListRequest()
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
              "packs": [
                {
                  "countryCode": "countryCode",
                  "formKey": "formKey",
                  "formName": "formName",
                  "frequency": "monthly",
                  "source": "source"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/vat-return/packs/list")
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

        var response = await Client.Declarations.PostV1DeclarationsEuVatReturnPacksListAsync(
            new PostV1DeclarationsEuVatReturnPacksListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
