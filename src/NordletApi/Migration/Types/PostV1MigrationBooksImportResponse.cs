using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1MigrationBooksImportResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("dryRun")]
    public required bool DryRun { get; set; }

    [JsonPropertyName("cutoverDate")]
    public required string CutoverDate { get; set; }

    [JsonPropertyName("accounts")]
    public required PostV1MigrationBooksImportResponseAccounts Accounts { get; set; }

    [JsonPropertyName("partners")]
    public required PostV1MigrationBooksImportResponsePartners Partners { get; set; }

    [JsonPropertyName("items")]
    public required PostV1MigrationBooksImportResponseItems Items { get; set; }

    [JsonPropertyName("assetGroups")]
    public required PostV1MigrationBooksImportResponseAssetGroups AssetGroups { get; set; }

    [JsonPropertyName("openingBalances")]
    public PostV1MigrationBooksImportResponseOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public required PostV1MigrationBooksImportResponseJournal Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public required PostV1MigrationBooksImportResponseOpenReceivables OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public required PostV1MigrationBooksImportResponseOpenPayables OpenPayables { get; set; }

    [JsonPropertyName("fixedAssets")]
    public required PostV1MigrationBooksImportResponseFixedAssets FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public required PostV1MigrationBooksImportResponseStock Stock { get; set; }

    [JsonPropertyName("numberSeries")]
    public IEnumerable<PostV1MigrationBooksImportResponseNumberSeriesItem> NumberSeries { get; set; } =
        new List<PostV1MigrationBooksImportResponseNumberSeriesItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
