using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AgreementsAgreementsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "number": "x",
              "startDate": "startDate"
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
              "startDate": "startDate",
              "endDate": "endDate",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "documentRef": "documentRef",
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
                    .WithPath("/v1/agreements/agreements/create")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsCreateAsync(
            new PostV1AgreementsAgreementsCreateRequest
            {
                TypeId = null,
                Kind = null,
                PartnerId = null,
                EmployeeId = null,
                BankAccountId = null,
                Number = "x",
                Name = null,
                StartDate = "startDate",
                EndDate = null,
                AutoRenew = null,
                Value = null,
                BillingPeriod = null,
                Currency = null,
                Status = null,
                Notes = null,
                DocumentRef = null,
                Items = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "number": "number",
              "startDate": "startDate"
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
              "startDate": "startDate",
              "endDate": "endDate",
              "autoRenew": true,
              "value": "value",
              "billingPeriod": "monthly",
              "currency": "currency",
              "status": "draft",
              "notes": "notes",
              "documentRef": "documentRef",
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
                    .WithPath("/v1/agreements/agreements/create")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsCreateAsync(
            new PostV1AgreementsAgreementsCreateRequest
            {
                Number = "number",
                StartDate = "startDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
