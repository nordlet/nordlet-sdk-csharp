using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsGlDetailTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "accountCode": "x",
              "fromDate": "fromDate",
              "toDate": "toDate"
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
                  "date": "date",
                  "description": "description",
                  "documentType": "documentType",
                  "documentId": "x",
                  "journalTransactionId": "x",
                  "debit": "debit",
                  "credit": "credit",
                  "balance": "balance"
                },
                {
                  "date": "date",
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

        var response = await Client.Reports.PostV1ReportsGlDetailAsync(
            new PostV1ReportsGlDetailRequest
            {
                AccountCode = "x",
                FromDate = "fromDate",
                ToDate = "toDate",
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
              "fromDate": "fromDate",
              "toDate": "toDate"
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
                  "date": "date",
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

        var response = await Client.Reports.PostV1ReportsGlDetailAsync(
            new PostV1ReportsGlDetailRequest
            {
                AccountCode = "accountCode",
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
