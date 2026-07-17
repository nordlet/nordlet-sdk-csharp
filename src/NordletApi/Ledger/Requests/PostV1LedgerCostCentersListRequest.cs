using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerCostCentersListRequest
{
    [JsonPropertyName("page")]
    public long? Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    [JsonPropertyName("sort")]
    public IEnumerable<PostV1LedgerCostCentersListRequestSortItem>? Sort { get; set; }

    [JsonPropertyName("filter")]
    public IEnumerable<PostV1LedgerCostCentersListRequestFilterItem>? Filter { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
