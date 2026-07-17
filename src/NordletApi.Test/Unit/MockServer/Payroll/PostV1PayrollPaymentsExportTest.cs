using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollPaymentsExportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "runId": "x",
              "bankAccountId": "x"
            }
            """;

        const string mockResponse = """
            {
              "messageId": "messageId",
              "fileName": "fileName",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/payments/export")
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

        var response = await Client.Payroll.PostV1PayrollPaymentsExportAsync(
            new PostV1PayrollPaymentsExportRequest
            {
                RunId = "x",
                BankAccountId = "x",
                ExecutionDate = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "runId": "runId",
              "bankAccountId": "bankAccountId"
            }
            """;

        const string mockResponse = """
            {
              "messageId": "messageId",
              "fileName": "fileName",
              "transactionCount": 1000000,
              "controlSum": "controlSum",
              "xml": "xml"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/payments/export")
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

        var response = await Client.Payroll.PostV1PayrollPaymentsExportAsync(
            new PostV1PayrollPaymentsExportRequest
            {
                RunId = "runId",
                BankAccountId = "bankAccountId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
