using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RemindersTheOvernightDebtReminderJobWouldSendTodayForThisCompanyTest
    : BaseMockServerTest
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
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "email": "email",
                  "locale": "lt",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "issueDate",
                      "dueDate": "dueDate",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    },
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "issueDate",
                      "dueDate": "dueDate",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    }
                  ],
                  "totalDue": "totalDue",
                  "interestDue": "interestDue"
                },
                {
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "email": "email",
                  "locale": "lt",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "issueDate",
                      "dueDate": "dueDate",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    },
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "issueDate",
                      "dueDate": "dueDate",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    }
                  ],
                  "totalDue": "totalDue",
                  "interestDue": "interestDue"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/preview")
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
            await Client.Partners.RemindersTheOvernightDebtReminderJobWouldSendTodayForThisCompanyAsync(
                new PostV1PartnersDebtRemindersPreviewRequest()
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
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "email": "email",
                  "locale": "lt",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "id",
                      "fullNumber": "fullNumber",
                      "issueDate": "issueDate",
                      "dueDate": "dueDate",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    }
                  ],
                  "totalDue": "totalDue",
                  "interestDue": "interestDue"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/preview")
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
            await Client.Partners.RemindersTheOvernightDebtReminderJobWouldSendTodayForThisCompanyAsync(
                new PostV1PartnersDebtRemindersPreviewRequest()
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
