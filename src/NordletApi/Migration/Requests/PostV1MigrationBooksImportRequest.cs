using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1MigrationBooksImportRequest
{
    [JsonPropertyName("cutoverDate")]
    public required string CutoverDate { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<PostV1MigrationBooksImportRequestAccountsItem>? Accounts { get; set; }

    [JsonPropertyName("partners")]
    public IEnumerable<PostV1MigrationBooksImportRequestPartnersItem>? Partners { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PostV1MigrationBooksImportRequestItemsItem>? Items { get; set; }

    [JsonPropertyName("openingBalances")]
    public PostV1MigrationBooksImportRequestOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public IEnumerable<PostV1MigrationBooksImportRequestJournalItem>? Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public IEnumerable<PostV1MigrationBooksImportRequestOpenReceivablesItem>? OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public IEnumerable<PostV1MigrationBooksImportRequestOpenPayablesItem>? OpenPayables { get; set; }

    [JsonPropertyName("assetGroups")]
    public IEnumerable<PostV1MigrationBooksImportRequestAssetGroupsItem>? AssetGroups { get; set; }

    [JsonPropertyName("fixedAssets")]
    public IEnumerable<PostV1MigrationBooksImportRequestFixedAssetsItem>? FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public IEnumerable<PostV1MigrationBooksImportRequestStockItem>? Stock { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
