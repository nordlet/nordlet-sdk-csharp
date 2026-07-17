using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtSaftGenerateTest : BaseMockServerTest
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
              "fileName": "fileName",
              "fileId": "x",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "counts": {
                "accounts": 1000000,
                "customers": 1000000,
                "suppliers": 1000000,
                "glTransactions": 1000000,
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000,
                "payments": 1000000,
                "stockMovements": 1000000,
                "assetTransactions": 1000000
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/saft/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSaftGenerateAsync(
            new PostV1DeclarationsLtSaftGenerateRequest
            {
                FromDate = "fromDate",
                ToDate = "toDate",
                DataType = null,
                Persist = null,
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
              "fileName": "fileName",
              "fileId": "fileId",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "counts": {
                "accounts": 1000000,
                "customers": 1000000,
                "suppliers": 1000000,
                "glTransactions": 1000000,
                "salesInvoices": 1000000,
                "purchaseInvoices": 1000000,
                "payments": 1000000,
                "stockMovements": 1000000,
                "assetTransactions": 1000000
              },
              "warnings": [
                "warnings"
              ],
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/saft/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSaftGenerateAsync(
            new PostV1DeclarationsLtSaftGenerateRequest { FromDate = "fromDate", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
