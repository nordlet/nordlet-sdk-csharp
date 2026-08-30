using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1MigrationBooksValidateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("dryRun")]
    public required bool DryRun { get; set; }

    [JsonPropertyName("cutoverDate")]
    public required string CutoverDate { get; set; }

    [JsonPropertyName("accounts")]
    public required PostV1MigrationBooksValidateResponseAccounts Accounts { get; set; }

    [JsonPropertyName("partners")]
    public required PostV1MigrationBooksValidateResponsePartners Partners { get; set; }

    [JsonPropertyName("items")]
    public required PostV1MigrationBooksValidateResponseItems Items { get; set; }

    [JsonPropertyName("assetGroups")]
    public required PostV1MigrationBooksValidateResponseAssetGroups AssetGroups { get; set; }

    [JsonPropertyName("openingBalances")]
    public PostV1MigrationBooksValidateResponseOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public required PostV1MigrationBooksValidateResponseJournal Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public required PostV1MigrationBooksValidateResponseOpenReceivables OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public required PostV1MigrationBooksValidateResponseOpenPayables OpenPayables { get; set; }

    [JsonPropertyName("fixedAssets")]
    public required PostV1MigrationBooksValidateResponseFixedAssets FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public required PostV1MigrationBooksValidateResponseStock Stock { get; set; }

    [JsonPropertyName("numberSeries")]
    public IEnumerable<PostV1MigrationBooksValidateResponseNumberSeriesItem> NumberSeries { get; set; } =
        new List<PostV1MigrationBooksValidateResponseNumberSeriesItem>();

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
