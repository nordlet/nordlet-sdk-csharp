using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RunsReverseTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "reason": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "year": 1000000,
              "month": 1000000,
              "countryCode": "countryCode",
              "payDate": "2023-01-15",
              "status": "draft",
              "grossTotal": "grossTotal",
              "taxAllowanceTotal": "taxAllowanceTotal",
              "incomeTaxTotal": "incomeTaxTotal",
              "employeeContributionsTotal": "employeeContributionsTotal",
              "employerContributionsTotal": "employerContributionsTotal",
              "componentTotals": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                },
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "netTotal": "netTotal",
              "paidAmount": "paidAmount",
              "journalTransactionId": "x",
              "notes": "notes",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "createdAt": "2024-01-15T09:30:00.000Z",
              "approvedAt": "2024-01-15T09:30:00.000Z",
              "reversedAt": "2024-01-15T09:30:00.000Z",
              "reversalJournalTransactionId": "x",
              "reversalReason": "reversalReason"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/reverse")
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

        var response = await Client.Payroll.RunsReverseAsync(
            new RunsReversePayrollRequest { Id = "x", Reason = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "reason": "reason"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "year": 1000000,
              "month": 1000000,
              "countryCode": "countryCode",
              "payDate": "2026-07-01",
              "status": "draft",
              "grossTotal": "grossTotal",
              "taxAllowanceTotal": "taxAllowanceTotal",
              "incomeTaxTotal": "incomeTaxTotal",
              "employeeContributionsTotal": "employeeContributionsTotal",
              "employerContributionsTotal": "employerContributionsTotal",
              "componentTotals": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "netTotal": "netTotal",
              "paidAmount": "paidAmount",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "warnings": [
                "warnings"
              ],
              "createdAt": "2026-07-01T09:30:00.000Z",
              "approvedAt": "2026-07-01T09:30:00.000Z",
              "reversedAt": "2026-07-01T09:30:00.000Z",
              "reversalJournalTransactionId": "reversalJournalTransactionId",
              "reversalReason": "reversalReason"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/reverse")
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

        var response = await Client.Payroll.RunsReverseAsync(
            new RunsReversePayrollRequest { Id = "id", Reason = "reason" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
