using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GlDetailTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "accountCode": "x",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "account": {
                "code": "code",
                "name": "name",
                "type": "type"
              },
              "opening": "opening",
              "closing": "closing",
              "rows": [
                {
                  "date": "2023-01-15",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "x",
                  "journalTransactionId": "x",
                  "debit": "debit",
                  "credit": "credit",
                  "balance": "balance"
                },
                {
                  "date": "2023-01-15",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "x",
                  "journalTransactionId": "x",
                  "debit": "debit",
                  "credit": "credit",
                  "balance": "balance"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/gl-detail")
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

        var response = await Client.Reports.GlDetailAsync(
            new GlDetailReportsRequest
            {
                AccountCode = "x",
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "accountCode": "accountCode",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "account": {
                "code": "code",
                "name": "name",
                "type": "type"
              },
              "opening": "opening",
              "closing": "closing",
              "rows": [
                {
                  "date": "2026-07-01",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "journalTransactionId": "journalTransactionId",
                  "debit": "debit",
                  "credit": "credit",
                  "balance": "balance"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/gl-detail")
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

        var response = await Client.Reports.GlDetailAsync(
            new GlDetailReportsRequest
            {
                AccountCode = "accountCode",
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
