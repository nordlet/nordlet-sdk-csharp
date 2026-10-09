using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BusinessTripsListHrRequest
{
    [JsonPropertyName("page")]
    public long? Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    [JsonPropertyName("sort")]
    public IEnumerable<BusinessTripsListHrRequestSortItem>? Sort { get; set; }

    [JsonPropertyName("filter")]
    public IEnumerable<BusinessTripsListHrRequestFilterItem>? Filter { get; set; }

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
