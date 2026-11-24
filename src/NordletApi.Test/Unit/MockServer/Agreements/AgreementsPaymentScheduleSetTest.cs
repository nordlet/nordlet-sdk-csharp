using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AgreementsPaymentScheduleSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "rows": [
                {
                  "dueDate": "2023-01-15",
                  "principal": "principal",
                  "interest": "interest"
                },
                {
                  "dueDate": "2023-01-15",
                  "principal": "principal",
                  "interest": "interest"
                }
              ]
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
                    .WithPath("/v1/agreements/agreements/payment-schedule/set")
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

        var response = await Client.Agreements.AgreementsPaymentScheduleSetAsync(
            new AgreementsPaymentScheduleSetAgreementsRequest
            {
                Id = "x",
                Rows = new List<AgreementsPaymentScheduleSetAgreementsRequestRowsItem>()
                {
                    new AgreementsPaymentScheduleSetAgreementsRequestRowsItem
                    {
                        DueDate = new DateOnly(2023, 1, 15),
                        Principal = "principal",
                        Interest = "interest",
                    },
                    new AgreementsPaymentScheduleSetAgreementsRequestRowsItem
                    {
                        DueDate = new DateOnly(2023, 1, 15),
                        Principal = "principal",
                        Interest = "interest",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "rows": [
                {
                  "dueDate": "2026-07-01",
                  "principal": "121.0000",
                  "interest": "121.0000"
                }
              ]
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
                    .WithPath("/v1/agreements/agreements/payment-schedule/set")
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

        var response = await Client.Agreements.AgreementsPaymentScheduleSetAsync(
            new AgreementsPaymentScheduleSetAgreementsRequest
            {
                Id = "id",
                Rows = new List<AgreementsPaymentScheduleSetAgreementsRequestRowsItem>()
                {
                    new AgreementsPaymentScheduleSetAgreementsRequestRowsItem
                    {
                        DueDate = new DateOnly(2026, 7, 1),
                        Principal = "121.0000",
                        Interest = "121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
