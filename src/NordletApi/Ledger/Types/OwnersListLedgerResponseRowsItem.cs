using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record OwnersListLedgerResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("equityAccountCode")]
    public required string EquityAccountCode { get; set; }

    [JsonPropertyName("sharesQuantity")]
    public string? SharesQuantity { get; set; }

    [JsonPropertyName("sharesAmount")]
    public string? SharesAmount { get; set; }

    [JsonPropertyName("sharesType")]
    public string? SharesType { get; set; }

    [JsonPropertyName("sharesAcquisitionDate")]
    public DateOnly? SharesAcquisitionDate { get; set; }

    [JsonPropertyName("withholdingTaxPercent")]
    public string? WithholdingTaxPercent { get; set; }

    [JsonPropertyName("partnerLiability")]
    public OwnersListLedgerResponseRowsItemPartnerLiability? PartnerLiability { get; set; }

    [JsonPropertyName("specialBalanceRequired")]
    public bool? SpecialBalanceRequired { get; set; }

    [JsonPropertyName("supplementaryBalanceRequired")]
    public bool? SupplementaryBalanceRequired { get; set; }

    [JsonPropertyName("address")]
    public OwnersListLedgerResponseRowsItemAddress? Address { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
