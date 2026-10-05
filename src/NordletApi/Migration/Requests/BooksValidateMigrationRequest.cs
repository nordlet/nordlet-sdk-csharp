using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BooksValidateMigrationRequest
{
    [JsonPropertyName("cutoverDate")]
    public required DateOnly CutoverDate { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<BooksValidateMigrationRequestAccountsItem>? Accounts { get; set; }

    [JsonPropertyName("partners")]
    public IEnumerable<BooksValidateMigrationRequestPartnersItem>? Partners { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<BooksValidateMigrationRequestItemsItem>? Items { get; set; }

    [JsonPropertyName("openingBalances")]
    public BooksValidateMigrationRequestOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public IEnumerable<BooksValidateMigrationRequestJournalItem>? Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public IEnumerable<BooksValidateMigrationRequestOpenReceivablesItem>? OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public IEnumerable<BooksValidateMigrationRequestOpenPayablesItem>? OpenPayables { get; set; }

    [JsonPropertyName("assetGroups")]
    public IEnumerable<BooksValidateMigrationRequestAssetGroupsItem>? AssetGroups { get; set; }

    [JsonPropertyName("fixedAssets")]
    public IEnumerable<BooksValidateMigrationRequestFixedAssetsItem>? FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public IEnumerable<BooksValidateMigrationRequestStockItem>? Stock { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
