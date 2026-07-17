using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1EcommerceOrdersListTest : BaseMockServerTest
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
                  "channel": "channel",
                  "externalRef": "externalRef",
                  "partnerId": "x",
                  "warehouseId": "x",
                  "currency": "currency",
                  "status": "new",
                  "invoiceId": "x",
                  "shipToCountryCode": "shipToCountryCode",
                  "marketplace": "marketplace",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "channel": "channel",
                  "externalRef": "externalRef",
                  "partnerId": "x",
                  "warehouseId": "x",
                  "currency": "currency",
                  "status": "new",
                  "invoiceId": "x",
                  "shipToCountryCode": "shipToCountryCode",
                  "marketplace": "marketplace",
                  "notes": "notes",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/orders/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceOrdersListAsync(
            new PostV1EcommerceOrdersListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
                  "channel": "channel",
                  "externalRef": "externalRef",
                  "partnerId": "partnerId",
                  "warehouseId": "warehouseId",
                  "currency": "currency",
                  "status": "new",
                  "invoiceId": "invoiceId",
                  "shipToCountryCode": "shipToCountryCode",
                  "marketplace": "marketplace",
                  "notes": "notes",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/orders/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceOrdersListAsync(
            new PostV1EcommerceOrdersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
