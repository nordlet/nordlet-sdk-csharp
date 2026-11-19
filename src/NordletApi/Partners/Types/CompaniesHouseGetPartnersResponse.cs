using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesHouseGetPartnersResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("companyNumber")]
    public required string CompanyNumber { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("jurisdiction")]
    public string? Jurisdiction { get; set; }

    [JsonPropertyName("incorporatedOn")]
    public string? IncorporatedOn { get; set; }

    [JsonPropertyName("ceasedOn")]
    public string? CeasedOn { get; set; }

    [JsonPropertyName("address")]
    public CompaniesHouseGetPartnersResponseAddress? Address { get; set; }

    [JsonPropertyName("accountingReferenceDate")]
    public CompaniesHouseGetPartnersResponseAccountingReferenceDate? AccountingReferenceDate { get; set; }

    [JsonPropertyName("nextAccountsDue")]
    public string? NextAccountsDue { get; set; }

    [JsonPropertyName("nextConfirmationStatementDue")]
    public string? NextConfirmationStatementDue { get; set; }

    [JsonPropertyName("sicCodes")]
    public IEnumerable<string> SicCodes { get; set; } = new List<string>();

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
