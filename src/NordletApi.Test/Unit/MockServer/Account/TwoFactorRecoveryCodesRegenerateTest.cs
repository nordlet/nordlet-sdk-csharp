using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TwoFactorRecoveryCodesRegenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "code": "banana"
            }
            """;

        const string mockResponse = """
            {
              "recoveryCodes": [
                "recoveryCodes",
                "recoveryCodes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/two-factor/recovery-codes/regenerate")
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

        var response = await Client.Account.TwoFactorRecoveryCodesRegenerateAsync(
            new TwoFactorRecoveryCodesRegenerateAccountRequest { Code = "banana" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "code": "code"
            }
            """;

        const string mockResponse = """
            {
              "recoveryCodes": [
                "recoveryCodes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/two-factor/recovery-codes/regenerate")
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

        var response = await Client.Account.TwoFactorRecoveryCodesRegenerateAsync(
            new TwoFactorRecoveryCodesRegenerateAccountRequest { Code = "code" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
