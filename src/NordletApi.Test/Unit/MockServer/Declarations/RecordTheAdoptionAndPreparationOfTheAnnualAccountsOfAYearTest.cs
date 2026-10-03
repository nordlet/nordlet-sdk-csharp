using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecordTheAdoptionAndPreparationOfTheAnnualAccountsOfAYearTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "adopted": true,
              "dateOfPreparation": "dateOfPreparation"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "year": 1000000,
              "adopted": true,
              "adoptionDate": "adoptionDate",
              "dateOfPreparation": "dateOfPreparation",
              "audited": true,
              "auditReportQualified": true,
              "auditorNotElected": true,
              "notesText": "notesText",
              "managementReportText": "managementReportText",
              "auditorReportText": "auditorReportText",
              "auditorReportDate": "auditorReportDate",
              "resultToReserves": "resultToReserves",
              "resultToLossCompensation": "resultToLossCompensation",
              "resultToRemainder": "resultToRemainder",
              "signatures": [
                {
                  "id": "x",
                  "directorName": "directorName",
                  "directorType": "managing_current",
                  "signed": true,
                  "signedOn": "signedOn",
                  "signedAt": "signedAt",
                  "reasonNotSigned": "reasonNotSigned"
                },
                {
                  "id": "x",
                  "directorName": "directorName",
                  "directorType": "managing_current",
                  "signed": true,
                  "signedOn": "signedOn",
                  "signedAt": "signedAt",
                  "reasonNotSigned": "reasonNotSigned"
                }
              ],
              "distributions": [
                {
                  "id": "x",
                  "decidedOn": "decidedOn",
                  "kind": "dividend",
                  "amount": "amount",
                  "description": "description"
                },
                {
                  "id": "x",
                  "decidedOn": "decidedOn",
                  "kind": "dividend",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "attachments": [
                {
                  "id": "x",
                  "kind": "full_report",
                  "name": "name",
                  "fileId": "x",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "storageKey": "storageKey"
                },
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/set")
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
            await Client.Declarations.RecordTheAdoptionAndPreparationOfTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsSetRequest
                {
                    Year = 1000000,
                    Adopted = true,
                    AdoptionDate = null,
                    DateOfPreparation = "dateOfPreparation",
                    Audited = null,
                    AuditReportQualified = null,
                    AuditorNotElected = null,
                    NotesText = null,
                    ManagementReportText = null,
                    AuditorReportText = null,
                    AuditorReportDate = null,
                    ResultToReserves = null,
                    ResultToLossCompensation = null,
                    ResultToRemainder = null,
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
              "adopted": true,
              "dateOfPreparation": "dateOfPreparation"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "year": 1000000,
              "adopted": true,
              "adoptionDate": "adoptionDate",
              "dateOfPreparation": "dateOfPreparation",
              "audited": true,
              "auditReportQualified": true,
              "auditorNotElected": true,
              "notesText": "notesText",
              "managementReportText": "managementReportText",
              "auditorReportText": "auditorReportText",
              "auditorReportDate": "auditorReportDate",
              "resultToReserves": "resultToReserves",
              "resultToLossCompensation": "resultToLossCompensation",
              "resultToRemainder": "resultToRemainder",
              "signatures": [
                {
                  "id": "id",
                  "directorName": "directorName",
                  "directorType": "managing_current",
                  "signed": true,
                  "signedOn": "signedOn",
                  "signedAt": "signedAt",
                  "reasonNotSigned": "reasonNotSigned"
                }
              ],
              "distributions": [
                {
                  "id": "id",
                  "decidedOn": "decidedOn",
                  "kind": "dividend",
                  "amount": "amount",
                  "description": "description"
                }
              ],
              "attachments": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/set")
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
            await Client.Declarations.RecordTheAdoptionAndPreparationOfTheAnnualAccountsOfAYearAsync(
                new PostV1DeclarationsAnnualAccountsSetRequest
                {
                    Year = 1000000,
                    Adopted = true,
                    DateOfPreparation = "dateOfPreparation",
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
