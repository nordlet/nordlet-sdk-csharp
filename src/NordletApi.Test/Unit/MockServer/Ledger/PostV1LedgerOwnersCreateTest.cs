using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerOwnersCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/owners/create")
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

        var response = await Client.Ledger.PostV1LedgerOwnersCreateAsync(
            new PostV1LedgerOwnersCreateRequest
            {
                Name = "x",
                Code = null,
                EquityAccountCode = null,
                SharesQuantity = null,
                SharesAmount = null,
                SharesType = null,
                SharesAcquisitionDate = null,
                Address = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
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
                "countryCode": "countryCode"
              },
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/owners/create")
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

        var response = await Client.Ledger.PostV1LedgerOwnersCreateAsync(
            new PostV1LedgerOwnersCreateRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
