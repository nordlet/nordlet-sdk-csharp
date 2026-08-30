using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1MigrationBooksValidateRequest
{
    [JsonPropertyName("cutoverDate")]
    public required string CutoverDate { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("accounts")]
    public IEnumerable<PostV1MigrationBooksValidateRequestAccountsItem>? Accounts { get; set; }

    [JsonPropertyName("partners")]
    public IEnumerable<PostV1MigrationBooksValidateRequestPartnersItem>? Partners { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PostV1MigrationBooksValidateRequestItemsItem>? Items { get; set; }

    [JsonPropertyName("openingBalances")]
    public PostV1MigrationBooksValidateRequestOpeningBalances? OpeningBalances { get; set; }

    [JsonPropertyName("journal")]
    public IEnumerable<PostV1MigrationBooksValidateRequestJournalItem>? Journal { get; set; }

    [JsonPropertyName("openReceivables")]
    public IEnumerable<PostV1MigrationBooksValidateRequestOpenReceivablesItem>? OpenReceivables { get; set; }

    [JsonPropertyName("openPayables")]
    public IEnumerable<PostV1MigrationBooksValidateRequestOpenPayablesItem>? OpenPayables { get; set; }

    [JsonPropertyName("assetGroups")]
    public IEnumerable<PostV1MigrationBooksValidateRequestAssetGroupsItem>? AssetGroups { get; set; }

    [JsonPropertyName("fixedAssets")]
    public IEnumerable<PostV1MigrationBooksValidateRequestFixedAssetsItem>? FixedAssets { get; set; }

    [JsonPropertyName("stock")]
    public IEnumerable<PostV1MigrationBooksValidateRequestStockItem>? Stock { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
