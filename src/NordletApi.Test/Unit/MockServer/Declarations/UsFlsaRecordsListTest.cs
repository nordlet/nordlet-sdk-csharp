using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsFlsaRecordsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "2023-01-15",
              "to": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "employees": [
                {
                  "employeeId": "employeeId",
                  "code": "code",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "address": {
                    "street": "street",
                    "city": "city",
                    "subdivision": "subdivision",
                    "postalCode": "postalCode"
                  },
                  "birthDate": "2023-01-15",
                  "sex": "M",
                  "occupation": "occupation",
                  "workweekStart": {
                    "day": "day",
                    "time": "time"
                  },
                  "exempt": true,
                  "workweeks": [
                    {
                      "start": "start",
                      "end": "end",
                      "hours": "hours",
                      "overtimeHours": "overtimeHours",
                      "days": [
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        },
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        }
                      ],
                      "regularRate": "regularRate",
                      "straightTimeEarnings": "straightTimeEarnings"
                    },
                    {
                      "start": "start",
                      "end": "end",
                      "hours": "hours",
                      "overtimeHours": "overtimeHours",
                      "days": [
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        },
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        }
                      ],
                      "regularRate": "regularRate",
                      "straightTimeEarnings": "straightTimeEarnings"
                    }
                  ],
                  "payPeriods": [
                    {
                      "runId": "runId",
                      "periodStart": "periodStart",
                      "periodEnd": "periodEnd",
                      "payDate": "2023-01-15",
                      "basisOfPay": {
                        "salaryType": "salaryType",
                        "rate": "rate"
                      },
                      "hoursWorked": "hoursWorked",
                      "regularPay": "regularPay",
                      "overtimePay": "overtimePay",
                      "overtimeHours": "overtimeHours",
                      "straightTimeEarnings": "straightTimeEarnings",
                      "overtimePremium": "overtimePremium",
                      "additions": [
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        },
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        }
                      ],
                      "deductions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        },
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "totalWages": "totalWages"
                    },
                    {
                      "runId": "runId",
                      "periodStart": "periodStart",
                      "periodEnd": "periodEnd",
                      "payDate": "2023-01-15",
                      "basisOfPay": {
                        "salaryType": "salaryType",
                        "rate": "rate"
                      },
                      "hoursWorked": "hoursWorked",
                      "regularPay": "regularPay",
                      "overtimePay": "overtimePay",
                      "overtimeHours": "overtimeHours",
                      "straightTimeEarnings": "straightTimeEarnings",
                      "overtimePremium": "overtimePremium",
                      "additions": [
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        },
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        }
                      ],
                      "deductions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        },
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "totalWages": "totalWages"
                    }
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "code": "code",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "address": {
                    "street": "street",
                    "city": "city",
                    "subdivision": "subdivision",
                    "postalCode": "postalCode"
                  },
                  "birthDate": "2023-01-15",
                  "sex": "M",
                  "occupation": "occupation",
                  "workweekStart": {
                    "day": "day",
                    "time": "time"
                  },
                  "exempt": true,
                  "workweeks": [
                    {
                      "start": "start",
                      "end": "end",
                      "hours": "hours",
                      "overtimeHours": "overtimeHours",
                      "days": [
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        },
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        }
                      ],
                      "regularRate": "regularRate",
                      "straightTimeEarnings": "straightTimeEarnings"
                    },
                    {
                      "start": "start",
                      "end": "end",
                      "hours": "hours",
                      "overtimeHours": "overtimeHours",
                      "days": [
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        },
                        {
                          "date": "2023-01-15",
                          "hours": "hours"
                        }
                      ],
                      "regularRate": "regularRate",
                      "straightTimeEarnings": "straightTimeEarnings"
                    }
                  ],
                  "payPeriods": [
                    {
                      "runId": "runId",
                      "periodStart": "periodStart",
                      "periodEnd": "periodEnd",
                      "payDate": "2023-01-15",
                      "basisOfPay": {
                        "salaryType": "salaryType",
                        "rate": "rate"
                      },
                      "hoursWorked": "hoursWorked",
                      "regularPay": "regularPay",
                      "overtimePay": "overtimePay",
                      "overtimeHours": "overtimeHours",
                      "straightTimeEarnings": "straightTimeEarnings",
                      "overtimePremium": "overtimePremium",
                      "additions": [
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        },
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        }
                      ],
                      "deductions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        },
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "totalWages": "totalWages"
                    },
                    {
                      "runId": "runId",
                      "periodStart": "periodStart",
                      "periodEnd": "periodEnd",
                      "payDate": "2023-01-15",
                      "basisOfPay": {
                        "salaryType": "salaryType",
                        "rate": "rate"
                      },
                      "hoursWorked": "hoursWorked",
                      "regularPay": "regularPay",
                      "overtimePay": "overtimePay",
                      "overtimeHours": "overtimeHours",
                      "straightTimeEarnings": "straightTimeEarnings",
                      "overtimePremium": "overtimePremium",
                      "additions": [
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        },
                        {
                          "name": "name",
                          "paymentType": "paymentType",
                          "amount": "amount",
                          "hours": "hours"
                        }
                      ],
                      "deductions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        },
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "totalWages": "totalWages"
                    }
                  ]
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/flsa-records/list")
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

        var response = await Client.Declarations.UsFlsaRecordsListAsync(
            new UsFlsaRecordsListDeclarationsRequest
            {
                From = new DateOnly(2023, 1, 15),
                To = new DateOnly(2023, 1, 15),
                EmployeeId = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "2026-07-01",
              "to": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "from": "from",
              "to": "to",
              "employees": [
                {
                  "employeeId": "employeeId",
                  "code": "code",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "address": {},
                  "birthDate": "2026-07-01",
                  "sex": "M",
                  "occupation": "occupation",
                  "workweekStart": {
                    "day": "day"
                  },
                  "exempt": true,
                  "workweeks": [
                    {
                      "start": "start",
                      "end": "end",
                      "hours": "hours",
                      "overtimeHours": "overtimeHours",
                      "days": [
                        {
                          "date": "2026-07-01",
                          "hours": "hours"
                        }
                      ]
                    }
                  ],
                  "payPeriods": [
                    {
                      "runId": "runId",
                      "periodStart": "periodStart",
                      "periodEnd": "periodEnd",
                      "payDate": "2026-07-01",
                      "regularPay": "regularPay",
                      "overtimePay": "overtimePay",
                      "overtimeHours": "overtimeHours",
                      "additions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "deductions": [
                        {
                          "name": "name",
                          "amount": "amount"
                        }
                      ],
                      "totalWages": "totalWages"
                    }
                  ]
                }
              ],
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/flsa-records/list")
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

        var response = await Client.Declarations.UsFlsaRecordsListAsync(
            new UsFlsaRecordsListDeclarationsRequest
            {
                From = new DateOnly(2026, 7, 1),
                To = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
