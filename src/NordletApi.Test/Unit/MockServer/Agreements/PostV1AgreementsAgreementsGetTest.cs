using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AgreementsAgreementsGetTest : BaseMockServerTest
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
              "typeId": "x",
              "partnerId": "x",
              "number": "number",
              "name": "name",
              "startDate": "startDate",
              "endDate": "endDate",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "createdAt": "createdAt",
              "items": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent"
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/get")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsGetAsync(
            new PostV1AgreementsAgreementsGetRequest { Id = "x" }
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
              "typeId": "typeId",
              "partnerId": "partnerId",
              "number": "number",
              "name": "name",
              "startDate": "startDate",
              "endDate": "endDate",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "createdAt": "createdAt",
              "items": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/get")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsGetAsync(
            new PostV1AgreementsAgreementsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
