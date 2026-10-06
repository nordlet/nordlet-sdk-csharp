using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.DocumentSeries;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
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
                  "documentType": "documentType",
                  "prefix": "prefix",
                  "name": "name",
                  "label": "label",
                  "operationTypeId": "x",
                  "numberLength": 1000000,
                  "nextNumber": 1000000,
                  "allocatedFrom": 1000000,
                  "allocatedTo": 1000000,
                  "warehouseId": "x",
                  "printSeries": true,
                  "isDefault": true,
                  "isActive": true,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "documentType": "documentType",
                  "prefix": "prefix",
                  "name": "name",
                  "label": "label",
                  "operationTypeId": "x",
                  "numberLength": 1000000,
                  "nextNumber": 1000000,
                  "allocatedFrom": 1000000,
                  "allocatedTo": 1000000,
                  "warehouseId": "x",
                  "printSeries": true,
                  "isDefault": true,
                  "isActive": true,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/document-series/list")
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

        var response = await Client.DocumentSeries.ListAsync(
            new ListDocumentSeriesRequest
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
                  "documentType": "documentType",
                  "prefix": "prefix",
                  "name": "name",
                  "label": "label",
                  "operationTypeId": "operationTypeId",
                  "numberLength": 1000000,
                  "nextNumber": 1000000,
                  "allocatedFrom": 1000000,
                  "allocatedTo": 1000000,
                  "warehouseId": "warehouseId",
                  "printSeries": true,
                  "isDefault": true,
                  "isActive": true,
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/document-series/list")
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

        var response = await Client.DocumentSeries.ListAsync(new ListDocumentSeriesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
