using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatAccountsReportsResponseAccountsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; set; }

    [JsonPropertyName("rules")]
    public IEnumerable<VatAccountsReportsResponseAccountsItemRulesItem> Rules { get; set; } =
        new List<VatAccountsReportsResponseAccountsItemRulesItem>();

    [JsonPropertyName("side")]
    public required VatAccountsReportsResponseAccountsItemSide Side { get; set; }

    [JsonPropertyName("posted")]
    public required string Posted { get; set; }

    [JsonPropertyName("expected")]
    public required string Expected { get; set; }

    [JsonPropertyName("difference")]
    public required string Difference { get; set; }

    [JsonPropertyName("settlements")]
    public required string Settlements { get; set; }

    [JsonPropertyName("byDocumentType")]
    public IEnumerable<VatAccountsReportsResponseAccountsItemByDocumentTypeItem> ByDocumentType { get; set; } =
        new List<VatAccountsReportsResponseAccountsItemByDocumentTypeItem>();

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
