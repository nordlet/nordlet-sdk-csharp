using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CalendarListTest : BaseMockServerTest
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
                  "dueDate": "dueDate",
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
                    "origin": "origin",
                    "transportSystem": "transportSystem",
                    "submittedAt": "submittedAt",
                    "acceptedAt": "acceptedAt",
                    "rejectedAt": "rejectedAt",
                    "checkedAt": "checkedAt",
                    "nextCheckAt": "nextCheckAt",
                    "attempts": 1000000,
                    "deliveryError": "deliveryError",
                    "sentSha256": "sentSha256",
                    "certificateFingerprint": "certificateFingerprint",
                    "submittedByActorType": "submittedByActorType",
                    "submittedByActorId": "submittedByActorId",
                    "createdAt": "createdAt",
                    "updatedAt": "updatedAt"
                  },
                  "canSubmit": true,
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
                  "dueDate": "dueDate",
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
                    "origin": "origin",
                    "transportSystem": "transportSystem",
                    "submittedAt": "submittedAt",
                    "acceptedAt": "acceptedAt",
                    "rejectedAt": "rejectedAt",
                    "checkedAt": "checkedAt",
                    "nextCheckAt": "nextCheckAt",
                    "attempts": 1000000,
                    "deliveryError": "deliveryError",
                    "sentSha256": "sentSha256",
                    "certificateFingerprint": "certificateFingerprint",
                    "submittedByActorType": "submittedByActorType",
                    "submittedByActorId": "submittedByActorId",
                    "createdAt": "createdAt",
                    "updatedAt": "updatedAt"
                  },
                  "canSubmit": true,
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

        var response = await Client.Calendar.PostV1CalendarListAsync(
            new PostV1CalendarListRequest
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
                  "dueDate": "dueDate",
                  "notes": "notes",
                  "done": true,
                  "href": "href",
                  "submission": {
                    "id": "id",
                    "obligation": "obligation",
                    "periodYear": 1000000,
                    "status": "generated",
                    "fileName": "fileName",
                    "origin": "origin",
                    "attempts": 1000000,
                    "createdAt": "createdAt",
                    "updatedAt": "updatedAt"
                  },
                  "canSubmit": true,
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

        var response = await Client.Calendar.PostV1CalendarListAsync(
            new PostV1CalendarListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
