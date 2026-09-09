using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DocumentSeriesListRequest
{
    [JsonPropertyName("page")]
    public long? Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    [JsonPropertyName("sort")]
    public IEnumerable<PostV1DocumentSeriesListRequestSortItem>? Sort { get; set; }

    [JsonPropertyName("filter")]
    public IEnumerable<PostV1DocumentSeriesListRequestFilterItem>? Filter { get; set; }

    /// <summary>
    /// Numeric fields to sum over every row matching the filter (not only the current page)
    /// </summary>
    [JsonPropertyName("totals")]
    public IEnumerable<string>? Totals { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
