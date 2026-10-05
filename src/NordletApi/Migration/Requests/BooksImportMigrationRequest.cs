using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BooksImportMigrationRequest
{
    [JsonPropertyName("cutoverDate")]
    public required DateOnly CutoverDate { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<BooksImportMigrationRequestAccountsItem>? Accounts { get; set; }

    [JsonPropertyName("partners")]
    public IEnumerable<BooksImportMigrationRequestPartnersItem>? Partners { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<BooksImportMigrationRequestItemsItem>? Items { get; set; }

    [JsonPropertyName("openingBalances")]
    public BooksImportMigrationRequestOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public IEnumerable<BooksImportMigrationRequestJournalItem>? Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public IEnumerable<BooksImportMigrationRequestOpenReceivablesItem>? OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public IEnumerable<BooksImportMigrationRequestOpenPayablesItem>? OpenPayables { get; set; }

    [JsonPropertyName("assetGroups")]
    public IEnumerable<BooksImportMigrationRequestAssetGroupsItem>? AssetGroups { get; set; }

    [JsonPropertyName("fixedAssets")]
    public IEnumerable<BooksImportMigrationRequestFixedAssetsItem>? FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public IEnumerable<BooksImportMigrationRequestStockItem>? Stock { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
