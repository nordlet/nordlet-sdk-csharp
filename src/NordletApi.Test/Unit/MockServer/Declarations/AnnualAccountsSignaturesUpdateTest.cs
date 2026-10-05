using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AnnualAccountsSignaturesUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "directorName": "x",
              "directorType": "managing_current",
              "signed": true
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "directorName": "directorName",
              "directorType": "managing_current",
              "signed": true,
              "signedOn": "signedOn",
              "signedAt": "2024-01-15T09:30:00.000Z",
              "reasonNotSigned": "reasonNotSigned"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/signatures/update")
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

        var response = await Client.Declarations.AnnualAccountsSignaturesUpdateAsync(
            new AnnualAccountsSignaturesUpdateDeclarationsRequest
            {
                Id = "x",
                DirectorName = "x",
                DirectorType =
                    AnnualAccountsSignaturesUpdateDeclarationsRequestDirectorType.ManagingCurrent,
                Signed = true,
                SignedOn = null,
                SignedAt = null,
                ReasonNotSigned = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "directorName": "directorName",
              "directorType": "managing_current",
              "signed": true
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "directorName": "directorName",
              "directorType": "managing_current",
              "signed": true,
              "signedOn": "signedOn",
              "signedAt": "2026-07-01T09:30:00.000Z",
              "reasonNotSigned": "reasonNotSigned"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/signatures/update")
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

        var response = await Client.Declarations.AnnualAccountsSignaturesUpdateAsync(
            new AnnualAccountsSignaturesUpdateDeclarationsRequest
            {
                Id = "id",
                DirectorName = "directorName",
                DirectorType =
                    AnnualAccountsSignaturesUpdateDeclarationsRequestDirectorType.ManagingCurrent,
                Signed = true,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
