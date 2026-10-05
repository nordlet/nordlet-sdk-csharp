using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StatementRowsListLedgerResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("scheme")]
    public required StatementRowsListLedgerResponseScheme Scheme { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<StatementRowsListLedgerResponseAccountsItem> Accounts { get; set; } =
        new List<StatementRowsListLedgerResponseAccountsItem>();

    [JsonPropertyName("rows")]
    public IEnumerable<StatementRowsListLedgerResponseRowsItem> Rows { get; set; } =
        new List<StatementRowsListLedgerResponseRowsItem>();

    [JsonPropertyName("unmapped")]
    public IEnumerable<string> Unmapped { get; set; } = new List<string>();

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
