using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AttachAnUploadedDocumentToTheAnnualAccountsOfAYearTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "kind": "full_report",
              "ref": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "kind": "full_report",
              "name": "name",
              "fileId": "x",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "sizeBytes": 1000000,
              "storageKey": "storageKey"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/attachments/add")
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
            await Client.Declarations.AttachAnUploadedDocumentToTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsAttachmentsAddRequest
                {
                    Year = 1000000,
                    Kind = PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind.FullReport,
                    Name = null,
                    Ref = "x",
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
              "kind": "full_report",
              "ref": "ref"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "kind": "full_report",
              "name": "name",
              "fileId": "fileId",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "sizeBytes": 1000000,
              "storageKey": "storageKey"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/attachments/add")
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
            await Client.Declarations.AttachAnUploadedDocumentToTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsAttachmentsAddRequest
                {
                    Year = 1000000,
                    Kind = PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind.FullReport,
                    Ref = "ref",
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
