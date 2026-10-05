using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/list")
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

        var response = await Client.Calendar.ListAsync(
            new ListCalendarRequest
            {
                From = null,
                To = null,
                IncludeDone = null,
            }
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
              "rows": [
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
                    "status": "generated",
                    "fileName": "fileName",
                    "amendment": 1000000,
                    "origin": "origin",
                    "submittedAt": "2026-07-01T09:30:00.000Z",
                    "acceptedAt": "2026-07-01T09:30:00.000Z",
                    "rejectedAt": "2026-07-01T09:30:00.000Z",
                    "checkedAt": "2026-07-01T09:30:00.000Z",
                    "nextCheckAt": "2026-07-01T09:30:00.000Z",
                    "attempts": 1000000,
                    "createdAt": "2026-07-01T09:30:00.000Z",
                    "updatedAt": "2026-07-01T09:30:00.000Z"
                  },
                  "submissions": [
                    {
                      "id": "id",
                      "obligation": "obligation",
                      "periodYear": 1000000,
                      "status": "generated",
                      "fileName": "fileName",
                      "amendment": 1000000,
                      "origin": "origin",
                      "submittedAt": "2026-07-01T09:30:00.000Z",
                      "acceptedAt": "2026-07-01T09:30:00.000Z",
                      "rejectedAt": "2026-07-01T09:30:00.000Z",
                      "checkedAt": "2026-07-01T09:30:00.000Z",
                      "nextCheckAt": "2026-07-01T09:30:00.000Z",
                      "attempts": 1000000,
                      "createdAt": "2026-07-01T09:30:00.000Z",
                      "updatedAt": "2026-07-01T09:30:00.000Z"
                    }
                  ],
                  "canSubmit": true,
                  "canAmend": true,
                  "canDownload": true,
                  "automated": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/list")
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

        var response = await Client.Calendar.ListAsync(new ListCalendarRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
