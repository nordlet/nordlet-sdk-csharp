using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DocumentSeriesUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "documentType": "documentType",
              "prefix": "prefix",
              "name": "name",
              "label": "label",
              "operationTypeId": "x",
              "numberLength": 1000000,
              "nextNumber": 1000000,
              "warehouseId": "x",
              "printSeries": true,
              "isDefault": true,
              "isActive": true,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/document-series/update")
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

        var response = await Client.Sales.PostV1DocumentSeriesUpdateAsync(
            new PostV1DocumentSeriesUpdateRequest
            {
                Id = "x",
                DocumentType = null,
                Prefix = null,
                Name = null,
                Label = null,
                OperationTypeId = null,
                NumberLength = null,
                NextNumber = null,
                WarehouseId = null,
                PrintSeries = null,
                IsDefault = null,
                IsActive = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "documentType": "documentType",
              "prefix": "prefix",
              "name": "name",
              "label": "label",
              "operationTypeId": "operationTypeId",
              "numberLength": 1000000,
              "nextNumber": 1000000,
              "warehouseId": "warehouseId",
              "printSeries": true,
              "isDefault": true,
              "isActive": true,
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/document-series/update")
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

        var response = await Client.Sales.PostV1DocumentSeriesUpdateAsync(
            new PostV1DocumentSeriesUpdateRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
