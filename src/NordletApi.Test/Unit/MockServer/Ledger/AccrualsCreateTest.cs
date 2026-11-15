using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AccrualsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "2023-01-15",
              "reason": "x",
              "lines": [
                {
                  "accountCode": "x"
                },
                {
                  "accountCode": "x"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "reversalId": "x",
              "date": "2023-01-15",
              "reversalDate": "2023-01-15"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/accruals/create")
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

        var response = await Client.Ledger.AccrualsCreateAsync(
            new AccrualsCreateLedgerRequest
            {
                Date = new DateOnly(2023, 1, 15),
                Reason = "x",
                Lines = new List<AccrualsCreateLedgerRequestLinesItem>()
                {
                    new AccrualsCreateLedgerRequestLinesItem
                    {
                        AccountCode = "x",
                        Debit = null,
                        Credit = null,
                        PartnerId = null,
                        Description = null,
                    },
                    new AccrualsCreateLedgerRequestLinesItem
                    {
                        AccountCode = "x",
                        Debit = null,
                        Credit = null,
                        PartnerId = null,
                        Description = null,
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
              "date": "2026-07-01",
              "reason": "reason",
              "lines": [
                {
                  "accountCode": "accountCode"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "reversalId": "reversalId",
              "date": "2026-07-01",
              "reversalDate": "2026-07-01"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/accruals/create")
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

        var response = await Client.Ledger.AccrualsCreateAsync(
            new AccrualsCreateLedgerRequest
            {
                Date = new DateOnly(2026, 7, 1),
                Reason = "reason",
                Lines = new List<AccrualsCreateLedgerRequestLinesItem>()
                {
                    new AccrualsCreateLedgerRequestLinesItem { AccountCode = "accountCode" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
