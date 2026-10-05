using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BooksValidateMigrationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("dryRun")]
    public required bool DryRun { get; set; }

    [JsonPropertyName("cutoverDate")]
    public required DateOnly CutoverDate { get; set; }

    [JsonPropertyName("accounts")]
    public required BooksValidateMigrationResponseAccounts Accounts { get; set; }

    [JsonPropertyName("partners")]
    public required BooksValidateMigrationResponsePartners Partners { get; set; }

    [JsonPropertyName("items")]
    public required BooksValidateMigrationResponseItems Items { get; set; }

    [JsonPropertyName("assetGroups")]
    public required BooksValidateMigrationResponseAssetGroups AssetGroups { get; set; }

    [JsonPropertyName("openingBalances")]
    public BooksValidateMigrationResponseOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public required BooksValidateMigrationResponseJournal Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public required BooksValidateMigrationResponseOpenReceivables OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public required BooksValidateMigrationResponseOpenPayables OpenPayables { get; set; }

    [JsonPropertyName("fixedAssets")]
    public required BooksValidateMigrationResponseFixedAssets FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public required BooksValidateMigrationResponseStock Stock { get; set; }

    [JsonPropertyName("numberSeries")]
    public IEnumerable<BooksValidateMigrationResponseNumberSeriesItem> NumberSeries { get; set; } =
        new List<BooksValidateMigrationResponseNumberSeriesItem>();

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
