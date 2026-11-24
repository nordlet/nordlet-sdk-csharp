using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AgreementsPaymentScheduleGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "agreementId": "x",
              "currency": "currency",
              "value": "value",
              "rows": [
                {
                  "dueDate": "2023-01-15",
                  "principal": "principal",
                  "interest": "interest",
                  "total": "total",
                  "principalOutstanding": "principalOutstanding"
                },
                {
                  "dueDate": "2023-01-15",
                  "principal": "principal",
                  "interest": "interest",
                  "total": "total",
                  "principalOutstanding": "principalOutstanding"
                }
              ],
              "totals": {
                "principal": "principal",
                "interest": "interest",
                "total": "total"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/payment-schedule/get")
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

        var response = await Client.Agreements.AgreementsPaymentScheduleGetAsync(
            new AgreementsPaymentScheduleGetAgreementsRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "agreementId": "agreementId",
              "currency": "currency",
              "value": "value",
              "rows": [
                {
                  "dueDate": "2026-07-01",
                  "principal": "principal",
                  "interest": "interest",
                  "total": "total",
                  "principalOutstanding": "principalOutstanding"
                }
              ],
              "totals": {
                "principal": "principal",
                "interest": "interest",
                "total": "total"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/payment-schedule/get")
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

        var response = await Client.Agreements.AgreementsPaymentScheduleGetAsync(
            new AgreementsPaymentScheduleGetAgreementsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
