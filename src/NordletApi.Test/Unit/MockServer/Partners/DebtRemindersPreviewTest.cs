using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DebtRemindersPreviewTest : BaseMockServerTest
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
                  "locale": "en",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "dueDate": "2023-01-15",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    },
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "dueDate": "2023-01-15",
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
                  "locale": "en",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "dueDate": "2023-01-15",
                      "remaining": "remaining",
                      "daysLate": 1000000,
                      "interest": "interest"
                    },
                    {
                      "id": "x",
                      "fullNumber": "fullNumber",
                      "issueDate": "2023-01-15",
                      "dueDate": "2023-01-15",
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

        var response = await Client.Partners.DebtRemindersPreviewAsync(
            new DebtRemindersPreviewPartnersRequest()
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
                  "locale": "en",
                  "currency": "currency",
                  "invoices": [
                    {
                      "id": "id",
                      "fullNumber": "fullNumber",
                      "issueDate": "2026-07-01",
                      "dueDate": "2026-07-01",
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

        var response = await Client.Partners.DebtRemindersPreviewAsync(
            new DebtRemindersPreviewPartnersRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
