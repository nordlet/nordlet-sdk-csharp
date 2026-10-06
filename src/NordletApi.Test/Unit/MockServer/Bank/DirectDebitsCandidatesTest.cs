using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DirectDebitsCandidatesTest : BaseMockServerTest
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
                  "fullNumber": "fullNumber",
                  "issueDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "remaining": "remaining",
                  "mandateId": "x",
                  "mandateReference": "mandateReference",
                  "mandateSignatureDate": "2023-01-15"
                },
                {
                  "id": "x",
                  "fullNumber": "fullNumber",
                  "issueDate": "2023-01-15",
                  "dueDate": "2023-01-15",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "remaining": "remaining",
                  "mandateId": "x",
                  "mandateReference": "mandateReference",
                  "mandateSignatureDate": "2023-01-15"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/direct-debits/candidates")
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

        var response = await Client.Bank.DirectDebitsCandidatesAsync(
            new DirectDebitsCandidatesBankRequest
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
                  "fullNumber": "fullNumber",
                  "issueDate": "2026-07-01",
                  "dueDate": "2026-07-01",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "remaining": "remaining",
                  "mandateId": "mandateId",
                  "mandateReference": "mandateReference",
                  "mandateSignatureDate": "2026-07-01"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/direct-debits/candidates")
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

        var response = await Client.Bank.DirectDebitsCandidatesAsync(
            new DirectDebitsCandidatesBankRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
