using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TableSettingsSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "tableKey": "x"
            }
            """;

        const string mockResponse = """
            {
              "tableKey": "tableKey",
              "columns": [
                "columns",
                "columns"
              ],
              "pageSize": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/table-settings/set")
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

        var response = await Client.Account.TableSettingsSetAsync(
            new TableSettingsSetAccountRequest
            {
                TableKey = "x",
                Columns = null,
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
              "tableKey": "tableKey"
            }
            """;

        const string mockResponse = """
            {
              "tableKey": "tableKey",
              "columns": [
                "columns"
              ],
              "pageSize": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/table-settings/set")
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

        var response = await Client.Account.TableSettingsSetAsync(
            new TableSettingsSetAccountRequest { TableKey = "tableKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
