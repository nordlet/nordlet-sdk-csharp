using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AgreementsUpdateTest : BaseMockServerTest
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
              "kind": "customer",
              "partnerId": "x",
              "employeeId": "x",
              "bankAccountId": "x",
              "number": "number",
              "name": "name",
              "startDate": "2023-01-15",
              "endDate": "2023-01-15",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "documentRef": "documentRef",
              "createdAt": "2024-01-15T09:30:00.000Z",
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
                    .WithPath("/v1/agreements/agreements/update")
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

        var response = await Client.Agreements.AgreementsUpdateAsync(
            new AgreementsUpdateAgreementsRequest
            {
                Id = "x",
                TypeId = null,
                Kind = null,
                Name = null,
                EndDate = null,
                AutoRenew = null,
                Value = null,
                BillingPeriod = null,
                Status = null,
                Notes = null,
                DocumentRef = null,
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
              "typeId": "typeId",
              "kind": "customer",
              "partnerId": "partnerId",
              "employeeId": "employeeId",
              "bankAccountId": "bankAccountId",
              "number": "number",
              "name": "name",
              "startDate": "2026-07-01",
              "endDate": "2026-07-01",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "documentRef": "documentRef",
              "createdAt": "2026-07-01T09:30:00.000Z",
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
                    .WithPath("/v1/agreements/agreements/update")
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

        var response = await Client.Agreements.AgreementsUpdateAsync(
            new AgreementsUpdateAgreementsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
