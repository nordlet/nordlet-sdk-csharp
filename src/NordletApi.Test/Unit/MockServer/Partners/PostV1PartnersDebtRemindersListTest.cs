using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersDebtRemindersListTest : BaseMockServerTest
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
                  "id": "x",
                  "partnerId": "x",
                  "sentTo": "sentTo",
                  "invoiceCount": 1000000,
                  "totalDue": "totalDue",
                  "interestDue": "interestDue",
                  "currency": "currency",
                  "invoiceIds": [
                    "invoiceIds",
                    "invoiceIds"
                  ],
                  "sentAt": "sentAt"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "sentTo": "sentTo",
                  "invoiceCount": 1000000,
                  "totalDue": "totalDue",
                  "interestDue": "interestDue",
                  "currency": "currency",
                  "invoiceIds": [
                    "invoiceIds",
                    "invoiceIds"
                  ],
                  "sentAt": "sentAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/list")
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

        var response = await Client.Partners.PostV1PartnersDebtRemindersListAsync(
            new PostV1PartnersDebtRemindersListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
                  "id": "id",
                  "partnerId": "partnerId",
                  "sentTo": "sentTo",
                  "invoiceCount": 1000000,
                  "totalDue": "totalDue",
                  "interestDue": "interestDue",
                  "currency": "currency",
                  "invoiceIds": [
                    "invoiceIds"
                  ],
                  "sentAt": "sentAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/debt-reminders/list")
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

        var response = await Client.Partners.PostV1PartnersDebtRemindersListAsync(
            new PostV1PartnersDebtRemindersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
