using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerOwnersListTest : BaseMockServerTest
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
                  "name": "name",
                  "code": "code",
                  "equityAccountCode": "equityAccountCode",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "sharesAcquisitionDate": "sharesAcquisitionDate",
                  "address": {
                    "street": "street",
                    "city": "city",
                    "postalCode": "postalCode",
                    "countryCode": "xy"
                  },
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "name": "name",
                  "code": "code",
                  "equityAccountCode": "equityAccountCode",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "sharesAcquisitionDate": "sharesAcquisitionDate",
                  "address": {
                    "street": "street",
                    "city": "city",
                    "postalCode": "postalCode",
                    "countryCode": "xy"
                  },
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
                    .WithPath("/v1/ledger/owners/list")
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

        var response = await Client.Ledger.PostV1LedgerOwnersListAsync(
            new PostV1LedgerOwnersListRequest
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
                  "name": "name",
                  "code": "code",
                  "equityAccountCode": "equityAccountCode",
                  "sharesQuantity": "sharesQuantity",
                  "sharesAmount": "sharesAmount",
                  "sharesType": "sharesType",
                  "sharesAcquisitionDate": "sharesAcquisitionDate",
                  "address": {},
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
                    .WithPath("/v1/ledger/owners/list")
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

        var response = await Client.Ledger.PostV1LedgerOwnersListAsync(
            new PostV1LedgerOwnersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
