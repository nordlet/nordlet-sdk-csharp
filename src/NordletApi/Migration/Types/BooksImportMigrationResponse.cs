using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BooksImportMigrationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("dryRun")]
    public required bool DryRun { get; set; }

    [JsonPropertyName("cutoverDate")]
    public required DateOnly CutoverDate { get; set; }

    [JsonPropertyName("accounts")]
    public required BooksImportMigrationResponseAccounts Accounts { get; set; }

    [JsonPropertyName("partners")]
    public required BooksImportMigrationResponsePartners Partners { get; set; }

    [JsonPropertyName("items")]
    public required BooksImportMigrationResponseItems Items { get; set; }

    [JsonPropertyName("assetGroups")]
    public required BooksImportMigrationResponseAssetGroups AssetGroups { get; set; }

    [JsonPropertyName("openingBalances")]
    public BooksImportMigrationResponseOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public required BooksImportMigrationResponseJournal Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public required BooksImportMigrationResponseOpenReceivables OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public required BooksImportMigrationResponseOpenPayables OpenPayables { get; set; }

    [JsonPropertyName("fixedAssets")]
    public required BooksImportMigrationResponseFixedAssets FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public required BooksImportMigrationResponseStock Stock { get; set; }

    [JsonPropertyName("numberSeries")]
    public IEnumerable<BooksImportMigrationResponseNumberSeriesItem> NumberSeries { get; set; } =
        new List<BooksImportMigrationResponseNumberSeriesItem>();

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
