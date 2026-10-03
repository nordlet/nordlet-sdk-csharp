using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerStatementRowsListResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("scheme")]
    public required PostV1LedgerStatementRowsListResponseScheme Scheme { get; set; }

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<PostV1LedgerStatementRowsListResponseAccountsItem> Accounts { get; set; } =
        new List<PostV1LedgerStatementRowsListResponseAccountsItem>();

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1LedgerStatementRowsListResponseRowsItem> Rows { get; set; } =
        new List<PostV1LedgerStatementRowsListResponseRowsItem>();

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
