using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecordWhetherADirectorSignedTheAnnualAccountsOfAYearTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
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
              "signedAt": "signedAt",
              "reasonNotSigned": "reasonNotSigned"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/signatures/create")
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

        var response =
            await Client.Declarations.RecordWhetherADirectorSignedTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsSignaturesCreateRequest
                {
                    Year = 1000000,
                    DirectorName = "x",
                    DirectorType =
                        PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType.ManagingCurrent,
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
              "year": 1000000,
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
              "signedAt": "signedAt",
              "reasonNotSigned": "reasonNotSigned"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/signatures/create")
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

        var response =
            await Client.Declarations.RecordWhetherADirectorSignedTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsSignaturesCreateRequest
                {
                    Year = 1000000,
                    DirectorName = "directorName",
                    DirectorType =
                        PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType.ManagingCurrent,
                    Signed = true,
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
