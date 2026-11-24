using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JournalTemplatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x",
              "lines": [
                {
                  "accountCode": "x",
                  "side": "debit"
                },
                {
                  "accountCode": "x",
                  "side": "debit"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "description": "description",
              "lines": [
                {
                  "accountCode": "x",
                  "side": "debit",
                  "description": "description",
                  "costCenterId": "x",
                  "projectId": "x",
                  "partnerId": "x"
                },
                {
                  "accountCode": "x",
                  "side": "debit",
                  "description": "description",
                  "costCenterId": "x",
                  "projectId": "x",
                  "partnerId": "x"
                }
              ],
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/templates/create")
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

        var response = await Client.Ledger.JournalTemplatesCreateAsync(
            new JournalTemplatesCreateLedgerRequest
            {
                Name = "x",
                Description = null,
                Lines = new List<JournalTemplatesCreateLedgerRequestLinesItem>()
                {
                    new JournalTemplatesCreateLedgerRequestLinesItem
                    {
                        AccountCode = "x",
                        Side = JournalTemplatesCreateLedgerRequestLinesItemSide.Debit,
                        Description = null,
                        CostCenterId = null,
                        ProjectId = null,
                        PartnerId = null,
                    },
                    new JournalTemplatesCreateLedgerRequestLinesItem
                    {
                        AccountCode = "x",
                        Side = JournalTemplatesCreateLedgerRequestLinesItemSide.Debit,
                        Description = null,
                        CostCenterId = null,
                        ProjectId = null,
                        PartnerId = null,
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
              "name": "name",
              "lines": [
                {
                  "accountCode": "accountCode",
                  "side": "debit"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "description": "description",
              "lines": [
                {
                  "accountCode": "accountCode",
                  "side": "debit",
                  "description": "description",
                  "costCenterId": "costCenterId",
                  "projectId": "projectId",
                  "partnerId": "partnerId"
                }
              ],
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/templates/create")
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

        var response = await Client.Ledger.JournalTemplatesCreateAsync(
            new JournalTemplatesCreateLedgerRequest
            {
                Name = "name",
                Lines = new List<JournalTemplatesCreateLedgerRequestLinesItem>()
                {
                    new JournalTemplatesCreateLedgerRequestLinesItem
                    {
                        AccountCode = "accountCode",
                        Side = JournalTemplatesCreateLedgerRequestLinesItemSide.Debit,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
