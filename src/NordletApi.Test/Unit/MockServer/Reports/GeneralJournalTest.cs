using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GeneralJournalTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "total": 1000000,
              "page": 1000000,
              "pageSize": 1000000,
              "rows": [
                {
                  "id": "x",
                  "date": "2023-01-15",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "x",
                  "entries": [
                    {
                      "accountCode": "accountCode",
                      "accountName": "accountName",
                      "debit": "debit",
                      "credit": "credit"
                    },
                    {
                      "accountCode": "accountCode",
                      "accountName": "accountName",
                      "debit": "debit",
                      "credit": "credit"
                    }
                  ]
                },
                {
                  "id": "x",
                  "date": "2023-01-15",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "x",
                  "entries": [
                    {
                      "accountCode": "accountCode",
                      "accountName": "accountName",
                      "debit": "debit",
                      "credit": "credit"
                    },
                    {
                      "accountCode": "accountCode",
                      "accountName": "accountName",
                      "debit": "debit",
                      "credit": "credit"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/general-journal")
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

        var response = await Client.Reports.GeneralJournalAsync(
            new GeneralJournalReportsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
                Page = null,
                PageSize = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "total": 1000000,
              "page": 1000000,
              "pageSize": 1000000,
              "rows": [
                {
                  "id": "id",
                  "date": "2026-07-01",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "entries": [
                    {
                      "accountCode": "accountCode",
                      "accountName": "accountName",
                      "debit": "debit",
                      "credit": "credit"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/general-journal")
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

        var response = await Client.Reports.GeneralJournalAsync(
            new GeneralJournalReportsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
