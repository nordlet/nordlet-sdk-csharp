using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsGeneralJournalTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "fromDate",
              "toDate": "toDate"
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
                  "date": "date",
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
                  "date": "date",
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

        var response = await Client.Reports.PostV1ReportsGeneralJournalAsync(
            new PostV1ReportsGeneralJournalRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
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
              "fromDate": "fromDate",
              "toDate": "toDate"
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
                  "date": "date",
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

        var response = await Client.Reports.PostV1ReportsGeneralJournalAsync(
            new PostV1ReportsGeneralJournalRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
