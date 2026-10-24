using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DebtRemindersUpcomingTest : BaseMockServerTest
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
                  "date": "2023-01-15",
                  "kind": "before_due",
                  "invoiceId": "x",
                  "fullNumber": "fullNumber",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "dueDate": "2023-01-15",
                  "remaining": "remaining",
                  "currency": "currency"
                },
                {
                  "date": "2023-01-15",
                  "kind": "before_due",
                  "invoiceId": "x",
                  "fullNumber": "fullNumber",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "dueDate": "2023-01-15",
                  "remaining": "remaining",
                  "currency": "currency"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/upcoming")
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

        var response = await Client.Partners.DebtRemindersUpcomingAsync(
            new DebtRemindersUpcomingPartnersRequest()
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
                  "date": "2026-07-01",
                  "kind": "before_due",
                  "invoiceId": "invoiceId",
                  "fullNumber": "fullNumber",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "dueDate": "2026-07-01",
                  "remaining": "remaining",
                  "currency": "currency"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/upcoming")
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

        var response = await Client.Partners.DebtRemindersUpcomingAsync(
            new DebtRemindersUpcomingPartnersRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
