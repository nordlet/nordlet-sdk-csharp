using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItInailAutoliquidazioneComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "tassoRegolazione",
                  "tassoRata": "tassoRata"
                },
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "tassoRegolazione",
                  "tassoRata": "tassoRata"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "employees": 1000000,
                  "retribuzioni": "retribuzioni",
                  "quoteEsenti": "quoteEsenti",
                  "imponibileRegolazione": "imponibileRegolazione",
                  "premioRegolazione": "premioRegolazione",
                  "riduzioneRegolazione": "riduzioneRegolazione",
                  "totaleRegolazione": "totaleRegolazione",
                  "imponibileRata": "imponibileRata",
                  "premioRata": "premioRata",
                  "riduzioneRata": "riduzioneRata",
                  "totaleRata": "totaleRata"
                },
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "employees": 1000000,
                  "retribuzioni": "retribuzioni",
                  "quoteEsenti": "quoteEsenti",
                  "imponibileRegolazione": "imponibileRegolazione",
                  "premioRegolazione": "premioRegolazione",
                  "riduzioneRegolazione": "riduzioneRegolazione",
                  "totaleRegolazione": "totaleRegolazione",
                  "imponibileRata": "imponibileRata",
                  "premioRata": "premioRata",
                  "riduzioneRata": "riduzioneRata",
                  "totaleRata": "totaleRata"
                }
              ],
              "regolazione": {
                "totale": "totale",
                "addizionale": "addizionale",
                "rataAnticipata": "rataAnticipata",
                "importo": "importo"
              },
              "rata": {
                "totale": "totale",
                "addizionale": "addizionale",
                "importo": "importo"
              },
              "total": "total",
              "instalments": [
                {
                  "number": 1000000,
                  "dueDate": "2023-01-15",
                  "amount": "amount",
                  "interest": "interest"
                },
                {
                  "number": 1000000,
                  "dueDate": "2023-01-15",
                  "amount": "amount",
                  "interest": "interest"
                }
              ],
              "f24": [
                {
                  "codiceSede": "codiceSede",
                  "codiceDitta": "codiceDitta",
                  "cc": "cc",
                  "numeroRiferimento": "numeroRiferimento",
                  "causale": "causale",
                  "importo": "importo",
                  "credito": true
                },
                {
                  "codiceSede": "codiceSede",
                  "codiceDitta": "codiceDitta",
                  "cc": "cc",
                  "numeroRiferimento": "numeroRiferimento",
                  "causale": "causale",
                  "importo": "importo",
                  "credito": true
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/inail/autoliquidazione/compute")
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

        var response = await Client.Declarations.ItInailAutoliquidazioneComputeAsync(
            new ItInailAutoliquidazioneComputeDeclarationsRequest
            {
                Year = 1000000,
                Positions =
                    new List<ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem>()
                    {
                        new ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem
                        {
                            Pat = "pat",
                            PatControlCode = "patControlCode",
                            Voce = "voce",
                            TassoRegolazione = "tassoRegolazione",
                            TassoRata = "tassoRata",
                            RiduzioneRegolazione = null,
                            RiduzioneRata = null,
                            QuoteEsenti = null,
                            RetribuzioniRata = null,
                            EmployeeIds = null,
                        },
                        new ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem
                        {
                            Pat = "pat",
                            PatControlCode = "patControlCode",
                            Voce = "voce",
                            TassoRegolazione = "tassoRegolazione",
                            TassoRata = "tassoRata",
                            RiduzioneRegolazione = null,
                            RiduzioneRata = null,
                            QuoteEsenti = null,
                            RetribuzioniRata = null,
                            EmployeeIds = null,
                        },
                    },
                RataAnticipata = null,
                Rateazione = null,
                CodiceDitta = null,
                CodiceDittaControlCode = null,
                SedeInail = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "121.00000",
                  "tassoRata": "121.00000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "employees": 1000000,
                  "retribuzioni": "retribuzioni",
                  "quoteEsenti": "quoteEsenti",
                  "imponibileRegolazione": "imponibileRegolazione",
                  "premioRegolazione": "premioRegolazione",
                  "riduzioneRegolazione": "riduzioneRegolazione",
                  "totaleRegolazione": "totaleRegolazione",
                  "imponibileRata": "imponibileRata",
                  "premioRata": "premioRata",
                  "riduzioneRata": "riduzioneRata",
                  "totaleRata": "totaleRata"
                }
              ],
              "regolazione": {
                "totale": "totale",
                "addizionale": "addizionale",
                "rataAnticipata": "rataAnticipata",
                "importo": "importo"
              },
              "rata": {
                "totale": "totale",
                "addizionale": "addizionale",
                "importo": "importo"
              },
              "total": "total",
              "instalments": [
                {
                  "number": 1000000,
                  "dueDate": "2026-07-01",
                  "amount": "amount",
                  "interest": "interest"
                }
              ],
              "f24": [
                {
                  "codiceSede": "codiceSede",
                  "codiceDitta": "codiceDitta",
                  "cc": "cc",
                  "numeroRiferimento": "numeroRiferimento",
                  "causale": "causale",
                  "importo": "importo",
                  "credito": true
                }
              ],
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/inail/autoliquidazione/compute")
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

        var response = await Client.Declarations.ItInailAutoliquidazioneComputeAsync(
            new ItInailAutoliquidazioneComputeDeclarationsRequest
            {
                Year = 1000000,
                Positions =
                    new List<ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem>()
                    {
                        new ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem
                        {
                            Pat = "pat",
                            PatControlCode = "patControlCode",
                            Voce = "voce",
                            TassoRegolazione = "121.00000",
                            TassoRata = "121.00000",
                        },
                    },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
