using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DeReturnFactsSetDeclarationsResponseFacts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("changedShareholderIds")]
    public IEnumerable<string>? ChangedShareholderIds { get; set; }

    [JsonPropertyName("shareholderContracts")]
    public bool? ShareholderContracts { get; set; }

    [JsonPropertyName("contracts")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsContractsItem>? Contracts { get; set; }

    [JsonPropertyName("harmfulShareAcquisition")]
    public bool? HarmfulShareAcquisition { get; set; }

    [JsonPropertyName("coronaAid")]
    public string? CoronaAid { get; set; }

    [JsonPropertyName("lossCarryback")]
    public string? LossCarryback { get; set; }

    [JsonPropertyName("donationCarryforward")]
    public string? DonationCarryforward { get; set; }

    [JsonPropertyName("contributionAccountOpening")]
    public string? ContributionAccountOpening { get; set; }

    [JsonPropertyName("contributions")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsContributionsItem>? Contributions { get; set; }

    [JsonPropertyName("distributions")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsDistributionsItem>? Distributions { get; set; }

    [JsonPropertyName("taxBalanceEquity")]
    public string? TaxBalanceEquity { get; set; }

    [JsonPropertyName("multipleMunicipalities")]
    public bool? MultipleMunicipalities { get; set; }

    [JsonPropertyName("relocation")]
    public DeReturnFactsSetDeclarationsResponseFactsRelocation? Relocation { get; set; }

    [JsonPropertyName("municipalities")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsMunicipalitiesItem>? Municipalities { get; set; }

    [JsonPropertyName("landHoldings")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsLandHoldingsItem>? LandHoldings { get; set; }

    [JsonPropertyName("propertyTaxExpense")]
    public string? PropertyTaxExpense { get; set; }

    [JsonPropertyName("licencesToNonResidents")]
    public string? LicencesToNonResidents { get; set; }

    [JsonPropertyName("participations")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsParticipationsItem>? Participations { get; set; }

    [JsonPropertyName("foreignIncome")]
    public IEnumerable<DeReturnFactsSetDeclarationsResponseFactsForeignIncomeItem>? ForeignIncome { get; set; }

    [JsonPropertyName("smallBusinessSwitchDate")]
    public DateOnly? SmallBusinessSwitchDate { get; set; }

    [JsonPropertyName("refundProcedureApplied")]
    public bool? RefundProcedureApplied { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    [JsonPropertyName("representative")]
    public DeReturnFactsSetDeclarationsResponseFactsRepresentative? Representative { get; set; }

    [JsonPropertyName("singleTransportTax")]
    public string? SingleTransportTax { get; set; }

    [JsonPropertyName("distanceSales")]
    public string? DistanceSales { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
