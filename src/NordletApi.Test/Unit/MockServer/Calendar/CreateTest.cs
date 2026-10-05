using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "title": "x",
              "dueDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "key": "x",
              "id": "x",
              "kind": "custom",
              "ruleKey": "ruleKey",
              "period": "period",
              "title": "title",
              "dueDate": "2023-01-15",
              "notes": "notes",
              "done": true,
              "href": "href",
              "submission": {
                "id": "x",
                "obligation": "obligation",
                "periodYear": 1000000,
                "periodMonth": 1000000,
                "variant": "variant",
                "status": "generated",
                "fileName": "fileName",
                "fileId": "x",
                "externalRef": "externalRef",
                "message": "message",
                "ruleKey": "ruleKey",
                "period": "period",
                "documentKey": "documentKey",
                "amendment": 1000000,
                "origin": "origin",
                "transportSystem": "transportSystem",
                "environment": "test",
                "submittedAt": "2024-01-15T09:30:00.000Z",
                "acceptedAt": "2024-01-15T09:30:00.000Z",
                "rejectedAt": "2024-01-15T09:30:00.000Z",
                "checkedAt": "2024-01-15T09:30:00.000Z",
                "nextCheckAt": "2024-01-15T09:30:00.000Z",
                "attempts": 1000000,
                "deliveryError": "deliveryError",
                "sentSha256": "sentSha256",
                "certificateFingerprint": "certificateFingerprint",
                "submittedByActorType": "submittedByActorType",
                "submittedByActorId": "submittedByActorId",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "updatedAt": "2024-01-15T09:30:00.000Z"
              },
              "submissions": [
                {
                  "id": "x",
                  "obligation": "obligation",
                  "periodYear": 1000000,
                  "periodMonth": 1000000,
                  "variant": "variant",
                  "status": "generated",
                  "fileName": "fileName",
                  "fileId": "x",
                  "externalRef": "externalRef",
                  "message": "message",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "documentKey": "documentKey",
                  "amendment": 1000000,
                  "origin": "origin",
                  "transportSystem": "transportSystem",
                  "environment": "test",
                  "submittedAt": "2024-01-15T09:30:00.000Z",
                  "acceptedAt": "2024-01-15T09:30:00.000Z",
                  "rejectedAt": "2024-01-15T09:30:00.000Z",
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "nextCheckAt": "2024-01-15T09:30:00.000Z",
                  "attempts": 1000000,
                  "deliveryError": "deliveryError",
                  "sentSha256": "sentSha256",
                  "certificateFingerprint": "certificateFingerprint",
                  "submittedByActorType": "submittedByActorType",
                  "submittedByActorId": "submittedByActorId",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "obligation": "obligation",
                  "periodYear": 1000000,
                  "periodMonth": 1000000,
                  "variant": "variant",
                  "status": "generated",
                  "fileName": "fileName",
                  "fileId": "x",
                  "externalRef": "externalRef",
                  "message": "message",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "documentKey": "documentKey",
                  "amendment": 1000000,
                  "origin": "origin",
                  "transportSystem": "transportSystem",
                  "environment": "test",
                  "submittedAt": "2024-01-15T09:30:00.000Z",
                  "acceptedAt": "2024-01-15T09:30:00.000Z",
                  "rejectedAt": "2024-01-15T09:30:00.000Z",
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "nextCheckAt": "2024-01-15T09:30:00.000Z",
                  "attempts": 1000000,
                  "deliveryError": "deliveryError",
                  "sentSha256": "sentSha256",
                  "certificateFingerprint": "certificateFingerprint",
                  "submittedByActorType": "submittedByActorType",
                  "submittedByActorId": "submittedByActorId",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "canSubmit": true,
              "canAmend": true,
              "canDownload": true,
              "automated": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/create")
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

        var response = await Client.Calendar.CreateAsync(
            new CreateCalendarRequest
            {
                Title = "x",
                DueDate = new DateOnly(2023, 1, 15),
                Notes = null,
                Done = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "title": "title",
              "dueDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "key": "key",
              "id": "id",
              "kind": "custom",
              "ruleKey": "ruleKey",
              "period": "period",
              "title": "title",
              "dueDate": "2026-07-01",
              "notes": "notes",
              "done": true,
              "href": "href",
              "submission": {
                "id": "id",
                "obligation": "obligation",
                "periodYear": 1000000,
                "periodMonth": 1000000,
                "variant": "variant",
                "status": "generated",
                "fileName": "fileName",
                "fileId": "fileId",
                "externalRef": "externalRef",
                "message": "message",
                "ruleKey": "ruleKey",
                "period": "period",
                "documentKey": "documentKey",
                "amendment": 1000000,
                "origin": "origin",
                "transportSystem": "transportSystem",
                "environment": "test",
                "submittedAt": "2026-07-01T09:30:00.000Z",
                "acceptedAt": "2026-07-01T09:30:00.000Z",
                "rejectedAt": "2026-07-01T09:30:00.000Z",
                "checkedAt": "2026-07-01T09:30:00.000Z",
                "nextCheckAt": "2026-07-01T09:30:00.000Z",
                "attempts": 1000000,
                "deliveryError": "deliveryError",
                "sentSha256": "sentSha256",
                "certificateFingerprint": "certificateFingerprint",
                "submittedByActorType": "submittedByActorType",
                "submittedByActorId": "submittedByActorId",
                "createdAt": "2026-07-01T09:30:00.000Z",
                "updatedAt": "2026-07-01T09:30:00.000Z"
              },
              "submissions": [
                {
                  "id": "id",
                  "obligation": "obligation",
                  "periodYear": 1000000,
                  "periodMonth": 1000000,
                  "variant": "variant",
                  "status": "generated",
                  "fileName": "fileName",
                  "fileId": "fileId",
                  "externalRef": "externalRef",
                  "message": "message",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "documentKey": "documentKey",
                  "amendment": 1000000,
                  "origin": "origin",
                  "transportSystem": "transportSystem",
                  "environment": "test",
                  "submittedAt": "2026-07-01T09:30:00.000Z",
                  "acceptedAt": "2026-07-01T09:30:00.000Z",
                  "rejectedAt": "2026-07-01T09:30:00.000Z",
                  "checkedAt": "2026-07-01T09:30:00.000Z",
                  "nextCheckAt": "2026-07-01T09:30:00.000Z",
                  "attempts": 1000000,
                  "deliveryError": "deliveryError",
                  "sentSha256": "sentSha256",
                  "certificateFingerprint": "certificateFingerprint",
                  "submittedByActorType": "submittedByActorType",
                  "submittedByActorId": "submittedByActorId",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "canSubmit": true,
              "canAmend": true,
              "canDownload": true,
              "automated": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/create")
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

        var response = await Client.Calendar.CreateAsync(
            new CreateCalendarRequest { Title = "title", DueDate = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
